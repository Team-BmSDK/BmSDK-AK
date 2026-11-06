#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RSeqAct_AugmentedForensicsBase<br/>
/// (size = 408)
/// (flags = 134226067)
/// </summary>
public partial class RSeqAct_AugmentedForensicsBase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_AugmentedForensicsBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSeqAct_AugmentedForensicsBase.
    /// </summary>
    public static RSeqAct_AugmentedForensicsBase DefaultObject => (RSeqAct_AugmentedForensicsBase)StaticClass().DefaultObject;

    internal RSeqAct_AugmentedForensicsBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_AugmentedForensicsBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_AugmentedForensicsBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_AugmentedForensicsBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_AugmentedForensicsBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_AugmentedForensicsBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_AugmentedForensicsBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_AugmentedForensicsBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_AugmentedForensicsBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_AugmentedForensicsBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmGame.RSeqAct_AugmentedForensicsBase.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ChangeIntoOrOutOfScanMode;
    /// <summary>
    /// Function: ChangeIntoOrOutOfScanMode
    /// </summary>
    public unsafe virtual void ChangeIntoOrOutOfScanMode(bool bInScanMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeIntoOrOutOfScanMode, "BmGame.RSeqAct_AugmentedForensicsBase.ChangeIntoOrOutOfScanMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInScanMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoFillTimelineWhenScannerModeEntered;
    /// <summary>
    /// Function: AutoFillTimelineWhenScannerModeEntered
    /// </summary>
    public unsafe virtual void AutoFillTimelineWhenScannerModeEntered()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoFillTimelineWhenScannerModeEntered, "BmGame.RSeqAct_AugmentedForensicsBase.AutoFillTimelineWhenScannerModeEntered");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendCursorToFlash;
    /// <summary>
    /// Function: SendCursorToFlash
    /// </summary>
    public unsafe virtual void SendCursorToFlash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendCursorToFlash, "BmGame.RSeqAct_AugmentedForensicsBase.SendCursorToFlash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FillTimelineWithDirectorTrack;
    /// <summary>
    /// Function: FillTimelineWithDirectorTrack
    /// </summary>
    public unsafe virtual void FillTimelineWithDirectorTrack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FillTimelineWithDirectorTrack, "BmGame.RSeqAct_AugmentedForensicsBase.FillTimelineWithDirectorTrack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendTimelineToFlash;
    /// <summary>
    /// Function: SendTimelineToFlash
    /// </summary>
    public unsafe virtual void SendTimelineToFlash(BmSDK.FString timeline_anim, float director_start_prop)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendTimelineToFlash, "BmGame.RSeqAct_AugmentedForensicsBase.SendTimelineToFlash");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeline_anim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(director_start_prop, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideReconstructionRate;
    /// <summary>
    /// Function: OverrideReconstructionRate
    /// </summary>
    public unsafe virtual void OverrideReconstructionRate(float recon_rate)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideReconstructionRate, "BmGame.RSeqAct_AugmentedForensicsBase.OverrideReconstructionRate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(recon_rate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeToPlaybackDirectorTrack;
    /// <summary>
    /// Function: ChangeToPlaybackDirectorTrack
    /// </summary>
    public unsafe virtual void ChangeToPlaybackDirectorTrack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeToPlaybackDirectorTrack, "BmGame.RSeqAct_AugmentedForensicsBase.ChangeToPlaybackDirectorTrack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDirectorAndSlomo;
    /// <summary>
    /// Function: SetDirectorAndSlomo
    /// </summary>
    public unsafe virtual void SetDirectorAndSlomo(int director_index, int slomo_index, int playback_director_index = default, int playback_slomo_index = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDirectorAndSlomo, "BmGame.RSeqAct_AugmentedForensicsBase.SetDirectorAndSlomo");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(director_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(slomo_index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playback_director_index, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playback_slomo_index, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoPlayBack;
    /// <summary>
    /// Function: AutoPlayBack
    /// </summary>
    public unsafe virtual void AutoPlayBack(float start_time, float end_time, float reconstruction_end_time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoPlayBack, "BmGame.RSeqAct_AugmentedForensicsBase.AutoPlayBack");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(start_time, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(end_time, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(reconstruction_end_time, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScrubbingDirectionAudio;
    /// <summary>
    /// Function: SetScrubbingDirectionAudio
    /// </summary>
    public unsafe virtual void SetScrubbingDirectionAudio(int NewScrubbingAudioDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScrubbingDirectionAudio, "BmGame.RSeqAct_AugmentedForensicsBase.SetScrubbingDirectionAudio");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScrubbingAudioDirection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTimeProportion;
    /// <summary>
    /// Function: SetTimeProportion
    /// </summary>
    public unsafe virtual void SetTimeProportion(float Proportion)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTimeProportion, "BmGame.RSeqAct_AugmentedForensicsBase.SetTimeProportion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMatineeTime;
    /// <summary>
    /// Function: SetMatineeTime
    /// </summary>
    public unsafe virtual void SetMatineeTime(float new_time)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMatineeTime, "BmGame.RSeqAct_AugmentedForensicsBase.SetMatineeTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMatineePlaypack;
    /// <summary>
    /// Function: SetMatineePlaypack
    /// </summary>
    public unsafe virtual void SetMatineePlaypack(float playback_speed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMatineePlaypack, "BmGame.RSeqAct_AugmentedForensicsBase.SetMatineePlaypack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playback_speed, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetActorHidden;
    /// <summary>
    /// Function: SetActorHidden
    /// </summary>
    public unsafe virtual void SetActorHidden(BmSDK.Engine.Actor the_actor, bool is_hidden)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActorHidden, "BmGame.RSeqAct_AugmentedForensicsBase.SetActorHidden");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_hidden, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetDirectorAndSloMoGroup;
    /// <summary>
    /// Function: SetDirectorAndSloMoGroup
    /// </summary>
    public unsafe virtual void SetDirectorAndSloMoGroup(int director_index, int slomo_index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDirectorAndSloMoGroup, "BmGame.RSeqAct_AugmentedForensicsBase.SetDirectorAndSloMoGroup");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(director_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(slomo_index, paramsPtr + 4);
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

    private static BmSDK.Function __fn_InitialiseMatinee;
    /// <summary>
    /// Function: InitialiseMatinee
    /// </summary>
    public unsafe virtual void InitialiseMatinee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseMatinee, "BmGame.RSeqAct_AugmentedForensicsBase.InitialiseMatinee");
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

    /// <summary>
    /// ObjectProperty: LinkedMatinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp LinkedMatinee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: DirectorTrackStart
    /// </summary>
    public unsafe float DirectorTrackStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// FloatProperty: DirectorTrackRange
    /// </summary>
    public unsafe float DirectorTrackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// IntProperty: AlternateDirectorTrackForPlayback
    /// </summary>
    public unsafe int AlternateDirectorTrackForPlayback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// IntProperty: AlternateSlomoTrackForPlayback
    /// </summary>
    public unsafe int AlternateSlomoTrackForPlayback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// BoolProperty: bIsAutoPlay
    /// </summary>
    public unsafe bool bIsAutoPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: TimelineVisible
    /// </summary>
    public unsafe bool TimelineVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: TellPlayerToScrub
    /// </summary>
    public unsafe bool TellPlayerToScrub
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// FloatProperty: TruncatedInterpLength
    /// </summary>
    public unsafe float TruncatedInterpLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
}
