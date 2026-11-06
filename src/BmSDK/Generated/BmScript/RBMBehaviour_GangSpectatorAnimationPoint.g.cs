#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_GangSpectatorAnimationPoint<br/>
/// (size = 952)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_GangSpectatorAnimationPoint : BmSDK.BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_GangSpectatorAnimationPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBehaviour_GangSpectatorAnimationPoint.
    /// </summary>
    public static RBMBehaviour_GangSpectatorAnimationPoint DefaultObject => (RBMBehaviour_GangSpectatorAnimationPoint)StaticClass().DefaultObject;

    internal RBMBehaviour_GangSpectatorAnimationPoint() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_GangSpectatorAnimationPoint
    /// </summary>
    public RBMBehaviour_GangSpectatorAnimationPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_GangSpectatorAnimationPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_GangSpectatorAnimationPoint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangSpectatorAnimationPoint>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangSpectatorAnimationPoint>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangSpectatorAnimationPoint>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangSpectatorAnimationPoint>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangSpectatorAnimationPoint>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangSpectatorAnimationPoint>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangSpectatorAnimationPoint>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_GangSpectatorAnimationPoint>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.RBMBehaviour_GangSpectatorAnimationPoint.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Cheer;
    /// <summary>
    /// Function: Cheer
    /// </summary>
    public unsafe virtual void Cheer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Cheer, "BmScript.RBMBehaviour_GangSpectatorAnimationPoint.Cheer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAnimationInAnyDirection;
    /// <summary>
    /// Function: StartAnimationInAnyDirection
    /// </summary>
    public unsafe override bool StartAnimationInAnyDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAnimationInAnyDirection, "BmScript.RBMBehaviour_GangSpectatorAnimationPoint.StartAnimationInAnyDirection");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCustomAnyDirectionAnimSettings;
    /// <summary>
    /// Function: SetCustomAnyDirectionAnimSettings
    /// </summary>
    public unsafe override void SetCustomAnyDirectionAnimSettings(BmSDK.FName PrevState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomAnyDirectionAnimSettings, "BmScript.RBMBehaviour_GangSpectatorAnimationPoint.SetCustomAnyDirectionAnimSettings");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWatchingPOILocation;
    /// <summary>
    /// Function: GetWatchingPOILocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetWatchingPOILocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWatchingPOILocation, "BmScript.RBMBehaviour_GangSpectatorAnimationPoint.GetWatchingPOILocation");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SuggestPOI;
    /// <summary>
    /// Function: SuggestPOI
    /// </summary>
    public unsafe virtual bool SuggestPOI(BmSDK.BmGame.RGangInteractPointBase SuggestedPOI)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuggestPOI, "BmScript.RBMBehaviour_GangSpectatorAnimationPoint.SuggestPOI");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SuggestedPOI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_POIStillValid;
    /// <summary>
    /// Function: POIStillValid
    /// </summary>
    public unsafe virtual bool POIStillValid()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_POIStillValid, "BmScript.RBMBehaviour_GangSpectatorAnimationPoint.POIStillValid");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmScript.RBMBehaviour_GangSpectatorAnimationPoint.OnActivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bHasFollowed
    /// </summary>
    public unsafe bool bHasFollowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }
}
