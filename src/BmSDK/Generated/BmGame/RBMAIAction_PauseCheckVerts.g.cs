#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIAction_PauseCheckVerts<br/>
/// (size = 988)
/// (flags = 10485778)
/// </summary>
public partial class RBMAIAction_PauseCheckVerts : BmSDK.BmGame.RBMAIAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIAction_PauseCheckVerts", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMAIAction_PauseCheckVerts.
    /// </summary>
    public static RBMAIAction_PauseCheckVerts DefaultObject => (RBMAIAction_PauseCheckVerts)StaticClass().DefaultObject;

    internal RBMAIAction_PauseCheckVerts() { }

    /// <summary>
    /// Constructs a new RBMAIAction_PauseCheckVerts
    /// </summary>
    public RBMAIAction_PauseCheckVerts(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIAction_PauseCheckVerts(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PauseCheckVerts>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PauseCheckVerts>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PauseCheckVerts>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PauseCheckVerts>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PauseCheckVerts>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PauseCheckVerts>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PauseCheckVerts>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PauseCheckVerts>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DebugShowVerts;
    /// <summary>
    /// Function: DebugShowVerts
    /// </summary>
    public unsafe virtual void DebugShowVerts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugShowVerts, "BmGame.RBMAIAction_PauseCheckVerts.DebugShowVerts");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActionTick;
    /// <summary>
    /// Function: ActionTick
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMAIAction.ActionTickResult ActionTick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActionTick, "BmGame.RBMAIAction_PauseCheckVerts.ActionTick");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIAction.ActionTickResult>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNextAimIndex_Checked;
    /// <summary>
    /// Function: GetNextAimIndex_Checked
    /// </summary>
    public unsafe virtual int GetNextAimIndex_Checked(out System.Numerics.Vector3 FaceAtDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextAimIndex_Checked, "BmGame.RBMAIAction_PauseCheckVerts.GetNextAimIndex_Checked");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FaceAtDir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FaceAtDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FaceAtDir = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetNextAimIndex_Unchecked;
    /// <summary>
    /// Function: GetNextAimIndex_Unchecked
    /// </summary>
    public unsafe virtual int GetNextAimIndex_Unchecked(out System.Numerics.Vector3 FaceAtDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextAimIndex_Unchecked, "BmGame.RBMAIAction_PauseCheckVerts.GetNextAimIndex_Unchecked");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FaceAtDir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FaceAtDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FaceAtDir = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PointIsBehind;
    /// <summary>
    /// Function: PointIsBehind
    /// </summary>
    public unsafe virtual bool PointIsBehind(System.Numerics.Vector3 TestDir)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointIsBehind, "BmGame.RBMAIAction_PauseCheckVerts.PointIsBehind");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_MoveCheckedPointsToCheckedArray;
    /// <summary>
    /// Function: MoveCheckedPointsToCheckedArray
    /// </summary>
    public unsafe virtual void MoveCheckedPointsToCheckedArray()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveCheckedPointsToCheckedArray, "BmGame.RBMAIAction_PauseCheckVerts.MoveCheckedPointsToCheckedArray");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessUntraced_Checked;
    /// <summary>
    /// Function: ProcessUntraced_Checked
    /// </summary>
    public unsafe virtual void ProcessUntraced_Checked(out int ChecksLeft)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessUntraced_Checked, "BmGame.RBMAIAction_PauseCheckVerts.ProcessUntraced_Checked");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ChecksLeft);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChecksLeft, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ChecksLeft = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessUntraced_Unchecked;
    /// <summary>
    /// Function: ProcessUntraced_Unchecked
    /// </summary>
    public unsafe virtual void ProcessUntraced_Unchecked(out int ChecksLeft)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessUntraced_Unchecked, "BmGame.RBMAIAction_PauseCheckVerts.ProcessUntraced_Unchecked");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ChecksLeft);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChecksLeft, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ChecksLeft = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_StartPause;
    /// <summary>
    /// Function: StartPause
    /// </summary>
    public unsafe virtual void StartPause()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPause, "BmGame.RBMAIAction_PauseCheckVerts.StartPause");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Cleanup;
    /// <summary>
    /// Function: Cleanup
    /// </summary>
    public unsafe override void Cleanup()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Cleanup, "BmGame.RBMAIAction_PauseCheckVerts.Cleanup");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmGame.RBMAIAction_PauseCheckVerts.OnActivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetValidFaceAtPoints;
    /// <summary>
    /// Function: SetValidFaceAtPoints
    /// </summary>
    public unsafe virtual void SetValidFaceAtPoints(BmSDK.TArray<System.Numerics.Vector3> NewFaceDirList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetValidFaceAtPoints, "BmGame.RBMAIAction_PauseCheckVerts.SetValidFaceAtPoints");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFaceDirList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNextDirOfTravel;
    /// <summary>
    /// Function: SetNextDirOfTravel
    /// </summary>
    public unsafe virtual void SetNextDirOfTravel(System.Numerics.Vector3 NewFaceTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextDirOfTravel, "BmGame.RBMAIAction_PauseCheckVerts.SetNextDirOfTravel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFaceTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVertsToCheck;
    /// <summary>
    /// Function: SetVertsToCheck
    /// </summary>
    public unsafe virtual void SetVertsToCheck(BmSDK.TArray<int> NewUnchecked, BmSDK.TArray<int> NewChecked, BmSDK.Engine.Pylon NewVertPylon, float NewCheckingStartTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVertsToCheck, "BmGame.RBMAIAction_PauseCheckVerts.SetVertsToCheck");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUnchecked, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewChecked, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVertPylon, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCheckingStartTime, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: Untraced_Unchecked
    /// </summary>
    public unsafe BmSDK.TArray<int> Untraced_Unchecked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ArrayProperty: Untraced_Checked
    /// </summary>
    public unsafe BmSDK.TArray<int> Untraced_Checked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ArrayProperty: Unchecked
    /// </summary>
    public unsafe BmSDK.TArray<int> Unchecked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ArrayProperty: Checked
    /// </summary>
    public unsafe BmSDK.TArray<int> Checked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ObjectProperty: VertPylon
    /// </summary>
    public unsafe BmSDK.Engine.Pylon VertPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// FloatProperty: CheckingStartTime
    /// </summary>
    public unsafe float CheckingStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: AimUpdateTimer
    /// </summary>
    public unsafe float AimUpdateTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: NextAimUpdate
    /// </summary>
    public unsafe float NextAimUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ArrayProperty: FaceDirList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> FaceDirList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// StructProperty: LastFaceDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastFaceDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 964);

    /// <summary>
    /// StructProperty: ForwardDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ForwardDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 976);
}
