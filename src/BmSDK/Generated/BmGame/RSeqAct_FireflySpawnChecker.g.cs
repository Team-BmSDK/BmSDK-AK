#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_FireflySpawnChecker<br/>
/// (size = 404)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_FireflySpawnChecker : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_FireflySpawnChecker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSeqAct_FireflySpawnChecker.
    /// </summary>
    public static RSeqAct_FireflySpawnChecker DefaultObject => (RSeqAct_FireflySpawnChecker)StaticClass().DefaultObject;

    internal RSeqAct_FireflySpawnChecker() { }

    /// <summary>
    /// Constructs a new RSeqAct_FireflySpawnChecker
    /// </summary>
    public RSeqAct_FireflySpawnChecker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_FireflySpawnChecker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_FireflySpawnChecker(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireflySpawnChecker>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireflySpawnChecker>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireflySpawnChecker>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireflySpawnChecker>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireflySpawnChecker>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireflySpawnChecker>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireflySpawnChecker>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_FireflySpawnChecker>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmGame.RSeqAct_FireflySpawnChecker.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FireOutputs;
    /// <summary>
    /// Function: FireOutputs
    /// </summary>
    public unsafe virtual void FireOutputs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireOutputs, "BmGame.RSeqAct_FireflySpawnChecker.FireOutputs");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckInputs;
    /// <summary>
    /// Function: CheckInputs
    /// </summary>
    public unsafe virtual void CheckInputs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckInputs, "BmGame.RSeqAct_FireflySpawnChecker.CheckInputs");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Activated;
    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Activated, "BmGame.RSeqAct_FireflySpawnChecker.Activated");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEncounterState;
    /// <summary>
    /// Function: GetEncounterState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSeqAct_FireflySpawnChecker.FireflyEncounterState GetEncounterState(int inEncounterIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEncounterState, "BmGame.RSeqAct_FireflySpawnChecker.GetEncounterState");
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_FireflySpawnChecker.FireflyEncounterState>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetEncounterFlag;
    /// <summary>
    /// Function: SetEncounterFlag
    /// </summary>
    public unsafe virtual bool SetEncounterFlag(int inEncounterIndex, BmSDK.BmGame.RSeqAct_FireflySpawnChecker.FireflyEncounterState encounterState, bool val = default, bool bAutoPan = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEncounterFlag, "BmGame.RSeqAct_FireflySpawnChecker.SetEncounterFlag");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(encounterState, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(val, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAutoPan, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsEncounterFlagSet;
    /// <summary>
    /// Function: IsEncounterFlagSet
    /// </summary>
    public unsafe virtual bool IsEncounterFlagSet(int inEncounterIndex, BmSDK.BmGame.RSeqAct_FireflySpawnChecker.FireflyEncounterState encounterState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEncounterFlagSet, "BmGame.RSeqAct_FireflySpawnChecker.IsEncounterFlagSet");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(encounterState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetEncounterFlagString;
    /// <summary>
    /// Function: GetEncounterFlagString
    /// </summary>
    public unsafe static BmSDK.FString GetEncounterFlagString(int inEncounterIndex, BmSDK.BmGame.RSeqAct_FireflySpawnChecker.FireflyEncounterState encounterState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEncounterFlagString, "BmGame.RSeqAct_FireflySpawnChecker.GetEncounterFlagString");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(encounterState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
    }

    /// <summary>
    /// Enum: FireflyEncounterState
    /// </summary>
    public enum FireflyEncounterState : byte
    {
        eFFES_locked = 0,
        eFFES_available = 1,
        eFFES_completed = 2,
        eFFES_MAX = 3,
    }

    /// <summary>
    /// InlineArray{StrProperty}: flagSuffixes
    /// </summary>
    public InlineArray<BmSDK.FString> flagSuffixes => new(3, Ptr + 352, 16, this);

    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: encounterIndex
    /// </summary>
    public unsafe int encounterIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
