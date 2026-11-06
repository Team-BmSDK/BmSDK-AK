#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_InGameStore<br/>
/// (size = 1204)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_InGameStore : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_InGameStore", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_InGameStore.
    /// </summary>
    public static RGFxMovieUI_InGameStore DefaultObject => (RGFxMovieUI_InGameStore)StaticClass().DefaultObject;

    internal RGFxMovieUI_InGameStore() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_InGameStore
    /// </summary>
    public RGFxMovieUI_InGameStore(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_InGameStore Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_InGameStore(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_InGameStore>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_InGameStore>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_InGameStore>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_InGameStore>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_InGameStore>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_InGameStore>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_InGameStore>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_InGameStore>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DebugStoreContent;
    /// <summary>
    /// Function: DebugStoreContent
    /// </summary>
    public unsafe virtual void DebugStoreContent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugStoreContent, "BmScript.RGFxMovieUI_InGameStore.DebugStoreContent");
        byte* paramsPtr = stackalloc byte[180];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateInGameStoreUI;
    /// <summary>
    /// Function: UpdateInGameStoreUI
    /// </summary>
    public unsafe virtual void UpdateInGameStoreUI()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateInGameStoreUI, "BmScript.RGFxMovieUI_InGameStore.UpdateInGameStoreUI");
        byte* paramsPtr = stackalloc byte[288];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PriceToString;
    /// <summary>
    /// Function: PriceToString
    /// </summary>
    public unsafe virtual BmSDK.FString PriceToString(BmSDK.FString Price)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PriceToString, "BmScript.RGFxMovieUI_InGameStore.PriceToString");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Price, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_OnReadHydraContentComplete;
    /// <summary>
    /// Function: OnReadHydraContentComplete
    /// </summary>
    public unsafe virtual void OnReadHydraContentComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadHydraContentComplete, "BmScript.RGFxMovieUI_InGameStore.OnReadHydraContentComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadSteamDLCFromHydraComplete;
    /// <summary>
    /// Function: OnReadSteamDLCFromHydraComplete
    /// </summary>
    public unsafe virtual void OnReadSteamDLCFromHydraComplete(bool bWasSuccessful, BmSDK.TArray<BmSDK.IpDrv.OnlineSubsystemCommonImpl.FSteam_PriceInfo> aPrices)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadSteamDLCFromHydraComplete, "BmScript.RGFxMovieUI_InGameStore.OnReadSteamDLCFromHydraComplete");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPrices, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadInGameStoreContentComplete;
    /// <summary>
    /// Function: OnReadInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void OnReadInGameStoreContentComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadInGameStoreContentComplete, "BmScript.RGFxMovieUI_InGameStore.OnReadInGameStoreContentComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPurchaseInGameStoreContentComplete;
    /// <summary>
    /// Function: OnPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe virtual void OnPurchaseInGameStoreContentComplete(bool bBoughtItem)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPurchaseInGameStoreContentComplete, "BmScript.RGFxMovieUI_InGameStore.OnPurchaseInGameStoreContentComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBoughtItem, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_HighlightProduct;
    /// <summary>
    /// Function: XI_HighlightProduct
    /// </summary>
    public unsafe virtual void XI_HighlightProduct(BmSDK.FString sProductId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_HighlightProduct, "BmScript.RGFxMovieUI_InGameStore.XI_HighlightProduct");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sProductId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_PurchaseProduct;
    /// <summary>
    /// Function: XI_PurchaseProduct
    /// </summary>
    public unsafe virtual void XI_PurchaseProduct(BmSDK.FString sProductId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_PurchaseProduct, "BmScript.RGFxMovieUI_InGameStore.XI_PurchaseProduct");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sProductId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ShowDownloadUI;
    /// <summary>
    /// Function: XI_ShowDownloadUI
    /// </summary>
    public unsafe virtual void XI_ShowDownloadUI()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ShowDownloadUI, "BmScript.RGFxMovieUI_InGameStore.XI_ShowDownloadUI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ShowRedeemVoucher;
    /// <summary>
    /// Function: XI_ShowRedeemVoucher
    /// </summary>
    public unsafe virtual bool XI_ShowRedeemVoucher(BmSDK.FString OfferId = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ShowRedeemVoucher, "BmScript.RGFxMovieUI_InGameStore.XI_ShowRedeemVoucher");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OfferId, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_XI_InspectStore;
    /// <summary>
    /// Function: XI_InspectStore
    /// </summary>
    public unsafe virtual void XI_InspectStore()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_InspectStore, "BmScript.RGFxMovieUI_InGameStore.XI_InspectStore");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_InspectProduct;
    /// <summary>
    /// Function: XI_InspectProduct
    /// </summary>
    public unsafe virtual void XI_InspectProduct(BmSDK.FString sProductId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_InspectProduct, "BmScript.RGFxMovieUI_InGameStore.XI_InspectProduct");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sProductId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_StoreEnumerate;
    /// <summary>
    /// Function: XI_StoreEnumerate
    /// </summary>
    public unsafe virtual void XI_StoreEnumerate(BmSDK.FString sTargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_StoreEnumerate, "BmScript.RGFxMovieUI_InGameStore.XI_StoreEnumerate");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sTargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CustomContentLoadedIGS;
    /// <summary>
    /// Function: CustomContentLoadedIGS
    /// </summary>
    public unsafe virtual void CustomContentLoadedIGS(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomContentLoadedIGS, "BmScript.RGFxMovieUI_InGameStore.CustomContentLoadedIGS");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CustomManifestLoadedIGS;
    /// <summary>
    /// Function: CustomManifestLoadedIGS
    /// </summary>
    public unsafe virtual void CustomManifestLoadedIGS(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomManifestLoadedIGS, "BmScript.RGFxMovieUI_InGameStore.CustomManifestLoadedIGS");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetSystemError;
    /// <summary>
    /// Function: UC_SetSystemError
    /// </summary>
    public unsafe virtual void UC_SetSystemError(BmSDK.FString sError, bool bSystemStore)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetSystemError, "BmScript.RGFxMovieUI_InGameStore.UC_SetSystemError");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sError, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSystemStore, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetProductError;
    /// <summary>
    /// Function: UC_SetProductError
    /// </summary>
    public unsafe virtual void UC_SetProductError(BmSDK.FString sProductId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetProductError, "BmScript.RGFxMovieUI_InGameStore.UC_SetProductError");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sProductId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetProductImage;
    /// <summary>
    /// Function: UC_SetProductImage
    /// </summary>
    public unsafe virtual void UC_SetProductImage(BmSDK.FString sProductId, BmSDK.GFxUI.GFxObject iImage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetProductImage, "BmScript.RGFxMovieUI_InGameStore.UC_SetProductImage");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sProductId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iImage, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetProductDetails;
    /// <summary>
    /// Function: UC_SetProductDetails
    /// </summary>
    public unsafe virtual void UC_SetProductDetails(BmSDK.FString sProductId, BmSDK.FString sTitle, BmSDK.FString sPrice, BmSDK.FString sState, bool bAvailable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetProductDetails, "BmScript.RGFxMovieUI_InGameStore.UC_SetProductDetails");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sProductId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sTitle, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPrice, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sState, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAvailable, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_AddProduct;
    /// <summary>
    /// Function: UC_AddProduct
    /// </summary>
    public unsafe virtual void UC_AddProduct(int nPage, int nRX, int nRY, int nRW, int nRH, BmSDK.FString sProductId, BmSDK.FString sTitle, BmSDK.FString sPrice, BmSDK.FString sState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddProduct, "BmScript.RGFxMovieUI_InGameStore.UC_AddProduct");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRW, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nRH, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sProductId, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sTitle, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPrice, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sState, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Tick;
    /// <summary>
    /// Function: XI_Tick
    /// </summary>
    public unsafe override void XI_Tick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Tick, "BmScript.RGFxMovieUI_InGameStore.XI_Tick");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupScreenPrompts;
    /// <summary>
    /// Function: SetupScreenPrompts
    /// </summary>
    public unsafe override void SetupScreenPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupScreenPrompts, "BmScript.RGFxMovieUI_InGameStore.SetupScreenPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmScript.RGFxMovieUI_InGameStore.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyLoginStatusChanged;
    /// <summary>
    /// Function: NotifyLoginStatusChanged
    /// </summary>
    public unsafe virtual void NotifyLoginStatusChanged(byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLoginStatusChanged, "BmScript.RGFxMovieUI_InGameStore.NotifyLoginStatusChanged");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyOnlineServiceStatusChanged;
    /// <summary>
    /// Function: NotifyOnlineServiceStatusChanged
    /// </summary>
    public unsafe virtual void NotifyOnlineServiceStatusChanged(BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus NewConnectionStatus)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyOnlineServiceStatusChanged, "BmScript.RGFxMovieUI_InGameStore.NotifyOnlineServiceStatusChanged");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewConnectionStatus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnContentStatusChanged;
    /// <summary>
    /// Function: OnContentStatusChanged
    /// </summary>
    public unsafe virtual void OnContentStatusChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnContentStatusChanged, "BmScript.RGFxMovieUI_InGameStore.OnContentStatusChanged");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMsgBoxUIComplete;
    /// <summary>
    /// Function: OnMsgBoxUIComplete
    /// </summary>
    public unsafe virtual void OnMsgBoxUIComplete(int ButtonResult)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMsgBoxUIComplete, "BmScript.RGFxMovieUI_InGameStore.OnMsgBoxUIComplete");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonResult, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Reliable_OnBack;
    /// <summary>
    /// Function: Reliable_OnBack
    /// </summary>
    public unsafe virtual void Reliable_OnBack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reliable_OnBack, "BmScript.RGFxMovieUI_InGameStore.Reliable_OnBack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnBack;
    /// <summary>
    /// Function: XI_OnBack
    /// </summary>
    public unsafe override void XI_OnBack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnBack, "BmScript.RGFxMovieUI_InGameStore.XI_OnBack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmScript.RGFxMovieUI_InGameStore.CloseScreen");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer iPlayer = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_InGameStore.Init");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FHydraTrackingInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FHydraTrackingInfo
    {
        /// <summary>
        /// StrProperty: ItemId
        /// </summary>
        public unsafe BmSDK.FString ItemId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ItemName
        /// </summary>
        public unsafe BmSDK.FString ItemName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: ItemCategory
        /// </summary>
        public unsafe BmSDK.FString ItemCategory
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: LoadTimeStart
        /// </summary>
        public unsafe int LoadTimeStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// IntProperty: LoadTime
        /// </summary>
        public unsafe int LoadTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: HighlightedThisVisit
        /// </summary>
        public unsafe bool HighlightedThisVisit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// StrProperty: sManifest
    /// </summary>
    public unsafe BmSDK.FString sManifest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: m_sMoviePath
    /// </summary>
    public unsafe BmSDK.FString m_sMoviePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: m_aStoreContent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent> m_aStoreContent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: m_aSWFTest
    /// </summary>
    public unsafe BmSDK.TArray<byte> m_aSWFTest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: m_aActiveCustomRequestIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> m_aActiveCustomRequestIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: m_bStoreContentEnumerated
    /// </summary>
    public unsafe bool m_bStoreContentEnumerated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bStoreContentSuccessful
    /// </summary>
    public unsafe bool m_bStoreContentSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bHydraContentEnumerated
    /// </summary>
    public unsafe bool m_bHydraContentEnumerated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bHydraContentSuccessful
    /// </summary>
    public unsafe bool m_bHydraContentSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bXYAvailable
    /// </summary>
    public unsafe bool bXYAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bSteamDLCPriceContentEnumerated
    /// </summary>
    public unsafe bool m_bSteamDLCPriceContentEnumerated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: m_aHydraTrackingInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieUI_InGameStore.FHydraTrackingInfo> m_aHydraTrackingInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieUI_InGameStore.FHydraTrackingInfo>>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// DelegateProperty: __CustomManifestLoadedIGS__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomManifestLoadedIGS__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// DelegateProperty: __CustomContentLoadedIGS__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomContentLoadedIGS__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
}
