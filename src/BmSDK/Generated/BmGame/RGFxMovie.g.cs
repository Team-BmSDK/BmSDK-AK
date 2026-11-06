#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovie<br/>
/// (size = 696)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovie : BmSDK.GFxUI.GFxMoviePlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovie", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovie.
    /// </summary>
    public static RGFxMovie DefaultObject => (RGFxMovie)StaticClass().DefaultObject;

    internal RGFxMovie() { }

    /// <summary>
    /// Constructs a new RGFxMovie
    /// </summary>
    public RGFxMovie(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovie Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovie(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsLocationInFearGasXYZ;
    /// <summary>
    /// Function: IsLocationInFearGasXYZ
    /// </summary>
    public unsafe virtual bool IsLocationInFearGasXYZ(float X, float Y, float Z)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocationInFearGasXYZ, "BmGame.RGFxMovie.IsLocationInFearGasXYZ");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 8);
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

    private static BmSDK.Function __fn_IsLocationInFearGas;
    /// <summary>
    /// Function: IsLocationInFearGas
    /// </summary>
    public unsafe virtual bool IsLocationInFearGas(System.Numerics.Vector3 vTestLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocationInFearGas, "BmGame.RGFxMovie.IsLocationInFearGas");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vTestLocation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnLoadedTexture;
    /// <summary>
    /// Function: OnLoadedTexture
    /// </summary>
    public unsafe virtual void OnLoadedTexture(BmSDK.FString sCallback, BmSDK.FString sPackage, BmSDK.Engine.Texture2D pTexture)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoadedTexture, "BmGame.RGFxMovie.OnLoadedTexture");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCallback, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPackage, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pTexture, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoadedPackage;
    /// <summary>
    /// Function: OnLoadedPackage
    /// </summary>
    public unsafe virtual void OnLoadedPackage(BmSDK.FString sCallback)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoadedPackage, "BmGame.RGFxMovie.OnLoadedPackage");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCallback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_LoadPackageSF;
    /// <summary>
    /// Function: XI_LoadPackageSF
    /// </summary>
    public unsafe virtual bool XI_LoadPackageSF(BmSDK.FString sPackage, BmSDK.FString sCallback, BmSDK.FString sAsset = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_LoadPackageSF, "BmGame.RGFxMovie.XI_LoadPackageSF");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPackage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCallback, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAsset, paramsPtr + 32);
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

    private static BmSDK.Function __fn_XI_CancelPackageSF;
    /// <summary>
    /// Function: XI_CancelPackageSF
    /// </summary>
    public unsafe virtual void XI_CancelPackageSF(BmSDK.FString sPackage = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_CancelPackageSF, "BmGame.RGFxMovie.XI_CancelPackageSF");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPackage, paramsPtr + 0);
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

    private static BmSDK.Function __fn_NotifyFriendBeatYou;
    /// <summary>
    /// Function: NotifyFriendBeatYou
    /// </summary>
    public unsafe virtual void NotifyFriendBeatYou()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFriendBeatYou, "BmGame.RGFxMovie.NotifyFriendBeatYou");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAnim;
    /// <summary>
    /// Function: PlayAnim
    /// </summary>
    public unsafe virtual void PlayAnim(BmSDK.FString AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAnim, "BmGame.RGFxMovie.PlayAnim");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VS_FakeNetID;
    /// <summary>
    /// Function: VS_FakeNetID
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.FUniqueNetId VS_FakeNetID(int IconId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VS_FakeNetID, "BmGame.RGFxMovie.VS_FakeNetID");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HandleVoiceRec;
    /// <summary>
    /// Function: HandleVoiceRec
    /// </summary>
    public unsafe virtual bool HandleVoiceRec(BmSDK.FString VoiceRecCommand)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleVoiceRec, "BmGame.RGFxMovie.HandleVoiceRec");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VoiceRecCommand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ProcessVoiceCommand;
    /// <summary>
    /// Function: ProcessVoiceCommand
    /// </summary>
    public unsafe virtual bool ProcessVoiceCommand(BmSDK.FString VoiceRecCommand)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessVoiceCommand, "BmGame.RGFxMovie.ProcessVoiceCommand");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VoiceRecCommand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PreRender;
    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe virtual void PreRender(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreRender, "BmGame.RGFxMovie.PreRender");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManualAdvance;
    /// <summary>
    /// Function: ManualAdvance
    /// </summary>
    public unsafe virtual void ManualAdvance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManualAdvance, "BmGame.RGFxMovie.ManualAdvance");
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

    private static BmSDK.Function __fn_PrepareManualAdvance;
    /// <summary>
    /// Function: PrepareManualAdvance
    /// </summary>
    public unsafe virtual void PrepareManualAdvance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareManualAdvance, "BmGame.RGFxMovie.PrepareManualAdvance");
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

    private static BmSDK.Function __fn_ManualAdvanceTick;
    /// <summary>
    /// Function: ManualAdvanceTick
    /// </summary>
    public unsafe virtual void ManualAdvanceTick(float DeltaT)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManualAdvanceTick, "BmGame.RGFxMovie.ManualAdvanceTick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaT, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSubtitle;
    /// <summary>
    /// Function: SetSubtitle
    /// </summary>
    public unsafe virtual void SetSubtitle(BmSDK.FString TheText)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubtitle, "BmGame.RGFxMovie.SetSubtitle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheText, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveSubtitle;
    /// <summary>
    /// Function: RemoveSubtitle
    /// </summary>
    public unsafe virtual void RemoveSubtitle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveSubtitle, "BmGame.RGFxMovie.RemoveSubtitle");
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

    private static BmSDK.Function __fn_AddSubtitle;
    /// <summary>
    /// Function: AddSubtitle
    /// </summary>
    public unsafe virtual void AddSubtitle(int SubtitlePriority, float SubtitleDuration, BmSDK.FString SubtitleText, bool bBackScreen, bool bMovie)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSubtitle, "BmGame.RGFxMovie.AddSubtitle");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtitlePriority, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtitleDuration, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtitleText, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBackScreen, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMovie, paramsPtr + 28);
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

    private static BmSDK.Function __fn_GetAudioTrackIds;
    /// <summary>
    /// Function: GetAudioTrackIds
    /// </summary>
    public unsafe virtual void GetAudioTrackIds(out int EffectsAudioTrack, out int DialogueAudioTrack, out int SubtitleTrackId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAudioTrackIds, "BmGame.RGFxMovie.GetAudioTrackIds");
        byte* paramsPtr = stackalloc byte[12];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out EffectsAudioTrack);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EffectsAudioTrack, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DialogueAudioTrack);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueAudioTrack, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SubtitleTrackId);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtitleTrackId, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        EffectsAudioTrack = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        DialogueAudioTrack = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        SubtitleTrackId = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerId;
    /// <summary>
    /// Function: GetPlayerId
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.FUniqueNetId GetPlayerId()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerId, "BmGame.RGFxMovie.GetPlayerId");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_IsTimeBasedChallenge;
    /// <summary>
    /// Function: XI_IsTimeBasedChallenge
    /// </summary>
    public unsafe virtual bool XI_IsTimeBasedChallenge(int nId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_IsTimeBasedChallenge, "BmGame.RGFxMovie.XI_IsTimeBasedChallenge");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_XI_IsSignedInOnline;
    /// <summary>
    /// Function: XI_IsSignedInOnline
    /// </summary>
    public unsafe virtual bool XI_IsSignedInOnline()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_IsSignedInOnline, "BmGame.RGFxMovie.XI_IsSignedInOnline");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_CanPlayOnline;
    /// <summary>
    /// Function: XI_CanPlayOnline
    /// </summary>
    public unsafe virtual bool XI_CanPlayOnline()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_CanPlayOnline, "BmGame.RGFxMovie.XI_CanPlayOnline");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_GetNPAvailState;
    /// <summary>
    /// Function: XI_GetNPAvailState
    /// </summary>
    public unsafe virtual int XI_GetNPAvailState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetNPAvailState, "BmGame.RGFxMovie.XI_GetNPAvailState");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_GetDisplayName;
    /// <summary>
    /// Function: XI_GetDisplayName
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetDisplayName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetDisplayName, "BmGame.RGFxMovie.XI_GetDisplayName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_GetNickName;
    /// <summary>
    /// Function: XI_GetNickName
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetNickName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetNickName, "BmGame.RGFxMovie.XI_GetNickName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveBank;
    /// <summary>
    /// Function: RemoveBank
    /// </summary>
    public unsafe virtual void RemoveBank(BmSDK.Engine.AkBank wwise_bank)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveBank, "BmGame.RGFxMovie.RemoveBank");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(wwise_bank, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushBank;
    /// <summary>
    /// Function: PushBank
    /// </summary>
    public unsafe virtual void PushBank(BmSDK.Engine.AkBank wwise_bank)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushBank, "BmGame.RGFxMovie.PushBank");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(wwise_bank, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBankIndex;
    /// <summary>
    /// Function: GetBankIndex
    /// </summary>
    public unsafe virtual int GetBankIndex(BmSDK.Engine.AkBank wwise_bank)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBankIndex, "BmGame.RGFxMovie.GetBankIndex");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(wwise_bank, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_XI_SetToolTip;
    /// <summary>
    /// Function: XI_SetToolTip
    /// </summary>
    public unsafe virtual void XI_SetToolTip(BmSDK.FString Text, BmSDK.FString Option = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetToolTip, "BmGame.RGFxMovie.XI_SetToolTip");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Option, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_LayoutPrompts;
    /// <summary>
    /// Function: XI_LayoutPrompts
    /// </summary>
    public unsafe virtual void XI_LayoutPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_LayoutPrompts, "BmGame.RGFxMovie.XI_LayoutPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_SetPrompt;
    /// <summary>
    /// Function: XI_SetPrompt
    /// </summary>
    public unsafe virtual void XI_SetPrompt(int PromptId, BmSDK.FString PromptTag, float Alpha)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetPrompt, "BmGame.RGFxMovie.XI_SetPrompt");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptTag, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ClearPrompts;
    /// <summary>
    /// Function: XI_ClearPrompts
    /// </summary>
    public unsafe virtual void XI_ClearPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ClearPrompts, "BmGame.RGFxMovie.XI_ClearPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetPromptStr2;
    /// <summary>
    /// Function: XI_GetPromptStr2
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetPromptStr2(int Id, bool bAsPad)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetPromptStr2, "BmGame.RGFxMovie.XI_GetPromptStr2");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAsPad, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_XI_GetPromptStr;
    /// <summary>
    /// Function: XI_GetPromptStr
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetPromptStr(int Id, bool bAsPad)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetPromptStr, "BmGame.RGFxMovie.XI_GetPromptStr");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAsPad, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_LookupLocTags;
    /// <summary>
    /// Function: LookupLocTags
    /// </summary>
    public unsafe virtual void LookupLocTags(BmSDK.FString BaseStr, out BmSDK.FString PadStr, out BmSDK.FString KeyStr)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookupLocTags, "BmGame.RGFxMovie.LookupLocTags");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseStr, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PadStr = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
        KeyStr = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 32);
        return;
    }

    private static BmSDK.Function __fn_LookupLocTag;
    /// <summary>
    /// Function: LookupLocTag
    /// </summary>
    public unsafe virtual BmSDK.FString LookupLocTag(BmSDK.FString BaseStr, bool bAsPad, bool bNoExpand = default, bool bIsKey2 = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookupLocTag, "BmGame.RGFxMovie.LookupLocTag");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAsPad, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoExpand, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsKey2, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_IsCircleToAccept;
    /// <summary>
    /// Function: IsCircleToAccept
    /// </summary>
    public unsafe virtual bool IsCircleToAccept()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCircleToAccept, "BmGame.RGFxMovie.IsCircleToAccept");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_xGetGlobalFlag;
    /// <summary>
    /// Function: xGetGlobalFlag
    /// </summary>
    public unsafe virtual int xGetGlobalFlag(BmSDK.FString FlagName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_xGetGlobalFlag, "BmGame.RGFxMovie.xGetGlobalFlag");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_xSetGlobalFlag;
    /// <summary>
    /// Function: xSetGlobalFlag
    /// </summary>
    public unsafe virtual void xSetGlobalFlag(BmSDK.FString FlagName, bool bValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_xSetGlobalFlag, "BmGame.RGFxMovie.xSetGlobalFlag");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bValue, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPS3_480i;
    /// <summary>
    /// Function: IsPS3_480i
    /// </summary>
    public unsafe virtual bool IsPS3_480i()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPS3_480i, "BmGame.RGFxMovie.IsPS3_480i");
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

    private static BmSDK.Function __fn_IsPS3_4x3;
    /// <summary>
    /// Function: IsPS3_4x3
    /// </summary>
    public unsafe virtual bool IsPS3_4x3()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPS3_4x3, "BmGame.RGFxMovie.IsPS3_4x3");
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

    private static BmSDK.Function __fn_SetAudioSuppressed;
    /// <summary>
    /// Function: SetAudioSuppressed
    /// </summary>
    public unsafe virtual void SetAudioSuppressed(bool should_suppress)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioSuppressed, "BmGame.RGFxMovie.SetAudioSuppressed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(should_suppress, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLanguageExt;
    /// <summary>
    /// Function: GetLanguageExt
    /// </summary>
    public unsafe virtual BmSDK.FString GetLanguageExt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLanguageExt, "BmGame.RGFxMovie.GetLanguageExt");
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

    private static BmSDK.Function __fn_IsPointerValid;
    /// <summary>
    /// Function: IsPointerValid
    /// </summary>
    public unsafe virtual bool IsPointerValid()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPointerValid, "BmGame.RGFxMovie.IsPointerValid");
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

    private static BmSDK.Function __fn_SetAudioState;
    /// <summary>
    /// Function: SetAudioState
    /// </summary>
    public unsafe virtual void SetAudioState(BmSDK.FString StateName, BmSDK.FString StateValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioState, "BmGame.RGFxMovie.SetAudioState");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateValue, paramsPtr + 16);
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

    private static BmSDK.Function __fn_SetAudioParameter;
    /// <summary>
    /// Function: SetAudioParameter
    /// </summary>
    public unsafe virtual void SetAudioParameter(BmSDK.FString ParamName, float ParamValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioParameter, "BmGame.RGFxMovie.SetAudioParameter");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 16);
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

    private static BmSDK.Function __fn_KillEventInstance;
    /// <summary>
    /// Function: KillEventInstance
    /// </summary>
    public unsafe virtual void KillEventInstance(int InstanceID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillEventInstance, "BmGame.RGFxMovie.KillEventInstance");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstanceID, paramsPtr + 0);
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

    private static BmSDK.Function __fn_TriggerAudioEventsQueue;
    /// <summary>
    /// Function: TriggerAudioEventsQueue
    /// </summary>
    public unsafe virtual void TriggerAudioEventsQueue(int ChannelID, BmSDK.FString Source_Event_Thing__PipeSeparated, int NumEvents)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAudioEventsQueue, "BmGame.RGFxMovie.TriggerAudioEventsQueue");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChannelID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Source_Event_Thing__PipeSeparated, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumEvents, paramsPtr + 20);
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

    private static BmSDK.Function __fn_TriggerAudioEvent;
    /// <summary>
    /// Function: TriggerAudioEvent
    /// </summary>
    public unsafe virtual void TriggerAudioEvent(int ChannelID, BmSDK.FString Source, BmSDK.FString Event, BmSDK.FString Thing)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAudioEvent, "BmGame.RGFxMovie.TriggerAudioEvent");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChannelID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Source, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thing, paramsPtr + 36);
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

    private static BmSDK.Function __fn_LocalisedExists;
    /// <summary>
    /// Function: LocalisedExists
    /// </summary>
    public unsafe virtual bool LocalisedExists(BmSDK.FString Str)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LocalisedExists, "BmGame.RGFxMovie.LocalisedExists");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Str, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_LocaliseCaps;
    /// <summary>
    /// Function: LocaliseCaps
    /// </summary>
    public unsafe virtual BmSDK.FString LocaliseCaps(BmSDK.FString Str)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LocaliseCaps, "BmGame.RGFxMovie.LocaliseCaps");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Str, paramsPtr + 0);
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

    private static BmSDK.Function __fn_Localise;
    /// <summary>
    /// Function: Localise
    /// </summary>
    public unsafe virtual BmSDK.FString Localise(BmSDK.FString Str)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Localise, "BmGame.RGFxMovie.Localise");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Str, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UC_TriggerPromptClicked;
    /// <summary>
    /// Function: UC_TriggerPromptClicked
    /// </summary>
    public unsafe virtual void UC_TriggerPromptClicked(int PromptId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_TriggerPromptClicked, "BmGame.RGFxMovie.UC_TriggerPromptClicked");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHudVisibility;
    /// <summary>
    /// Function: UpdateHudVisibility
    /// </summary>
    public unsafe virtual void UpdateHudVisibility(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHudVisibility, "BmGame.RGFxMovie.UpdateHudVisibility");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGenericErrorOpen;
    /// <summary>
    /// Function: IsGenericErrorOpen
    /// </summary>
    public unsafe virtual bool IsGenericErrorOpen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGenericErrorOpen, "BmGame.RGFxMovie.IsGenericErrorOpen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnFadeCompleted_Callback;
    /// <summary>
    /// Function: OnFadeCompleted_Callback
    /// </summary>
    public unsafe virtual void OnFadeCompleted_Callback()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFadeCompleted_Callback, "BmGame.RGFxMovie.OnFadeCompleted_Callback");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe virtual void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmGame.RGFxMovie.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenPopupMessage4;
    /// <summary>
    /// Function: OpenPopupMessage4
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGFxMoviePopupRequester OpenPopupMessage4(BmSDK.FString Prompt1, BmSDK.FString Prompt2, BmSDK.FString Prompt3, BmSDK.FString Prompt4, BmSDK.FString Message, int DefaultSelected = default, bool bAllowBack = default, BmSDK.GFxUI.SwfMovie iMovie = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenPopupMessage4, "BmGame.RGFxMovie.OpenPopupMessage4");
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt3, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt4, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultSelected, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowBack, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iMovie, paramsPtr + 88);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_OpenPopupMessage3;
    /// <summary>
    /// Function: OpenPopupMessage3
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGFxMoviePopupRequester OpenPopupMessage3(BmSDK.FString Prompt1, BmSDK.FString Prompt2, BmSDK.FString Prompt3, BmSDK.FString Message, int DefaultSelected = default, bool bAllowBack = default, BmSDK.GFxUI.SwfMovie iMovie = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenPopupMessage3, "BmGame.RGFxMovie.OpenPopupMessage3");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt3, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultSelected, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowBack, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iMovie, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(paramsPtr + 80);
    }

    private static BmSDK.Function __fn_OpenPopupMessage2;
    /// <summary>
    /// Function: OpenPopupMessage2
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGFxMoviePopupRequester OpenPopupMessage2(BmSDK.FString Prompt1, BmSDK.FString Prompt2, BmSDK.FString Message, int DefaultSelected = default, bool bAllowBack = default, BmSDK.GFxUI.SwfMovie iMovie = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenPopupMessage2, "BmGame.RGFxMovie.OpenPopupMessage2");
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultSelected, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowBack, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iMovie, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_OpenPopupMessage1;
    /// <summary>
    /// Function: OpenPopupMessage1
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGFxMoviePopupRequester OpenPopupMessage1(BmSDK.FString Prompt1, BmSDK.FString Message, bool bAllowBack = default, BmSDK.GFxUI.SwfMovie iMovie = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenPopupMessage1, "BmGame.RGFxMovie.OpenPopupMessage1");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowBack, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iMovie, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_OnAspectRatioChanged;
    /// <summary>
    /// Function: OnAspectRatioChanged
    /// </summary>
    public unsafe override void OnAspectRatioChanged(float aspect_ratio)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAspectRatioChanged, "BmGame.RGFxMovie.OnAspectRatioChanged");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aspect_ratio, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_GetUsingGamepad;
    /// <summary>
    /// Function: XI_GetUsingGamepad
    /// </summary>
    public unsafe virtual bool XI_GetUsingGamepad()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetUsingGamepad, "BmGame.RGFxMovie.XI_GetUsingGamepad");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAspectRatioAuto;
    /// <summary>
    /// Function: SetAspectRatioAuto
    /// </summary>
    public unsafe virtual void SetAspectRatioAuto()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAspectRatioAuto, "BmGame.RGFxMovie.SetAspectRatioAuto");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KismetEvent;
    /// <summary>
    /// Function: KismetEvent
    /// </summary>
    public unsafe virtual void KismetEvent(BmSDK.FString EventName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetEvent, "BmGame.RGFxMovie.KismetEvent");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTheClassName;
    /// <summary>
    /// Function: GetTheClassName
    /// </summary>
    public unsafe virtual BmSDK.FString GetTheClassName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTheClassName, "BmGame.RGFxMovie.GetTheClassName");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGameStatus;
    /// <summary>
    /// Function: GetGameStatus
    /// </summary>
    public unsafe virtual int GetGameStatus()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameStatus, "BmGame.RGFxMovie.GetGameStatus");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetGameStatus;
    /// <summary>
    /// Function: SetGameStatus
    /// </summary>
    public unsafe virtual void SetGameStatus(BmSDK.BmGame.RGameRI.EGameStatus Status)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGameStatus, "BmGame.RGFxMovie.SetGameStatus");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Status, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ReturnToChallengeMenu;
    /// <summary>
    /// Function: XI_ReturnToChallengeMenu
    /// </summary>
    public unsafe virtual void XI_ReturnToChallengeMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ReturnToChallengeMenu, "BmGame.RGFxMovie.XI_ReturnToChallengeMenu");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_IsFrontEndChallenge;
    /// <summary>
    /// Function: XI_IsFrontEndChallenge
    /// </summary>
    public unsafe virtual bool XI_IsFrontEndChallenge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_IsFrontEndChallenge, "BmGame.RGFxMovie.XI_IsFrontEndChallenge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlatformTag;
    /// <summary>
    /// Function: GetPlatformTag
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlatformTag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlatformTag, "BmGame.RGFxMovie.GetPlatformTag");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlatformStr;
    /// <summary>
    /// Function: GetPlatformStr
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlatformStr()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlatformStr, "BmGame.RGFxMovie.GetPlatformStr");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_XI_IsDemo;
    /// <summary>
    /// Function: XI_IsDemo
    /// </summary>
    public unsafe virtual bool XI_IsDemo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_IsDemo, "BmGame.RGFxMovie.XI_IsDemo");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGRI;
    /// <summary>
    /// Function: GetGRI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameRI GetGRI()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGRI, "BmGame.RGFxMovie.GetGRI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRGI;
    /// <summary>
    /// Function: GetRGI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo GetRGI()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRGI, "BmGame.RGFxMovie.GetRGI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWI;
    /// <summary>
    /// Function: GetWI
    /// </summary>
    public unsafe virtual BmSDK.Engine.WorldInfo GetWI()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWI, "BmGame.RGFxMovie.GetWI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnMWLeaderboardRead;
    /// <summary>
    /// Function: OnMWLeaderboardRead
    /// </summary>
    public unsafe virtual void OnMWLeaderboardRead(bool bWasSuccessful, BmSDK.BmGame.ROnlineStatsReadMostWanted MWStats)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMWLeaderboardRead, "BmGame.RGFxMovie.OnMWLeaderboardRead");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MWStats, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendLeaderBoardToFlash;
    /// <summary>
    /// Function: SendLeaderBoardToFlash
    /// </summary>
    public unsafe virtual void SendLeaderBoardToFlash(int Id, int total, BmSDK.TArray<int> FriendIndex, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> NetIDs, BmSDK.TArray<int> Ranks, BmSDK.TArray<BmSDK.FString> NickNames, BmSDK.TArray<int> Stars, BmSDK.TArray<float> Scores, BmSDK.TArray<int> RivalPoints, BmSDK.TArray<float> Story, BmSDK.TArray<float> MW, BmSDK.TArray<float> AR)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendLeaderBoardToFlash, "BmGame.RGFxMovie.SendLeaderBoardToFlash");
        byte* paramsPtr = stackalloc byte[168];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(total, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetIDs, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ranks, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NickNames, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stars, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scores, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RivalPoints, paramsPtr + 104);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Story, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MW, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AR, paramsPtr + 152);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovie.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPC;
    /// <summary>
    /// Function: GetPC
    /// </summary>
    public unsafe override BmSDK.Engine.PlayerController GetPC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPC, "BmGame.RGFxMovie.GetPC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLP;
    /// <summary>
    /// Function: GetLP
    /// </summary>
    public unsafe override BmSDK.Engine.LocalPlayer GetLP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLP, "BmGame.RGFxMovie.GetLP");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LocalPlayer>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ObjectProperty: CurrentStreamedPicture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D CurrentStreamedPicture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ArrayProperty: WwiseBanks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkBank> WwiseBanks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkBank>>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ArrayProperty: VoiceRecList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> VoiceRecList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ArrayProperty: AS_LoaderPackage_SF
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> AS_LoaderPackage_SF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ArrayProperty: AS_LoaderCallback_SF
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> AS_LoaderCallback_SF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// StrProperty: CurrentPackageBaseName
    /// </summary>
    public unsafe BmSDK.FString CurrentPackageBaseName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// StrProperty: CurrentStreamedName
    /// </summary>
    public unsafe BmSDK.FString CurrentStreamedName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// IntProperty: iSplitscreenIndex
    /// </summary>
    public unsafe int iSplitscreenIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// BoolProperty: bHUDVisibleLast
    /// </summary>
    public unsafe bool bHUDVisibleLast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bVisibleFirstSet
    /// </summary>
    public unsafe bool bVisibleFirstSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bMovieAudioSuppressed
    /// </summary>
    public unsafe bool bMovieAudioSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bStorageErrorSuppressed
    /// </summary>
    public unsafe bool bStorageErrorSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bHandleLossDelegates
    /// </summary>
    public unsafe bool bHandleLossDelegates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: ReturnToChallengeMenu
    /// </summary>
    public unsafe bool ReturnToChallengeMenu
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// FloatProperty: fTimeOfLastManualAdvance
    /// </summary>
    public unsafe float fTimeOfLastManualAdvance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: fMaximumManualAdvanceTime
    /// </summary>
    public unsafe float fMaximumManualAdvanceTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: CurrentAspectRatio
    /// </summary>
    public unsafe float CurrentAspectRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// Enum: FlashAudioChannel
    /// </summary>
    public enum FlashAudioChannel : byte
    {
        FLASH_AUDIO_CHANNEL_UI = 0,
        FLASH_AUDIO_CHANNEL_HUD = 1,
        FLASH_AUDIO_CHANNEL_MAX = 2,
    }

    /// <summary>
    /// Enum: KeyMapping
    /// </summary>
    public enum KeyMapping : byte
    {
        KeyMapping_None = 0,
        KeyMapping_START = 1,
        KeyMapping_BACK = 2,
        KeyMapping_A = 3,
        KeyMapping_B = 4,
        KeyMapping_X = 5,
        KeyMapping_Y = 6,
        KeyMapping_LB = 7,
        KeyMapping_LT = 8,
        KeyMapping_LTHUMB = 9,
        KeyMapping_RB = 10,
        KeyMapping_RT = 11,
        KeyMapping_RTHUMB = 12,
        KeyMapping_LEFT = 13,
        KeyMapping_RIGHT = 14,
        KeyMapping_UP = 15,
        KeyMapping_DOWN = 16,
        KeyMapping_L_LEFT = 17,
        KeyMapping_L_RIGHT = 18,
        KeyMapping_L_UP = 19,
        KeyMapping_L_DOWN = 20,
        KeyMapping_R_LEFT = 21,
        KeyMapping_R_RIGHT = 22,
        KeyMapping_R_UP = 23,
        KeyMapping_R_DOWN = 24,
        KeyMapping_MAX = 25,
    }
}
