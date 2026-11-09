#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: ROnlineCustomContentCacheManager<br/>
/// (size = 252)
/// (flags = 134217874)
/// </summary>
public partial class ROnlineCustomContentCacheManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.ROnlineCustomContentCacheManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as ROnlineCustomContentCacheManager.
    /// </summary>
    public static ROnlineCustomContentCacheManager DefaultObject => (ROnlineCustomContentCacheManager)StaticClass().DefaultObject;

    internal ROnlineCustomContentCacheManager() { }

    /// <summary>
    /// Constructs a new ROnlineCustomContentCacheManager
    /// </summary>
    public ROnlineCustomContentCacheManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ROnlineCustomContentCacheManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ROnlineCustomContentCacheManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ROnlineCustomContentCacheManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROnlineCustomContentCacheManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ROnlineCustomContentCacheManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROnlineCustomContentCacheManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROnlineCustomContentCacheManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROnlineCustomContentCacheManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ROnlineCustomContentCacheManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROnlineCustomContentCacheManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CheckStateChange;
    /// <summary>
    /// Function: CheckStateChange
    /// </summary>
    public unsafe void CheckStateChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckStateChange, "IpDrv.ROnlineCustomContentCacheManager.CheckStateChange");
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

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe virtual void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "IpDrv.ROnlineCustomContentCacheManager.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetActivityLogAsList;
    /// <summary>
    /// Function: GetActivityLogAsList
    /// </summary>
    public unsafe virtual void GetActivityLogAsList(out BmSDK.TArray<BmSDK.FString> OutList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActivityLogAsList, "IpDrv.ROnlineCustomContentCacheManager.GetActivityLogAsList");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateActivity;
    /// <summary>
    /// Function: UpdateActivity
    /// </summary>
    public unsafe virtual void UpdateActivity(BmSDK.FString Filename, BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityType Type, BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityStatus Status, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateActivity, "IpDrv.ROnlineCustomContentCacheManager.UpdateActivity");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Status, paramsPtr + 17);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCleanupObsoleteInternal;
    /// <summary>
    /// Function: OnCleanupObsoleteInternal
    /// </summary>
    public unsafe virtual void OnCleanupObsoleteInternal(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCleanupObsoleteInternal, "IpDrv.ROnlineCustomContentCacheManager.OnCleanupObsoleteInternal");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCrcDownloadComplete;
    /// <summary>
    /// Function: OnCrcDownloadComplete
    /// </summary>
    public unsafe virtual void OnCrcDownloadComplete(BmSDK.Engine.OnlineCustomContentRequestHydra SubRequest, BmSDK.FString Category)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCrcDownloadComplete, "IpDrv.ROnlineCustomContentCacheManager.OnCrcDownloadComplete");
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubRequest, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Category, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRegistryAsFileNames;
    /// <summary>
    /// Function: GetRegistryAsFileNames
    /// </summary>
    public unsafe virtual void GetRegistryAsFileNames(out BmSDK.TArray<BmSDK.FString> OutList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRegistryAsFileNames, "IpDrv.ROnlineCustomContentCacheManager.GetRegistryAsFileNames");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetRegistryAsList;
    /// <summary>
    /// Function: GetRegistryAsList
    /// </summary>
    public unsafe virtual int GetRegistryAsList(out BmSDK.TArray<BmSDK.FString> OutList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRegistryAsList, "IpDrv.ROnlineCustomContentCacheManager.GetRegistryAsList");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetIndexOfFolderInRegistry;
    /// <summary>
    /// Function: GetIndexOfFolderInRegistry
    /// </summary>
    public unsafe virtual int GetIndexOfFolderInRegistry(out BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryFolder folderCopy, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIndexOfFolderInRegistry, "IpDrv.ROnlineCustomContentCacheManager.GetIndexOfFolderInRegistry");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        folderCopy = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryFolder>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_GetIndexOfEntryInFolder;
    /// <summary>
    /// Function: GetIndexOfEntryInFolder
    /// </summary>
    public unsafe virtual int GetIndexOfEntryInFolder(out BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry entryCopy, BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryFolder folderCopy, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIndexOfEntryInFolder, "IpDrv.ROnlineCustomContentCacheManager.GetIndexOfEntryInFolder");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(folderCopy, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        entryCopy = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 80);
    }

    private static BmSDK.Function __fn_GetCopyOfEntryInRegistry;
    /// <summary>
    /// Function: GetCopyOfEntryInRegistry
    /// </summary>
    public unsafe virtual bool GetCopyOfEntryInRegistry(out BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry entryCopy, BmSDK.FString Filename, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCopyOfEntryInRegistry, "IpDrv.ROnlineCustomContentCacheManager.GetCopyOfEntryInRegistry");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        entryCopy = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_FlagObsoleteInRegistry;
    /// <summary>
    /// Function: FlagObsoleteInRegistry
    /// </summary>
    public unsafe virtual bool FlagObsoleteInRegistry(BmSDK.FString Filename, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlagObsoleteInRegistry, "IpDrv.ROnlineCustomContentCacheManager.FlagObsoleteInRegistry");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_RemoveFromRegistry;
    /// <summary>
    /// Function: RemoveFromRegistry
    /// </summary>
    public unsafe virtual bool RemoveFromRegistry(BmSDK.FString Filename, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFromRegistry, "IpDrv.ROnlineCustomContentCacheManager.RemoveFromRegistry");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_UpdateRegistry;
    /// <summary>
    /// Function: UpdateRegistry
    /// </summary>
    public unsafe virtual void UpdateRegistry(BmSDK.FString Filename, BmSDK.FString Subfolder, int Crc32, int Size, bool bObsolete)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRegistry, "IpDrv.ROnlineCustomContentCacheManager.UpdateRegistry");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Crc32, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bObsolete, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFileCacheSize;
    /// <summary>
    /// Function: GetFileCacheSize
    /// </summary>
    public unsafe virtual int GetFileCacheSize(BmSDK.FString Filename, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFileCacheSize, "IpDrv.ROnlineCustomContentCacheManager.GetFileCacheSize");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetFileCacheStatus;
    /// <summary>
    /// Function: GetFileCacheStatus
    /// </summary>
    public unsafe virtual BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheFileStatus GetFileCacheStatus(BmSDK.FString Filename, BmSDK.FString Subfolder, int ExpectedCrc32)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFileCacheStatus, "IpDrv.ROnlineCustomContentCacheManager.GetFileCacheStatus");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExpectedCrc32, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheFileStatus>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_InitializeCacheRegistry;
    /// <summary>
    /// Function: InitializeCacheRegistry
    /// </summary>
    public unsafe virtual void InitializeCacheRegistry()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeCacheRegistry, "IpDrv.ROnlineCustomContentCacheManager.InitializeCacheRegistry");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCacheDeleteComplete;
    /// <summary>
    /// Function: OnCacheDeleteComplete
    /// </summary>
    public unsafe virtual void OnCacheDeleteComplete(bool bWasSuccessful, BmSDK.FString Filename, float timeTaken)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCacheDeleteComplete, "IpDrv.ROnlineCustomContentCacheManager.OnCacheDeleteComplete");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCacheDeleteBegin;
    /// <summary>
    /// Function: OnCacheDeleteBegin
    /// </summary>
    public unsafe virtual void OnCacheDeleteBegin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCacheDeleteBegin, "IpDrv.ROnlineCustomContentCacheManager.OnCacheDeleteBegin");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCacheSaveComplete;
    /// <summary>
    /// Function: OnCacheSaveComplete
    /// </summary>
    public unsafe virtual void OnCacheSaveComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCacheSaveComplete, "IpDrv.ROnlineCustomContentCacheManager.OnCacheSaveComplete");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCacheSaveBegin;
    /// <summary>
    /// Function: OnCacheSaveBegin
    /// </summary>
    public unsafe virtual void OnCacheSaveBegin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCacheSaveBegin, "IpDrv.ROnlineCustomContentCacheManager.OnCacheSaveBegin");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCacheLoadComplete;
    /// <summary>
    /// Function: OnCacheLoadComplete
    /// </summary>
    public unsafe virtual void OnCacheLoadComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCacheLoadComplete, "IpDrv.ROnlineCustomContentCacheManager.OnCacheLoadComplete");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCacheLoadBegin;
    /// <summary>
    /// Function: OnCacheLoadBegin
    /// </summary>
    public unsafe virtual void OnCacheLoadBegin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCacheLoadBegin, "IpDrv.ROnlineCustomContentCacheManager.OnCacheLoadBegin");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddToDeleteQueue;
    /// <summary>
    /// Function: AddToDeleteQueue
    /// </summary>
    public unsafe virtual void AddToDeleteQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToDeleteQueue, "IpDrv.ROnlineCustomContentCacheManager.AddToDeleteQueue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddToWriteQueue;
    /// <summary>
    /// Function: AddToWriteQueue
    /// </summary>
    public unsafe virtual void AddToWriteQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToWriteQueue, "IpDrv.ROnlineCustomContentCacheManager.AddToWriteQueue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RemoveFromReadQueue;
    /// <summary>
    /// Function: RemoveFromReadQueue
    /// </summary>
    public unsafe virtual void RemoveFromReadQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFromReadQueue, "IpDrv.ROnlineCustomContentCacheManager.RemoveFromReadQueue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddToReadQueue;
    /// <summary>
    /// Function: AddToReadQueue
    /// </summary>
    public unsafe virtual void AddToReadQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToReadQueue, "IpDrv.ROnlineCustomContentCacheManager.AddToReadQueue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
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
    /// ObjectProperty: OnlineSub
    /// </summary>
    public unsafe BmSDK.IpDrv.OnlineSubsystemCommonImpl OnlineSub
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.OnlineSubsystemCommonImpl>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: RequestInProgress
    /// </summary>
    public unsafe BmSDK.Engine.OnlineCustomContentRequestCacheableHydra RequestInProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ByteProperty: CurrentState
    /// </summary>
    public unsafe BmSDK.IpDrv.ROnlineCustomContentCacheManager.QueuePriorityState CurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.ROnlineCustomContentCacheManager.QueuePriorityState>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: FileSystemBusy
    /// </summary>
    public unsafe bool FileSystemBusy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: ReadQueue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra> ReadQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: WriteQueue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra> WriteQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: DeleteQueue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra> DeleteQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineCustomContentRequestCacheableHydra>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: Registries
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryFolder> Registries
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryFolder>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: ActivityLog
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FCacheActivityEntry> ActivityLog
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FCacheActivityEntry>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// DelegateProperty: __OnCacheLoadComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCacheLoadComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// DelegateProperty: __OnCacheSaveComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCacheSaveComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// DelegateProperty: __OnCacheDeleteComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCacheDeleteComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// DelegateProperty: __OnCleanupObsoleteInternal__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCleanupObsoleteInternal__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// Struct: FCacheActivityEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FCacheActivityEntry
    {
        /// <summary>
        /// StrProperty: Filename
        /// </summary>
        public unsafe BmSDK.FString Filename
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: OpType
        /// </summary>
        public unsafe BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityType OpType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityType>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: Status
        /// </summary>
        public unsafe BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityStatus Status
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.ROnlineCustomContentCacheManager.CacheActivityStatus>(Ptr + 17); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17); }; }
        }

        /// <summary>
        /// IntProperty: bytesTransferred
        /// </summary>
        public unsafe int bytesTransferred
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: timeTaken
        /// </summary>
        public unsafe float timeTaken
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: CacheActivityType
    /// </summary>
    public enum CacheActivityType : byte
    {
        ActivityRead = 0,
        ActivityWrite = 1,
        ActivityDelete = 2,
        CacheActivityType_MAX = 3,
    }

    /// <summary>
    /// Enum: CacheActivityStatus
    /// </summary>
    public enum CacheActivityStatus : byte
    {
        ActivitySuccessful = 0,
        ActivityFailed = 1,
        CacheActivityStatus_MAX = 2,
    }

    /// <summary>
    /// Enum: CacheFileStatus
    /// </summary>
    public enum CacheFileStatus : byte
    {
        FileOK = 0,
        FileObsolete = 1,
        FileNonexistent = 2,
        CacheFileStatus_MAX = 3,
    }

    /// <summary>
    /// Enum: QueuePriorityState
    /// </summary>
    public enum QueuePriorityState : byte
    {
        StandbyState = 0,
        ReadState = 1,
        WriteState = 2,
        DeleteState = 3,
        QueuePriorityState_MAX = 4,
    }

    /// <summary>
    /// Struct: FRegistryFolder
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FRegistryFolder
    {
        /// <summary>
        /// StrProperty: FolderName
        /// </summary>
        public unsafe BmSDK.FString FolderName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Entries
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry> Entries
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.IpDrv.ROnlineCustomContentCacheManager.FRegistryEntry>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Version
        /// </summary>
        public unsafe int Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FRegistryEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FRegistryEntry
    {
        /// <summary>
        /// StrProperty: Filename
        /// </summary>
        public unsafe BmSDK.FString Filename
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Size
        /// </summary>
        public unsafe int Size
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: CRC
        /// </summary>
        public unsafe int CRC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: Obsolete
        /// </summary>
        public unsafe bool Obsolete
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }
}
