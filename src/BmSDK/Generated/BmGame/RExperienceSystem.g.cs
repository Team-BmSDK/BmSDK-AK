#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RExperienceSystem<br/>
/// (size = 764)
/// (flags = 10485782)
/// </summary>
public partial class RExperienceSystem : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RExperienceSystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RExperienceSystem.
    /// </summary>
    public static RExperienceSystem DefaultObject => (RExperienceSystem)StaticClass().DefaultObject;

    internal RExperienceSystem() { }

    /// <summary>
    /// Constructs a new RExperienceSystem
    /// </summary>
    public RExperienceSystem(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RExperienceSystem(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExperienceSystem>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExperienceSystem>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExperienceSystem>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExperienceSystem>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExperienceSystem>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExperienceSystem>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExperienceSystem>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExperienceSystem>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_HideXPBar;
    /// <summary>
    /// Function: HideXPBar
    /// </summary>
    public unsafe virtual void HideXPBar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideXPBar, "BmGame.RExperienceSystem.HideXPBar");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowXPBar;
    /// <summary>
    /// Function: ShowXPBar
    /// </summary>
    public unsafe virtual void ShowXPBar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowXPBar, "BmGame.RExperienceSystem.ShowXPBar");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpentXP;
    /// <summary>
    /// Function: SpentXP
    /// </summary>
    public unsafe virtual void SpentXP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpentXP, "BmGame.RExperienceSystem.SpentXP");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsXPCutsceneSuppressed;
    /// <summary>
    /// Function: IsXPCutsceneSuppressed
    /// </summary>
    public unsafe virtual bool IsXPCutsceneSuppressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsXPCutsceneSuppressed, "BmGame.RExperienceSystem.IsXPCutsceneSuppressed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllowXPCutscene;
    /// <summary>
    /// Function: AllowXPCutscene
    /// </summary>
    public unsafe virtual void AllowXPCutscene()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowXPCutscene, "BmGame.RExperienceSystem.AllowXPCutscene");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuppressXPCutscene;
    /// <summary>
    /// Function: SuppressXPCutscene
    /// </summary>
    public unsafe virtual void SuppressXPCutscene()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuppressXPCutscene, "BmGame.RExperienceSystem.SuppressXPCutscene");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetActualXPBar;
    /// <summary>
    /// Function: SetActualXPBar
    /// </summary>
    public unsafe virtual void SetActualXPBar(int NewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActualXPBar, "BmGame.RExperienceSystem.SetActualXPBar");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetXpDisplayProportion;
    /// <summary>
    /// Function: GetXpDisplayProportion
    /// </summary>
    public unsafe virtual float GetXpDisplayProportion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetXpDisplayProportion, "BmGame.RExperienceSystem.GetXpDisplayProportion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearActualXPBar;
    /// <summary>
    /// Function: ClearActualXPBar
    /// </summary>
    public unsafe virtual void ClearActualXPBar()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearActualXPBar, "BmGame.RExperienceSystem.ClearActualXPBar");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFadedXPBar;
    /// <summary>
    /// Function: SetFadedXPBar
    /// </summary>
    public unsafe virtual void SetFadedXPBar(int NewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFadedXPBar, "BmGame.RExperienceSystem.SetFadedXPBar");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndLevelUp;
    /// <summary>
    /// Function: EndLevelUp
    /// </summary>
    public unsafe virtual void EndLevelUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndLevelUp, "BmGame.RExperienceSystem.EndLevelUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LevelUp;
    /// <summary>
    /// Function: LevelUp
    /// </summary>
    public unsafe virtual void LevelUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelUp, "BmGame.RExperienceSystem.LevelUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckXPAfterLoad;
    /// <summary>
    /// Function: CheckXPAfterLoad
    /// </summary>
    public unsafe virtual void CheckXPAfterLoad()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckXPAfterLoad, "BmGame.RExperienceSystem.CheckXPAfterLoad");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndUnbankedXP;
    /// <summary>
    /// Function: EndUnbankedXP
    /// </summary>
    public unsafe virtual void EndUnbankedXP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndUnbankedXP, "BmGame.RExperienceSystem.EndUnbankedXP");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BankXP;
    /// <summary>
    /// Function: BankXP
    /// </summary>
    public unsafe virtual void BankXP(bool bForSave = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BankXP, "BmGame.RExperienceSystem.BankXP");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForSave, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnRegisterXPSequence;
    /// <summary>
    /// Function: UnRegisterXPSequence
    /// </summary>
    public unsafe virtual void UnRegisterXPSequence(BmSDK.BmGame.RXPSequence OldSequence)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnRegisterXPSequence, "BmGame.RExperienceSystem.UnRegisterXPSequence");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldSequence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterXPSequence;
    /// <summary>
    /// Function: RegisterXPSequence
    /// </summary>
    public unsafe virtual void RegisterXPSequence(BmSDK.BmGame.RXPSequence NewSequence)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterXPSequence, "BmGame.RExperienceSystem.RegisterXPSequence");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSequence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlushPendingLevelUp;
    /// <summary>
    /// Function: FlushPendingLevelUp
    /// </summary>
    public unsafe virtual void FlushPendingLevelUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushPendingLevelUp, "BmGame.RExperienceSystem.FlushPendingLevelUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BankIfRoomClear;
    /// <summary>
    /// Function: BankIfRoomClear
    /// </summary>
    public unsafe virtual void BankIfRoomClear()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BankIfRoomClear, "BmGame.RExperienceSystem.BankIfRoomClear");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceBankXP;
    /// <summary>
    /// Function: ForceBankXP
    /// </summary>
    public unsafe virtual void ForceBankXP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceBankXP, "BmGame.RExperienceSystem.ForceBankXP");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceBankIfRoomClear;
    /// <summary>
    /// Function: ForceBankIfRoomClear
    /// </summary>
    public unsafe virtual void ForceBankIfRoomClear()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceBankIfRoomClear, "BmGame.RExperienceSystem.ForceBankIfRoomClear");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BankIfVehiclesClear;
    /// <summary>
    /// Function: BankIfVehiclesClear
    /// </summary>
    public unsafe virtual void BankIfVehiclesClear()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BankIfVehiclesClear, "BmGame.RExperienceSystem.BankIfVehiclesClear");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceBankVehicleXPIfRoomClear;
    /// <summary>
    /// Function: ForceBankVehicleXPIfRoomClear
    /// </summary>
    public unsafe virtual void ForceBankVehicleXPIfRoomClear()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceBankVehicleXPIfRoomClear, "BmGame.RExperienceSystem.ForceBankVehicleXPIfRoomClear");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUnbankedXP;
    /// <summary>
    /// Function: AddUnbankedXP
    /// </summary>
    public unsafe virtual void AddUnbankedXP(int XpAwarded, bool bTeeth)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUnbankedXP, "BmGame.RExperienceSystem.AddUnbankedXP");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XpAwarded, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTeeth, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnXPSequence;
    /// <summary>
    /// Function: SpawnXPSequence
    /// </summary>
    public unsafe virtual void SpawnXPSequence(int XpAwarded, BmSDK.Engine.Actor XPTarget, BmSDK.BmGame.RGameInfo.EGameAction Type, float BatMultiplier = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnXPSequence, "BmGame.RExperienceSystem.SpawnXPSequence");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XpAwarded, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatMultiplier, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowXPBarForUnbanked;
    /// <summary>
    /// Function: ShowXPBarForUnbanked
    /// </summary>
    public unsafe virtual void ShowXPBarForUnbanked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowXPBarForUnbanked, "BmGame.RExperienceSystem.ShowXPBarForUnbanked");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCombatChallengeBonus;
    /// <summary>
    /// Function: AddCombatChallengeBonus
    /// </summary>
    public unsafe virtual int AddCombatChallengeBonus(out BmSDK.FString SummaryString, out float DelayBankTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCombatChallengeBonus, "BmGame.RExperienceSystem.AddCombatChallengeBonus");
        byte* paramsPtr = stackalloc byte[56];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DelayBankTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayBankTime, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SummaryString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        DelayBankTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_AddToBonusSummaryString;
    /// <summary>
    /// Function: AddToBonusSummaryString
    /// </summary>
    public unsafe virtual void AddToBonusSummaryString(out BmSDK.FString SummaryString, out int TotalScore, out float DelayTime, BmSDK.FString Desc, int Multi, int Score, bool bMultiXScore, BmSDK.FString OverrideString = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToBonusSummaryString, "BmGame.RExperienceSystem.AddToBonusSummaryString");
        byte* paramsPtr = stackalloc byte[84];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TotalScore);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalScore, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DelayTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayTime, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Multi, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMultiXScore, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideString, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SummaryString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        TotalScore = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        DelayTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_GetMaxComboGadgetVariationBonus;
    /// <summary>
    /// Function: GetMaxComboGadgetVariationBonus
    /// </summary>
    public unsafe virtual int GetMaxComboGadgetVariationBonus(int Variation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxComboGadgetVariationBonus, "BmGame.RExperienceSystem.GetMaxComboGadgetVariationBonus");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Variation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetMaxComboVariationBonus;
    /// <summary>
    /// Function: GetMaxComboVariationBonus
    /// </summary>
    public unsafe virtual int GetMaxComboVariationBonus(int Variation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxComboVariationBonus, "BmGame.RExperienceSystem.GetMaxComboVariationBonus");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Variation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AddPredatorXPBonus;
    /// <summary>
    /// Function: AddPredatorXPBonus
    /// </summary>
    public unsafe virtual void AddPredatorXPBonus(BmSDK.BmGame.RGameInfo.FPredatorXPInfo XPInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPredatorXPBonus, "BmGame.RExperienceSystem.AddPredatorXPBonus");
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCombatXPBonus;
    /// <summary>
    /// Function: AddCombatXPBonus
    /// </summary>
    public unsafe virtual void AddCombatXPBonus(BmSDK.BmGame.RGameInfo.FCombatXPInfo XPInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCombatXPBonus, "BmGame.RExperienceSystem.AddCombatXPBonus");
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddSummaryTitle;
    /// <summary>
    /// Function: AddSummaryTitle
    /// </summary>
    public unsafe virtual void AddSummaryTitle(out BmSDK.FString SummaryString, out float DelayTime, BmSDK.FString TitleText)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSummaryTitle, "BmGame.RExperienceSystem.AddSummaryTitle");
        byte* paramsPtr = stackalloc byte[36];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DelayTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleText, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SummaryString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        DelayTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_AddToSummaryString;
    /// <summary>
    /// Function: AddToSummaryString
    /// </summary>
    public unsafe virtual void AddToSummaryString(out BmSDK.FString SummaryString, out int TotalXP, out float DelayTime, BmSDK.FString Desc, int Multi, float XPPer, bool bIndent, bool bAddXP = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToSummaryString, "BmGame.RExperienceSystem.AddToSummaryString");
        byte* paramsPtr = stackalloc byte[76];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TotalXP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalXP, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DelayTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayTime, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Multi, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPPer, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIndent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddXP, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SummaryString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        TotalXP = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        DelayTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_RegisterCombatKO;
    /// <summary>
    /// Function: RegisterCombatKO
    /// </summary>
    public unsafe virtual void RegisterCombatKO(BmSDK.BmGame.RGameInfo.EGameAction Type, BmSDK.Engine.Actor XPTarget, int XPAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterCombatKO, "BmGame.RExperienceSystem.RegisterCombatKO");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAmount, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterSpecialAction;
    /// <summary>
    /// Function: RegisterSpecialAction
    /// </summary>
    public unsafe virtual void RegisterSpecialAction(BmSDK.BmGame.RGameInfo.EGameAction Type, BmSDK.Engine.Actor XPTarget, int XPAmount = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterSpecialAction, "BmGame.RExperienceSystem.RegisterSpecialAction");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAmount, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterRepeatedAction;
    /// <summary>
    /// Function: RegisterRepeatedAction
    /// </summary>
    public unsafe virtual void RegisterRepeatedAction(BmSDK.BmGame.RGameInfo.EGameAction Type, BmSDK.Engine.Actor XPTarget, int XPAmount = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterRepeatedAction, "BmGame.RExperienceSystem.RegisterRepeatedAction");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAmount, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterTakedown;
    /// <summary>
    /// Function: RegisterTakedown
    /// </summary>
    public unsafe virtual void RegisterTakedown(BmSDK.BmGame.RGameInfo.EGameAction Type, BmSDK.Engine.Actor XPTarget, int XPAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterTakedown, "BmGame.RExperienceSystem.RegisterTakedown");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAmount, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldAwardCombatXP;
    /// <summary>
    /// Function: ShouldAwardCombatXP
    /// </summary>
    public unsafe virtual bool ShouldAwardCombatXP()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldAwardCombatXP, "BmGame.RExperienceSystem.ShouldAwardCombatXP");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RExperienceSystem.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: pData
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData pData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: PShared
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentShared PShared
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentShared>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ArrayProperty: XPValue
    /// </summary>
    public unsafe BmSDK.TArray<float> XPValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ArrayProperty: XPCurve
    /// </summary>
    public unsafe BmSDK.TArray<float> XPCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: TargetPreXP
    /// </summary>
    public unsafe float TargetPreXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForUpgrade
    /// </summary>
    public unsafe bool bWaitingForUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bSuppressCutscene
    /// </summary>
    public unsafe bool bSuppressCutscene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bShownBarForLevelUp
    /// </summary>
    public unsafe bool bShownBarForLevelUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bShownBarForBanking
    /// </summary>
    public unsafe bool bShownBarForBanking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bShownBarForUnbanked
    /// </summary>
    public unsafe bool bShownBarForUnbanked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// IntProperty: ShowBar
    /// </summary>
    public unsafe int ShowBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// IntProperty: UnbankedXP
    /// </summary>
    public unsafe int UnbankedXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// IntProperty: UnbankedTeethXP
    /// </summary>
    public unsafe int UnbankedTeethXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ArrayProperty: XPSequences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RXPSequence> XPSequences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RXPSequence>>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: TimePerSummaryEntry
    /// </summary>
    public unsafe float TimePerSummaryEntry
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }
}
