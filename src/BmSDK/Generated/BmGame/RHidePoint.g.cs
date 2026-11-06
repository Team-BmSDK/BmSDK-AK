#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHidePoint<br/>
/// (size = 1288)
/// (flags = 2292187794)
/// </summary>
public partial class RHidePoint : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHidePoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHidePoint.
    /// </summary>
    public static RHidePoint DefaultObject => (RHidePoint)StaticClass().DefaultObject;

    internal RHidePoint() { }

    /// <summary>
    /// Constructs a new RHidePoint
    /// </summary>
    public RHidePoint(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHidePoint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_TriedToGrappleToUnusableHidePoint;
    /// <summary>
    /// Function: TriedToGrappleToUnusableHidePoint
    /// </summary>
    public unsafe virtual void TriedToGrappleToUnusableHidePoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriedToGrappleToUnusableHidePoint, "BmGame.RHidePoint.TriedToGrappleToUnusableHidePoint");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveHidePoint;
    /// <summary>
    /// Function: MoveHidePoint
    /// </summary>
    public unsafe virtual void MoveHidePoint(System.Numerics.Vector3 InputDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveHidePoint, "BmGame.RHidePoint.MoveHidePoint");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsActorTiedTo;
    /// <summary>
    /// Function: IsActorTiedTo
    /// </summary>
    public unsafe virtual bool IsActorTiedTo(BmSDK.Engine.Actor TestActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActorTiedTo, "BmGame.RHidePoint.IsActorTiedTo");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddAttachedRope;
    /// <summary>
    /// Function: AddAttachedRope
    /// </summary>
    public unsafe virtual void AddAttachedRope(BmSDK.BmGame.RRopeBase Rope)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAttachedRope, "BmGame.RHidePoint.AddAttachedRope");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rope, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAttachedRopes;
    /// <summary>
    /// Function: RemoveAttachedRopes
    /// </summary>
    public unsafe virtual void RemoveAttachedRopes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAttachedRopes, "BmGame.RHidePoint.RemoveAttachedRopes");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsValidVantageMineTarget;
    /// <summary>
    /// Function: IsValidVantageMineTarget
    /// </summary>
    public unsafe virtual bool IsValidVantageMineTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidVantageMineTarget, "BmGame.RHidePoint.IsValidVantageMineTarget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WillSmashIfShot;
    /// <summary>
    /// Function: WillSmashIfShot
    /// </summary>
    public unsafe virtual bool WillSmashIfShot()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillSmashIfShot, "BmGame.RHidePoint.WillSmashIfShot");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnlinkToActor;
    /// <summary>
    /// Function: UnlinkToActor
    /// </summary>
    public unsafe override bool UnlinkToActor(BmSDK.Engine.Actor LinkTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlinkToActor, "BmGame.RHidePoint.UnlinkToActor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TriggerScanFX;
    /// <summary>
    /// Function: TriggerScanFX
    /// </summary>
    public unsafe virtual void TriggerScanFX(BmSDK.Engine.ParticleSystem ScanFX)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerScanFX, "BmGame.RHidePoint.TriggerScanFX");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanFX, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasThermalCheckFloorPos;
    /// <summary>
    /// Function: HasThermalCheckFloorPos
    /// </summary>
    public unsafe virtual bool HasThermalCheckFloorPos(out System.Numerics.Vector3 FloorPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasThermalCheckFloorPos, "BmGame.RHidePoint.HasThermalCheckFloorPos");
        byte* paramsPtr = stackalloc byte[32];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FloorPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FloorPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FloorPos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsHidePointLinked;
    /// <summary>
    /// Function: IsHidePointLinked
    /// </summary>
    public unsafe virtual bool IsHidePointLinked(BmSDK.BmGame.RHidePoint TestPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHidePointLinked, "BmGame.RHidePoint.IsHidePointLinked");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TriggerGrappledToEvents;
    /// <summary>
    /// Function: TriggerGrappledToEvents
    /// </summary>
    public unsafe virtual void TriggerGrappledToEvents()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGrappledToEvents, "BmGame.RHidePoint.TriggerGrappledToEvents");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsSmashed;
    /// <summary>
    /// Function: IsSmashed
    /// </summary>
    public unsafe virtual bool IsSmashed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSmashed, "BmGame.RHidePoint.IsSmashed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TakeGunDamage;
    /// <summary>
    /// Function: TakeGunDamage
    /// </summary>
    public unsafe virtual void TakeGunDamage(float DamageAmount, BmSDK.BmGame.RBMPawnAI AttackingPawn, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeGunDamage, "BmGame.RHidePoint.TakeGunDamage");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackingPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnhidePlayers;
    /// <summary>
    /// Function: UnhidePlayers
    /// </summary>
    public unsafe virtual void UnhidePlayers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnhidePlayers, "BmGame.RHidePoint.UnhidePlayers");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayers;
    /// <summary>
    /// Function: GetPlayers
    /// </summary>
    public unsafe virtual bool GetPlayers(out BmSDK.TArray<BmSDK.BmGame.RPlayerController> PlayersOnVantagePoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayers, "BmGame.RHidePoint.GetPlayers");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PlayersOnVantagePoint = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPlayerController>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetGrappleCameraRoot;
    /// <summary>
    /// Function: GetGrappleCameraRoot
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGrappleCameraRoot(BmSDK.BmGame.RPawnPlayer Pawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrappleCameraRoot, "BmGame.RHidePoint.GetGrappleCameraRoot");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_MountGargoyle;
    /// <summary>
    /// Function: MountGargoyle
    /// </summary>
    public unsafe virtual void MountGargoyle(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MountGargoyle, "BmGame.RHidePoint.MountGargoyle");
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "BmGame.RHidePoint.Bump");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "BmGame.RHidePoint.Touch");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGrappleSound;
    /// <summary>
    /// Function: GetGrappleSound
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetGrappleSound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrappleSound, "BmGame.RHidePoint.GetGrappleSound");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyRopeCut;
    /// <summary>
    /// Function: NotifyRopeCut
    /// </summary>
    public unsafe virtual void NotifyRopeCut(BmSDK.BmGame.RBatarangProjectile Brang)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyRopeCut, "BmGame.RHidePoint.NotifyRopeCut");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Brang, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadDestroyedState;
    /// <summary>
    /// Function: LoadDestroyedState
    /// </summary>
    public unsafe virtual void LoadDestroyedState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadDestroyedState, "BmGame.RHidePoint.LoadDestroyedState");
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

    private static BmSDK.Function __fn_SaveDestroyedState;
    /// <summary>
    /// Function: SaveDestroyedState
    /// </summary>
    public unsafe virtual void SaveDestroyedState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveDestroyedState, "BmGame.RHidePoint.SaveDestroyedState");
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

    private static BmSDK.Function __fn_SetDestroyedHelpText;
    /// <summary>
    /// Function: SetDestroyedHelpText
    /// </summary>
    public unsafe virtual void SetDestroyedHelpText()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDestroyedHelpText, "BmGame.RHidePoint.SetDestroyedHelpText");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamagedByBomb;
    /// <summary>
    /// Function: DamagedByBomb
    /// </summary>
    public unsafe virtual void DamagedByBomb()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedByBomb, "BmGame.RHidePoint.DamagedByBomb");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleCanJumpOff;
    /// <summary>
    /// Function: ToggleCanJumpOff
    /// </summary>
    public unsafe virtual void ToggleCanJumpOff(BmSDK.BmGame.RSeqAct_ToggleCanJumpOffVantagePoint Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleCanJumpOff, "BmGame.RHidePoint.ToggleCanJumpOff");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RHidePoint.PreStreamOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RHidePoint.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggle;
    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe virtual void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggle, "BmGame.RHidePoint.OnToggle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShutDown;
    /// <summary>
    /// Function: ShutDown
    /// </summary>
    public unsafe override void ShutDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutDown, "BmGame.RHidePoint.ShutDown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveMine;
    /// <summary>
    /// Function: RemoveMine
    /// </summary>
    public unsafe virtual void RemoveMine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveMine, "BmGame.RHidePoint.RemoveMine");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestMineAttachPoint;
    /// <summary>
    /// Function: RequestMineAttachPoint
    /// </summary>
    public unsafe virtual bool RequestMineAttachPoint(System.Numerics.Vector3 TargetHintLoc, BmSDK.Rotator ThrowDir, out System.Numerics.Vector3 mineLoc, out BmSDK.Rotator MineRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestMineAttachPoint, "BmGame.RHidePoint.RequestMineAttachPoint");
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetHintLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out mineLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mineLoc, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MineRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MineRot, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        mineLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        MineRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_GetMineAttachSocketWorldLocationAndRotation;
    /// <summary>
    /// Function: GetMineAttachSocketWorldLocationAndRotation
    /// </summary>
    public unsafe virtual bool GetMineAttachSocketWorldLocationAndRotation(BmSDK.FName InSocketName, out System.Numerics.Vector3 OutLocation, out BmSDK.Rotator OutRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMineAttachSocketWorldLocationAndRotation, "BmGame.RHidePoint.GetMineAttachSocketWorldLocationAndRotation");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSocketName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutLocation, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutRotation, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        OutRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetPlayerPerchPosition;
    /// <summary>
    /// Function: GetPlayerPerchPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPlayerPerchPosition(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerPerchPosition, "BmGame.RHidePoint.GetPlayerPerchPosition");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetRedHoodPerchPosition;
    /// <summary>
    /// Function: GetRedHoodPerchPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRedHoodPerchPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRedHoodPerchPosition, "BmGame.RHidePoint.GetRedHoodPerchPosition");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCatwomanPerchPosition;
    /// <summary>
    /// Function: GetCatwomanPerchPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCatwomanPerchPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCatwomanPerchPosition, "BmGame.RHidePoint.GetCatwomanPerchPosition");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatmanPerchPosition;
    /// <summary>
    /// Function: GetBatmanPerchPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBatmanPerchPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatmanPerchPosition, "BmGame.RHidePoint.GetBatmanPerchPosition");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGrapplePosition;
    /// <summary>
    /// Function: GetGrapplePosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGrapplePosition(System.Numerics.Vector3 CheckLocation, System.Numerics.Vector3 CheckDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrapplePosition, "BmGame.RHidePoint.GetGrapplePosition");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDirection, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_DeactivateForGrapple;
    /// <summary>
    /// Function: DeactivateForGrapple
    /// </summary>
    public unsafe virtual void DeactivateForGrapple()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateForGrapple, "BmGame.RHidePoint.DeactivateForGrapple");
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

    private static BmSDK.Function __fn_ActivateForGrapple;
    /// <summary>
    /// Function: ActivateForGrapple
    /// </summary>
    public unsafe virtual void ActivateForGrapple()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateForGrapple, "BmGame.RHidePoint.ActivateForGrapple");
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

    private static BmSDK.Function __fn_DisableHidePoint;
    /// <summary>
    /// Function: DisableHidePoint
    /// </summary>
    public unsafe virtual void DisableHidePoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableHidePoint, "BmGame.RHidePoint.DisableHidePoint");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanUseInCinematicMode;
    /// <summary>
    /// Function: CanUseInCinematicMode
    /// </summary>
    public unsafe virtual bool CanUseInCinematicMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseInCinematicMode, "BmGame.RHidePoint.CanUseInCinematicMode");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindClosestPawnRotation;
    /// <summary>
    /// Function: FindClosestPawnRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator FindClosestPawnRotation(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindClosestPawnRotation, "BmGame.RHidePoint.FindClosestPawnRotation");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_InstantMovePawnTo;
    /// <summary>
    /// Function: InstantMovePawnTo
    /// </summary>
    public unsafe virtual void InstantMovePawnTo(BmSDK.BmGame.RPlayerController lPC, BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantMovePawnTo, "BmGame.RHidePoint.InstantMovePawnTo");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(lPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MovePawnTo;
    /// <summary>
    /// Function: MovePawnTo
    /// </summary>
    public unsafe virtual void MovePawnTo(BmSDK.Engine.Pawn PawnToMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovePawnTo, "BmGame.RHidePoint.MovePawnTo");
        byte* paramsPtr = stackalloc byte[200];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnToMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartedMountMove;
    /// <summary>
    /// Function: StartedMountMove
    /// </summary>
    public unsafe virtual void StartedMountMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartedMountMove, "BmGame.RHidePoint.StartedMountMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvestigateHighlighted;
    /// <summary>
    /// Function: SetInvestigateHighlighted
    /// </summary>
    public unsafe override void SetInvestigateHighlighted(BmSDK.Engine.MaterialInstanceConstant highMat, bool On)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvestigateHighlighted, "BmGame.RHidePoint.SetInvestigateHighlighted");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(highMat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLinkedHidePointsHighlight;
    /// <summary>
    /// Function: SetLinkedHidePointsHighlight
    /// </summary>
    public unsafe virtual void SetLinkedHidePointsHighlight(bool bHighlight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLinkedHidePointsHighlight, "BmGame.RHidePoint.SetLinkedHidePointsHighlight");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHighlight, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassessCanGrapple;
    /// <summary>
    /// Function: ReassessCanGrapple
    /// </summary>
    public unsafe virtual void ReassessCanGrapple()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassessCanGrapple, "BmGame.RHidePoint.ReassessCanGrapple");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RedHoodLeft;
    /// <summary>
    /// Function: RedHoodLeft
    /// </summary>
    public unsafe virtual void RedHoodLeft(BmSDK.BmGame.RSpecialMoveConfig NewBatmanSwingMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RedHoodLeft, "BmGame.RHidePoint.RedHoodLeft");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBatmanSwingMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RedHoodEntered;
    /// <summary>
    /// Function: RedHoodEntered
    /// </summary>
    public unsafe virtual void RedHoodEntered(BmSDK.BmGame.RPawnVillain Redhood, BmSDK.BmGame.RSpecialMoveConfig NewBatmanSwingMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RedHoodEntered, "BmGame.RHidePoint.RedHoodEntered");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Redhood, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBatmanSwingMove, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KickVillainOffVantagePoint;
    /// <summary>
    /// Function: KickVillainOffVantagePoint
    /// </summary>
    public unsafe virtual void KickVillainOffVantagePoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KickVillainOffVantagePoint, "BmGame.RHidePoint.KickVillainOffVantagePoint");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanKickVillainOff;
    /// <summary>
    /// Function: CanKickVillainOff
    /// </summary>
    public unsafe virtual bool CanKickVillainOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanKickVillainOff, "BmGame.RHidePoint.CanKickVillainOff");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMine;
    /// <summary>
    /// Function: SetMine
    /// </summary>
    public unsafe virtual void SetMine(BmSDK.BmGame.RVantageMineBase NewMine)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMine, "BmGame.RHidePoint.SetMine");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMine, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMine;
    /// <summary>
    /// Function: GetMine
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RVantageMineBase GetMine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMine, "BmGame.RHidePoint.GetMine");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RVantageMineBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BMLeft;
    /// <summary>
    /// Function: BMLeft
    /// </summary>
    public unsafe virtual void BMLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BMLeft, "BmGame.RHidePoint.BMLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BMEntered;
    /// <summary>
    /// Function: BMEntered
    /// </summary>
    public unsafe virtual void BMEntered()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BMEntered, "BmGame.RHidePoint.BMEntered");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPlayerOnVantagePoint;
    /// <summary>
    /// Function: IsPlayerOnVantagePoint
    /// </summary>
    public unsafe virtual bool IsPlayerOnVantagePoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerOnVantagePoint, "BmGame.RHidePoint.IsPlayerOnVantagePoint");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPerfectConcealment;
    /// <summary>
    /// Function: GetPerfectConcealment
    /// </summary>
    public unsafe virtual bool GetPerfectConcealment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPerfectConcealment, "BmGame.RHidePoint.GetPerfectConcealment");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPerfectConcealment;
    /// <summary>
    /// Function: SetPerfectConcealment
    /// </summary>
    public unsafe virtual void SetPerfectConcealment(bool bNewPerfectConcealment)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPerfectConcealment, "BmGame.RHidePoint.SetPerfectConcealment");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewPerfectConcealment, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInThermalMode;
    /// <summary>
    /// Function: SetInThermalMode
    /// </summary>
    public unsafe virtual void SetInThermalMode(bool On, bool bForceOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInThermalMode, "BmGame.RHidePoint.SetInThermalMode");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAIPointOfInterestPosition;
    /// <summary>
    /// Function: GetAIPointOfInterestPosition
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetAIPointOfInterestPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIPointOfInterestPosition, "BmGame.RHidePoint.GetAIPointOfInterestPosition");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BMInverting;
    /// <summary>
    /// Function: BMInverting
    /// </summary>
    public unsafe virtual void BMInverting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BMInverting, "BmGame.RHidePoint.BMInverting");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFOVCheckLocation;
    /// <summary>
    /// Function: GetFOVCheckLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetFOVCheckLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVCheckLocation, "BmGame.RHidePoint.GetFOVCheckLocation");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLinkedHidePoint;
    /// <summary>
    /// Function: GetLinkedHidePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetLinkedHidePoint(int I)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLinkedHidePoint, "BmGame.RHidePoint.GetLinkedHidePoint");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(I, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint>(paramsPtr + 4);
    }

    /// <summary>
    /// Enum: EForceVantageCameraSide
    /// </summary>
    public enum EForceVantageCameraSide : byte
    {
        EFCS_Either = 0,
        EFCS_Left = 1,
        EFCS_Right = 2,
        EFCS_MAX = 3,
    }

    /// <summary>
    /// Enum: EVantageWallInfo
    /// </summary>
    public enum EVantageWallInfo : byte
    {
        VWI_Default = 0,
        VWI_TwoWallCorner = 1,
        VWI_PlainWall = 2,
        VWI_MAX = 3,
    }

    /// <summary>
    /// Struct: FCantJumpOffArc
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FCantJumpOffArc
    {
        /// <summary>
        /// IntProperty: MinYaw
        /// </summary>
        public unsafe int MinYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: MaxYaw
        /// </summary>
        public unsafe int MaxYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FHideLink
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FHideLink
    {
        /// <summary>
        /// StructProperty: SwingPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: TravelTime
        /// </summary>
        public unsafe float TravelTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: MidPoint
        /// </summary>
        public unsafe System.Numerics.Vector3 MidPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// BoolProperty: bForceCeilingGrateNoisyTakedown
    /// </summary>
    public unsafe bool bForceCeilingGrateNoisyTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bForceCeilingGrateFearTakedown
    /// </summary>
    public unsafe bool bForceCeilingGrateFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bPerfectConcealment
    /// </summary>
    public unsafe bool bPerfectConcealment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bPlayerOnVantage
    /// </summary>
    public unsafe bool bPlayerOnVantage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bGrappleVantagePoint
    /// </summary>
    public unsafe bool bGrappleVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bSwingHidePoint
    /// </summary>
    public unsafe bool bSwingHidePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bNoGrappleBoost
    /// </summary>
    public unsafe bool bNoGrappleBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanHang
    /// </summary>
    public unsafe bool bCanHang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanSwing
    /// </summary>
    public unsafe bool bCanSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDisplayAutomaticHelp
    /// </summary>
    public unsafe bool bDisplayAutomaticHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: BatmanCanJumpOff
    /// </summary>
    public unsafe bool BatmanCanJumpOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: DestroyedByBomb
    /// </summary>
    public unsafe bool DestroyedByBomb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDestroyedByGunfire
    /// </summary>
    public unsafe bool bDestroyedByGunfire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: CanGrappleFromOtherLevels
    /// </summary>
    public unsafe bool CanGrappleFromOtherLevels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCacheDestroyVantagePointsDone
    /// </summary>
    public unsafe bool bCacheDestroyVantagePointsDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bFailedToFindThermalStandPoint
    /// </summary>
    public unsafe bool bFailedToFindThermalStandPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: ValidHidePoint
    /// </summary>
    public unsafe bool ValidHidePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bUnusableHidePoint
    /// </summary>
    public unsafe bool bUnusableHidePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bSuppressUnusableGrappleEvent
    /// </summary>
    public unsafe bool bSuppressUnusableGrappleEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bLowPriorityHidePoint
    /// </summary>
    public unsafe bool bLowPriorityHidePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredWithPoly
    /// </summary>
    public unsafe bool bRegisteredWithPoly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanGrappleBoost
    /// </summary>
    public unsafe bool bCanGrappleBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: AutoAdjustOnPathBuild
    /// </summary>
    public unsafe bool AutoAdjustOnPathBuild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: OnlyForGlideSwinging
    /// </summary>
    public unsafe bool OnlyForGlideSwinging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDisallowVantageMines
    /// </summary>
    public unsafe bool bDisallowVantageMines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreDirectPounceCollision
    /// </summary>
    public unsafe bool bIgnoreDirectPounceCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bSwingOnly
    /// </summary>
    public unsafe bool bSwingOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bRobinHidePoint
    /// </summary>
    public unsafe bool bRobinHidePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bControllable
    /// </summary>
    public unsafe bool bControllable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bOwnedByPlayer
    /// </summary>
    public unsafe bool bOwnedByPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bMarkedForHangingTakedownExploitPreventionMine
    /// </summary>
    public unsafe bool bMarkedForHangingTakedownExploitPreventionMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalVantageRotation
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Rotator> AdditionalVantageRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Rotator>>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalVantagePointYaw
    /// </summary>
    public unsafe BmSDK.TArray<float> AdditionalVantagePointYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalArrowComponent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ArrowComponent> AdditionalArrowComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ArrowComponent>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ComponentProperty: GargoyleMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent GargoyleMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StructProperty: HangOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HangOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 728);

    /// <summary>
    /// StructProperty: GrappleIconOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleIconOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 740);

    /// <summary>
    /// FloatProperty: VantagePointRange
    /// </summary>
    public unsafe float VantagePointRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: HangMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: RecoverMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RecoverMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: RecoverMoveAfterGrab
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RecoverMoveAfterGrab
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: SwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndGargoyleMoveLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndGargoyleMoveLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndGargoyleMoveRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndGargoyleMoveRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: AerialMountMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig AerialMountMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: DropOffVantagePointMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DropOffVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: DropOffFrontVantagePointMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DropOffFrontVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: VillainOnVantage
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain VillainOnVantage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel1
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsCrossLevel1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel2
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsCrossLevel2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel3
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsCrossLevel3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel4
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsCrossLevel4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel5
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsCrossLevel5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel6
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsCrossLevel6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel7
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsCrossLevel7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel8
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsCrossLevel8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: LinkedHidePointsSameLevel
    /// </summary>
    public InlineArray<BmSDK.BmGame.RHidePoint> LinkedHidePointsSameLevel => new(8, Ptr + 900, 8, this);

    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsSameLevel_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsSameLevel_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsSameLevel_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsSameLevel_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsSameLevel_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsSameLevel_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsSameLevel_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LinkedHidePointsSameLevel_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: Bomb
    /// </summary>
    public unsafe BmSDK.BmGame.RGargoyleBombBase Bomb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGargoyleBombBase>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ObjectProperty: GrappleImpactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GrappleImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ObjectProperty: ThermalStandPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget ThermalStandPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ObjectProperty: ClimbLocators
    /// </summary>
    public unsafe BmSDK.BmGame.RClimbLocatorContainer ClimbLocators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RClimbLocatorContainer>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// ObjectProperty: SpawnedPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHangPointSpawnable SpawnedPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHangPointSpawnable>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ObjectProperty: Mine
    /// </summary>
    public unsafe BmSDK.BmGame.RVantageMineBase Mine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVantageMineBase>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ComponentProperty: BadSprite
    /// </summary>
    public unsafe BmSDK.Engine.SpriteComponent BadSprite
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpriteComponent>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ComponentProperty: GoodSprite
    /// </summary>
    public unsafe BmSDK.Engine.SpriteComponent GoodSprite
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpriteComponent>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// StructProperty: RopeAttachPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RopeAttachPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1028);

    /// <summary>
    /// FloatProperty: StoredRopeLengthForFear
    /// </summary>
    public unsafe float StoredRopeLengthForFear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: ConstrainRagdollBoxRadius
    /// </summary>
    public unsafe float ConstrainRagdollBoxRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ArrayProperty: HidePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHidePoint.FHideLink> HidePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHidePoint.FHideLink>>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: HidePointCrossLevel
    /// </summary>
    public InlineArray<byte> HidePointCrossLevel => new(8, Ptr + 1064, 1, this);

    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1065); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1065); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1066); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1066); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1067); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1067); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1069); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1069); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1070); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1070); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1071); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1071); }
    }

    /// <summary>
    /// ByteProperty: WallInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint.EVantageWallInfo WallInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint.EVantageWallInfo>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ByteProperty: VillainOnVantageCameraSide
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint.EForceVantageCameraSide VillainOnVantageCameraSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint.EForceVantageCameraSide>(Ptr + 1073); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1073); }
    }

    /// <summary>
    /// ArrayProperty: CachedDestroyVantagePoints
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> CachedDestroyVantagePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ArrayProperty: CantJumpOff
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHidePoint.FCantJumpOffArc> CantJumpOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHidePoint.FCantJumpOffArc>>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: GunDamage
    /// </summary>
    public unsafe float GunDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// FloatProperty: GunDamageMax
    /// </summary>
    public unsafe float GunDamageMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// FloatProperty: RopeHealth
    /// </summary>
    public unsafe float RopeHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// FloatProperty: RopeDmgFromRifle
    /// </summary>
    public unsafe float RopeDmgFromRifle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// FloatProperty: RopeDmgFromShotgun
    /// </summary>
    public unsafe float RopeDmgFromShotgun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ArrayProperty: AttachedRopes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRopeBase> AttachedRopes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRopeBase>>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// StructProperty: OctTreeObject
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGrapplePoint.FGrapplePointOctreeObject OctTreeObject
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGrapplePoint.FGrapplePointOctreeObject>(Ptr + 1144);

    /// <summary>
    /// StructProperty: RegisteredWithPolyPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RegisteredWithPolyPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1212);

    /// <summary>
    /// StructProperty: CatwomanPerchOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CatwomanPerchOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1224);

    /// <summary>
    /// ArrayProperty: BlockedHidePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BlockedHidePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// FloatProperty: ExtraRCBatarangHeight
    /// </summary>
    public unsafe float ExtraRCBatarangHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// ArrayProperty: MineAttachSocketList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MineAttachSocketList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// StructProperty: ExtraSpaceCheckOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExtraSpaceCheckOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1272);

    /// <summary>
    /// FloatProperty: GrappleScoreMod
    /// </summary>
    public unsafe float GrappleScoreMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }
}
