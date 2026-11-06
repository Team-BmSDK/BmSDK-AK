#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: MaterialInterface<br/>
/// (size = 132)
/// (flags = 134217875)
/// </summary>
public partial class MaterialInterface : BmSDK.Engine.Surface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MaterialInterface.
    /// </summary>
    public static MaterialInterface DefaultObject => (MaterialInterface)StaticClass().DefaultObject;

    internal MaterialInterface() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialInterface(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialInterface>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialInterface>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialInterface>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialInterface>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialInterface>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialInterface>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialInterface>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialInterface>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetPrestreamMipLevels;
    /// <summary>
    /// Function: SetPrestreamMipLevels
    /// </summary>
    public unsafe virtual void SetPrestreamMipLevels(float ForceDuration, bool FullMips, bool HighPriority, bool GentleLastRenderTimeHint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrestreamMipLevels, "Engine.MaterialInterface.SetPrestreamMipLevels");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceDuration, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FullMips, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighPriority, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GentleLastRenderTimeHint, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetForceMipLevelsToBeResident;
    /// <summary>
    /// Function: SetForceMipLevelsToBeResident
    /// </summary>
    public unsafe virtual void SetForceMipLevelsToBeResident(bool OverrideForceMiplevelsToBeResident, bool bForceMiplevelsToBeResidentValue, float ForceDuration, int CinematicTextureGroups = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForceMipLevelsToBeResident, "Engine.MaterialInterface.SetForceMipLevelsToBeResident");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideForceMiplevelsToBeResident, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceMiplevelsToBeResidentValue, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceDuration, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicTextureGroups, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetMobileVectorParameterValue;
    /// <summary>
    /// Function: GetMobileVectorParameterValue
    /// </summary>
    public unsafe virtual bool GetMobileVectorParameterValue(BmSDK.FName ParameterName, out BmSDK.GameObject.FLinearColor OutValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMobileVectorParameterValue, "Engine.MaterialInterface.GetMobileVectorParameterValue");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutValue);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutValue, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FLinearColor>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetMobileTextureParameterValue;
    /// <summary>
    /// Function: GetMobileTextureParameterValue
    /// </summary>
    public unsafe virtual bool GetMobileTextureParameterValue(BmSDK.FName ParameterName, out BmSDK.Engine.Texture OutValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMobileTextureParameterValue, "Engine.MaterialInterface.GetMobileTextureParameterValue");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutValue);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutValue, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Texture>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetMobileScalarParameterValue;
    /// <summary>
    /// Function: GetMobileScalarParameterValue
    /// </summary>
    public unsafe virtual bool GetMobileScalarParameterValue(BmSDK.FName ParameterName, out float OutValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMobileScalarParameterValue, "Engine.MaterialInterface.GetMobileScalarParameterValue");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutValue);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutValue, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetGroupName;
    /// <summary>
    /// Function: GetGroupName
    /// </summary>
    public unsafe virtual bool GetGroupName(BmSDK.FName ParameterName, out BmSDK.FName GroupName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGroupName, "Engine.MaterialInterface.GetGroupName");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out GroupName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupName, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        GroupName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetLinearColorCurveParameterValue;
    /// <summary>
    /// Function: GetLinearColorCurveParameterValue
    /// </summary>
    public unsafe virtual bool GetLinearColorCurveParameterValue(BmSDK.FName ParameterName, out BmSDK.GameObject.FInterpCurveLinearColor OutValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLinearColorCurveParameterValue, "Engine.MaterialInterface.GetLinearColorCurveParameterValue");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FInterpCurveLinearColor>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetLinearColorParameterValue;
    /// <summary>
    /// Function: GetLinearColorParameterValue
    /// </summary>
    public unsafe virtual bool GetLinearColorParameterValue(BmSDK.FName ParameterName, out BmSDK.GameObject.FLinearColor OutValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLinearColorParameterValue, "Engine.MaterialInterface.GetLinearColorParameterValue");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutValue);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutValue, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FLinearColor>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetVectorCurveParameterValue;
    /// <summary>
    /// Function: GetVectorCurveParameterValue
    /// </summary>
    public unsafe virtual bool GetVectorCurveParameterValue(BmSDK.FName ParameterName, out BmSDK.GameObject.FInterpCurveVector OutValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVectorCurveParameterValue, "Engine.MaterialInterface.GetVectorCurveParameterValue");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FInterpCurveVector>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetVectorParameterValue;
    /// <summary>
    /// Function: GetVectorParameterValue
    /// </summary>
    public unsafe virtual bool GetVectorParameterValue(BmSDK.FName ParameterName, out BmSDK.GameObject.FLinearColor OutValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVectorParameterValue, "Engine.MaterialInterface.GetVectorParameterValue");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutValue);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutValue, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FLinearColor>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetTextureParameterValue;
    /// <summary>
    /// Function: GetTextureParameterValue
    /// </summary>
    public unsafe virtual bool GetTextureParameterValue(BmSDK.FName ParameterName, out BmSDK.Engine.Texture OutValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTextureParameterValue, "Engine.MaterialInterface.GetTextureParameterValue");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutValue);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutValue, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Texture>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetScalarCurveParameterValue;
    /// <summary>
    /// Function: GetScalarCurveParameterValue
    /// </summary>
    public unsafe virtual bool GetScalarCurveParameterValue(BmSDK.FName ParameterName, out BmSDK.GameObject.FInterpCurveFloat OutValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScalarCurveParameterValue, "Engine.MaterialInterface.GetScalarCurveParameterValue");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FInterpCurveFloat>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetScalarParameterValue;
    /// <summary>
    /// Function: GetScalarParameterValue
    /// </summary>
    public unsafe virtual bool GetScalarParameterValue(BmSDK.FName ParameterName, out float OutValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScalarParameterValue, "Engine.MaterialInterface.GetScalarParameterValue");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutValue);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutValue, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetFontParameterValue;
    /// <summary>
    /// Function: GetFontParameterValue
    /// </summary>
    public unsafe virtual bool GetFontParameterValue(BmSDK.FName ParameterName, out BmSDK.Engine.Font OutFontValue, out int OutFontPage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFontParameterValue, "Engine.MaterialInterface.GetFontParameterValue");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutFontValue);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutFontValue, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutFontPage);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutFontPage, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutFontValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Font>(paramsPtr + 8);
        OutFontPage = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetParameterDesc;
    /// <summary>
    /// Function: GetParameterDesc
    /// </summary>
    public unsafe virtual bool GetParameterDesc(BmSDK.FName ParameterName, out BmSDK.FString OutDesc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetParameterDesc, "Engine.MaterialInterface.GetParameterDesc");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParameterName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutDesc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetPhysicalMaterial;
    /// <summary>
    /// Function: GetPhysicalMaterial
    /// </summary>
    public unsafe virtual BmSDK.Engine.PhysicalMaterial GetPhysicalMaterial()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPhysicalMaterial, "Engine.MaterialInterface.GetPhysicalMaterial");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PhysicalMaterial>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaterial;
    /// <summary>
    /// Function: GetMaterial
    /// </summary>
    public unsafe virtual BmSDK.Engine.Material GetMaterial()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaterial, "Engine.MaterialInterface.GetMaterial");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Material>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FLightmassMaterialInterfaceSettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FLightmassMaterialInterfaceSettings
    {
        /// <summary>
        /// BoolProperty: bCastShadowAsMasked
        /// </summary>
        public unsafe bool bCastShadowAsMasked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: EmissiveBoost
        /// </summary>
        public unsafe float EmissiveBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: DiffuseBoost
        /// </summary>
        public unsafe float DiffuseBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: SpecularBoost
        /// </summary>
        public unsafe float SpecularBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: ExportResolutionScale
        /// </summary>
        public unsafe float ExportResolutionScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: DistanceFieldPenumbraScale
        /// </summary>
        public unsafe float DistanceFieldPenumbraScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bOverrideCastShadowAsMasked
        /// </summary>
        public unsafe bool bOverrideCastShadowAsMasked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bOverrideEmissiveBoost
        /// </summary>
        public unsafe bool bOverrideEmissiveBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bOverrideDiffuseBoost
        /// </summary>
        public unsafe bool bOverrideDiffuseBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bOverrideSpecularBoost
        /// </summary>
        public unsafe bool bOverrideSpecularBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bOverrideExportResolutionScale
        /// </summary>
        public unsafe bool bOverrideExportResolutionScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bOverrideDistanceFieldPenumbraScale
        /// </summary>
        public unsafe bool bOverrideDistanceFieldPenumbraScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// StructProperty: ParentRefFence
    /// </summary>
    public unsafe ref BmSDK.GameObject.FRenderCommandFence_Mirror ParentRefFence
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FRenderCommandFence_Mirror>(Ptr + 84);

    /// <summary>
    /// ObjectProperty: PhysMaterial
    /// </summary>
    public unsafe BmSDK.Engine.PhysicalMaterial PhysMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// StrProperty: PreviewMesh
    /// </summary>
    public unsafe BmSDK.FString PreviewMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: LightingGuid
    /// </summary>
    public unsafe ref BmSDK.GameObject.FGuid LightingGuid
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FGuid>(Ptr + 112);

    /// <summary>
    /// BoolProperty: bHasQualitySwitch
    /// </summary>
    public unsafe bool bHasQualitySwitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bEnableDecalCollision
    /// </summary>
    public unsafe bool bEnableDecalCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// Enum: EMaterialUsage
    /// </summary>
    public enum EMaterialUsage : byte
    {
        MATUSAGE_SkeletalMesh = 0,
        MATUSAGE_FracturedMeshes = 1,
        MATUSAGE_ParticleSprites = 2,
        MATUSAGE_BeamTrails = 3,
        MATUSAGE_ParticleSubUV = 4,
        MATUSAGE_SpeedTree = 5,
        MATUSAGE_StaticLighting = 6,
        MATUSAGE_GammaCorrection = 7,
        MATUSAGE_LensFlare = 8,
        MATUSAGE_InstancedMeshParticles = 9,
        MATUSAGE_FluidSurface = 10,
        MATUSAGE_RockDecals = 11,
        MATUSAGE_Decals = 12,
        MATUSAGE_MaterialEffect = 13,
        MATUSAGE_MorphTargets = 14,
        MATUSAGE_FogVolumes = 15,
        MATUSAGE_StaticModulatedShadows = 16,
        MATUSAGE_PerVertexRockAtmosFog = 17,
        MATUSAGE_LightEnvironments = 18,
        MATUSAGE_StaticMesh = 19,
        MATUSAGE_RadialBlur = 20,
        MATUSAGE_InstancedMeshes = 21,
        MATUSAGE_SplineMesh = 22,
        MATUSAGE_ScreenDoorFade = 23,
        MATUSAGE_APEXMesh = 24,
        MATUSAGE_APEXClothing = 25,
        MATUSAGE_Terrain = 26,
        MATUSAGE_Landscape = 27,
        MATUSAGE_VTF = 28,
        MATUSAGE_DirectionalLights = 29,
        MATUSAGE_SpotLights = 30,
        MATUSAGE_PointLights = 31,
        MATUSAGE_HitMasks = 32,
        MATUSAGE_ParticleGPU = 33,
        MATUSAGE_OpacityShadows = 34,
        MATUSAGE_MAX = 35,
    }
}
