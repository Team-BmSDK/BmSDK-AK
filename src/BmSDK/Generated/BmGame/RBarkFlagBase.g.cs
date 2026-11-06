#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkFlagBase<br/>
/// (size = 100)
/// (flags = 134221970)
/// </summary>
public partial class RBarkFlagBase : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkFlagBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBarkFlagBase.
    /// </summary>
    public static RBarkFlagBase DefaultObject => (RBarkFlagBase)StaticClass().DefaultObject;

    internal RBarkFlagBase() { }

    /// <summary>
    /// Constructs a new RBarkFlagBase
    /// </summary>
    public RBarkFlagBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkFlagBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkFlagBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkFlagBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkFlagBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkFlagBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkFlagBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkFlagBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkFlagBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBarkFlagBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBarkFlagBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetFlagsAsString;
    /// <summary>
    /// Function: GetFlagsAsString
    /// </summary>
    public unsafe virtual BmSDK.FString GetFlagsAsString()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFlagsAsString, "BmGame.RBarkFlagBase.GetFlagsAsString");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DumpToLog;
    /// <summary>
    /// Function: DumpToLog
    /// </summary>
    public unsafe virtual void DumpToLog()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpToLog, "BmGame.RBarkFlagBase.DumpToLog");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldAutoTagAsNeverOverRadio;
    /// <summary>
    /// Function: ShouldAutoTagAsNeverOverRadio
    /// </summary>
    public unsafe virtual bool ShouldAutoTagAsNeverOverRadio()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldAutoTagAsNeverOverRadio, "BmGame.RBarkFlagBase.ShouldAutoTagAsNeverOverRadio");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldAutoTagAsAllowKnockedOut;
    /// <summary>
    /// Function: ShouldAutoTagAsAllowKnockedOut
    /// </summary>
    public unsafe virtual bool ShouldAutoTagAsAllowKnockedOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldAutoTagAsAllowKnockedOut, "BmGame.RBarkFlagBase.ShouldAutoTagAsAllowKnockedOut");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearAllOfType;
    /// <summary>
    /// Function: ClearAllOfType
    /// </summary>
    public unsafe virtual void ClearAllOfType(BmSDK.BmGame.RBarkValDef.FlagTypeEnum PurgeType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllOfType, "BmGame.RBarkFlagBase.ClearAllOfType");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurgeType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInterestWeight;
    /// <summary>
    /// Function: GetInterestWeight
    /// </summary>
    public unsafe virtual int GetInterestWeight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInterestWeight, "BmGame.RBarkFlagBase.GetInterestWeight");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetValidValuesForType;
    /// <summary>
    /// Function: GetValidValuesForType
    /// </summary>
    public unsafe static void GetValidValuesForType(BmSDK.BmGame.RBarkValDef.FlagTypeEnum CheckType, out BmSDK.TArray<BmSDK.FName> ValidList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValidValuesForType, "BmGame.RBarkFlagBase.GetValidValuesForType");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ValidList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_ValueIsValid;
    /// <summary>
    /// Function: ValueIsValid
    /// </summary>
    public unsafe virtual bool ValueIsValid(BmSDK.BmGame.RBarkValDef.FlagTypeEnum CheckType, BmSDK.FName CheckValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ValueIsValid, "BmGame.RBarkFlagBase.ValueIsValid");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckValue, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_HasTheseFlags;
    /// <summary>
    /// Function: HasTheseFlags
    /// </summary>
    public unsafe virtual bool HasTheseFlags(BmSDK.BmGame.RBarkFlagBase OtherBase)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasTheseFlags, "BmGame.RBarkFlagBase.HasTheseFlags");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherBase, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetAllValuesForType;
    /// <summary>
    /// Function: GetAllValuesForType
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.FName> GetAllValuesForType(BmSDK.BmGame.RBarkValDef.FlagTypeEnum TestType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllValuesForType, "BmGame.RBarkFlagBase.GetAllValuesForType");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetValueForType;
    /// <summary>
    /// Function: GetValueForType
    /// </summary>
    public unsafe virtual BmSDK.FName GetValueForType(BmSDK.BmGame.RBarkValDef.FlagTypeEnum TestType, int TestIndex = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValueForType, "BmGame.RBarkFlagBase.GetValueForType");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestIndex, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCountFlagFromInt;
    /// <summary>
    /// Function: GetCountFlagFromInt
    /// </summary>
    public unsafe static BmSDK.FName GetCountFlagFromInt(int CountVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCountFlagFromInt, "BmGame.RBarkFlagBase.GetCountFlagFromInt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CountVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AddFlagStruct;
    /// <summary>
    /// Function: AddFlagStruct
    /// </summary>
    public unsafe virtual void AddFlagStruct(BmSDK.BmGame.RBarkFlagBase.FBarkFlag NewFlag)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFlagStruct, "BmGame.RBarkFlagBase.AddFlagStruct");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveFlag;
    /// <summary>
    /// Function: RemoveFlag
    /// </summary>
    public unsafe virtual void RemoveFlag(BmSDK.BmGame.RBarkValDef.FlagTypeEnum PurgeType, BmSDK.FName PurgeName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFlag, "BmGame.RBarkFlagBase.RemoveFlag");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurgeType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurgeName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFlag;
    /// <summary>
    /// Function: AddFlag
    /// </summary>
    public unsafe virtual bool AddFlag(BmSDK.BmGame.RBarkValDef.FlagTypeEnum Type, BmSDK.FName NewName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFlag, "BmGame.RBarkFlagBase.AddFlag");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_BuildFromString;
    /// <summary>
    /// Function: BuildFromString
    /// </summary>
    public unsafe virtual bool BuildFromString(BmSDK.FString Input)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildFromString, "BmGame.RBarkFlagBase.BuildFromString");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Input, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ValueFromString;
    /// <summary>
    /// Function: ValueFromString
    /// </summary>
    public unsafe static BmSDK.FName ValueFromString(BmSDK.FString Input)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ValueFromString, "BmGame.RBarkFlagBase.ValueFromString");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Input, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_TypeFromString;
    /// <summary>
    /// Function: TypeFromString
    /// </summary>
    public unsafe static BmSDK.BmGame.RBarkValDef.FlagTypeEnum TypeFromString(BmSDK.FString Input)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TypeFromString, "BmGame.RBarkFlagBase.TypeFromString");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Input, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkValDef.FlagTypeEnum>(paramsPtr + 16);
    }

    /// <summary>
    /// ArrayProperty: FlagList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase.FBarkFlag> FlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase.FBarkFlag>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// Struct: FBarkFlag
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FBarkFlag
    {
        /// <summary>
        /// ByteProperty: FlagType
        /// </summary>
        public unsafe BmSDK.BmGame.RBarkValDef.FlagTypeEnum FlagType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkValDef.FlagTypeEnum>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: FlagName
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> FlagName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EBarkDeliveryType
    /// </summary>
    public enum EBarkDeliveryType : byte
    {
        BDT_DoNotCare = 0,
        BDT_Spoken = 1,
        BDT_Shouted = 2,
        BDT_Auto = 3,
        BDT_MAX = 4,
    }
}
