#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Brang_Sub_WatchBatarang<br/>
/// (size = 712)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_Brang_Sub_WatchBatarang : BmSDK.BmGame.RAlertEventCoordinatorSolo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Brang_Sub_WatchBatarang", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Brang_Sub_WatchBatarang.
    /// </summary>
    public static RAEC_Brang_Sub_WatchBatarang DefaultObject => (RAEC_Brang_Sub_WatchBatarang)StaticClass().DefaultObject;

    internal RAEC_Brang_Sub_WatchBatarang() { }

    /// <summary>
    /// Constructs a new RAEC_Brang_Sub_WatchBatarang
    /// </summary>
    public RAEC_Brang_Sub_WatchBatarang(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Brang_Sub_WatchBatarang(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Brang_Sub_WatchBatarang>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Brang_Sub_WatchBatarang>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Brang_Sub_WatchBatarang>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Brang_Sub_WatchBatarang>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Brang_Sub_WatchBatarang>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Brang_Sub_WatchBatarang>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Brang_Sub_WatchBatarang>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Brang_Sub_WatchBatarang>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_AdjustWatchPointForFloor;
    /// <summary>
    /// Function: AdjustWatchPointForFloor
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 AdjustWatchPointForFloor(System.Numerics.Vector3 CurrentPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustWatchPointForFloor, "BmGame.RAEC_Brang_Sub_WatchBatarang.AdjustWatchPointForFloor");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanDodgeProjectile;
    /// <summary>
    /// Function: CanDodgeProjectile
    /// </summary>
    public unsafe override bool CanDodgeProjectile(System.Numerics.Vector3 ThrownFromPos, int CheckBatarangID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDodgeProjectile, "BmGame.RAEC_Brang_Sub_WatchBatarang.CanDodgeProjectile");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckBatarangID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetWatchPoint;
    /// <summary>
    /// Function: SetWatchPoint
    /// </summary>
    public unsafe virtual void SetWatchPoint(System.Numerics.Vector3 NewWatchPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWatchPoint, "BmGame.RAEC_Brang_Sub_WatchBatarang.SetWatchPoint");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWatchPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartleForCasualtyImpact;
    /// <summary>
    /// Function: StartleForCasualtyImpact
    /// </summary>
    public unsafe virtual void StartleForCasualtyImpact(System.Numerics.Vector3 NewPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartleForCasualtyImpact, "BmGame.RAEC_Brang_Sub_WatchBatarang.StartleForCasualtyImpact");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartleForImpact;
    /// <summary>
    /// Function: StartleForImpact
    /// </summary>
    public unsafe virtual void StartleForImpact(System.Numerics.Vector3 NewPos, bool bTerrorShootStartle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartleForImpact, "BmGame.RAEC_Brang_Sub_WatchBatarang.StartleForImpact");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTerrorShootStartle, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GlanceAtImpact;
    /// <summary>
    /// Function: GlanceAtImpact
    /// </summary>
    public unsafe virtual void GlanceAtImpact(System.Numerics.Vector3 GlanceLoc, float NewGlanceTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GlanceAtImpact, "BmGame.RAEC_Brang_Sub_WatchBatarang.GlanceAtImpact");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GlanceLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGlanceTime, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignNewPosition;
    /// <summary>
    /// Function: AssignNewPosition
    /// </summary>
    public unsafe virtual void AssignNewPosition(System.Numerics.Vector3 NewPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignNewPosition, "BmGame.RAEC_Brang_Sub_WatchBatarang.AssignNewPosition");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFinished;
    /// <summary>
    /// Function: NotifyFinished
    /// </summary>
    public unsafe override void NotifyFinished(BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFinished, "BmGame.RAEC_Brang_Sub_WatchBatarang.NotifyFinished");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: WatchPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WatchPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 696);

    /// <summary>
    /// FloatProperty: GlanceTime
    /// </summary>
    public unsafe float GlanceTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }
}
