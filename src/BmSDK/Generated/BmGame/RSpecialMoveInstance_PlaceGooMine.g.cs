#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveInstance_PlaceGooMine<br/>
/// (size = 1064)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_PlaceGooMine : BmSDK.BmGame.RSpecialMoveInstance_PlaceActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveInstance_PlaceGooMine", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_PlaceGooMine.
    /// </summary>
    public static RSpecialMoveInstance_PlaceGooMine DefaultObject => (RSpecialMoveInstance_PlaceGooMine)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_PlaceGooMine() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_PlaceGooMine
    /// </summary>
    public RSpecialMoveInstance_PlaceGooMine(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_PlaceGooMine(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PlaceGooMine>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PlaceGooMine>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PlaceGooMine>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PlaceGooMine>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PlaceGooMine>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PlaceGooMine>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PlaceGooMine>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_PlaceGooMine>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_AllowMoveTo;
    /// <summary>
    /// Function: AllowMoveTo
    /// </summary>
    public unsafe override bool AllowMoveTo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowMoveTo, "BmGame.RSpecialMoveInstance_PlaceGooMine.AllowMoveTo");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SafeToCancel;
    /// <summary>
    /// Function: SafeToCancel
    /// </summary>
    public unsafe virtual void SafeToCancel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SafeToCancel, "BmGame.RSpecialMoveInstance_PlaceGooMine.SafeToCancel");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchToExtraCam;
    /// <summary>
    /// Function: SwitchToExtraCam
    /// </summary>
    public unsafe virtual void SwitchToExtraCam()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchToExtraCam, "BmGame.RSpecialMoveInstance_PlaceGooMine.SwitchToExtraCam");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FallTimeOut;
    /// <summary>
    /// Function: FallTimeOut
    /// </summary>
    public unsafe override void FallTimeOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FallTimeOut, "BmGame.RSpecialMoveInstance_PlaceGooMine.FallTimeOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGelSound;
    /// <summary>
    /// Function: StartGelSound
    /// </summary>
    public unsafe virtual void StartGelSound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGelSound, "BmGame.RSpecialMoveInstance_PlaceGooMine.StartGelSound");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSpecialMove, "BmGame.RSpecialMoveInstance_PlaceGooMine.CancelSpecialMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerGooActivateEvent;
    /// <summary>
    /// Function: TriggerGooActivateEvent
    /// </summary>
    public unsafe virtual void TriggerGooActivateEvent(int Output, BmSDK.BmGame.RPlayerController RPC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGooActivateEvent, "BmGame.RSpecialMoveInstance_PlaceGooMine.TriggerGooActivateEvent");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Output, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepGelDummy;
    /// <summary>
    /// Function: PrepGelDummy
    /// </summary>
    public unsafe virtual void PrepGelDummy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepGelDummy, "BmGame.RSpecialMoveInstance_PlaceGooMine.PrepGelDummy");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGelDummyAnim;
    /// <summary>
    /// Function: GetGelDummyAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetGelDummyAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGelDummyAnim, "BmGame.RSpecialMoveInstance_PlaceGooMine.GetGelDummyAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AnimationStarted;
    /// <summary>
    /// Function: AnimationStarted
    /// </summary>
    public unsafe override void AnimationStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimationStarted, "BmGame.RSpecialMoveInstance_PlaceGooMine.AnimationStarted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetonateGelPressed;
    /// <summary>
    /// Function: DetonateGelPressed
    /// </summary>
    public unsafe virtual void DetonateGelPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetonateGelPressed, "BmGame.RSpecialMoveInstance_PlaceGooMine.DetonateGelPressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe override void FinishSpecialMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmGame.RSpecialMoveInstance_PlaceGooMine.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaceActor;
    /// <summary>
    /// Function: PlaceActor
    /// </summary>
    public unsafe override void PlaceActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaceActor, "BmGame.RSpecialMoveInstance_PlaceGooMine.PlaceActor");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDoCombat;
    /// <summary>
    /// Function: CanDoCombat
    /// </summary>
    public unsafe override bool CanDoCombat(bool CheckForEvade = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoCombat, "BmGame.RSpecialMoveInstance_PlaceGooMine.CanDoCombat");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckForEvade, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmGame.RSpecialMoveInstance_PlaceGooMine.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bPlacedActor
    /// </summary>
    public unsafe bool bPlacedActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1020); }
    }

    /// <summary>
    /// BoolProperty: bSafeToCancel
    /// </summary>
    public unsafe bool bSafeToCancel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1020); }
    }

    /// <summary>
    /// ObjectProperty: Mine
    /// </summary>
    public unsafe BmSDK.BmGame.RExplosiveGooMine Mine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RExplosiveGooMine>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ObjectProperty: GelSprayAudio
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GelSprayAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ObjectProperty: OldGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget OldGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StructProperty: GelSoundHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle GelSoundHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 1048);
}
