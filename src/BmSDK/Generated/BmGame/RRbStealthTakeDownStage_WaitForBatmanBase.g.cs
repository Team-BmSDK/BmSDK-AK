#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRbStealthTakeDownStage_WaitForBatmanBase<br/>
/// (size = 1688)
/// (flags = 10485778)
/// </summary>
public partial class RRbStealthTakeDownStage_WaitForBatmanBase : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRbStealthTakeDownStage_WaitForBatmanBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RRbStealthTakeDownStage_WaitForBatmanBase.
    /// </summary>
    public static RRbStealthTakeDownStage_WaitForBatmanBase DefaultObject => (RRbStealthTakeDownStage_WaitForBatmanBase)StaticClass().DefaultObject;

    internal RRbStealthTakeDownStage_WaitForBatmanBase() { }

    /// <summary>
    /// Constructs a new RRbStealthTakeDownStage_WaitForBatmanBase
    /// </summary>
    public RRbStealthTakeDownStage_WaitForBatmanBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRbStealthTakeDownStage_WaitForBatmanBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_End;
    /// <summary>
    /// Function: End
    /// </summary>
    public unsafe override void End(bool bLastStage = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_End, "BmGame.RRbStealthTakeDownStage_WaitForBatmanBase.End");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLastStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Cancel;
    /// <summary>
    /// Function: Cancel
    /// </summary>
    public unsafe override void Cancel(bool SetState = default, bool bAbandonVictims = default, bool bResetPlayerPose = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Cancel, "BmGame.RRbStealthTakeDownStage_WaitForBatmanBase.Cancel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbandonVictims, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetPlayerPose, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FailedTakedown;
    /// <summary>
    /// Function: FailedTakedown
    /// </summary>
    public unsafe virtual void FailedTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FailedTakedown, "BmGame.RRbStealthTakeDownStage_WaitForBatmanBase.FailedTakedown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanStartedGlideKick;
    /// <summary>
    /// Function: BatmanStartedGlideKick
    /// </summary>
    public unsafe virtual void BatmanStartedGlideKick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanStartedGlideKick, "BmGame.RRbStealthTakeDownStage_WaitForBatmanBase.BatmanStartedGlideKick");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TooLateToAttack;
    /// <summary>
    /// Function: TooLateToAttack
    /// </summary>
    public unsafe virtual void TooLateToAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TooLateToAttack, "BmGame.RRbStealthTakeDownStage_WaitForBatmanBase.TooLateToAttack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchToBatman;
    /// <summary>
    /// Function: SwitchToBatman
    /// </summary>
    public unsafe virtual void SwitchToBatman()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchToBatman, "BmGame.RRbStealthTakeDownStage_WaitForBatmanBase.SwitchToBatman");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimeOut;
    /// <summary>
    /// Function: TimeOut
    /// </summary>
    public unsafe virtual void TimeOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimeOut, "BmGame.RRbStealthTakeDownStage_WaitForBatmanBase.TimeOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Begin;
    /// <summary>
    /// Function: Begin
    /// </summary>
    public unsafe override void Begin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Begin, "BmGame.RRbStealthTakeDownStage_WaitForBatmanBase.Begin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EWaitForBatmanStages
    /// </summary>
    public enum EWaitForBatmanStages : byte
    {
        WFBS_None = 0,
        WFBS_Ready = 1,
        WFBS_TooLateToAttack = 2,
        WFBS_FailedTakedown = 3,
        WFBS_MAX = 4,
    }

    /// <summary>
    /// BoolProperty: bBatmanStartedGlideKick
    /// </summary>
    public unsafe bool bBatmanStartedGlideKick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// ByteProperty: GlideKickTakedownStage
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages GlideKickTakedownStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ByteProperty: Stage
    /// </summary>
    public unsafe BmSDK.BmGame.RRbStealthTakeDownStage_WaitForBatmanBase.EWaitForBatmanStages Stage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRbStealthTakeDownStage_WaitForBatmanBase.EWaitForBatmanStages>(Ptr + 1669); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1669); }
    }

    /// <summary>
    /// NameProperty: TurnLeftAnim
    /// </summary>
    public unsafe BmSDK.FName TurnLeftAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// NameProperty: TurnRightAnim
    /// </summary>
    public unsafe BmSDK.FName TurnRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }
}
