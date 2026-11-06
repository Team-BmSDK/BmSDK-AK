#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieWorldMap3D<br/>
/// (size = 1148)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieWorldMap3D : BmSDK.BmGame.RGFxMovieWorldBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieWorldMap3D", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieWorldMap3D.
    /// </summary>
    public static RGFxMovieWorldMap3D DefaultObject => (RGFxMovieWorldMap3D)StaticClass().DefaultObject;

    internal RGFxMovieWorldMap3D() { }

    /// <summary>
    /// Constructs a new RGFxMovieWorldMap3D
    /// </summary>
    public RGFxMovieWorldMap3D(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieWorldMap3D Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieWorldMap3D(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieWorldMap3D>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieWorldMap3D>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieWorldMap3D>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieWorldMap3D>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieWorldMap3D>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieWorldMap3D>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieWorldMap3D>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieWorldMap3D>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_XI_GetMedalCount;
    /// <summary>
    /// Function: XI_GetMedalCount
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetMedalCount(BmSDK.FString IconInstanceName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetMedalCount, "BmGame.RGFxMovieWorldMap3D.XI_GetMedalCount");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconInstanceName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetARChallengeMedalCount;
    /// <summary>
    /// Function: GetARChallengeMedalCount
    /// </summary>
    public unsafe virtual int GetARChallengeMedalCount(BmSDK.FString IconInstanceName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetARChallengeMedalCount, "BmGame.RGFxMovieWorldMap3D.GetARChallengeMedalCount");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconInstanceName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_XI_GetDroneDifficulty;
    /// <summary>
    /// Function: XI_GetDroneDifficulty
    /// </summary>
    public unsafe virtual BmSDK.FString XI_GetDroneDifficulty(BmSDK.FString IconInstanceName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_GetDroneDifficulty, "BmGame.RGFxMovieWorldMap3D.XI_GetDroneDifficulty");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconInstanceName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CalcRoute;
    /// <summary>
    /// Function: CalcRoute
    /// </summary>
    public unsafe virtual bool CalcRoute()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcRoute, "BmGame.RGFxMovieWorldMap3D.CalcRoute");
        byte* paramsPtr = stackalloc byte[204];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SendRouteToGame;
    /// <summary>
    /// Function: SendRouteToGame
    /// </summary>
    public unsafe virtual void SendRouteToGame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendRouteToGame, "BmGame.RGFxMovieWorldMap3D.SendRouteToGame");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRouteEnd;
    /// <summary>
    /// Function: SetRouteEnd
    /// </summary>
    public unsafe virtual void SetRouteEnd(BmSDK.FString WaypointName, System.Numerics.Vector3 pos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRouteEnd, "BmGame.RGFxMovieWorldMap3D.SetRouteEnd");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaypointName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRouteStart;
    /// <summary>
    /// Function: SetRouteStart
    /// </summary>
    public unsafe virtual void SetRouteStart(System.Numerics.Vector3 pos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRouteStart, "BmGame.RGFxMovieWorldMap3D.SetRouteStart");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsIconInGas;
    /// <summary>
    /// Function: IsIconInGas
    /// </summary>
    public unsafe virtual bool IsIconInGas(int IconIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsIconInGas, "BmGame.RGFxMovieWorldMap3D.IsIconInGas");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetSelectedItemIndex;
    /// <summary>
    /// Function: GetSelectedItemIndex
    /// </summary>
    public unsafe virtual int GetSelectedItemIndex()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSelectedItemIndex, "BmGame.RGFxMovieWorldMap3D.GetSelectedItemIndex");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearIconNewFor;
    /// <summary>
    /// Function: ClearIconNewFor
    /// </summary>
    public unsafe virtual int ClearIconNewFor(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearIconNewFor, "BmGame.RGFxMovieWorldMap3D.ClearIconNewFor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ProjectIcons;
    /// <summary>
    /// Function: ProjectIcons
    /// </summary>
    public unsafe virtual void ProjectIcons(BmSDK.BmGame.RGFxWorldMovieActorMap3D Actor, BmSDK.Engine.Canvas Canvas, bool bDebugEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectIcons, "BmGame.RGFxMovieWorldMap3D.ProjectIcons");
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugEnabled, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateLocalCustomPosition;
    /// <summary>
    /// Function: UpdateLocalCustomPosition
    /// </summary>
    public unsafe virtual void UpdateLocalCustomPosition(float X, float Y, float Z)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLocalCustomPosition, "BmGame.RGFxMovieWorldMap3D.UpdateLocalCustomPosition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMapIsMoving;
    /// <summary>
    /// Function: SetMapIsMoving
    /// </summary>
    public unsafe virtual void SetMapIsMoving(bool bMoving)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMapIsMoving, "BmGame.RGFxMovieWorldMap3D.SetMapIsMoving");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMoving, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCameraAngles;
    /// <summary>
    /// Function: SetCameraAngles
    /// </summary>
    public unsafe virtual void SetCameraAngles(float CurrentX, float CurrentY, float CurrentZ, float CurrentRotation, float CurrentElevation, float CurrentDistance, int CityArea)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraAngles, "BmGame.RGFxMovieWorldMap3D.SetCameraAngles");
        byte* paramsPtr = stackalloc byte[28];
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

    private static BmSDK.Function __fn_SetIconState;
    /// <summary>
    /// Function: SetIconState
    /// </summary>
    public unsafe virtual void SetIconState(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIconState, "BmGame.RGFxMovieWorldMap3D.SetIconState");
        byte* paramsPtr = stackalloc byte[4];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeIconFilter, "BmGame.RGFxMovieWorldMap3D.ChangeIconFilter");
        byte* paramsPtr = stackalloc byte[4];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActiveFilters, "BmGame.RGFxMovieWorldMap3D.GetActiveFilters");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetUserMarker;
    /// <summary>
    /// Function: SetUserMarker
    /// </summary>
    public unsafe virtual void SetUserMarker(bool bVisible, bool bOnIcon, float atX, float atY, float atZ, BmSDK.FString WaypointName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUserMarker, "BmGame.RGFxMovieWorldMap3D.SetUserMarker");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnIcon, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaypointName, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__SetUserMarker;
    /// <summary>
    /// Function: _SetUserMarker
    /// </summary>
    public unsafe virtual void _SetUserMarker(bool bVisible, bool bOnIcon, float atX, float atY, float atZ, float atZBase)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__SetUserMarker, "BmGame.RGFxMovieWorldMap3D._SetUserMarker");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnIcon, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZBase, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartOutro;
    /// <summary>
    /// Function: StartOutro
    /// </summary>
    public unsafe virtual void StartOutro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartOutro, "BmGame.RGFxMovieWorldMap3D.StartOutro");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleObjectivesSelected;
    /// <summary>
    /// Function: ToggleObjectivesSelected
    /// </summary>
    public unsafe virtual void ToggleObjectivesSelected()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleObjectivesSelected, "BmGame.RGFxMovieWorldMap3D.ToggleObjectivesSelected");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__ToggleObjectivesSelected;
    /// <summary>
    /// Function: _ToggleObjectivesSelected
    /// </summary>
    public unsafe virtual void _ToggleObjectivesSelected(bool bEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__ToggleObjectivesSelected, "BmGame.RGFxMovieWorldMap3D._ToggleObjectivesSelected");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateIcons;
    /// <summary>
    /// Function: CreateIcons
    /// </summary>
    public unsafe virtual void CreateIcons()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateIcons, "BmGame.RGFxMovieWorldMap3D.CreateIcons");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FetchEvidenceTrailIcons;
    /// <summary>
    /// Function: FetchEvidenceTrailIcons
    /// </summary>
    public unsafe virtual void FetchEvidenceTrailIcons()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchEvidenceTrailIcons, "BmGame.RGFxMovieWorldMap3D.FetchEvidenceTrailIcons");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FetchThreeDeeTargets;
    /// <summary>
    /// Function: FetchThreeDeeTargets
    /// </summary>
    public unsafe virtual void FetchThreeDeeTargets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchThreeDeeTargets, "BmGame.RGFxMovieWorldMap3D.FetchThreeDeeTargets");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FetchMultipleMobileObjectives;
    /// <summary>
    /// Function: FetchMultipleMobileObjectives
    /// </summary>
    public unsafe virtual void FetchMultipleMobileObjectives()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchMultipleMobileObjectives, "BmGame.RGFxMovieWorldMap3D.FetchMultipleMobileObjectives");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FetchTrackedVehicle;
    /// <summary>
    /// Function: FetchTrackedVehicle
    /// </summary>
    public unsafe virtual void FetchTrackedVehicle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchTrackedVehicle, "BmGame.RGFxMovieWorldMap3D.FetchTrackedVehicle");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRemapIndex;
    /// <summary>
    /// Function: GetRemapIndex
    /// </summary>
    public unsafe virtual int GetRemapIndex()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRemapIndex, "BmGame.RGFxMovieWorldMap3D.GetRemapIndex");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldHideBuildingMarker;
    /// <summary>
    /// Function: ShouldHideBuildingMarker
    /// </summary>
    public unsafe virtual bool ShouldHideBuildingMarker(BmSDK.FString ItemName, int X, int Y, int Z, int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldHideBuildingMarker, "BmGame.RGFxMovieWorldMap3D.ShouldHideBuildingMarker");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_BuildIndexListOfMapObj;
    /// <summary>
    /// Function: BuildIndexListOfMapObj
    /// </summary>
    public unsafe virtual void BuildIndexListOfMapObj()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildIndexListOfMapObj, "BmGame.RGFxMovieWorldMap3D.BuildIndexListOfMapObj");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Setup;
    /// <summary>
    /// Function: Setup
    /// </summary>
    public unsafe virtual void Setup(System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Setup, "BmGame.RGFxMovieWorldMap3D.Setup");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBaseLocation;
    /// <summary>
    /// Function: GetBaseLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBaseLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBaseLocation, "BmGame.RGFxMovieWorldMap3D.GetBaseLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddIconsForMapArea;
    /// <summary>
    /// Function: AddIconsForMapArea
    /// </summary>
    public unsafe virtual void AddIconsForMapArea(BmSDK.FString MapName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddIconsForMapArea, "BmGame.RGFxMovieWorldMap3D.AddIconsForMapArea");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddIconAt;
    /// <summary>
    /// Function: AddIconAt
    /// </summary>
    public unsafe virtual void AddIconAt(BmSDK.FString TypeName, BmSDK.FString instancename, int X, int Y, int Z, int Rot, int FloatUpBy, int FilterId, int GroupArea, int GroupRange, BmSDK.FString CustomFlags, int Flags, bool bNew = default, bool bGas = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddIconAt, "BmGame.RGFxMovieWorldMap3D.AddIconAt");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TypeName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(instancename, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FloatUpBy, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FilterId, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupArea, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupRange, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomFlags, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Flags, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNew, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGas, paramsPtr + 88);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieWorldMap3D.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGasState;
    /// <summary>
    /// Function: IsGasState
    /// </summary>
    public unsafe virtual bool IsGasState(BmSDK.FString ItemType, float X, float Y, float Z)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGasState, "BmGame.RGFxMovieWorldMap3D.IsGasState");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// StructProperty: BaseLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BaseLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 696);

    /// <summary>
    /// StructProperty: Offset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Offset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 708);

    /// <summary>
    /// ObjectProperty: RGI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo RGI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: GRI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: pData
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData pData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: PDD
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentDebugData PDD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// IntProperty: SelectedIconIndex
    /// </summary>
    public unsafe int SelectedIconIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StrProperty: RemapIconType
    /// </summary>
    public unsafe BmSDK.FString RemapIconType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// StrProperty: RemapIconName
    /// </summary>
    public unsafe BmSDK.FString RemapIconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: Icon_TypeName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Icon_TypeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ArrayProperty: Icon_InstanceName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Icon_InstanceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ArrayProperty: Icon_X
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_X
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Y
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Y
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Z
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Z
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: Icon_ZBase
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_ZBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Rotation
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: Icon_GroupRange
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_GroupRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ArrayProperty: Icon_GroupArea
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_GroupArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Flags
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Flags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: Icon_CustomFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Icon_CustomFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Clipping
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Clipping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Scale
    /// </summary>
    public unsafe BmSDK.TArray<float> Icon_Scale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Filter
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Filter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ArrayProperty: MapObjIndexList
    /// </summary>
    public unsafe BmSDK.TArray<int> MapObjIndexList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: RemapListItem
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RemapListItem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ArrayProperty: RemapListItemOther
    /// </summary>
    public unsafe BmSDK.TArray<int> RemapListItemOther
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// IntProperty: FilterMask
    /// </summary>
    public unsafe int FilterMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: ActiveFilter
    /// </summary>
    public unsafe int ActiveFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// StructProperty: StatNavStart
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StatNavStart
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1068);

    /// <summary>
    /// StructProperty: StatNavEnd
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StatNavEnd
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1080);

    /// <summary>
    /// ArrayProperty: SatNavRoute
    /// </summary>
    public unsafe BmSDK.TArray<int> SatNavRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// IntProperty: SatNavRouteStartPoint
    /// </summary>
    public unsafe int SatNavRouteStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// BoolProperty: bMapMoving
    /// </summary>
    public unsafe bool bMapMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bMapSelectionDisabled
    /// </summary>
    public unsafe bool bMapSelectionDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bLockedInBatmobile
    /// </summary>
    public unsafe bool bLockedInBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bSideStoriesDisabled
    /// </summary>
    public unsafe bool bSideStoriesDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bGasActive
    /// </summary>
    public unsafe bool bGasActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bGCPDAssualt
    /// </summary>
    public unsafe bool bGCPDAssualt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bMissionBundleInstalled
    /// </summary>
    public unsafe bool bMissionBundleInstalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// StrProperty: ActiveMissionName
    /// </summary>
    public unsafe BmSDK.FString ActiveMissionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// FloatProperty: CameraRotation
    /// </summary>
    public unsafe float CameraRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: CameraX
    /// </summary>
    public unsafe float CameraX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: CameraY
    /// </summary>
    public unsafe float CameraY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: CameraZ
    /// </summary>
    public unsafe float CameraZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }
}
