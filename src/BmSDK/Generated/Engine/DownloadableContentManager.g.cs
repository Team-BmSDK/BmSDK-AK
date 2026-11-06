#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DownloadableContentManager<br/>
/// (size = 332)
/// (flags = 134217874)
/// </summary>
public partial class DownloadableContentManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DownloadableContentManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as DownloadableContentManager.
    /// </summary>
    public static DownloadableContentManager DefaultObject => (DownloadableContentManager)StaticClass().DefaultObject;

    internal DownloadableContentManager() { }

    /// <summary>
    /// Constructs a new DownloadableContentManager
    /// </summary>
    public DownloadableContentManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DownloadableContentManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DownloadableContentManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DownloadableContentManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DownloadableContentManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DownloadableContentManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DownloadableContentManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DownloadableContentManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DownloadableContentManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DownloadableContentManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DownloadableContentManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnRefreshComplete;
    /// <summary>
    /// Function: OnRefreshComplete
    /// </summary>
    public unsafe virtual void OnRefreshComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRefreshComplete, "Engine.DownloadableContentManager.OnRefreshComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPackagesToFullyLoad;
    /// <summary>
    /// Function: AddPackagesToFullyLoad
    /// </summary>
    public unsafe virtual void AddPackagesToFullyLoad(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPackagesToFullyLoad, "Engine.DownloadableContentManager.AddPackagesToFullyLoad");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RefreshDLCEnumComplete;
    /// <summary>
    /// Function: RefreshDLCEnumComplete
    /// </summary>
    public unsafe virtual void RefreshDLCEnumComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshDLCEnumComplete, "Engine.DownloadableContentManager.RefreshDLCEnumComplete");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshDLC;
    /// <summary>
    /// Function: RefreshDLC
    /// </summary>
    public unsafe virtual void RefreshDLC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshDLC, "Engine.DownloadableContentManager.RefreshDLC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetListOfBadBundles;
    /// <summary>
    /// Function: GetListOfBadBundles
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.FString> GetListOfBadBundles(bool bCorrupt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetListOfBadBundles, "Engine.DownloadableContentManager.GetListOfBadBundles");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCorrupt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AreAnyBundlesInvalidUser;
    /// <summary>
    /// Function: AreAnyBundlesInvalidUser
    /// </summary>
    public unsafe virtual bool AreAnyBundlesInvalidUser()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAnyBundlesInvalidUser, "Engine.DownloadableContentManager.AreAnyBundlesInvalidUser");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AreAnyBundlesCorrupt;
    /// <summary>
    /// Function: AreAnyBundlesCorrupt
    /// </summary>
    public unsafe virtual bool AreAnyBundlesCorrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAnyBundlesCorrupt, "Engine.DownloadableContentManager.AreAnyBundlesCorrupt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearALLDLC;
    /// <summary>
    /// Function: ClearALLDLC
    /// </summary>
    public unsafe virtual void ClearALLDLC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearALLDLC, "Engine.DownloadableContentManager.ClearALLDLC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "Engine.DownloadableContentManager.Init");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InstallNonPackageFiles;
    /// <summary>
    /// Function: InstallNonPackageFiles
    /// </summary>
    public unsafe virtual void InstallNonPackageFiles(out BmSDK.Engine.OnlineSubsystem.FOnlineContent DLCBundle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstallNonPackageFiles, "Engine.DownloadableContentManager.InstallNonPackageFiles");
        byte* paramsPtr = stackalloc byte[104];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DLCBundle = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FOnlineContent>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_InstallPackages;
    /// <summary>
    /// Function: InstallPackages
    /// </summary>
    public unsafe virtual void InstallPackages(out BmSDK.Engine.OnlineSubsystem.FOnlineContent DLCBundle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstallPackages, "Engine.DownloadableContentManager.InstallPackages");
        byte* paramsPtr = stackalloc byte[104];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DLCBundle = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FOnlineContent>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateObjectLists;
    /// <summary>
    /// Function: UpdateObjectLists
    /// </summary>
    public unsafe virtual void UpdateObjectLists()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateObjectLists, "Engine.DownloadableContentManager.UpdateObjectLists");
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

    private static BmSDK.Function __fn_MarkPerObjectConfigPendingKill;
    /// <summary>
    /// Function: MarkPerObjectConfigPendingKill
    /// </summary>
    public unsafe virtual void MarkPerObjectConfigPendingKill(BmSDK.FString Section)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkPerObjectConfigPendingKill, "Engine.DownloadableContentManager.MarkPerObjectConfigPendingKill");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Section, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddSectionToObjectList;
    /// <summary>
    /// Function: AddSectionToObjectList
    /// </summary>
    public unsafe virtual void AddSectionToObjectList(BmSDK.FString Section)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSectionToObjectList, "Engine.DownloadableContentManager.AddSectionToObjectList");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Section, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FlushOpenHandles;
    /// <summary>
    /// Function: FlushOpenHandles
    /// </summary>
    public unsafe virtual void FlushOpenHandles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushOpenHandles, "Engine.DownloadableContentManager.FlushOpenHandles");
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

    private static BmSDK.Function __fn_GetRockDLCCachePath;
    /// <summary>
    /// Function: GetRockDLCCachePath
    /// </summary>
    public unsafe virtual bool GetRockDLCCachePath(BmSDK.FName BaseName, out BmSDK.FString Path)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRockDLCCachePath, "Engine.DownloadableContentManager.GetRockDLCCachePath");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Path = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetDLCNonPackageFilePath;
    /// <summary>
    /// Function: GetDLCNonPackageFilePath
    /// </summary>
    public unsafe virtual bool GetDLCNonPackageFilePath(BmSDK.FName NonPackageFileName, out BmSDK.FString Path)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDLCNonPackageFilePath, "Engine.DownloadableContentManager.GetDLCNonPackageFilePath");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NonPackageFileName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Path = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClearDLC;
    /// <summary>
    /// Function: ClearDLC
    /// </summary>
    public unsafe virtual void ClearDLC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDLC, "Engine.DownloadableContentManager.ClearDLC");
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

    private static BmSDK.Function __fn_InstallDLCs;
    /// <summary>
    /// Function: InstallDLCs
    /// </summary>
    public unsafe virtual void InstallDLCs(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent> DLCBundles)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstallDLCs, "Engine.DownloadableContentManager.InstallDLCs");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DLCBundles = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_InstallDLC;
    /// <summary>
    /// Function: InstallDLC
    /// </summary>
    public unsafe virtual bool InstallDLC(out BmSDK.Engine.OnlineSubsystem.FOnlineContent DLCBundle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstallDLC, "Engine.DownloadableContentManager.InstallDLC");
        byte* paramsPtr = stackalloc byte[108];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DLCBundle = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FOnlineContent>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 104);
    }

    /// <summary>
    /// ArrayProperty: DLCConfigCacheChanges
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> DLCConfigCacheChanges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: InstalledDLC
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> InstalledDLC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: NonPackageFilePathMap
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMap_Mirror NonPackageFilePathMap
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMap_Mirror>(Ptr + 116);

    /// <summary>
    /// StructProperty: RockDLCCachePathMap
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMap_Mirror RockDLCCachePathMap
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMap_Mirror>(Ptr + 188);

    /// <summary>
    /// ArrayProperty: ClassesToReload
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> ClassesToReload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: ObjectsToReload
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> ObjectsToReload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ArrayProperty: QueuedFullyLoadPackageInis
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> QueuedFullyLoadPackageInis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: GameEngine
    /// </summary>
    public unsafe BmSDK.Engine.GameEngine GameEngine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameEngine>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// DelegateProperty: __OnRefreshComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRefreshComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }
}
