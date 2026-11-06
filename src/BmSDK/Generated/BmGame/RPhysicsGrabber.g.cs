#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPhysicsGrabber<br/>
/// (size = 2220)
/// (flags = 144703666)
/// </summary>
public partial class RPhysicsGrabber : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPhysicsGrabber", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPhysicsGrabber.
    /// </summary>
    public static RPhysicsGrabber DefaultObject => (RPhysicsGrabber)StaticClass().DefaultObject;

    internal RPhysicsGrabber() { }

    /// <summary>
    /// Constructs a new RPhysicsGrabber
    /// </summary>
    public RPhysicsGrabber(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPhysicsGrabber(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CalculateDiscoveryMethod;
    /// <summary>
    /// Function: CalculateDiscoveryMethod
    /// </summary>
    public unsafe virtual bool CalculateDiscoveryMethod(BmSDK.Engine.Actor Actor, BmSDK.Engine.Actor.FTraceHitInfo Hit)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateDiscoveryMethod, "BmGame.RPhysicsGrabber.CalculateDiscoveryMethod");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Hit, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_PhysObjectDetectorUpdate;
    /// <summary>
    /// Function: PhysObjectDetectorUpdate
    /// </summary>
    public unsafe virtual bool PhysObjectDetectorUpdate(System.Numerics.Vector3 GrabberLocation, BmSDK.Rotator GrabberRotation, out float OutUnrealHitDistance, out BmSDK.Engine.Actor OutHitActor, out BmSDK.Engine.RB_BodyInstance OutHitBodyInstance, out System.Numerics.Vector3 OutHitShapeBoundsCentre, out System.Numerics.Vector3 OutHitShapeBoundsExtents, out System.Numerics.Vector3 OutHitLocation, out System.Numerics.Vector3 OutHitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PhysObjectDetectorUpdate, "BmGame.RPhysicsGrabber.PhysObjectDetectorUpdate");
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrabberLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrabberRotation, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutUnrealHitDistance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutUnrealHitDistance, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHitActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHitActor, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHitBodyInstance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHitBodyInstance, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHitShapeBoundsCentre);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHitShapeBoundsCentre, paramsPtr + 44);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHitShapeBoundsExtents);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHitShapeBoundsExtents, paramsPtr + 56);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHitLocation, paramsPtr + 68);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHitNormal, paramsPtr + 80);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutUnrealHitDistance = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        OutHitActor = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 28);
        OutHitBodyInstance = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RB_BodyInstance>(paramsPtr + 36);
        OutHitShapeBoundsCentre = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 44);
        OutHitShapeBoundsExtents = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 56);
        OutHitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 68);
        OutHitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 80);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 92);
    }

    private static BmSDK.Function __fn_PlayerTick;
    /// <summary>
    /// Function: PlayerTick
    /// </summary>
    public unsafe override void PlayerTick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerTick, "BmGame.RPhysicsGrabber.PlayerTick");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopPhysicsDrag;
    /// <summary>
    /// Function: StopPhysicsDrag
    /// </summary>
    public unsafe virtual void StopPhysicsDrag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopPhysicsDrag, "BmGame.RPhysicsGrabber.StopPhysicsDrag");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartPhysicsDrag;
    /// <summary>
    /// Function: StartPhysicsDrag
    /// </summary>
    public unsafe virtual void StartPhysicsDrag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPhysicsDrag, "BmGame.RPhysicsGrabber.StartPhysicsDrag");
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PhysicsDragRaycast;
    /// <summary>
    /// Function: PhysicsDragRaycast
    /// </summary>
    public unsafe virtual void PhysicsDragRaycast(out BmSDK.Engine.Actor HitActor, out BmSDK.Engine.PrimitiveComponent HitComponent, out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, out float HitDistance, out BmSDK.FName HitBoneName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PhysicsDragRaycast, "BmGame.RPhysicsGrabber.PhysicsDragRaycast");
        byte* paramsPtr = stackalloc byte[68];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitComponent);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitDistance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitDistance, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitBoneName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitBoneName, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitActor = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
        HitComponent = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PrimitiveComponent>(paramsPtr + 8);
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
        HitDistance = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
        HitBoneName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 44);
        return;
    }

    private static BmSDK.Function __fn_CancelGadget;
    /// <summary>
    /// Function: CancelGadget
    /// </summary>
    public unsafe override void CancelGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelGadget, "BmGame.RPhysicsGrabber.CancelGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override bool GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RPhysicsGrabber.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetRBBodyInstancePointerString;
    /// <summary>
    /// Function: GetRBBodyInstancePointerString
    /// </summary>
    public unsafe virtual BmSDK.FString GetRBBodyInstancePointerString()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRBBodyInstancePointerString, "BmGame.RPhysicsGrabber.GetRBBodyInstancePointerString");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RPhysicsGrabber.DrawHUD");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoNavMeshSurfaceTypeRender;
    /// <summary>
    /// Function: DoNavMeshSurfaceTypeRender
    /// </summary>
    public unsafe virtual void DoNavMeshSurfaceTypeRender(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoNavMeshSurfaceTypeRender, "BmGame.RPhysicsGrabber.DoNavMeshSurfaceTypeRender");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerImpactEffect;
    /// <summary>
    /// Function: TriggerImpactEffect
    /// </summary>
    public unsafe virtual void TriggerImpactEffect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerImpactEffect, "BmGame.RPhysicsGrabber.TriggerImpactEffect");
        byte* paramsPtr = stackalloc byte[212];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleImpactType;
    /// <summary>
    /// Function: ToggleImpactType
    /// </summary>
    public unsafe virtual void ToggleImpactType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleImpactType, "BmGame.RPhysicsGrabber.ToggleImpactType");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoSurfaceTypeRender;
    /// <summary>
    /// Function: DoSurfaceTypeRender
    /// </summary>
    public unsafe virtual void DoSurfaceTypeRender(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoSurfaceTypeRender, "BmGame.RPhysicsGrabber.DoSurfaceTypeRender");
        byte* paramsPtr = stackalloc byte[312];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CopyToClipboard;
    /// <summary>
    /// Function: CopyToClipboard
    /// </summary>
    public unsafe virtual void CopyToClipboard(BmSDK.FString MeshName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CopyToClipboard, "BmGame.RPhysicsGrabber.CopyToClipboard");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRMaterial;
    /// <summary>
    /// Function: GetRMaterial
    /// </summary>
    public unsafe virtual BmSDK.Engine.RPhysicalMaterialProperty GetRMaterial(BmSDK.Engine.PhysicalMaterial PhysMaterial)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRMaterial, "BmGame.RPhysicsGrabber.GetRMaterial");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PhysMaterial, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RPhysicalMaterialProperty>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetSurfaceType;
    /// <summary>
    /// Function: GetSurfaceType
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetSurfaceType(out BmSDK.Engine.Actor.FImpactInfo HitInfo, out float Dist, out BmSDK.Engine.Actor.FImpactInfo Foot, out BmSDK.Engine.PhysicalMaterial simpleCollision, out int usingSimple, out float simpleDifference)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSurfaceType, "BmGame.RPhysicsGrabber.GetSurfaceType");
        byte* paramsPtr = stackalloc byte[468];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Dist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dist, paramsPtr + 96);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Foot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 100);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out simpleCollision);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(simpleCollision, paramsPtr + 196);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out usingSimple);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(usingSimple, paramsPtr + 204);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out simpleDifference);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(simpleDifference, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FImpactInfo>(paramsPtr + 0);
        Dist = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 96);
        Foot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FImpactInfo>(paramsPtr + 100);
        simpleCollision = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PhysicalMaterial>(paramsPtr + 196);
        usingSimple = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 204);
        simpleDifference = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 208);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 212);
    }

    private static BmSDK.Function __fn_GetFullName;
    /// <summary>
    /// Function: GetFullName
    /// </summary>
    public unsafe static BmSDK.FString GetFullName(BmSDK.GameObject Obj)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullName, "BmGame.RPhysicsGrabber.GetFullName");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SecondaryButtonPressed;
    /// <summary>
    /// Function: SecondaryButtonPressed
    /// </summary>
    public unsafe override void SecondaryButtonPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecondaryButtonPressed, "BmGame.RPhysicsGrabber.SecondaryButtonPressed");
        byte* paramsPtr = stackalloc byte[220];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ButtonReleased;
    /// <summary>
    /// Function: ButtonReleased
    /// </summary>
    public unsafe override void ButtonReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonReleased, "BmGame.RPhysicsGrabber.ButtonReleased");
        byte* paramsPtr = stackalloc byte[220];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ButtonPressed;
    /// <summary>
    /// Function: ButtonPressed
    /// </summary>
    public unsafe override void ButtonPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonPressed, "BmGame.RPhysicsGrabber.ButtonPressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetName;
    /// <summary>
    /// Function: GetName
    /// </summary>
    public unsafe override BmSDK.FString GetName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetName, "BmGame.RPhysicsGrabber.GetName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStartEndTracePoints;
    /// <summary>
    /// Function: GetStartEndTracePoints
    /// </summary>
    public unsafe virtual void GetStartEndTracePoints(out System.Numerics.Vector3 TraceStart, out System.Numerics.Vector3 TraceEnd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStartEndTracePoints, "BmGame.RPhysicsGrabber.GetStartEndTracePoints");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TraceStart);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TraceEnd);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TraceStart = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        TraceEnd = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetApexDestructibleChunkIndex;
    /// <summary>
    /// Function: GetApexDestructibleChunkIndex
    /// </summary>
    public unsafe virtual int GetApexDestructibleChunkIndex(BmSDK.BmGame.RApexStaticDestructibleComponent ApexComponent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetApexDestructibleChunkIndex, "BmGame.RPhysicsGrabber.GetApexDestructibleChunkIndex");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ApexComponent, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetNavMeshInfo;
    /// <summary>
    /// Function: GetNavMeshInfo
    /// </summary>
    public unsafe virtual bool GetNavMeshInfo(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, out BmSDK.FString NavMeshString, out System.Numerics.Vector3 NavMeshHitPoint, out System.Numerics.Vector3 NavMeshHitNormal, out int StringR, out int StringG, out int StringB)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavMeshInfo, "BmGame.RPhysicsGrabber.GetNavMeshInfo");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NavMeshHitPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavMeshHitPoint, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NavMeshHitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavMeshHitNormal, paramsPtr + 52);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StringR);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringR, paramsPtr + 64);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StringG);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringG, paramsPtr + 68);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StringB);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringB, paramsPtr + 72);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NavMeshString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 24);
        NavMeshHitPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 40);
        NavMeshHitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 52);
        StringR = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 64);
        StringG = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 68);
        StringB = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 72);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 76);
    }

    /// <summary>
    /// FloatProperty: WeaponImpulse
    /// </summary>
    public unsafe float WeaponImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// FloatProperty: ThrowImpulse
    /// </summary>
    public unsafe float ThrowImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// ComponentProperty: PhysicsGrabber
    /// </summary>
    public unsafe BmSDK.Engine.RB_Handle PhysicsGrabber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_Handle>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// FloatProperty: HoldDistance
    /// </summary>
    public unsafe float HoldDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// StructProperty: HoldOrientation
    /// </summary>
    public unsafe ref BmSDK.GameObject.FQuat HoldOrientation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FQuat>(Ptr + 2096);

    /// <summary>
    /// BoolProperty: IsPhysActorHit
    /// </summary>
    public unsafe bool IsPhysActorHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// FloatProperty: PhysTestHitDistance
    /// </summary>
    public unsafe float PhysTestHitDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// ObjectProperty: PhysTestHitRBBodyInstance
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance PhysTestHitRBBodyInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ObjectProperty: PhysTestHitActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor PhysTestHitActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// StructProperty: PhysTestShapeBoundsCentre
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PhysTestShapeBoundsCentre
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2136);

    /// <summary>
    /// StructProperty: PhysTestShapeBoundsExtents
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PhysTestShapeBoundsExtents
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2148);

    /// <summary>
    /// StructProperty: PhysTestHitLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PhysTestHitLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2160);

    /// <summary>
    /// StructProperty: PhysTestHitNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PhysTestHitNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2172);

    /// <summary>
    /// StrProperty: CurrentlyInClipboard
    /// </summary>
    public unsafe BmSDK.FString CurrentlyInClipboard
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ByteProperty: CurrentImpactMaterial
    /// </summary>
    public unsafe BmSDK.Engine.RPhysicalMaterialProperty.EPhysMaterialImpactTypes CurrentImpactMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty.EPhysMaterialImpactTypes>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// StrProperty: DiscoveryMethod
    /// </summary>
    public unsafe BmSDK.FString DiscoveryMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }
}
