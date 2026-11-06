#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlinePlayerStorage<br/>
/// (size = 136)
/// (flags = 134217906)
/// </summary>
public partial class OnlinePlayerStorage : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlinePlayerStorage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as OnlinePlayerStorage.
    /// </summary>
    public static OnlinePlayerStorage DefaultObject => (OnlinePlayerStorage)StaticClass().DefaultObject;

    internal OnlinePlayerStorage() { }

    /// <summary>
    /// Constructs a new OnlinePlayerStorage
    /// </summary>
    public OnlinePlayerStorage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlinePlayerStorage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlinePlayerStorage(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlinePlayerStorage>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlinePlayerStorage>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlinePlayerStorage>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlinePlayerStorage>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlinePlayerStorage>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlinePlayerStorage>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlinePlayerStorage>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlinePlayerStorage>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetDefaultVersionNumber;
    /// <summary>
    /// Function: SetDefaultVersionNumber
    /// </summary>
    public unsafe virtual void SetDefaultVersionNumber()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDefaultVersionNumber, "Engine.OnlinePlayerStorage.SetDefaultVersionNumber");
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

    private static BmSDK.Function __fn_GetVersionNumber;
    /// <summary>
    /// Function: GetVersionNumber
    /// </summary>
    public unsafe virtual int GetVersionNumber()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVersionNumber, "Engine.OnlinePlayerStorage.GetVersionNumber");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AppendVersionToSettings;
    /// <summary>
    /// Function: AppendVersionToSettings
    /// </summary>
    public unsafe virtual void AppendVersionToSettings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendVersionToSettings, "Engine.OnlinePlayerStorage.AppendVersionToSettings");
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
    public unsafe virtual void SetToDefaults()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetToDefaults, "Engine.OnlinePlayerStorage.SetToDefaults");
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

    private static BmSDK.Function __fn_AddSettingFloat;
    /// <summary>
    /// Function: AddSettingFloat
    /// </summary>
    public unsafe virtual void AddSettingFloat(int SettingId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSettingFloat, "Engine.OnlinePlayerStorage.AddSettingFloat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SettingId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddSettingInt;
    /// <summary>
    /// Function: AddSettingInt
    /// </summary>
    public unsafe virtual void AddSettingInt(int SettingId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSettingInt, "Engine.OnlinePlayerStorage.AddSettingInt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SettingId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetRangedProfileSettingValue;
    /// <summary>
    /// Function: GetRangedProfileSettingValue
    /// </summary>
    public unsafe virtual bool GetRangedProfileSettingValue(int ProfileId, out float OutValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRangedProfileSettingValue, "Engine.OnlinePlayerStorage.GetRangedProfileSettingValue");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetRangedProfileSettingValue;
    /// <summary>
    /// Function: SetRangedProfileSettingValue
    /// </summary>
    public unsafe virtual bool SetRangedProfileSettingValue(int ProfileId, float NewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRangedProfileSettingValue, "Engine.OnlinePlayerStorage.SetRangedProfileSettingValue");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetProfileSettingRange;
    /// <summary>
    /// Function: GetProfileSettingRange
    /// </summary>
    public unsafe virtual bool GetProfileSettingRange(int ProfileId, out float OutMinValue, out float OutMaxValue, out float RangeIncrement, out byte bFormatAsInt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingRange, "Engine.OnlinePlayerStorage.GetProfileSettingRange");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutMinValue = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        OutMaxValue = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
        RangeIncrement = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
        bFormatAsInt = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetProfileSettingMappingIds;
    /// <summary>
    /// Function: GetProfileSettingMappingIds
    /// </summary>
    public unsafe static bool GetProfileSettingMappingIds(int ProfileId, out BmSDK.TArray<int> Ids)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingMappingIds, "Engine.OnlinePlayerStorage.GetProfileSettingMappingIds");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Ids = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetProfileSettingMappingType;
    /// <summary>
    /// Function: GetProfileSettingMappingType
    /// </summary>
    public unsafe virtual bool GetProfileSettingMappingType(int ProfileId, out BmSDK.Engine.Settings.EPropertyValueMappingType OutType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingMappingType, "Engine.OnlinePlayerStorage.GetProfileSettingMappingType");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutType = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Settings.EPropertyValueMappingType>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetProfileSettingValueFloat;
    /// <summary>
    /// Function: SetProfileSettingValueFloat
    /// </summary>
    public unsafe virtual bool SetProfileSettingValueFloat(int ProfileSettingId, float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProfileSettingValueFloat, "Engine.OnlinePlayerStorage.SetProfileSettingValueFloat");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetProfileSettingValueInt;
    /// <summary>
    /// Function: SetProfileSettingValueInt
    /// </summary>
    public unsafe virtual bool SetProfileSettingValueInt(int ProfileSettingId, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProfileSettingValueInt, "Engine.OnlinePlayerStorage.SetProfileSettingValueInt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetProfileSettingValueId;
    /// <summary>
    /// Function: SetProfileSettingValueId
    /// </summary>
    public unsafe virtual bool SetProfileSettingValueId(int ProfileSettingId, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProfileSettingValueId, "Engine.OnlinePlayerStorage.SetProfileSettingValueId");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetProfileSettingValueFloat;
    /// <summary>
    /// Function: GetProfileSettingValueFloat
    /// </summary>
    public unsafe virtual bool GetProfileSettingValueFloat(int ProfileSettingId, out float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingValueFloat, "Engine.OnlinePlayerStorage.GetProfileSettingValueFloat");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Value = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetProfileSettingValueInt;
    /// <summary>
    /// Function: GetProfileSettingValueInt
    /// </summary>
    public unsafe virtual bool GetProfileSettingValueInt(int ProfileSettingId, out int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingValueInt, "Engine.OnlinePlayerStorage.GetProfileSettingValueInt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Value = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetProfileSettingValueFromListIndex;
    /// <summary>
    /// Function: GetProfileSettingValueFromListIndex
    /// </summary>
    public unsafe virtual bool GetProfileSettingValueFromListIndex(int ProfileSettingId, int ListIndex, out int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingValueFromListIndex, "Engine.OnlinePlayerStorage.GetProfileSettingValueFromListIndex");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListIndex, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Value = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetProfileSettingValueId;
    /// <summary>
    /// Function: GetProfileSettingValueId
    /// </summary>
    public unsafe virtual bool GetProfileSettingValueId(int ProfileSettingId, out int ValueId, out int ListIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingValueId, "Engine.OnlinePlayerStorage.GetProfileSettingValueId");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ValueId = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        ListIndex = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetProfileSettingValue;
    /// <summary>
    /// Function: SetProfileSettingValue
    /// </summary>
    public unsafe virtual bool SetProfileSettingValue(int ProfileSettingId, out BmSDK.FString NewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProfileSettingValue, "Engine.OnlinePlayerStorage.SetProfileSettingValue");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewValue = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetProfileSettingValueByName;
    /// <summary>
    /// Function: SetProfileSettingValueByName
    /// </summary>
    public unsafe virtual bool SetProfileSettingValueByName(BmSDK.FName ProfileSettingName, out BmSDK.FString NewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProfileSettingValueByName, "Engine.OnlinePlayerStorage.SetProfileSettingValueByName");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewValue = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetProfileSettingValueByName;
    /// <summary>
    /// Function: GetProfileSettingValueByName
    /// </summary>
    public unsafe virtual bool GetProfileSettingValueByName(BmSDK.FName ProfileSettingName, out BmSDK.FString Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingValueByName, "Engine.OnlinePlayerStorage.GetProfileSettingValueByName");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Value = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetProfileSettingValues;
    /// <summary>
    /// Function: GetProfileSettingValues
    /// </summary>
    public unsafe virtual bool GetProfileSettingValues(int ProfileSettingId, out BmSDK.TArray<BmSDK.FName> Values)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingValues, "Engine.OnlinePlayerStorage.GetProfileSettingValues");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Values = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetProfileSettingValueName;
    /// <summary>
    /// Function: GetProfileSettingValueName
    /// </summary>
    public unsafe virtual BmSDK.FName GetProfileSettingValueName(int ProfileSettingId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingValueName, "Engine.OnlinePlayerStorage.GetProfileSettingValueName");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetProfileSettingValue;
    /// <summary>
    /// Function: GetProfileSettingValue
    /// </summary>
    public unsafe virtual bool GetProfileSettingValue(int ProfileSettingId, out BmSDK.FString Value, int ValueMapID = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingValue, "Engine.OnlinePlayerStorage.GetProfileSettingValue");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueMapID, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Value = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_IsProfileSettingIdMapped;
    /// <summary>
    /// Function: IsProfileSettingIdMapped
    /// </summary>
    public unsafe virtual bool IsProfileSettingIdMapped(int ProfileSettingId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsProfileSettingIdMapped, "Engine.OnlinePlayerStorage.IsProfileSettingIdMapped");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FindDefaultProfileMappingIndexByName;
    /// <summary>
    /// Function: FindDefaultProfileMappingIndexByName
    /// </summary>
    public unsafe static int FindDefaultProfileMappingIndexByName(BmSDK.FName ProfileSettingName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindDefaultProfileMappingIndexByName, "Engine.OnlinePlayerStorage.FindDefaultProfileMappingIndexByName");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindProfileMappingIndexByName;
    /// <summary>
    /// Function: FindProfileMappingIndexByName
    /// </summary>
    public unsafe virtual int FindProfileMappingIndexByName(BmSDK.FName ProfileSettingName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindProfileMappingIndexByName, "Engine.OnlinePlayerStorage.FindProfileMappingIndexByName");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindProfileMappingIndex;
    /// <summary>
    /// Function: FindProfileMappingIndex
    /// </summary>
    public unsafe virtual int FindProfileMappingIndex(int ProfileSettingId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindProfileMappingIndex, "Engine.OnlinePlayerStorage.FindProfileMappingIndex");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindProfileSettingIndex;
    /// <summary>
    /// Function: FindProfileSettingIndex
    /// </summary>
    public unsafe virtual int FindProfileSettingIndex(int ProfileSettingId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindProfileSettingIndex, "Engine.OnlinePlayerStorage.FindProfileSettingIndex");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetProfileSettingColumnHeader;
    /// <summary>
    /// Function: GetProfileSettingColumnHeader
    /// </summary>
    public unsafe virtual BmSDK.FString GetProfileSettingColumnHeader(int ProfileSettingId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingColumnHeader, "Engine.OnlinePlayerStorage.GetProfileSettingColumnHeader");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetProfileSettingName;
    /// <summary>
    /// Function: GetProfileSettingName
    /// </summary>
    public unsafe virtual BmSDK.FName GetProfileSettingName(int ProfileSettingId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingName, "Engine.OnlinePlayerStorage.GetProfileSettingName");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetProfileSettingId;
    /// <summary>
    /// Function: GetProfileSettingId
    /// </summary>
    public unsafe virtual bool GetProfileSettingId(BmSDK.FName ProfileSettingName, out int ProfileSettingId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettingId, "Engine.OnlinePlayerStorage.GetProfileSettingId");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettingName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ProfileSettingId = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Enum: EOnlinePlayerStorageAsyncState
    /// </summary>
    public enum EOnlinePlayerStorageAsyncState : byte
    {
        OPAS_NotStarted = 0,
        OPAS_Read = 1,
        OPAS_Write = 2,
        OPAS_Finished = 3,
        OPAS_MAX = 4,
    }

    /// <summary>
    /// IntProperty: VersionNumber
    /// </summary>
    public unsafe int VersionNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: VersionSettingsId
    /// </summary>
    public unsafe int VersionSettingsId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// IntProperty: SaveCountSettingId
    /// </summary>
    public unsafe int SaveCountSettingId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: ProfileSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlinePlayerStorage.FOnlineProfileSetting> ProfileSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlinePlayerStorage.FOnlineProfileSetting>>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: ProfileMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Settings.FSettingsPropertyPropertyMetaData> ProfileMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FSettingsPropertyPropertyMetaData>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ByteProperty: AsyncState
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerStorage.EOnlinePlayerStorageAsyncState AsyncState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerStorage.EOnlinePlayerStorageAsyncState>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// IntProperty: DeviceID
    /// </summary>
    public unsafe int DeviceID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// Struct: FOnlineProfileSetting
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FOnlineProfileSetting
    {
        /// <summary>
        /// ByteProperty: Owner
        /// </summary>
        public unsafe BmSDK.Engine.OnlinePlayerStorage.EOnlineProfilePropertyOwner Owner
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerStorage.EOnlineProfilePropertyOwner>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ProfileSetting
        /// </summary>
        public unsafe BmSDK.Engine.Settings.FSettingsProperty ProfileSetting
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Settings.FSettingsProperty>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EOnlineProfilePropertyOwner
    /// </summary>
    public enum EOnlineProfilePropertyOwner : byte
    {
        OPPO_None = 0,
        OPPO_OnlineService = 1,
        OPPO_Game = 2,
        OPPO_MAX = 3,
    }
}
