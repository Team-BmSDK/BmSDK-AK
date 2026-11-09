#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CheatManager<br/>
/// (size = 136)
/// (flags = 134217906)
/// </summary>
public partial class CheatManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CheatManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as CheatManager.
    /// </summary>
    public static CheatManager DefaultObject => (CheatManager)StaticClass().DefaultObject;

    internal CheatManager() { }

    /// <summary>
    /// Constructs a new CheatManager
    /// </summary>
    public CheatManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CheatManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CheatManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CheatManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CheatManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CheatManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CheatManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CheatManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CheatManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CheatManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CheatManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnRequestComplete;
    /// <summary>
    /// Function: OnRequestComplete
    /// </summary>
    public unsafe virtual void OnRequestComplete(BmSDK.Engine.HttpRequestInterface OriginalRequest, BmSDK.Engine.HttpResponseInterface Response, bool bDidSucceed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRequestComplete, "Engine.CheatManager.OnRequestComplete");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalRequest, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Response, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDidSucceed, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestHttp;
    /// <summary>
    /// Function: TestHttp
    /// </summary>
    public unsafe virtual void TestHttp(BmSDK.FString Verb, BmSDK.FString Payload, BmSDK.FString URL, bool bSendParallelRequest = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestHttp, "Engine.CheatManager.TestHttp");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Verb, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Payload, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSendParallelRequest, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeleteUserFileComplete;
    /// <summary>
    /// Function: OnDeleteUserFileComplete
    /// </summary>
    public unsafe void OnDeleteUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeleteUserFileComplete, "Engine.CheatManager.OnDeleteUserFileComplete");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugDeleteUserFile;
    /// <summary>
    /// Function: DebugDeleteUserFile
    /// </summary>
    public unsafe virtual void DebugDeleteUserFile(BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugDeleteUserFile, "Engine.CheatManager.DebugDeleteUserFile");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadUserFileComplete;
    /// <summary>
    /// Function: OnReadUserFileComplete
    /// </summary>
    public unsafe void OnReadUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadUserFileComplete, "Engine.CheatManager.OnReadUserFileComplete");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugReadUserFile;
    /// <summary>
    /// Function: DebugReadUserFile
    /// </summary>
    public unsafe virtual void DebugReadUserFile(BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugReadUserFile, "Engine.CheatManager.DebugReadUserFile");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWriteUserFileComplete;
    /// <summary>
    /// Function: OnWriteUserFileComplete
    /// </summary>
    public unsafe void OnWriteUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWriteUserFileComplete, "Engine.CheatManager.OnWriteUserFileComplete");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugWriteUserFile;
    /// <summary>
    /// Function: DebugWriteUserFile
    /// </summary>
    public unsafe virtual void DebugWriteUserFile(BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugWriteUserFile, "Engine.CheatManager.DebugWriteUserFile");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEnumerateUserFilesComplete;
    /// <summary>
    /// Function: OnEnumerateUserFilesComplete
    /// </summary>
    public unsafe void OnEnumerateUserFilesComplete(bool bWasSuccessful, BmSDK.FString UserId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEnumerateUserFilesComplete, "Engine.CheatManager.OnEnumerateUserFilesComplete");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugQueryUserFiles;
    /// <summary>
    /// Function: DebugQueryUserFiles
    /// </summary>
    public unsafe virtual void DebugQueryUserFiles(BmSDK.FString UserId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugQueryUserFiles, "Engine.CheatManager.DebugQueryUserFiles");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReceivedLocalNotificationDebug;
    /// <summary>
    /// Function: OnReceivedLocalNotificationDebug
    /// </summary>
    public unsafe void OnReceivedLocalNotificationDebug(out BmSDK.Engine.AppNotificationsBase.FNotificationInfo Notification, bool bWasAppActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReceivedLocalNotificationDebug, "Engine.CheatManager.OnReceivedLocalNotificationDebug");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasAppActive, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Notification = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AppNotificationsBase.FNotificationInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DebugNotification;
    /// <summary>
    /// Function: DebugNotification
    /// </summary>
    public unsafe virtual void DebugNotification(BmSDK.FString MessageBody, int SecondsFromNow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugNotification, "Engine.CheatManager.DebugNotification");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageBody, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondsFromNow, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawLocationXYZ;
    /// <summary>
    /// Function: DrawLocationXYZ
    /// </summary>
    public unsafe virtual void DrawLocationXYZ(float X, float Y, float Z)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawLocationXYZ, "Engine.CheatManager.DrawLocationXYZ");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawLocation;
    /// <summary>
    /// Function: DrawLocation
    /// </summary>
    public unsafe virtual void DrawLocation(System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawLocation, "Engine.CheatManager.DrawLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TelemetryTogglePause;
    /// <summary>
    /// Function: TelemetryTogglePause
    /// </summary>
    public unsafe virtual void TelemetryTogglePause()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TelemetryTogglePause, "Engine.CheatManager.TelemetryTogglePause");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_DumpCoverStats;
    /// <summary>
    /// Function: DumpCoverStats
    /// </summary>
    public unsafe virtual void DumpCoverStats()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpCoverStats, "Engine.CheatManager.DumpCoverStats");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_DebugEmsDownload;
    /// <summary>
    /// Function: DebugEmsDownload
    /// </summary>
    public unsafe virtual void DebugEmsDownload()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugEmsDownload, "Engine.CheatManager.DebugEmsDownload");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugDeleteTitleFiles;
    /// <summary>
    /// Function: DebugDeleteTitleFiles
    /// </summary>
    public unsafe virtual void DebugDeleteTitleFiles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugDeleteTitleFiles, "Engine.CheatManager.DebugDeleteTitleFiles");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSaveComplete;
    /// <summary>
    /// Function: OnSaveComplete
    /// </summary>
    public unsafe virtual void OnSaveComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSaveComplete, "Engine.CheatManager.OnSaveComplete");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugSaveTitleFile;
    /// <summary>
    /// Function: DebugSaveTitleFile
    /// </summary>
    public unsafe virtual void DebugSaveTitleFile(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugSaveTitleFile, "Engine.CheatManager.DebugSaveTitleFile");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoadComplete;
    /// <summary>
    /// Function: OnLoadComplete
    /// </summary>
    public unsafe virtual void OnLoadComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoadComplete, "Engine.CheatManager.OnLoadComplete");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDownloadComplete;
    /// <summary>
    /// Function: OnDownloadComplete
    /// </summary>
    public unsafe virtual void OnDownloadComplete(bool bWasSuccessful, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDownloadComplete, "Engine.CheatManager.OnDownloadComplete");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugDownloadTitleFile;
    /// <summary>
    /// Function: DebugDownloadTitleFile
    /// </summary>
    public unsafe virtual void DebugDownloadTitleFile(BmSDK.FString Filename, bool bFromCache = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugDownloadTitleFile, "Engine.CheatManager.DebugDownloadTitleFile");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFromCache, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugIniLocPatcher;
    /// <summary>
    /// Function: DebugIniLocPatcher
    /// </summary>
    public unsafe virtual void DebugIniLocPatcher()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugIniLocPatcher, "Engine.CheatManager.DebugIniLocPatcher");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleAILogging;
    /// <summary>
    /// Function: ToggleAILogging
    /// </summary>
    public unsafe virtual void ToggleAILogging()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleAILogging, "Engine.CheatManager.ToggleAILogging");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VerifyNavMeshCoverRefs;
    /// <summary>
    /// Function: VerifyNavMeshCoverRefs
    /// </summary>
    public unsafe virtual void VerifyNavMeshCoverRefs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VerifyNavMeshCoverRefs, "Engine.CheatManager.VerifyNavMeshCoverRefs");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_PrintNavMeshObstacles;
    /// <summary>
    /// Function: PrintNavMeshObstacles
    /// </summary>
    public unsafe virtual void PrintNavMeshObstacles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrintNavMeshObstacles, "Engine.CheatManager.PrintNavMeshObstacles");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_PrintAllPathObjectEdges;
    /// <summary>
    /// Function: PrintAllPathObjectEdges
    /// </summary>
    public unsafe virtual void PrintAllPathObjectEdges()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrintAllPathObjectEdges, "Engine.CheatManager.PrintAllPathObjectEdges");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_NavMeshVerification;
    /// <summary>
    /// Function: NavMeshVerification
    /// </summary>
    public unsafe virtual void NavMeshVerification(float interval = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavMeshVerification, "Engine.CheatManager.NavMeshVerification");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interval, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawUnsupportingEdges;
    /// <summary>
    /// Function: DrawUnsupportingEdges
    /// </summary>
    public unsafe virtual void DrawUnsupportingEdges(BmSDK.FString PawnClassName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawUnsupportingEdges, "Engine.CheatManager.DrawUnsupportingEdges");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnClassName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_VerifyNavMeshObjects;
    /// <summary>
    /// Function: VerifyNavMeshObjects
    /// </summary>
    public unsafe virtual void VerifyNavMeshObjects()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VerifyNavMeshObjects, "Engine.CheatManager.VerifyNavMeshObjects");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_LogParticleActivateSystemCalls;
    /// <summary>
    /// Function: LogParticleActivateSystemCalls
    /// </summary>
    public unsafe virtual void LogParticleActivateSystemCalls(bool bShouldLog)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogParticleActivateSystemCalls, "Engine.CheatManager.LogParticleActivateSystemCalls");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldLog, paramsPtr + 0);
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

    private static BmSDK.Function __fn_LogPlaySoundCalls;
    /// <summary>
    /// Function: LogPlaySoundCalls
    /// </summary>
    public unsafe virtual void LogPlaySoundCalls(bool bShouldLog)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogPlaySoundCalls, "Engine.CheatManager.LogPlaySoundCalls");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldLog, paramsPtr + 0);
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

    private static BmSDK.Function __fn_InitCheatManager;
    /// <summary>
    /// Function: InitCheatManager
    /// </summary>
    public unsafe virtual void InitCheatManager()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitCheatManager, "Engine.CheatManager.InitCheatManager");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestPylonConnectivity;
    /// <summary>
    /// Function: TestPylonConnectivity
    /// </summary>
    public unsafe virtual void TestPylonConnectivity()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestPylonConnectivity, "Engine.CheatManager.TestPylonConnectivity");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CE;
    /// <summary>
    /// Function: CE
    /// </summary>
    public unsafe virtual void CE(BmSDK.FName EventName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CE, "Engine.CheatManager.CE");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CauseEvent;
    /// <summary>
    /// Function: CauseEvent
    /// </summary>
    public unsafe virtual void CauseEvent(BmSDK.FName EventName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CauseEvent, "Engine.CheatManager.CauseEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Online;
    /// <summary>
    /// Function: Online
    /// </summary>
    public unsafe virtual void Online(int Command, int Parameter = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Online, "Engine.CheatManager.Online");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Command, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Parameter, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOnlineDebugLevel;
    /// <summary>
    /// Function: SetOnlineDebugLevel
    /// </summary>
    public unsafe virtual void SetOnlineDebugLevel(int DebugLevel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOnlineDebugLevel, "Engine.CheatManager.SetOnlineDebugLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestLevel;
    /// <summary>
    /// Function: TestLevel
    /// </summary>
    public unsafe virtual void TestLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestLevel, "Engine.CheatManager.TestLevel");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableDebugCamera;
    /// <summary>
    /// Function: EnableDebugCamera
    /// </summary>
    public unsafe virtual void EnableDebugCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableDebugCamera, "Engine.CheatManager.EnableDebugCamera");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleDebugCamera;
    /// <summary>
    /// Function: ToggleDebugCamera
    /// </summary>
    public unsafe virtual void ToggleDebugCamera(bool bDestroy = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleDebugCamera, "Engine.CheatManager.ToggleDebugCamera");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDestroy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StreamLevelOut;
    /// <summary>
    /// Function: StreamLevelOut
    /// </summary>
    public unsafe virtual void StreamLevelOut(BmSDK.FName PackageName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StreamLevelOut, "Engine.CheatManager.StreamLevelOut");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnlyLoadLevel;
    /// <summary>
    /// Function: OnlyLoadLevel
    /// </summary>
    public unsafe virtual void OnlyLoadLevel(BmSDK.FName PackageName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnlyLoadLevel, "Engine.CheatManager.OnlyLoadLevel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StreamLevelIn;
    /// <summary>
    /// Function: StreamLevelIn
    /// </summary>
    public unsafe virtual void StreamLevelIn(BmSDK.FName PackageName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StreamLevelIn, "Engine.CheatManager.StreamLevelIn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLevelStreamingStatus;
    /// <summary>
    /// Function: SetLevelStreamingStatus
    /// </summary>
    public unsafe virtual void SetLevelStreamingStatus(BmSDK.FName PackageName, bool bShouldBeLoaded, bool bShouldBeVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLevelStreamingStatus, "Engine.CheatManager.SetLevelStreamingStatus");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldBeLoaded, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldBeVisible, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllWeapons;
    /// <summary>
    /// Function: AllWeapons
    /// </summary>
    public unsafe virtual void AllWeapons()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllWeapons, "Engine.CheatManager.AllWeapons");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ViewActor;
    /// <summary>
    /// Function: ViewActor
    /// </summary>
    public unsafe virtual void ViewActor(BmSDK.FName ActorName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ViewActor, "Engine.CheatManager.ViewActor");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ViewPlayer;
    /// <summary>
    /// Function: ViewPlayer
    /// </summary>
    public unsafe virtual void ViewPlayer(BmSDK.FString S)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ViewPlayer, "Engine.CheatManager.ViewPlayer");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ViewSelf;
    /// <summary>
    /// Function: ViewSelf
    /// </summary>
    public unsafe virtual void ViewSelf(bool bQuiet = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ViewSelf, "Engine.CheatManager.ViewSelf");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bQuiet, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RememberSpot;
    /// <summary>
    /// Function: RememberSpot
    /// </summary>
    public unsafe virtual void RememberSpot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RememberSpot, "Engine.CheatManager.RememberSpot");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FractureAllMeshesToMaximizeMemoryUsage;
    /// <summary>
    /// Function: FractureAllMeshesToMaximizeMemoryUsage
    /// </summary>
    public unsafe virtual void FractureAllMeshesToMaximizeMemoryUsage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FractureAllMeshesToMaximizeMemoryUsage, "Engine.CheatManager.FractureAllMeshesToMaximizeMemoryUsage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FractureAllMeshes;
    /// <summary>
    /// Function: FractureAllMeshes
    /// </summary>
    public unsafe virtual void FractureAllMeshes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FractureAllMeshes, "Engine.CheatManager.FractureAllMeshes");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyFractures;
    /// <summary>
    /// Function: DestroyFractures
    /// </summary>
    public unsafe virtual void DestroyFractures(float Radius = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyFractures, "Engine.CheatManager.DestroyFractures");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuspendAI;
    /// <summary>
    /// Function: SuspendAI
    /// </summary>
    public unsafe virtual void SuspendAI()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuspendAI, "Engine.CheatManager.SuspendAI");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayersOnly;
    /// <summary>
    /// Function: PlayersOnly
    /// </summary>
    public unsafe virtual void PlayersOnly()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayersOnly, "Engine.CheatManager.PlayersOnly");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveWeapon;
    /// <summary>
    /// Function: GiveWeapon
    /// </summary>
    public unsafe virtual BmSDK.Engine.Weapon GiveWeapon(BmSDK.FString WeaponClassStr)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveWeapon, "Engine.CheatManager.GiveWeapon");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponClassStr, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Weapon>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_Summon;
    /// <summary>
    /// Function: Summon
    /// </summary>
    public unsafe virtual void Summon(BmSDK.FString ClassName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Summon, "Engine.CheatManager.Summon");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClassName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillPawns;
    /// <summary>
    /// Function: KillPawns
    /// </summary>
    public unsafe virtual void KillPawns()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillPawns, "Engine.CheatManager.KillPawns");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillAllPawns;
    /// <summary>
    /// Function: KillAllPawns
    /// </summary>
    public unsafe virtual void KillAllPawns(BmSDK.Class aClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillAllPawns, "Engine.CheatManager.KillAllPawns");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillAll;
    /// <summary>
    /// Function: KillAll
    /// </summary>
    public unsafe virtual void KillAll(BmSDK.Class aClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillAll, "Engine.CheatManager.KillAll");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSpeed;
    /// <summary>
    /// Function: SetSpeed
    /// </summary>
    public unsafe virtual void SetSpeed(float F)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpeed, "Engine.CheatManager.SetSpeed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(F, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGravity;
    /// <summary>
    /// Function: SetGravity
    /// </summary>
    public unsafe virtual void SetGravity(float F)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGravity, "Engine.CheatManager.SetGravity");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(F, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetJumpZ;
    /// <summary>
    /// Function: SetJumpZ
    /// </summary>
    public unsafe virtual void SetJumpZ(float F)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetJumpZ, "Engine.CheatManager.SetJumpZ");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(F, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Slomo;
    /// <summary>
    /// Function: Slomo
    /// </summary>
    public unsafe virtual void Slomo(float T)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Slomo, "Engine.CheatManager.Slomo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_God;
    /// <summary>
    /// Function: God
    /// </summary>
    public unsafe virtual void God()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_God, "Engine.CheatManager.God");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllAmmo;
    /// <summary>
    /// Function: AllAmmo
    /// </summary>
    public unsafe virtual void AllAmmo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllAmmo, "Engine.CheatManager.AllAmmo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Ghost;
    /// <summary>
    /// Function: Ghost
    /// </summary>
    public unsafe virtual void Ghost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Ghost, "Engine.CheatManager.Ghost");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Walk;
    /// <summary>
    /// Function: Walk
    /// </summary>
    public unsafe virtual void Walk()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Walk, "Engine.CheatManager.Walk");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Fly;
    /// <summary>
    /// Function: Fly
    /// </summary>
    public unsafe virtual void Fly()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Fly, "Engine.CheatManager.Fly");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Amphibious;
    /// <summary>
    /// Function: Amphibious
    /// </summary>
    public unsafe virtual void Amphibious()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Amphibious, "Engine.CheatManager.Amphibious");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndPath;
    /// <summary>
    /// Function: EndPath
    /// </summary>
    public unsafe virtual void EndPath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndPath, "Engine.CheatManager.EndPath");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeSize;
    /// <summary>
    /// Function: ChangeSize
    /// </summary>
    public unsafe virtual void ChangeSize(float F)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeSize, "Engine.CheatManager.ChangeSize");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(F, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Teleport;
    /// <summary>
    /// Function: Teleport
    /// </summary>
    public unsafe virtual void Teleport()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Teleport, "Engine.CheatManager.Teleport");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillViewedActor;
    /// <summary>
    /// Function: KillViewedActor
    /// </summary>
    public unsafe virtual void KillViewedActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillViewedActor, "Engine.CheatManager.KillViewedActor");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WriteToLog;
    /// <summary>
    /// Function: WriteToLog
    /// </summary>
    public unsafe virtual void WriteToLog(BmSDK.FString Param)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteToLog, "Engine.CheatManager.WriteToLog");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Param, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FreezeFrame;
    /// <summary>
    /// Function: FreezeFrame
    /// </summary>
    public unsafe virtual void FreezeFrame(float Delay)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreezeFrame, "Engine.CheatManager.FreezeFrame");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListDynamicActors;
    /// <summary>
    /// Function: ListDynamicActors
    /// </summary>
    public unsafe virtual void ListDynamicActors()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListDynamicActors, "Engine.CheatManager.ListDynamicActors");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugPause;
    /// <summary>
    /// Function: DebugPause
    /// </summary>
    public unsafe virtual void DebugPause()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugPause, "Engine.CheatManager.DebugPause");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugAI;
    /// <summary>
    /// Function: DebugAI
    /// </summary>
    public unsafe virtual void DebugAI(BmSDK.FName Category = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugAI, "Engine.CheatManager.DebugAI");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Category, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: DebugCameraControllerRef
    /// </summary>
    public unsafe BmSDK.Engine.DebugCameraController DebugCameraControllerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DebugCameraController>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ClassProperty: DebugCameraControllerClass
    /// </summary>
    public unsafe BmSDK.Class DebugCameraControllerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StrProperty: ViewingFrom
    /// </summary>
    public unsafe BmSDK.FString ViewingFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StrProperty: OwnCamera
    /// </summary>
    public unsafe BmSDK.FString OwnCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: CurrentBatmobileSetting
    /// </summary>
    public unsafe int CurrentBatmobileSetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
