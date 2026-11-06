#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ActivateBombThugRiots<br/>
/// (size = 448)
/// (flags = 134226066)
/// </summary>
public partial class RSeqAct_ActivateBombThugRiots : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ActivateBombThugRiots", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSeqAct_ActivateBombThugRiots.
    /// </summary>
    public static RSeqAct_ActivateBombThugRiots DefaultObject => (RSeqAct_ActivateBombThugRiots)StaticClass().DefaultObject;

    internal RSeqAct_ActivateBombThugRiots() { }

    /// <summary>
    /// Constructs a new RSeqAct_ActivateBombThugRiots
    /// </summary>
    public RSeqAct_ActivateBombThugRiots(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ActivateBombThugRiots Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ActivateBombThugRiots(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ActivateBombThugRiots>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ActivateBombThugRiots>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ActivateBombThugRiots>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ActivateBombThugRiots>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ActivateBombThugRiots>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ActivateBombThugRiots>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ActivateBombThugRiots>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_ActivateBombThugRiots>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmGame.RSeqAct_ActivateBombThugRiots.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Update;
    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Update, "BmGame.RSeqAct_ActivateBombThugRiots.Update");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetUpRiotZones;
    /// <summary>
    /// Function: SetUpRiotZones
    /// </summary>
    public unsafe virtual void SetUpRiotZones()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUpRiotZones, "BmGame.RSeqAct_ActivateBombThugRiots.SetUpRiotZones");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetRiotZones;
    /// <summary>
    /// Function: ResetRiotZones
    /// </summary>
    public unsafe virtual void ResetRiotZones()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetRiotZones, "BmGame.RSeqAct_ActivateBombThugRiots.ResetRiotZones");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveRiotThug;
    /// <summary>
    /// Function: RemoveRiotThug
    /// </summary>
    public unsafe virtual void RemoveRiotThug(BmSDK.BmGame.RPawnVillain OldThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveRiotThug, "BmGame.RSeqAct_ActivateBombThugRiots.RemoveRiotThug");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BombThugRanAway;
    /// <summary>
    /// Function: BombThugRanAway
    /// </summary>
    public unsafe virtual void BombThugRanAway()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BombThugRanAway, "BmGame.RSeqAct_ActivateBombThugRiots.BombThugRanAway");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BombThugKOd;
    /// <summary>
    /// Function: BombThugKOd
    /// </summary>
    public unsafe virtual void BombThugKOd()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BombThugKOd, "BmGame.RSeqAct_ActivateBombThugRiots.BombThugKOd");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BombThugDefused;
    /// <summary>
    /// Function: BombThugDefused
    /// </summary>
    public unsafe virtual void BombThugDefused()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BombThugDefused, "BmGame.RSeqAct_ActivateBombThugRiots.BombThugDefused");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BombThugScanned;
    /// <summary>
    /// Function: BombThugScanned
    /// </summary>
    public unsafe virtual void BombThugScanned(BmSDK.BmGame.RPawnVillain NewBombThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BombThugScanned, "BmGame.RSeqAct_ActivateBombThugRiots.BombThugScanned");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBombThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasBombThugBeenFound;
    /// <summary>
    /// Function: HasBombThugBeenFound
    /// </summary>
    public unsafe virtual bool HasBombThugBeenFound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBombThugBeenFound, "BmGame.RSeqAct_ActivateBombThugRiots.HasBombThugBeenFound");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BombThugScanningStopped;
    /// <summary>
    /// Function: BombThugScanningStopped
    /// </summary>
    public unsafe virtual void BombThugScanningStopped()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BombThugScanningStopped, "BmGame.RSeqAct_ActivateBombThugRiots.BombThugScanningStopped");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BombThugScanningStarted;
    /// <summary>
    /// Function: BombThugScanningStarted
    /// </summary>
    public unsafe virtual void BombThugScanningStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BombThugScanningStarted, "BmGame.RSeqAct_ActivateBombThugRiots.BombThugScanningStarted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HaveIBeenScanned;
    /// <summary>
    /// Function: HaveIBeenScanned
    /// </summary>
    public unsafe virtual bool HaveIBeenScanned(BmSDK.BmGame.RPawnVillain TestThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HaveIBeenScanned, "BmGame.RSeqAct_ActivateBombThugRiots.HaveIBeenScanned");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AmIBombThug;
    /// <summary>
    /// Function: AmIBombThug
    /// </summary>
    public unsafe virtual bool AmIBombThug(BmSDK.BmGame.RPawnVillain TestThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AmIBombThug, "BmGame.RSeqAct_ActivateBombThugRiots.AmIBombThug");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PotentialBombThugScanned;
    /// <summary>
    /// Function: PotentialBombThugScanned
    /// </summary>
    public unsafe virtual bool PotentialBombThugScanned(BmSDK.BmGame.RPawnVillain NewThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PotentialBombThugScanned, "BmGame.RSeqAct_ActivateBombThugRiots.PotentialBombThugScanned");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddThug;
    /// <summary>
    /// Function: AddThug
    /// </summary>
    public unsafe virtual void AddThug(BmSDK.BmGame.RPawnVillain NewThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddThug, "BmGame.RSeqAct_ActivateBombThugRiots.AddThug");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Activated;
    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Activated, "BmGame.RSeqAct_ActivateBombThugRiots.Activated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: RiotZones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.ROverworldPopulationVolume> RiotZones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.ROverworldPopulationVolume>>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bScanningHasStarted
    /// </summary>
    public unsafe bool bScanningHasStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 392); }
    }

    /// <summary>
    /// BoolProperty: bSetBombThugWhenReady
    /// </summary>
    public unsafe bool bSetBombThugWhenReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 392); }
    }

    /// <summary>
    /// IntProperty: BombThugIdx
    /// </summary>
    public unsafe int BombThugIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ArrayProperty: ThugList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ArrayProperty: ScannedList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ScannedList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: BombThug
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain BombThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ByteProperty: RiddlerZone
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.ERiddlerCategory RiddlerZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ERiddlerCategory>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// IntProperty: UniqueRiddlerID
    /// </summary>
    public unsafe int UniqueRiddlerID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
}
