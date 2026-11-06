#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Disarmed<br/>
/// (size = 752)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_Disarmed : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Disarmed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Disarmed.
    /// </summary>
    public static RAEC_Disarmed DefaultObject => (RAEC_Disarmed)StaticClass().DefaultObject;

    internal RAEC_Disarmed() { }

    /// <summary>
    /// Constructs a new RAEC_Disarmed
    /// </summary>
    public RAEC_Disarmed(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Disarmed(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Disarmed>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Disarmed>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Disarmed>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Disarmed>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Disarmed>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Disarmed>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Disarmed>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Disarmed>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnBeginShutdown;
    /// <summary>
    /// Function: OnBeginShutdown
    /// </summary>
    public unsafe override void OnBeginShutdown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginShutdown, "BmGame.RAEC_Disarmed.OnBeginShutdown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PuncherIsActive;
    /// <summary>
    /// Function: PuncherIsActive
    /// </summary>
    public unsafe virtual bool PuncherIsActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PuncherIsActive, "BmGame.RAEC_Disarmed.PuncherIsActive");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAssigningThugs;
    /// <summary>
    /// Function: IsAssigningThugs
    /// </summary>
    public unsafe virtual bool IsAssigningThugs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAssigningThugs, "BmGame.RAEC_Disarmed.IsAssigningThugs");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearThugSearch;
    /// <summary>
    /// Function: ClearThugSearch
    /// </summary>
    public unsafe virtual void ClearThugSearch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearThugSearch, "BmGame.RAEC_Disarmed.ClearThugSearch");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugInterrupted;
    /// <summary>
    /// Function: ThugInterrupted
    /// </summary>
    public unsafe virtual void ThugInterrupted(BmSDK.BmGame.RBMAIController InterruptedCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugInterrupted, "BmGame.RAEC_Disarmed.ThugInterrupted");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterruptedCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearThugFromSearch;
    /// <summary>
    /// Function: ClearThugFromSearch
    /// </summary>
    public unsafe virtual void ClearThugFromSearch(BmSDK.BmGame.RBMAIController AICon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearThugFromSearch, "BmGame.RAEC_Disarmed.ClearThugFromSearch");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AICon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Reroute;
    /// <summary>
    /// Function: Reroute
    /// </summary>
    public unsafe virtual void Reroute(BmSDK.BmGame.RBMPawnAI SearchPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reroute, "BmGame.RAEC_Disarmed.Reroute");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InsertThugIntoSearch;
    /// <summary>
    /// Function: InsertThugIntoSearch
    /// </summary>
    public unsafe virtual void InsertThugIntoSearch(BmSDK.BmGame.RBMPawnAI SearchPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InsertThugIntoSearch, "BmGame.RAEC_Disarmed.InsertThugIntoSearch");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitPaths;
    /// <summary>
    /// Function: InitPaths
    /// </summary>
    public unsafe virtual void InitPaths()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitPaths, "BmGame.RAEC_Disarmed.InitPaths");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartThugWaitingToFindGun;
    /// <summary>
    /// Function: StartThugWaitingToFindGun
    /// </summary>
    public unsafe virtual void StartThugWaitingToFindGun(BmSDK.BmGame.RBMAIController NewSearcher)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartThugWaitingToFindGun, "BmGame.RAEC_Disarmed.StartThugWaitingToFindGun");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSearcher, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartThugLookingForGun;
    /// <summary>
    /// Function: StartThugLookingForGun
    /// </summary>
    public unsafe virtual void StartThugLookingForGun(BmSDK.BmGame.RBMAIController NewSearcher)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartThugLookingForGun, "BmGame.RAEC_Disarmed.StartThugLookingForGun");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSearcher, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDisarmSub;
    /// <summary>
    /// Function: GetDisarmSub
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAEC_Sub_Disarmed GetDisarmSub(BmSDK.BmGame.RBMAIController AICon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisarmSub, "BmGame.RAEC_Disarmed.GetDisarmSub");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AICon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAEC_Sub_Disarmed>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OnAssign;
    /// <summary>
    /// Function: OnAssign
    /// </summary>
    public unsafe override void OnAssign(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAssign, "BmGame.RAEC_Disarmed.OnAssign");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RAEC_Disarmed.PreStreamOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: PotentialGunSource
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_Disarmed.FGunSource> PotentialGunSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_Disarmed.FGunSource>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: ThugSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper_DisarmedSearch> ThugSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper_DisarmedSearch>>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// Struct: FGunSource
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FGunSource
    {
        /// <summary>
        /// ObjectProperty: GunPickup
        /// </summary>
        public unsafe BmSDK.BmGame.RBMCombatThrownObject_Predator GunPickup
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject_Predator>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: GunLocker
        /// </summary>
        public unsafe BmSDK.BmGame.RPredatorGunLockerBase GunLocker
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPredatorGunLockerBase>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
