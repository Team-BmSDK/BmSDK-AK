#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNode_Pose<br/>
/// (size = 1640)
/// (flags = 144703634)
/// </summary>
public partial class RAnimNode_Pose : BmSDK.Engine.AnimNode, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNode_Pose", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAnimNode_Pose.
    /// </summary>
    public static RAnimNode_Pose DefaultObject => (RAnimNode_Pose)StaticClass().DefaultObject;

    internal RAnimNode_Pose() { }

    /// <summary>
    /// Constructs a new RAnimNode_Pose
    /// </summary>
    public RAnimNode_Pose(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNode_Pose Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNode_Pose(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNode_Pose>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNode_Pose>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNode_Pose>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNode_Pose>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNode_Pose>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNode_Pose>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNode_Pose>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNode_Pose>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ShutdownForPooling;
    /// <summary>
    /// Function: ShutdownForPooling
    /// </summary>
    public unsafe virtual void ShutdownForPooling()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutdownForPooling, "BmGame.RAnimNode_Pose.ShutdownForPooling");
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

    private static BmSDK.Function __fn_GetInferredReferencePoint;
    /// <summary>
    /// Function: GetInferredReferencePoint
    /// </summary>
    public unsafe static void GetInferredReferencePoint(BmSDK.Engine.SkeletalMeshComponent SkeletalMeshComponent, float Time, BmSDK.Engine.AnimSequence Sequence, bool Mirrored, out System.Numerics.Vector3 Out_Translation, out BmSDK.Rotator out_Rotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInferredReferencePoint, "BmGame.RAnimNode_Pose.GetInferredReferencePoint");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkeletalMeshComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sequence, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Out_Translation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
        out_Rotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 36);
        return;
    }

    private static BmSDK.Function __fn_ClearGlobalGundummyAnim;
    /// <summary>
    /// Function: ClearGlobalGundummyAnim
    /// </summary>
    public unsafe virtual void ClearGlobalGundummyAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGlobalGundummyAnim, "BmGame.RAnimNode_Pose.ClearGlobalGundummyAnim");
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

    private static BmSDK.Function __fn_SetGlobalGundummyAnim;
    /// <summary>
    /// Function: SetGlobalGundummyAnim
    /// </summary>
    public unsafe virtual void SetGlobalGundummyAnim(BmSDK.Engine.AnimSequence Anim, float NormalizedTime, float Weight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlobalGundummyAnim, "BmGame.RAnimNode_Pose.SetGlobalGundummyAnim");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalizedTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weight, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ClearGlobalAdditiveAnim;
    /// <summary>
    /// Function: ClearGlobalAdditiveAnim
    /// </summary>
    public unsafe virtual void ClearGlobalAdditiveAnim(BmSDK.FName Slot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGlobalAdditiveAnim, "BmGame.RAnimNode_Pose.ClearGlobalAdditiveAnim");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Slot, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetGlobalAdditiveAnim;
    /// <summary>
    /// Function: SetGlobalAdditiveAnim
    /// </summary>
    public unsafe virtual void SetGlobalAdditiveAnim(BmSDK.FName Slot, BmSDK.Engine.AnimSequence AddAnim, BmSDK.Engine.AnimSequence SubtractAnim, float NormalizedTime, float Weight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlobalAdditiveAnim, "BmGame.RAnimNode_Pose.SetGlobalAdditiveAnim");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Slot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddAnim, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtractAnim, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalizedTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weight, paramsPtr + 28);
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

    private static BmSDK.Function __fn_GetCurveFloat;
    /// <summary>
    /// Function: GetCurveFloat
    /// </summary>
    public unsafe virtual float GetCurveFloat(BmSDK.FName CurveFloatName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurveFloat, "BmGame.RAnimNode_Pose.GetCurveFloat");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveFloatName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SnapFloorCorrection;
    /// <summary>
    /// Function: SnapFloorCorrection
    /// </summary>
    public unsafe virtual void SnapFloorCorrection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SnapFloorCorrection, "BmGame.RAnimNode_Pose.SnapFloorCorrection");
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

    private static BmSDK.Function __fn_SetCustomFloorCorrection;
    /// <summary>
    /// Function: SetCustomFloorCorrection
    /// </summary>
    public unsafe virtual void SetCustomFloorCorrection(float CustomFloorCorrection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomFloorCorrection, "BmGame.RAnimNode_Pose.SetCustomFloorCorrection");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomFloorCorrection, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetPhysicsBodyForBone;
    /// <summary>
    /// Function: GetPhysicsBodyForBone
    /// </summary>
    public unsafe virtual BmSDK.Engine.RB_BodyInstance GetPhysicsBodyForBone(BmSDK.FName BoneName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPhysicsBodyForBone, "BmGame.RAnimNode_Pose.GetPhysicsBodyForBone");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetRightFootPhysicsBody;
    /// <summary>
    /// Function: GetRightFootPhysicsBody
    /// </summary>
    public unsafe virtual BmSDK.Engine.RB_BodyInstance GetRightFootPhysicsBody()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRightFootPhysicsBody, "BmGame.RAnimNode_Pose.GetRightFootPhysicsBody");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLeftFootPhysicsBody;
    /// <summary>
    /// Function: GetLeftFootPhysicsBody
    /// </summary>
    public unsafe virtual BmSDK.Engine.RB_BodyInstance GetLeftFootPhysicsBody()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeftFootPhysicsBody, "BmGame.RAnimNode_Pose.GetLeftFootPhysicsBody");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSpinePhysicsBody;
    /// <summary>
    /// Function: GetSpinePhysicsBody
    /// </summary>
    public unsafe virtual BmSDK.Engine.RB_BodyInstance GetSpinePhysicsBody()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpinePhysicsBody, "BmGame.RAnimNode_Pose.GetSpinePhysicsBody");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPelvisPhysicsBody;
    /// <summary>
    /// Function: GetPelvisPhysicsBody
    /// </summary>
    public unsafe virtual BmSDK.Engine.RB_BodyInstance GetPelvisPhysicsBody()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPelvisPhysicsBody, "BmGame.RAnimNode_Pose.GetPelvisPhysicsBody");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetTimeScale;
    /// <summary>
    /// Function: SetTimeScale
    /// </summary>
    public unsafe virtual void SetTimeScale(float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTimeScale, "BmGame.RAnimNode_Pose.SetTimeScale");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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

    private static BmSDK.Function __fn_DisableTick;
    /// <summary>
    /// Function: DisableTick
    /// </summary>
    public unsafe virtual void DisableTick(bool bDisable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableTick, "BmGame.RAnimNode_Pose.DisableTick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisable, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetFullyCustomAdditiveAnim;
    /// <summary>
    /// Function: GetFullyCustomAdditiveAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FFullyCustomAdditiveAnimConfig GetFullyCustomAdditiveAnim(BmSDK.FName AddAnimName, BmSDK.FName SubtractAnimName, BmSDK.Engine.AnimSet Set, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullyCustomAdditiveAnim, "BmGame.RAnimNode_Pose.GetFullyCustomAdditiveAnim");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtractAnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FFullyCustomAdditiveAnimConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetAdditiveAnim;
    /// <summary>
    /// Function: GetAdditiveAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig GetAdditiveAnim(BmSDK.FName AddAnimName, BmSDK.FName SubtractAnimName, BmSDK.Engine.AnimSet Set, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdditiveAnim, "BmGame.RAnimNode_Pose.GetAdditiveAnim");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtractAnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetEmptyAnim;
    /// <summary>
    /// Function: GetEmptyAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetEmptyAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEmptyAnim, "BmGame.RAnimNode_Pose.GetEmptyAnim");
        byte* paramsPtr = stackalloc byte[52];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFullBodyAnim;
    /// <summary>
    /// Function: GetFullBodyAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetFullBodyAnim(BmSDK.FName AnimName, BmSDK.Engine.AnimSet Set, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets, BmSDK.Engine.RAimingConfig AimingConfig)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullBodyAnim, "BmGame.RAnimNode_Pose.GetFullBodyAnim");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_IsAimAtOnTarget;
    /// <summary>
    /// Function: IsAimAtOnTarget
    /// </summary>
    public unsafe virtual bool IsAimAtOnTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAimAtOnTarget, "BmGame.RAnimNode_Pose.IsAimAtOnTarget");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetIdleTimeScale;
    /// <summary>
    /// Function: SetIdleTimeScale
    /// </summary>
    public unsafe virtual void SetIdleTimeScale(float NewValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIdleTimeScale, "BmGame.RAnimNode_Pose.SetIdleTimeScale");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetRagdollFacing;
    /// <summary>
    /// Function: GetRagdollFacing
    /// </summary>
    public unsafe virtual float GetRagdollFacing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRagdollFacing, "BmGame.RAnimNode_Pose.GetRagdollFacing");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddRagdollForce;
    /// <summary>
    /// Function: AddRagdollForce
    /// </summary>
    public unsafe virtual void AddRagdollForce(BmSDK.BmGame.RAnimUtil_PhysicsOutput.ERagdollForceType Type, System.Numerics.Vector3 Translation, System.Numerics.Vector3 Rotation, BmSDK.FName BodyName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRagdollForce, "BmGame.RAnimNode_Pose.AddRagdollForce");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Translation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rotation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BodyName, paramsPtr + 28);
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

    private static BmSDK.Function __fn_BreakRagdollConstraint;
    /// <summary>
    /// Function: BreakRagdollConstraint
    /// </summary>
    public unsafe virtual void BreakRagdollConstraint(BmSDK.FName ConstraintName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BreakRagdollConstraint, "BmGame.RAnimNode_Pose.BreakRagdollConstraint");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConstraintName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsConsideringStuckAsARagdoll;
    /// <summary>
    /// Function: IsConsideringStuckAsARagdoll
    /// </summary>
    public unsafe virtual bool IsConsideringStuckAsARagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsConsideringStuckAsARagdoll, "BmGame.RAnimNode_Pose.IsConsideringStuckAsARagdoll");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsStuckAsARagdoll;
    /// <summary>
    /// Function: IsStuckAsARagdoll
    /// </summary>
    public unsafe virtual bool IsStuckAsARagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStuckAsARagdoll, "BmGame.RAnimNode_Pose.IsStuckAsARagdoll");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsRagdoll;
    /// <summary>
    /// Function: IsRagdoll
    /// </summary>
    public unsafe virtual bool IsRagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRagdoll, "BmGame.RAnimNode_Pose.IsRagdoll");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ChangeRagdollDamping;
    /// <summary>
    /// Function: ChangeRagdollDamping
    /// </summary>
    public unsafe virtual void ChangeRagdollDamping(float LinearDamping, float AngularDamping)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeRagdollDamping, "BmGame.RAnimNode_Pose.ChangeRagdollDamping");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinearDamping, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngularDamping, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ChangeRagdollMotorWeight;
    /// <summary>
    /// Function: ChangeRagdollMotorWeight
    /// </summary>
    public unsafe virtual void ChangeRagdollMotorWeight(BmSDK.FName Description, float NewWeight, float BlendDuration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeRagdollMotorWeight, "BmGame.RAnimNode_Pose.ChangeRagdollMotorWeight");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeight, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendDuration, paramsPtr + 12);
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

    private static BmSDK.Function __fn_InstantResetRagdoll;
    /// <summary>
    /// Function: InstantResetRagdoll
    /// </summary>
    public unsafe virtual void InstantResetRagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantResetRagdoll, "BmGame.RAnimNode_Pose.InstantResetRagdoll");
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

    private static BmSDK.Function __fn_ResetRagdoll;
    /// <summary>
    /// Function: ResetRagdoll
    /// </summary>
    public unsafe virtual void ResetRagdoll()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetRagdoll, "BmGame.RAnimNode_Pose.ResetRagdoll");
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

    private static BmSDK.Function __fn_PopRagdoll;
    /// <summary>
    /// Function: PopRagdoll
    /// </summary>
    public unsafe virtual void PopRagdoll(BmSDK.FName Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopRagdoll, "BmGame.RAnimNode_Pose.PopRagdoll");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PushRagdollOff;
    /// <summary>
    /// Function: PushRagdollOff
    /// </summary>
    public unsafe virtual void PushRagdollOff(BmSDK.FName Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushRagdollOff, "BmGame.RAnimNode_Pose.PushRagdollOff");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PushRagdollOn;
    /// <summary>
    /// Function: PushRagdollOn
    /// </summary>
    public unsafe virtual void PushRagdollOn(BmSDK.FName Description, float MotorWeight, float BlendInDuration, float BlendOutDuration, float LinearDamping, float AngularDamping, BmSDK.TArray<BmSDK.FName> FixedBodies, bool ActorRotationLocked)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushRagdollOn, "BmGame.RAnimNode_Pose.PushRagdollOn");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MotorWeight, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInDuration, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutDuration, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinearDamping, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngularDamping, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FixedBodies, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorRotationLocked, paramsPtr + 44);
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

    private static BmSDK.Function __fn_SetPhysicsAsset;
    /// <summary>
    /// Function: SetPhysicsAsset
    /// </summary>
    public unsafe virtual void SetPhysicsAsset(BmSDK.Engine.PhysicsAsset NewPhysicsAsset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPhysicsAsset, "BmGame.RAnimNode_Pose.SetPhysicsAsset");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysicsAsset, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe virtual void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> OutThoughts)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RAnimNode_Pose.GetThoughts");
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutThoughts = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_IsFallingOrLanding;
    /// <summary>
    /// Function: IsFallingOrLanding
    /// </summary>
    public unsafe virtual bool IsFallingOrLanding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFallingOrLanding, "BmGame.RAnimNode_Pose.IsFallingOrLanding");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFalling;
    /// <summary>
    /// Function: IsFalling
    /// </summary>
    public unsafe virtual bool IsFalling()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFalling, "BmGame.RAnimNode_Pose.IsFalling");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAdditiveAnimStateWithNotifies;
    /// <summary>
    /// Function: SetAdditiveAnimStateWithNotifies
    /// </summary>
    public unsafe virtual void SetAdditiveAnimStateWithNotifies(int Index, BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan AddNormalizedTime, float SubtractNormalizedTime, float Weight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAdditiveAnimStateWithNotifies, "BmGame.RAnimNode_Pose.SetAdditiveAnimStateWithNotifies");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddNormalizedTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtractNormalizedTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weight, paramsPtr + 20);
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

    private static BmSDK.Function __fn_SetAdditiveAnimState;
    /// <summary>
    /// Function: SetAdditiveAnimState
    /// </summary>
    public unsafe virtual void SetAdditiveAnimState(int Index, float AddNormalizedTime, float SubtractNormalizedTime, float Weight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAdditiveAnimState, "BmGame.RAnimNode_Pose.SetAdditiveAnimState");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddNormalizedTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtractNormalizedTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weight, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetTransitionAnimFromCurrent;
    /// <summary>
    /// Function: GetTransitionAnimFromCurrent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSequence GetTransitionAnimFromCurrent(BmSDK.FName ToMovementStance, BmSDK.FName ToWeaponStance, BmSDK.FName ToIdleStance, bool ToMirrored = default, BmSDK.FName TransitionName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionAnimFromCurrent, "BmGame.RAnimNode_Pose.GetTransitionAnimFromCurrent");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToMovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToWeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToIdleStance, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToMirrored, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetTransitionAnim;
    /// <summary>
    /// Function: GetTransitionAnim
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSequence GetTransitionAnim(BmSDK.BmGame.RWeaponConfig WeaponConfig, BmSDK.FName FromMovementStance, BmSDK.FName FromWeaponStance, BmSDK.FName FromIdleStance, bool FromMirrored, BmSDK.FName ToMovementStance, BmSDK.FName ToWeaponStance, BmSDK.FName ToIdleStance, bool ToMirrored, BmSDK.FName TransitionName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionAnim, "BmGame.RAnimNode_Pose.GetTransitionAnim");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromMovementStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromWeaponStance, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromIdleStance, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromMirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToMovementStance, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToWeaponStance, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToIdleStance, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToMirrored, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_GetTransitionActorPositionWithFullRotation;
    /// <summary>
    /// Function: GetTransitionActorPositionWithFullRotation
    /// </summary>
    public unsafe virtual bool GetTransitionActorPositionWithFullRotation(BmSDK.BmGame.RAnimConfig.FCustomAnimConfig Anim, float NormalizedTime, System.Numerics.Vector3 WorldReferencePosition, BmSDK.Rotator WorldReferencRrotation, bool Mirrored, out System.Numerics.Vector3 Out_Position, out BmSDK.Rotator out_Rotation, BmSDK.BmGame.RAnimConfig.FCustomAnimConfig OverrideReferencePointAnim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionActorPositionWithFullRotation, "BmGame.RAnimNode_Pose.GetTransitionActorPositionWithFullRotation");
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalizedTime, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldReferencePosition, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldReferencRrotation, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideReferencePointAnim, paramsPtr + 108);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Out_Position = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 84);
        out_Rotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 96);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 160);
    }

    private static BmSDK.Function __fn_GetTransitionActorPosition;
    /// <summary>
    /// Function: GetTransitionActorPosition
    /// </summary>
    public unsafe virtual bool GetTransitionActorPosition(BmSDK.BmGame.RAnimConfig.FCustomAnimConfig Anim, float NormalizedTime, System.Numerics.Vector3 WorldReferencePosition, int WorldReferenceYaw, bool Mirrored, out System.Numerics.Vector3 Out_Position, out BmSDK.Rotator out_Rotation, BmSDK.BmGame.RAnimConfig.FCustomAnimConfig OverrideReferencePointAnim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionActorPosition, "BmGame.RAnimNode_Pose.GetTransitionActorPosition");
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalizedTime, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldReferencePosition, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldReferenceYaw, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideReferencePointAnim, paramsPtr + 100);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Out_Position = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 76);
        out_Rotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 88);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 152);
    }

    private static BmSDK.Function __fn_SetMeetingPointsRealTime;
    /// <summary>
    /// Function: SetMeetingPointsRealTime
    /// </summary>
    public unsafe virtual void SetMeetingPointsRealTime(BmSDK.BmGame.RAnimUtil.FMeetingPoints In)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMeetingPointsRealTime, "BmGame.RAnimNode_Pose.SetMeetingPointsRealTime");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(In, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetMeetingPointsRealTime;
    /// <summary>
    /// Function: GetMeetingPointsRealTime
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FMeetingPoints GetMeetingPointsRealTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMeetingPointsRealTime, "BmGame.RAnimNode_Pose.GetMeetingPointsRealTime");
        byte* paramsPtr = stackalloc byte[48];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FMeetingPoints>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMeetingPointsNormalizedTime;
    /// <summary>
    /// Function: SetMeetingPointsNormalizedTime
    /// </summary>
    public unsafe virtual void SetMeetingPointsNormalizedTime(BmSDK.BmGame.RAnimUtil.FMeetingPoints In)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMeetingPointsNormalizedTime, "BmGame.RAnimNode_Pose.SetMeetingPointsNormalizedTime");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(In, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetMeetingPointsNormalizedTime;
    /// <summary>
    /// Function: GetMeetingPointsNormalizedTime
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FMeetingPoints GetMeetingPointsNormalizedTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMeetingPointsNormalizedTime, "BmGame.RAnimNode_Pose.GetMeetingPointsNormalizedTime");
        byte* paramsPtr = stackalloc byte[48];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FMeetingPoints>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TimeTillMeetingPointEnd;
    /// <summary>
    /// Function: TimeTillMeetingPointEnd
    /// </summary>
    public unsafe virtual float TimeTillMeetingPointEnd(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimeTillMeetingPointEnd, "BmGame.RAnimNode_Pose.TimeTillMeetingPointEnd");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsPastTransitionMeetingPointEnd;
    /// <summary>
    /// Function: IsPastTransitionMeetingPointEnd
    /// </summary>
    public unsafe virtual bool IsPastTransitionMeetingPointEnd(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPastTransitionMeetingPointEnd, "BmGame.RAnimNode_Pose.IsPastTransitionMeetingPointEnd");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsPastTransitionMeetingPointBegin;
    /// <summary>
    /// Function: IsPastTransitionMeetingPointBegin
    /// </summary>
    public unsafe virtual bool IsPastTransitionMeetingPointBegin(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPastTransitionMeetingPointBegin, "BmGame.RAnimNode_Pose.IsPastTransitionMeetingPointBegin");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTransitionDominantAnim;
    /// <summary>
    /// Function: GetTransitionDominantAnim
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSequence GetTransitionDominantAnim(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionDominantAnim, "BmGame.RAnimNode_Pose.GetTransitionDominantAnim");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetTransitionDuration;
    /// <summary>
    /// Function: SetTransitionDuration
    /// </summary>
    public unsafe virtual void SetTransitionDuration(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id, float NewDuration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTransitionDuration, "BmGame.RAnimNode_Pose.SetTransitionDuration");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDuration, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetTransitionDuration;
    /// <summary>
    /// Function: GetTransitionDuration
    /// </summary>
    public unsafe virtual float GetTransitionDuration(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionDuration, "BmGame.RAnimNode_Pose.GetTransitionDuration");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTransitionNormalizedTime;
    /// <summary>
    /// Function: GetTransitionNormalizedTime
    /// </summary>
    public unsafe virtual float GetTransitionNormalizedTime(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionNormalizedTime, "BmGame.RAnimNode_Pose.GetTransitionNormalizedTime");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTransitionTimeInSeconds;
    /// <summary>
    /// Function: GetTransitionTimeInSeconds
    /// </summary>
    public unsafe virtual float GetTransitionTimeInSeconds(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionTimeInSeconds, "BmGame.RAnimNode_Pose.GetTransitionTimeInSeconds");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetHeadTransition;
    /// <summary>
    /// Function: GetHeadTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetHeadTransition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeadTransition, "BmGame.RAnimNode_Pose.GetHeadTransition");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsHeadTransition;
    /// <summary>
    /// Function: IsHeadTransition
    /// </summary>
    public unsafe virtual bool IsHeadTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHeadTransition, "BmGame.RAnimNode_Pose.IsHeadTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasTransition;
    /// <summary>
    /// Function: HasTransition
    /// </summary>
    public unsafe virtual bool HasTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasTransition, "BmGame.RAnimNode_Pose.HasTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_WillBeInTransition;
    /// <summary>
    /// Function: WillBeInTransition
    /// </summary>
    public unsafe virtual bool WillBeInTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id, float DeltaSeconds, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillBeInTransition, "BmGame.RAnimNode_Pose.WillBeInTransition");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaSeconds, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsInTransition;
    /// <summary>
    /// Function: IsInTransition
    /// </summary>
    public unsafe virtual bool IsInTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInTransition, "BmGame.RAnimNode_Pose.IsInTransition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsInAnyNonAutomaticTransition;
    /// <summary>
    /// Function: IsInAnyNonAutomaticTransition
    /// </summary>
    public unsafe virtual bool IsInAnyNonAutomaticTransition(BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAnyNonAutomaticTransition, "BmGame.RAnimNode_Pose.IsInAnyNonAutomaticTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsInAnyAutomaticTransition;
    /// <summary>
    /// Function: IsInAnyAutomaticTransition
    /// </summary>
    public unsafe virtual bool IsInAnyAutomaticTransition(BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness, out BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Transition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAnyAutomaticTransition, "BmGame.RAnimNode_Pose.IsInAnyAutomaticTransition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Transition = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsInAnyTransition;
    /// <summary>
    /// Function: IsInAnyTransition
    /// </summary>
    public unsafe virtual bool IsInAnyTransition(BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAnyTransition, "BmGame.RAnimNode_Pose.IsInAnyTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsPlayingAnyOverlay;
    /// <summary>
    /// Function: IsPlayingAnyOverlay
    /// </summary>
    public unsafe virtual bool IsPlayingAnyOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayingAnyOverlay, "BmGame.RAnimNode_Pose.IsPlayingAnyOverlay");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPlayingOverlay;
    /// <summary>
    /// Function: IsPlayingOverlay
    /// </summary>
    public unsafe virtual bool IsPlayingOverlay(BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayingOverlay, "BmGame.RAnimNode_Pose.IsPlayingOverlay");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_StopAllOverlaysInstantly;
    /// <summary>
    /// Function: StopAllOverlaysInstantly
    /// </summary>
    public unsafe virtual void StopAllOverlaysInstantly()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllOverlaysInstantly, "BmGame.RAnimNode_Pose.StopAllOverlaysInstantly");
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

    private static BmSDK.Function __fn_StopAllOverlays;
    /// <summary>
    /// Function: StopAllOverlays
    /// </summary>
    public unsafe virtual void StopAllOverlays()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllOverlays, "BmGame.RAnimNode_Pose.StopAllOverlays");
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

    private static BmSDK.Function __fn_StopGlobalAdditiveOverlay;
    /// <summary>
    /// Function: StopGlobalAdditiveOverlay
    /// </summary>
    public unsafe virtual void StopGlobalAdditiveOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGlobalAdditiveOverlay, "BmGame.RAnimNode_Pose.StopGlobalAdditiveOverlay");
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

    private static BmSDK.Function __fn_PlayGlobalAdditiveOverlay;
    /// <summary>
    /// Function: PlayGlobalAdditiveOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayGlobalAdditiveOverlay(BmSDK.BmGame.RAnimConfig.FFullyCustomAdditiveAnimConfig Anim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGlobalAdditiveOverlay, "BmGame.RAnimNode_Pose.PlayGlobalAdditiveOverlay");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_PlayAdditiveOverlayOnAllPoses;
    /// <summary>
    /// Function: PlayAdditiveOverlayOnAllPoses
    /// </summary>
    public unsafe virtual void PlayAdditiveOverlayOnAllPoses(BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig Anim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAdditiveOverlayOnAllPoses, "BmGame.RAnimNode_Pose.PlayAdditiveOverlayOnAllPoses");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StopAdditiveOverlay;
    /// <summary>
    /// Function: StopAdditiveOverlay
    /// </summary>
    public unsafe virtual void StopAdditiveOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAdditiveOverlay, "BmGame.RAnimNode_Pose.StopAdditiveOverlay");
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

    private static BmSDK.Function __fn_PlayAdditiveOverlay;
    /// <summary>
    /// Function: PlayAdditiveOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayAdditiveOverlay(BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig Anim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAdditiveOverlay, "BmGame.RAnimNode_Pose.PlayAdditiveOverlay");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_StopIdleOverlay;
    /// <summary>
    /// Function: StopIdleOverlay
    /// </summary>
    public unsafe virtual void StopIdleOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopIdleOverlay, "BmGame.RAnimNode_Pose.StopIdleOverlay");
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

    private static BmSDK.Function __fn_PlayIdleOverlay;
    /// <summary>
    /// Function: PlayIdleOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayIdleOverlay(BmSDK.FName OverlayName, BmSDK.BmGame.RAnimConfig.FCustomAnimConfig CustomAnim = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayIdleOverlay, "BmGame.RAnimNode_Pose.PlayIdleOverlay");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverlayName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomAnim, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_StopWeaponOverlay;
    /// <summary>
    /// Function: StopWeaponOverlay
    /// </summary>
    public unsafe virtual void StopWeaponOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopWeaponOverlay, "BmGame.RAnimNode_Pose.StopWeaponOverlay");
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

    private static BmSDK.Function __fn_PlayWeaponOverlay;
    /// <summary>
    /// Function: PlayWeaponOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayWeaponOverlay(BmSDK.FName OverlayName, BmSDK.BmGame.RAnimConfig.FCustomAnimConfig CustomAnim = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayWeaponOverlay, "BmGame.RAnimNode_Pose.PlayWeaponOverlay");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverlayName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomAnim, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_OverrideYawVelocity;
    /// <summary>
    /// Function: OverrideYawVelocity
    /// </summary>
    public unsafe virtual void OverrideYawVelocity(float YawVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideYawVelocity, "BmGame.RAnimNode_Pose.OverrideYawVelocity");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawVelocity, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OverrideTranslationVelocity;
    /// <summary>
    /// Function: OverrideTranslationVelocity
    /// </summary>
    public unsafe virtual void OverrideTranslationVelocity(System.Numerics.Vector3 TranslationVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideTranslationVelocity, "BmGame.RAnimNode_Pose.OverrideTranslationVelocity");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TranslationVelocity, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddYaw;
    /// <summary>
    /// Function: AddYaw
    /// </summary>
    public unsafe virtual void AddYaw(float Yaw)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddYaw, "BmGame.RAnimNode_Pose.AddYaw");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Yaw, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddYawVelocity;
    /// <summary>
    /// Function: AddYawVelocity
    /// </summary>
    public unsafe virtual void AddYawVelocity(float YawVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddYawVelocity, "BmGame.RAnimNode_Pose.AddYawVelocity");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawVelocity, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddTranslation;
    /// <summary>
    /// Function: AddTranslation
    /// </summary>
    public unsafe virtual void AddTranslation(System.Numerics.Vector3 Translation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddTranslation, "BmGame.RAnimNode_Pose.AddTranslation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Translation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddTranslationVelocity;
    /// <summary>
    /// Function: AddTranslationVelocity
    /// </summary>
    public unsafe virtual void AddTranslationVelocity(System.Numerics.Vector3 TranslationVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddTranslationVelocity, "BmGame.RAnimNode_Pose.AddTranslationVelocity");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TranslationVelocity, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetFaceAtDirection;
    /// <summary>
    /// Function: GetFaceAtDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFaceAtDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFaceAtDirection, "BmGame.RAnimNode_Pose.GetFaceAtDirection");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopFaceAt;
    /// <summary>
    /// Function: StopFaceAt
    /// </summary>
    public unsafe virtual void StopFaceAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFaceAt, "BmGame.RAnimNode_Pose.StopFaceAt");
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

    private static BmSDK.Function __fn_FaceAtActor;
    /// <summary>
    /// Function: FaceAtActor
    /// </summary>
    public unsafe virtual void FaceAtActor(BmSDK.Engine.Actor Actor, BmSDK.FName ActorBoneName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceAtActor, "BmGame.RAnimNode_Pose.FaceAtActor");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBoneName, paramsPtr + 8);
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

    private static BmSDK.Function __fn_FaceAt;
    /// <summary>
    /// Function: FaceAt
    /// </summary>
    public unsafe virtual void FaceAt(System.Numerics.Vector3 Position, BmSDK.BmGame.RAnimUtil.EAbsoluteOrRelative Space = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceAt, "BmGame.RAnimNode_Pose.FaceAt");
        byte* paramsPtr = stackalloc byte[13];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Space, paramsPtr + 12);
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

    private static BmSDK.Function __fn_StopLookAt;
    /// <summary>
    /// Function: StopLookAt
    /// </summary>
    public unsafe virtual void StopLookAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLookAt, "BmGame.RAnimNode_Pose.StopLookAt");
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

    private static BmSDK.Function __fn_LookAtActor;
    /// <summary>
    /// Function: LookAtActor
    /// </summary>
    public unsafe virtual void LookAtActor(BmSDK.Engine.Actor Actor, BmSDK.FName ActorBoneName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAtActor, "BmGame.RAnimNode_Pose.LookAtActor");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBoneName, paramsPtr + 8);
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

    private static BmSDK.Function __fn_LookAt;
    /// <summary>
    /// Function: LookAt
    /// </summary>
    public unsafe virtual void LookAt(System.Numerics.Vector3 Position, BmSDK.BmGame.RAnimUtil.EAbsoluteOrRelative Space)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAt, "BmGame.RAnimNode_Pose.LookAt");
        byte* paramsPtr = stackalloc byte[13];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Space, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetHeadPositionWithAiming;
    /// <summary>
    /// Function: GetHeadPositionWithAiming
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetHeadPositionWithAiming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeadPositionWithAiming, "BmGame.RAnimNode_Pose.GetHeadPositionWithAiming");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeadPositionWithoutAiming;
    /// <summary>
    /// Function: GetHeadPositionWithoutAiming
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetHeadPositionWithoutAiming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeadPositionWithoutAiming, "BmGame.RAnimNode_Pose.GetHeadPositionWithoutAiming");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActualAimAtDirection;
    /// <summary>
    /// Function: GetActualAimAtDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetActualAimAtDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActualAimAtDirection, "BmGame.RAnimNode_Pose.GetActualAimAtDirection");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetAimAtDirection;
    /// <summary>
    /// Function: GetTargetAimAtDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetTargetAimAtDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetAimAtDirection, "BmGame.RAnimNode_Pose.GetTargetAimAtDirection");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SnapAimAt;
    /// <summary>
    /// Function: SnapAimAt
    /// </summary>
    public unsafe virtual void SnapAimAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SnapAimAt, "BmGame.RAnimNode_Pose.SnapAimAt");
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

    private static BmSDK.Function __fn_StopAimAt;
    /// <summary>
    /// Function: StopAimAt
    /// </summary>
    public unsafe virtual void StopAimAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAimAt, "BmGame.RAnimNode_Pose.StopAimAt");
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

    private static BmSDK.Function __fn_AimAtActor;
    /// <summary>
    /// Function: AimAtActor
    /// </summary>
    public unsafe virtual void AimAtActor(BmSDK.Engine.Actor Actor, BmSDK.FName Description, BmSDK.FName ActorBoneName, BmSDK.BmGame.RAnimUtil_PosePlayer.EAllowTurningToAim AllowTurningToAim, float LimitScale = default, BmSDK.BmGame.RPoseConfig.FAimingTransitionTimingOverride TimingOverride = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimAtActor, "BmGame.RAnimNode_Pose.AimAtActor");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBoneName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimitScale, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimingOverride, paramsPtr + 32);
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

    private static BmSDK.Function __fn_AimAt;
    /// <summary>
    /// Function: AimAt
    /// </summary>
    public unsafe virtual void AimAt(System.Numerics.Vector3 Position, BmSDK.FName Description, BmSDK.BmGame.RAnimUtil.EAbsoluteOrRelative Space, BmSDK.BmGame.RAnimUtil_PosePlayer.EAllowTurningToAim AllowTurningToAim, float LimitScale = default, BmSDK.BmGame.RPoseConfig.FAimingTransitionTimingOverride TimingOverride = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimAt, "BmGame.RAnimNode_Pose.AimAt");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Space, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 21);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimitScale, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimingOverride, paramsPtr + 28);
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

    private static BmSDK.Function __fn_IsMoveToProbablyFinished;
    /// <summary>
    /// Function: IsMoveToProbablyFinished
    /// </summary>
    public unsafe virtual bool IsMoveToProbablyFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMoveToProbablyFinished, "BmGame.RAnimNode_Pose.IsMoveToProbablyFinished");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsMoveToFinished;
    /// <summary>
    /// Function: IsMoveToFinished
    /// </summary>
    public unsafe virtual bool IsMoveToFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMoveToFinished, "BmGame.RAnimNode_Pose.IsMoveToFinished");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsMoveToActive;
    /// <summary>
    /// Function: IsMoveToActive
    /// </summary>
    public unsafe virtual bool IsMoveToActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMoveToActive, "BmGame.RAnimNode_Pose.IsMoveToActive");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMoveToDirection;
    /// <summary>
    /// Function: GetMoveToDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMoveToDirection()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMoveToDirection, "BmGame.RAnimNode_Pose.GetMoveToDirection");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InstantStopMoveTo;
    /// <summary>
    /// Function: InstantStopMoveTo
    /// </summary>
    public unsafe virtual void InstantStopMoveTo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantStopMoveTo, "BmGame.RAnimNode_Pose.InstantStopMoveTo");
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

    private static BmSDK.Function __fn_StopMoveTo;
    /// <summary>
    /// Function: StopMoveTo
    /// </summary>
    public unsafe virtual void StopMoveTo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopMoveTo, "BmGame.RAnimNode_Pose.StopMoveTo");
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

    private static BmSDK.Function __fn_MoveTo;
    /// <summary>
    /// Function: MoveTo
    /// </summary>
    public unsafe virtual void MoveTo(System.Numerics.Vector3 Position, BmSDK.BmGame.RAnimUtil.EAbsoluteOrRelative Space)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveTo, "BmGame.RAnimNode_Pose.MoveTo");
        byte* paramsPtr = stackalloc byte[13];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Space, paramsPtr + 12);
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

    private static BmSDK.Function __fn_PlayOneShotMovementCycle;
    /// <summary>
    /// Function: PlayOneShotMovementCycle
    /// </summary>
    public unsafe virtual void PlayOneShotMovementCycle(BmSDK.BmGame.RAnimConfig.FCustomAnimConfig AnimConfig, BmSDK.FName Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayOneShotMovementCycle, "BmGame.RAnimNode_Pose.PlayOneShotMovementCycle");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimConfig, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 52);
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

    private static BmSDK.Function __fn_GetMovementSpeedScale;
    /// <summary>
    /// Function: GetMovementSpeedScale
    /// </summary>
    public unsafe virtual float GetMovementSpeedScale()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMovementSpeedScale, "BmGame.RAnimNode_Pose.GetMovementSpeedScale");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMovementSpeed;
    /// <summary>
    /// Function: GetMovementSpeed
    /// </summary>
    public unsafe virtual BmSDK.Engine.RAutomaticTransitions.EMovementSpeed GetMovementSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMovementSpeed, "BmGame.RAnimNode_Pose.GetMovementSpeed");
        byte* paramsPtr = stackalloc byte[1];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAutomaticTransitions.EMovementSpeed>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMovementSpeed;
    /// <summary>
    /// Function: SetMovementSpeed
    /// </summary>
    public unsafe virtual void SetMovementSpeed(BmSDK.Engine.RAutomaticTransitions.EMovementSpeed NewSpeed, float NewSpeedScale, BmSDK.BmGame.RAnimUtil_PosePlayer.EMoveToRequestFacing NewFacing = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMovementSpeed, "BmGame.RAnimNode_Pose.SetMovementSpeed");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSpeed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSpeedScale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFacing, paramsPtr + 8);
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

    private static BmSDK.Function __fn_IsInWeaponTransition;
    /// <summary>
    /// Function: IsInWeaponTransition
    /// </summary>
    public unsafe virtual bool IsInWeaponTransition(BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInWeaponTransition, "BmGame.RAnimNode_Pose.IsInWeaponTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsTransitionMirrored;
    /// <summary>
    /// Function: IsTransitionMirrored
    /// </summary>
    public unsafe virtual bool IsTransitionMirrored()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTransitionMirrored, "BmGame.RAnimNode_Pose.IsTransitionMirrored");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPoseMirrored;
    /// <summary>
    /// Function: IsPoseMirrored
    /// </summary>
    public unsafe virtual bool IsPoseMirrored()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPoseMirrored, "BmGame.RAnimNode_Pose.IsPoseMirrored");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAllowAutomaticTransitionOutOfMatinee;
    /// <summary>
    /// Function: SetAllowAutomaticTransitionOutOfMatinee
    /// </summary>
    public unsafe virtual void SetAllowAutomaticTransitionOutOfMatinee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowAutomaticTransitionOutOfMatinee, "BmGame.RAnimNode_Pose.SetAllowAutomaticTransitionOutOfMatinee");
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

    private static BmSDK.Function __fn_IsControlledByParticularMatinee;
    /// <summary>
    /// Function: IsControlledByParticularMatinee
    /// </summary>
    public unsafe virtual bool IsControlledByParticularMatinee(BmSDK.Engine.InterpGroupInst InterpGroupInst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControlledByParticularMatinee, "BmGame.RAnimNode_Pose.IsControlledByParticularMatinee");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsControlledByMatinee;
    /// <summary>
    /// Function: IsControlledByMatinee
    /// </summary>
    public unsafe virtual bool IsControlledByMatinee()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControlledByMatinee, "BmGame.RAnimNode_Pose.IsControlledByMatinee");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInIdleStance;
    /// <summary>
    /// Function: IsInIdleStance
    /// </summary>
    public unsafe virtual bool IsInIdleStance(BmSDK.FName Stance, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInIdleStance, "BmGame.RAnimNode_Pose.IsInIdleStance");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsInWeaponStance;
    /// <summary>
    /// Function: IsInWeaponStance
    /// </summary>
    public unsafe virtual bool IsInWeaponStance(BmSDK.FName Stance, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInWeaponStance, "BmGame.RAnimNode_Pose.IsInWeaponStance");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsInMovementStance;
    /// <summary>
    /// Function: IsInMovementStance
    /// </summary>
    public unsafe virtual bool IsInMovementStance(BmSDK.FName Stance, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInMovementStance, "BmGame.RAnimNode_Pose.IsInMovementStance");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetIdleStance;
    /// <summary>
    /// Function: GetIdleStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetIdleStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIdleStance, "BmGame.RAnimNode_Pose.GetIdleStance");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWeaponStance;
    /// <summary>
    /// Function: GetWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetWeaponStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponStance, "BmGame.RAnimNode_Pose.GetWeaponStance");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMovementStance;
    /// <summary>
    /// Function: GetMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetMovementStance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMovementStance, "BmGame.RAnimNode_Pose.GetMovementStance");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EndSetDirectionalWeightsOnTransition;
    /// <summary>
    /// Function: EndSetDirectionalWeightsOnTransition
    /// </summary>
    public unsafe virtual void EndSetDirectionalWeightsOnTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id, BmSDK.Engine.Actor Actor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndSetDirectionalWeightsOnTransition, "BmGame.RAnimNode_Pose.EndSetDirectionalWeightsOnTransition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetDirectionalWeightOnTransition;
    /// <summary>
    /// Function: SetDirectionalWeightOnTransition
    /// </summary>
    public unsafe virtual void SetDirectionalWeightOnTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id, int Index, float Weight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDirectionalWeightOnTransition, "BmGame.RAnimNode_Pose.SetDirectionalWeightOnTransition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weight, paramsPtr + 8);
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

    private static BmSDK.Function __fn_BeginSetDirectionalWeightsOnTransition;
    /// <summary>
    /// Function: BeginSetDirectionalWeightsOnTransition
    /// </summary>
    public unsafe virtual void BeginSetDirectionalWeightsOnTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginSetDirectionalWeightsOnTransition, "BmGame.RAnimNode_Pose.BeginSetDirectionalWeightsOnTransition");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
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

    private static BmSDK.Function __fn_EndSetDirectionalWeights;
    /// <summary>
    /// Function: EndSetDirectionalWeights
    /// </summary>
    public unsafe virtual void EndSetDirectionalWeights(BmSDK.Engine.Actor Actor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndSetDirectionalWeights, "BmGame.RAnimNode_Pose.EndSetDirectionalWeights");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetDirectionalWeight;
    /// <summary>
    /// Function: SetDirectionalWeight
    /// </summary>
    public unsafe virtual void SetDirectionalWeight(int Index, float Weight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDirectionalWeight, "BmGame.RAnimNode_Pose.SetDirectionalWeight");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weight, paramsPtr + 4);
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

    private static BmSDK.Function __fn_BeginSetDirectionalWeights;
    /// <summary>
    /// Function: BeginSetDirectionalWeights
    /// </summary>
    public unsafe virtual void BeginSetDirectionalWeights()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginSetDirectionalWeights, "BmGame.RAnimNode_Pose.BeginSetDirectionalWeights");
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

    private static BmSDK.Function __fn_GetRelativeTargetRotation;
    /// <summary>
    /// Function: GetRelativeTargetRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetRelativeTargetRotation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRelativeTargetRotation, "BmGame.RAnimNode_Pose.GetRelativeTargetRotation");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRelativeTargetYaw;
    /// <summary>
    /// Function: GetRelativeTargetYaw
    /// </summary>
    public unsafe virtual int GetRelativeTargetYaw()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRelativeTargetYaw, "BmGame.RAnimNode_Pose.GetRelativeTargetYaw");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRelativeTargetPosition;
    /// <summary>
    /// Function: GetRelativeTargetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRelativeTargetPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRelativeTargetPosition, "BmGame.RAnimNode_Pose.GetRelativeTargetPosition");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTransitionType;
    /// <summary>
    /// Function: GetTransitionType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimTransitionType GetTransitionType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionType, "BmGame.RAnimNode_Pose.GetTransitionType");
        byte* paramsPtr = stackalloc byte[1];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimTransitionType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetActorSpaceRelativeTarget;
    /// <summary>
    /// Function: SetActorSpaceRelativeTarget
    /// </summary>
    public unsafe virtual void SetActorSpaceRelativeTarget(BmSDK.Engine.Actor RelativeActor, System.Numerics.Vector3 NewPosition = default, BmSDK.Rotator NewRotation = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActorSpaceRelativeTarget, "BmGame.RAnimNode_Pose.SetActorSpaceRelativeTarget");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelativeActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPosition, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 20);
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

    private static BmSDK.Function __fn_SetRelativeTargetRotation;
    /// <summary>
    /// Function: SetRelativeTargetRotation
    /// </summary>
    public unsafe virtual void SetRelativeTargetRotation(BmSDK.Rotator NewRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRelativeTargetRotation, "BmGame.RAnimNode_Pose.SetRelativeTargetRotation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetRelativeTargetYaw;
    /// <summary>
    /// Function: SetRelativeTargetYaw
    /// </summary>
    public unsafe virtual void SetRelativeTargetYaw(int NewYaw)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRelativeTargetYaw, "BmGame.RAnimNode_Pose.SetRelativeTargetYaw");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewYaw, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetRelativeTargetPosition;
    /// <summary>
    /// Function: SetRelativeTargetPosition
    /// </summary>
    public unsafe virtual void SetRelativeTargetPosition(System.Numerics.Vector3 NewPosition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRelativeTargetPosition, "BmGame.RAnimNode_Pose.SetRelativeTargetPosition");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPosition, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetTransitionType;
    /// <summary>
    /// Function: SetTransitionType
    /// </summary>
    public unsafe virtual void SetTransitionType(BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimTransitionType NewType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTransitionType, "BmGame.RAnimNode_Pose.SetTransitionType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewType, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FakeTickTransitionTime;
    /// <summary>
    /// Function: FakeTickTransitionTime
    /// </summary>
    public unsafe virtual void FakeTickTransitionTime(float NormalizedTime, int DisableTimeAdvanceForNumFrames = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeTickTransitionTime, "BmGame.RAnimNode_Pose.FakeTickTransitionTime");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalizedTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableTimeAdvanceForNumFrames, paramsPtr + 4);
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

    private static BmSDK.Function __fn_TeleportTransitionTime;
    /// <summary>
    /// Function: TeleportTransitionTime
    /// </summary>
    public unsafe virtual void TeleportTransitionTime(float NormalizedTime, int DisableTimeAdvanceForNumFrames = default, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Transition = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeleportTransitionTime, "BmGame.RAnimNode_Pose.TeleportTransitionTime");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalizedTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableTimeAdvanceForNumFrames, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Transition, paramsPtr + 8);
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

    private static BmSDK.Function __fn_MatineeTeleport;
    /// <summary>
    /// Function: MatineeTeleport
    /// </summary>
    public unsafe virtual void MatineeTeleport(BmSDK.Engine.InterpGroupInst InterpGroupInst, BmSDK.FName DebugSource)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatineeTeleport, "BmGame.RAnimNode_Pose.MatineeTeleport");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugSource, paramsPtr + 8);
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

    private static BmSDK.Function __fn_UpdateMatineeMovementTarget;
    /// <summary>
    /// Function: UpdateMatineeMovementTarget
    /// </summary>
    public unsafe virtual void UpdateMatineeMovementTarget(BmSDK.Engine.InterpGroupInst InterpGroupInst, System.Numerics.Vector3 TargetLocation, BmSDK.Rotator TargetRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMatineeMovementTarget, "BmGame.RAnimNode_Pose.UpdateMatineeMovementTarget");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetRotation, paramsPtr + 20);
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

    private static BmSDK.Function __fn_UpdateMatineeAnim;
    /// <summary>
    /// Function: UpdateMatineeAnim
    /// </summary>
    public unsafe virtual void UpdateMatineeAnim(BmSDK.Engine.InterpGroupInst InterpGroupInst, BmSDK.FName SlotName, BmSDK.FName AnimName, float Time, bool FireNotifies, bool Looping)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMatineeAnim, "BmGame.RAnimNode_Pose.UpdateMatineeAnim");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireNotifies, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Looping, paramsPtr + 32);
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

    private static BmSDK.Function __fn_GetNullTransitionId;
    /// <summary>
    /// Function: GetNullTransitionId
    /// </summary>
    public unsafe static BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetNullTransitionId()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNullTransitionId, "BmGame.RAnimNode_Pose.GetNullTransitionId");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearQueue;
    /// <summary>
    /// Function: ClearQueue
    /// </summary>
    public unsafe virtual void ClearQueue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearQueue, "BmGame.RAnimNode_Pose.ClearQueue");
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

    private static BmSDK.Function __fn_ChangePose;
    /// <summary>
    /// Function: ChangePose
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ChangePose(BmSDK.BmGame.RAnimNode_Pose.FPoseDescription Input, BmSDK.BmGame.RAnimNode_Pose.FPreviousPoseDescription PreviousInput)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePose, "BmGame.RAnimNode_Pose.ChangePose");
        byte* paramsPtr = stackalloc byte[468];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Input, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousInput, paramsPtr + 360);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 464);
    }

    private static BmSDK.Function __fn_DummyOnPlayedQueuedTransition;
    /// <summary>
    /// Function: DummyOnPlayedQueuedTransition
    /// </summary>
    public unsafe virtual void DummyOnPlayedQueuedTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Id, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DummyOnPlayedQueuedTransition, "BmGame.RAnimNode_Pose.DummyOnPlayedQueuedTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FGlobalGundummyAnimState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FGlobalGundummyAnimState
    {
        /// <summary>
        /// ObjectProperty: Anim
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence Anim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: NormalizedTime
        /// </summary>
        public unsafe float NormalizedTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: Weight
        /// </summary>
        public unsafe float Weight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FGlobalAdditiveAnimState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FGlobalAdditiveAnimState
    {
        /// <summary>
        /// NameProperty: Slot
        /// </summary>
        public unsafe BmSDK.FName Slot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: AddAnim
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence AddAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: SubtractAnim
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence SubtractAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: NormalizedTime
        /// </summary>
        public unsafe float NormalizedTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: Weight
        /// </summary>
        public unsafe float Weight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FBreathingState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FBreathingState
    {
        /// <summary>
        /// BoolProperty: Allowed
        /// </summary>
        public unsafe bool Allowed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: PreviousUnconscious
        /// </summary>
        public unsafe bool PreviousUnconscious
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: TimeScale
        /// </summary>
        public unsafe float TimeScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FCurveFloatState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FCurveFloatState
    {
        /// <summary>
        /// ArrayProperty: CurrentValues
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RAnimNode_Pose.FCurveFloat> CurrentValues
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnimNode_Pose.FCurveFloat>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FCurveFloat
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FCurveFloat
    {
        /// <summary>
        /// NameProperty: FloatName
        /// </summary>
        public unsafe BmSDK.FName FloatName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: FloatValue
        /// </summary>
        public unsafe float FloatValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FPoseDescription
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 360)]
    public partial record struct FPoseDescription
    {
        /// <summary>
        /// NameProperty: MovementStance
        /// </summary>
        public unsafe BmSDK.FName MovementStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: WeaponStance
        /// </summary>
        public unsafe BmSDK.FName WeaponStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: IdleStance
        /// </summary>
        public unsafe BmSDK.FName IdleStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: TransitionType
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimTransitionType TransitionType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimTransitionType>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// NameProperty: TransitionName
        /// </summary>
        public unsafe BmSDK.FName TransitionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: TransitionOverrideDurationEnabled
        /// </summary>
        public unsafe bool TransitionOverrideDurationEnabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: TransitionOverrideDuration
        /// </summary>
        public unsafe float TransitionOverrideDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: TransitionDurationScale
        /// </summary>
        public unsafe float TransitionDurationScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: TransitionMeetingPointBegin
        /// </summary>
        public unsafe float TransitionMeetingPointBegin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: TransitionMeetingPointEnd
        /// </summary>
        public unsafe float TransitionMeetingPointEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// ByteProperty: TransitionMirrored
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// StructProperty: TransitionSlavedTo
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FSlavedToTransitionDescription TransitionSlavedTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FSlavedToTransitionDescription>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: TransitionStartTime
        /// </summary>
        public unsafe float TransitionStartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// ObjectProperty: Weapon
        /// </summary>
        public unsafe BmSDK.Engine.Inventory Weapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// ObjectProperty: TransitionWeapon
        /// </summary>
        public unsafe BmSDK.Engine.Inventory TransitionWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// ObjectProperty: WeaponConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RWeaponConfig WeaponConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// ObjectProperty: TransitionWeaponConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RWeaponConfig TransitionWeaponConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// StructProperty: CustomIdle
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.FCustomAnimConfig CustomIdle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }

        /// <summary>
        /// StructProperty: CustomTransition
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.FCustomAnimConfig CustomTransition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(Ptr + 180); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }; }
        }

        /// <summary>
        /// ObjectProperty: MatineeInterpGroupInst
        /// </summary>
        public unsafe BmSDK.Engine.InterpGroupInst MatineeInterpGroupInst
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpGroupInst>(Ptr + 232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }; }
        }

        /// <summary>
        /// DelegateProperty: OnPlayedQueuedTransition
        /// </summary>
        public unsafe System.IntPtr OnPlayedQueuedTransition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }; }
        }

        /// <summary>
        /// ByteProperty: IdleType
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimIdleType IdleType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.EAnimIdleType>(Ptr + 256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }; }
        }

        /// <summary>
        /// StructProperty: IdleSlavedTo
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FIdleSlavedToDescription IdleSlavedTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FIdleSlavedToDescription>(Ptr + 260); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }; }
        }

        /// <summary>
        /// StructProperty: BeginEverythingSlavedTo
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FBeginEverythingSlavedToDescription BeginEverythingSlavedTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FBeginEverythingSlavedToDescription>(Ptr + 272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }; }
        }

        /// <summary>
        /// StructProperty: EndEverythingSlavedTo
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FEndEverythingSlavedToDescription EndEverythingSlavedTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FEndEverythingSlavedToDescription>(Ptr + 300); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }; }
        }

        /// <summary>
        /// BoolProperty: OverrideIdleStartTimeEnabled
        /// </summary>
        public unsafe bool OverrideIdleStartTimeEnabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 304); }; }
        }

        /// <summary>
        /// FloatProperty: OverrideIdleStartTime
        /// </summary>
        public unsafe float OverrideIdleStartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 308); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }; }
        }

        /// <summary>
        /// StructProperty: RelativeTarget
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FRelativeTarget RelativeTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FRelativeTarget>(Ptr + 312); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }; }
        }

        /// <summary>
        /// BoolProperty: TransitionDoesntConsumeAdditiveWeight
        /// </summary>
        public unsafe bool TransitionDoesntConsumeAdditiveWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }; }
        }

        /// <summary>
        /// BoolProperty: TransitionAlwaysAdditiveBlendIn
        /// </summary>
        public unsafe bool TransitionAlwaysAdditiveBlendIn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }; }
        }

        /// <summary>
        /// BoolProperty: TransitionForceBlend
        /// </summary>
        public unsafe bool TransitionForceBlend
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }; }
        }

        /// <summary>
        /// BoolProperty: Mirrored
        /// </summary>
        public unsafe bool Mirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }; }
        }

        /// <summary>
        /// BoolProperty: ForceChange
        /// </summary>
        public unsafe bool ForceChange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }; }
        }

        /// <summary>
        /// BoolProperty: WarnWhenDiscardingChanges
        /// </summary>
        public unsafe bool WarnWhenDiscardingChanges
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }; }
        }

        /// <summary>
        /// BoolProperty: Queued
        /// </summary>
        public unsafe bool Queued
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }; }
        }
    }

    /// <summary>
    /// Struct: FPreviousPoseDescription
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial record struct FPreviousPoseDescription
    {
        /// <summary>
        /// NameProperty: MovementStance
        /// </summary>
        public unsafe BmSDK.FName MovementStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: WeaponStance
        /// </summary>
        public unsafe BmSDK.FName WeaponStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: IdleStance
        /// </summary>
        public unsafe BmSDK.FName IdleStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: Weapon
        /// </summary>
        public unsafe BmSDK.Engine.Inventory Weapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: WeaponConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RWeaponConfig WeaponConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: Mirrored
        /// </summary>
        public unsafe bool Mirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// ObjectProperty: MatineeInterpGroupInst
        /// </summary>
        public unsafe BmSDK.Engine.InterpGroupInst MatineeInterpGroupInst
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpGroupInst>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StructProperty: CustomIdle
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.FCustomAnimConfig CustomIdle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
    }

    /// <summary>
    /// Struct: FEditorNonsense
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial record struct FEditorNonsense
    {
        /// <summary>
        /// StructProperty: Idle
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.FAnimConfig Idle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FAnimConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: AdditiveIdle
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.FAdditiveAnimConfig AdditiveIdle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FAdditiveAnimConfig>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: AimAtYaw
        /// </summary>
        public unsafe float AimAtYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: AimAtPitch
        /// </summary>
        public unsafe float AimAtPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: LookAtYaw
        /// </summary>
        public unsafe float LookAtYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: LookAtPitch
        /// </summary>
        public unsafe float LookAtPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ObjectProperty: AimingConfig
        /// </summary>
        public unsafe BmSDK.Engine.RAimingConfig AimingConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAimingConfig>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// StructProperty: AimAtTiming
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.FAimingTransitionTiming AimAtTiming
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FAimingTransitionTiming>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// StructProperty: LookAtTiming
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.FAimingTransitionTiming LookAtTiming
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FAimingTransitionTiming>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// BoolProperty: AimAtEnabled
        /// </summary>
        public unsafe bool AimAtEnabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }; }
        }

        /// <summary>
        /// BoolProperty: LookAtEnabled
        /// </summary>
        public unsafe bool LookAtEnabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }; }
        }

        /// <summary>
        /// BoolProperty: Mirrored
        /// </summary>
        public unsafe bool Mirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }; }
        }
    }

    /// <summary>
    /// BoolProperty: EnableRagdollSupport
    /// </summary>
    public unsafe bool EnableRagdollSupport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: EnableCheekyBlending
    /// </summary>
    public unsafe bool EnableCheekyBlending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: SyncToAudioTime
    /// </summary>
    public unsafe bool SyncToAudioTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: DumpThoughts
    /// </summary>
    public unsafe bool DumpThoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: TickLocked
    /// </summary>
    public unsafe bool TickLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: BetweenTick1And2
    /// </summary>
    public unsafe bool BetweenTick1And2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: ForceResetOnInitAnim
    /// </summary>
    public unsafe bool ForceResetOnInitAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: ForceBlockActorsOff
    /// </summary>
    public unsafe bool ForceBlockActorsOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: ForceCollideWorldOff
    /// </summary>
    public unsafe bool ForceCollideWorldOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: TempDisableCollisionCorrection
    /// </summary>
    public unsafe bool TempDisableCollisionCorrection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: TempDisableLegIk
    /// </summary>
    public unsafe bool TempDisableLegIk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: Unconscious
    /// </summary>
    public unsafe bool Unconscious
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: DisableBlink
    /// </summary>
    public unsafe bool DisableBlink
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: ForceAnimatedAutomaticTransitionsOff
    /// </summary>
    public unsafe bool ForceAnimatedAutomaticTransitionsOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: MouseSteering
    /// </summary>
    public unsafe bool MouseSteering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: EnableIndependentTick
    /// </summary>
    public unsafe bool EnableIndependentTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: TickDisabled
    /// </summary>
    public unsafe bool TickDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: EnableLocalRotZ
    /// </summary>
    public unsafe bool EnableLocalRotZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// StructProperty: Editor
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimNode_Pose.FEditorNonsense Editor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimNode_Pose.FEditorNonsense>(Ptr + 284);

    /// <summary>
    /// StructProperty: PreviousEditor
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimNode_Pose.FEditorNonsense PreviousEditor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimNode_Pose.FEditorNonsense>(Ptr + 404);

    /// <summary>
    /// ObjectProperty: EditorMasterNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence EditorMasterNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ObjectProperty: EditorMirrorNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeMirror EditorMirrorNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeMirror>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsOutput
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PhysicsOutput PhysicsOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PhysicsOutput>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: FaceFXOutput
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_FaceFXOutput FaceFXOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_FaceFXOutput>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ObjectProperty: FloorCorrection
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_FloorCorrection FloorCorrection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_FloorCorrection>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ObjectProperty: ShimmyCorrection
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_ShimmyCorrection ShimmyCorrection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_ShimmyCorrection>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ObjectProperty: PreviousSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh PreviousSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: PreviousPhysicsAsset
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset PreviousPhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ObjectProperty: AimingBoneConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig AimingBoneConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSwitchWeaponBoneNotify
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_SwitchWeaponBone CurrentSwitchWeaponBoneNotify
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_SwitchWeaponBone>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ComponentProperty: PreviousSkelComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent PreviousSkelComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// StructProperty: CurrCurveFloatState
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimNode_Pose.FCurveFloatState CurrCurveFloatState
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimNode_Pose.FCurveFloatState>(Ptr + 612);

    /// <summary>
    /// StructProperty: PosePlayer
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FPosePlayer PosePlayer
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FPosePlayer>(Ptr + 628);

    /// <summary>
    /// StructProperty: PendingQueuedTransitionCallback
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FPendingQueuedTransitionCallback PendingQueuedTransitionCallback
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FPendingQueuedTransitionCallback>(Ptr + 1044);

    /// <summary>
    /// StructProperty: MovementPlayer
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_MovementPlayer.FMovementPlayer MovementPlayer
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_MovementPlayer.FMovementPlayer>(Ptr + 1072);

    /// <summary>
    /// StructProperty: MovementOutput
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_MovementOutput.FMovementOutput MovementOutput
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_MovementOutput.FMovementOutput>(Ptr + 1184);

    /// <summary>
    /// StructProperty: WeaponOverlays
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayPlayer WeaponOverlays
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayPlayer>(Ptr + 1312);

    /// <summary>
    /// StructProperty: IdleOverlays
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayPlayer IdleOverlays
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayPlayer>(Ptr + 1340);

    /// <summary>
    /// StructProperty: AdditiveOverlays
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FAdditiveOverlayPlayer AdditiveOverlays
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FAdditiveOverlayPlayer>(Ptr + 1368);

    /// <summary>
    /// StructProperty: GlobalAdditiveOverlays
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FGlobalAdditiveOverlayPlayer GlobalAdditiveOverlays
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FGlobalAdditiveOverlayPlayer>(Ptr + 1392);

    /// <summary>
    /// StructProperty: AnimAccumulator
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FAnimAccumulator AnimAccumulator
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FAnimAccumulator>(Ptr + 1424);

    /// <summary>
    /// ArrayProperty: TransientNotifyThoughts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor.FThought> TransientNotifyThoughts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// StructProperty: Breathing
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimNode_Pose.FBreathingState Breathing
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimNode_Pose.FBreathingState>(Ptr + 1536);

    /// <summary>
    /// FloatProperty: GlobalTimeScale
    /// </summary>
    public unsafe float GlobalTimeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// StructProperty: NotifyAnim
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FNotifyAnim NotifyAnim
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FNotifyAnim>(Ptr + 1552);

    /// <summary>
    /// ArrayProperty: GlobalAdditiveAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAnimNode_Pose.FGlobalAdditiveAnimState> GlobalAdditiveAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnimNode_Pose.FGlobalAdditiveAnimState>>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// StructProperty: GlobalGundummyAnim
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimNode_Pose.FGlobalGundummyAnimState GlobalGundummyAnim
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimNode_Pose.FGlobalGundummyAnimState>(Ptr + 1596);

    /// <summary>
    /// FloatProperty: LocalRotZ
    /// </summary>
    public unsafe float LocalRotZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// StructProperty: AsyncJob
    /// </summary>
    public unsafe System.IntPtr AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// DelegateProperty: __DummyOnPlayedQueuedTransition__Delegate
    /// </summary>
    public unsafe System.IntPtr __DummyOnPlayedQueuedTransition__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }
}
