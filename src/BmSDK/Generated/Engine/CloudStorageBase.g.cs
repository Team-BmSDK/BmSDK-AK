#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CloudStorageBase<br/>
/// (size = 136)
/// (flags = 134217882)
/// </summary>
public partial class CloudStorageBase : BmSDK.Engine.PlatformInterfaceBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CloudStorageBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as CloudStorageBase.
    /// </summary>
    public static CloudStorageBase DefaultObject => (CloudStorageBase)StaticClass().DefaultObject;

    internal CloudStorageBase() { }

    /// <summary>
    /// Constructs a new CloudStorageBase
    /// </summary>
    public CloudStorageBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CloudStorageBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CloudStorageBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CloudStorageBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CloudStorageBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CloudStorageBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CloudStorageBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CloudStorageBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CloudStorageBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CloudStorageBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CloudStorageBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpgradeLocalStorageToCloud;
    /// <summary>
    /// Function: UpgradeLocalStorageToCloud
    /// </summary>
    public unsafe virtual bool UpgradeLocalStorageToCloud(BmSDK.Engine.CloudStorageUpgradeHelper UpgradeHelper, bool bForceSearchAgain = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradeLocalStorageToCloud, "Engine.CloudStorageBase.UpgradeLocalStorageToCloud");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpgradeHelper, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSearchAgain, paramsPtr + 16);
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

    private static BmSDK.Function __fn_ResolveConflictWithVersionIndex;
    /// <summary>
    /// Function: ResolveConflictWithVersionIndex
    /// </summary>
    public unsafe virtual bool ResolveConflictWithVersionIndex(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResolveConflictWithVersionIndex, "Engine.CloudStorageBase.ResolveConflictWithVersionIndex");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ResolveConflictWithNewestDocument;
    /// <summary>
    /// Function: ResolveConflictWithNewestDocument
    /// </summary>
    public unsafe virtual bool ResolveConflictWithNewestDocument()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResolveConflictWithNewestDocument, "Engine.CloudStorageBase.ResolveConflictWithNewestDocument");
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

    private static BmSDK.Function __fn_WaitForWritesToFinish;
    /// <summary>
    /// Function: WaitForWritesToFinish
    /// </summary>
    public unsafe virtual bool WaitForWritesToFinish(float MaxTimeSeconds = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WaitForWritesToFinish, "Engine.CloudStorageBase.WaitForWritesToFinish");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxTimeSeconds, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsStillWritingFiles;
    /// <summary>
    /// Function: IsStillWritingFiles
    /// </summary>
    public unsafe virtual bool IsStillWritingFiles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStillWritingFiles, "Engine.CloudStorageBase.IsStillWritingFiles");
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

    private static BmSDK.Function __fn_SaveDocumentWithObject;
    /// <summary>
    /// Function: SaveDocumentWithObject
    /// </summary>
    public unsafe virtual bool SaveDocumentWithObject(int Index, BmSDK.GameObject ObjectData, int SaveVersion)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveDocumentWithObject, "Engine.CloudStorageBase.SaveDocumentWithObject");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectData, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveVersion, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SaveDocumentWithBytes;
    /// <summary>
    /// Function: SaveDocumentWithBytes
    /// </summary>
    public unsafe virtual bool SaveDocumentWithBytes(int Index, BmSDK.TArray<byte> ByteData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveDocumentWithBytes, "Engine.CloudStorageBase.SaveDocumentWithBytes");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ByteData, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SaveDocumentWithString;
    /// <summary>
    /// Function: SaveDocumentWithString
    /// </summary>
    public unsafe virtual bool SaveDocumentWithString(int Index, BmSDK.FString StringData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveDocumentWithString, "Engine.CloudStorageBase.SaveDocumentWithString");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringData, paramsPtr + 4);
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

    private static BmSDK.Function __fn_WriteCloudDocument;
    /// <summary>
    /// Function: WriteCloudDocument
    /// </summary>
    public unsafe virtual bool WriteCloudDocument(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteCloudDocument, "Engine.CloudStorageBase.WriteCloudDocument");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ParseDocumentAsObject;
    /// <summary>
    /// Function: ParseDocumentAsObject
    /// </summary>
    public unsafe virtual BmSDK.GameObject ParseDocumentAsObject(int Index, BmSDK.Class ObjectClass, int ExpectedVersion, bool bIsForConflict = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ParseDocumentAsObject, "Engine.CloudStorageBase.ParseDocumentAsObject");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectClass, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExpectedVersion, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsForConflict, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ParseDocumentAsBytes;
    /// <summary>
    /// Function: ParseDocumentAsBytes
    /// </summary>
    public unsafe virtual void ParseDocumentAsBytes(int Index, out BmSDK.TArray<byte> ByteData, bool bIsForConflict = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ParseDocumentAsBytes, "Engine.CloudStorageBase.ParseDocumentAsBytes");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsForConflict, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ByteData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_ParseDocumentAsString;
    /// <summary>
    /// Function: ParseDocumentAsString
    /// </summary>
    public unsafe virtual BmSDK.FString ParseDocumentAsString(int Index, bool bIsForConflict = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ParseDocumentAsString, "Engine.CloudStorageBase.ParseDocumentAsString");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsForConflict, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ReadCloudDocument;
    /// <summary>
    /// Function: ReadCloudDocument
    /// </summary>
    public unsafe virtual bool ReadCloudDocument(int Index, bool bIsForConflict = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadCloudDocument, "Engine.CloudStorageBase.ReadCloudDocument");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsForConflict, paramsPtr + 4);
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

    private static BmSDK.Function __fn_CreateCloudDocument;
    /// <summary>
    /// Function: CreateCloudDocument
    /// </summary>
    public unsafe virtual int CreateCloudDocument(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateCloudDocument, "Engine.CloudStorageBase.CreateCloudDocument");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetCloudDocumentName;
    /// <summary>
    /// Function: GetCloudDocumentName
    /// </summary>
    public unsafe virtual BmSDK.FString GetCloudDocumentName(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloudDocumentName, "Engine.CloudStorageBase.GetCloudDocumentName");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumCloudDocuments;
    /// <summary>
    /// Function: GetNumCloudDocuments
    /// </summary>
    public unsafe virtual int GetNumCloudDocuments(bool bIsForConflict = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCloudDocuments, "Engine.CloudStorageBase.GetNumCloudDocuments");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsForConflict, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_QueryForCloudDocuments;
    /// <summary>
    /// Function: QueryForCloudDocuments
    /// </summary>
    public unsafe virtual bool QueryForCloudDocuments()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueryForCloudDocuments, "Engine.CloudStorageBase.QueryForCloudDocuments");
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

    private static BmSDK.Function __fn_WriteKeyValue;
    /// <summary>
    /// Function: WriteKeyValue
    /// </summary>
    public unsafe virtual bool WriteKeyValue(BmSDK.FString KeyName, out BmSDK.Engine.PlatformInterfaceBase.FPlatformInterfaceData Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteKeyValue, "Engine.CloudStorageBase.WriteKeyValue");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlatformInterfaceBase.FPlatformInterfaceData>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_ReadKeyValue;
    /// <summary>
    /// Function: ReadKeyValue
    /// </summary>
    public unsafe virtual bool ReadKeyValue(BmSDK.FString KeyName, BmSDK.Engine.PlatformInterfaceBase.EPlatformInterfaceDataType Type, out BmSDK.Engine.PlatformInterfaceBase.FPlatformInterfaceDelegateResult Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadKeyValue, "Engine.CloudStorageBase.ReadKeyValue");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlatformInterfaceBase.FPlatformInterfaceDelegateResult>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_IsUsingLocalStorage;
    /// <summary>
    /// Function: IsUsingLocalStorage
    /// </summary>
    public unsafe virtual bool IsUsingLocalStorage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsUsingLocalStorage, "Engine.CloudStorageBase.IsUsingLocalStorage");
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

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "Engine.CloudStorageBase.Init");
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
    /// ArrayProperty: LocalCloudFiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LocalCloudFiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bSuppressDelegateCalls
    /// </summary>
    public unsafe bool bSuppressDelegateCalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }
    }

    /// <summary>
    /// Enum: ECloudStorageDelegate
    /// </summary>
    public enum ECloudStorageDelegate : byte
    {
        CSD_KeyValueReadComplete = 0,
        CSD_KeyValueWriteComplete = 1,
        CSD_ValueChanged = 2,
        CSD_DocumentQueryComplete = 3,
        CSD_DocumentReadComplete = 4,
        CSD_DocumentWriteComplete = 5,
        CSD_DocumentConflictDetected = 6,
        CSD_MAX = 7,
    }
}
