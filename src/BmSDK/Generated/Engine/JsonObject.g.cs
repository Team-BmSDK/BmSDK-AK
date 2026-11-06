#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: JsonObject<br/>
/// (size = 260)
/// (flags = 134217874)
/// </summary>
public partial class JsonObject : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.JsonObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as JsonObject.
    /// </summary>
    public static JsonObject DefaultObject => (JsonObject)StaticClass().DefaultObject;

    internal JsonObject() { }

    /// <summary>
    /// Constructs a new JsonObject
    /// </summary>
    public JsonObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, JsonObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected JsonObject(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<JsonObject>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<JsonObject>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<JsonObject>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<JsonObject>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<JsonObject>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<JsonObject>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<JsonObject>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<JsonObject>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DecodeJson;
    /// <summary>
    /// Function: DecodeJson
    /// </summary>
    public unsafe static BmSDK.Engine.JsonObject DecodeJson(BmSDK.FString Str)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DecodeJson, "Engine.JsonObject.DecodeJson");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Str, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.JsonObject>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EncodeJson;
    /// <summary>
    /// Function: EncodeJson
    /// </summary>
    public unsafe static BmSDK.FString EncodeJson(BmSDK.Engine.JsonObject Root)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EncodeJson, "Engine.JsonObject.EncodeJson");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Root, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetBoolValue;
    /// <summary>
    /// Function: SetBoolValue
    /// </summary>
    public unsafe virtual void SetBoolValue(BmSDK.FString Key, bool Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBoolValue, "Engine.JsonObject.SetBoolValue");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFloatValue;
    /// <summary>
    /// Function: SetFloatValue
    /// </summary>
    public unsafe virtual void SetFloatValue(BmSDK.FString Key, float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFloatValue, "Engine.JsonObject.SetFloatValue");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIntValue;
    /// <summary>
    /// Function: SetIntValue
    /// </summary>
    public unsafe virtual void SetIntValue(BmSDK.FString Key, int Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIntValue, "Engine.JsonObject.SetIntValue");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStringValue;
    /// <summary>
    /// Function: SetStringValue
    /// </summary>
    public unsafe virtual void SetStringValue(BmSDK.FString Key, BmSDK.FString Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStringValue, "Engine.JsonObject.SetStringValue");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
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

    private static BmSDK.Function __fn_SetObject;
    /// <summary>
    /// Function: SetObject
    /// </summary>
    public unsafe virtual void SetObject(BmSDK.FString Key, BmSDK.Engine.JsonObject Object)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetObject, "Engine.JsonObject.SetObject");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Object, paramsPtr + 16);
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

    private static BmSDK.Function __fn_GetVector4Value;
    /// <summary>
    /// Function: GetVector4Value
    /// </summary>
    public unsafe virtual System.Numerics.Vector4 GetVector4Value(BmSDK.FString Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVector4Value, "Engine.JsonObject.GetVector4Value");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector4>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetVectorValue;
    /// <summary>
    /// Function: GetVectorValue
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetVectorValue(BmSDK.FString Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVectorValue, "Engine.JsonObject.GetVectorValue");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetBoolValue;
    /// <summary>
    /// Function: GetBoolValue
    /// </summary>
    public unsafe virtual bool GetBoolValue(BmSDK.FString Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoolValue, "Engine.JsonObject.GetBoolValue");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetFloatValue;
    /// <summary>
    /// Function: GetFloatValue
    /// </summary>
    public unsafe virtual float GetFloatValue(BmSDK.FString Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFloatValue, "Engine.JsonObject.GetFloatValue");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetIntValue;
    /// <summary>
    /// Function: GetIntValue
    /// </summary>
    public unsafe virtual int GetIntValue(BmSDK.FString Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIntValue, "Engine.JsonObject.GetIntValue");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetStringValueWithFallback;
    /// <summary>
    /// Function: GetStringValueWithFallback
    /// </summary>
    public unsafe virtual BmSDK.FString GetStringValueWithFallback(BmSDK.FString Key, BmSDK.FString Fallback)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringValueWithFallback, "Engine.JsonObject.GetStringValueWithFallback");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fallback, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetStringValue;
    /// <summary>
    /// Function: GetStringValue
    /// </summary>
    public unsafe virtual BmSDK.FString GetStringValue(BmSDK.FString Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringValue, "Engine.JsonObject.GetStringValue");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetObject;
    /// <summary>
    /// Function: GetObject
    /// </summary>
    public unsafe virtual BmSDK.Engine.JsonObject GetObject(BmSDK.FString Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObject, "Engine.JsonObject.GetObject");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.JsonObject>(paramsPtr + 16);
    }

    /// <summary>
    /// StructProperty: ValueMap
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMap_Mirror ValueMap
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMap_Mirror>(Ptr + 84);

    /// <summary>
    /// StructProperty: ObjectMap
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMap_Mirror ObjectMap
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMap_Mirror>(Ptr + 156);

    /// <summary>
    /// ArrayProperty: ValueArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ValueArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: ObjectArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.JsonObject> ObjectArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.JsonObject>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
}
