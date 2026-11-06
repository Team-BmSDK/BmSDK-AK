#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RLineLauncher<br/>
/// (size = 2464)
/// (flags = 144703667)
/// </summary>
public partial class RLineLauncher : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RLineLauncher", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RLineLauncher.
    /// </summary>
    public static RLineLauncher DefaultObject => (RLineLauncher)StaticClass().DefaultObject;

    internal RLineLauncher() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RLineLauncher(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DropFromWireWalkToZipLine;
    /// <summary>
    /// Function: DropFromWireWalkToZipLine
    /// </summary>
    public unsafe virtual bool DropFromWireWalkToZipLine(BmSDK.BmGame.RHidePoint_RopeBase WalkingRope, BmSDK.Rotator Direction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropFromWireWalkToZipLine, "BmGame.RLineLauncher.DropFromWireWalkToZipLine");
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WalkingRope, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SwitchToWire;
    /// <summary>
    /// Function: SwitchToWire
    /// </summary>
    public unsafe virtual void SwitchToWire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchToWire, "BmGame.RLineLauncher.SwitchToWire");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnLineLauncherWire;
    /// <summary>
    /// Function: SpawnLineLauncherWire
    /// </summary>
    public unsafe virtual void SpawnLineLauncherWire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnLineLauncherWire, "BmGame.RLineLauncher.SpawnLineLauncherWire");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlignLineLauncherSwingToRoadNetwork;
    /// <summary>
    /// Function: AlignLineLauncherSwingToRoadNetwork
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 AlignLineLauncherSwingToRoadNetwork(System.Numerics.Vector3 SwingLocation, System.Numerics.Vector3 SwingDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlignLineLauncherSwingToRoadNetwork, "BmGame.RLineLauncher.AlignLineLauncherSwingToRoadNetwork");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwingLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwingDirection, paramsPtr + 12);
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

    private static BmSDK.Function __fn_TryLineLauncherDiveSwing;
    /// <summary>
    /// Function: TryLineLauncherDiveSwing
    /// </summary>
    public unsafe virtual void TryLineLauncherDiveSwing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryLineLauncherDiveSwing, "BmGame.RLineLauncher.TryLineLauncherDiveSwing");
        byte* paramsPtr = stackalloc byte[232];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryLineLaunchStop;
    /// <summary>
    /// Function: TryLineLaunchStop
    /// </summary>
    public unsafe virtual void TryLineLaunchStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryLineLaunchStop, "BmGame.RLineLauncher.TryLineLaunchStop");
        byte* paramsPtr = stackalloc byte[216];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RLineLauncher.Destroyed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainHitRope;
    /// <summary>
    /// Function: VillainHitRope
    /// </summary>
    public unsafe virtual void VillainHitRope(BmSDK.BmGame.RPawnVillain HitVillain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainHitRope, "BmGame.RLineLauncher.VillainHitRope");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckToBreakRope;
    /// <summary>
    /// Function: CheckToBreakRope
    /// </summary>
    public unsafe virtual bool CheckToBreakRope(System.Numerics.Vector3 StartPos, System.Numerics.Vector3 EndPos, bool OnlyCheckInterpActorsInFront, bool DoAccuratePawnsTest)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckToBreakRope, "BmGame.RLineLauncher.CheckToBreakRope");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlyCheckInterpActorsInFront, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoAccuratePawnsTest, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_IsActive;
    /// <summary>
    /// Function: IsActive
    /// </summary>
    public unsafe virtual bool IsActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActive, "BmGame.RLineLauncher.IsActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayCameraAnimEx;
    /// <summary>
    /// Function: PlayCameraAnimEx
    /// </summary>
    public unsafe virtual void PlayCameraAnimEx(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc, BmSDK.FName AnimName, BmSDK.Engine.AnimSet AnimSet, bool bCamMirrored, BmSDK.Engine.Actor CameraCollisionTarget, float FOV = default, System.Numerics.Vector3 CollisionTargetPos = default, bool bHardCut = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCameraAnimEx, "BmGame.RLineLauncher.PlayCameraAnimEx");
        byte* paramsPtr = stackalloc byte[196];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCamMirrored, paramsPtr + 148);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraCollisionTarget, paramsPtr + 152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 160);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionTargetPos, paramsPtr + 164);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHardCut, paramsPtr + 176);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BackToPlayerCamera;
    /// <summary>
    /// Function: BackToPlayerCamera
    /// </summary>
    public unsafe virtual void BackToPlayerCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BackToPlayerCamera, "BmGame.RLineLauncher.BackToPlayerCamera");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override bool GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RLineLauncher.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_TriggerLineLauncherCamera;
    /// <summary>
    /// Function: TriggerLineLauncherCamera
    /// </summary>
    public unsafe virtual void TriggerLineLauncherCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLineLauncherCamera, "BmGame.RLineLauncher.TriggerLineLauncherCamera");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToHand;
    /// <summary>
    /// Function: AttachToHand
    /// </summary>
    public unsafe override void AttachToHand(BmSDK.FName CustomBone = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToHand, "BmGame.RLineLauncher.AttachToHand");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RLineLauncher.Tick");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffProjectiles;
    /// <summary>
    /// Function: TurnOffProjectiles
    /// </summary>
    public unsafe override void TurnOffProjectiles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffProjectiles, "BmGame.RLineLauncher.TurnOffProjectiles");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireDualProjectiles;
    /// <summary>
    /// Function: FireDualProjectiles
    /// </summary>
    public unsafe virtual void FireDualProjectiles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireDualProjectiles, "BmGame.RLineLauncher.FireDualProjectiles");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsLineLaunchFearGasSafe;
    /// <summary>
    /// Function: IsLineLaunchFearGasSafe
    /// </summary>
    public unsafe virtual bool IsLineLaunchFearGasSafe(System.Numerics.Vector3 vStartPoint, System.Numerics.Vector3 vEndPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLineLaunchFearGasSafe, "BmGame.RLineLauncher.IsLineLaunchFearGasSafe");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vStartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vEndPoint, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_IsLineLaunchOceanSafe;
    /// <summary>
    /// Function: IsLineLaunchOceanSafe
    /// </summary>
    public unsafe virtual bool IsLineLaunchOceanSafe(System.Numerics.Vector3 vStartPoint, System.Numerics.Vector3 vEndPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLineLaunchOceanSafe, "BmGame.RLineLauncher.IsLineLaunchOceanSafe");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vStartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vEndPoint, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TraceForOutOfBounds;
    /// <summary>
    /// Function: TraceForOutOfBounds
    /// </summary>
    public unsafe virtual bool TraceForOutOfBounds(System.Numerics.Vector3 Start, System.Numerics.Vector3 End)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceForOutOfBounds, "BmGame.RLineLauncher.TraceForOutOfBounds");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TraceForHostageTakers;
    /// <summary>
    /// Function: TraceForHostageTakers
    /// </summary>
    public unsafe virtual bool TraceForHostageTakers(System.Numerics.Vector3 Start, System.Numerics.Vector3 End)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceForHostageTakers, "BmGame.RLineLauncher.TraceForHostageTakers");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TraceGuidingVolume;
    /// <summary>
    /// Function: TraceGuidingVolume
    /// </summary>
    public unsafe virtual bool TraceGuidingVolume(System.Numerics.Vector3 PlayerLocation, System.Numerics.Vector3 Start, System.Numerics.Vector3 End, out BmSDK.BmGame.RLineLauncherGuidingVolume GuidingVolume)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceGuidingVolume, "BmGame.RLineLauncher.TraceGuidingVolume");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out GuidingVolume);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GuidingVolume, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        GuidingVolume = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RLineLauncherGuidingVolume>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_TraceRescueVolume;
    /// <summary>
    /// Function: TraceRescueVolume
    /// </summary>
    public unsafe virtual bool TraceRescueVolume(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, out BmSDK.BmGame.RLineLauncherRescueVolume HostagePickupVolume, out BmSDK.BmGame.RLineLauncherRescueVolume RescueSafeZoneVolume)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceRescueVolume, "BmGame.RLineLauncher.TraceRescueVolume");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HostagePickupVolume);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HostagePickupVolume, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RescueSafeZoneVolume);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RescueSafeZoneVolume, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HostagePickupVolume = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RLineLauncherRescueVolume>(paramsPtr + 24);
        RescueSafeZoneVolume = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RLineLauncherRescueVolume>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetLineLauncherTetherPoints;
    /// <summary>
    /// Function: GetLineLauncherTetherPoints
    /// </summary>
    public unsafe virtual bool GetLineLauncherTetherPoints(out System.Numerics.Vector3 RearPoint, out System.Numerics.Vector3 FrontPoint, out System.Numerics.Vector3 ActorStartPoint, out System.Numerics.Vector3 ActorEndPoint, System.Numerics.Vector3 CurrentPosition, System.Numerics.Vector3 CameraLoc, System.Numerics.Vector3 CurrentFacing, System.Numerics.Vector3 TargetLoc = default, bool bDebugTrace = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLineLauncherTetherPoints, "BmGame.RLineLauncher.GetLineLauncherTetherPoints");
        byte* paramsPtr = stackalloc byte[104];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RearPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RearPoint, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FrontPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrontPoint, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ActorStartPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorStartPoint, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ActorEndPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorEndPoint, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPosition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLoc, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentFacing, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugTrace, paramsPtr + 96);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RearPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        FrontPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        ActorStartPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        ActorEndPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 100);
    }

    private static BmSDK.Function __fn_IncremementZipSpeed;
    /// <summary>
    /// Function: IncremementZipSpeed
    /// </summary>
    public unsafe virtual void IncremementZipSpeed(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncremementZipSpeed, "BmGame.RLineLauncher.IncremementZipSpeed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryFireLineLauncher;
    /// <summary>
    /// Function: TryFireLineLauncher
    /// </summary>
    public unsafe virtual bool TryFireLineLauncher()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryFireLineLauncher, "BmGame.RLineLauncher.TryFireLineLauncher");
        byte* paramsPtr = stackalloc byte[184];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FailedFiringLineLauncher;
    /// <summary>
    /// Function: FailedFiringLineLauncher
    /// </summary>
    public unsafe virtual void FailedFiringLineLauncher()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FailedFiringLineLauncher, "BmGame.RLineLauncher.FailedFiringLineLauncher");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetClosestPointOnLine;
    /// <summary>
    /// Function: GetClosestPointOnLine
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClosestPointOnLine(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 TestPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestPointOnLine, "BmGame.RLineLauncher.GetClosestPointOnLine");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_FireProjectiles;
    /// <summary>
    /// Function: FireProjectiles
    /// </summary>
    public unsafe virtual void FireProjectiles(System.Numerics.Vector3 ProjectileTarget, System.Numerics.Vector3 ProjectileTarget2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireProjectiles, "BmGame.RLineLauncher.FireProjectiles");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjectileTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjectileTarget2, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawAimingHUD;
    /// <summary>
    /// Function: DrawAimingHUD
    /// </summary>
    public unsafe virtual void DrawAimingHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawAimingHUD, "BmGame.RLineLauncher.DrawAimingHUD");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideAimingHud;
    /// <summary>
    /// Function: HideAimingHud
    /// </summary>
    public unsafe virtual void HideAimingHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideAimingHud, "BmGame.RLineLauncher.HideAimingHud");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsSafeToFire;
    /// <summary>
    /// Function: IsSafeToFire
    /// </summary>
    public unsafe virtual bool IsSafeToFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSafeToFire, "BmGame.RLineLauncher.IsSafeToFire");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GoodFireAngle;
    /// <summary>
    /// Function: GoodFireAngle
    /// </summary>
    public unsafe virtual bool GoodFireAngle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoodFireAngle, "BmGame.RLineLauncher.GoodFireAngle");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryHostageAlignedTargeting;
    /// <summary>
    /// Function: TryHostageAlignedTargeting
    /// </summary>
    public unsafe virtual bool TryHostageAlignedTargeting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryHostageAlignedTargeting, "BmGame.RLineLauncher.TryHostageAlignedTargeting");
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryAlignedTargeting;
    /// <summary>
    /// Function: TryAlignedTargeting
    /// </summary>
    public unsafe virtual bool TryAlignedTargeting(System.Numerics.Vector3 Start, System.Numerics.Vector3 End)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryAlignedTargeting, "BmGame.RLineLauncher.TryAlignedTargeting");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_UpdateAiming;
    /// <summary>
    /// Function: UpdateAiming
    /// </summary>
    public unsafe virtual void UpdateAiming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAiming, "BmGame.RLineLauncher.UpdateAiming");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanFire2ndLine;
    /// <summary>
    /// Function: CanFire2ndLine
    /// </summary>
    public unsafe virtual bool CanFire2ndLine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanFire2ndLine, "BmGame.RLineLauncher.CanFire2ndLine");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopSloMoFromFlip;
    /// <summary>
    /// Function: StopSloMoFromFlip
    /// </summary>
    public unsafe virtual void StopSloMoFromFlip()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSloMoFromFlip, "BmGame.RLineLauncher.StopSloMoFromFlip");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPrimedPose;
    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe override BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState, out BmSDK.FName OutCapeTransitionState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmGame.RLineLauncher.GetPrimedPose");
        byte* paramsPtr = stackalloc byte[36];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StanceIsCrouched);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StanceIsCrouched, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MirroredNess);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredNess, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeState, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeTransitionState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeTransitionState, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        OutCapeTransitionState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetGadgetCamera;
    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe override BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetCamera, "BmGame.RLineLauncher.GetGadgetCamera");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    /// <summary>
    /// FloatProperty: LineLauncherRange
    /// </summary>
    public unsafe float LineLauncherRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherBackRange
    /// </summary>
    public unsafe float LineLauncherBackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherHeight
    /// </summary>
    public unsafe float LineLauncherHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherPlayerHeight
    /// </summary>
    public unsafe float LineLauncherPlayerHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// FloatProperty: MinLineLauncherRange
    /// </summary>
    public unsafe float MinLineLauncherRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// FloatProperty: MinLineLauncherBackRange
    /// </summary>
    public unsafe float MinLineLauncherBackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherFireRightOffset
    /// </summary>
    public unsafe float LineLauncherFireRightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ObjectProperty: SuccessfulFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SuccessfulFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// ObjectProperty: SuccessfulFire2ndLineLeftMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SuccessfulFire2ndLineLeftMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// ObjectProperty: SuccessfulFire2ndLineRightMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SuccessfulFire2ndLineRightMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// ObjectProperty: FailedFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FailedFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ObjectProperty: LineLauncherGlideStopMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LineLauncherGlideStopMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: Projectile
    /// </summary>
    public InlineArray<BmSDK.BmGame.RProjectileWithRope> Projectile => new(2, Ptr + 2136, 8, this);

    /// <summary>
    /// ObjectProperty: Projectile
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileWithRope Projectile_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileWithRope>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }
    /// <summary>
    /// ObjectProperty: Projectile
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileWithRope Projectile_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileWithRope>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// ObjectProperty: RescueVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncherRescueVolume RescueVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncherRescueVolume>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// ObjectProperty: HostageVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncherRescueVolume HostageVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncherRescueVolume>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ObjectProperty: TargetedHostage
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI TargetedHostage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// ObjectProperty: GrabbedVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain GrabbedVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ObjectProperty: GrabbedHostage
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI GrabbedHostage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: LineLauncherWire
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint_RopeBase LineLauncherWire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint_RopeBase>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ObjectProperty: FlipUpOntoTightropeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FlipUpOntoTightropeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ObjectProperty: DiveSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// ObjectProperty: FailedFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FailedFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// ClassProperty: RopeSpawnClass
    /// </summary>
    public unsafe BmSDK.Class RopeSpawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: ProjectileRope
    /// </summary>
    public InlineArray<BmSDK.BmGame.RSimpleRopeComponent> ProjectileRope => new(2, Ptr + 2248, 8, this);

    /// <summary>
    /// ComponentProperty: ProjectileRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent ProjectileRope_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }
    /// <summary>
    /// ComponentProperty: ProjectileRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent ProjectileRope_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// FloatProperty: ZipForwardMaxSpeed
    /// </summary>
    public unsafe float ZipForwardMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// FloatProperty: ZipForwardAccel
    /// </summary>
    public unsafe float ZipForwardAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// IntProperty: YawRangeToCheck
    /// </summary>
    public unsafe int YawRangeToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// IntProperty: NumChecksOnEachSide
    /// </summary>
    public unsafe int NumChecksOnEachSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherAttachAngle
    /// </summary>
    public unsafe float LineLauncherAttachAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// FloatProperty: LowLineLauncherHeightOffset
    /// </summary>
    public unsafe float LowLineLauncherHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// FloatProperty: LowLineLauncherPlayerHeightOffset
    /// </summary>
    public unsafe float LowLineLauncherPlayerHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// StructProperty: CurrentWinchUpPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentWinchUpPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2292);

    /// <summary>
    /// StructProperty: CurrentEndPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentEndPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2304);

    /// <summary>
    /// FloatProperty: CurrentZipSpeed
    /// </summary>
    public unsafe float CurrentZipSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// FloatProperty: CosLineLauncherAttachAngle
    /// </summary>
    public unsafe float CosLineLauncherAttachAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// StructProperty: EndRopePos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EndRopePos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2324);

    /// <summary>
    /// StructProperty: BackRopePos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BackRopePos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2336);

    /// <summary>
    /// StructProperty: BatmanStartPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmanStartPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2348);

    /// <summary>
    /// StructProperty: BatmanEndPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmanEndPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2360);

    /// <summary>
    /// StructProperty: EndRopePosAim
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EndRopePosAim
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2372);

    /// <summary>
    /// StructProperty: BackRopePosAim
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BackRopePosAim
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2384);

    /// <summary>
    /// StructProperty: BatmanStartPointAim
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmanStartPointAim
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2396);

    /// <summary>
    /// StructProperty: BatmanEndPointAim
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmanEndPointAim
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2408);

    /// <summary>
    /// IntProperty: RopeInitTimer
    /// </summary>
    public unsafe int RopeInitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// IntProperty: RopesFired
    /// </summary>
    public unsafe int RopesFired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// FloatProperty: FirstRopePlayerHeight
    /// </summary>
    public unsafe float FirstRopePlayerHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// FloatProperty: MinAimAngle
    /// </summary>
    public unsafe float MinAimAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// FloatProperty: CosMinAimAngle
    /// </summary>
    public unsafe float CosMinAimAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// BoolProperty: bGrabHostageMode
    /// </summary>
    public unsafe bool bGrabHostageMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: BlockedByHostageTaker
    /// </summary>
    public unsafe bool BlockedByHostageTaker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bFailedLaunch
    /// </summary>
    public unsafe bool bFailedLaunch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: AlwaysAllowLineLauncherTightrope
    /// </summary>
    public unsafe bool AlwaysAllowLineLauncherTightrope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// NameProperty: CameraFire2ndLineLeftAnim
    /// </summary>
    public unsafe BmSDK.FName CameraFire2ndLineLeftAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// NameProperty: CameraFire2ndLineRightAnim
    /// </summary>
    public unsafe BmSDK.FName CameraFire2ndLineRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// FloatProperty: CameraAnimFactor
    /// </summary>
    public unsafe float CameraAnimFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }
}
