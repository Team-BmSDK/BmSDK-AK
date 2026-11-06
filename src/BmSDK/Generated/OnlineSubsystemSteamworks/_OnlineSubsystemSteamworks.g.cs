#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: _OnlineSubsystemSteamworks<br/>
/// (size = 3088)
/// (flags = 134217910)
/// </summary>
public partial class _OnlineSubsystemSteamworks : BmSDK.IpDrv.OnlineSubsystemCommonImpl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as _OnlineSubsystemSteamworks.
    /// </summary>
    public static _OnlineSubsystemSteamworks DefaultObject => (_OnlineSubsystemSteamworks)StaticClass().DefaultObject;

    internal _OnlineSubsystemSteamworks() { }

    /// <summary>
    /// Constructs a new _OnlineSubsystemSteamworks
    /// </summary>
    public _OnlineSubsystemSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, _OnlineSubsystemSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected _OnlineSubsystemSteamworks(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CancelFetchSteamDLC;
    /// <summary>
    /// Function: CancelFetchSteamDLC
    /// </summary>
    public unsafe virtual void CancelFetchSteamDLC(BmSDK.GameObject TargetObject)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelFetchSteamDLC, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CancelFetchSteamDLC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetObject, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FetchSteamDLC;
    /// <summary>
    /// Function: FetchSteamDLC
    /// </summary>
    public unsafe virtual void FetchSteamDLC(BmSDK.GameObject TargetObject, System.IntPtr cback)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchSteamDLC, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.FetchSteamDLC");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cback, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SteamDLCCallback;
    /// <summary>
    /// Function: SteamDLCCallback
    /// </summary>
    public unsafe virtual void SteamDLCCallback(bool bWasSuccessful, BmSDK.TArray<BmSDK.IpDrv.OnlineSubsystemCommonImpl.FSteam_PriceInfo> aPrices)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SteamDLCCallback, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SteamDLCCallback");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPrices, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Exit;
    /// <summary>
    /// Function: Exit
    /// </summary>
    public unsafe override void Exit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Exit, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Exit");
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

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Init");
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

    private static BmSDK.Function __fn_OnRequestComplete;
    /// <summary>
    /// Function: OnRequestComplete
    /// </summary>
    public unsafe virtual void OnRequestComplete(BmSDK.Engine.HttpRequestInterface OriginalRequest, BmSDK.Engine.HttpResponseInterface Response, bool bDidSucceed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRequestComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnRequestComplete");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalRequest, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Response, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDidSucceed, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WebRequest;
    /// <summary>
    /// Function: WebRequest
    /// </summary>
    public unsafe virtual void WebRequest(BmSDK.FString HttpMethod, BmSDK.FString URL, BmSDK.FString Params = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WebRequest, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WebRequest");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HttpMethod, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSteamID;
    /// <summary>
    /// Function: GetSteamID
    /// </summary>
    public unsafe virtual BmSDK.FString GetSteamID()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSteamID, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetSteamID");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearWriteSharedFileCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteSharedFileCompleteDelegate(System.IntPtr WriteSharedFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWriteSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteSharedFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWriteSharedFileCompleteDelegate;
    /// <summary>
    /// Function: AddWriteSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteSharedFileCompleteDelegate(System.IntPtr WriteSharedFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWriteSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteSharedFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WriteSharedFile;
    /// <summary>
    /// Function: WriteSharedFile
    /// </summary>
    public unsafe virtual bool WriteSharedFile(BmSDK.FString UserId, BmSDK.FString Filename, out BmSDK.TArray<byte> Contents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteSharedFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteSharedFile");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Contents = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_OnWriteSharedFileComplete;
    /// <summary>
    /// Function: OnWriteSharedFileComplete
    /// </summary>
    public unsafe virtual void OnWriteSharedFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename, BmSDK.FString SharedHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWriteSharedFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteSharedFileComplete");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedHandle, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearReadSharedFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadSharedFileCompleteDelegate(System.IntPtr ReadSharedFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadSharedFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadSharedFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadSharedFileCompleteDelegate(System.IntPtr ReadSharedFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadSharedFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadSharedFile;
    /// <summary>
    /// Function: ReadSharedFile
    /// </summary>
    public unsafe virtual bool ReadSharedFile(BmSDK.FString SharedHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadSharedFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadSharedFile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedHandle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnReadSharedFileComplete;
    /// <summary>
    /// Function: OnReadSharedFileComplete
    /// </summary>
    public unsafe virtual void OnReadSharedFileComplete(bool bWasSuccessful, BmSDK.FString SharedHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadSharedFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadSharedFileComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedHandle, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearSharedFile;
    /// <summary>
    /// Function: ClearSharedFile
    /// </summary>
    public unsafe virtual bool ClearSharedFile(BmSDK.FString SharedHandle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearSharedFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearSharedFile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedHandle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearSharedFiles;
    /// <summary>
    /// Function: ClearSharedFiles
    /// </summary>
    public unsafe virtual bool ClearSharedFiles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearSharedFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearSharedFiles");
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

    private static BmSDK.Function __fn_GetSharedFileContents;
    /// <summary>
    /// Function: GetSharedFileContents
    /// </summary>
    public unsafe virtual bool GetSharedFileContents(BmSDK.FString SharedHandle, out BmSDK.TArray<byte> FileContents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSharedFileContents, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetSharedFileContents");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedHandle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_WriteFileToScatch;
    /// <summary>
    /// Function: WriteFileToScatch
    /// </summary>
    public unsafe virtual bool WriteFileToScatch(byte LocalUserNum, BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteFileToScatch, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteFileToScatch");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FileContents = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ReadFileFromScatch;
    /// <summary>
    /// Function: ReadFileFromScatch
    /// </summary>
    public unsafe virtual bool ReadFileFromScatch(byte LocalUserNum, BmSDK.FString Filename, out BmSDK.TArray<byte> OutFileContents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadFileFromScatch, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadFileFromScatch");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutFileContents = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ClearAllDelegates;
    /// <summary>
    /// Function: ClearAllDelegates
    /// </summary>
    public unsafe virtual void ClearAllDelegates()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllDelegates, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearAllDelegates");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelDownloadFileIO;
    /// <summary>
    /// Function: CancelDownloadFileIO
    /// </summary>
    public unsafe virtual void CancelDownloadFileIO()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelDownloadFileIO, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CancelDownloadFileIO");
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

    private static BmSDK.Function __fn_ClearDeleteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: ClearDeleteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearDeleteDownloadFileCompleteDelegate(System.IntPtr DeleteDownloadFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDeleteDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDeleteDownloadFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDeleteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: AddDeleteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddDeleteDownloadFileCompleteDelegate(System.IntPtr DeleteDownloadFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDeleteDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddDeleteDownloadFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeleteDownloadFileComplete;
    /// <summary>
    /// Function: OnDeleteDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnDeleteDownloadFileComplete(bool bWasSuccessful, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeleteDownloadFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnDeleteDownloadFileComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeleteDownloadFile;
    /// <summary>
    /// Function: DeleteDownloadFile
    /// </summary>
    public unsafe virtual bool DeleteDownloadFile(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteDownloadFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteDownloadFile");
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

    private static BmSDK.Function __fn_ClearWriteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteDownloadFileCompleteDelegate(System.IntPtr WriteDownloadFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWriteDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteDownloadFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWriteDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: AddWriteDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteDownloadFileCompleteDelegate(System.IntPtr WriteDownloadFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWriteDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteDownloadFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWriteDownloadFileComplete;
    /// <summary>
    /// Function: OnWriteDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnWriteDownloadFileComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesProcessed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWriteDownloadFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteDownloadFileComplete");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesProcessed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WriteDownloadFile;
    /// <summary>
    /// Function: WriteDownloadFile
    /// </summary>
    public unsafe virtual bool WriteDownloadFile(BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents, out BmSDK.FString FileCRC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteDownloadFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteDownloadFile");
        byte* paramsPtr = stackalloc byte[52];
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
        FileCRC = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_ClearReadDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadDownloadFileCompleteDelegate(System.IntPtr ReadDownloadFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadDownloadFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadDownloadFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadDownloadFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadDownloadFileCompleteDelegate(System.IntPtr ReadDownloadFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadDownloadFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadDownloadFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadDownloadFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadDownloadFileComplete;
    /// <summary>
    /// Function: OnReadDownloadFileComplete
    /// </summary>
    public unsafe virtual void OnReadDownloadFileComplete(bool bWasSuccessful, BmSDK.FString Filename, int bytesProcessed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadDownloadFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadDownloadFileComplete");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bytesProcessed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadDownloadFile;
    /// <summary>
    /// Function: ReadDownloadFile
    /// </summary>
    public unsafe virtual bool ReadDownloadFile(BmSDK.FString Filename, out BmSDK.TArray<byte> OutFileContents, out BmSDK.FString OutFileCRC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadDownloadFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadDownloadFile");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutFileContents = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 16);
        OutFileCRC = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_GetDownloadFileSize;
    /// <summary>
    /// Function: GetDownloadFileSize
    /// </summary>
    public unsafe virtual int GetDownloadFileSize(BmSDK.FString Filename, bool KeepHandle = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDownloadFileSize, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetDownloadFileSize");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeepHandle, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_EnumerateDownloadFiles;
    /// <summary>
    /// Function: EnumerateDownloadFiles
    /// </summary>
    public unsafe virtual void EnumerateDownloadFiles(out BmSDK.TArray<BmSDK.FString> OutFiles, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnumerateDownloadFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.EnumerateDownloadFiles");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutFiles = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_EnumerateDownloadFolders;
    /// <summary>
    /// Function: EnumerateDownloadFolders
    /// </summary>
    public unsafe virtual void EnumerateDownloadFolders(out BmSDK.TArray<BmSDK.FString> OutFolders)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnumerateDownloadFolders, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.EnumerateDownloadFolders");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutFolders = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ClearDeleteUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearDeleteUserFileCompleteDelegate(System.IntPtr DeleteUserFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDeleteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDeleteUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDeleteUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddDeleteUserFileCompleteDelegate(System.IntPtr DeleteUserFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDeleteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddDeleteUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeleteUserFile;
    /// <summary>
    /// Function: DeleteUserFile
    /// </summary>
    public unsafe virtual bool DeleteUserFile(BmSDK.FString UserId, BmSDK.FString Filename, bool bShouldCloudDelete, bool bShouldLocallyDelete)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteUserFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteUserFile");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldCloudDelete, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldLocallyDelete, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_OnDeleteUserFileComplete;
    /// <summary>
    /// Function: OnDeleteUserFileComplete
    /// </summary>
    public unsafe virtual void OnDeleteUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeleteUserFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnDeleteUserFileComplete");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearWriteUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteUserFileCompleteDelegate(System.IntPtr WriteUserFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWriteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWriteUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteUserFileCompleteDelegate(System.IntPtr WriteUserFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWriteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManageLocalBackups;
    /// <summary>
    /// Function: ManageLocalBackups
    /// </summary>
    public unsafe virtual bool ManageLocalBackups(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManageLocalBackups, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ManageLocalBackups");
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

    private static BmSDK.Function __fn_WriteUserFileLocal;
    /// <summary>
    /// Function: WriteUserFileLocal
    /// </summary>
    public unsafe virtual bool WriteUserFileLocal(BmSDK.FString SaveName, out BmSDK.TArray<byte> Contents, bool isSteamBackup)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteUserFileLocal, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteUserFileLocal");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isSteamBackup, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Contents = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_WriteUserFile;
    /// <summary>
    /// Function: WriteUserFile
    /// </summary>
    public unsafe virtual bool WriteUserFile(BmSDK.FString UserId, BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteUserFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteUserFile");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FileContents = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_OnWriteUserFileComplete;
    /// <summary>
    /// Function: OnWriteUserFileComplete
    /// </summary>
    public unsafe virtual void OnWriteUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWriteUserFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteUserFileComplete");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearReadUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadUserFileCompleteDelegate(System.IntPtr ReadUserFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadUserFileCompleteDelegate(System.IntPtr ReadUserFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadUserFile;
    /// <summary>
    /// Function: ReadUserFile
    /// </summary>
    public unsafe virtual bool ReadUserFile(BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadUserFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadUserFile");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_OnReadUserFileComplete;
    /// <summary>
    /// Function: OnReadUserFileComplete
    /// </summary>
    public unsafe virtual void OnReadUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadUserFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadUserFileComplete");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUserFileList;
    /// <summary>
    /// Function: GetUserFileList
    /// </summary>
    public unsafe virtual void GetUserFileList(BmSDK.FString UserId, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile> UserFiles)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUserFileList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetUserFileList");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        UserFiles = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile>>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_ClearEnumerateUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearEnumerateUserFileCompleteDelegate(System.IntPtr EnumerateUserFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearEnumerateUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearEnumerateUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnumerateUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddEnumerateUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddEnumerateUserFileCompleteDelegate(System.IntPtr EnumerateUserFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddEnumerateUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddEnumerateUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnumerateUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnumerateUserFiles;
    /// <summary>
    /// Function: EnumerateUserFiles
    /// </summary>
    public unsafe virtual void EnumerateUserFiles(BmSDK.FString UserId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnumerateUserFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.EnumerateUserFiles");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnEnumerateUserFilesComplete;
    /// <summary>
    /// Function: OnEnumerateUserFilesComplete
    /// </summary>
    public unsafe virtual void OnEnumerateUserFilesComplete(bool bWasSuccessful, BmSDK.FString UserId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEnumerateUserFilesComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnEnumerateUserFilesComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearFile;
    /// <summary>
    /// Function: ClearFile
    /// </summary>
    public unsafe virtual bool ClearFile(BmSDK.FString UserId, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFile");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ClearFiles;
    /// <summary>
    /// Function: ClearFiles
    /// </summary>
    public unsafe virtual bool ClearFiles(BmSDK.FString UserId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFiles");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetFileContents;
    /// <summary>
    /// Function: GetFileContents
    /// </summary>
    public unsafe virtual bool GetFileContents(BmSDK.FString UserId, BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFileContents, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFileContents");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FileContents = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_NotifyVOIPPlaybackFinished;
    /// <summary>
    /// Function: NotifyVOIPPlaybackFinished
    /// </summary>
    public unsafe virtual void NotifyVOIPPlaybackFinished(BmSDK.Engine.AudioComponent VOIPAudioComponent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyVOIPPlaybackFinished, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.NotifyVOIPPlaybackFinished");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VOIPAudioComponent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnVOIPPlaybackFinished;
    /// <summary>
    /// Function: OnVOIPPlaybackFinished
    /// </summary>
    public unsafe virtual void OnVOIPPlaybackFinished(BmSDK.Engine.AudioComponent AC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnVOIPPlaybackFinished, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnVOIPPlaybackFinished");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnmuteAll;
    /// <summary>
    /// Function: UnmuteAll
    /// </summary>
    public unsafe virtual bool UnmuteAll(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnmuteAll, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnmuteAll");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MuteAll;
    /// <summary>
    /// Function: MuteAll
    /// </summary>
    public unsafe virtual bool MuteAll(byte LocalUserNum, bool bAllowFriends)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MuteAll, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.MuteAll");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowFriends, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetSpeechRecognitionObject;
    /// <summary>
    /// Function: SetSpeechRecognitionObject
    /// </summary>
    public unsafe virtual bool SetSpeechRecognitionObject(byte LocalUserNum, BmSDK.Engine.SpeechRecognition SpeechRecogObj)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpeechRecognitionObject, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetSpeechRecognitionObject");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeechRecogObj, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SelectVocabulary;
    /// <summary>
    /// Function: SelectVocabulary
    /// </summary>
    public unsafe virtual bool SelectVocabulary(byte LocalUserNum, int VocabularyId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectVocabulary, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SelectVocabulary");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VocabularyId, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearRecognitionCompleteDelegate;
    /// <summary>
    /// Function: ClearRecognitionCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearRecognitionCompleteDelegate(byte LocalUserNum, System.IntPtr RecognitionDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecognitionCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearRecognitionCompleteDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecognitionDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddRecognitionCompleteDelegate;
    /// <summary>
    /// Function: AddRecognitionCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRecognitionCompleteDelegate(byte LocalUserNum, System.IntPtr RecognitionDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRecognitionCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddRecognitionCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecognitionDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRecognitionComplete;
    /// <summary>
    /// Function: OnRecognitionComplete
    /// </summary>
    public unsafe virtual void OnRecognitionComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRecognitionComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnRecognitionComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRecognitionResults;
    /// <summary>
    /// Function: GetRecognitionResults
    /// </summary>
    public unsafe virtual bool GetRecognitionResults(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FSpeechRecognizedWord> Words)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRecognitionResults, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetRecognitionResults");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Words = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FSpeechRecognizedWord>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_StopSpeechRecognition;
    /// <summary>
    /// Function: StopSpeechRecognition
    /// </summary>
    public unsafe virtual bool StopSpeechRecognition(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeechRecognition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StopSpeechRecognition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StartSpeechRecognition;
    /// <summary>
    /// Function: StartSpeechRecognition
    /// </summary>
    public unsafe virtual bool StartSpeechRecognition(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSpeechRecognition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StartSpeechRecognition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StopNetworkedVoice;
    /// <summary>
    /// Function: StopNetworkedVoice
    /// </summary>
    public unsafe virtual void StopNetworkedVoice(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopNetworkedVoice, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StopNetworkedVoice");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StartNetworkedVoice;
    /// <summary>
    /// Function: StartNetworkedVoice
    /// </summary>
    public unsafe virtual void StartNetworkedVoice(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNetworkedVoice, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StartNetworkedVoice");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearPlayerTalkingDelegate;
    /// <summary>
    /// Function: ClearPlayerTalkingDelegate
    /// </summary>
    public unsafe virtual void ClearPlayerTalkingDelegate(System.IntPtr TalkerDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPlayerTalkingDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearPlayerTalkingDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TalkerDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPlayerTalkingDelegate;
    /// <summary>
    /// Function: AddPlayerTalkingDelegate
    /// </summary>
    public unsafe virtual void AddPlayerTalkingDelegate(System.IntPtr TalkerDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPlayerTalkingDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddPlayerTalkingDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TalkerDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPlayerTalkingStateChange;
    /// <summary>
    /// Function: OnPlayerTalkingStateChange
    /// </summary>
    public unsafe virtual void OnPlayerTalkingStateChange(BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player, bool bIsTalking)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayerTalkingStateChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnPlayerTalkingStateChange");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsTalking, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnmuteRemoteTalker;
    /// <summary>
    /// Function: UnmuteRemoteTalker
    /// </summary>
    public unsafe virtual bool UnmuteRemoteTalker(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bIsSystemWide = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnmuteRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnmuteRemoteTalker");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSystemWide, paramsPtr + 12);
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

    private static BmSDK.Function __fn_MuteRemoteTalker;
    /// <summary>
    /// Function: MuteRemoteTalker
    /// </summary>
    public unsafe virtual bool MuteRemoteTalker(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bIsSystemWide = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MuteRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.MuteRemoteTalker");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSystemWide, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetRemoteTalkerPriority;
    /// <summary>
    /// Function: SetRemoteTalkerPriority
    /// </summary>
    public unsafe virtual bool SetRemoteTalkerPriority(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, int Priority)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRemoteTalkerPriority, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetRemoteTalkerPriority");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 12);
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

    private static BmSDK.Function __fn_IsHeadsetPresent;
    /// <summary>
    /// Function: IsHeadsetPresent
    /// </summary>
    public unsafe virtual bool IsHeadsetPresent(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHeadsetPresent, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsHeadsetPresent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsRemotePlayerTalking;
    /// <summary>
    /// Function: IsRemotePlayerTalking
    /// </summary>
    public unsafe virtual bool IsRemotePlayerTalking(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRemotePlayerTalking, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsRemotePlayerTalking");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsLocalPlayerTalking;
    /// <summary>
    /// Function: IsLocalPlayerTalking
    /// </summary>
    public unsafe virtual bool IsLocalPlayerTalking(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocalPlayerTalking, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsLocalPlayerTalking");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UnregisterRemoteTalker;
    /// <summary>
    /// Function: UnregisterRemoteTalker
    /// </summary>
    public unsafe virtual bool UnregisterRemoteTalker(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnregisterRemoteTalker");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RegisterRemoteTalker;
    /// <summary>
    /// Function: RegisterRemoteTalker
    /// </summary>
    public unsafe virtual bool RegisterRemoteTalker(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterRemoteTalker");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UnregisterLocalTalker;
    /// <summary>
    /// Function: UnregisterLocalTalker
    /// </summary>
    public unsafe virtual bool UnregisterLocalTalker(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterLocalTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnregisterLocalTalker");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RegisterLocalTalker;
    /// <summary>
    /// Function: RegisterLocalTalker
    /// </summary>
    public unsafe virtual bool RegisterLocalTalker(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterLocalTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterLocalTalker");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearRequestTitleFileListCompleteDelegate;
    /// <summary>
    /// Function: ClearRequestTitleFileListCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearRequestTitleFileListCompleteDelegate(System.IntPtr RequestTitleFileListDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRequestTitleFileListCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearRequestTitleFileListCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestTitleFileListDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddRequestTitleFileListCompleteDelegate;
    /// <summary>
    /// Function: AddRequestTitleFileListCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRequestTitleFileListCompleteDelegate(System.IntPtr RequestTitleFileListDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRequestTitleFileListCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddRequestTitleFileListCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestTitleFileListDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRequestTitleFileListComplete;
    /// <summary>
    /// Function: OnRequestTitleFileListComplete
    /// </summary>
    public unsafe virtual void OnRequestTitleFileListComplete(bool bWasSuccessful, BmSDK.FString ResultStr)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRequestTitleFileListComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnRequestTitleFileListComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResultStr, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestTitleFileList;
    /// <summary>
    /// Function: RequestTitleFileList
    /// </summary>
    public unsafe virtual void RequestTitleFileList()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestTitleFileList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RequestTitleFileList");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearDownloadedFile;
    /// <summary>
    /// Function: ClearDownloadedFile
    /// </summary>
    public unsafe virtual bool ClearDownloadedFile(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDownloadedFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDownloadedFile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ClearDownloadedFiles;
    /// <summary>
    /// Function: ClearDownloadedFiles
    /// </summary>
    public unsafe virtual bool ClearDownloadedFiles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDownloadedFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDownloadedFiles");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTitleFileState;
    /// <summary>
    /// Function: GetTitleFileState
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetTitleFileState(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTitleFileState, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetTitleFileState");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetTitleFileContents;
    /// <summary>
    /// Function: GetTitleFileContents
    /// </summary>
    public unsafe virtual bool GetTitleFileContents(BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTitleFileContents, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetTitleFileContents");
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

    private static BmSDK.Function __fn_ClearReadTitleFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadTitleFileCompleteDelegate(System.IntPtr ReadTitleFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadTitleFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadTitleFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadTitleFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadTitleFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadTitleFileCompleteDelegate(System.IntPtr ReadTitleFileCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadTitleFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadTitleFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadTitleFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadTitleFile;
    /// <summary>
    /// Function: ReadTitleFile
    /// </summary>
    public unsafe virtual bool ReadTitleFile(BmSDK.FString FileToRead)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadTitleFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadTitleFile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileToRead, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnReadTitleFileComplete;
    /// <summary>
    /// Function: OnReadTitleFileComplete
    /// </summary>
    public unsafe virtual void OnReadTitleFileComplete(bool bWasSuccessful, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadTitleFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadTitleFileComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearSaveGames;
    /// <summary>
    /// Function: ClearSaveGames
    /// </summary>
    public unsafe virtual bool ClearSaveGames(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearSaveGames, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearSaveGames");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DeleteSaveGame;
    /// <summary>
    /// Function: DeleteSaveGame
    /// </summary>
    public unsafe virtual bool DeleteSaveGame(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteSaveGame, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteSaveGame");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_ClearWriteSaveGameDataComplete;
    /// <summary>
    /// Function: ClearWriteSaveGameDataComplete
    /// </summary>
    public unsafe virtual void ClearWriteSaveGameDataComplete(byte LocalUserNum, System.IntPtr WriteSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWriteSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteSaveGameDataComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWriteSaveGameDataComplete;
    /// <summary>
    /// Function: AddWriteSaveGameDataComplete
    /// </summary>
    public unsafe virtual void AddWriteSaveGameDataComplete(byte LocalUserNum, System.IntPtr WriteSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWriteSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteSaveGameDataComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWriteSaveGameDataComplete;
    /// <summary>
    /// Function: OnWriteSaveGameDataComplete
    /// </summary>
    public unsafe virtual void OnWriteSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWriteSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteSaveGameDataComplete");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WriteSaveGameData;
    /// <summary>
    /// Function: WriteSaveGameData
    /// </summary>
    public unsafe virtual bool WriteSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName, out BmSDK.TArray<byte> SaveGameData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteSaveGameData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteSaveGameData");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 56);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_ClearReadSaveGameDataComplete;
    /// <summary>
    /// Function: ClearReadSaveGameDataComplete
    /// </summary>
    public unsafe virtual void ClearReadSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadSaveGameDataComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadSaveGameDataComplete;
    /// <summary>
    /// Function: AddReadSaveGameDataComplete
    /// </summary>
    public unsafe virtual void AddReadSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadSaveGameDataComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadSaveGameDataComplete;
    /// <summary>
    /// Function: OnReadSaveGameDataComplete
    /// </summary>
    public unsafe virtual void OnReadSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadSaveGameDataComplete");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSaveGameData;
    /// <summary>
    /// Function: GetSaveGameData
    /// </summary>
    public unsafe virtual bool GetSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName, out byte bIsValid, out BmSDK.TArray<byte> SaveGameData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSaveGameData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetSaveGameData");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bIsValid);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsValid, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bIsValid = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 56);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 60);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 76);
    }

    private static BmSDK.Function __fn_ReadSaveGameData;
    /// <summary>
    /// Function: ReadSaveGameData
    /// </summary>
    public unsafe virtual bool ReadSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadSaveGameData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadSaveGameData");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_GetAvailableDownloadCounts;
    /// <summary>
    /// Function: GetAvailableDownloadCounts
    /// </summary>
    public unsafe virtual void GetAvailableDownloadCounts(byte LocalUserNum, out int NewDownloads, out int TotalDownloads)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAvailableDownloadCounts, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetAvailableDownloadCounts");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewDownloads);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDownloads, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TotalDownloads);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalDownloads, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewDownloads = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        TotalDownloads = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_ClearQueryAvailableDownloadsComplete;
    /// <summary>
    /// Function: ClearQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe virtual void ClearQueryAvailableDownloadsComplete(byte LocalUserNum, System.IntPtr QueryDownloadsDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearQueryAvailableDownloadsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearQueryAvailableDownloadsComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueryDownloadsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddQueryAvailableDownloadsComplete;
    /// <summary>
    /// Function: AddQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe virtual void AddQueryAvailableDownloadsComplete(byte LocalUserNum, System.IntPtr QueryDownloadsDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddQueryAvailableDownloadsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddQueryAvailableDownloadsComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueryDownloadsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnQueryAvailableDownloadsComplete;
    /// <summary>
    /// Function: OnQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe virtual void OnQueryAvailableDownloadsComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnQueryAvailableDownloadsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnQueryAvailableDownloadsComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueryAvailableDownloads;
    /// <summary>
    /// Function: QueryAvailableDownloads
    /// </summary>
    public unsafe virtual bool QueryAvailableDownloads(byte LocalUserNum, int CategoryMask = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueryAvailableDownloads, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.QueryAvailableDownloads");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CategoryMask, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearCrossTitleSaveGames;
    /// <summary>
    /// Function: ClearCrossTitleSaveGames
    /// </summary>
    public unsafe virtual bool ClearCrossTitleSaveGames(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCrossTitleSaveGames, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearCrossTitleSaveGames");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearReadCrossTitleSaveGameDataComplete;
    /// <summary>
    /// Function: ClearReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe virtual void ClearReadCrossTitleSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadCrossTitleSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadCrossTitleSaveGameDataComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadCrossTitleSaveGameDataComplete;
    /// <summary>
    /// Function: AddReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe virtual void AddReadCrossTitleSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadCrossTitleSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadCrossTitleSaveGameDataComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadCrossTitleSaveGameDataComplete;
    /// <summary>
    /// Function: OnReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe virtual void OnReadCrossTitleSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadCrossTitleSaveGameDataComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadCrossTitleSaveGameDataComplete");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCrossTitleSaveGameData;
    /// <summary>
    /// Function: GetCrossTitleSaveGameData
    /// </summary>
    public unsafe virtual bool GetCrossTitleSaveGameData(byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName, out byte bIsValid, out BmSDK.TArray<byte> SaveGameData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCrossTitleSaveGameData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetCrossTitleSaveGameData");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 44);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bIsValid);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsValid, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bIsValid = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 60);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 64);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 80);
    }

    private static BmSDK.Function __fn_ReadCrossTitleSaveGameData;
    /// <summary>
    /// Function: ReadCrossTitleSaveGameData
    /// </summary>
    public unsafe virtual bool ReadCrossTitleSaveGameData(byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadCrossTitleSaveGameData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadCrossTitleSaveGameData");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_ClearReadCrossTitleContentCompleteDelegate;
    /// <summary>
    /// Function: ClearReadCrossTitleContentCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadCrossTitleContentCompleteDelegate(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadCrossTitleContentCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadCrossTitleContentCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadCrossTitleContentCompleteDelegate;
    /// <summary>
    /// Function: AddReadCrossTitleContentCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadCrossTitleContentCompleteDelegate(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadCrossTitleContentCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadCrossTitleContentCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadCrossTitleContentComplete;
    /// <summary>
    /// Function: OnReadCrossTitleContentComplete
    /// </summary>
    public unsafe virtual void OnReadCrossTitleContentComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadCrossTitleContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadCrossTitleContentComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCrossTitleContentList;
    /// <summary>
    /// Function: GetCrossTitleContentList
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineCrossTitleContent> ContentList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCrossTitleContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetCrossTitleContentList");
        byte* paramsPtr = stackalloc byte[21];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineCrossTitleContent>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ClearCrossTitleContentList;
    /// <summary>
    /// Function: ClearCrossTitleContentList
    /// </summary>
    public unsafe virtual void ClearCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCrossTitleContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearCrossTitleContentList");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadCrossTitleContentList;
    /// <summary>
    /// Function: ReadCrossTitleContentList
    /// </summary>
    public unsafe virtual bool ReadCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int TitleId = default, int DeviceID = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadCrossTitleContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadCrossTitleContentList");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetUserLanguage;
    /// <summary>
    /// Function: GetUserLanguage
    /// </summary>
    public unsafe virtual BmSDK.FString GetUserLanguage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUserLanguage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetUserLanguage");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUserCountryCode;
    /// <summary>
    /// Function: GetUserCountryCode
    /// </summary>
    public unsafe virtual BmSDK.FString GetUserCountryCode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUserCountryCode, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetUserCountryCode");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowPS4DownloadList;
    /// <summary>
    /// Function: ShowPS4DownloadList
    /// </summary>
    public unsafe virtual void ShowPS4DownloadList(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPS4DownloadList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowPS4DownloadList");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowPS4StoreIcon;
    /// <summary>
    /// Function: ShowPS4StoreIcon
    /// </summary>
    public unsafe virtual void ShowPS4StoreIcon(bool bShow, int Position = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPS4StoreIcon, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowPS4StoreIcon");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BrowseInGameStoreItem;
    /// <summary>
    /// Function: BrowseInGameStoreItem
    /// </summary>
    public unsafe virtual void BrowseInGameStoreItem(byte LocalUserNum, BmSDK.FString ItemId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BrowseInGameStoreItem, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.BrowseInGameStoreItem");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemId, paramsPtr + 4);
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

    private static BmSDK.Function __fn_PurchaseInGameStoreItem;
    /// <summary>
    /// Function: PurchaseInGameStoreItem
    /// </summary>
    public unsafe virtual void PurchaseInGameStoreItem(byte LocalUserNum, BmSDK.FString ItemId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PurchaseInGameStoreItem, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.PurchaseInGameStoreItem");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemId, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ClearPurchaseInGameStoreContentComplete;
    /// <summary>
    /// Function: ClearPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void ClearPurchaseInGameStoreContentComplete(byte LocalUserNum, System.IntPtr PurchaseInGameStoreContentComplete)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPurchaseInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearPurchaseInGameStoreContentComplete");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurchaseInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPurchaseInGameStoreContentComplete;
    /// <summary>
    /// Function: AddPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void AddPurchaseInGameStoreContentComplete(byte LocalUserNum, System.IntPtr PurchaseInGameStoreContentComplete)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPurchaseInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddPurchaseInGameStoreContentComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurchaseInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPurchaseInGameStoreContentComplete;
    /// <summary>
    /// Function: OnPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void OnPurchaseInGameStoreContentComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPurchaseInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnPurchaseInGameStoreContentComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInGameStoreContentList;
    /// <summary>
    /// Function: GetInGameStoreContentList
    /// </summary>
    public unsafe virtual void GetInGameStoreContentList(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent> ContentList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInGameStoreContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetInGameStoreContentList");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ContentList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_ReadInGameStoreContentList;
    /// <summary>
    /// Function: ReadInGameStoreContentList
    /// </summary>
    public unsafe virtual bool ReadInGameStoreContentList(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadInGameStoreContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadInGameStoreContentList");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearInGameStoreContentList;
    /// <summary>
    /// Function: ClearInGameStoreContentList
    /// </summary>
    public unsafe virtual void ClearInGameStoreContentList(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearInGameStoreContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearInGameStoreContentList");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearReadInGameStoreContentComplete;
    /// <summary>
    /// Function: ClearReadInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void ClearReadInGameStoreContentComplete(byte LocalUserNum, System.IntPtr ReadInGameStoreContentComplete)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadInGameStoreContentComplete");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadInGameStoreContentComplete;
    /// <summary>
    /// Function: AddReadInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void AddReadInGameStoreContentComplete(byte LocalUserNum, System.IntPtr ReadInGameStoreContentComplete)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadInGameStoreContentComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadInGameStoreContentComplete;
    /// <summary>
    /// Function: OnReadInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void OnReadInGameStoreContentComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadInGameStoreContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadInGameStoreContentComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearContentStatusChangeDelegate;
    /// <summary>
    /// Function: ClearContentStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearContentStatusChangeDelegate(System.IntPtr ContentStatusChangeDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearContentStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearContentStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentStatusChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddContentStatusChangeDelegate;
    /// <summary>
    /// Function: AddContentStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddContentStatusChangeDelegate(System.IntPtr ContentStatusChangeDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddContentStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddContentStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentStatusChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnContentStatusChange;
    /// <summary>
    /// Function: OnContentStatusChange
    /// </summary>
    public unsafe virtual void OnContentStatusChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnContentStatusChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnContentStatusChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetContentList;
    /// <summary>
    /// Function: GetContentList
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent> ContentList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetContentList");
        byte* paramsPtr = stackalloc byte[21];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ClearContentList;
    /// <summary>
    /// Function: ClearContentList
    /// </summary>
    public unsafe virtual void ClearContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearContentList");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
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

    private static BmSDK.Function __fn_ReadContentList;
    /// <summary>
    /// Function: ReadContentList
    /// </summary>
    public unsafe virtual bool ReadContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int DeviceID = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadContentList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadContentList");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_HasContentUpdated;
    /// <summary>
    /// Function: HasContentUpdated
    /// </summary>
    public unsafe virtual bool HasContentUpdated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasContentUpdated, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.HasContentUpdated");
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

    private static BmSDK.Function __fn_ClearReadContentComplete;
    /// <summary>
    /// Function: ClearReadContentComplete
    /// </summary>
    public unsafe virtual void ClearReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadContentComplete");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadContentComplete;
    /// <summary>
    /// Function: AddReadContentComplete
    /// </summary>
    public unsafe virtual void AddReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadContentComplete");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadContentComplete;
    /// <summary>
    /// Function: OnReadContentComplete
    /// </summary>
    public unsafe virtual void OnReadContentComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadContentComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadContentComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearContentChangeDelegate;
    /// <summary>
    /// Function: ClearContentChangeDelegate
    /// </summary>
    public unsafe virtual void ClearContentChangeDelegate(System.IntPtr ContentDelegate, byte LocalUserNum = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearContentChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearContentChangeDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddContentChangeDelegate;
    /// <summary>
    /// Function: AddContentChangeDelegate
    /// </summary>
    public unsafe virtual void AddContentChangeDelegate(System.IntPtr ContentDelegate, byte LocalUserNum = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddContentChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddContentChangeDelegate");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnContentChange;
    /// <summary>
    /// Function: OnContentChange
    /// </summary>
    public unsafe virtual void OnContentChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnContentChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnContentChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalcAggregateSkill;
    /// <summary>
    /// Function: CalcAggregateSkill
    /// </summary>
    public unsafe virtual void CalcAggregateSkill(BmSDK.TArray<double> Mus, BmSDK.TArray<double> Sigmas, out double OutAggregateMu, out double OutAggregateSigma)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcAggregateSkill, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CalcAggregateSkill");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sigmas, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutAggregateMu);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutAggregateMu, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutAggregateSigma);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutAggregateSigma, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutAggregateMu = BmSDK.Framework.MarshalUtil.ToManaged<double>(paramsPtr + 32);
        OutAggregateSigma = BmSDK.Framework.MarshalUtil.ToManaged<double>(paramsPtr + 40);
        return;
    }

    private static BmSDK.Function __fn_RegisterStatGuid;
    /// <summary>
    /// Function: RegisterStatGuid
    /// </summary>
    public unsafe virtual bool RegisterStatGuid(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, out BmSDK.FString ClientStatGuid)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterStatGuid");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClientStatGuid = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetClientStatGuid;
    /// <summary>
    /// Function: GetClientStatGuid
    /// </summary>
    public unsafe virtual BmSDK.FString GetClientStatGuid()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClientStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetClientStatGuid");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearRegisterHostStatGuidCompleteDelegateDelegate;
    /// <summary>
    /// Function: ClearRegisterHostStatGuidCompleteDelegateDelegate
    /// </summary>
    public unsafe virtual void ClearRegisterHostStatGuidCompleteDelegateDelegate(System.IntPtr RegisterHostStatGuidCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRegisterHostStatGuidCompleteDelegateDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearRegisterHostStatGuidCompleteDelegateDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterHostStatGuidCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddRegisterHostStatGuidCompleteDelegate;
    /// <summary>
    /// Function: AddRegisterHostStatGuidCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRegisterHostStatGuidCompleteDelegate(System.IntPtr RegisterHostStatGuidCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRegisterHostStatGuidCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddRegisterHostStatGuidCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterHostStatGuidCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRegisterHostStatGuidComplete;
    /// <summary>
    /// Function: OnRegisterHostStatGuidComplete
    /// </summary>
    public unsafe virtual void OnRegisterHostStatGuidComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRegisterHostStatGuidComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnRegisterHostStatGuidComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterHostStatGuid;
    /// <summary>
    /// Function: RegisterHostStatGuid
    /// </summary>
    public unsafe virtual bool RegisterHostStatGuid(out BmSDK.FString HostStatGuid)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterHostStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterHostStatGuid");
        byte* paramsPtr = stackalloc byte[20];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HostStatGuid = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetHostStatGuid;
    /// <summary>
    /// Function: GetHostStatGuid
    /// </summary>
    public unsafe virtual BmSDK.FString GetHostStatGuid()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHostStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetHostStatGuid");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WriteOnlinePlayerScores;
    /// <summary>
    /// Function: WriteOnlinePlayerScores
    /// </summary>
    public unsafe virtual bool WriteOnlinePlayerScores(BmSDK.FName SessionName, int LeaderboardId, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore> PlayerScores)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteOnlinePlayerScores, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteOnlinePlayerScores");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderboardId, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerScores = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore>>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_CreateLeaderboard;
    /// <summary>
    /// Function: CreateLeaderboard
    /// </summary>
    public unsafe virtual bool CreateLeaderboard(BmSDK.FString LeaderboardName, BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardSortType SortType, BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardFormat DisplayFormat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLeaderboard, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateLeaderboard");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderboardName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SortType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisplayFormat, paramsPtr + 17);
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

    private static BmSDK.Function __fn_ResetStats;
    /// <summary>
    /// Function: ResetStats
    /// </summary>
    public unsafe virtual bool ResetStats(bool bResetAchievements)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ResetStats");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetAchievements, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearFlushOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: ClearFlushOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearFlushOnlineStatsCompleteDelegate(System.IntPtr FlushOnlineStatsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFlushOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFlushOnlineStatsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlushOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFlushOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: AddFlushOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddFlushOnlineStatsCompleteDelegate(System.IntPtr FlushOnlineStatsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFlushOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFlushOnlineStatsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlushOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFlushOnlineStatsComplete;
    /// <summary>
    /// Function: OnFlushOnlineStatsComplete
    /// </summary>
    public unsafe virtual void OnFlushOnlineStatsComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFlushOnlineStatsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFlushOnlineStatsComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlushOnlineStats;
    /// <summary>
    /// Function: FlushOnlineStats
    /// </summary>
    public unsafe virtual bool FlushOnlineStats(BmSDK.FName SessionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushOnlineStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.FlushOnlineStats");
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
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_WriteOnlineStats;
    /// <summary>
    /// Function: WriteOnlineStats
    /// </summary>
    public unsafe virtual bool WriteOnlineStats(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player, BmSDK.Engine.OnlineStatsWrite StatsWrite)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteOnlineStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteOnlineStats");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsWrite, paramsPtr + 16);
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

    private static BmSDK.Function __fn_FreeStats;
    /// <summary>
    /// Function: FreeStats
    /// </summary>
    public unsafe virtual void FreeStats(BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreeStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.FreeStats");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearReadOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadOnlineStatsCompleteDelegate(System.IntPtr ReadOnlineStatsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadOnlineStatsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: AddReadOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadOnlineStatsCompleteDelegate(System.IntPtr ReadOnlineStatsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadOnlineStatsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadOnlineStatsComplete;
    /// <summary>
    /// Function: OnReadOnlineStatsComplete
    /// </summary>
    public unsafe virtual void OnReadOnlineStatsComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadOnlineStatsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadOnlineStatsComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadOnlineStatsByRankAroundPlayer;
    /// <summary>
    /// Function: ReadOnlineStatsByRankAroundPlayer
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsByRankAroundPlayer(byte LocalUserNum, BmSDK.Engine.OnlineStatsRead StatsRead, int NumRows = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadOnlineStatsByRankAroundPlayer, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStatsByRankAroundPlayer");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumRows, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ReadOnlineStatsByRank;
    /// <summary>
    /// Function: ReadOnlineStatsByRank
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsByRank(BmSDK.Engine.OnlineStatsRead StatsRead, int StartIndex = default, int NumToRead = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadOnlineStatsByRank, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStatsByRank");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumToRead, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ReadOnlineStatsForFriends;
    /// <summary>
    /// Function: ReadOnlineStatsForFriends
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsForFriends(byte LocalUserNum, BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadOnlineStatsForFriends, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStatsForFriends");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ReadOnlineStats;
    /// <summary>
    /// Function: ReadOnlineStats
    /// </summary>
    public unsafe virtual bool ReadOnlineStats(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadOnlineStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStats");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Players = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_DebugWriteLBForUser;
    /// <summary>
    /// Function: DebugWriteLBForUser
    /// </summary>
    public unsafe virtual void DebugWriteLBForUser(BmSDK.FString User, int BoardID, int RankValue, BmSDK.TArray<int> StatsArray)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugWriteLBForUser, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DebugWriteLBForUser");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RankValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsArray, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropOnlineStatsRead;
    /// <summary>
    /// Function: DropOnlineStatsRead
    /// </summary>
    public unsafe virtual void DropOnlineStatsRead()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropOnlineStatsRead, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DropOnlineStatsRead");
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

    private static BmSDK.Function __fn_ResetOnlineStatsForAllUsers;
    /// <summary>
    /// Function: ResetOnlineStatsForAllUsers
    /// </summary>
    public unsafe virtual bool ResetOnlineStatsForAllUsers(int BoardID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetOnlineStatsForAllUsers, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ResetOnlineStatsForAllUsers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ResetOnlineStatsForUser;
    /// <summary>
    /// Function: ResetOnlineStatsForUser
    /// </summary>
    public unsafe virtual bool ResetOnlineStatsForUser(byte LocalUserNum, int BoardID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetOnlineStatsForUser, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ResetOnlineStatsForUser");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetLocalAccountNames;
    /// <summary>
    /// Function: GetLocalAccountNames
    /// </summary>
    public unsafe virtual bool GetLocalAccountNames(out BmSDK.TArray<BmSDK.FString> Accounts)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalAccountNames, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetLocalAccountNames");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Accounts = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DeleteLocalAccount;
    /// <summary>
    /// Function: DeleteLocalAccount
    /// </summary>
    public unsafe virtual bool DeleteLocalAccount(BmSDK.FString UserName, BmSDK.FString Password = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteLocalAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteLocalAccount");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_RenameLocalAccount;
    /// <summary>
    /// Function: RenameLocalAccount
    /// </summary>
    public unsafe virtual bool RenameLocalAccount(BmSDK.FString NewUserName, BmSDK.FString OldUserName, BmSDK.FString Password = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RenameLocalAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RenameLocalAccount");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUserName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldUserName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_CreateLocalAccount;
    /// <summary>
    /// Function: CreateLocalAccount
    /// </summary>
    public unsafe virtual bool CreateLocalAccount(BmSDK.FString UserName, BmSDK.FString Password = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLocalAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateLocalAccount");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ClearCreateOnlineAccountCompletedDelegate;
    /// <summary>
    /// Function: ClearCreateOnlineAccountCompletedDelegate
    /// </summary>
    public unsafe virtual void ClearCreateOnlineAccountCompletedDelegate(System.IntPtr AccountCreateDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCreateOnlineAccountCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearCreateOnlineAccountCompletedDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AccountCreateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCreateOnlineAccountCompletedDelegate;
    /// <summary>
    /// Function: AddCreateOnlineAccountCompletedDelegate
    /// </summary>
    public unsafe virtual void AddCreateOnlineAccountCompletedDelegate(System.IntPtr AccountCreateDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCreateOnlineAccountCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddCreateOnlineAccountCompletedDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AccountCreateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCreateOnlineAccountCompleted;
    /// <summary>
    /// Function: OnCreateOnlineAccountCompleted
    /// </summary>
    public unsafe virtual void OnCreateOnlineAccountCompleted(BmSDK.Engine.OnlineSubsystem.EOnlineAccountCreateStatus ErrorStatus)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCreateOnlineAccountCompleted, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnCreateOnlineAccountCompleted");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorStatus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateOnlineAccount;
    /// <summary>
    /// Function: CreateOnlineAccount
    /// </summary>
    public unsafe virtual bool CreateOnlineAccount(BmSDK.FString UserName, BmSDK.FString Password, BmSDK.FString EmailAddress, BmSDK.FString ProductKey = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateOnlineAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateOnlineAccount");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EmailAddress, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProductKey, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_IsExternalRemoteDevice;
    /// <summary>
    /// Function: IsExternalRemoteDevice
    /// </summary>
    public unsafe virtual bool IsExternalRemoteDevice()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsExternalRemoteDevice, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsExternalRemoteDevice");
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

    private static BmSDK.Function __fn_OpenWebBrowser;
    /// <summary>
    /// Function: OpenWebBrowser
    /// </summary>
    public unsafe virtual void OpenWebBrowser(BmSDK.FString sURL)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenWebBrowser, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OpenWebBrowser");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sURL, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetNpAvailabilityForUser;
    /// <summary>
    /// Function: GetNpAvailabilityForUser
    /// </summary>
    public unsafe virtual int GetNpAvailabilityForUser(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNpAvailabilityForUser, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetNpAvailabilityForUser");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckNpAvailabilityForUser;
    /// <summary>
    /// Function: CheckNpAvailabilityForUser
    /// </summary>
    public unsafe virtual void CheckNpAvailabilityForUser(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckNpAvailabilityForUser, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CheckNpAvailabilityForUser");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StreamingInstall_Poll;
    /// <summary>
    /// Function: StreamingInstall_Poll
    /// </summary>
    public unsafe virtual int StreamingInstall_Poll(out int Percent, out int Time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StreamingInstall_Poll, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StreamingInstall_Poll");
        byte* paramsPtr = stackalloc byte[12];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Percent);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percent, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Percent = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        Time = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_StreamingInstall_CheckChunk;
    /// <summary>
    /// Function: StreamingInstall_CheckChunk
    /// </summary>
    public unsafe virtual bool StreamingInstall_CheckChunk(int Chunk)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StreamingInstall_CheckChunk, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StreamingInstall_CheckChunk");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Chunk, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StreamingInstall_IsFinished;
    /// <summary>
    /// Function: StreamingInstall_IsFinished
    /// </summary>
    public unsafe virtual bool StreamingInstall_IsFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StreamingInstall_IsFinished, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StreamingInstall_IsFinished");
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

    private static BmSDK.Function __fn_SetDurangoKinectState;
    /// <summary>
    /// Function: SetDurangoKinectState
    /// </summary>
    public unsafe virtual void SetDurangoKinectState(bool bEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDurangoKinectState, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetDurangoKinectState");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGTCStates;
    /// <summary>
    /// Function: SetGTCStates
    /// </summary>
    public unsafe virtual void SetGTCStates(bool bPlayEnabled, bool bPauseEnabled, bool bMenuEnabled, bool bViewEnabled, bool bBackEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGTCStates, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetGTCStates");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPauseEnabled, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMenuEnabled, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bViewEnabled, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBackEnabled, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGTCState;
    /// <summary>
    /// Function: SetGTCState
    /// </summary>
    public unsafe virtual void SetGTCState(BmSDK.Engine.OnlineSubsystem.EGTCCommand Id, bool bState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGTCState, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetGTCState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearGTCCommandDelegate;
    /// <summary>
    /// Function: ClearGTCCommandDelegate
    /// </summary>
    public unsafe virtual void ClearGTCCommandDelegate(System.IntPtr GTCCommandDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGTCCommandDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearGTCCommandDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GTCCommandDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGTCCommandDelegate;
    /// <summary>
    /// Function: AddGTCCommandDelegate
    /// </summary>
    public unsafe virtual void AddGTCCommandDelegate(System.IntPtr GTCCommandDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGTCCommandDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddGTCCommandDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GTCCommandDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGTCCommand;
    /// <summary>
    /// Function: OnGTCCommand
    /// </summary>
    public unsafe virtual void OnGTCCommand(BmSDK.Engine.OnlineSubsystem.EGTCCommand NewCommand)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGTCCommand, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnGTCCommand");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCommand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavigateBack;
    /// <summary>
    /// Function: NavigateBack
    /// </summary>
    public unsafe virtual void NavigateBack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavigateBack, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.NavigateBack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenHelpManual;
    /// <summary>
    /// Function: OpenHelpManual
    /// </summary>
    public unsafe virtual void OpenHelpManual(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenHelpManual, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OpenHelpManual");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VideoRecordStop;
    /// <summary>
    /// Function: VideoRecordStop
    /// </summary>
    public unsafe virtual bool VideoRecordStop(byte LocalUserNum, byte VideoId, BmSDK.FString TitleStr)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VideoRecordStop, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.VideoRecordStop");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoId, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleStr, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_VideoRecordStart;
    /// <summary>
    /// Function: VideoRecordStart
    /// </summary>
    public unsafe virtual bool VideoRecordStart(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VideoRecordStart, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.VideoRecordStart");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_VideoRecord;
    /// <summary>
    /// Function: VideoRecord
    /// </summary>
    public unsafe virtual void VideoRecord(byte LocalUserNum, byte VideoId, BmSDK.FString TitleStr, float TimeStart, float TimeStop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VideoRecord, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.VideoRecord");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoId, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleStr, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeStart, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeStop, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VideoRecordSetGameSectionId;
    /// <summary>
    /// Function: VideoRecordSetGameSectionId
    /// </summary>
    public unsafe virtual void VideoRecordSetGameSectionId(int SectionId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VideoRecordSetGameSectionId, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.VideoRecordSetGameSectionId");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SectionId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VideoRecordAllowed;
    /// <summary>
    /// Function: VideoRecordAllowed
    /// </summary>
    public unsafe virtual void VideoRecordAllowed(bool bEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VideoRecordAllowed, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.VideoRecordAllowed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsVideoRecordAllowed;
    /// <summary>
    /// Function: IsVideoRecordAllowed
    /// </summary>
    public unsafe virtual bool IsVideoRecordAllowed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVideoRecordAllowed, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsVideoRecordAllowed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnBindAllPlayers;
    /// <summary>
    /// Function: UnBindAllPlayers
    /// </summary>
    public unsafe virtual void UnBindAllPlayers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnBindAllPlayers, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnBindAllPlayers");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnBindPlayer;
    /// <summary>
    /// Function: UnBindPlayer
    /// </summary>
    public unsafe virtual void UnBindPlayer(int ControllerId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnBindPlayer, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnBindPlayer");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResumePlayer;
    /// <summary>
    /// Function: ResumePlayer
    /// </summary>
    public unsafe virtual int ResumePlayer(int ControllerId, int ControllerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResumePlayer, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ResumePlayer");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ReBindPlayer;
    /// <summary>
    /// Function: ReBindPlayer
    /// </summary>
    public unsafe virtual void ReBindPlayer(int ControllerId, int ControllerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReBindPlayer, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReBindPlayer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BindPlayer;
    /// <summary>
    /// Function: BindPlayer
    /// </summary>
    public unsafe virtual int BindPlayer(int ControllerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BindPlayer, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.BindPlayer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBoundCount;
    /// <summary>
    /// Function: GetBoundCount
    /// </summary>
    public unsafe virtual int GetBoundCount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoundCount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetBoundCount");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReadOnlineAvatar;
    /// <summary>
    /// Function: ReadOnlineAvatar
    /// </summary>
    public unsafe virtual void ReadOnlineAvatar(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId, int Size, System.IntPtr ReadOnlineAvatarCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadOnlineAvatar, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineAvatar");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineAvatarCompleteDelegate, paramsPtr + 12);
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

    private static BmSDK.Function __fn_OnReadOnlineAvatarComplete;
    /// <summary>
    /// Function: OnReadOnlineAvatarComplete
    /// </summary>
    public unsafe virtual void OnReadOnlineAvatarComplete(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId, BmSDK.Engine.Texture2D Avatar)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadOnlineAvatarComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadOnlineAvatarComplete");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Avatar, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCustomMessageUI;
    /// <summary>
    /// Function: ShowCustomMessageUI
    /// </summary>
    public unsafe virtual bool ShowCustomMessageUI(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Recipients, BmSDK.FString MessageTitle, BmSDK.FString NonEditableMessage, BmSDK.FString EditableMessage = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCustomMessageUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowCustomMessageUI");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageTitle, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NonEditableMessage, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EditableMessage, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Recipients = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_ClearCrossTitleProfileSettings;
    /// <summary>
    /// Function: ClearCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual void ClearCrossTitleProfileSettings(byte LocalUserNum, int TitleId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCrossTitleProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearCrossTitleProfileSettings");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCrossTitleProfileSettings;
    /// <summary>
    /// Function: GetCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineProfileSettings GetCrossTitleProfileSettings(byte LocalUserNum, int TitleId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCrossTitleProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetCrossTitleProfileSettings");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineProfileSettings>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearReadCrossTitleProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadCrossTitleProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadCrossTitleProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadCrossTitleProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadCrossTitleProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: AddReadCrossTitleProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadCrossTitleProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadCrossTitleProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadCrossTitleProfileSettingsComplete;
    /// <summary>
    /// Function: OnReadCrossTitleProfileSettingsComplete
    /// </summary>
    public unsafe virtual void OnReadCrossTitleProfileSettingsComplete(byte LocalUserNum, int TitleId, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadCrossTitleProfileSettingsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadCrossTitleProfileSettingsComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadCrossTitleProfileSettings;
    /// <summary>
    /// Function: ReadCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual bool ReadCrossTitleProfileSettings(byte LocalUserNum, int TitleId, BmSDK.Engine.OnlineProfileSettings ProfileSettings)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadCrossTitleProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadCrossTitleProfileSettings");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UnlockAvatarAward;
    /// <summary>
    /// Function: UnlockAvatarAward
    /// </summary>
    public unsafe virtual bool UnlockAvatarAward(byte LocalUserNum, int AvatarItemId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAvatarAward, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnlockAvatarAward");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvatarItemId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetTimeSinceGuideLastClosed;
    /// <summary>
    /// Function: GetTimeSinceGuideLastClosed
    /// </summary>
    public unsafe virtual float GetTimeSinceGuideLastClosed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeSinceGuideLastClosed, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetTimeSinceGuideLastClosed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateInfocastSystem;
    /// <summary>
    /// Function: CreateInfocastSystem
    /// </summary>
    public unsafe virtual void CreateInfocastSystem()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateInfocastSystem, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateInfocastSystem");
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

    private static BmSDK.Function __fn_ClearNewInfocastDelegate;
    /// <summary>
    /// Function: ClearNewInfocastDelegate
    /// </summary>
    public unsafe virtual void ClearNewInfocastDelegate(System.IntPtr InfocastDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearNewInfocastDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearNewInfocastDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfocastDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddNewInfocastDelegate;
    /// <summary>
    /// Function: AddNewInfocastDelegate
    /// </summary>
    public unsafe virtual void AddNewInfocastDelegate(System.IntPtr InfocastDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNewInfocastDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddNewInfocastDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfocastDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnNewInfocast;
    /// <summary>
    /// Function: OnNewInfocast
    /// </summary>
    public unsafe virtual void OnNewInfocast(BmSDK.FString Infocast)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnNewInfocast, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnNewInfocast");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Infocast, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCustomPlayersUI;
    /// <summary>
    /// Function: ShowCustomPlayersUI
    /// </summary>
    public unsafe virtual bool ShowCustomPlayersUI(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.FString Title, BmSDK.FString Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCustomPlayersUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowCustomPlayersUI");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Players = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_ShowPlayersUI;
    /// <summary>
    /// Function: ShowPlayersUI
    /// </summary>
    public unsafe virtual bool ShowPlayersUI(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPlayersUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowPlayersUI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ShowGuideUI;
    /// <summary>
    /// Function: ShowGuideUI
    /// </summary>
    public unsafe virtual bool ShowGuideUI()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowGuideUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowGuideUI");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowFriendsInviteUI;
    /// <summary>
    /// Function: ShowFriendsInviteUI
    /// </summary>
    public unsafe virtual bool ShowFriendsInviteUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFriendsInviteUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowFriendsInviteUI");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearProfileDataChangedDelegate;
    /// <summary>
    /// Function: ClearProfileDataChangedDelegate
    /// </summary>
    public unsafe virtual void ClearProfileDataChangedDelegate(byte LocalUserNum, System.IntPtr ProfileDataChangedDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearProfileDataChangedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearProfileDataChangedDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileDataChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddProfileDataChangedDelegate;
    /// <summary>
    /// Function: AddProfileDataChangedDelegate
    /// </summary>
    public unsafe virtual void AddProfileDataChangedDelegate(byte LocalUserNum, System.IntPtr ProfileDataChangedDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddProfileDataChangedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddProfileDataChangedDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileDataChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnProfileDataChanged;
    /// <summary>
    /// Function: OnProfileDataChanged
    /// </summary>
    public unsafe virtual void OnProfileDataChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnProfileDataChanged, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnProfileDataChanged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockGamerPicture;
    /// <summary>
    /// Function: UnlockGamerPicture
    /// </summary>
    public unsafe virtual bool UnlockGamerPicture(byte LocalUserNum, int PictureId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockGamerPicture, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnlockGamerPicture");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PictureId, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsDeviceValid;
    /// <summary>
    /// Function: IsDeviceValid
    /// </summary>
    public unsafe virtual bool IsDeviceValid(int DeviceID, int SizeNeeded = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDeviceValid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsDeviceValid");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SizeNeeded, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDeviceSelectionResults;
    /// <summary>
    /// Function: GetDeviceSelectionResults
    /// </summary>
    public unsafe virtual int GetDeviceSelectionResults(byte LocalUserNum, out BmSDK.FString DeviceName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDeviceSelectionResults, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetDeviceSelectionResults");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DeviceName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ClearDeviceSelectionDoneDelegate;
    /// <summary>
    /// Function: ClearDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe virtual void ClearDeviceSelectionDoneDelegate(byte LocalUserNum, System.IntPtr DeviceDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDeviceSelectionDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDeviceSelectionDoneDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDeviceSelectionDoneDelegate;
    /// <summary>
    /// Function: AddDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe virtual void AddDeviceSelectionDoneDelegate(byte LocalUserNum, System.IntPtr DeviceDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDeviceSelectionDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddDeviceSelectionDoneDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeviceSelectionComplete;
    /// <summary>
    /// Function: OnDeviceSelectionComplete
    /// </summary>
    public unsafe virtual void OnDeviceSelectionComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeviceSelectionComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnDeviceSelectionComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowDeviceSelectionUI;
    /// <summary>
    /// Function: ShowDeviceSelectionUI
    /// </summary>
    public unsafe virtual bool ShowDeviceSelectionUI(byte LocalUserNum, int SizeNeeded, bool bForceShowUI = default, bool bManageStorage = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowDeviceSelectionUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowDeviceSelectionUI");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SizeNeeded, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceShowUI, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bManageStorage, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ShowMembershipMarketplaceUI;
    /// <summary>
    /// Function: ShowMembershipMarketplaceUI
    /// </summary>
    public unsafe virtual bool ShowMembershipMarketplaceUI(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowMembershipMarketplaceUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowMembershipMarketplaceUI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ShowContentMarketplaceUI;
    /// <summary>
    /// Function: ShowContentMarketplaceUI
    /// </summary>
    public unsafe virtual bool ShowContentMarketplaceUI(byte LocalUserNum, int CategoryMask = default, int OfferId = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowContentMarketplaceUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowContentMarketplaceUI");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CategoryMask, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OfferId, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ShowInviteUI;
    /// <summary>
    /// Function: ShowInviteUI
    /// </summary>
    public unsafe virtual bool ShowInviteUI(byte LocalUserNum, BmSDK.FString InviteText = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowInviteUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowInviteUI");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteText, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ShowAchievementsUI;
    /// <summary>
    /// Function: ShowAchievementsUI
    /// </summary>
    public unsafe virtual bool ShowAchievementsUI(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowAchievementsUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowAchievementsUI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ShowMessagesUI;
    /// <summary>
    /// Function: ShowMessagesUI
    /// </summary>
    public unsafe virtual bool ShowMessagesUI(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowMessagesUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowMessagesUI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ShowTokenRedemptionUI;
    /// <summary>
    /// Function: ShowTokenRedemptionUI
    /// </summary>
    public unsafe virtual bool ShowTokenRedemptionUI(byte LocalUserNum, BmSDK.FString OfferId = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowTokenRedemptionUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowTokenRedemptionUI");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OfferId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ShowAccountPickerUI;
    /// <summary>
    /// Function: ShowAccountPickerUI
    /// </summary>
    public unsafe virtual bool ShowAccountPickerUI(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowAccountPickerUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowAccountPickerUI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShowGamerCardUI;
    /// <summary>
    /// Function: ShowGamerCardUI
    /// </summary>
    public unsafe virtual bool ShowGamerCardUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, BmSDK.FString NickName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowGamerCardUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowGamerCardUI");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NickName, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ShowFeedbackUI;
    /// <summary>
    /// Function: ShowFeedbackUI
    /// </summary>
    public unsafe virtual bool ShowFeedbackUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFeedbackUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowFeedbackUI");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearMsgBoxUIDelegate;
    /// <summary>
    /// Function: ClearMsgBoxUIDelegate
    /// </summary>
    public unsafe virtual void ClearMsgBoxUIDelegate(System.IntPtr MsgDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMsgBoxUIDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearMsgBoxUIDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MsgDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddMsgBoxUIDoneDelegate;
    /// <summary>
    /// Function: AddMsgBoxUIDoneDelegate
    /// </summary>
    public unsafe virtual void AddMsgBoxUIDoneDelegate(System.IntPtr MsgDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMsgBoxUIDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddMsgBoxUIDoneDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MsgDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMsgBoxUIComplete;
    /// <summary>
    /// Function: OnMsgBoxUIComplete
    /// </summary>
    public unsafe virtual void OnMsgBoxUIComplete(int ButtonResult)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMsgBoxUIComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnMsgBoxUIComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonResult, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSystemMsgBoxUI;
    /// <summary>
    /// Function: ShowSystemMsgBoxUI
    /// </summary>
    public unsafe virtual bool ShowSystemMsgBoxUI(byte LocalUserNum, int SysMsg)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSystemMsgBoxUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowSystemMsgBoxUI");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SysMsg, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_WriteUserFileInternal;
    /// <summary>
    /// Function: WriteUserFileInternal
    /// </summary>
    public unsafe bool WriteUserFileInternal(BmSDK.FString UserId, BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteUserFileInternal, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteUserFileInternal");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FileContents = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_GetPlayerNicknameFromIndex;
    /// <summary>
    /// Function: GetPlayerNicknameFromIndex
    /// </summary>
    public unsafe override BmSDK.FString GetPlayerNicknameFromIndex(int UserIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerNicknameFromIndex, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerNicknameFromIndex");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAchievements;
    /// <summary>
    /// Function: GetAchievements
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetAchievements(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FAchievementDetails> Achievements, int TitleId = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAchievements, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetAchievements");
        byte* paramsPtr = stackalloc byte[25];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Achievements = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FAchievementDetails>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClearReadAchievementsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadAchievementsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadAchievementsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadAchievementsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadAchievementsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadAchievementsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadAchievementsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadAchievementsCompleteDelegate;
    /// <summary>
    /// Function: AddReadAchievementsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadAchievementsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadAchievementsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadAchievementsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadAchievementsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadAchievementsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadAchievementsComplete;
    /// <summary>
    /// Function: OnReadAchievementsComplete
    /// </summary>
    public unsafe virtual void OnReadAchievementsComplete(int TitleId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadAchievementsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadAchievementsComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadAchievements;
    /// <summary>
    /// Function: ReadAchievements
    /// </summary>
    public unsafe virtual bool ReadAchievements(byte LocalUserNum, int TitleId = default, bool bShouldReadText = default, bool bShouldReadImages = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadAchievements, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadAchievements");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldReadText, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldReadImages, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ClearUnlockAchievementCompleteDelegate;
    /// <summary>
    /// Function: ClearUnlockAchievementCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearUnlockAchievementCompleteDelegate(byte LocalUserNum, System.IntPtr UnlockAchievementCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearUnlockAchievementCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearUnlockAchievementCompleteDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockAchievementCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUnlockAchievementCompleteDelegate;
    /// <summary>
    /// Function: AddUnlockAchievementCompleteDelegate
    /// </summary>
    public unsafe virtual void AddUnlockAchievementCompleteDelegate(byte LocalUserNum, System.IntPtr UnlockAchievementCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUnlockAchievementCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddUnlockAchievementCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockAchievementCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnUnlockAchievementComplete;
    /// <summary>
    /// Function: OnUnlockAchievementComplete
    /// </summary>
    public unsafe virtual void OnUnlockAchievementComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnUnlockAchievementComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnUnlockAchievementComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockAchievement;
    /// <summary>
    /// Function: UnlockAchievement
    /// </summary>
    public unsafe virtual bool UnlockAchievement(byte LocalUserNum, int AchievementId, float PercentComplete = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAchievement, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnlockAchievement");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AchievementId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PercentComplete, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DisplayAchievementProgress;
    /// <summary>
    /// Function: DisplayAchievementProgress
    /// </summary>
    public unsafe virtual bool DisplayAchievementProgress(int AchievementId, int ProgressCount, int MaxProgress)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayAchievementProgress, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DisplayAchievementProgress");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AchievementId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProgressCount, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxProgress, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DeleteMessage;
    /// <summary>
    /// Function: DeleteMessage
    /// </summary>
    public unsafe virtual bool DeleteMessage(byte LocalUserNum, int MessageIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteMessage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteMessage");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearFriendMessageReceivedDelegate;
    /// <summary>
    /// Function: ClearFriendMessageReceivedDelegate
    /// </summary>
    public unsafe virtual void ClearFriendMessageReceivedDelegate(byte LocalUserNum, System.IntPtr MessageDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFriendMessageReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFriendMessageReceivedDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFriendMessageReceivedDelegate;
    /// <summary>
    /// Function: AddFriendMessageReceivedDelegate
    /// </summary>
    public unsafe virtual void AddFriendMessageReceivedDelegate(byte LocalUserNum, System.IntPtr MessageDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFriendMessageReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendMessageReceivedDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFriendMessageReceived;
    /// <summary>
    /// Function: OnFriendMessageReceived
    /// </summary>
    public unsafe virtual void OnFriendMessageReceived(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId SendingPlayer, BmSDK.FString SendingNick, BmSDK.FString Message)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFriendMessageReceived, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFriendMessageReceived");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SendingPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SendingNick, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFriendMessages;
    /// <summary>
    /// Function: GetFriendMessages
    /// </summary>
    public unsafe virtual void GetFriendMessages(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage> FriendMessages)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFriendMessages, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFriendMessages");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FriendMessages = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_ClearJoinFriendGameCompleteDelegate;
    /// <summary>
    /// Function: ClearJoinFriendGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearJoinFriendGameCompleteDelegate(System.IntPtr JoinFriendGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearJoinFriendGameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearJoinFriendGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinFriendGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddJoinFriendGameCompleteDelegate;
    /// <summary>
    /// Function: AddJoinFriendGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddJoinFriendGameCompleteDelegate(System.IntPtr JoinFriendGameCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJoinFriendGameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddJoinFriendGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinFriendGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnJoinFriendGameComplete;
    /// <summary>
    /// Function: OnJoinFriendGameComplete
    /// </summary>
    public unsafe virtual void OnJoinFriendGameComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnJoinFriendGameComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnJoinFriendGameComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JoinFriendGame;
    /// <summary>
    /// Function: JoinFriendGame
    /// </summary>
    public unsafe virtual bool JoinFriendGame(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JoinFriendGame, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.JoinFriendGame");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friend, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearReceivedGameInviteDelegate;
    /// <summary>
    /// Function: ClearReceivedGameInviteDelegate
    /// </summary>
    public unsafe virtual void ClearReceivedGameInviteDelegate(byte LocalUserNum, System.IntPtr ReceivedGameInviteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReceivedGameInviteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReceivedGameInviteDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReceivedGameInviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReceivedGameInviteDelegate;
    /// <summary>
    /// Function: AddReceivedGameInviteDelegate
    /// </summary>
    public unsafe virtual void AddReceivedGameInviteDelegate(byte LocalUserNum, System.IntPtr ReceivedGameInviteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReceivedGameInviteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReceivedGameInviteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReceivedGameInviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReceivedGameInvite;
    /// <summary>
    /// Function: OnReceivedGameInvite
    /// </summary>
    public unsafe virtual void OnReceivedGameInvite(byte LocalUserNum, BmSDK.FString InviterName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReceivedGameInvite, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReceivedGameInvite");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviterName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendGameInviteToFriends;
    /// <summary>
    /// Function: SendGameInviteToFriends
    /// </summary>
    public unsafe virtual bool SendGameInviteToFriends(byte LocalUserNum, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Friends, BmSDK.FString Text = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendGameInviteToFriends, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SendGameInviteToFriends");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friends, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_SendGameInviteToFriend;
    /// <summary>
    /// Function: SendGameInviteToFriend
    /// </summary>
    public unsafe virtual bool SendGameInviteToFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend, BmSDK.FString Text = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendGameInviteToFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SendGameInviteToFriend");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friend, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SendMessageToFriend;
    /// <summary>
    /// Function: SendMessageToFriend
    /// </summary>
    public unsafe virtual bool SendMessageToFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend, BmSDK.FString Message)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendMessageToFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SendMessageToFriend");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friend, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ClearFriendInviteReceivedDelegate;
    /// <summary>
    /// Function: ClearFriendInviteReceivedDelegate
    /// </summary>
    public unsafe virtual void ClearFriendInviteReceivedDelegate(byte LocalUserNum, System.IntPtr InviteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFriendInviteReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFriendInviteReceivedDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFriendInviteReceivedDelegate;
    /// <summary>
    /// Function: AddFriendInviteReceivedDelegate
    /// </summary>
    public unsafe virtual void AddFriendInviteReceivedDelegate(byte LocalUserNum, System.IntPtr InviteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFriendInviteReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendInviteReceivedDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFriendInviteReceived;
    /// <summary>
    /// Function: OnFriendInviteReceived
    /// </summary>
    public unsafe virtual void OnFriendInviteReceived(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer, BmSDK.FString RequestingNick, BmSDK.FString Message)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFriendInviteReceived, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFriendInviteReceived");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingNick, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveFriend;
    /// <summary>
    /// Function: RemoveFriend
    /// </summary>
    public unsafe virtual bool RemoveFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId FormerFriend)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RemoveFriend");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormerFriend, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DenyFriendInvite;
    /// <summary>
    /// Function: DenyFriendInvite
    /// </summary>
    public unsafe virtual bool DenyFriendInvite(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DenyFriendInvite, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DenyFriendInvite");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingPlayer, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AcceptFriendInvite;
    /// <summary>
    /// Function: AcceptFriendInvite
    /// </summary>
    public unsafe virtual bool AcceptFriendInvite(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AcceptFriendInvite, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AcceptFriendInvite");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingPlayer, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearAddFriendByNameCompleteDelegate;
    /// <summary>
    /// Function: ClearAddFriendByNameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearAddFriendByNameCompleteDelegate(byte LocalUserNum, System.IntPtr FriendDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAddFriendByNameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearAddFriendByNameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddAddFriendByNameCompleteDelegate;
    /// <summary>
    /// Function: AddAddFriendByNameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddAddFriendByNameCompleteDelegate(byte LocalUserNum, System.IntPtr FriendDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAddFriendByNameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddAddFriendByNameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAddFriendByNameComplete;
    /// <summary>
    /// Function: OnAddFriendByNameComplete
    /// </summary>
    public unsafe virtual void OnAddFriendByNameComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAddFriendByNameComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnAddFriendByNameComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFriendByName;
    /// <summary>
    /// Function: AddFriendByName
    /// </summary>
    public unsafe virtual bool AddFriendByName(byte LocalUserNum, BmSDK.FString FriendName, BmSDK.FString Message = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFriendByName, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendByName");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_AddFriend;
    /// <summary>
    /// Function: AddFriend
    /// </summary>
    public unsafe virtual bool AddFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewFriend, BmSDK.FString Message = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriend");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFriend, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetKeyboardInputResults;
    /// <summary>
    /// Function: GetKeyboardInputResults
    /// </summary>
    public unsafe virtual BmSDK.FString GetKeyboardInputResults(out byte bWasCanceled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKeyboardInputResults, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetKeyboardInputResults");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bWasCanceled);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasCanceled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bWasCanceled = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearKeyboardInputDoneDelegate;
    /// <summary>
    /// Function: ClearKeyboardInputDoneDelegate
    /// </summary>
    public unsafe virtual void ClearKeyboardInputDoneDelegate(System.IntPtr InputDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearKeyboardInputDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearKeyboardInputDoneDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddKeyboardInputDoneDelegate;
    /// <summary>
    /// Function: AddKeyboardInputDoneDelegate
    /// </summary>
    public unsafe virtual void AddKeyboardInputDoneDelegate(System.IntPtr InputDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddKeyboardInputDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddKeyboardInputDoneDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnKeyboardInputComplete;
    /// <summary>
    /// Function: OnKeyboardInputComplete
    /// </summary>
    public unsafe virtual void OnKeyboardInputComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnKeyboardInputComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnKeyboardInputComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowKeyboardUI;
    /// <summary>
    /// Function: ShowKeyboardUI
    /// </summary>
    public unsafe virtual bool ShowKeyboardUI(byte LocalUserNum, BmSDK.FString TitleText, BmSDK.FString DescriptionText, bool bIsPassword = default, bool bShouldValidate = default, BmSDK.FString DefaultText = default, int MaxResultLength = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowKeyboardUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowKeyboardUI");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleText, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DescriptionText, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPassword, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldValidate, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultText, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxResultLength, paramsPtr + 60);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_SetOnlineStatus;
    /// <summary>
    /// Function: SetOnlineStatus
    /// </summary>
    public unsafe virtual void SetOnlineStatus(byte LocalUserNum, int StatusId, out BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting> LocalizedStringSettings, out BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty> Properties)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOnlineStatus, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetOnlineStatus");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatusId, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LocalizedStringSettings = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting>>(paramsPtr + 8);
        Properties = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty>>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_GetFriendsList;
    /// <summary>
    /// Function: GetFriendsList
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetFriendsList(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend> Friends, int Count = default, int StartingAt = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFriendsList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFriendsList");
        byte* paramsPtr = stackalloc byte[29];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartingAt, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Friends = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ClearReadFriendsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadFriendsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadFriendsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadFriendsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadFriendsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadFriendsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadFriendsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadFriendsCompleteDelegate;
    /// <summary>
    /// Function: AddReadFriendsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadFriendsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadFriendsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadFriendsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadFriendsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadFriendsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadFriendsComplete;
    /// <summary>
    /// Function: OnReadFriendsComplete
    /// </summary>
    public unsafe virtual void OnReadFriendsComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadFriendsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadFriendsComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadFriendsList;
    /// <summary>
    /// Function: ReadFriendsList
    /// </summary>
    public unsafe virtual bool ReadFriendsList(byte LocalUserNum, int Count = default, int StartingAt = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadFriendsList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadFriendsList");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartingAt, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearWritePlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: ClearWritePlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWritePlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr WritePlayerStorageCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWritePlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWritePlayerStorageCompleteDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WritePlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWritePlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: AddWritePlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWritePlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr WritePlayerStorageCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWritePlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWritePlayerStorageCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WritePlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWritePlayerStorageComplete;
    /// <summary>
    /// Function: OnWritePlayerStorageComplete
    /// </summary>
    public unsafe virtual void OnWritePlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWritePlayerStorageComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWritePlayerStorageComplete");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WritePlayerStorage;
    /// <summary>
    /// Function: WritePlayerStorage
    /// </summary>
    public unsafe virtual bool WritePlayerStorage(byte LocalUserNum, BmSDK.Engine.OnlinePlayerStorage PlayerStorage, int DeviceID = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WritePlayerStorage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WritePlayerStorage");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetPlayerStorage;
    /// <summary>
    /// Function: GetPlayerStorage
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlinePlayerStorage GetPlayerStorage(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerStorage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerStorage");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerStorage>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearReadPlayerStorageForNetIdCompleteDelegate;
    /// <summary>
    /// Function: ClearReadPlayerStorageForNetIdCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadPlayerStorageForNetIdCompleteDelegate(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, System.IntPtr ReadPlayerStorageForNetIdCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadPlayerStorageForNetIdCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadPlayerStorageForNetIdCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageForNetIdCompleteDelegate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadPlayerStorageForNetIdCompleteDelegate;
    /// <summary>
    /// Function: AddReadPlayerStorageForNetIdCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadPlayerStorageForNetIdCompleteDelegate(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, System.IntPtr ReadPlayerStorageForNetIdCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadPlayerStorageForNetIdCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadPlayerStorageForNetIdCompleteDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageForNetIdCompleteDelegate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadPlayerStorageForNetIdComplete;
    /// <summary>
    /// Function: OnReadPlayerStorageForNetIdComplete
    /// </summary>
    public unsafe virtual void OnReadPlayerStorageForNetIdComplete(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadPlayerStorageForNetIdComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadPlayerStorageForNetIdComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadPlayerStorageForNetId;
    /// <summary>
    /// Function: ReadPlayerStorageForNetId
    /// </summary>
    public unsafe virtual bool ReadPlayerStorageForNetId(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, BmSDK.Engine.OnlinePlayerStorage PlayerStorage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadPlayerStorageForNetId, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadPlayerStorageForNetId");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ClearReadPlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: ClearReadPlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadPlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr ReadPlayerStorageCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadPlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadPlayerStorageCompleteDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadPlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: AddReadPlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadPlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr ReadPlayerStorageCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadPlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadPlayerStorageCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadPlayerStorageComplete;
    /// <summary>
    /// Function: OnReadPlayerStorageComplete
    /// </summary>
    public unsafe virtual void OnReadPlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadPlayerStorageComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadPlayerStorageComplete");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadPlayerStorage;
    /// <summary>
    /// Function: ReadPlayerStorage
    /// </summary>
    public unsafe virtual bool ReadPlayerStorage(byte LocalUserNum, BmSDK.Engine.OnlinePlayerStorage PlayerStorage, int DeviceID = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadPlayerStorage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadPlayerStorage");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetFriendJoinURL;
    /// <summary>
    /// Function: GetFriendJoinURL
    /// </summary>
    public unsafe virtual bool GetFriendJoinURL(BmSDK.Engine.OnlineSubsystem.FUniqueNetId FriendUID, out BmSDK.FString ServerURL, out BmSDK.FString ServerUID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFriendJoinURL, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFriendJoinURL");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendUID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ServerURL = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
        ServerUID = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetCommandlineJoinURL;
    /// <summary>
    /// Function: GetCommandlineJoinURL
    /// </summary>
    public unsafe virtual bool GetCommandlineJoinURL(bool bMarkAsJoined, out BmSDK.FString ServerURL, out BmSDK.FString ServerUID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCommandlineJoinURL, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetCommandlineJoinURL");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMarkAsJoined, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ServerURL = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
        ServerUID = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_Int64ToUniqueNetId;
    /// <summary>
    /// Function: Int64ToUniqueNetId
    /// </summary>
    public unsafe virtual bool Int64ToUniqueNetId(BmSDK.FString UIDString, out BmSDK.Engine.OnlineSubsystem.FUniqueNetId OutUID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Int64ToUniqueNetId, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Int64ToUniqueNetId");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UIDString, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutUID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutUID, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutUID = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_UniqueNetIdToInt64;
    /// <summary>
    /// Function: UniqueNetIdToInt64
    /// </summary>
    public unsafe virtual BmSDK.FString UniqueNetIdToInt64(out BmSDK.Engine.OnlineSubsystem.FUniqueNetId Uid)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UniqueNetIdToInt64, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UniqueNetIdToInt64");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Uid);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Uid = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShowProfileUI;
    /// <summary>
    /// Function: ShowProfileUI
    /// </summary>
    public unsafe virtual bool ShowProfileUI(byte LocalUserNum, BmSDK.FString SubURL = default, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerUID = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowProfileUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowProfileUI");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubURL, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerUID, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_UniqueNetIdToPlayerName;
    /// <summary>
    /// Function: UniqueNetIdToPlayerName
    /// </summary>
    public unsafe virtual BmSDK.FString UniqueNetIdToPlayerName(out BmSDK.Engine.OnlineSubsystem.FUniqueNetId Uid)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UniqueNetIdToPlayerName, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UniqueNetIdToPlayerName");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Uid);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Uid = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetSteamClanData;
    /// <summary>
    /// Function: GetSteamClanData
    /// </summary>
    public unsafe virtual void GetSteamClanData(out BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamPlayerClanData> Results)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSteamClanData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetSteamClanData");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Results = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamPlayerClanData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ClearGetNumberOfCurrentPlayersCompleteDelegate;
    /// <summary>
    /// Function: ClearGetNumberOfCurrentPlayersCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearGetNumberOfCurrentPlayersCompleteDelegate(System.IntPtr GetNumberOfCurrentPlayersCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGetNumberOfCurrentPlayersCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearGetNumberOfCurrentPlayersCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetNumberOfCurrentPlayersCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGetNumberOfCurrentPlayersCompleteDelegate;
    /// <summary>
    /// Function: AddGetNumberOfCurrentPlayersCompleteDelegate
    /// </summary>
    public unsafe virtual void AddGetNumberOfCurrentPlayersCompleteDelegate(System.IntPtr GetNumberOfCurrentPlayersCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGetNumberOfCurrentPlayersCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddGetNumberOfCurrentPlayersCompleteDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetNumberOfCurrentPlayersCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGetNumberOfCurrentPlayersComplete;
    /// <summary>
    /// Function: OnGetNumberOfCurrentPlayersComplete
    /// </summary>
    public unsafe virtual void OnGetNumberOfCurrentPlayersComplete(int TotalPlayers)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGetNumberOfCurrentPlayersComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnGetNumberOfCurrentPlayersComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalPlayers, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNumberOfCurrentPlayers;
    /// <summary>
    /// Function: GetNumberOfCurrentPlayers
    /// </summary>
    public unsafe virtual bool GetNumberOfCurrentPlayers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumberOfCurrentPlayers, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetNumberOfCurrentPlayers");
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

    private static BmSDK.Function __fn_ClearWriteProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr WriteProfileSettingsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWriteProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWriteProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: AddWriteProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr WriteProfileSettingsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWriteProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWriteProfileSettingsComplete;
    /// <summary>
    /// Function: OnWriteProfileSettingsComplete
    /// </summary>
    public unsafe virtual void OnWriteProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWriteProfileSettingsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteProfileSettingsComplete");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WriteProfileSettings;
    /// <summary>
    /// Function: WriteProfileSettings
    /// </summary>
    public unsafe virtual bool WriteProfileSettings(byte LocalUserNum, BmSDK.Engine.OnlineProfileSettings ProfileSettings)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteProfileSettings");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetProfileSettings;
    /// <summary>
    /// Function: GetProfileSettings
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineProfileSettings GetProfileSettings(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetProfileSettings");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineProfileSettings>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearReadProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: AddReadProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadProfileSettingsComplete;
    /// <summary>
    /// Function: OnReadProfileSettingsComplete
    /// </summary>
    public unsafe virtual void OnReadProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadProfileSettingsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadProfileSettingsComplete");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadProfileSettings;
    /// <summary>
    /// Function: ReadProfileSettings
    /// </summary>
    public unsafe virtual bool ReadProfileSettings(byte LocalUserNum, BmSDK.Engine.OnlineProfileSettings ProfileSettings)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadProfileSettings");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearFriendsChangeDelegate;
    /// <summary>
    /// Function: ClearFriendsChangeDelegate
    /// </summary>
    public unsafe virtual void ClearFriendsChangeDelegate(byte LocalUserNum, System.IntPtr FriendsDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFriendsChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFriendsChangeDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFriendsChangeDelegate;
    /// <summary>
    /// Function: AddFriendsChangeDelegate
    /// </summary>
    public unsafe virtual void AddFriendsChangeDelegate(byte LocalUserNum, System.IntPtr FriendsDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFriendsChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendsChangeDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearMutingChangeDelegate;
    /// <summary>
    /// Function: ClearMutingChangeDelegate
    /// </summary>
    public unsafe virtual void ClearMutingChangeDelegate(System.IntPtr MutingDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMutingChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearMutingChangeDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutingDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddMutingChangeDelegate;
    /// <summary>
    /// Function: AddMutingChangeDelegate
    /// </summary>
    public unsafe virtual void AddMutingChangeDelegate(System.IntPtr MutingDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMutingChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddMutingChangeDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutingDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLoginCancelledDelegate;
    /// <summary>
    /// Function: ClearLoginCancelledDelegate
    /// </summary>
    public unsafe virtual void ClearLoginCancelledDelegate(System.IntPtr CancelledDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLoginCancelledDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginCancelledDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CancelledDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLoginCancelledDelegate;
    /// <summary>
    /// Function: AddLoginCancelledDelegate
    /// </summary>
    public unsafe virtual void AddLoginCancelledDelegate(System.IntPtr CancelledDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLoginCancelledDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginCancelledDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CancelledDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLoginStatusChangeDelegate;
    /// <summary>
    /// Function: ClearLoginStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearLoginStatusChangeDelegate(System.IntPtr LoginStatusDelegate, byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLoginStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLoginStatusChangeDelegate;
    /// <summary>
    /// Function: AddLoginStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddLoginStatusChangeDelegate(System.IntPtr LoginStatusDelegate, byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLoginStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginStatusChange;
    /// <summary>
    /// Function: OnLoginStatusChange
    /// </summary>
    public unsafe virtual void OnLoginStatusChange(BmSDK.Engine.OnlineSubsystem.ELoginStatus NewStatus, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginStatusChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginStatusChange");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStatus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLoginChangeDelegate;
    /// <summary>
    /// Function: ClearLoginChangeDelegate
    /// </summary>
    public unsafe virtual void ClearLoginChangeDelegate(System.IntPtr LoginDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLoginChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginChangeDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLoginChangeDelegate;
    /// <summary>
    /// Function: AddLoginChangeDelegate
    /// </summary>
    public unsafe virtual void AddLoginChangeDelegate(System.IntPtr LoginDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLoginChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginChangeDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowFriendsUI;
    /// <summary>
    /// Function: ShowFriendsUI
    /// </summary>
    public unsafe virtual bool ShowFriendsUI(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFriendsUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowFriendsUI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsMuted;
    /// <summary>
    /// Function: IsMuted
    /// </summary>
    public unsafe virtual bool IsMuted(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMuted, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsMuted");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AreAnyFriends;
    /// <summary>
    /// Function: AreAnyFriends
    /// </summary>
    public unsafe virtual bool AreAnyFriends(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FFriendsQuery> Query)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAnyFriends, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AreAnyFriends");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Query = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FFriendsQuery>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_IsFriend;
    /// <summary>
    /// Function: IsFriend
    /// </summary>
    public unsafe virtual bool IsFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsFriend");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanShowPresenceInformation;
    /// <summary>
    /// Function: CanShowPresenceInformation
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanShowPresenceInformation(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanShowPresenceInformation, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanShowPresenceInformation");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_CanViewPlayerProfiles;
    /// <summary>
    /// Function: CanViewPlayerProfiles
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanViewPlayerProfiles(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanViewPlayerProfiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanViewPlayerProfiles");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_CanPurchaseContent;
    /// <summary>
    /// Function: CanPurchaseContent
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanPurchaseContent(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPurchaseContent, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanPurchaseContent");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_CanDownloadUserContent;
    /// <summary>
    /// Function: CanDownloadUserContent
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanDownloadUserContent(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDownloadUserContent, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanDownloadUserContent");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_CanCommunicate;
    /// <summary>
    /// Function: CanCommunicate
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanCommunicate(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCommunicate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanCommunicate");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_CanPlayOnline;
    /// <summary>
    /// Function: CanPlayOnline
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanPlayOnline(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayOnline, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanPlayOnline");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_IsOnlineAccount;
    /// <summary>
    /// Function: IsOnlineAccount
    /// </summary>
    public unsafe virtual bool IsOnlineAccount(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOnlineAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsOnlineAccount");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsLocalLogin;
    /// <summary>
    /// Function: IsLocalLogin
    /// </summary>
    public unsafe virtual bool IsLocalLogin(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocalLogin, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsLocalLogin");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsGuestLogin;
    /// <summary>
    /// Function: IsGuestLogin
    /// </summary>
    public unsafe virtual bool IsGuestLogin(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGuestLogin, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsGuestLogin");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPlayerDisplayName;
    /// <summary>
    /// Function: GetPlayerDisplayName
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayerDisplayName(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerDisplayName, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerDisplayName");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPlayerNickname;
    /// <summary>
    /// Function: GetPlayerNickname
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayerNickname(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerNickname, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerNickname");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetUniquePlayerId;
    /// <summary>
    /// Function: GetUniquePlayerId
    /// </summary>
    public unsafe virtual bool GetUniquePlayerId(byte LocalUserNum, out BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUniquePlayerId, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetUniquePlayerId");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PlayerID = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetLoginStatus;
    /// <summary>
    /// Function: GetLoginStatus
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.ELoginStatus GetLoginStatus(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLoginStatus, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetLoginStatus");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ELoginStatus>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_ClearLogoutCompletedDelegate;
    /// <summary>
    /// Function: ClearLogoutCompletedDelegate
    /// </summary>
    public unsafe virtual void ClearLogoutCompletedDelegate(byte LocalUserNum, System.IntPtr LogoutDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLogoutCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLogoutCompletedDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LogoutDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLogoutCompletedDelegate;
    /// <summary>
    /// Function: AddLogoutCompletedDelegate
    /// </summary>
    public unsafe virtual void AddLogoutCompletedDelegate(byte LocalUserNum, System.IntPtr LogoutDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLogoutCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLogoutCompletedDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LogoutDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLogoutCompleted;
    /// <summary>
    /// Function: OnLogoutCompleted
    /// </summary>
    public unsafe virtual void OnLogoutCompleted(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLogoutCompleted, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLogoutCompleted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Logout;
    /// <summary>
    /// Function: Logout
    /// </summary>
    public unsafe virtual bool Logout(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Logout, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Logout");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearLoginFailedDelegate;
    /// <summary>
    /// Function: ClearLoginFailedDelegate
    /// </summary>
    public unsafe virtual void ClearLoginFailedDelegate(byte LocalUserNum, System.IntPtr LoginFailedDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLoginFailedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginFailedDelegate");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginFailedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLoginFailedDelegate;
    /// <summary>
    /// Function: AddLoginFailedDelegate
    /// </summary>
    public unsafe virtual void AddLoginFailedDelegate(byte LocalUserNum, System.IntPtr LoginFailedDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLoginFailedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginFailedDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginFailedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginFailed;
    /// <summary>
    /// Function: OnLoginFailed
    /// </summary>
    public unsafe virtual void OnLoginFailed(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ErrorCode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginFailed, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginFailed");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorCode, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoLogin;
    /// <summary>
    /// Function: AutoLogin
    /// </summary>
    public unsafe virtual bool AutoLogin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoLogin, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AutoLogin");
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

    private static BmSDK.Function __fn_Login;
    /// <summary>
    /// Function: Login
    /// </summary>
    public unsafe virtual bool Login(byte LocalUserNum, BmSDK.FString LoginName, BmSDK.FString Password, bool bWantsLocalOnly = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Login, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Login");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantsLocalOnly, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_ShowLoginUI;
    /// <summary>
    /// Function: ShowLoginUI
    /// </summary>
    public unsafe virtual bool ShowLoginUI(bool bShowOnlineOnly = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLoginUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowLoginUI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowOnlineOnly, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnFriendsChange;
    /// <summary>
    /// Function: OnFriendsChange
    /// </summary>
    public unsafe virtual void OnFriendsChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFriendsChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFriendsChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMutingChange;
    /// <summary>
    /// Function: OnMutingChange
    /// </summary>
    public unsafe virtual void OnMutingChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMutingChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnMutingChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginCancelled;
    /// <summary>
    /// Function: OnLoginCancelled
    /// </summary>
    public unsafe virtual void OnLoginCancelled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginCancelled, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginCancelled");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginChange;
    /// <summary>
    /// Function: OnLoginChange
    /// </summary>
    public unsafe virtual void OnLoginChange(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginChange");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLocale;
    /// <summary>
    /// Function: GetLocale
    /// </summary>
    public unsafe virtual int GetLocale()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocale, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetLocale");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearStorageDeviceChangeDelegate;
    /// <summary>
    /// Function: ClearStorageDeviceChangeDelegate
    /// </summary>
    public unsafe virtual void ClearStorageDeviceChangeDelegate(System.IntPtr StorageDeviceChangeDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearStorageDeviceChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearStorageDeviceChangeDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageDeviceChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddStorageDeviceChangeDelegate;
    /// <summary>
    /// Function: AddStorageDeviceChangeDelegate
    /// </summary>
    public unsafe virtual void AddStorageDeviceChangeDelegate(System.IntPtr StorageDeviceChangeDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddStorageDeviceChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddStorageDeviceChangeDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageDeviceChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnStorageDeviceChange;
    /// <summary>
    /// Function: OnStorageDeviceChange
    /// </summary>
    public unsafe virtual void OnStorageDeviceChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStorageDeviceChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnStorageDeviceChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNATType;
    /// <summary>
    /// Function: GetNATType
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.ENATType GetNATType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNATType, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetNATType");
        byte* paramsPtr = stackalloc byte[1];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ENATType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearConnectionStatusChangeDelegate;
    /// <summary>
    /// Function: ClearConnectionStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearConnectionStatusChangeDelegate(System.IntPtr ConnectionStatusDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearConnectionStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearConnectionStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConnectionStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddConnectionStatusChangeDelegate;
    /// <summary>
    /// Function: AddConnectionStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddConnectionStatusChangeDelegate(System.IntPtr ConnectionStatusDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddConnectionStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddConnectionStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConnectionStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnConnectionStatusChange;
    /// <summary>
    /// Function: OnConnectionStatusChange
    /// </summary>
    public unsafe virtual void OnConnectionStatusChange(BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ConnectionStatus)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnConnectionStatusChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnConnectionStatusChange");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConnectionStatus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsControllerConnected;
    /// <summary>
    /// Function: IsControllerConnected
    /// </summary>
    public unsafe virtual bool IsControllerConnected(int ControllerId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControllerConnected, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsControllerConnected");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearControllerChangeDelegate;
    /// <summary>
    /// Function: ClearControllerChangeDelegate
    /// </summary>
    public unsafe virtual void ClearControllerChangeDelegate(System.IntPtr ControllerChangeDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearControllerChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearControllerChangeDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddControllerChangeDelegate;
    /// <summary>
    /// Function: AddControllerChangeDelegate
    /// </summary>
    public unsafe virtual void AddControllerChangeDelegate(System.IntPtr ControllerChangeDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddControllerChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddControllerChangeDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnControllerChange;
    /// <summary>
    /// Function: OnControllerChange
    /// </summary>
    public unsafe virtual void OnControllerChange(int ControllerId, bool bIsConnected)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnControllerChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnControllerChange");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsConnected, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNetworkNotificationPosition;
    /// <summary>
    /// Function: SetNetworkNotificationPosition
    /// </summary>
    public unsafe virtual void SetNetworkNotificationPosition(BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition NewPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNetworkNotificationPosition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetNetworkNotificationPosition");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPos, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetNetworkNotificationPosition;
    /// <summary>
    /// Function: GetNetworkNotificationPosition
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition GetNetworkNotificationPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNetworkNotificationPosition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetNetworkNotificationPosition");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearExternalUIChangeDelegate;
    /// <summary>
    /// Function: ClearExternalUIChangeDelegate
    /// </summary>
    public unsafe virtual void ClearExternalUIChangeDelegate(System.IntPtr ExternalUIDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearExternalUIChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearExternalUIChangeDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExternalUIDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddExternalUIChangeDelegate;
    /// <summary>
    /// Function: AddExternalUIChangeDelegate
    /// </summary>
    public unsafe virtual void AddExternalUIChangeDelegate(System.IntPtr ExternalUIDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddExternalUIChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddExternalUIChangeDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExternalUIDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnExternalUIChange;
    /// <summary>
    /// Function: OnExternalUIChange
    /// </summary>
    public unsafe virtual void OnExternalUIChange(bool bIsOpening)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnExternalUIChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnExternalUIChange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsOpening, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLinkStatusChangeDelegate;
    /// <summary>
    /// Function: ClearLinkStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearLinkStatusChangeDelegate(System.IntPtr LinkStatusDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLinkStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLinkStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLinkStatusChangeDelegate;
    /// <summary>
    /// Function: AddLinkStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddLinkStatusChangeDelegate(System.IntPtr LinkStatusDelegate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLinkStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLinkStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLinkStatusChange;
    /// <summary>
    /// Function: OnLinkStatusChange
    /// </summary>
    public unsafe virtual void OnLinkStatusChange(bool bIsConnected)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLinkStatusChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLinkStatusChange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsConnected, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasLinkConnection;
    /// <summary>
    /// Function: HasLinkConnection
    /// </summary>
    public unsafe virtual bool HasLinkConnection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLinkConnection, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.HasLinkConnection");
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

    /// <summary>
    /// Struct: FSteamUserCloudMetadata
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FSteamUserCloudMetadata
    {
        /// <summary>
        /// StrProperty: UserId
        /// </summary>
        public unsafe BmSDK.FString UserId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: UserCloudMetadata
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile> UserCloudMetadata
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FSteamUserCloud
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FSteamUserCloud
    {
        /// <summary>
        /// StrProperty: UserId
        /// </summary>
        public unsafe BmSDK.FString UserId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: UserCloudFileData
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile> UserCloudFileData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FLocalTalkerSteam
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 5)]
    public partial record struct FLocalTalkerSteam
    {
        /// <summary>
        /// ByteProperty: MuteType
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.EMuteType MuteType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.EMuteType>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EMuteType
    /// </summary>
    public enum EMuteType : byte
    {
        MUTE_None = 0,
        MUTE_AllButFriends = 1,
        MUTE_All = 2,
        MUTE_MAX = 3,
    }

    /// <summary>
    /// Struct: FContentListCache
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 108)]
    public partial record struct FContentListCache
    {
        /// <summary>
        /// ArrayProperty: Content
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent> Content
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: ReadState
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState ReadState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: ContentChangeDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> ContentChangeDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: ReadCompleteDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> ReadCompleteDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ArrayProperty: ContentStatusChangeDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> ContentStatusChangeDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// ArrayProperty: ReadInGameStoreContentCompleteDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> ReadInGameStoreContentCompleteDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// ArrayProperty: PurchaseInGameStoreContentCompleteDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> PurchaseInGameStoreContentCompleteDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// IntProperty: NewDownloadCount
        /// </summary>
        public unsafe int NewDownloadCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// IntProperty: TotalDownloadCount
        /// </summary>
        public unsafe int TotalDownloadCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }
    }

    /// <summary>
    /// Struct: FLeaderboardEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FLeaderboardEntry
    {
        /// <summary>
        /// StructProperty: PlayerUID
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Rank
        /// </summary>
        public unsafe int Rank
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Score
        /// </summary>
        public unsafe int Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: LeaderboardData
        /// </summary>
        public unsafe BmSDK.TArray<int> LeaderboardData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FDeferredLeaderboardWrite
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FDeferredLeaderboardWrite
    {
        /// <summary>
        /// StrProperty: LeaderboardName
        /// </summary>
        public unsafe BmSDK.FString LeaderboardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Score
        /// </summary>
        public unsafe int Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: LeaderboardData
        /// </summary>
        public unsafe BmSDK.TArray<int> LeaderboardData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FDeferredLeaderboardRead
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FDeferredLeaderboardRead
    {
        /// <summary>
        /// StrProperty: LeaderboardName
        /// </summary>
        public unsafe BmSDK.FString LeaderboardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: RequestType
        /// </summary>
        public unsafe byte RequestType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Start
        /// </summary>
        public unsafe int Start
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: End
        /// </summary>
        public unsafe int End
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: PlayerList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> PlayerList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FLeaderboardTemplate
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FLeaderboardTemplate
    {
        /// <summary>
        /// StrProperty: LeaderboardName
        /// </summary>
        public unsafe BmSDK.FString LeaderboardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: UpdateType
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardUpdateType UpdateType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardUpdateType>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: LeaderboardSize
        /// </summary>
        public unsafe int LeaderboardSize
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ByteProperty: SortType
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardSortType SortType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardSortType>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: DisplayFormat
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardFormat DisplayFormat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardFormat>(Ptr + 25); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 25); }; }
        }

        /// <summary>
        /// StructProperty: LeaderboardRef
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardHandle LeaderboardRef
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardHandle>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bLeaderboardInitializing
        /// </summary>
        public unsafe bool bLeaderboardInitializing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bLeaderboardInitiated
        /// </summary>
        public unsafe bool bLeaderboardInitiated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FLeaderboardHandle
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FLeaderboardHandle
    {
        /// <summary>
        /// StructProperty: Dud
        /// </summary>
        public unsafe ulong Dud
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: ELeaderboardUpdateType
    /// </summary>
    public enum ELeaderboardUpdateType : byte
    {
        LUT_KeepBest = 0,
        LUT_Force = 1,
        LUT_MAX = 2,
    }

    /// <summary>
    /// Enum: ELeaderboardFormat
    /// </summary>
    public enum ELeaderboardFormat : byte
    {
        LF_Number = 0,
        LF_Seconds = 1,
        LF_Milliseconds = 2,
        LF_MAX = 3,
    }

    /// <summary>
    /// Enum: ELeaderboardSortType
    /// </summary>
    public enum ELeaderboardSortType : byte
    {
        LST_Ascending = 0,
        LST_Descending = 1,
        LST_MAX = 2,
    }

    /// <summary>
    /// Enum: ELeaderboardRequestType
    /// </summary>
    public enum ELeaderboardRequestType : byte
    {
        LBRT_Global = 0,
        LBRT_Player = 1,
        LBRT_Friends = 2,
        LBRT_MAX = 3,
    }

    /// <summary>
    /// Struct: FPendingPlayerStats
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial record struct FPendingPlayerStats
    {
        /// <summary>
        /// StructProperty: Player
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: PlayerName
        /// </summary>
        public unsafe BmSDK.FString PlayerName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: StatGuid
        /// </summary>
        public unsafe BmSDK.FString StatGuid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: Stats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPlayerStat> Stats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPlayerStat>>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: Score
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// StrProperty: Place
        /// </summary>
        public unsafe BmSDK.FString Place
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
    }

    /// <summary>
    /// Struct: FPlayerStat
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FPlayerStat
    {
        /// <summary>
        /// IntProperty: ViewId
        /// </summary>
        public unsafe int ViewId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ColumnId
        /// </summary>
        public unsafe int ColumnId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.Engine.Settings.FSettingsData Data
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Settings.FSettingsData>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FQueuedAvatarRequest
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FQueuedAvatarRequest
    {
        /// <summary>
        /// FloatProperty: CheckTime
        /// </summary>
        public unsafe float CheckTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: NumberOfAttempts
        /// </summary>
        public unsafe int NumberOfAttempts
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: PlayerNetId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
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
        /// DelegateProperty: ReadOnlineAvatarCompleteDelegate
        /// </summary>
        public unsafe System.IntPtr ReadOnlineAvatarCompleteDelegate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FDeviceIdCache
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FDeviceIdCache
    {
        /// <summary>
        /// IntProperty: DeviceID
        /// </summary>
        public unsafe int DeviceID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// DelegateProperty: DeviceSelectionMulticast
        /// </summary>
        public unsafe System.IntPtr DeviceSelectionMulticast
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: DeviceSelectionDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> DeviceSelectionDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FAchievementProgressStat
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FAchievementProgressStat
    {
        /// <summary>
        /// IntProperty: AchievementId
        /// </summary>
        public unsafe int AchievementId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Progress
        /// </summary>
        public unsafe int Progress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: MaxProgress
        /// </summary>
        public unsafe int MaxProgress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bUnlock
        /// </summary>
        public unsafe bool bUnlock
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FAchievementMappingInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FAchievementMappingInfo
    {
        /// <summary>
        /// IntProperty: AchievementId
        /// </summary>
        public unsafe int AchievementId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: AchievementName
        /// </summary>
        public unsafe BmSDK.FName AchievementName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: ViewId
        /// </summary>
        public unsafe int ViewId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: ProgressCount
        /// </summary>
        public unsafe int ProgressCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: MaxProgress
        /// </summary>
        public unsafe int MaxProgress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bAutoUnlock
        /// </summary>
        public unsafe bool bAutoUnlock
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FSteamPlayerClanData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FSteamPlayerClanData
    {
        /// <summary>
        /// StrProperty: ClanName
        /// </summary>
        public unsafe BmSDK.FString ClanName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ClanTag
        /// </summary>
        public unsafe BmSDK.FString ClanTag
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FControllerConnectionState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FControllerConnectionState
    {
        /// <summary>
        /// IntProperty: bIsControllerConnected
        /// </summary>
        public unsafe int bIsControllerConnected
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: bLastIsControllerConnected
        /// </summary>
        public unsafe int bLastIsControllerConnected
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FOnlineStatusMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FOnlineStatusMapping
    {
        /// <summary>
        /// IntProperty: StatusId
        /// </summary>
        public unsafe int StatusId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: StatusString
        /// </summary>
        public unsafe BmSDK.FString StatusString
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FProfileSettingsCache
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial record struct FProfileSettingsCache
    {
        /// <summary>
        /// ObjectProperty: Profile
        /// </summary>
        public unsafe BmSDK.Engine.OnlineProfileSettings Profile
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineProfileSettings>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: ReadDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> ReadDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: WriteDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> WriteDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: ProfileDataChangedDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> ProfileDataChangedDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// StructProperty: DLCAPI
    /// </summary>
    public unsafe System.IntPtr DLCAPI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ObjectProperty: CachedGameInt
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks CachedGameInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ObjectProperty: CachedProfile
    /// </summary>
    public unsafe BmSDK.Engine.OnlineProfileSettings CachedProfile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineProfileSettings>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: PlayerStorageCache
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerStorage PlayerStorageCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerStorage>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: CachedAuthInt
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks CachedAuthInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ObjectProperty: CurrentStatsRead
    /// </summary>
    public unsafe BmSDK.Engine.OnlineStatsRead CurrentStatsRead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineStatsRead>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// IntProperty: GameID
    /// </summary>
    public unsafe int GameID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// StrProperty: EncryptedProductKey
    /// </summary>
    public unsafe BmSDK.FString EncryptedProductKey
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ArrayProperty: ConnectionStatusChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ConnectionStatusChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: ControllerChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ControllerChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ArrayProperty: LinkStatusDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LinkStatusDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ByteProperty: CurrentNotificationPosition
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition CurrentNotificationPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ByteProperty: LoggedInStatus
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ELoginStatus LoggedInStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ELoginStatus>(Ptr + 749); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 749); }
    }

    /// <summary>
    /// ByteProperty: bWasKeyboardInputCanceled
    /// </summary>
    public unsafe byte bWasKeyboardInputCanceled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 750); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 750); }
    }

    /// <summary>
    /// ByteProperty: UserStatsReceivedState
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState UserStatsReceivedState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(Ptr + 751); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 751); }
    }

    /// <summary>
    /// StrProperty: LocalProfileName
    /// </summary>
    public unsafe BmSDK.FString LocalProfileName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StrProperty: LoggedInPlayerName
    /// </summary>
    public unsafe BmSDK.FString LoggedInPlayerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// StructProperty: LoggedInPlayerId
    /// </summary>
    public unsafe ref BmSDK.Engine.OnlineSubsystem.FUniqueNetId LoggedInPlayerId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 784);

    /// <summary>
    /// IntProperty: LoggedInPlayerNum
    /// </summary>
    public unsafe int LoggedInPlayerNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// StrProperty: ProfileDataDirectory
    /// </summary>
    public unsafe BmSDK.FString ProfileDataDirectory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// StrProperty: ProfileDataExtension
    /// </summary>
    public unsafe BmSDK.FString ProfileDataExtension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ArrayProperty: FriendInviteReceivedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FriendInviteReceivedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ArrayProperty: FriendMessageReceivedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FriendMessageReceivedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ArrayProperty: AddFriendByNameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AddFriendByNameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// StructProperty: ProfileCache
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FProfileSettingsCache ProfileCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FProfileSettingsCache>(Ptr + 876);

    /// <summary>
    /// StrProperty: CachedFriendMessage
    /// </summary>
    public unsafe BmSDK.FString CachedFriendMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: LocationUrlsForInvites
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LocationUrlsForInvites
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// StrProperty: LocationUrl
    /// </summary>
    public unsafe BmSDK.FString LocationUrl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: ReceivedGameInviteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ReceivedGameInviteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ArrayProperty: JoinFriendGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> JoinFriendGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ArrayProperty: GetNumberOfCurrentPlayersCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> GetNumberOfCurrentPlayersCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: RegisterHostStatGuidCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RegisterHostStatGuidCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ArrayProperty: CachedFriendMessages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage> CachedFriendMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage>>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// BoolProperty: bStoringAchievement
    /// </summary>
    public unsafe bool bStoringAchievement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bLastHasConnection
    /// </summary>
    public unsafe bool bLastHasConnection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bHasSteamworksAccount
    /// </summary>
    public unsafe bool bHasSteamworksAccount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bShouldUseMcp
    /// </summary>
    public unsafe bool bShouldUseMcp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bNeedsKeyboardTicking
    /// </summary>
    public unsafe bool bNeedsKeyboardTicking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bVideoRecordEnabled
    /// </summary>
    public unsafe bool bVideoRecordEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bClientStatsStorePending
    /// </summary>
    public unsafe bool bClientStatsStorePending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bGSStatsStoresSuccess
    /// </summary>
    public unsafe bool bGSStatsStoresSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bIsStatsSessionOk
    /// </summary>
    public unsafe bool bIsStatsSessionOk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bReadOpComplete
    /// </summary>
    public unsafe bool m_bReadOpComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bWriteOpComplete
    /// </summary>
    public unsafe bool m_bWriteOpComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bDeleteOpComplete
    /// </summary>
    public unsafe bool m_bDeleteOpComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: m_bOpSuccessful
    /// </summary>
    public unsafe bool m_bOpSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bHasReceivedSteamPrices
    /// </summary>
    public unsafe bool bHasReceivedSteamPrices
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// ArrayProperty: AchievementDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AchievementDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ArrayProperty: AchievementReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AchievementReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: ReadFriendsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ReadFriendsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ArrayProperty: WriteProfileSettingsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> WriteProfileSettingsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ArrayProperty: FriendsChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FriendsChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ArrayProperty: LoginChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LoginChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ArrayProperty: LoginFailedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LoginFailedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ArrayProperty: LogoutCompletedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LogoutCompletedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ArrayProperty: MutingChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> MutingChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ArrayProperty: StatusMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FOnlineStatusMapping> StatusMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FOnlineStatusMapping>>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// StrProperty: DefaultStatus
    /// </summary>
    public unsafe BmSDK.FString DefaultStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// StrProperty: GameInviteMessage
    /// </summary>
    public unsafe BmSDK.FString GameInviteMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ControllerStates
    /// </summary>
    public InlineArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState> ControllerStates => new(4, Ptr + 1256, 8, this);

    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 1256);
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 1264);
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 1272);
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 1280);

    /// <summary>
    /// FloatProperty: ConnectionPresenceTimeInterval
    /// </summary>
    public unsafe float ConnectionPresenceTimeInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: ConnectionPresenceElapsedTime
    /// </summary>
    public unsafe float ConnectionPresenceElapsedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// ArrayProperty: PendingRedirects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.IpDrv.InternetLink.FIpAddr> PendingRedirects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.IpDrv.InternetLink.FIpAddr>>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// StrProperty: KeyboardResultsString
    /// </summary>
    public unsafe BmSDK.FString KeyboardResultsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// ArrayProperty: KeyboardInputDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> KeyboardInputDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// ArrayProperty: AchievementMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementMappingInfo> AchievementMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementMappingInfo>>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ArrayProperty: LocalPlayerStorageReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LocalPlayerStorageReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ArrayProperty: LocalPlayerStorageWriteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LocalPlayerStorageWriteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// ArrayProperty: RemotePlayerStorageReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RemotePlayerStorageReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// ArrayProperty: PendingAchievementProgress
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementProgressStat> PendingAchievementProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementProgressStat>>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// StructProperty: DeviceCache
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeviceIdCache DeviceCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeviceIdCache>(Ptr + 1424);

    /// <summary>
    /// ArrayProperty: QueuedAvatarRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FQueuedAvatarRequest> QueuedAvatarRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FQueuedAvatarRequest>>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// ArrayProperty: AccountCreateDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AccountCreateDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// IntProperty: TotalGSStatsStoresPending
    /// </summary>
    public unsafe int TotalGSStatsStoresPending
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// ArrayProperty: ReadOnlineStatsCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ReadOnlineStatsCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// ArrayProperty: FlushOnlineStatsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FlushOnlineStatsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// ArrayProperty: PendingStats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPendingPlayerStats> PendingStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPendingPlayerStats>>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// ArrayProperty: LeaderboardList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardTemplate> LeaderboardList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardTemplate>>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// ArrayProperty: DeferredLeaderboardReads
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardRead> DeferredLeaderboardReads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardRead>>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// ArrayProperty: DeferredLeaderboardWrites
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite> DeferredLeaderboardWrites
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite>>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// ArrayProperty: PendingLeaderboardStats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite> PendingLeaderboardStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite>>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// ArrayProperty: GameServerStatsMappings
    /// </summary>
    public unsafe BmSDK.TArray<int> GameServerStatsMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// StructProperty: ContentCache
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FContentListCache ContentCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FContentListCache>(Ptr + 1624);

    /// <summary>
    /// StrProperty: DLCRootDir
    /// </summary>
    public unsafe BmSDK.FString DLCRootDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// ArrayProperty: ReadTitleFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ReadTitleFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile> SharedFileCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile>>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// ArrayProperty: SpeechRecognitionCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> SpeechRecognitionCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// ArrayProperty: TalkingDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> TalkingDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ArrayProperty: MuteList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> MuteList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// StructProperty: CurrentLocalTalker
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLocalTalkerSteam CurrentLocalTalker
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLocalTalkerSteam>(Ptr + 1828);

    /// <summary>
    /// ArrayProperty: RemoteTalkers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FRemoteTalker> RemoteTalkers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FRemoteTalker>>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// ArrayProperty: EnumerateUserFilesCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> EnumerateUserFilesCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ArrayProperty: ReadUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ReadUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ArrayProperty: WriteUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> WriteUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ArrayProperty: DeleteUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> DeleteUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// ArrayProperty: ReadDownloadFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ReadDownloadFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// ArrayProperty: WriteDownloadFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> WriteDownloadFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// ArrayProperty: DeleteDownloadFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> DeleteDownloadFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// ArrayProperty: UserCloudFiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloud> UserCloudFiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloud>>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// ArrayProperty: UserCloudMetadata
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloudMetadata> UserCloudMetadata
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloudMetadata>>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileReadCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> SharedFileReadCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileWriteCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> SharedFileWriteCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// StrProperty: m_DownloadFileName
    /// </summary>
    public unsafe BmSDK.FString m_DownloadFileName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// StructProperty: m_DownloadFileDescriptor
    /// </summary>
    public unsafe System.IntPtr m_DownloadFileDescriptor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// StructProperty: m_DownloadFileTask
    /// </summary>
    public unsafe System.IntPtr m_DownloadFileTask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// IntProperty: m_bytesProcessed
    /// </summary>
    public unsafe int m_bytesProcessed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// ArrayProperty: CachedSteamPrices
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContentOffering> CachedSteamPrices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContentOffering>>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// DelegateProperty: __OnLinkStatusChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLinkStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// DelegateProperty: __OnExternalUIChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnExternalUIChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// DelegateProperty: __OnControllerChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnControllerChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// DelegateProperty: __OnConnectionStatusChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnConnectionStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// DelegateProperty: __OnStorageDeviceChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnStorageDeviceChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginCancelled__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginCancelled__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// DelegateProperty: __OnMutingChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnMutingChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendsChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFriendsChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginFailed__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// DelegateProperty: __OnLogoutCompleted__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLogoutCompleted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginStatusChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// DelegateProperty: __OnGetNumberOfCurrentPlayersComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnGetNumberOfCurrentPlayersComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadPlayerStorageComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadPlayerStorageComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadPlayerStorageForNetIdComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadPlayerStorageForNetIdComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// DelegateProperty: __OnWritePlayerStorageComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWritePlayerStorageComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadFriendsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadFriendsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// DelegateProperty: __OnKeyboardInputComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnKeyboardInputComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// DelegateProperty: __OnAddFriendByNameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnAddFriendByNameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendInviteReceived__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFriendInviteReceived__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// DelegateProperty: __OnReceivedGameInvite__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReceivedGameInvite__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// DelegateProperty: __OnJoinFriendGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnJoinFriendGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendMessageReceived__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFriendMessageReceived__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// DelegateProperty: __OnUnlockAchievementComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUnlockAchievementComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadAchievementsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadAchievementsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// DelegateProperty: __OnMsgBoxUIComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnMsgBoxUIComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeviceSelectionComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDeviceSelectionComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// DelegateProperty: __OnProfileDataChanged__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnProfileDataChanged__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// DelegateProperty: __OnNewInfocast__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnNewInfocast__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadCrossTitleProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadCrossTitleProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadOnlineAvatarComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadOnlineAvatarComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// DelegateProperty: __OnGTCCommand__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnGTCCommand__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// DelegateProperty: __OnCreateOnlineAccountCompleted__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCreateOnlineAccountCompleted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadOnlineStatsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadOnlineStatsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// DelegateProperty: __OnFlushOnlineStatsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFlushOnlineStatsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// DelegateProperty: __OnRegisterHostStatGuidComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRegisterHostStatGuidComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// DelegateProperty: __OnContentChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnContentChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadContentComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// DelegateProperty: __OnContentStatusChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnContentStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadInGameStoreContentComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadInGameStoreContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// DelegateProperty: __OnPurchaseInGameStoreContentComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnPurchaseInGameStoreContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadCrossTitleContentComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadCrossTitleContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadCrossTitleSaveGameDataComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadCrossTitleSaveGameDataComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// DelegateProperty: __OnQueryAvailableDownloadsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnQueryAvailableDownloadsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadSaveGameDataComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadSaveGameDataComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteSaveGameDataComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteSaveGameDataComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2832); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadTitleFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadTitleFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }
    }

    /// <summary>
    /// DelegateProperty: __OnRequestTitleFileListComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRequestTitleFileListComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }
    }

    /// <summary>
    /// DelegateProperty: __OnPlayerTalkingStateChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnPlayerTalkingStateChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2880); }
    }

    /// <summary>
    /// DelegateProperty: __OnRecognitionComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRecognitionComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2896); }
    }

    /// <summary>
    /// DelegateProperty: __OnEnumerateUserFilesComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnEnumerateUserFilesComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2912); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadUserFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteUserFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeleteUserFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDeleteUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2960); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadDownloadFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadDownloadFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2976); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteDownloadFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteDownloadFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2992); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeleteDownloadFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDeleteDownloadFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadSharedFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadSharedFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3024); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteSharedFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteSharedFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3040); }
    }

    /// <summary>
    /// DelegateProperty: __OnRequestComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRequestComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3056); }
    }

    /// <summary>
    /// DelegateProperty: __SteamDLCCallback__Delegate
    /// </summary>
    public unsafe System.IntPtr __SteamDLCCallback__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3072); }
    }
}
