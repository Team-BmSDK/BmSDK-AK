#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_WBIDUnlocksAndRewards<br/>
/// (size = 1228)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_WBIDUnlocksAndRewards : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_WBIDUnlocksAndRewards.
    /// </summary>
    public static RGFxMovieUI_WBIDUnlocksAndRewards DefaultObject => (RGFxMovieUI_WBIDUnlocksAndRewards)StaticClass().DefaultObject;

    internal RGFxMovieUI_WBIDUnlocksAndRewards() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_WBIDUnlocksAndRewards
    /// </summary>
    public RGFxMovieUI_WBIDUnlocksAndRewards(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_WBIDUnlocksAndRewards Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_WBIDUnlocksAndRewards(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WBIDUnlocksAndRewards>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WBIDUnlocksAndRewards>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WBIDUnlocksAndRewards>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WBIDUnlocksAndRewards>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WBIDUnlocksAndRewards>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WBIDUnlocksAndRewards>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WBIDUnlocksAndRewards>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WBIDUnlocksAndRewards>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CompareUTCTimes;
    /// <summary>
    /// Function: CompareUTCTimes
    /// </summary>
    public unsafe virtual void CompareUTCTimes(BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDTime TimeA, BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDTime TimeB, out int AIsGreaterThanB, out int AreEqual)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CompareUTCTimes, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.CompareUTCTimes");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeB, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AIsGreaterThanB);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AIsGreaterThanB, paramsPtr + 56);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AreEqual);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AreEqual, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AIsGreaterThanB = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 56);
        AreEqual = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 60);
        return;
    }

    private static BmSDK.Function __fn_IsTimeALessThanOrEqualTimeB;
    /// <summary>
    /// Function: IsTimeALessThanOrEqualTimeB
    /// </summary>
    public unsafe virtual bool IsTimeALessThanOrEqualTimeB(BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDTime TimeA, BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDTime TimeB)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTimeALessThanOrEqualTimeB, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.IsTimeALessThanOrEqualTimeB");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeB, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_IsTimeAGreaterThanOrEqualTimeB;
    /// <summary>
    /// Function: IsTimeAGreaterThanOrEqualTimeB
    /// </summary>
    public unsafe virtual bool IsTimeAGreaterThanOrEqualTimeB(BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDTime TimeA, BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDTime TimeB)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTimeAGreaterThanOrEqualTimeB, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.IsTimeAGreaterThanOrEqualTimeB");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeB, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_ParseUTCString;
    /// <summary>
    /// Function: ParseUTCString
    /// </summary>
    public unsafe virtual void ParseUTCString(BmSDK.FString UTCTime, out BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDTime Time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ParseUTCString, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.ParseUTCString");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UTCTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDTime>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentUTCTimeViaWBIDTime;
    /// <summary>
    /// Function: GetCurrentUTCTimeViaWBIDTime
    /// </summary>
    public unsafe virtual void GetCurrentUTCTimeViaWBIDTime(out BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDTime Time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentUTCTimeViaWBIDTime, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.GetCurrentUTCTimeViaWBIDTime");
        byte* paramsPtr = stackalloc byte[56];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDTime>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Tick;
    /// <summary>
    /// Function: XI_Tick
    /// </summary>
    public unsafe override void XI_Tick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Tick, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_Tick");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe virtual void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoWBPlay;
    /// <summary>
    /// Function: GotoWBPlay
    /// </summary>
    public unsafe virtual void GotoWBPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoWBPlay, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.GotoWBPlay");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateWBIDWidgets;
    /// <summary>
    /// Function: UpdateWBIDWidgets
    /// </summary>
    public unsafe virtual void UpdateWBIDWidgets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateWBIDWidgets, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UpdateWBIDWidgets");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWBIDOverlayClosed;
    /// <summary>
    /// Function: OnWBIDOverlayClosed
    /// </summary>
    public unsafe virtual void OnWBIDOverlayClosed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWBIDOverlayClosed, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.OnWBIDOverlayClosed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BootOverlays;
    /// <summary>
    /// Function: BootOverlays
    /// </summary>
    public unsafe virtual void BootOverlays()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BootOverlays, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.BootOverlays");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_UpdatePendingRewards;
    /// <summary>
    /// Function: XI_UpdatePendingRewards
    /// </summary>
    public unsafe virtual void XI_UpdatePendingRewards(int Pending)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_UpdatePendingRewards, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_UpdatePendingRewards");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pending, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ManageAccount;
    /// <summary>
    /// Function: XI_ManageAccount
    /// </summary>
    public unsafe virtual void XI_ManageAccount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ManageAccount, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_ManageAccount");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SignInToWBPlay;
    /// <summary>
    /// Function: XI_SignInToWBPlay
    /// </summary>
    public unsafe virtual void XI_SignInToWBPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SignInToWBPlay, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_SignInToWBPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ClaimReward;
    /// <summary>
    /// Function: XI_ClaimReward
    /// </summary>
    public unsafe virtual void XI_ClaimReward(BmSDK.FString RewardFlag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ClaimReward, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_ClaimReward");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RewardFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetMouseY;
    /// <summary>
    /// Function: XI_GetMouseY
    /// </summary>
    public unsafe virtual void XI_GetMouseY(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetMouseY, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_GetMouseY");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Trace;
    /// <summary>
    /// Function: XI_Trace
    /// </summary>
    public unsafe virtual void XI_Trace(BmSDK.FString msg)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Trace, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_Trace");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(msg, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnBack;
    /// <summary>
    /// Function: XI_OnBack
    /// </summary>
    public unsafe override void XI_OnBack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnBack, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_OnBack");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnOut;
    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe override void XI_OnOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnOut, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_OnOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnIn;
    /// <summary>
    /// Function: XI_OnIn
    /// </summary>
    public unsafe override void XI_OnIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnIn, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_OnIn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupScreenPrompts;
    /// <summary>
    /// Function: SetupScreenPrompts
    /// </summary>
    public unsafe override void SetupScreenPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupScreenPrompts, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.SetupScreenPrompts");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Update;
    /// <summary>
    /// Function: XI_Update
    /// </summary>
    public unsafe virtual void XI_Update(BmSDK.GFxUI.GFxObject iRewardData, int Node, bool IsCommunityEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Update, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_Update");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iRewardData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Node, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsCommunityEvent, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ShowMobileReleaseOverlay;
    /// <summary>
    /// Function: XI_ShowMobileReleaseOverlay
    /// </summary>
    public unsafe virtual void XI_ShowMobileReleaseOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ShowMobileReleaseOverlay, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_ShowMobileReleaseOverlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_Timeout;
    /// <summary>
    /// Function: UC_Timeout
    /// </summary>
    public unsafe virtual void UC_Timeout()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_Timeout, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_Timeout");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetSystemError;
    /// <summary>
    /// Function: UC_SetSystemError
    /// </summary>
    public unsafe virtual void UC_SetSystemError(BmSDK.FString sError, bool bSystemError)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetSystemError, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_SetSystemError");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sError, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSystemError, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_DoneLoading;
    /// <summary>
    /// Function: UC_DoneLoading
    /// </summary>
    public unsafe virtual void UC_DoneLoading()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_DoneLoading, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_DoneLoading");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetWBPlaySignedIn;
    /// <summary>
    /// Function: UC_SetWBPlaySignedIn
    /// </summary>
    public unsafe virtual void UC_SetWBPlaySignedIn(bool SignedIn, BmSDK.FString Email = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetWBPlaySignedIn, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_SetWBPlaySignedIn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SignedIn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Email, paramsPtr + 4);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_UC_IsOfTypeWBIDRewardData;
    /// <summary>
    /// Function: UC_IsOfTypeWBIDRewardData
    /// </summary>
    public unsafe virtual int UC_IsOfTypeWBIDRewardData(BmSDK.GFxUI.GFxObject iRewardData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_IsOfTypeWBIDRewardData, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_IsOfTypeWBIDRewardData");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iRewardData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UC_SelectReward;
    /// <summary>
    /// Function: UC_SelectReward
    /// </summary>
    public unsafe virtual void UC_SelectReward(BmSDK.FString Stab, BmSDK.FString sRewardFlag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SelectReward, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_SelectReward");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stab, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sRewardFlag, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SelectTab;
    /// <summary>
    /// Function: UC_SelectTab
    /// </summary>
    public unsafe virtual void UC_SelectTab(BmSDK.FString Stab)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SelectTab, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_SelectTab");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stab, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SelectItem;
    /// <summary>
    /// Function: UC_SelectItem
    /// </summary>
    public unsafe virtual void UC_SelectItem(int nNode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SelectItem, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_SelectItem");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nNode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OneLessContentToLoad;
    /// <summary>
    /// Function: OneLessContentToLoad
    /// </summary>
    public unsafe virtual void OneLessContentToLoad()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OneLessContentToLoad, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.OneLessContentToLoad");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetRewardDescriptionImage;
    /// <summary>
    /// Function: UC_SetRewardDescriptionImage
    /// </summary>
    public unsafe virtual void UC_SetRewardDescriptionImage(BmSDK.FString Stab, BmSDK.FString sRewardName, BmSDK.GFxUI.GFxObject aImage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetRewardDescriptionImage, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_SetRewardDescriptionImage");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stab, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sRewardName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aImage, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetRewardMenuImage;
    /// <summary>
    /// Function: UC_SetRewardMenuImage
    /// </summary>
    public unsafe virtual void UC_SetRewardMenuImage(BmSDK.FString Stab, BmSDK.FString sRewardName, BmSDK.GFxUI.GFxObject aImage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetRewardMenuImage, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_SetRewardMenuImage");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stab, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sRewardName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aImage, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadComingSoonContentComplete;
    /// <summary>
    /// Function: OnReadComingSoonContentComplete
    /// </summary>
    public unsafe virtual void OnReadComingSoonContentComplete(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadComingSoonContentComplete, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.OnReadComingSoonContentComplete");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadRewardDescriptionContentComplete;
    /// <summary>
    /// Function: OnReadRewardDescriptionContentComplete
    /// </summary>
    public unsafe virtual void OnReadRewardDescriptionContentComplete(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadRewardDescriptionContentComplete, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.OnReadRewardDescriptionContentComplete");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadRewardMenuContentComplete;
    /// <summary>
    /// Function: OnReadRewardMenuContentComplete
    /// </summary>
    public unsafe virtual void OnReadRewardMenuContentComplete(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadRewardMenuContentComplete, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.OnReadRewardMenuContentComplete");
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadRewardManifestComplete;
    /// <summary>
    /// Function: OnReadRewardManifestComplete
    /// </summary>
    public unsafe virtual void OnReadRewardManifestComplete(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadRewardManifestComplete, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.OnReadRewardManifestComplete");
        byte* paramsPtr = stackalloc byte[376];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_AddCommunityEventReward;
    /// <summary>
    /// Function: UC_AddCommunityEventReward
    /// </summary>
    public unsafe virtual void UC_AddCommunityEventReward(BmSDK.GFxUI.GFxObject iRewardData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddCommunityEventReward, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_AddCommunityEventReward");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iRewardData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_AddUnlockReward;
    /// <summary>
    /// Function: UC_AddUnlockReward
    /// </summary>
    public unsafe virtual void UC_AddUnlockReward(BmSDK.GFxUI.GFxObject iRewardData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddUnlockReward, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.UC_AddUnlockReward");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iRewardData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.CloseScreen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_FetchRewards;
    /// <summary>
    /// Function: XI_FetchRewards
    /// </summary>
    public unsafe virtual void XI_FetchRewards(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_FetchRewards, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.XI_FetchRewards");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.Init");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateGiftWBIDReward;
    /// <summary>
    /// Function: CreateGiftWBIDReward
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDReward CreateGiftWBIDReward(BmSDK.BmGame.RGameInfo.FWBPlayRewardInfo iRewardData, BmSDK.FString sEventDescription, bool bUnlocked = default, bool bUnclaimed = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateGiftWBIDReward, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.CreateGiftWBIDReward");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iRewardData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sEventDescription, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnlocked, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnclaimed, paramsPtr + 100);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDReward>(paramsPtr + 104);
    }

    private static BmSDK.Function __fn_CreateCommunityEventWBIDReward;
    /// <summary>
    /// Function: CreateCommunityEventWBIDReward
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDReward CreateCommunityEventWBIDReward(BmSDK.BmGame.RGameInfo.FWBPlayRewardInfo iRewardData, BmSDK.FString sEventDescription, BmSDK.FString sCommunityStatus, bool bUnclaimed = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateCommunityEventWBIDReward, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.CreateCommunityEventWBIDReward");
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iRewardData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sEventDescription, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCommunityStatus, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnclaimed, paramsPtr + 112);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDReward>(paramsPtr + 116);
    }

    private static BmSDK.Function __fn_CreateUnlockableWBIDReward;
    /// <summary>
    /// Function: CreateUnlockableWBIDReward
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDReward CreateUnlockableWBIDReward(BmSDK.BmGame.RGameInfo.FWBPlayRewardInfo iRewardData, BmSDK.FString sEventDescription, bool bUnlocked = default, bool bUnclaimed = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateUnlockableWBIDReward, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.CreateUnlockableWBIDReward");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iRewardData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sEventDescription, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnlocked, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnclaimed, paramsPtr + 100);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDReward>(paramsPtr + 104);
    }

    private static BmSDK.Function __fn_CreateWBIDReward;
    /// <summary>
    /// Function: CreateWBIDReward
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDReward CreateWBIDReward()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWBIDReward, "BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.CreateWBIDReward");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDReward>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FWBIDReward
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FWBIDReward
    {
        /// <summary>
        /// BoolProperty: CommunityEvent
        /// </summary>
        public unsafe bool CommunityEvent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Node
        /// </summary>
        public unsafe int Node
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: RewardData
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject RewardData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FWBIDTime
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FWBIDTime
    {
        /// <summary>
        /// IntProperty: Year
        /// </summary>
        public unsafe int Year
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Month
        /// </summary>
        public unsafe int Month
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Day
        /// </summary>
        public unsafe int Day
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Hour
        /// </summary>
        public unsafe int Hour
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Minute
        /// </summary>
        public unsafe int Minute
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Second
        /// </summary>
        public unsafe int Second
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: Microsecond
        /// </summary>
        public unsafe int Microsecond
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// BoolProperty: SaveOnClose
    /// </summary>
    public unsafe bool SaveOnClose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bOrbisBeginSignIn
    /// </summary>
    public unsafe bool bOrbisBeginSignIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bIsPC
    /// </summary>
    public unsafe bool bIsPC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bIsDurango
    /// </summary>
    public unsafe bool bIsDurango
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bIsOrbis
    /// </summary>
    public unsafe bool bIsOrbis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bIsDemo
    /// </summary>
    public unsafe bool bIsDemo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: ScreenFailedToLoad
    /// </summary>
    public unsafe bool ScreenFailedToLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: RewardManifestSuccessful
    /// </summary>
    public unsafe bool RewardManifestSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: MobileReleaseOverlayEnabled
    /// </summary>
    public unsafe bool MobileReleaseOverlayEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: MobileReleaseOverlayShown
    /// </summary>
    public unsafe bool MobileReleaseOverlayShown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: ShowTabPrompt
    /// </summary>
    public unsafe bool ShowTabPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: ReturnToMainMenu
    /// </summary>
    public unsafe bool ReturnToMainMenu
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: RGI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo RGI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ObjectProperty: WBIDOverlays
    /// </summary>
    public unsafe BmSDK.BmScript.MGFxMovieUI_WBIDMain WBIDOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MGFxMovieUI_WBIDMain>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: ManagerRef
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDOverlayManager ManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDOverlayManager>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: DataMessage
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDDataMessage DataMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDDataMessage>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// StrProperty: FlashPath
    /// </summary>
    public unsafe BmSDK.FString FlashPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// IntProperty: NumberOfPendingRewards
    /// </summary>
    public unsafe int NumberOfPendingRewards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ArrayProperty: WBIDMovieInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.SwfMovie> WBIDMovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.SwfMovie>>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ByteProperty: PopupType
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_MainMenu.MMPopTypes PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_MainMenu.MMPopTypes>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// StrProperty: MOTD_SelectedTab
    /// </summary>
    public unsafe BmSDK.FString MOTD_SelectedTab
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// StrProperty: MOTD_SelectedNode
    /// </summary>
    public unsafe BmSDK.FString MOTD_SelectedNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// StrProperty: MobileReleaseMessage
    /// </summary>
    public unsafe BmSDK.FString MobileReleaseMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ArrayProperty: ActiveCustomRequestIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ActiveCustomRequestIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// StructProperty: CurrentReward
    /// </summary>
    public unsafe ref BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDReward CurrentReward
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards.FWBIDReward>(Ptr + 1212);
}
