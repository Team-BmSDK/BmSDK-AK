#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveInstance_HangOnHelicopter<br/>
/// (size = 1256)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_HangOnHelicopter : BmSDK.BmGame.RSpecialMoveInstance_PlaceGooMine, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveInstance_HangOnHelicopter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_HangOnHelicopter.
    /// </summary>
    public static RSpecialMoveInstance_HangOnHelicopter DefaultObject => (RSpecialMoveInstance_HangOnHelicopter)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_HangOnHelicopter() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_HangOnHelicopter
    /// </summary>
    public RSpecialMoveInstance_HangOnHelicopter(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_HangOnHelicopter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HangOnHelicopter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HangOnHelicopter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HangOnHelicopter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HangOnHelicopter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HangOnHelicopter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HangOnHelicopter>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HangOnHelicopter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HangOnHelicopter>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CanDoCombat;
    /// <summary>
    /// Function: CanDoCombat
    /// </summary>
    public unsafe override bool CanDoCombat(bool CheckForEvade = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoCombat, "BmScript.RSpecialMoveInstance_HangOnHelicopter.CanDoCombat");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckForEvade, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StopAnimFollowingHeli;
    /// <summary>
    /// Function: StopAnimFollowingHeli
    /// </summary>
    public unsafe virtual void StopAnimFollowingHeli()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAnimFollowingHeli, "BmScript.RSpecialMoveInstance_HangOnHelicopter.StopAnimFollowingHeli");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GelSprayOff;
    /// <summary>
    /// Function: GelSprayOff
    /// </summary>
    public unsafe virtual void GelSprayOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GelSprayOff, "BmScript.RSpecialMoveInstance_HangOnHelicopter.GelSprayOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GelSprayOn;
    /// <summary>
    /// Function: GelSprayOn
    /// </summary>
    public unsafe virtual void GelSprayOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GelSprayOn, "BmScript.RSpecialMoveInstance_HangOnHelicopter.GelSprayOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGForceAnims;
    /// <summary>
    /// Function: UpdateGForceAnims
    /// </summary>
    public unsafe virtual void UpdateGForceAnims()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGForceAnims, "BmScript.RSpecialMoveInstance_HangOnHelicopter.UpdateGForceAnims");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGlideOutAnim;
    /// <summary>
    /// Function: GetGlideOutAnim
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RSpecialMoveConfig_HangOnHelicopter.FGlideOutAnim GetGlideOutAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlideOutAnim, "BmScript.RSpecialMoveInstance_HangOnHelicopter.GetGlideOutAnim");
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RSpecialMoveConfig_HangOnHelicopter.FGlideOutAnim>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartScan;
    /// <summary>
    /// Function: StartScan
    /// </summary>
    public unsafe virtual void StartScan()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartScan, "BmScript.RSpecialMoveInstance_HangOnHelicopter.StartScan");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHelicopter;
    /// <summary>
    /// Function: GetHelicopter
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHelicopterBase GetHelicopter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelicopter, "BmScript.RSpecialMoveInstance_HangOnHelicopter.GetHelicopter");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHelicopterBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSpecialMove, "BmScript.RSpecialMoveInstance_HangOnHelicopter.CancelSpecialMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe override void FinishSpecialMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmScript.RSpecialMoveInstance_HangOnHelicopter.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGelDummyAnim;
    /// <summary>
    /// Function: GetGelDummyAnim
    /// </summary>
    public unsafe override BmSDK.FName GetGelDummyAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGelDummyAnim, "BmScript.RSpecialMoveInstance_HangOnHelicopter.GetGelDummyAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmScript.RSpecialMoveInstance_HangOnHelicopter.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: CurrentTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CurrentTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 1064);

    /// <summary>
    /// StructProperty: LastHeliAccel
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastHeliAccel
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1068);

    /// <summary>
    /// IntProperty: screenShakeID
    /// </summary>
    public unsafe int screenShakeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// StructProperty: ScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 1084);

    /// <summary>
    /// BoolProperty: bStopAligningWithHeli
    /// </summary>
    public unsafe bool bStopAligningWithHeli
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1240); }
    }

    /// <summary>
    /// StructProperty: UpdatedReferenceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator UpdatedReferenceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1244);
}
