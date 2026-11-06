#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RLevelTransitionDoorBunkerNativeBase<br/>
/// (size = 796)
/// (flags = 144703634)
/// </summary>
public partial class RLevelTransitionDoorBunkerNativeBase : BmSDK.BmGame.RLevelTransition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RLevelTransitionDoorBunkerNativeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RLevelTransitionDoorBunkerNativeBase.
    /// </summary>
    public static RLevelTransitionDoorBunkerNativeBase DefaultObject => (RLevelTransitionDoorBunkerNativeBase)StaticClass().DefaultObject;

    internal RLevelTransitionDoorBunkerNativeBase() { }

    /// <summary>
    /// Constructs a new RLevelTransitionDoorBunkerNativeBase
    /// </summary>
    public RLevelTransitionDoorBunkerNativeBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RLevelTransitionDoorBunkerNativeBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_AttemptingToUseButDisabledByPassenger;
    /// <summary>
    /// Function: AttemptingToUseButDisabledByPassenger
    /// </summary>
    public unsafe virtual void AttemptingToUseButDisabledByPassenger()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptingToUseButDisabledByPassenger, "BmGame.RLevelTransitionDoorBunkerNativeBase.AttemptingToUseButDisabledByPassenger");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttemptingToUseWhenCombatLocked;
    /// <summary>
    /// Function: AttemptingToUseWhenCombatLocked
    /// </summary>
    public unsafe virtual void AttemptingToUseWhenCombatLocked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptingToUseWhenCombatLocked, "BmGame.RLevelTransitionDoorBunkerNativeBase.AttemptingToUseWhenCombatLocked");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowedToOpenIfNotAlreadyOpen;
    /// <summary>
    /// Function: AllowedToOpenIfNotAlreadyOpen
    /// </summary>
    public unsafe virtual bool AllowedToOpenIfNotAlreadyOpen(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowedToOpenIfNotAlreadyOpen, "BmGame.RLevelTransitionDoorBunkerNativeBase.AllowedToOpenIfNotAlreadyOpen");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AllowedToBeOpen;
    /// <summary>
    /// Function: AllowedToBeOpen
    /// </summary>
    public unsafe virtual bool AllowedToBeOpen(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowedToBeOpen, "BmGame.RLevelTransitionDoorBunkerNativeBase.AllowedToBeOpen");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DisabledByPassenger;
    /// <summary>
    /// Function: DisabledByPassenger
    /// </summary>
    public unsafe virtual bool DisabledByPassenger(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisabledByPassenger, "BmGame.RLevelTransitionDoorBunkerNativeBase.DisabledByPassenger");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsLookingAt;
    /// <summary>
    /// Function: IsLookingAt
    /// </summary>
    public unsafe virtual bool IsLookingAt(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLookingAt, "BmGame.RLevelTransitionDoorBunkerNativeBase.IsLookingAt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PassedThroughDoor;
    /// <summary>
    /// Function: PassedThroughDoor
    /// </summary>
    public unsafe virtual void PassedThroughDoor(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PassedThroughDoor, "BmGame.RLevelTransitionDoorBunkerNativeBase.PassedThroughDoor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedClosingDoor;
    /// <summary>
    /// Function: FinishedClosingDoor
    /// </summary>
    public unsafe virtual void FinishedClosingDoor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedClosingDoor, "BmGame.RLevelTransitionDoorBunkerNativeBase.FinishedClosingDoor");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttemptingToUseWhenSideStoriesDisabled;
    /// <summary>
    /// Function: AttemptingToUseWhenSideStoriesDisabled
    /// </summary>
    public unsafe virtual void AttemptingToUseWhenSideStoriesDisabled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptingToUseWhenSideStoriesDisabled, "BmGame.RLevelTransitionDoorBunkerNativeBase.AttemptingToUseWhenSideStoriesDisabled");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UsedWhenLocked;
    /// <summary>
    /// Function: UsedWhenLocked
    /// </summary>
    public unsafe virtual bool UsedWhenLocked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsedWhenLocked, "BmGame.RLevelTransitionDoorBunkerNativeBase.UsedWhenLocked");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AttemptToCloseDoor;
    /// <summary>
    /// Function: AttemptToCloseDoor
    /// </summary>
    public unsafe virtual bool AttemptToCloseDoor(bool Instantly = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptToCloseDoor, "BmGame.RLevelTransitionDoorBunkerNativeBase.AttemptToCloseDoor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Instantly, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AttemptToOpenDoor;
    /// <summary>
    /// Function: AttemptToOpenDoor
    /// </summary>
    public unsafe virtual void AttemptToOpenDoor(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptToOpenDoor, "BmGame.RLevelTransitionDoorBunkerNativeBase.AttemptToOpenDoor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInActivationRange;
    /// <summary>
    /// Function: IsInActivationRange
    /// </summary>
    public unsafe virtual bool IsInActivationRange(System.Numerics.Vector3 pos, float Range)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInActivationRange, "BmGame.RLevelTransitionDoorBunkerNativeBase.IsInActivationRange");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Range, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DoorIsAnimating;
    /// <summary>
    /// Function: DoorIsAnimating
    /// </summary>
    public unsafe virtual bool DoorIsAnimating()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoorIsAnimating, "BmGame.RLevelTransitionDoorBunkerNativeBase.DoorIsAnimating");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPlayerPassingThrough;
    /// <summary>
    /// Function: IsPlayerPassingThrough
    /// </summary>
    public unsafe override bool IsPlayerPassingThrough(System.Numerics.Vector3 PlayerLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerPassingThrough, "BmGame.RLevelTransitionDoorBunkerNativeBase.IsPlayerPassingThrough");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: DoorLocked
    /// </summary>
    public unsafe bool DoorLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bLockWhenSideStoriesDisabled
    /// </summary>
    public unsafe bool bLockWhenSideStoriesDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: StartedOtherLevel
    /// </summary>
    public unsafe bool StartedOtherLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: OtherLevelVisible
    /// </summary>
    public unsafe bool OtherLevelVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: StartedLevelHere
    /// </summary>
    public unsafe bool StartedLevelHere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: ForceOpen
    /// </summary>
    public unsafe bool ForceOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: ForceUnloadWhenClosed
    /// </summary>
    public unsafe bool ForceUnloadWhenClosed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bUnlockAutomatedLevelStreaming
    /// </summary>
    public unsafe bool bUnlockAutomatedLevelStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bInTriggerArea
    /// </summary>
    public unsafe bool bInTriggerArea
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredCombatLockedEvent
    /// </summary>
    public unsafe bool bTriggeredCombatLockedEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bClosing
    /// </summary>
    public unsafe bool bClosing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredUsedWhenLocked
    /// </summary>
    public unsafe bool bTriggeredUsedWhenLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: PlayerOpenRange
    /// </summary>
    public unsafe float PlayerOpenRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: PlayerOpenHeight
    /// </summary>
    public unsafe float PlayerOpenHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ObjectProperty: VillainBlocker
    /// </summary>
    public unsafe BmSDK.BmGame.RBunkerDoorVillainBlocker VillainBlocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBunkerDoorVillainBlocker>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ComponentProperty: PlayerBlocker
    /// </summary>
    public unsafe BmSDK.Engine.RAggGeomCollisionComponent PlayerBlocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAggGeomCollisionComponent>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }
}
