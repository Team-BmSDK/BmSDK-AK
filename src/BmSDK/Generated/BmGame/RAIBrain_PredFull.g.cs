#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAIBrain_PredFull<br/>
/// (size = 564)
/// (flags = 18)
/// </summary>
public partial class RAIBrain_PredFull : BmSDK.BmGame.RAIBrain_Pred, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAIBrain_PredFull", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAIBrain_PredFull.
    /// </summary>
    public static RAIBrain_PredFull DefaultObject => (RAIBrain_PredFull)StaticClass().DefaultObject;

    internal RAIBrain_PredFull() { }

    /// <summary>
    /// Constructs a new RAIBrain_PredFull
    /// </summary>
    public RAIBrain_PredFull(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAIBrain_PredFull Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAIBrain_PredFull(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAIBrain_PredFull>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAIBrain_PredFull>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAIBrain_PredFull>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAIBrain_PredFull>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAIBrain_PredFull>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAIBrain_PredFull>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAIBrain_PredFull>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAIBrain_PredFull>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetSentryGunAEC;
    /// <summary>
    /// Function: SetSentryGunAEC
    /// </summary>
    public unsafe virtual void SetSentryGunAEC(BmSDK.BmGame.RAEC_PlaceSentryGun NewSentryGunAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSentryGunAEC, "BmGame.RAIBrain_PredFull.SetSentryGunAEC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSentryGunAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIncendiaryStartleAEC;
    /// <summary>
    /// Function: SetIncendiaryStartleAEC
    /// </summary>
    public unsafe virtual void SetIncendiaryStartleAEC(BmSDK.BmGame.RAEC_IncendiaryStartle NewVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIncendiaryStartleAEC, "BmGame.RAIBrain_PredFull.SetIncendiaryStartleAEC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEnviroStartleAEC;
    /// <summary>
    /// Function: SetEnviroStartleAEC
    /// </summary>
    public unsafe virtual void SetEnviroStartleAEC(BmSDK.BmGame.RAEC_EnvironmentStartle NewVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEnviroStartleAEC, "BmGame.RAIBrain_PredFull.SetEnviroStartleAEC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveMusBoothAEC;
    /// <summary>
    /// Function: RemoveMusBoothAEC
    /// </summary>
    public unsafe virtual void RemoveMusBoothAEC(BmSDK.BmGame.RAEC_MuseumBooth_PerPoint FinishedBooth)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveMusBoothAEC, "BmGame.RAIBrain_PredFull.RemoveMusBoothAEC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedBooth, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddMusBoothAEC;
    /// <summary>
    /// Function: AddMusBoothAEC
    /// </summary>
    public unsafe virtual void AddMusBoothAEC(BmSDK.BmGame.RAEC_MuseumBooth_PerPoint NewBooth)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMusBoothAEC, "BmGame.RAIBrain_PredFull.AddMusBoothAEC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBooth, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasSonicBatarangAEC;
    /// <summary>
    /// Function: HasSonicBatarangAEC
    /// </summary>
    public unsafe virtual bool HasSonicBatarangAEC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasSonicBatarangAEC, "BmGame.RAIBrain_PredFull.HasSonicBatarangAEC");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetSonicBatarangAEC;
    /// <summary>
    /// Function: SetSonicBatarangAEC
    /// </summary>
    public unsafe virtual void SetSonicBatarangAEC(BmSDK.BmGame.RAEC_SonicBatarang NewVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSonicBatarangAEC, "BmGame.RAIBrain_PredFull.SetSonicBatarangAEC");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasLowPriorityEvent;
    /// <summary>
    /// Function: HasLowPriorityEvent
    /// </summary>
    public unsafe override bool HasLowPriorityEvent(out BmSDK.FName NewName, out BmSDK.BmGame.RAlertEventCoordinatorBase NewAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLowPriorityEvent, "BmGame.RAIBrain_PredFull.HasLowPriorityEvent");
        byte* paramsPtr = stackalloc byte[28];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewAEC);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAEC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        NewAEC = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAlertEventCoordinatorBase>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_BagCarryIsSentryGun;
    /// <summary>
    /// Function: BagCarryIsSentryGun
    /// </summary>
    public unsafe override bool BagCarryIsSentryGun(out BmSDK.FName NewName, out BmSDK.BmGame.RAlertEventCoordinatorBase NewAEC, bool bAllowBatarangResponse)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BagCarryIsSentryGun, "BmGame.RAIBrain_PredFull.BagCarryIsSentryGun");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewAEC);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAEC, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowBatarangResponse, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        NewAEC = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAlertEventCoordinatorBase>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_HasLessThanShootButMoreThanChaseEvent;
    /// <summary>
    /// Function: HasLessThanShootButMoreThanChaseEvent
    /// </summary>
    public unsafe override bool HasLessThanShootButMoreThanChaseEvent(out BmSDK.FName NewName, out BmSDK.BmGame.RAlertEventCoordinatorBase NewAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLessThanShootButMoreThanChaseEvent, "BmGame.RAIBrain_PredFull.HasLessThanShootButMoreThanChaseEvent");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewAEC);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAEC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        NewAEC = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAlertEventCoordinatorBase>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HasFullPredEventThatInterruptsBagCarry;
    /// <summary>
    /// Function: HasFullPredEventThatInterruptsBagCarry
    /// </summary>
    public unsafe override bool HasFullPredEventThatInterruptsBagCarry(out BmSDK.FName NewName, out BmSDK.BmGame.RAlertEventCoordinatorBase NewAEC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasFullPredEventThatInterruptsBagCarry, "BmGame.RAIBrain_PredFull.HasFullPredEventThatInterruptsBagCarry");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewAEC);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAEC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        NewAEC = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAlertEventCoordinatorBase>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// ObjectProperty: GlanceForBooth
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_MuseumBooth GlanceForBooth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_MuseumBooth>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ObjectProperty: SonicBatarangAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_SonicBatarang SonicBatarangAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_SonicBatarang>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ObjectProperty: EnviroStartleAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_EnvironmentStartle EnviroStartleAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_EnvironmentStartle>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ObjectProperty: IncendiaryStartleAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_IncendiaryStartle IncendiaryStartleAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_IncendiaryStartle>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ObjectProperty: SentryGunAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_PlaceSentryGun SentryGunAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_PlaceSentryGun>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: PotentialBooth
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_MuseumBooth_PerPoint> PotentialBooth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_MuseumBooth_PerPoint>>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bIsTooBusyForVoiceSynth
    /// </summary>
    public unsafe bool bIsTooBusyForVoiceSynth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 560); }
    }
}
