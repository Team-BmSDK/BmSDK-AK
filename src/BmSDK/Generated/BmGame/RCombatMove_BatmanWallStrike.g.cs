#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_BatmanWallStrike<br/>
/// (size = 1576)
/// (flags = 10485778)
/// </summary>
public partial class RCombatMove_BatmanWallStrike : BmSDK.BmGame.RCombatMove_BatmanStrike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_BatmanWallStrike", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_BatmanWallStrike.
    /// </summary>
    public static RCombatMove_BatmanWallStrike DefaultObject => (RCombatMove_BatmanWallStrike)StaticClass().DefaultObject;

    internal RCombatMove_BatmanWallStrike() { }

    /// <summary>
    /// Constructs a new RCombatMove_BatmanWallStrike
    /// </summary>
    public RCombatMove_BatmanWallStrike(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_BatmanWallStrike(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanWallStrike>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanWallStrike>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanWallStrike>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanWallStrike>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanWallStrike>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanWallStrike>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanWallStrike>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanWallStrike>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlayedQueuedStrikeAnimSimulated;
    /// <summary>
    /// Function: PlayedQueuedStrikeAnimSimulated
    /// </summary>
    public unsafe override void PlayedQueuedStrikeAnimSimulated(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedAnimID, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedQueuedStrikeAnimSimulated, "BmGame.RCombatMove_BatmanWallStrike.PlayedQueuedStrikeAnimSimulated");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayedQueuedStrikeAnim;
    /// <summary>
    /// Function: PlayedQueuedStrikeAnim
    /// </summary>
    public unsafe override void PlayedQueuedStrikeAnim(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedAnimID, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedQueuedStrikeAnim, "BmGame.RCombatMove_BatmanWallStrike.PlayedQueuedStrikeAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoFirstStateSimulated;
    /// <summary>
    /// Function: GotoFirstStateSimulated
    /// </summary>
    public unsafe virtual void GotoFirstStateSimulated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoFirstStateSimulated, "BmGame.RCombatMove_BatmanWallStrike.GotoFirstStateSimulated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoFirstState;
    /// <summary>
    /// Function: GotoFirstState
    /// </summary>
    public unsafe override void GotoFirstState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoFirstState, "BmGame.RCombatMove_BatmanWallStrike.GotoFirstState");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToFindTarget;
    /// <summary>
    /// Function: TryToFindTarget
    /// </summary>
    public unsafe override void TryToFindTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToFindTarget, "BmGame.RCombatMove_BatmanWallStrike.TryToFindTarget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNoTargetDir;
    /// <summary>
    /// Function: SetNoTargetDir
    /// </summary>
    public unsafe override void SetNoTargetDir()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNoTargetDir, "BmGame.RCombatMove_BatmanWallStrike.SetNoTargetDir");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterHit;
    /// <summary>
    /// Function: RegisterHit
    /// </summary>
    public unsafe virtual void RegisterHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterHit, "BmGame.RCombatMove_BatmanWallStrike.RegisterHit");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessDamageResult;
    /// <summary>
    /// Function: ProcessDamageResult
    /// </summary>
    public unsafe override void ProcessDamageResult(BmSDK.BmGame.RPawnCombat.DamageResult DmgResult, BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessDamageResult, "BmGame.RCombatMove_BatmanWallStrike.ProcessDamageResult");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDamagePower;
    /// <summary>
    /// Function: GetDamagePower
    /// </summary>
    public unsafe override float GetDamagePower()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamagePower, "BmGame.RCombatMove_BatmanWallStrike.GetDamagePower");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetComboIncrease;
    /// <summary>
    /// Function: GetComboIncrease
    /// </summary>
    public unsafe override void GetComboIncrease(out int ComboIncrease, out int SpecialMoveCountIncrease)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboIncrease, "BmGame.RCombatMove_BatmanWallStrike.GetComboIncrease");
        byte* paramsPtr = stackalloc byte[8];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ComboIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboIncrease, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpecialMoveCountIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveCountIncrease, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ComboIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        SpecialMoveCountIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// StructProperty: WallNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1564);
}
