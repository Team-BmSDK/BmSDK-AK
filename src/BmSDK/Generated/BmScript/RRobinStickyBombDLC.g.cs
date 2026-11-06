#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RRobinStickyBombDLC<br/>
/// (size = 2176)
/// (flags = 10485810)
/// </summary>
public partial class RRobinStickyBombDLC : BmSDK.BmScript.RRobinStickyBomb, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RRobinStickyBombDLC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RRobinStickyBombDLC.
    /// </summary>
    public static RRobinStickyBombDLC DefaultObject => (RRobinStickyBombDLC)StaticClass().DefaultObject;

    internal RRobinStickyBombDLC() { }

    /// <summary>
    /// Constructs a new RRobinStickyBombDLC
    /// </summary>
    public RRobinStickyBombDLC(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRobinStickyBombDLC(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRobinStickyBombDLC>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinStickyBombDLC>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRobinStickyBombDLC>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinStickyBombDLC>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinStickyBombDLC>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinStickyBombDLC>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRobinStickyBombDLC>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinStickyBombDLC>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_TriggerStunnedThugKOedBySnapFlashEvents;
    /// <summary>
    /// Function: TriggerStunnedThugKOedBySnapFlashEvents
    /// </summary>
    public unsafe virtual void TriggerStunnedThugKOedBySnapFlashEvents(BmSDK.BmGame.RPawnVillain Victim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerStunnedThugKOedBySnapFlashEvents, "BmScript.RRobinStickyBombDLC.TriggerStunnedThugKOedBySnapFlashEvents");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerMedicKOedBySnapFlashEvents;
    /// <summary>
    /// Function: TriggerMedicKOedBySnapFlashEvents
    /// </summary>
    public unsafe virtual void TriggerMedicKOedBySnapFlashEvents(BmSDK.BmGame.RPawnVillain Victim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerMedicKOedBySnapFlashEvents, "BmScript.RRobinStickyBombDLC.TriggerMedicKOedBySnapFlashEvents");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExplodeBomb;
    /// <summary>
    /// Function: ExplodeBomb
    /// </summary>
    public unsafe override void ExplodeBomb(BmSDK.Engine.MeshComponent Bomb, BmSDK.BmGame.RPawnVillain bombWasOnDownedEnemy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExplodeBomb, "BmScript.RRobinStickyBombDLC.ExplodeBomb");
        byte* paramsPtr = stackalloc byte[352];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bomb, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bombWasOnDownedEnemy, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetonateAll;
    /// <summary>
    /// Function: DetonateAll
    /// </summary>
    public unsafe override void DetonateAll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetonateAll, "BmScript.RRobinStickyBombDLC.DetonateAll");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainWasDestroyedWithStickyBombAttached;
    /// <summary>
    /// Function: VillainWasDestroyedWithStickyBombAttached
    /// </summary>
    public unsafe override void VillainWasDestroyedWithStickyBombAttached(BmSDK.Engine.MeshComponent Bomb)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainWasDestroyedWithStickyBombAttached, "BmScript.RRobinStickyBombDLC.VillainWasDestroyedWithStickyBombAttached");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bomb, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetCamera;
    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe override BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetCamera, "BmScript.RRobinStickyBombDLC.GetGadgetCamera");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsValidStickyBombTarget;
    /// <summary>
    /// Function: IsValidStickyBombTarget
    /// </summary>
    public unsafe override bool IsValidStickyBombTarget(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidStickyBombTarget, "BmScript.RRobinStickyBombDLC.IsValidStickyBombTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// IntProperty: NumVillainsKOed
    /// </summary>
    public unsafe int NumVillainsKOed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }
}
