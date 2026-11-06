#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: OnlineGameInterfaceImpl<br/>
/// (size = 588)
/// (flags = 134217878)
/// </summary>
public partial class OnlineGameInterfaceImpl : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.OnlineGameInterfaceImpl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as OnlineGameInterfaceImpl.
    /// </summary>
    public static OnlineGameInterfaceImpl DefaultObject => (OnlineGameInterfaceImpl)StaticClass().DefaultObject;

    internal OnlineGameInterfaceImpl() { }

    /// <summary>
    /// Constructs a new OnlineGameInterfaceImpl
    /// </summary>
    public OnlineGameInterfaceImpl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineGameInterfaceImpl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineGameInterfaceImpl(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ClearQosStatusChangedDelegate;
    /// <summary>
    /// Function: ClearQosStatusChangedDelegate
    /// </summary>
    public unsafe virtual void ClearQosStatusChangedDelegate(System.IntPtr QosStatusChangedDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearQosStatusChangedDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearQosStatusChangedDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QosStatusChangedDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddQosStatusChangedDelegate;
    /// <summary>
    /// Function: AddQosStatusChangedDelegate
    /// </summary>
    public unsafe virtual void AddQosStatusChangedDelegate(System.IntPtr QosStatusChangedDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddQosStatusChangedDelegate, "IpDrv.OnlineGameInterfaceImpl.AddQosStatusChangedDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QosStatusChangedDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnQosStatusChanged;
    /// <summary>
    /// Function: OnQosStatusChanged
    /// </summary>
    public unsafe virtual void OnQosStatusChanged(int NumComplete, int NumTotal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnQosStatusChanged, "IpDrv.OnlineGameInterfaceImpl.OnQosStatusChanged");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumComplete, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumTotal, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BindPlatformSpecificSessionToSearch;
    /// <summary>
    /// Function: BindPlatformSpecificSessionToSearch
    /// </summary>
    public unsafe virtual bool BindPlatformSpecificSessionToSearch(byte SearchingPlayerNum, BmSDK.Engine.OnlineGameSearch SearchSettings, byte PlatformSpecificInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BindPlatformSpecificSessionToSearch, "IpDrv.OnlineGameInterfaceImpl.BindPlatformSpecificSessionToSearch");
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchingPlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchSettings, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 92);
    }

    private static BmSDK.Function __fn_ReadPlatformSpecificSessionInfoBySessionName;
    /// <summary>
    /// Function: ReadPlatformSpecificSessionInfoBySessionName
    /// </summary>
    public unsafe virtual bool ReadPlatformSpecificSessionInfoBySessionName(BmSDK.FName SessionName, out byte PlatformSpecificInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadPlatformSpecificSessionInfoBySessionName, "IpDrv.OnlineGameInterfaceImpl.ReadPlatformSpecificSessionInfoBySessionName");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlatformSpecificInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PlatformSpecificInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_ReadPlatformSpecificSessionInfo;
    /// <summary>
    /// Function: ReadPlatformSpecificSessionInfo
    /// </summary>
    public unsafe virtual bool ReadPlatformSpecificSessionInfo(out BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult DesiredGame, out byte PlatformSpecificInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadPlatformSpecificSessionInfo, "IpDrv.OnlineGameInterfaceImpl.ReadPlatformSpecificSessionInfo");
        byte* paramsPtr = stackalloc byte[100];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DesiredGame);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredGame, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlatformSpecificInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DesiredGame = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult>(paramsPtr + 0);
        PlatformSpecificInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_QueryNonAdvertisedData;
    /// <summary>
    /// Function: QueryNonAdvertisedData
    /// </summary>
    public unsafe virtual bool QueryNonAdvertisedData(int StartAt, int NumberToQuery)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueryNonAdvertisedData, "IpDrv.OnlineGameInterfaceImpl.QueryNonAdvertisedData");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartAt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumberToQuery, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearJoinMigratedOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearJoinMigratedOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearJoinMigratedOnlineGameCompleteDelegate(System.IntPtr JoinMigratedOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearJoinMigratedOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearJoinMigratedOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinMigratedOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddJoinMigratedOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddJoinMigratedOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddJoinMigratedOnlineGameCompleteDelegate(System.IntPtr JoinMigratedOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJoinMigratedOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddJoinMigratedOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinMigratedOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnJoinMigratedOnlineGameComplete;
    /// <summary>
    /// Function: OnJoinMigratedOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnJoinMigratedOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnJoinMigratedOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnJoinMigratedOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JoinMigratedOnlineGame;
    /// <summary>
    /// Function: JoinMigratedOnlineGame
    /// </summary>
    public unsafe virtual bool JoinMigratedOnlineGame(byte PlayerNum, BmSDK.FName SessionName, out BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult DesiredGame)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JoinMigratedOnlineGame, "IpDrv.OnlineGameInterfaceImpl.JoinMigratedOnlineGame");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DesiredGame);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredGame, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DesiredGame = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ClearMigrateOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearMigrateOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearMigrateOnlineGameCompleteDelegate(System.IntPtr MigrateOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMigrateOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearMigrateOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MigrateOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddMigrateOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddMigrateOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddMigrateOnlineGameCompleteDelegate(System.IntPtr MigrateOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMigrateOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddMigrateOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MigrateOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMigrateOnlineGameComplete;
    /// <summary>
    /// Function: OnMigrateOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnMigrateOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMigrateOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnMigrateOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MigrateOnlineGame;
    /// <summary>
    /// Function: MigrateOnlineGame
    /// </summary>
    public unsafe virtual bool MigrateOnlineGame(byte HostingPlayerNum, BmSDK.FName SessionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MigrateOnlineGame, "IpDrv.OnlineGameInterfaceImpl.MigrateOnlineGame");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HostingPlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearRecalculateSkillRatingCompleteDelegate;
    /// <summary>
    /// Function: ClearRecalculateSkillRatingCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearRecalculateSkillRatingCompleteDelegate(System.IntPtr RecalculateSkillRatingGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecalculateSkillRatingCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearRecalculateSkillRatingCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecalculateSkillRatingGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddRecalculateSkillRatingCompleteDelegate;
    /// <summary>
    /// Function: AddRecalculateSkillRatingCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRecalculateSkillRatingCompleteDelegate(System.IntPtr RecalculateSkillRatingCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRecalculateSkillRatingCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddRecalculateSkillRatingCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecalculateSkillRatingCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRecalculateSkillRatingComplete;
    /// <summary>
    /// Function: OnRecalculateSkillRatingComplete
    /// </summary>
    public unsafe virtual void OnRecalculateSkillRatingComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRecalculateSkillRatingComplete, "IpDrv.OnlineGameInterfaceImpl.OnRecalculateSkillRatingComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecalculateSkillRating;
    /// <summary>
    /// Function: RecalculateSkillRating
    /// </summary>
    public unsafe virtual bool RecalculateSkillRating(BmSDK.FName SessionName, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecalculateSkillRating, "IpDrv.OnlineGameInterfaceImpl.RecalculateSkillRating");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Players = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_AcceptGameInvite;
    /// <summary>
    /// Function: AcceptGameInvite
    /// </summary>
    public unsafe virtual bool AcceptGameInvite(byte LocalUserNum, BmSDK.FName SessionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AcceptGameInvite, "IpDrv.OnlineGameInterfaceImpl.AcceptGameInvite");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearGameInviteAcceptedDelegate;
    /// <summary>
    /// Function: ClearGameInviteAcceptedDelegate
    /// </summary>
    public unsafe virtual void ClearGameInviteAcceptedDelegate(byte LocalUserNum, System.IntPtr GameInviteAcceptedDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGameInviteAcceptedDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearGameInviteAcceptedDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameInviteAcceptedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGameInviteAcceptedDelegate;
    /// <summary>
    /// Function: AddGameInviteAcceptedDelegate
    /// </summary>
    public unsafe virtual void AddGameInviteAcceptedDelegate(byte LocalUserNum, System.IntPtr GameInviteAcceptedDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGameInviteAcceptedDelegate, "IpDrv.OnlineGameInterfaceImpl.AddGameInviteAcceptedDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameInviteAcceptedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGameInviteAccepted;
    /// <summary>
    /// Function: OnGameInviteAccepted
    /// </summary>
    public unsafe virtual void OnGameInviteAccepted(out BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult InviteResult)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGameInviteAccepted, "IpDrv.OnlineGameInterfaceImpl.OnGameInviteAccepted");
        byte* paramsPtr = stackalloc byte[16];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InviteResult);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteResult, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InviteResult = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetArbitratedPlayers;
    /// <summary>
    /// Function: GetArbitratedPlayers
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineArbitrationRegistrant> GetArbitratedPlayers(BmSDK.FName SessionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArbitratedPlayers, "IpDrv.OnlineGameInterfaceImpl.GetArbitratedPlayers");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineArbitrationRegistrant>>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearArbitrationRegistrationCompleteDelegate;
    /// <summary>
    /// Function: ClearArbitrationRegistrationCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearArbitrationRegistrationCompleteDelegate(System.IntPtr ArbitrationRegistrationCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearArbitrationRegistrationCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearArbitrationRegistrationCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArbitrationRegistrationCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddArbitrationRegistrationCompleteDelegate;
    /// <summary>
    /// Function: AddArbitrationRegistrationCompleteDelegate
    /// </summary>
    public unsafe virtual void AddArbitrationRegistrationCompleteDelegate(System.IntPtr ArbitrationRegistrationCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddArbitrationRegistrationCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddArbitrationRegistrationCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArbitrationRegistrationCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnArbitrationRegistrationComplete;
    /// <summary>
    /// Function: OnArbitrationRegistrationComplete
    /// </summary>
    public unsafe virtual void OnArbitrationRegistrationComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnArbitrationRegistrationComplete, "IpDrv.OnlineGameInterfaceImpl.OnArbitrationRegistrationComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterForArbitration;
    /// <summary>
    /// Function: RegisterForArbitration
    /// </summary>
    public unsafe virtual bool RegisterForArbitration(BmSDK.FName SessionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterForArbitration, "IpDrv.OnlineGameInterfaceImpl.RegisterForArbitration");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearEndOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearEndOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearEndOnlineGameCompleteDelegate(System.IntPtr EndOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearEndOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearEndOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddEndOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddEndOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddEndOnlineGameCompleteDelegate(System.IntPtr EndOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddEndOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddEndOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEndOnlineGameComplete;
    /// <summary>
    /// Function: OnEndOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnEndOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEndOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnEndOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndOnlineGame;
    /// <summary>
    /// Function: EndOnlineGame
    /// </summary>
    public unsafe virtual bool EndOnlineGame(BmSDK.FName SessionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndOnlineGame, "IpDrv.OnlineGameInterfaceImpl.EndOnlineGame");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearStartOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearStartOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearStartOnlineGameCompleteDelegate(System.IntPtr StartOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearStartOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearStartOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddStartOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddStartOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddStartOnlineGameCompleteDelegate(System.IntPtr StartOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddStartOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddStartOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnStartOnlineGameComplete;
    /// <summary>
    /// Function: OnStartOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnStartOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStartOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnStartOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartOnlineGame;
    /// <summary>
    /// Function: StartOnlineGame
    /// </summary>
    public unsafe virtual bool StartOnlineGame(BmSDK.FName SessionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartOnlineGame, "IpDrv.OnlineGameInterfaceImpl.StartOnlineGame");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearUnregisterPlayerCompleteDelegate;
    /// <summary>
    /// Function: ClearUnregisterPlayerCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearUnregisterPlayerCompleteDelegate(System.IntPtr UnregisterPlayerCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearUnregisterPlayerCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearUnregisterPlayerCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnregisterPlayerCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUnregisterPlayerCompleteDelegate;
    /// <summary>
    /// Function: AddUnregisterPlayerCompleteDelegate
    /// </summary>
    public unsafe virtual void AddUnregisterPlayerCompleteDelegate(System.IntPtr UnregisterPlayerCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUnregisterPlayerCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddUnregisterPlayerCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnregisterPlayerCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnUnregisterPlayerComplete;
    /// <summary>
    /// Function: OnUnregisterPlayerComplete
    /// </summary>
    public unsafe virtual void OnUnregisterPlayerComplete(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnUnregisterPlayerComplete, "IpDrv.OnlineGameInterfaceImpl.OnUnregisterPlayerComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterPlayers;
    /// <summary>
    /// Function: UnregisterPlayers
    /// </summary>
    public unsafe virtual bool UnregisterPlayers(BmSDK.FName SessionName, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterPlayers, "IpDrv.OnlineGameInterfaceImpl.UnregisterPlayers");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Players = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_UnregisterPlayer;
    /// <summary>
    /// Function: UnregisterPlayer
    /// </summary>
    public unsafe virtual bool UnregisterPlayer(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterPlayer, "IpDrv.OnlineGameInterfaceImpl.UnregisterPlayer");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ClearRegisterPlayerCompleteDelegate;
    /// <summary>
    /// Function: ClearRegisterPlayerCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearRegisterPlayerCompleteDelegate(System.IntPtr RegisterPlayerCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRegisterPlayerCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearRegisterPlayerCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterPlayerCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddRegisterPlayerCompleteDelegate;
    /// <summary>
    /// Function: AddRegisterPlayerCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRegisterPlayerCompleteDelegate(System.IntPtr RegisterPlayerCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRegisterPlayerCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddRegisterPlayerCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterPlayerCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRegisterPlayerComplete;
    /// <summary>
    /// Function: OnRegisterPlayerComplete
    /// </summary>
    public unsafe virtual void OnRegisterPlayerComplete(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRegisterPlayerComplete, "IpDrv.OnlineGameInterfaceImpl.OnRegisterPlayerComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterPlayers;
    /// <summary>
    /// Function: RegisterPlayers
    /// </summary>
    public unsafe virtual bool RegisterPlayers(BmSDK.FName SessionName, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPlayers, "IpDrv.OnlineGameInterfaceImpl.RegisterPlayers");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Players = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_RegisterPlayer;
    /// <summary>
    /// Function: RegisterPlayer
    /// </summary>
    public unsafe virtual bool RegisterPlayer(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasInvited)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPlayer, "IpDrv.OnlineGameInterfaceImpl.RegisterPlayer");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasInvited, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetResolvedConnectString;
    /// <summary>
    /// Function: GetResolvedConnectString
    /// </summary>
    public unsafe virtual bool GetResolvedConnectString(BmSDK.FName SessionName, out BmSDK.FString ConnectInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResolvedConnectString, "IpDrv.OnlineGameInterfaceImpl.GetResolvedConnectString");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ConnectInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClearJoinOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearJoinOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearJoinOnlineGameCompleteDelegate(System.IntPtr JoinOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearJoinOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearJoinOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddJoinOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddJoinOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddJoinOnlineGameCompleteDelegate(System.IntPtr JoinOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJoinOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddJoinOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnJoinOnlineGameComplete;
    /// <summary>
    /// Function: OnJoinOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnJoinOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnJoinOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnJoinOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JoinOnlineGame;
    /// <summary>
    /// Function: JoinOnlineGame
    /// </summary>
    public unsafe virtual bool JoinOnlineGame(byte PlayerNum, BmSDK.FName SessionName, out BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult DesiredGame)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JoinOnlineGame, "IpDrv.OnlineGameInterfaceImpl.JoinOnlineGame");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DesiredGame);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredGame, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DesiredGame = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_FreeSearchResults;
    /// <summary>
    /// Function: FreeSearchResults
    /// </summary>
    public unsafe virtual bool FreeSearchResults(BmSDK.Engine.OnlineGameSearch Search)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreeSearchResults, "IpDrv.OnlineGameInterfaceImpl.FreeSearchResults");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Search, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearCancelFindOnlineGamesCompleteDelegate;
    /// <summary>
    /// Function: ClearCancelFindOnlineGamesCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearCancelFindOnlineGamesCompleteDelegate(System.IntPtr CancelFindOnlineGamesCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCancelFindOnlineGamesCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearCancelFindOnlineGamesCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CancelFindOnlineGamesCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCancelFindOnlineGamesCompleteDelegate;
    /// <summary>
    /// Function: AddCancelFindOnlineGamesCompleteDelegate
    /// </summary>
    public unsafe virtual void AddCancelFindOnlineGamesCompleteDelegate(System.IntPtr CancelFindOnlineGamesCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCancelFindOnlineGamesCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddCancelFindOnlineGamesCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CancelFindOnlineGamesCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCancelFindOnlineGamesComplete;
    /// <summary>
    /// Function: OnCancelFindOnlineGamesComplete
    /// </summary>
    public unsafe virtual void OnCancelFindOnlineGamesComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCancelFindOnlineGamesComplete, "IpDrv.OnlineGameInterfaceImpl.OnCancelFindOnlineGamesComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelFindOnlineGames;
    /// <summary>
    /// Function: CancelFindOnlineGames
    /// </summary>
    public unsafe virtual bool CancelFindOnlineGames()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelFindOnlineGames, "IpDrv.OnlineGameInterfaceImpl.CancelFindOnlineGames");
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

    private static BmSDK.Function __fn_ClearFindOnlineGamesCompleteDelegate;
    /// <summary>
    /// Function: ClearFindOnlineGamesCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearFindOnlineGamesCompleteDelegate(System.IntPtr FindOnlineGamesCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFindOnlineGamesCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearFindOnlineGamesCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindOnlineGamesCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFindOnlineGamesCompleteDelegate;
    /// <summary>
    /// Function: AddFindOnlineGamesCompleteDelegate
    /// </summary>
    public unsafe virtual void AddFindOnlineGamesCompleteDelegate(System.IntPtr FindOnlineGamesCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFindOnlineGamesCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddFindOnlineGamesCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindOnlineGamesCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindOnlineGames;
    /// <summary>
    /// Function: FindOnlineGames
    /// </summary>
    public unsafe virtual bool FindOnlineGames(byte SearchingPlayerNum, BmSDK.Engine.OnlineGameSearch SearchSettings)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindOnlineGames, "IpDrv.OnlineGameInterfaceImpl.FindOnlineGames");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchingPlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchSettings, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearDestroyOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearDestroyOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearDestroyOnlineGameCompleteDelegate(System.IntPtr DestroyOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDestroyOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearDestroyOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestroyOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDestroyOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddDestroyOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddDestroyOnlineGameCompleteDelegate(System.IntPtr DestroyOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDestroyOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddDestroyOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestroyOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDestroyOnlineGameComplete;
    /// <summary>
    /// Function: OnDestroyOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnDestroyOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDestroyOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnDestroyOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyOnlineGame;
    /// <summary>
    /// Function: DestroyOnlineGame
    /// </summary>
    public unsafe virtual bool DestroyOnlineGame(BmSDK.FName SessionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyOnlineGame, "IpDrv.OnlineGameInterfaceImpl.DestroyOnlineGame");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearUpdateOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearUpdateOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearUpdateOnlineGameCompleteDelegate(System.IntPtr UpdateOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearUpdateOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearUpdateOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUpdateOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddUpdateOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddUpdateOnlineGameCompleteDelegate(System.IntPtr UpdateOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUpdateOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddUpdateOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnUpdateOnlineGameComplete;
    /// <summary>
    /// Function: OnUpdateOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnUpdateOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnUpdateOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnUpdateOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateOnlineGame;
    /// <summary>
    /// Function: UpdateOnlineGame
    /// </summary>
    public unsafe virtual bool UpdateOnlineGame(BmSDK.FName SessionName, BmSDK.Engine.OnlineGameSettings UpdatedGameSettings, bool bShouldRefreshOnlineData = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateOnlineGame, "IpDrv.OnlineGameInterfaceImpl.UpdateOnlineGame");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdatedGameSettings, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldRefreshOnlineData, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ClearCreateOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearCreateOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearCreateOnlineGameCompleteDelegate(System.IntPtr CreateOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCreateOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearCreateOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreateOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCreateOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddCreateOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddCreateOnlineGameCompleteDelegate(System.IntPtr CreateOnlineGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCreateOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddCreateOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreateOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCreateOnlineGameComplete;
    /// <summary>
    /// Function: OnCreateOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnCreateOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCreateOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnCreateOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateOnlineGame;
    /// <summary>
    /// Function: CreateOnlineGame
    /// </summary>
    public unsafe virtual bool CreateOnlineGame(byte HostingPlayerNum, BmSDK.FName SessionName, BmSDK.Engine.OnlineGameSettings NewGameSettings)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateOnlineGame, "IpDrv.OnlineGameInterfaceImpl.CreateOnlineGame");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HostingPlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGameSettings, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetGameSearch;
    /// <summary>
    /// Function: GetGameSearch
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineGameSearch GetGameSearch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameSearch, "IpDrv.OnlineGameInterfaceImpl.GetGameSearch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineGameSearch>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGameSettings;
    /// <summary>
    /// Function: GetGameSettings
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineGameSettings GetGameSettings(BmSDK.FName SessionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameSettings, "IpDrv.OnlineGameInterfaceImpl.GetGameSettings");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineGameSettings>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OnFindOnlineGamesComplete;
    /// <summary>
    /// Function: OnFindOnlineGamesComplete
    /// </summary>
    public unsafe virtual void OnFindOnlineGamesComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFindOnlineGamesComplete, "IpDrv.OnlineGameInterfaceImpl.OnFindOnlineGamesComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: OwningSubsystem
    /// </summary>
    public unsafe BmSDK.IpDrv.OnlineSubsystemCommonImpl OwningSubsystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.OnlineSubsystemCommonImpl>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: GameSettings
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSettings GameSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSettings>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: GameSearch
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSearch GameSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSearch>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: CreateOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> CreateOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: UpdateOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> UpdateOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: DestroyOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> DestroyOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: JoinOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> JoinOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: MigrateOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> MigrateOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ArrayProperty: JoinMigratedOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> JoinMigratedOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: RecalculateSkillRatingCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RecalculateSkillRatingCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ArrayProperty: StartOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> StartOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: EndOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> EndOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: FindOnlineGamesCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FindOnlineGamesCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ArrayProperty: CancelFindOnlineGamesCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> CancelFindOnlineGamesCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ByteProperty: LanBeaconState
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ELanBeaconState LanBeaconState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ELanBeaconState>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: LanNonce
    /// </summary>
    public InlineArray<byte> LanNonce => new(8, Ptr + 285, 1, this);

    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 285); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 285); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 286); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 286); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 287); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 287); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 289); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 289); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 290); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 290); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 291); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 291); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// IntProperty: LanAnnouncePort
    /// </summary>
    public unsafe int LanAnnouncePort
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// IntProperty: LanGameUniqueId
    /// </summary>
    public unsafe int LanGameUniqueId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// IntProperty: LanPacketPlatformMask
    /// </summary>
    public unsafe int LanPacketPlatformMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// FloatProperty: LanQueryTimeLeft
    /// </summary>
    public unsafe float LanQueryTimeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// FloatProperty: LanQueryTimeout
    /// </summary>
    public unsafe float LanQueryTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: LanBeacon
    /// </summary>
    public unsafe System.IntPtr LanBeacon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StructProperty: SessionInfo
    /// </summary>
    public unsafe System.IntPtr SessionInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// DelegateProperty: __OnFindOnlineGamesComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFindOnlineGamesComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// DelegateProperty: __OnCreateOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCreateOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// DelegateProperty: __OnUpdateOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUpdateOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// DelegateProperty: __OnDestroyOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDestroyOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// DelegateProperty: __OnCancelFindOnlineGamesComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCancelFindOnlineGamesComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// DelegateProperty: __OnJoinOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnJoinOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// DelegateProperty: __OnRegisterPlayerComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRegisterPlayerComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// DelegateProperty: __OnUnregisterPlayerComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUnregisterPlayerComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// DelegateProperty: __OnStartOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnStartOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// DelegateProperty: __OnEndOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnEndOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// DelegateProperty: __OnArbitrationRegistrationComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnArbitrationRegistrationComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// DelegateProperty: __OnGameInviteAccepted__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnGameInviteAccepted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// DelegateProperty: __OnRecalculateSkillRatingComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRecalculateSkillRatingComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// DelegateProperty: __OnMigrateOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnMigrateOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// DelegateProperty: __OnJoinMigratedOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnJoinMigratedOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// DelegateProperty: __OnQosStatusChanged__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnQosStatusChanged__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }
}
