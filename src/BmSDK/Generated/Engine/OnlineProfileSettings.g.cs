#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineProfileSettings<br/>
/// (size = 184)
/// (flags = 134217906)
/// </summary>
public partial class OnlineProfileSettings : BmSDK.Engine.OnlinePlayerStorage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineProfileSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as OnlineProfileSettings.
    /// </summary>
    public static OnlineProfileSettings DefaultObject => (OnlineProfileSettings)StaticClass().DefaultObject;

    internal OnlineProfileSettings() { }

    /// <summary>
    /// Constructs a new OnlineProfileSettings
    /// </summary>
    public OnlineProfileSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineProfileSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineProfileSettings(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineProfileSettings>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineProfileSettings>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineProfileSettings>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineProfileSettings>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineProfileSettings>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineProfileSettings>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineProfileSettings>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineProfileSettings>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ModifyAvailableProfileSettings;
    /// <summary>
    /// Function: ModifyAvailableProfileSettings
    /// </summary>
    public unsafe virtual void ModifyAvailableProfileSettings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyAvailableProfileSettings, "Engine.OnlineProfileSettings.ModifyAvailableProfileSettings");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AppendVersionToReadIds;
    /// <summary>
    /// Function: AppendVersionToReadIds
    /// </summary>
    public unsafe virtual void AppendVersionToReadIds()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendVersionToReadIds, "Engine.OnlineProfileSettings.AppendVersionToReadIds");
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

    private static BmSDK.Function __fn_SetToDefaults;
    /// <summary>
    /// Function: SetToDefaults
    /// </summary>
    public unsafe override void SetToDefaults()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetToDefaults, "Engine.OnlineProfileSettings.SetToDefaults");
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

    private static BmSDK.Function __fn_GetProfileSettingDefaultFloat;
    /// <summary>
    /// Function: GetProfileSettingDefaultFloat
    /// </summary>
    public unsafe virtual bool GetProfileSettingDefaultFloat(int ProfileSettingId, out float DefaultFloat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingDefaultFloat, "Engine.OnlineProfileSettings.GetProfileSettingDefaultFloat");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DefaultFloat);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultFloat, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DefaultFloat = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetProfileSettingDefaultInt;
    /// <summary>
    /// Function: GetProfileSettingDefaultInt
    /// </summary>
    public unsafe virtual bool GetProfileSettingDefaultInt(int ProfileSettingId, out int DefaultInt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingDefaultInt, "Engine.OnlineProfileSettings.GetProfileSettingDefaultInt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DefaultInt);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultInt, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DefaultInt = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetProfileSettingDefaultId;
    /// <summary>
    /// Function: GetProfileSettingDefaultId
    /// </summary>
    public unsafe virtual bool GetProfileSettingDefaultId(int ProfileSettingId, out int DefaultId, out int ListIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingDefaultId, "Engine.OnlineProfileSettings.GetProfileSettingDefaultId");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DefaultId);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultId, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ListIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListIndex, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DefaultId = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        ListIndex = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Enum: EProfileVoiceThruSpeakersOptions
    /// </summary>
    public enum EProfileVoiceThruSpeakersOptions : byte
    {
        PVTSO_Off = 0,
        PVTSO_On = 1,
        PVTSO_Both = 2,
        PVTSO_MAX = 3,
    }

    /// <summary>
    /// Enum: EProfileControllerVibrationToggleOptions
    /// </summary>
    public enum EProfileControllerVibrationToggleOptions : byte
    {
        PCVTO_Off = 0,
        PCVTO_IgnoreThis = 1,
        PCVTO_IgnoreThis2 = 2,
        PCVTO_On = 3,
        PCVTO_MAX = 4,
    }

    /// <summary>
    /// Enum: EProfileOmniDirEvadeOptions
    /// </summary>
    public enum EProfileOmniDirEvadeOptions : byte
    {
        PODI_Off = 0,
        PODI_On = 1,
        PODI_MAX = 2,
    }

    /// <summary>
    /// Enum: EProfileXInversionOptions
    /// </summary>
    public enum EProfileXInversionOptions : byte
    {
        PXIO_Off = 0,
        PXIO_On = 1,
        PXIO_MAX = 2,
    }

    /// <summary>
    /// Enum: EProfileYInversionOptions
    /// </summary>
    public enum EProfileYInversionOptions : byte
    {
        PYIO_Off = 0,
        PYIO_On = 1,
        PYIO_MAX = 2,
    }

    /// <summary>
    /// Enum: EProfileRaceAcceleratorControlOptions
    /// </summary>
    public enum EProfileRaceAcceleratorControlOptions : byte
    {
        PRACO_Trigger = 0,
        PRACO_Button = 1,
        PRACO_MAX = 2,
    }

    /// <summary>
    /// Enum: EProfileRaceBrakeControlOptions
    /// </summary>
    public enum EProfileRaceBrakeControlOptions : byte
    {
        PRBCO_Trigger = 0,
        PRBCO_Button = 1,
        PRBCO_MAX = 2,
    }

    /// <summary>
    /// Enum: EProfileRaceCameraLocationOptions
    /// </summary>
    public enum EProfileRaceCameraLocationOptions : byte
    {
        PRCLO_Behind = 0,
        PRCLO_Front = 1,
        PRCLO_Inside = 2,
        PRCLO_MAX = 3,
    }

    /// <summary>
    /// Enum: EProfileRaceTransmissionOptions
    /// </summary>
    public enum EProfileRaceTransmissionOptions : byte
    {
        PRTO_Auto = 0,
        PRTO_Manual = 1,
        PRTO_MAX = 2,
    }

    /// <summary>
    /// Enum: EProfileMovementControlOptions
    /// </summary>
    public enum EProfileMovementControlOptions : byte
    {
        PMCO_L_Thumbstick = 0,
        PMCO_R_Thumbstick = 1,
        PMCO_MAX = 2,
    }

    /// <summary>
    /// Enum: EProfileAutoCenterOptions
    /// </summary>
    public enum EProfileAutoCenterOptions : byte
    {
        PACO_Off = 0,
        PACO_On = 1,
        PACO_MAX = 2,
    }

    /// <summary>
    /// Enum: EProfileAutoAimOptions
    /// </summary>
    public enum EProfileAutoAimOptions : byte
    {
        PAAO_Off = 0,
        PAAO_On = 1,
        PAAO_MAX = 2,
    }

    /// <summary>
    /// Enum: EProfilePreferredColorOptions
    /// </summary>
    public enum EProfilePreferredColorOptions : byte
    {
        PPCO_None = 0,
        PPCO_Black = 1,
        PPCO_White = 2,
        PPCO_Yellow = 3,
        PPCO_Orange = 4,
        PPCO_Pink = 5,
        PPCO_Red = 6,
        PPCO_Purple = 7,
        PPCO_Blue = 8,
        PPCO_Green = 9,
        PPCO_Brown = 10,
        PPCO_Silver = 11,
        PPCO_MAX = 12,
    }

    /// <summary>
    /// Enum: EProfileControllerSensitivityOptions
    /// </summary>
    public enum EProfileControllerSensitivityOptions : byte
    {
        PCSO_Medium = 0,
        PCSO_Low = 1,
        PCSO_High = 2,
        PCSO_MAX = 3,
    }

    /// <summary>
    /// Enum: EProfileDifficultyOptions
    /// </summary>
    public enum EProfileDifficultyOptions : byte
    {
        PDO_Normal = 0,
        PDO_Easy = 1,
        PDO_Hard = 2,
        PDO_MAX = 3,
    }

    /// <summary>
    /// ArrayProperty: ProfileSettingIds
    /// </summary>
    public unsafe BmSDK.TArray<int> ProfileSettingIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ArrayProperty: DefaultSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlinePlayerStorage.FOnlineProfileSetting> DefaultSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlinePlayerStorage.FOnlineProfileSetting>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ArrayProperty: OwnerMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Settings.FIdToStringMapping> OwnerMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FIdToStringMapping>>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// Enum: EProfileSettingID
    /// </summary>
    public enum EProfileSettingID : byte
    {
        PSI_Unknown = 0,
        PSI_ControllerVibration = 1,
        PSI_YInversion = 2,
        PSI_GamerCred = 3,
        PSI_GamerRep = 4,
        PSI_VoiceMuted = 5,
        PSI_VoiceThruSpeakers = 6,
        PSI_VoiceVolume = 7,
        PSI_GamerPictureKey = 8,
        PSI_GamerMotto = 9,
        PSI_GamerTitlesPlayed = 10,
        PSI_GamerAchievementsEarned = 11,
        PSI_GameDifficulty = 12,
        PSI_ControllerSensitivity = 13,
        PSI_PreferredColor1 = 14,
        PSI_PreferredColor2 = 15,
        PSI_AutoAim = 16,
        PSI_AutoCenter = 17,
        PSI_MovementControl = 18,
        PSI_RaceTransmission = 19,
        PSI_RaceCameraLocation = 20,
        PSI_RaceBrakeControl = 21,
        PSI_RaceAcceleratorControl = 22,
        PSI_GameCredEarned = 23,
        PSI_GameAchievementsEarned = 24,
        PSI_EndLiveIds = 25,
        PSI_ProfileVersionNum = 26,
        PSI_ProfileSaveCount = 27,
        PSI_MAX = 28,
    }
}
