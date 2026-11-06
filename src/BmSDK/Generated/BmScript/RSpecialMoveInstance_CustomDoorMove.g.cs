#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveInstance_CustomDoorMove<br/>
/// (size = 1032)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_CustomDoorMove : BmSDK.BmGame.RSpecialMoveInstance_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveInstance_CustomDoorMove", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_CustomDoorMove.
    /// </summary>
    public static RSpecialMoveInstance_CustomDoorMove DefaultObject => (RSpecialMoveInstance_CustomDoorMove)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_CustomDoorMove() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_CustomDoorMove
    /// </summary>
    public RSpecialMoveInstance_CustomDoorMove(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_CustomDoorMove(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CustomDoorMove>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CustomDoorMove>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CustomDoorMove>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CustomDoorMove>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CustomDoorMove>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CustomDoorMove>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CustomDoorMove>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CustomDoorMove>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe override void FinishSpecialMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmScript.RSpecialMoveInstance_CustomDoorMove.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStaggNormal;
    /// <summary>
    /// Function: SetStaggNormal
    /// </summary>
    public unsafe virtual void SetStaggNormal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStaggNormal, "BmScript.RSpecialMoveInstance_CustomDoorMove.SetStaggNormal");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStaggScanning;
    /// <summary>
    /// Function: SetStaggScanning
    /// </summary>
    public unsafe virtual void SetStaggScanning()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStaggScanning, "BmScript.RSpecialMoveInstance_CustomDoorMove.SetStaggScanning");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStaggOpen;
    /// <summary>
    /// Function: SetStaggOpen
    /// </summary>
    public unsafe virtual void SetStaggOpen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStaggOpen, "BmScript.RSpecialMoveInstance_CustomDoorMove.SetStaggOpen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachStaggLight;
    /// <summary>
    /// Function: DetachStaggLight
    /// </summary>
    public unsafe virtual void DetachStaggLight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachStaggLight, "BmScript.RSpecialMoveInstance_CustomDoorMove.DetachStaggLight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachStaggLight;
    /// <summary>
    /// Function: AttachStaggLight
    /// </summary>
    public unsafe virtual void AttachStaggLight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachStaggLight, "BmScript.RSpecialMoveInstance_CustomDoorMove.AttachStaggLight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TeleportToOtherSide;
    /// <summary>
    /// Function: TeleportToOtherSide
    /// </summary>
    public unsafe virtual void TeleportToOtherSide()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeleportToOtherSide, "BmScript.RSpecialMoveInstance_CustomDoorMove.TeleportToOtherSide");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateSpecialMove;
    /// <summary>
    /// Function: UpdateSpecialMove
    /// </summary>
    public unsafe override bool UpdateSpecialMove(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSpecialMove, "BmScript.RSpecialMoveInstance_CustomDoorMove.UpdateSpecialMove");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmScript.RSpecialMoveInstance_CustomDoorMove.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: LevelDoor
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelTransitionDoorBase LevelDoor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelTransitionDoorBase>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// ComponentProperty: DoorLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent DoorLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bStartedOtherPawn
    /// </summary>
    public unsafe bool bStartedOtherPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1004) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1004); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1004); }
    }

    /// <summary>
    /// StructProperty: SavedLocatorRot
    /// </summary>
    public unsafe ref BmSDK.Rotator SavedLocatorRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1008);

    /// <summary>
    /// StructProperty: BlueCol
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor BlueCol
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1020);

    /// <summary>
    /// StructProperty: RedCol
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor RedCol
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1024);

    /// <summary>
    /// StructProperty: GreenCol
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor GreenCol
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 1028);
}
