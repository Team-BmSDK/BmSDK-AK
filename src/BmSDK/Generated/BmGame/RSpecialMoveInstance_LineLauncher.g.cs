#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveInstance_LineLauncher<br/>
/// (size = 1147)
/// (flags = 144703634)
/// </summary>
public partial class RSpecialMoveInstance_LineLauncher : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveInstance_LineLauncher", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_LineLauncher.
    /// </summary>
    public static RSpecialMoveInstance_LineLauncher DefaultObject => (RSpecialMoveInstance_LineLauncher)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_LineLauncher() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_LineLauncher
    /// </summary>
    public RSpecialMoveInstance_LineLauncher(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_LineLauncher(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_LineLauncher>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_LineLauncher>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_LineLauncher>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_LineLauncher>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_LineLauncher>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_LineLauncher>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_LineLauncher>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_LineLauncher>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdateZipLineControlPoint;
    /// <summary>
    /// Function: UpdateZipLineControlPoint
    /// </summary>
    public unsafe virtual void UpdateZipLineControlPoint(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateZipLineControlPoint, "BmGame.RSpecialMoveInstance_LineLauncher.UpdateZipLineControlPoint");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ZipLineAttach;
    /// <summary>
    /// Function: ZipLineAttach
    /// </summary>
    public unsafe virtual void ZipLineAttach()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ZipLineAttach, "BmGame.RSpecialMoveInstance_LineLauncher.ZipLineAttach");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchedPlayers;
    /// <summary>
    /// Function: SwitchedPlayers
    /// </summary>
    public unsafe virtual void SwitchedPlayers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchedPlayers, "BmGame.RSpecialMoveInstance_LineLauncher.SwitchedPlayers");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInteruptable;
    /// <summary>
    /// Function: IsInteruptable
    /// </summary>
    public unsafe override bool IsInteruptable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInteruptable, "BmGame.RSpecialMoveInstance_LineLauncher.IsInteruptable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckSpaceForTightRope;
    /// <summary>
    /// Function: CheckSpaceForTightRope
    /// </summary>
    public unsafe virtual bool CheckSpaceForTightRope(float ForwardTravelTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSpaceForTightRope, "BmGame.RSpecialMoveInstance_LineLauncher.CheckSpaceForTightRope");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForwardTravelTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckForRailingComingUp;
    /// <summary>
    /// Function: CheckForRailingComingUp
    /// </summary>
    public unsafe virtual void CheckForRailingComingUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForRailingComingUp, "BmGame.RSpecialMoveInstance_LineLauncher.CheckForRailingComingUp");
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StartLineLaunching;
    /// <summary>
    /// Function: StartLineLaunching
    /// </summary>
    public unsafe virtual void StartLineLaunching()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLineLaunching, "BmGame.RSpecialMoveInstance_LineLauncher.StartLineLaunching");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttackFinished;
    /// <summary>
    /// Function: AttackFinished
    /// </summary>
    public unsafe virtual void AttackFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttackFinished, "BmGame.RSpecialMoveInstance_LineLauncher.AttackFinished");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyBump;
    /// <summary>
    /// Function: NotifyBump
    /// </summary>
    public unsafe override void NotifyBump(BmSDK.Engine.Actor Other, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyBump, "BmGame.RSpecialMoveInstance_LineLauncher.NotifyBump");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LineLauncherGrabHostage;
    /// <summary>
    /// Function: LineLauncherGrabHostage
    /// </summary>
    public unsafe virtual void LineLauncherGrabHostage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LineLauncherGrabHostage, "BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherGrabHostage");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LineLauncherGrabVictim;
    /// <summary>
    /// Function: LineLauncherGrabVictim
    /// </summary>
    public unsafe virtual void LineLauncherGrabVictim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LineLauncherGrabVictim, "BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherGrabVictim");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KickAnimTimer;
    /// <summary>
    /// Function: KickAnimTimer
    /// </summary>
    public unsafe virtual void KickAnimTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KickAnimTimer, "BmGame.RSpecialMoveInstance_LineLauncher.KickAnimTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckKickedThroughWindow;
    /// <summary>
    /// Function: CheckKickedThroughWindow
    /// </summary>
    public unsafe virtual void CheckKickedThroughWindow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckKickedThroughWindow, "BmGame.RSpecialMoveInstance_LineLauncher.CheckKickedThroughWindow");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LineLauncherAttack;
    /// <summary>
    /// Function: LineLauncherAttack
    /// </summary>
    public unsafe virtual void LineLauncherAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LineLauncherAttack, "BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherAttack");
        byte* paramsPtr = stackalloc byte[308];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BackToPlayerCamera;
    /// <summary>
    /// Function: BackToPlayerCamera
    /// </summary>
    public unsafe virtual void BackToPlayerCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BackToPlayerCamera, "BmGame.RSpecialMoveInstance_LineLauncher.BackToPlayerCamera");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmGame.RSpecialMoveInstance_LineLauncher.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSpecialMove, "BmGame.RSpecialMoveInstance_LineLauncher.CancelSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropHostage;
    /// <summary>
    /// Function: DropHostage
    /// </summary>
    public unsafe virtual void DropHostage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropHostage, "BmGame.RSpecialMoveInstance_LineLauncher.DropHostage");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropVillain;
    /// <summary>
    /// Function: DropVillain
    /// </summary>
    public unsafe virtual void DropVillain()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropVillain, "BmGame.RSpecialMoveInstance_LineLauncher.DropVillain");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishGrabbedVillain;
    /// <summary>
    /// Function: FinishGrabbedVillain
    /// </summary>
    public unsafe virtual void FinishGrabbedVillain(BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherTakedownFinish Move = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishGrabbedVillain, "BmGame.RSpecialMoveInstance_LineLauncher.FinishGrabbedVillain");
        byte* paramsPtr = stackalloc byte[252];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffRopes;
    /// <summary>
    /// Function: TurnOffRopes
    /// </summary>
    public unsafe virtual void TurnOffRopes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffRopes, "BmGame.RSpecialMoveInstance_LineLauncher.TurnOffRopes");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTakedownTarget;
    /// <summary>
    /// Function: GetTakedownTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetTakedownTarget(float DropTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTakedownTarget, "BmGame.RSpecialMoveInstance_LineLauncher.GetTakedownTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DropTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetGrabTarget;
    /// <summary>
    /// Function: GetGrabTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMPawnAI GetGrabTarget(float GrabTime, float MinOffsetForGrab, float MaxSpeed, float LineLauncherAccel, bool bOnlyGrabHostage, out BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherGrabType GrabType, out BmSDK.BmGame.RBMPawnAI _PotentialGrabTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrabTarget, "BmGame.RSpecialMoveInstance_LineLauncher.GetGrabTarget");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrabTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinOffsetForGrab, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxSpeed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineLauncherAccel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyGrabHostage, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out GrabType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrabType, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out _PotentialGrabTarget);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_PotentialGrabTarget, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        GrabType = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherGrabType>(paramsPtr + 20);
        _PotentialGrabTarget = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMPawnAI>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMPawnAI>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetKickTarget;
    /// <summary>
    /// Function: GetKickTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetKickTarget(float KickTime, float LeftKickTime, float RightKickTime, float MinOffsetForFwdKick, float MaxSpeed, float LineLauncherAccel, out BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherKickDirection KickDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKickTarget, "BmGame.RSpecialMoveInstance_LineLauncher.GetKickTarget");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KickTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftKickTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightKickTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinOffsetForFwdKick, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxSpeed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineLauncherAccel, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out KickDir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KickDir, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        KickDir = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherKickDirection>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ShouldIDoLandAnim;
    /// <summary>
    /// Function: ShouldIDoLandAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherDismountType ShouldIDoLandAnim(out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Locator, float MinLandHeight, float MaxLandHeight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldIDoLandAnim, "BmGame.RSpecialMoveInstance_LineLauncher.ShouldIDoLandAnim");
        byte* paramsPtr = stackalloc byte[141];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Locator);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Locator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinLandHeight, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxLandHeight, paramsPtr + 136);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Locator = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherDismountType>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_LineLauncherMovement;
    /// <summary>
    /// Function: LineLauncherMovement
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherMovementResult LineLauncherMovement(float DeltaTime, float HorizontalSpeed, float VerticalAccel, float MaxVerticalSpeed, float WallLookAheadTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LineLauncherMovement, "BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherMovement");
        byte* paramsPtr = stackalloc byte[21];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HorizontalSpeed, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VerticalAccel, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVerticalSpeed, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLookAheadTime, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherMovementResult>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_JumpOffLineLauncher;
    /// <summary>
    /// Function: JumpOffLineLauncher
    /// </summary>
    public unsafe virtual void JumpOffLineLauncher()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JumpOffLineLauncher, "BmGame.RSpecialMoveInstance_LineLauncher.JumpOffLineLauncher");
        byte* paramsPtr = stackalloc byte[168];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGrabbedTargetReference;
    /// <summary>
    /// Function: GetGrabbedTargetReference
    /// </summary>
    public unsafe virtual void GetGrabbedTargetReference(out System.Numerics.Vector3 RefLocation, out BmSDK.Rotator RefRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrabbedTargetReference, "BmGame.RSpecialMoveInstance_LineLauncher.GetGrabbedTargetReference");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RefLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RefRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RefLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        RefRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CheckForPawnHits;
    /// <summary>
    /// Function: CheckForPawnHits
    /// </summary>
    public unsafe virtual void CheckForPawnHits()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForPawnHits, "BmGame.RSpecialMoveInstance_LineLauncher.CheckForPawnHits");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BumpVillain;
    /// <summary>
    /// Function: BumpVillain
    /// </summary>
    public unsafe virtual void BumpVillain(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BumpVillain, "BmGame.RSpecialMoveInstance_LineLauncher.BumpVillain");
        byte* paramsPtr = stackalloc byte[268];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoRescueLanding;
    /// <summary>
    /// Function: DoRescueLanding
    /// </summary>
    public unsafe virtual void DoRescueLanding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoRescueLanding, "BmGame.RSpecialMoveInstance_LineLauncher.DoRescueLanding");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForRescueVolume;
    /// <summary>
    /// Function: CheckForRescueVolume
    /// </summary>
    public unsafe virtual void CheckForRescueVolume()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForRescueVolume, "BmGame.RSpecialMoveInstance_LineLauncher.CheckForRescueVolume");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchHands;
    /// <summary>
    /// Function: SwitchHands
    /// </summary>
    public unsafe virtual void SwitchHands()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchHands, "BmGame.RSpecialMoveInstance_LineLauncher.SwitchHands");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrabHostage;
    /// <summary>
    /// Function: GrabHostage
    /// </summary>
    public unsafe virtual void GrabHostage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabHostage, "BmGame.RSpecialMoveInstance_LineLauncher.GrabHostage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnLineLancherWire;
    /// <summary>
    /// Function: SpawnLineLancherWire
    /// </summary>
    public unsafe virtual void SpawnLineLancherWire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnLineLancherWire, "BmGame.RSpecialMoveInstance_LineLauncher.SpawnLineLancherWire");
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerTightRope;
    /// <summary>
    /// Function: TriggerTightRope
    /// </summary>
    public unsafe virtual void TriggerTightRope()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerTightRope, "BmGame.RSpecialMoveInstance_LineLauncher.TriggerTightRope");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoteEvent;
    /// <summary>
    /// Function: RemoteEvent
    /// </summary>
    public unsafe override void RemoteEvent(BmSDK.FName EventName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoteEvent, "BmGame.RSpecialMoveInstance_LineLauncher.RemoteEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanTakeDownTarget;
    /// <summary>
    /// Function: CanTakeDownTarget
    /// </summary>
    public unsafe virtual bool CanTakeDownTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTakeDownTarget, "BmGame.RSpecialMoveInstance_LineLauncher.CanTakeDownTarget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HandleAction;
    /// <summary>
    /// Function: HandleAction
    /// </summary>
    public unsafe override void HandleAction(BmSDK.FName actionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleAction, "BmGame.RSpecialMoveInstance_LineLauncher.HandleAction");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAiming;
    /// <summary>
    /// Function: StopAiming
    /// </summary>
    public unsafe virtual void StopAiming(float SlowMoFadeOutTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAiming, "BmGame.RSpecialMoveInstance_LineLauncher.StopAiming");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlowMoFadeOutTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAiming;
    /// <summary>
    /// Function: StartAiming
    /// </summary>
    public unsafe virtual void StartAiming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAiming, "BmGame.RSpecialMoveInstance_LineLauncher.StartAiming");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmGame.RSpecialMoveInstance_LineLauncher.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: LineLauncherTakedownFinish
    /// </summary>
    public enum LineLauncherTakedownFinish : byte
    {
        LLFM_Drop = 0,
        LLFM_WallSlam = 1,
        LLFM_Land = 2,
        LLFM_MAX = 3,
    }

    /// <summary>
    /// Enum: LineLauncherGrabType
    /// </summary>
    public enum LineLauncherGrabType : byte
    {
        LLGT_GrabLeft = 0,
        LLGT_GrabRight = 1,
        LLGT_MAX = 2,
    }

    /// <summary>
    /// Enum: LineLauncherDismountType
    /// </summary>
    public enum LineLauncherDismountType : byte
    {
        LLDT_None = 0,
        LLDT_Land = 1,
        LLDT_WallLand = 2,
        LLDT_WallFall = 3,
        LLDT_Climb = 4,
        LLDT_MAX = 5,
    }

    /// <summary>
    /// Enum: LineLauncherMovementResult
    /// </summary>
    public enum LineLauncherMovementResult : byte
    {
        LLMR_AllFine = 0,
        LLMR_HitObstacle = 1,
        LLMR_HitWall = 2,
        LLMR_TooHigh = 3,
        LLMR_MAX = 4,
    }

    /// <summary>
    /// Enum: LineLauncherKickDirection
    /// </summary>
    public enum LineLauncherKickDirection : byte
    {
        LLKD_ForwardKick = 0,
        LLKD_LeftKick = 1,
        LLKD_RightKick = 2,
        LLKD_MAX = 3,
    }

    /// <summary>
    /// StructProperty: Transition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Transition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 876);

    /// <summary>
    /// StructProperty: GrabTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GrabTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 880);

    /// <summary>
    /// IntProperty: StationaryCount
    /// </summary>
    public unsafe int StationaryCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// IntProperty: TooHighCount
    /// </summary>
    public unsafe int TooHighCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// FloatProperty: CurrentSpeed
    /// </summary>
    public unsafe float CurrentSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// StructProperty: OldPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OldPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 896);

    /// <summary>
    /// ObjectProperty: KickTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain KickTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: RescueTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI RescueTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: GrabbedHostage
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI GrabbedHostage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ObjectProperty: ControlledHostageBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour ControlledHostageBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: RescueVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncherRescueVolume RescueVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncherRescueVolume>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ObjectProperty: HostageVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncherRescueVolume HostageVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncherRescueVolume>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ObjectProperty: TargetedHostage
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI TargetedHostage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: PotentialGrabTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PotentialGrabTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ObjectProperty: GrabTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain GrabTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ObjectProperty: GrabbedVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain GrabbedVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ObjectProperty: ControlledVillainBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour ControlledVillainBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// ObjectProperty: TakedownTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain TakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ObjectProperty: ThroughWindow
    /// </summary>
    public unsafe BmSDK.Engine.Actor ThroughWindow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ObjectProperty: KickableWallComingUp
    /// </summary>
    public unsafe BmSDK.Engine.Actor KickableWallComingUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ObjectProperty: MyConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig_LineLauncher MyConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig_LineLauncher>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: FakeRopeComp
    /// </summary>
    public InlineArray<BmSDK.BmGame.RSimpleRopeComponent> FakeRopeComp => new(2, Ptr + 1028, 8, this);

    /// <summary>
    /// ComponentProperty: FakeRopeComp
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent FakeRopeComp_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }
    /// <summary>
    /// ComponentProperty: FakeRopeComp
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent FakeRopeComp_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// StructProperty: KickOverlay
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId KickOverlay
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 1044);

    /// <summary>
    /// BoolProperty: bGrabHostageMode
    /// </summary>
    public unsafe bool bGrabHostageMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bGrabVillainMode
    /// </summary>
    public unsafe bool bGrabVillainMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bNoisyTakedownMode
    /// </summary>
    public unsafe bool bNoisyTakedownMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bFearTakedownMode
    /// </summary>
    public unsafe bool bFearTakedownMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bAllowNextAttack
    /// </summary>
    public unsafe bool bAllowNextAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bIsRailingComingUp
    /// </summary>
    public unsafe bool bIsRailingComingUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bAiming
    /// </summary>
    public unsafe bool bAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bWaitForReleasedAimButton
    /// </summary>
    public unsafe bool bWaitForReleasedAimButton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bQueuedWireWalk
    /// </summary>
    public unsafe bool bQueuedWireWalk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bUpdateGrabbedPawnLocation
    /// </summary>
    public unsafe bool bUpdateGrabbedPawnLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bGrabPressed
    /// </summary>
    public unsafe bool bGrabPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bAttackPressed
    /// </summary>
    public unsafe bool bAttackPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: PreviousLLKicked
    /// </summary>
    public unsafe bool PreviousLLKicked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bAnimationIsMirrored
    /// </summary>
    public unsafe bool bAnimationIsMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: TightRopeAvailable
    /// </summary>
    public unsafe bool TightRopeAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bKickFailed
    /// </summary>
    public unsafe bool bKickFailed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bSwitchedPlayers
    /// </summary>
    public unsafe bool bSwitchedPlayers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredCamera
    /// </summary>
    public unsafe bool bTriggeredCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: MaxPotentialGrabTargetDistance
    /// </summary>
    public unsafe float MaxPotentialGrabTargetDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// StructProperty: GrabVillainOverlay
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId GrabVillainOverlay
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 1060);

    /// <summary>
    /// FloatProperty: CurrentZSpeed
    /// </summary>
    public unsafe float CurrentZSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// ArrayProperty: NumKicks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pawn> NumKicks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pawn>>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ArrayProperty: NumDodges
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pawn> NumDodges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pawn>>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// FloatProperty: LastSideDiffSizeSquared2D
    /// </summary>
    public unsafe float LastSideDiffSizeSquared2D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// StructProperty: VictimLeftOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VictimLeftOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1108);

    /// <summary>
    /// StructProperty: VictimRightOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VictimRightOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1120);

    /// <summary>
    /// FloatProperty: TakedownWallLookAhead
    /// </summary>
    public unsafe float TakedownWallLookAhead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: SlowMoFactor
    /// </summary>
    public unsafe float SlowMoFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: DistanceToWall
    /// </summary>
    public unsafe float DistanceToWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ByteProperty: CurrentKickDir
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherKickDirection CurrentKickDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherKickDirection>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ByteProperty: CurrentGrabType
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherGrabType CurrentGrabType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherGrabType>(Ptr + 1145); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1145); }
    }

    /// <summary>
    /// ByteProperty: LastGrabType
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherGrabType LastGrabType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveInstance_LineLauncher.LineLauncherGrabType>(Ptr + 1146); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1146); }
    }
}
