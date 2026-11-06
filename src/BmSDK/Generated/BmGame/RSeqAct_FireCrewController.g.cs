#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_FireCrewController<br/>
/// (size = 492)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_FireCrewController : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_FireCrewController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSeqAct_FireCrewController.
    /// </summary>
    public static RSeqAct_FireCrewController DefaultObject => (RSeqAct_FireCrewController)StaticClass().DefaultObject;

    internal RSeqAct_FireCrewController() { }

    /// <summary>
    /// Constructs a new RSeqAct_FireCrewController
    /// </summary>
    public RSeqAct_FireCrewController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_FireCrewController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_FireCrewController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireCrewController>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireCrewController>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireCrewController>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireCrewController>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireCrewController>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireCrewController>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireCrewController>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireCrewController>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmGame.RSeqAct_FireCrewController.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LogDump;
    /// <summary>
    /// Function: LogDump
    /// </summary>
    public unsafe virtual void LogDump()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogDump, "BmGame.RSeqAct_FireCrewController.LogDump");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateAvailability;
    /// <summary>
    /// Function: UpdateAvailability
    /// </summary>
    public unsafe virtual void UpdateAvailability()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAvailability, "BmGame.RSeqAct_FireCrewController.UpdateAvailability");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentTier;
    /// <summary>
    /// Function: GetCurrentTier
    /// </summary>
    public unsafe virtual int GetCurrentTier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentTier, "BmGame.RSeqAct_FireCrewController.GetCurrentTier");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsTierComplete;
    /// <summary>
    /// Function: IsTierComplete
    /// </summary>
    public unsafe virtual bool IsTierComplete(int Tier)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTierComplete, "BmGame.RSeqAct_FireCrewController.IsTierComplete");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetEncounterTier;
    /// <summary>
    /// Function: GetEncounterTier
    /// </summary>
    public unsafe virtual int GetEncounterTier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEncounterTier, "BmGame.RSeqAct_FireCrewController.GetEncounterTier");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetEncounterRescued;
    /// <summary>
    /// Function: SetEncounterRescued
    /// </summary>
    public unsafe virtual void SetEncounterRescued()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEncounterRescued, "BmGame.RSeqAct_FireCrewController.SetEncounterRescued");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMostWanted;
    /// <summary>
    /// Function: UpdateMostWanted
    /// </summary>
    public unsafe virtual void UpdateMostWanted(int encounter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMostWanted, "BmGame.RSeqAct_FireCrewController.UpdateMostWanted");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(encounter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireOutputs;
    /// <summary>
    /// Function: FireOutputs
    /// </summary>
    public unsafe virtual void FireOutputs(bool bOnlyNewEncounters = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireOutputs, "BmGame.RSeqAct_FireCrewController.FireOutputs");
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyNewEncounters, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CountNumRescued;
    /// <summary>
    /// Function: CountNumRescued
    /// </summary>
    public unsafe virtual int CountNumRescued()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountNumRescued, "BmGame.RSeqAct_FireCrewController.CountNumRescued");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckInputs;
    /// <summary>
    /// Function: CheckInputs
    /// </summary>
    public unsafe virtual void CheckInputs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckInputs, "BmGame.RSeqAct_FireCrewController.CheckInputs");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEncounterIndexOnLinkedSpawners;
    /// <summary>
    /// Function: SetEncounterIndexOnLinkedSpawners
    /// </summary>
    public unsafe virtual void SetEncounterIndexOnLinkedSpawners()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEncounterIndexOnLinkedSpawners, "BmGame.RSeqAct_FireCrewController.SetEncounterIndexOnLinkedSpawners");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Activated;
    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Activated, "BmGame.RSeqAct_FireCrewController.Activated");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEncounterState;
    /// <summary>
    /// Function: GetEncounterState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSeqAct_FireCrewController.FireCrewEncounterState GetEncounterState(int inEncounterIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEncounterState, "BmGame.RSeqAct_FireCrewController.GetEncounterState");
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSeqAct_FireCrewController.FireCrewEncounterState>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetEncounterFlag;
    /// <summary>
    /// Function: SetEncounterFlag
    /// </summary>
    public unsafe virtual bool SetEncounterFlag(int inEncounterIndex, BmSDK.BmGame.RSeqAct_FireCrewController.FireCrewEncounterState encounterState, bool val = default, bool bAutoPan = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEncounterFlag, "BmGame.RSeqAct_FireCrewController.SetEncounterFlag");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(encounterState, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(val, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAutoPan, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsEncounterFlagSet;
    /// <summary>
    /// Function: IsEncounterFlagSet
    /// </summary>
    public unsafe virtual bool IsEncounterFlagSet(int inEncounterIndex, BmSDK.BmGame.RSeqAct_FireCrewController.FireCrewEncounterState encounterState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEncounterFlagSet, "BmGame.RSeqAct_FireCrewController.IsEncounterFlagSet");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(encounterState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetEncounterFlagString;
    /// <summary>
    /// Function: GetEncounterFlagString
    /// </summary>
    public unsafe static BmSDK.FString GetEncounterFlagString(int inEncounterIndex, BmSDK.BmGame.RSeqAct_FireCrewController.FireCrewEncounterState encounterState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEncounterFlagString, "BmGame.RSeqAct_FireCrewController.GetEncounterFlagString");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(encounterState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    /// <summary>
    /// Enum: FireCrewEncounterState
    /// </summary>
    public enum FireCrewEncounterState : byte
    {
        eFCES_unavailable = 0,
        eFCES_available_unseen = 1,
        eFCES_available_seen = 2,
        eFCES_rescued = 3,
        eFCES_rescuedAndGone = 4,
        eFCES_MAX = 5,
    }

    /// <summary>
    /// InlineArray{StructProperty}: allTiers
    /// </summary>
    public InlineArray<BmSDK.BmGame.RSeqAct_FireCrewController.FsingleTier> allTiers => new(2, Ptr + 352, 16, this);

    /// <summary>
    /// StructProperty: allTiers
    /// </summary>
    public unsafe ref BmSDK.BmGame.RSeqAct_FireCrewController.FsingleTier allTiers_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RSeqAct_FireCrewController.FsingleTier>(Ptr + 352);
    /// <summary>
    /// StructProperty: allTiers
    /// </summary>
    public unsafe ref BmSDK.BmGame.RSeqAct_FireCrewController.FsingleTier allTiers_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RSeqAct_FireCrewController.FsingleTier>(Ptr + 368);

    /// <summary>
    /// InlineArray{StrProperty}: flagSuffixes
    /// </summary>
    public InlineArray<BmSDK.FString> flagSuffixes => new(5, Ptr + 384, 16, this);

    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// StrProperty: tierCompletedFlag
    /// </summary>
    public unsafe BmSDK.FString tierCompletedFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// BoolProperty: bSetupTierStruct
    /// </summary>
    public unsafe bool bSetupTierStruct
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// IntProperty: encounterIndex
    /// </summary>
    public unsafe int encounterIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// IntProperty: numRescued
    /// </summary>
    public unsafe int numRescued
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// Struct: FsingleTier
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FsingleTier
    {
        /// <summary>
        /// ArrayProperty: members
        /// </summary>
        public unsafe BmSDK.TArray<int> members
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }
}
