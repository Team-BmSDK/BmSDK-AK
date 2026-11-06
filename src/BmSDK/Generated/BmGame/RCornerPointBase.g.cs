#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCornerPointBase<br/>
/// (size = 756)
/// (flags = 144704146)
/// </summary>
public partial class RCornerPointBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCornerPointBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCornerPointBase.
    /// </summary>
    public static RCornerPointBase DefaultObject => (RCornerPointBase)StaticClass().DefaultObject;

    internal RCornerPointBase() { }

    /// <summary>
    /// Constructs a new RCornerPointBase
    /// </summary>
    public RCornerPointBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCornerPointBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCornerPointBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCornerPointBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCornerPointBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCornerPointBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCornerPointBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCornerPointBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCornerPointBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCornerPointBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsLockedBy;
    /// <summary>
    /// Function: IsLockedBy
    /// </summary>
    public unsafe virtual bool IsLockedBy(BmSDK.BmGame.RBMAIController TestLockedBy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLockedBy, "BmGame.RCornerPointBase.IsLockedBy");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLockedBy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsLocked;
    /// <summary>
    /// Function: IsLocked
    /// </summary>
    public unsafe virtual bool IsLocked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocked, "BmGame.RCornerPointBase.IsLocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnLock;
    /// <summary>
    /// Function: UnLock
    /// </summary>
    public unsafe virtual void UnLock(BmSDK.BmGame.RBMAIController Unlocker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnLock, "BmGame.RCornerPointBase.UnLock");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Unlocker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Lock;
    /// <summary>
    /// Function: Lock
    /// </summary>
    public unsafe virtual void Lock(BmSDK.BmGame.RBMAIController NewLockedBy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Lock, "BmGame.RCornerPointBase.Lock");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLockedBy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAmbushDir;
    /// <summary>
    /// Function: GetAmbushDir
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCornerPointBase.AmbushDir GetAmbushDir(System.Numerics.Vector3 TargetPos, BmSDK.BmGame.RBMPawnAI HostPawn, BmSDK.BmGame.RCornerWallMarker AmbushStart, out BmSDK.BmGame.RCornerWallMarker AmbushEnd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAmbushDir, "BmGame.RCornerPointBase.GetAmbushDir");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HostPawn, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmbushStart, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AmbushEnd);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmbushEnd, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AmbushEnd = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCornerWallMarker>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCornerPointBase.AmbushDir>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetAmbushOffset;
    /// <summary>
    /// Function: GetAmbushOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAmbushOffset(BmSDK.BmGame.RBMPawnAI HostPawn, System.Numerics.Vector3 StartPos, BmSDK.Rotator StartRot, BmSDK.BmGame.RCornerPointBase.AmbushDir Dir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAmbushOffset, "BmGame.RCornerPointBase.GetAmbushOffset");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HostPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartRot, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetPrevWall;
    /// <summary>
    /// Function: GetPrevWall
    /// </summary>
    public unsafe virtual int GetPrevWall(int ThisIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrevWall, "BmGame.RCornerPointBase.GetPrevWall");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNextWall;
    /// <summary>
    /// Function: GetNextWall
    /// </summary>
    public unsafe virtual int GetNextWall(int ThisIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextWall, "BmGame.RCornerPointBase.GetNextWall");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RCornerPointBase.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RCornerPointBase.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RCornerPointBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDistFromExposureLine;
    /// <summary>
    /// Function: GetDistFromExposureLine
    /// </summary>
    public unsafe virtual float GetDistFromExposureLine(System.Numerics.Vector3 TestPos, System.Numerics.Vector3 HideFromPos, BmSDK.BmGame.RCornerWallMarker AmbushStart, BmSDK.BmGame.RCornerWallMarker AmbushEnd)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDistFromExposureLine, "BmGame.RCornerPointBase.GetDistFromExposureLine");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HideFromPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmbushStart, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmbushEnd, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_CanBeLockedBy;
    /// <summary>
    /// Function: CanBeLockedBy
    /// </summary>
    public unsafe virtual bool CanBeLockedBy(BmSDK.BmGame.RBMAIController TestLockedBy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeLockedBy, "BmGame.RCornerPointBase.CanBeLockedBy");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLockedBy, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetCornerFor;
    /// <summary>
    /// Function: GetCornerFor
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCornerFor(BmSDK.BmGame.RCornerWallMarker StartWall, BmSDK.BmGame.RCornerWallMarker DestWall)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCornerFor, "BmGame.RCornerPointBase.GetCornerFor");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartWall, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestWall, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DeregisterCornerPointsWithNavMesh;
    /// <summary>
    /// Function: DeregisterCornerPointsWithNavMesh
    /// </summary>
    public unsafe virtual void DeregisterCornerPointsWithNavMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeregisterCornerPointsWithNavMesh, "BmGame.RCornerPointBase.DeregisterCornerPointsWithNavMesh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_RegisterCornerPointsWithNavMesh;
    /// <summary>
    /// Function: RegisterCornerPointsWithNavMesh
    /// </summary>
    public unsafe virtual void RegisterCornerPointsWithNavMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterCornerPointsWithNavMesh, "BmGame.RCornerPointBase.RegisterCornerPointsWithNavMesh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    /// <summary>
    /// Enum: AmbushDir
    /// </summary>
    public enum AmbushDir : byte
    {
        AMB_NONE = 0,
        AMB_LEFT = 1,
        AMB_RIGHT = 2,
        AMB_MAX = 3,
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: WallPoint
    /// </summary>
    public InlineArray<BmSDK.BmGame.RCornerWallMarkerBase> WallPoint => new(4, Ptr + 668, 8, this);

    /// <summary>
    /// ObjectProperty: WallPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerWallMarkerBase WallPoint_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerWallMarkerBase>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }
    /// <summary>
    /// ObjectProperty: WallPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerWallMarkerBase WallPoint_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerWallMarkerBase>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }
    /// <summary>
    /// ObjectProperty: WallPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerWallMarkerBase WallPoint_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerWallMarkerBase>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }
    /// <summary>
    /// ObjectProperty: WallPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerWallMarkerBase WallPoint_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerWallMarkerBase>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: LockedBy
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController LockedBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: LinkedFractureWall
    /// </summary>
    public unsafe BmSDK.BmGame.RFractureWallBase LinkedFractureWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFractureWallBase>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredPolyList
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RegisteredPolyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StructProperty: FirstWallNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FirstWallNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 732);

    /// <summary>
    /// FloatProperty: OffsetDist
    /// </summary>
    public unsafe float OffsetDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bAICanUse
    /// </summary>
    public unsafe bool bAICanUse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bDontUpdateInOvernightBuild
    /// </summary>
    public unsafe bool bDontUpdateInOvernightBuild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// FloatProperty: LastLockTime
    /// </summary>
    public unsafe float LastLockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }
}
