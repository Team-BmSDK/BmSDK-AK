#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCombatMove_VillainMultiCleaverThrow<br/>
/// (size = 880)
/// (flags = 10485778)
/// </summary>
public partial class RCombatMove_VillainMultiCleaverThrow : BmSDK.BmGame.RCombatMove_VillainAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCombatMove_VillainMultiCleaverThrow", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_VillainMultiCleaverThrow.
    /// </summary>
    public static RCombatMove_VillainMultiCleaverThrow DefaultObject => (RCombatMove_VillainMultiCleaverThrow)StaticClass().DefaultObject;

    internal RCombatMove_VillainMultiCleaverThrow() { }

    /// <summary>
    /// Constructs a new RCombatMove_VillainMultiCleaverThrow
    /// </summary>
    public RCombatMove_VillainMultiCleaverThrow(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_VillainMultiCleaverThrow(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainMultiCleaverThrow>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainMultiCleaverThrow>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainMultiCleaverThrow>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainMultiCleaverThrow>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainMultiCleaverThrow>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainMultiCleaverThrow>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainMultiCleaverThrow>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainMultiCleaverThrow>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmScript.RCombatMove_VillainMultiCleaverThrow.ExitMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayThrow;
    /// <summary>
    /// Function: PlayThrow
    /// </summary>
    public unsafe virtual void PlayThrow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayThrow, "BmScript.RCombatMove_VillainMultiCleaverThrow.PlayThrow");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowKnife;
    /// <summary>
    /// Function: ShowKnife
    /// </summary>
    public unsafe virtual void ShowKnife()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowKnife, "BmScript.RCombatMove_VillainMultiCleaverThrow.ShowKnife");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSmashWindow;
    /// <summary>
    /// Function: OnSmashWindow
    /// </summary>
    public unsafe virtual void OnSmashWindow(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId NewId, float TimeLeftOver)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSmashWindow, "BmScript.RCombatMove_VillainMultiCleaverThrow.OnSmashWindow");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeftOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCameraLookAtPriority;
    /// <summary>
    /// Function: GetCameraLookAtPriority
    /// </summary>
    public unsafe override float GetCameraLookAtPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraLookAtPriority, "BmScript.RCombatMove_VillainMultiCleaverThrow.GetCameraLookAtPriority");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCounterLimb;
    /// <summary>
    /// Function: GetCounterLimb
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.CounterLimb GetCounterLimb(BmSDK.BmGame.RPawnCombat TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterLimb, "BmScript.RCombatMove_VillainMultiCleaverThrow.GetCounterLimb");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.CounterLimb>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ExtendTargetComboWindow;
    /// <summary>
    /// Function: ExtendTargetComboWindow
    /// </summary>
    public unsafe virtual void ExtendTargetComboWindow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExtendTargetComboWindow, "BmScript.RCombatMove_VillainMultiCleaverThrow.ExtendTargetComboWindow");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowAnotherAttacker;
    /// <summary>
    /// Function: AllowAnotherAttacker
    /// </summary>
    public unsafe override bool AllowAnotherAttacker()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowAnotherAttacker, "BmScript.RCombatMove_VillainMultiCleaverThrow.AllowAnotherAttacker");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAttacking;
    /// <summary>
    /// Function: IsAttacking
    /// </summary>
    public unsafe override bool IsAttacking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAttacking, "BmScript.RCombatMove_VillainMultiCleaverThrow.IsAttacking");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnThrownObject;
    /// <summary>
    /// Function: SpawnThrownObject
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject SpawnThrownObject(BmSDK.FName AttachBone, BmSDK.Class CleaverClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnThrownObject, "BmScript.RCombatMove_VillainMultiCleaverThrow.SpawnThrownObject");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachBone, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CleaverClass, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmScript.RCombatMove_VillainMultiCleaverThrow.Initialise");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBestWindow;
    /// <summary>
    /// Function: GetBestWindow
    /// </summary>
    public unsafe static int GetBestWindow(BmSDK.BmScript.RPawnVillainPyg PygPawn, BmSDK.BmGame.RPawnPlayerCombat TestTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestWindow, "BmScript.RCombatMove_VillainMultiCleaverThrow.GetBestWindow");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PygPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanBeUsed;
    /// <summary>
    /// Function: CanBeUsed
    /// </summary>
    public unsafe static bool CanBeUsed(BmSDK.BmGame.RBMCombatManager CombatManager, BmSDK.BmGame.RPawnCombat User, BmSDK.BmGame.RPawnCombat NewTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeUsed, "BmScript.RCombatMove_VillainMultiCleaverThrow.CanBeUsed");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatManager, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ShowCleaver;
    /// <summary>
    /// Function: ShowCleaver
    /// </summary>
    public unsafe virtual void ShowCleaver()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCleaver, "BmScript.RCombatMove_VillainMultiCleaverThrow.ShowCleaver");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnRightCatchable;
    /// <summary>
    /// Function: SpawnRightCatchable
    /// </summary>
    public unsafe virtual void SpawnRightCatchable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnRightCatchable, "BmScript.RCombatMove_VillainMultiCleaverThrow.SpawnRightCatchable");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowRight;
    /// <summary>
    /// Function: ThrowRight
    /// </summary>
    public unsafe virtual void ThrowRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowRight, "BmScript.RCombatMove_VillainMultiCleaverThrow.ThrowRight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnRight;
    /// <summary>
    /// Function: SpawnRight
    /// </summary>
    public unsafe virtual void SpawnRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnRight, "BmScript.RCombatMove_VillainMultiCleaverThrow.SpawnRight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowLeft;
    /// <summary>
    /// Function: ThrowLeft
    /// </summary>
    public unsafe virtual void ThrowLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowLeft, "BmScript.RCombatMove_VillainMultiCleaverThrow.ThrowLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnLeft;
    /// <summary>
    /// Function: SpawnLeft
    /// </summary>
    public unsafe virtual void SpawnLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnLeft, "BmScript.RCombatMove_VillainMultiCleaverThrow.SpawnLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Pyg
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnVillainPyg Pyg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnVillainPyg>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: ThrownWeaponLeft
    /// </summary>
    public unsafe BmSDK.BmScript.RBMCombatThrownObject_Cleaver ThrownWeaponLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMCombatThrownObject_Cleaver>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: ThrownWeaponRight
    /// </summary>
    public unsafe BmSDK.BmScript.RBMCombatThrownObject_Cleaver ThrownWeaponRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMCombatThrownObject_Cleaver>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: CurrWindow
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrWindow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// FloatProperty: HoldTime
    /// </summary>
    public unsafe float HoldTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: MoveTimeout
    /// </summary>
    public unsafe float MoveTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// StructProperty: AnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId AnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 844);

    /// <summary>
    /// IntProperty: ThrowNum
    /// </summary>
    public unsafe int ThrowNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ArrayProperty: ThrowAnimName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ThrowAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: ThrowTime
    /// </summary>
    public unsafe float ThrowTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bThrowFromWindow
    /// </summary>
    public unsafe bool bThrowFromWindow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 872); }
    }

    /// <summary>
    /// BoolProperty: bSmashWindow
    /// </summary>
    public unsafe bool bSmashWindow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: ThrowDelay
    /// </summary>
    public unsafe float ThrowDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
}
