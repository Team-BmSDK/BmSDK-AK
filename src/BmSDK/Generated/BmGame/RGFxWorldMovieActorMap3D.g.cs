#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxWorldMovieActorMap3D<br/>
/// (size = 720)
/// (flags = 10485778)
/// </summary>
public partial class RGFxWorldMovieActorMap3D : BmSDK.BmGame.RGFxWorldMovieActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxWorldMovieActorMap3D", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxWorldMovieActorMap3D.
    /// </summary>
    public static RGFxWorldMovieActorMap3D DefaultObject => (RGFxWorldMovieActorMap3D)StaticClass().DefaultObject;

    internal RGFxWorldMovieActorMap3D() { }

    /// <summary>
    /// Constructs a new RGFxWorldMovieActorMap3D
    /// </summary>
    public RGFxWorldMovieActorMap3D(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxWorldMovieActorMap3D(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxWorldMovieActorMap3D>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxWorldMovieActorMap3D>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxWorldMovieActorMap3D>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxWorldMovieActorMap3D>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxWorldMovieActorMap3D>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxWorldMovieActorMap3D>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxWorldMovieActorMap3D>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxWorldMovieActorMap3D>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CalcRoute;
    /// <summary>
    /// Function: CalcRoute
    /// </summary>
    public unsafe virtual bool CalcRoute(bool bEnabled, BmSDK.FString WaypointName, float X, float Y, float Z)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcRoute, "BmGame.RGFxWorldMovieActorMap3D.CalcRoute");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaypointName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_SetMapIsMoving;
    /// <summary>
    /// Function: SetMapIsMoving
    /// </summary>
    public unsafe virtual void SetMapIsMoving(bool bMoving)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMapIsMoving, "BmGame.RGFxWorldMovieActorMap3D.SetMapIsMoving");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMoving, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIconState;
    /// <summary>
    /// Function: SetIconState
    /// </summary>
    public unsafe virtual void SetIconState(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIconState, "BmGame.RGFxWorldMovieActorMap3D.SetIconState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeIconFilter;
    /// <summary>
    /// Function: ChangeIconFilter
    /// </summary>
    public unsafe virtual void ChangeIconFilter(int FilterId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeIconFilter, "BmGame.RGFxWorldMovieActorMap3D.ChangeIconFilter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FilterId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetActiveFilters;
    /// <summary>
    /// Function: GetActiveFilters
    /// </summary>
    public unsafe virtual BmSDK.TArray<int> GetActiveFilters()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActiveFilters, "BmGame.RGFxWorldMovieActorMap3D.GetActiveFilters");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetUserMarker;
    /// <summary>
    /// Function: SetUserMarker
    /// </summary>
    public unsafe virtual void SetUserMarker(bool bVisible, bool bOnIcon, float atX, float atY, float atZ, BmSDK.FString WaypointName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUserMarker, "BmGame.RGFxWorldMovieActorMap3D.SetUserMarker");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnIcon, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaypointName, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBaseLocation;
    /// <summary>
    /// Function: GetBaseLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBaseLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBaseLocation, "BmGame.RGFxWorldMovieActorMap3D.GetBaseLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCameraAngles;
    /// <summary>
    /// Function: SetCameraAngles
    /// </summary>
    public unsafe virtual void SetCameraAngles(float CurrentX, float CurrentY, float CurrentZ, float CurrentRotation, float CurrentElevation, float CurrentDistance, int CityArea)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraAngles, "BmGame.RGFxWorldMovieActorMap3D.SetCameraAngles");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentZ, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentElevation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentDistance, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CityArea, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreRender;
    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe virtual void PreRender(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreRender, "BmGame.RGFxWorldMovieActorMap3D.PreRender");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDebugMode;
    /// <summary>
    /// Function: SetDebugMode
    /// </summary>
    public unsafe virtual void SetDebugMode(bool bEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDebugMode, "BmGame.RGFxWorldMovieActorMap3D.SetDebugMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RGFxWorldMovieActorMap3D.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RGFxWorldMovieActorMap3D.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: RoadComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RMap3DRoadComponent RoadComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMap3DRoadComponent>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: GFxMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieWorldMap3D GFxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieWorldMap3D>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: bDebugMode
    /// </summary>
    public unsafe bool bDebugMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 716); }
    }
}
