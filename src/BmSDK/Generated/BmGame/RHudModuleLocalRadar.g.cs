#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleLocalRadar<br/>
/// (size = 596)
/// (flags = 134217874)
/// </summary>
public partial class RHudModuleLocalRadar : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleLocalRadar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudModuleLocalRadar.
    /// </summary>
    public static RHudModuleLocalRadar DefaultObject => (RHudModuleLocalRadar)StaticClass().DefaultObject;

    internal RHudModuleLocalRadar() { }

    /// <summary>
    /// Constructs a new RHudModuleLocalRadar
    /// </summary>
    public RHudModuleLocalRadar(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleLocalRadar Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleLocalRadar(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleLocalRadar>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleLocalRadar>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleLocalRadar>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleLocalRadar>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleLocalRadar>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleLocalRadar>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleLocalRadar>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleLocalRadar>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetMaskEnormous;
    /// <summary>
    /// Function: SetMaskEnormous
    /// </summary>
    public unsafe virtual void SetMaskEnormous(bool enormous)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaskEnormous, "BmGame.RHudModuleLocalRadar.SetMaskEnormous");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(enormous, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRootsPermanentlyVisible;
    /// <summary>
    /// Function: SetRootsPermanentlyVisible
    /// </summary>
    public unsafe virtual void SetRootsPermanentlyVisible(bool make_visible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRootsPermanentlyVisible, "BmGame.RHudModuleLocalRadar.SetRootsPermanentlyVisible");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(make_visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoPulsePrivate;
    /// <summary>
    /// Function: DoPulsePrivate
    /// </summary>
    public unsafe virtual void DoPulsePrivate(float time_extra)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPulsePrivate, "BmGame.RHudModuleLocalRadar.DoPulsePrivate");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(time_extra, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoPulse;
    /// <summary>
    /// Function: DoPulse
    /// </summary>
    public unsafe virtual void DoPulse(float proportion_extra)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPulse, "BmGame.RHudModuleLocalRadar.DoPulse");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(proportion_extra, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRootNetworkOpacity;
    /// <summary>
    /// Function: SetRootNetworkOpacity
    /// </summary>
    public unsafe virtual void SetRootNetworkOpacity(float _NetworkOpacity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRootNetworkOpacity, "BmGame.RHudModuleLocalRadar.SetRootNetworkOpacity");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_NetworkOpacity, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerPosition;
    /// <summary>
    /// Function: SetPlayerPosition
    /// </summary>
    public unsafe virtual void SetPlayerPosition(float PlayerRotationRadians, float LocationX, float LocationY)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerPosition, "BmGame.RHudModuleLocalRadar.SetPlayerPosition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerRotationRadians, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocationX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocationY, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVisualModePrivate;
    /// <summary>
    /// Function: SetVisualModePrivate
    /// </summary>
    public unsafe virtual void SetVisualModePrivate(bool RadarVisible, bool HeavyTanksVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVisualModePrivate, "BmGame.RHudModuleLocalRadar.SetVisualModePrivate");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RadarVisible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeavyTanksVisible, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVisualModeAuto;
    /// <summary>
    /// Function: SetVisualModeAuto
    /// </summary>
    public unsafe virtual void SetVisualModeAuto()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVisualModeAuto, "BmGame.RHudModuleLocalRadar.SetVisualModeAuto");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRootNetworkPrivate;
    /// <summary>
    /// Function: SetRootNetworkPrivate
    /// </summary>
    public unsafe virtual void SetRootNetworkPrivate(BmSDK.FString RootNetworkString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRootNetworkPrivate, "BmGame.RHudModuleLocalRadar.SetRootNetworkPrivate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RootNetworkString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRootNetwork;
    /// <summary>
    /// Function: SetRootNetwork
    /// </summary>
    public unsafe virtual void SetRootNetwork(BmSDK.FString RootNetworkString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRootNetwork, "BmGame.RHudModuleLocalRadar.SetRootNetwork");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RootNetworkString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushTrackedActorsToFlash;
    /// <summary>
    /// Function: PushTrackedActorsToFlash
    /// </summary>
    public unsafe virtual void PushTrackedActorsToFlash(int Num_Array_Actors, bool DisplayNonVehicleActors = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushTrackedActorsToFlash, "BmGame.RHudModuleLocalRadar.PushTrackedActorsToFlash");
        byte* paramsPtr = stackalloc byte[125];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Num_Array_Actors, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisplayNonVehicleActors, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHeavyTankRadiusPrivate;
    /// <summary>
    /// Function: SetHeavyTankRadiusPrivate
    /// </summary>
    public unsafe virtual void SetHeavyTankRadiusPrivate(float pos_angle, float pos_distance, float radius_scale)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeavyTankRadiusPrivate, "BmGame.RHudModuleLocalRadar.SetHeavyTankRadiusPrivate");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos_angle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos_distance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(radius_scale, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDetailObjectPrivate;
    /// <summary>
    /// Function: SetDetailObjectPrivate
    /// </summary>
    public unsafe virtual void SetDetailObjectPrivate(int obj_index, float pos_angle, float pos_distance, float bearing_rad, int movie_frame)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDetailObjectPrivate, "BmGame.RHudModuleLocalRadar.SetDetailObjectPrivate");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(obj_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos_angle, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos_distance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bearing_rad, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(movie_frame, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExtendObjectArray;
    /// <summary>
    /// Function: ExtendObjectArray
    /// </summary>
    public unsafe virtual void ExtendObjectArray()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExtendObjectArray, "BmGame.RHudModuleLocalRadar.ExtendObjectArray");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushConsolidatedArrayToFlash;
    /// <summary>
    /// Function: PushConsolidatedArrayToFlash
    /// </summary>
    public unsafe virtual void PushConsolidatedArrayToFlash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushConsolidatedArrayToFlash, "BmGame.RHudModuleLocalRadar.PushConsolidatedArrayToFlash");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushActorsToFlashPrivate;
    /// <summary>
    /// Function: PushActorsToFlashPrivate
    /// </summary>
    public unsafe virtual void PushActorsToFlashPrivate(int Num_Actors, bool RadarJammed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushActorsToFlashPrivate, "BmGame.RHudModuleLocalRadar.PushActorsToFlashPrivate");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Num_Actors, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RadarJammed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushFakeActorsToFlash;
    /// <summary>
    /// Function: PushFakeActorsToFlash
    /// </summary>
    public unsafe virtual void PushFakeActorsToFlash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushFakeActorsToFlash, "BmGame.RHudModuleLocalRadar.PushFakeActorsToFlash");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBatmobileRevDisplayActive;
    /// <summary>
    /// Function: SetBatmobileRevDisplayActive
    /// </summary>
    public unsafe virtual void SetBatmobileRevDisplayActive(bool _BatmobileRevDisplayActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmobileRevDisplayActive, "BmGame.RHudModuleLocalRadar.SetBatmobileRevDisplayActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_BatmobileRevDisplayActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHeavyTankTrackingActive;
    /// <summary>
    /// Function: SetHeavyTankTrackingActive
    /// </summary>
    public unsafe virtual void SetHeavyTankTrackingActive(bool _HeavyTankTrackingIsActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeavyTankTrackingActive, "BmGame.RHudModuleLocalRadar.SetHeavyTankTrackingActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_HeavyTankTrackingIsActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVehicleTrackingActive;
    /// <summary>
    /// Function: SetVehicleTrackingActive
    /// </summary>
    public unsafe virtual void SetVehicleTrackingActive(bool _VehicleTrackingIsActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVehicleTrackingActive, "BmGame.RHudModuleLocalRadar.SetVehicleTrackingActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_VehicleTrackingIsActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInBatmobile;
    /// <summary>
    /// Function: SetInBatmobile
    /// </summary>
    public unsafe virtual void SetInBatmobile(bool _InBatmobile)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInBatmobile, "BmGame.RHudModuleLocalRadar.SetInBatmobile");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_InBatmobile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealthValue;
    /// <summary>
    /// Function: SetHealthValue
    /// </summary>
    public unsafe virtual void SetHealthValue(float current_value, bool is_critical = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealthValue, "BmGame.RHudModuleLocalRadar.SetHealthValue");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_critical, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealthTitle;
    /// <summary>
    /// Function: SetHealthTitle
    /// </summary>
    public unsafe virtual void SetHealthTitle(BmSDK.FString health_title)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealthTitle, "BmGame.RHudModuleLocalRadar.SetHealthTitle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(health_title, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLockonValue;
    /// <summary>
    /// Function: SetLockonValue
    /// </summary>
    public unsafe virtual void SetLockonValue(float current_value, float warning_threshold)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLockonValue, "BmGame.RHudModuleLocalRadar.SetLockonValue");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(warning_threshold, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStationaryLockonValue;
    /// <summary>
    /// Function: SetStationaryLockonValue
    /// </summary>
    public unsafe virtual void SetStationaryLockonValue(float current_value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStationaryLockonValue, "BmGame.RHudModuleLocalRadar.SetStationaryLockonValue");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateTargetPositionPrivate;
    /// <summary>
    /// Function: UpdateTargetPositionPrivate
    /// </summary>
    public unsafe virtual void UpdateTargetPositionPrivate(float target_location_angle, float target_location_distance, float target_bearing, int num_tagged_vehicle_points)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTargetPositionPrivate, "BmGame.RHudModuleLocalRadar.UpdateTargetPositionPrivate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_location_angle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_location_distance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_bearing, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(num_tagged_vehicle_points, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushTaggedPoints;
    /// <summary>
    /// Function: PushTaggedPoints
    /// </summary>
    public unsafe virtual void PushTaggedPoints(BmSDK.Engine.Actor TheTarget, float CameraFacingAngle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushTaggedPoints, "BmGame.RHudModuleLocalRadar.PushTaggedPoints");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraFacingAngle, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTargetLocation;
    /// <summary>
    /// Function: SetTargetLocation
    /// </summary>
    public unsafe virtual void SetTargetLocation(BmSDK.Engine.Actor the_target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetLocation, "BmGame.RHudModuleLocalRadar.SetTargetLocation");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_LocalRadarOffscreen;
    /// <summary>
    /// Function: XI_LocalRadarOffscreen
    /// </summary>
    public unsafe virtual void XI_LocalRadarOffscreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_LocalRadarOffscreen, "BmGame.RHudModuleLocalRadar.XI_LocalRadarOffscreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoOutro;
    /// <summary>
    /// Function: DoOutro
    /// </summary>
    public unsafe virtual void DoOutro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoOutro, "BmGame.RHudModuleLocalRadar.DoOutro");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoIntro;
    /// <summary>
    /// Function: DoIntro
    /// </summary>
    public unsafe virtual void DoIntro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoIntro, "BmGame.RHudModuleLocalRadar.DoIntro");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudModuleLocalRadar.Close");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseFlash;
    /// <summary>
    /// Function: InitialiseFlash
    /// </summary>
    public unsafe override void InitialiseFlash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseFlash, "BmGame.RHudModuleLocalRadar.InitialiseFlash");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RadarRangeUpdated;
    /// <summary>
    /// Function: RadarRangeUpdated
    /// </summary>
    public unsafe virtual void RadarRangeUpdated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RadarRangeUpdated, "BmGame.RHudModuleLocalRadar.RadarRangeUpdated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudModuleLocalRadar.Init");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Struct: FDetailObject
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FDetailObject
    {
        /// <summary>
        /// FloatProperty: PositionX
        /// </summary>
        public unsafe float PositionX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: PositionY
        /// </summary>
        public unsafe float PositionY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Bearing
        /// </summary>
        public unsafe int Bearing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: MovieFrame
        /// </summary>
        public unsafe int MovieFrame
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: HeavyTankDetails
    /// </summary>
    public enum HeavyTankDetails : byte
    {
        HTD_ArrayIndex = 0,
        HTD_PositionX = 1,
        HTD_PositionY = 2,
        HTD_Bearing = 3,
        HTD_MovieFrame = 4,
        HTD_PerTank = 5,
        HTD_MAX = 6,
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
    /// BoolProperty: CurrentLockonCritical
    /// </summary>
    public unsafe bool CurrentLockonCritical
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: CurrentHealthCritical
    /// </summary>
    public unsafe bool CurrentHealthCritical
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: InBatmobile
    /// </summary>
    public unsafe bool InBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: VehicleTrackingIsActive
    /// </summary>
    public unsafe bool VehicleTrackingIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: RootSonarIsActive
    /// </summary>
    public unsafe bool RootSonarIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: HeavyTankTrackingIsActive
    /// </summary>
    public unsafe bool HeavyTankTrackingIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: BatmobileRevDisplayActive
    /// </summary>
    public unsafe bool BatmobileRevDisplayActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: FlashRadarVisible
    /// </summary>
    public unsafe bool FlashRadarVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: FlashHeavyTanksVisible
    /// </summary>
    public unsafe bool FlashHeavyTanksVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: RootsPermanentlyVisible
    /// </summary>
    public unsafe bool RootsPermanentlyVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_UpdateTargetPosition
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_UpdateTargetPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetLockonValue
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetLockonValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetStationaryLockonValue
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetStationaryLockonValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetHealthValue
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetHealthValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_PushTrackedActorsToFlash
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_PushTrackedActorsToFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetPlayerPosition
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetPlayerPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_DoPulse
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_DoPulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StrProperty: CachedVariable_HeavyTankDetailArray
    /// </summary>
    public unsafe BmSDK.FString CachedVariable_HeavyTankDetailArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// StrProperty: CachedVariable_TaggedVehicleDetailArray
    /// </summary>
    public unsafe BmSDK.FString CachedVariable_TaggedVehicleDetailArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ObjectProperty: FlashConsolidatedDataArray
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject FlashConsolidatedDataArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// FloatProperty: CurrentLockOn
    /// </summary>
    public unsafe float CurrentLockOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// FloatProperty: CurrentHealth
    /// </summary>
    public unsafe float CurrentHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StrProperty: CurrentHealthTitle
    /// </summary>
    public unsafe BmSDK.FString CurrentHealthTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: RadarRange
    /// </summary>
    public unsafe float RadarRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: HeavyTankRadarRange
    /// </summary>
    public unsafe float HeavyTankRadarRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: RadarRangeInverse
    /// </summary>
    public unsafe float RadarRangeInverse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// FloatProperty: HeavyTankRadarRangeInverse
    /// </summary>
    public unsafe float HeavyTankRadarRangeInverse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// StrProperty: CurrentRootNetwork
    /// </summary>
    public unsafe BmSDK.FString CurrentRootNetwork
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// ArrayProperty: HeavyTankDetailArray
    /// </summary>
    public unsafe BmSDK.TArray<float> HeavyTankDetailArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ArrayProperty: HeavyTankDetailArrayCopy
    /// </summary>
    public unsafe BmSDK.TArray<float> HeavyTankDetailArrayCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// IntProperty: NumChangedTanks
    /// </summary>
    public unsafe int NumChangedTanks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ArrayProperty: HeavyTankDetailObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHudModuleLocalRadar.FDetailObject> HeavyTankDetailObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHudModuleLocalRadar.FDetailObject>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: HeavyTankRadiusPositionX
    /// </summary>
    public unsafe float HeavyTankRadiusPositionX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: HeavyTankRadiusPositionY
    /// </summary>
    public unsafe float HeavyTankRadiusPositionY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// FloatProperty: HeavyTankRadiusScale
    /// </summary>
    public unsafe float HeavyTankRadiusScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ArrayProperty: TaggedVehicleDetailArray
    /// </summary>
    public unsafe BmSDK.TArray<float> TaggedVehicleDetailArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: NumTaggedVehiclePoints
    /// </summary>
    public unsafe int NumTaggedVehiclePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ArrayProperty: RandomAngleArray
    /// </summary>
    public unsafe BmSDK.TArray<float> RandomAngleArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: RandomDistanceArray
    /// </summary>
    public unsafe BmSDK.TArray<float> RandomDistanceArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: FakeTankFrameCounter
    /// </summary>
    public unsafe int FakeTankFrameCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// IntProperty: FakeTankFrameInterval
    /// </summary>
    public unsafe int FakeTankFrameInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// IntProperty: FakeTankNumTanks
    /// </summary>
    public unsafe int FakeTankNumTanks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// IntProperty: NumHeavyTanksInWorld
    /// </summary>
    public unsafe int NumHeavyTanksInWorld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// IntProperty: NumHeavyTanksLastFrame
    /// </summary>
    public unsafe int NumHeavyTanksLastFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: NumCobraTanksInWorld
    /// </summary>
    public unsafe int NumCobraTanksInWorld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: NumCobraTanksLastFrame
    /// </summary>
    public unsafe int NumCobraTanksLastFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }
}
