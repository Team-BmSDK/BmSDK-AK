#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleBatmobile<br/>
/// (size = 660)
/// (flags = 18)
/// </summary>
public partial class RHudModuleBatmobile : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleBatmobile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudModuleBatmobile.
    /// </summary>
    public static RHudModuleBatmobile DefaultObject => (RHudModuleBatmobile)StaticClass().DefaultObject;

    internal RHudModuleBatmobile() { }

    /// <summary>
    /// Constructs a new RHudModuleBatmobile
    /// </summary>
    public RHudModuleBatmobile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleBatmobile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleBatmobile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleBatmobile>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBatmobile>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleBatmobile>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBatmobile>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBatmobile>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBatmobile>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleBatmobile>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleBatmobile>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetBatmobileEnergyTutorialLevel;
    /// <summary>
    /// Function: SetBatmobileEnergyTutorialLevel
    /// </summary>
    public unsafe virtual void SetBatmobileEnergyTutorialLevel(int tutorial_level)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmobileEnergyTutorialLevel, "BmGame.RHudModuleBatmobile.SetBatmobileEnergyTutorialLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(tutorial_level, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBattleModeOpacity;
    /// <summary>
    /// Function: SetBattleModeOpacity
    /// </summary>
    public unsafe virtual void SetBattleModeOpacity(float the_opacity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBattleModeOpacity, "BmGame.RHudModuleBatmobile.SetBattleModeOpacity");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_opacity, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWeaponFeedbackPrivate;
    /// <summary>
    /// Function: SetWeaponFeedbackPrivate
    /// </summary>
    public unsafe virtual void SetWeaponFeedbackPrivate(bool FeedbackActive, bool FeedbackEffective)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWeaponFeedbackPrivate, "BmGame.RHudModuleBatmobile.SetWeaponFeedbackPrivate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FeedbackActive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FeedbackEffective, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBattleAndZoomModePrivate;
    /// <summary>
    /// Function: SetBattleAndZoomModePrivate
    /// </summary>
    public unsafe virtual void SetBattleAndZoomModePrivate(bool IsBattleMode, bool IsZoomed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBattleAndZoomModePrivate, "BmGame.RHudModuleBatmobile.SetBattleAndZoomModePrivate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsBattleMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsZoomed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSpecialWeaponValuesPrivate;
    /// <summary>
    /// Function: SetSpecialWeaponValuesPrivate
    /// </summary>
    public unsafe virtual void SetSpecialWeaponValuesPrivate(int Weapon1Value, int Weapon2Value, int Weapon3Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpecialWeaponValuesPrivate, "BmGame.RHudModuleBatmobile.SetSpecialWeaponValuesPrivate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon1Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon2Value, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon3Value, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCannonCooldownPrivate;
    /// <summary>
    /// Function: SetCannonCooldownPrivate
    /// </summary>
    public unsafe virtual void SetCannonCooldownPrivate(int CannonCooldown)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCannonCooldownPrivate, "BmGame.RHudModuleBatmobile.SetCannonCooldownPrivate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CannonCooldown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrimaryWeaponPrivate;
    /// <summary>
    /// Function: SetPrimaryWeaponPrivate
    /// </summary>
    public unsafe virtual void SetPrimaryWeaponPrivate(BmSDK.FString WeaponType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrimaryWeaponPrivate, "BmGame.RHudModuleBatmobile.SetPrimaryWeaponPrivate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlushPending;
    /// <summary>
    /// Function: FlushPending
    /// </summary>
    public unsafe virtual void FlushPending(float DeltaT)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushPending, "BmGame.RHudModuleBatmobile.FlushPending");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaT, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWeaponFeedback;
    /// <summary>
    /// Function: SetWeaponFeedback
    /// </summary>
    public unsafe virtual void SetWeaponFeedback(bool FeedbackActive, bool FeedbackEffective)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWeaponFeedback, "BmGame.RHudModuleBatmobile.SetWeaponFeedback");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FeedbackActive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FeedbackEffective, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBattleAndZoomModeSemiPrivate;
    /// <summary>
    /// Function: SetBattleAndZoomModeSemiPrivate
    /// </summary>
    public unsafe virtual void SetBattleAndZoomModeSemiPrivate(bool IsBattleMode, bool IsZoomed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBattleAndZoomModeSemiPrivate, "BmGame.RHudModuleBatmobile.SetBattleAndZoomModeSemiPrivate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsBattleMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsZoomed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSpecialWeaponValues;
    /// <summary>
    /// Function: SetSpecialWeaponValues
    /// </summary>
    public unsafe virtual void SetSpecialWeaponValues(int Weapon1Value, int Weapon2Value, int Weapon3Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpecialWeaponValues, "BmGame.RHudModuleBatmobile.SetSpecialWeaponValues");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon1Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon2Value, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon3Value, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSecondaryWeapon;
    /// <summary>
    /// Function: SetSecondaryWeapon
    /// </summary>
    public unsafe virtual void SetSecondaryWeapon(BmSDK.FString WeaponType, bool Available, bool OnCoolDown)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSecondaryWeapon, "BmGame.RHudModuleBatmobile.SetSecondaryWeapon");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Available, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnCoolDown, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCannonCoolDownAnimState;
    /// <summary>
    /// Function: SetCannonCoolDownAnimState
    /// </summary>
    public unsafe virtual void SetCannonCoolDownAnimState(int CoolDownLevel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCannonCoolDownAnimState, "BmGame.RHudModuleBatmobile.SetCannonCoolDownAnimState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CoolDownLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrimaryWeapon;
    /// <summary>
    /// Function: SetPrimaryWeapon
    /// </summary>
    public unsafe virtual void SetPrimaryWeapon(BmSDK.FString WeaponType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrimaryWeapon, "BmGame.RHudModuleBatmobile.SetPrimaryWeapon");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPassengerInformation;
    /// <summary>
    /// Function: ClearPassengerInformation
    /// </summary>
    public unsafe virtual void ClearPassengerInformation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPassengerInformation, "BmGame.RHudModuleBatmobile.ClearPassengerInformation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPassengerInformation;
    /// <summary>
    /// Function: SetPassengerInformation
    /// </summary>
    public unsafe virtual void SetPassengerInformation(bool has_passenger, BmSDK.FString status_title, BmSDK.FString occupant_name, BmSDK.FString occupant_icon, bool second_passenger = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPassengerInformation, "BmGame.RHudModuleBatmobile.SetPassengerInformation");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(has_passenger, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(status_title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(occupant_name, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(occupant_icon, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(second_passenger, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetClockTimer;
    /// <summary>
    /// Function: SetClockTimer
    /// </summary>
    public unsafe virtual void SetClockTimer(BmSDK.FString Text, bool bVisible, bool bWarning)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClockTimer, "BmGame.RHudModuleBatmobile.SetClockTimer");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWarning, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendVirusUploadToFlashPrivate;
    /// <summary>
    /// Function: SendVirusUploadToFlashPrivate
    /// </summary>
    public unsafe virtual void SendVirusUploadToFlashPrivate(BmSDK.FString state_string, bool warning_visible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendVirusUploadToFlashPrivate, "BmGame.RHudModuleBatmobile.SendVirusUploadToFlashPrivate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(state_string, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(warning_visible, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVirusUploadComplete;
    /// <summary>
    /// Function: SetVirusUploadComplete
    /// </summary>
    public unsafe virtual void SetVirusUploadComplete(bool bSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVirusUploadComplete, "BmGame.RHudModuleBatmobile.SetVirusUploadComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVirusUploadActive;
    /// <summary>
    /// Function: SetVirusUploadActive
    /// </summary>
    public unsafe virtual void SetVirusUploadActive(bool bRangeWarning)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVirusUploadActive, "BmGame.RHudModuleBatmobile.SetVirusUploadActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRangeWarning, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWinchMeterVisible;
    /// <summary>
    /// Function: SetWinchMeterVisible
    /// </summary>
    public unsafe virtual void SetWinchMeterVisible(bool is_visible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWinchMeterVisible, "BmGame.RHudModuleBatmobile.SetWinchMeterVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWinchMeter;
    /// <summary>
    /// Function: SetWinchMeter
    /// </summary>
    public unsafe virtual void SetWinchMeter(float ConeAngleDegrees, float NeedleAngleDegrees, bool IsOnTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWinchMeter, "BmGame.RHudModuleBatmobile.SetWinchMeter");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConeAngleDegrees, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NeedleAngleDegrees, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsOnTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealthBarVisible;
    /// <summary>
    /// Function: SetHealthBarVisible
    /// </summary>
    public unsafe virtual void SetHealthBarVisible(bool is_visible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealthBarVisible, "BmGame.RHudModuleBatmobile.SetHealthBarVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetXpLevel;
    /// <summary>
    /// Function: SetXpLevel
    /// </summary>
    public unsafe virtual void SetXpLevel(float new_proportion, bool Snap = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXpLevel, "BmGame.RHudModuleBatmobile.SetXpLevel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_proportion, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Snap, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealth;
    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe virtual void SetHealth(float new_value, float max_value, bool Snap = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealth, "BmGame.RHudModuleBatmobile.SetHealth");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(max_value, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Snap, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBatmobileCombo;
    /// <summary>
    /// Function: SetBatmobileCombo
    /// </summary>
    public unsafe virtual void SetBatmobileCombo(float seconds_for_countdown, int Combo, float ComboReductionFactor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmobileCombo, "BmGame.RHudModuleBatmobile.SetBatmobileCombo");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(seconds_for_countdown, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Combo, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboReductionFactor, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMachineGunAccuracyFramePrivate;
    /// <summary>
    /// Function: SetMachineGunAccuracyFramePrivate
    /// </summary>
    public unsafe virtual void SetMachineGunAccuracyFramePrivate(int mgun_acc_frame)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMachineGunAccuracyFramePrivate, "BmGame.RHudModuleBatmobile.SetMachineGunAccuracyFramePrivate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mgun_acc_frame, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMachineGunAccuracy;
    /// <summary>
    /// Function: SetMachineGunAccuracy
    /// </summary>
    public unsafe virtual void SetMachineGunAccuracy(float mgun_acc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMachineGunAccuracy, "BmGame.RHudModuleBatmobile.SetMachineGunAccuracy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mgun_acc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEnergySystem;
    /// <summary>
    /// Function: SetEnergySystem
    /// </summary>
    public unsafe virtual void SetEnergySystem(int num_charges, int max_charges, float gauge_proportion, bool Snap, BmSDK.BmGame.RHudModuleBatmobile.EnergySystemStates current_state)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEnergySystem, "BmGame.RHudModuleBatmobile.SetEnergySystem");
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(num_charges, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(max_charges, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gauge_proportion, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Snap, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_state, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNumCharges;
    /// <summary>
    /// Function: SetNumCharges
    /// </summary>
    public unsafe virtual void SetNumCharges(int num_charges)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNumCharges, "BmGame.RHudModuleBatmobile.SetNumCharges");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(num_charges, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Batmobile_VirusOutroComplete;
    /// <summary>
    /// Function: XI_Batmobile_VirusOutroComplete
    /// </summary>
    public unsafe virtual void XI_Batmobile_VirusOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Batmobile_VirusOutroComplete, "BmGame.RHudModuleBatmobile.XI_Batmobile_VirusOutroComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_Batmobile_NotifyOutroComplete;
    /// <summary>
    /// Function: XI_Batmobile_NotifyOutroComplete
    /// </summary>
    public unsafe virtual void XI_Batmobile_NotifyOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_Batmobile_NotifyOutroComplete, "BmGame.RHudModuleBatmobile.XI_Batmobile_NotifyOutroComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoOutro;
    /// <summary>
    /// Function: DoOutro
    /// </summary>
    public unsafe virtual void DoOutro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoOutro, "BmGame.RHudModuleBatmobile.DoOutro");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoIntro;
    /// <summary>
    /// Function: DoIntro
    /// </summary>
    public unsafe virtual void DoIntro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoIntro, "BmGame.RHudModuleBatmobile.DoIntro");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBattleMode;
    /// <summary>
    /// Function: SetBattleMode
    /// </summary>
    public unsafe virtual void SetBattleMode(bool is_battlemode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBattleMode, "BmGame.RHudModuleBatmobile.SetBattleMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_battlemode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetZoom;
    /// <summary>
    /// Function: SetZoom
    /// </summary>
    public unsafe virtual void SetZoom(bool is_zoomed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetZoom, "BmGame.RHudModuleBatmobile.SetZoom");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_zoomed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMedalAccruing;
    /// <summary>
    /// Function: SetMedalAccruing
    /// </summary>
    public unsafe virtual void SetMedalAccruing(bool accruing)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMedalAccruing, "BmGame.RHudModuleBatmobile.SetMedalAccruing");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(accruing, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardMedal;
    /// <summary>
    /// Function: AwardMedal
    /// </summary>
    public unsafe virtual void AwardMedal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardMedal, "BmGame.RHudModuleBatmobile.AwardMedal");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMedalIndex;
    /// <summary>
    /// Function: SetMedalIndex
    /// </summary>
    public unsafe virtual void SetMedalIndex(int new_type)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMedalIndex, "BmGame.RHudModuleBatmobile.SetMedalIndex");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMedalProportion;
    /// <summary>
    /// Function: SetMedalProportion
    /// </summary>
    public unsafe virtual void SetMedalProportion(float new_proportion)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMedalProportion, "BmGame.RHudModuleBatmobile.SetMedalProportion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_proportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEnemyCount;
    /// <summary>
    /// Function: SetEnemyCount
    /// </summary>
    public unsafe virtual void SetEnemyCount(int NumEnemies)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEnemyCount, "BmGame.RHudModuleBatmobile.SetEnemyCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumEnemies, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideBoostGauge;
    /// <summary>
    /// Function: HideBoostGauge
    /// </summary>
    public unsafe virtual void HideBoostGauge()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideBoostGauge, "BmGame.RHudModuleBatmobile.HideBoostGauge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBoostGauge;
    /// <summary>
    /// Function: SetBoostGauge
    /// </summary>
    public unsafe virtual void SetBoostGauge(int current_percent, int upgrade_level)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBoostGauge, "BmGame.RHudModuleBatmobile.SetBoostGauge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_percent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(upgrade_level, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowBoostUpgrade;
    /// <summary>
    /// Function: ShowBoostUpgrade
    /// </summary>
    public unsafe virtual void ShowBoostUpgrade(BmSDK.FString line1, BmSDK.FString line2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowBoostUpgrade, "BmGame.RHudModuleBatmobile.ShowBoostUpgrade");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(line1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(line2, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRemoteInterfaceVisible;
    /// <summary>
    /// Function: SetRemoteInterfaceVisible
    /// </summary>
    public unsafe virtual void SetRemoteInterfaceVisible(bool is_visible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRemoteInterfaceVisible, "BmGame.RHudModuleBatmobile.SetRemoteInterfaceVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetForensicTrail;
    /// <summary>
    /// Function: SetForensicTrail
    /// </summary>
    public unsafe virtual void SetForensicTrail(BmSDK.FString ForensicsString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForensicTrail, "BmGame.RHudModuleBatmobile.SetForensicTrail");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForensicsString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoUpdateForensicTrail;
    /// <summary>
    /// Function: AutoUpdateForensicTrail
    /// </summary>
    public unsafe virtual void AutoUpdateForensicTrail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoUpdateForensicTrail, "BmGame.RHudModuleBatmobile.AutoUpdateForensicTrail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTurnAround;
    /// <summary>
    /// Function: SetTurnAround
    /// </summary>
    public unsafe virtual bool SetTurnAround(int Direction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTurnAround, "BmGame.RHudModuleBatmobile.SetTurnAround");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StartupCommon;
    /// <summary>
    /// Function: StartupCommon
    /// </summary>
    public unsafe virtual void StartupCommon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartupCommon, "BmGame.RHudModuleBatmobile.StartupCommon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseFlash;
    /// <summary>
    /// Function: InitialiseFlash
    /// </summary>
    public unsafe override void InitialiseFlash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseFlash, "BmGame.RHudModuleBatmobile.InitialiseFlash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudModuleBatmobile.Close");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudModuleBatmobile.Init");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Enum: HeavyCannonCooldownLevel
    /// </summary>
    public enum HeavyCannonCooldownLevel : byte
    {
        HCC_ReadyToFire = 0,
        HCC_JustFired = 1,
        HCC_ReloadingLevel0 = 2,
        HCC_ReloadingLevel1 = 3,
        HCC_ReloadingLevel2 = 4,
        HCC_MAX = 5,
    }

    /// <summary>
    /// Enum: EnergySystemStates
    /// </summary>
    public enum EnergySystemStates : byte
    {
        ESS_Normal = 0,
        ESS_Hit = 1,
        ESS_Using = 2,
        ESS_Depleting = 3,
        ESS_MAX = 4,
    }

    /// <summary>
    /// BoolProperty: DeployedAndActive
    /// </summary>
    public unsafe bool DeployedAndActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: BoostGaugeVisible
    /// </summary>
    public unsafe bool BoostGaugeVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: WinchIsOnTarget
    /// </summary>
    public unsafe bool WinchIsOnTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: WinchMeterVisible
    /// </summary>
    public unsafe bool WinchMeterVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: VirusUploadActive
    /// </summary>
    public unsafe bool VirusUploadActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bHasPassenger
    /// </summary>
    public unsafe bool bHasPassenger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bHasSecondPassenger
    /// </summary>
    public unsafe bool bHasSecondPassenger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bComboOnscreen
    /// </summary>
    public unsafe bool bComboOnscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingHudChange
    /// </summary>
    public unsafe bool PendingHudChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingPrimaryWeapon
    /// </summary>
    public unsafe bool PendingPrimaryWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: CurrentSecondaryWeaponAvailable
    /// </summary>
    public unsafe bool CurrentSecondaryWeaponAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: CurrentOnCoolDown
    /// </summary>
    public unsafe bool CurrentOnCoolDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingSecondaryWeapon
    /// </summary>
    public unsafe bool PendingSecondaryWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingCannonCooldown
    /// </summary>
    public unsafe bool PendingCannonCooldown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingSpecialWeapon
    /// </summary>
    public unsafe bool PendingSpecialWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: BattleModeActive
    /// </summary>
    public unsafe bool BattleModeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: ZoomModeActive
    /// </summary>
    public unsafe bool ZoomModeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingBattleAndZoom
    /// </summary>
    public unsafe bool PendingBattleAndZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: WeaponFeedbackActive
    /// </summary>
    public unsafe bool WeaponFeedbackActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: WeaponFeedbackEffective
    /// </summary>
    public unsafe bool WeaponFeedbackEffective
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingWeaponFeedback
    /// </summary>
    public unsafe bool PendingWeaponFeedback
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: SuppressNextChargeIncreaseSound
    /// </summary>
    public unsafe bool SuppressNextChargeIncreaseSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetBoostGauge
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetBoostGauge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetEnemyCount
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetEnemyCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetMedalProportion
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetMedalProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetMedalType
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetMedalType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetBatmobileCombo
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetBatmobileCombo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetHealth
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetXpLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetXpLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetWinchMeter
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetWinchMeter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetPrimaryWeapon
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetPrimaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCannonCooldown
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCannonCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetSpecialWeapons
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetSpecialWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetBattleAndZoomMode
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetBattleAndZoomMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetWeaponFeedback
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetWeaponFeedback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetTurnAround
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetTurnAround
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetEnergySystem
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetEnergySystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// StrProperty: CurrentForensicTrailDisplay
    /// </summary>
    public unsafe BmSDK.FString CurrentForensicTrailDisplay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetClockTimer
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetClockTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetMachineGunAccuracyFrame
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetMachineGunAccuracyFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: BoostLevel
    /// </summary>
    public unsafe int BoostLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// IntProperty: BoostUpgradeLevel
    /// </summary>
    public unsafe int BoostUpgradeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// IntProperty: CurrentEnemyCount
    /// </summary>
    public unsafe int CurrentEnemyCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: CurrentMedalProportion
    /// </summary>
    public unsafe float CurrentMedalProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: CurrentMedalIndex
    /// </summary>
    public unsafe int CurrentMedalIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: ComboSecondsForCountdown
    /// </summary>
    public unsafe float ComboSecondsForCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: ComboMultipier
    /// </summary>
    public unsafe int ComboMultipier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: CurrentComboReductionFactor
    /// </summary>
    public unsafe float CurrentComboReductionFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// FloatProperty: fCurrentHealthProportion
    /// </summary>
    public unsafe float fCurrentHealthProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: WinchConeAngleDegrees
    /// </summary>
    public unsafe float WinchConeAngleDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: WinchNeedleAngleDegrees
    /// </summary>
    public unsafe float WinchNeedleAngleDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// StrProperty: CurrentPrimaryWeapon
    /// </summary>
    public unsafe BmSDK.FString CurrentPrimaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// StrProperty: CurrentSecondaryWeapon
    /// </summary>
    public unsafe BmSDK.FString CurrentSecondaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: CurrentCannonCooldown
    /// </summary>
    public unsafe int CurrentCannonCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// IntProperty: SpecialWeaponValue1
    /// </summary>
    public unsafe int SpecialWeaponValue1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// IntProperty: SpecialWeaponValue2
    /// </summary>
    public unsafe int SpecialWeaponValue2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// IntProperty: SpecialWeaponValue3
    /// </summary>
    public unsafe int SpecialWeaponValue3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: WeaponFeedBackTimer
    /// </summary>
    public unsafe float WeaponFeedBackTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// IntProperty: TurnaroundTimer
    /// </summary>
    public unsafe int TurnaroundTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// IntProperty: TurnaroundCurrentValue
    /// </summary>
    public unsafe int TurnaroundCurrentValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: CurrentMachineGunAccuracy
    /// </summary>
    public unsafe float CurrentMachineGunAccuracy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// IntProperty: CurrentMachineGunAccuracyFrame
    /// </summary>
    public unsafe int CurrentMachineGunAccuracyFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// IntProperty: ES_NumCharges
    /// </summary>
    public unsafe int ES_NumCharges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// IntProperty: ES_MaxCharges
    /// </summary>
    public unsafe int ES_MaxCharges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: ES_GaugeProportion
    /// </summary>
    public unsafe float ES_GaugeProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: BattleModeOpacity
    /// </summary>
    public unsafe float BattleModeOpacity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }
}
