#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPickupBaseBase<br/>
/// (size = 668)
/// (flags = 144703635)
/// </summary>
public partial class RPickupBaseBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPickupBaseBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPickupBaseBase.
    /// </summary>
    public static RPickupBaseBase DefaultObject => (RPickupBaseBase)StaticClass().DefaultObject;

    internal RPickupBaseBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPickupBaseBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPickupBaseBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPickupBaseBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPickupBaseBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPickupBaseBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPickupBaseBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPickupBaseBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPickupBaseBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPickupBaseBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetScannedStringDesc;
    /// <summary>
    /// Function: GetScannedStringDesc
    /// </summary>
    public unsafe virtual BmSDK.FString GetScannedStringDesc(bool bAlreadyTagged)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScannedStringDesc, "BmGame.RPickupBaseBase.GetScannedStringDesc");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlreadyTagged, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetScannedStringTitle;
    /// <summary>
    /// Function: GetScannedStringTitle
    /// </summary>
    public unsafe virtual BmSDK.FString GetScannedStringTitle(bool bAlreadyTagged)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScannedStringTitle, "BmGame.RPickupBaseBase.GetScannedStringTitle");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlreadyTagged, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetScanDistMax;
    /// <summary>
    /// Function: GetScanDistMax
    /// </summary>
    public unsafe virtual float GetScanDistMax()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScanDistMax, "BmGame.RPickupBaseBase.GetScanDistMax");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRiddlerPieceType;
    /// <summary>
    /// Function: GetRiddlerPieceType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.ERiddlerPiece GetRiddlerPieceType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerPieceType, "BmGame.RPickupBaseBase.GetRiddlerPieceType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.ERiddlerPiece>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetIgnoreRayTrace;
    /// <summary>
    /// Function: GetIgnoreRayTrace
    /// </summary>
    public unsafe virtual bool GetIgnoreRayTrace()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIgnoreRayTrace, "BmGame.RPickupBaseBase.GetIgnoreRayTrace");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetScanLocationOffset;
    /// <summary>
    /// Function: GetScanLocationOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetScanLocationOffset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScanLocationOffset, "BmGame.RPickupBaseBase.GetScanLocationOffset");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLocationOffset;
    /// <summary>
    /// Function: GetLocationOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLocationOffset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocationOffset, "BmGame.RPickupBaseBase.GetLocationOffset");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GenerateScanEvent;
    /// <summary>
    /// Function: GenerateScanEvent
    /// </summary>
    public unsafe virtual void GenerateScanEvent(BmSDK.BmGame.RPlayerController RPC, bool Rescanned)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateScanEvent, "BmGame.RPickupBaseBase.GenerateScanEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rescanned, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanScanAndAddToMap;
    /// <summary>
    /// Function: CanScanAndAddToMap
    /// </summary>
    public unsafe virtual bool CanScanAndAddToMap()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanScanAndAddToMap, "BmGame.RPickupBaseBase.CanScanAndAddToMap");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasBeenPickedUp;
    /// <summary>
    /// Function: HasBeenPickedUp
    /// </summary>
    public unsafe virtual bool HasBeenPickedUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBeenPickedUp, "BmGame.RPickupBaseBase.HasBeenPickedUp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPickedUpName;
    /// <summary>
    /// Function: GetPickedUpName
    /// </summary>
    public unsafe virtual BmSDK.FString GetPickedUpName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPickedUpName, "BmGame.RPickupBaseBase.GetPickedUpName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMapVisibleName;
    /// <summary>
    /// Function: GetMapVisibleName
    /// </summary>
    public unsafe virtual BmSDK.FString GetMapVisibleName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMapVisibleName, "BmGame.RPickupBaseBase.GetMapVisibleName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }
}
