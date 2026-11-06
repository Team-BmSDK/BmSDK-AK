#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: TitleFileDownloadCache<br/>
/// (size = 236)
/// (flags = 134217878)
/// </summary>
public partial class TitleFileDownloadCache : BmSDK.IpDrv.MCPBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.TitleFileDownloadCache", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as TitleFileDownloadCache.
    /// </summary>
    public static TitleFileDownloadCache DefaultObject => (TitleFileDownloadCache)StaticClass().DefaultObject;

    internal TitleFileDownloadCache() { }

    /// <summary>
    /// Constructs a new TitleFileDownloadCache
    /// </summary>
    public TitleFileDownloadCache(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TitleFileDownloadCache Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TitleFileDownloadCache(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<TitleFileDownloadCache>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<TitleFileDownloadCache>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<TitleFileDownloadCache>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<TitleFileDownloadCache>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<TitleFileDownloadCache>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<TitleFileDownloadCache>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<TitleFileDownloadCache>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<TitleFileDownloadCache>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CancelIO;
    /// <summary>
    /// Function: CancelIO
    /// </summary>
    public unsafe virtual void CancelIO()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelIO, "IpDrv.TitleFileDownloadCache.CancelIO");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttemptDeleteDownloadFile;
    /// <summary>
    /// Function: AttemptDeleteDownloadFile
    /// </summary>
    public unsafe virtual bool AttemptDeleteDownloadFile(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptDeleteDownloadFile, "IpDrv.TitleFileDownloadCache.AttemptDeleteDownloadFile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_OnDeleteDownloadFileCompleteInternal;
    /// <summary>
    /// Function: OnDeleteDownloadFileCompleteInternal
    /// </summary>
    public unsafe virtual bool OnDeleteDownloadFileCompleteInternal(bool bWasSuccessful, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeleteDownloadFileCompleteInternal, "IpDrv.TitleFileDownloadCache.OnDeleteDownloadFileCompleteInternal");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_OnDeleteDownloadFileComplete;
    /// <summary>
    /// Function: OnDeleteDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnDeleteDownloadFileComplete(bool bWasSuccessful, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeleteDownloadFileComplete, "IpDrv.TitleFileDownloadCache.OnDeleteDownloadFileComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttemptReadDownloadFile;
    /// <summary>
    /// Function: AttemptReadDownloadFile
    /// </summary>
    public unsafe virtual bool AttemptReadDownloadFile(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptReadDownloadFile, "IpDrv.TitleFileDownloadCache.AttemptReadDownloadFile");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_OnReadDownloadFileCompleteInternal;
    /// <summary>
    /// Function: OnReadDownloadFileCompleteInternal
    /// </summary>
    public unsafe virtual bool OnReadDownloadFileCompleteInternal(bool bWasSuccessful, BmSDK.FString Filename, int bytesProcessed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadDownloadFileCompleteInternal, "IpDrv.TitleFileDownloadCache.OnReadDownloadFileCompleteInternal");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesProcessed, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_OnReadDownloadFileComplete;
    /// <summary>
    /// Function: OnReadDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnReadDownloadFileComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesProcessed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadDownloadFileComplete, "IpDrv.TitleFileDownloadCache.OnReadDownloadFileComplete");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesProcessed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttemptWriteDownloadFile;
    /// <summary>
    /// Function: AttemptWriteDownloadFile
    /// </summary>
    public unsafe virtual bool AttemptWriteDownloadFile(BmSDK.FString Filename, BmSDK.TArray<byte> FileContents, BmSDK.FString FileCRC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptWriteDownloadFile, "IpDrv.TitleFileDownloadCache.AttemptWriteDownloadFile");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileContents, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileCRC, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_OnWriteDownloadFileCompleteInternal;
    /// <summary>
    /// Function: OnWriteDownloadFileCompleteInternal
    /// </summary>
    public unsafe virtual bool OnWriteDownloadFileCompleteInternal(bool bWasSuccessful, BmSDK.FString Filename, int bytesProcessed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWriteDownloadFileCompleteInternal, "IpDrv.TitleFileDownloadCache.OnWriteDownloadFileCompleteInternal");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesProcessed, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_OnWriteDownloadFileComplete;
    /// <summary>
    /// Function: OnWriteDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnWriteDownloadFileComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesProcessed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWriteDownloadFileComplete, "IpDrv.TitleFileDownloadCache.OnWriteDownloadFileComplete");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesProcessed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttemptGetDownloadFileSize;
    /// <summary>
    /// Function: AttemptGetDownloadFileSize
    /// </summary>
    public unsafe virtual int AttemptGetDownloadFileSize(BmSDK.FString Filename, bool KeepHandle = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptGetDownloadFileSize, "IpDrv.TitleFileDownloadCache.AttemptGetDownloadFileSize");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeepHandle, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_FindFolders;
    /// <summary>
    /// Function: FindFolders
    /// </summary>
    public unsafe virtual void FindFolders(out BmSDK.TArray<BmSDK.FString> Results)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindFolders, "IpDrv.TitleFileDownloadCache.FindFolders");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Results = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_FindFiles;
    /// <summary>
    /// Function: FindFiles
    /// </summary>
    public unsafe virtual void FindFiles(out BmSDK.TArray<BmSDK.FString> Results, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindFiles, "IpDrv.TitleFileDownloadCache.FindFiles");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Results = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DeleteTitleFile;
    /// <summary>
    /// Function: DeleteTitleFile
    /// </summary>
    public unsafe virtual bool DeleteTitleFile(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteTitleFile, "IpDrv.TitleFileDownloadCache.DeleteTitleFile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DeleteTitleFiles;
    /// <summary>
    /// Function: DeleteTitleFiles
    /// </summary>
    public unsafe virtual bool DeleteTitleFiles(float MaxAgeSeconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteTitleFiles, "IpDrv.TitleFileDownloadCache.DeleteTitleFiles");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxAgeSeconds, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearCachedFile;
    /// <summary>
    /// Function: ClearCachedFile
    /// </summary>
    public unsafe virtual bool ClearCachedFile(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCachedFile, "IpDrv.TitleFileDownloadCache.ClearCachedFile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ClearCachedFiles;
    /// <summary>
    /// Function: ClearCachedFiles
    /// </summary>
    public unsafe virtual bool ClearCachedFiles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCachedFiles, "IpDrv.TitleFileDownloadCache.ClearCachedFiles");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTitleFileLogicalName;
    /// <summary>
    /// Function: GetTitleFileLogicalName
    /// </summary>
    public unsafe virtual BmSDK.FString GetTitleFileLogicalName(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTitleFileLogicalName, "IpDrv.TitleFileDownloadCache.GetTitleFileLogicalName");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetTitleFileHash;
    /// <summary>
    /// Function: GetTitleFileHash
    /// </summary>
    public unsafe virtual BmSDK.FString GetTitleFileHash(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTitleFileHash, "IpDrv.TitleFileDownloadCache.GetTitleFileHash");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetTitleFileState;
    /// <summary>
    /// Function: GetTitleFileState
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetTitleFileState(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTitleFileState, "IpDrv.TitleFileDownloadCache.GetTitleFileState");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetTitleFileContents;
    /// <summary>
    /// Function: GetTitleFileContents
    /// </summary>
    public unsafe virtual bool GetTitleFileContents(BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTitleFileContents, "IpDrv.TitleFileDownloadCache.GetTitleFileContents");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FileContents = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ClearDeleteTitleFileCompleteDelegate;
    /// <summary>
    /// Function: ClearDeleteTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearDeleteTitleFileCompleteDelegate(System.IntPtr DeleteCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDeleteTitleFileCompleteDelegate, "IpDrv.TitleFileDownloadCache.ClearDeleteTitleFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDeleteTitleFileCompleteDelegate;
    /// <summary>
    /// Function: AddDeleteTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddDeleteTitleFileCompleteDelegate(System.IntPtr DeleteCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDeleteTitleFileCompleteDelegate, "IpDrv.TitleFileDownloadCache.AddDeleteTitleFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeleteTitleFileComplete;
    /// <summary>
    /// Function: OnDeleteTitleFileComplete
    /// </summary>
    public unsafe virtual void OnDeleteTitleFileComplete(bool bWasSuccessful, BmSDK.FString Filename, float timeTaken)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeleteTitleFileComplete, "IpDrv.TitleFileDownloadCache.OnDeleteTitleFileComplete");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearSaveTitleFileCompleteDelegate;
    /// <summary>
    /// Function: ClearSaveTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearSaveTitleFileCompleteDelegate(System.IntPtr SaveCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearSaveTitleFileCompleteDelegate, "IpDrv.TitleFileDownloadCache.ClearSaveTitleFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddSaveTitleFileCompleteDelegate;
    /// <summary>
    /// Function: AddSaveTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddSaveTitleFileCompleteDelegate(System.IntPtr SaveCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSaveTitleFileCompleteDelegate, "IpDrv.TitleFileDownloadCache.AddSaveTitleFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSaveTitleFileComplete;
    /// <summary>
    /// Function: OnSaveTitleFileComplete
    /// </summary>
    public unsafe virtual void OnSaveTitleFileComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSaveTitleFileComplete, "IpDrv.TitleFileDownloadCache.OnSaveTitleFileComplete");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SaveTitleFile;
    /// <summary>
    /// Function: SaveTitleFile
    /// </summary>
    public unsafe virtual bool SaveTitleFile(BmSDK.FString Filename, BmSDK.FString LogicalName, BmSDK.TArray<byte> FileContents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveTitleFile, "IpDrv.TitleFileDownloadCache.SaveTitleFile");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LogicalName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileContents, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_ClearLoadTitleFileCompleteDelegate;
    /// <summary>
    /// Function: ClearLoadTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearLoadTitleFileCompleteDelegate(System.IntPtr LoadCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLoadTitleFileCompleteDelegate, "IpDrv.TitleFileDownloadCache.ClearLoadTitleFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLoadTitleFileCompleteDelegate;
    /// <summary>
    /// Function: AddLoadTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddLoadTitleFileCompleteDelegate(System.IntPtr LoadCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLoadTitleFileCompleteDelegate, "IpDrv.TitleFileDownloadCache.AddLoadTitleFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoadTitleFileComplete;
    /// <summary>
    /// Function: OnLoadTitleFileComplete
    /// </summary>
    public unsafe virtual void OnLoadTitleFileComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesTransferred, float timeTaken)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoadTitleFileComplete, "IpDrv.TitleFileDownloadCache.OnLoadTitleFileComplete");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesTransferred, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeTaken, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadTitleFile;
    /// <summary>
    /// Function: LoadTitleFile
    /// </summary>
    public unsafe virtual bool LoadTitleFile(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadTitleFile, "IpDrv.TitleFileDownloadCache.LoadTitleFile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// ObjectProperty: OnlineSub
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem OnlineSub
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: TitleFiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.IpDrv.TitleFileCacheEntry> TitleFiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.IpDrv.TitleFileCacheEntry>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: LoadCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LoadCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: SaveCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> SaveCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: DeleteCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> DeleteCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoadTitleFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoadTitleFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// DelegateProperty: __OnSaveTitleFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnSaveTitleFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeleteTitleFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDeleteTitleFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
}
