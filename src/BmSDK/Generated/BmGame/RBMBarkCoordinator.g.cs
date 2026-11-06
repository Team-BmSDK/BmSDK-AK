#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBarkCoordinator<br/>
/// (size = 728)
/// (flags = 144703634)
/// </summary>
public partial class RBMBarkCoordinator : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBarkCoordinator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMBarkCoordinator.
    /// </summary>
    public static RBMBarkCoordinator DefaultObject => (RBMBarkCoordinator)StaticClass().DefaultObject;

    internal RBMBarkCoordinator() { }

    /// <summary>
    /// Constructs a new RBMBarkCoordinator
    /// </summary>
    public RBMBarkCoordinator(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBarkCoordinator(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetLinesMatchingFlags;
    /// <summary>
    /// Function: GetLinesMatchingFlags
    /// </summary>
    public unsafe static BmSDK.TArray<BmSDK.BmGame.RBarkConvo> GetLinesMatchingFlags(BmSDK.TArray<BmSDK.BmGame.RBarkConvo> TestLines, BmSDK.BmGame.RBarkValDef.FlagTypeEnum TestType, BmSDK.FName TestValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLinesMatchingFlags, "BmGame.RBMBarkCoordinator.GetLinesMatchingFlags");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLines, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestValue, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RBarkConvo>>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetLinesContainingFlags;
    /// <summary>
    /// Function: GetLinesContainingFlags
    /// </summary>
    public unsafe static BmSDK.TArray<BmSDK.BmGame.RBarkConvo> GetLinesContainingFlags(BmSDK.TArray<BmSDK.BmGame.RBarkConvo> TestLines, BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLinesContainingFlags, "BmGame.RBMBarkCoordinator.GetLinesContainingFlags");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLines, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RBarkConvo>>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CheckCoverage;
    /// <summary>
    /// Function: CheckCoverage
    /// </summary>
    public unsafe static bool CheckCoverage(BmSDK.TArray<BmSDK.BmGame.RBarkSet> TestSet, BmSDK.BmGame.RBarkFlagBase BaseQuery, out BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase> FailCases, out BmSDK.TArray<BmSDK.BmGame.RBarkValDef.FlagTypeEnum> MustDefineList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckCoverage, "BmGame.RBMBarkCoordinator.CheckCoverage");
        byte* paramsPtr = stackalloc byte[208];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseQuery, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FailCases = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase>>(paramsPtr + 24);
        MustDefineList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RBarkValDef.FlagTypeEnum>>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_DecreaseDialogueFrequency;
    /// <summary>
    /// Function: DecreaseDialogueFrequency
    /// </summary>
    public unsafe virtual void DecreaseDialogueFrequency()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DecreaseDialogueFrequency, "BmGame.RBMBarkCoordinator.DecreaseDialogueFrequency");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMinRandomBarkTime;
    /// <summary>
    /// Function: SetMinRandomBarkTime
    /// </summary>
    public unsafe virtual void SetMinRandomBarkTime(float NewMin)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMinRandomBarkTime, "BmGame.RBMBarkCoordinator.SetMinRandomBarkTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InstigateRandomBark;
    /// <summary>
    /// Function: InstigateRandomBark
    /// </summary>
    public unsafe virtual void InstigateRandomBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstigateRandomBark, "BmGame.RBMBarkCoordinator.InstigateRandomBark");
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FunctionalityTest;
    /// <summary>
    /// Function: FunctionalityTest
    /// </summary>
    public unsafe static void FunctionalityTest()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FunctionalityTest, "BmGame.RBMBarkCoordinator.FunctionalityTest");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpStateToLog;
    /// <summary>
    /// Function: DumpStateToLog
    /// </summary>
    public unsafe virtual void DumpStateToLog()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpStateToLog, "BmGame.RBMBarkCoordinator.DumpStateToLog");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnDied;
    /// <summary>
    /// Function: PawnDied
    /// </summary>
    public unsafe virtual void PawnDied(BmSDK.BmGame.RPawnVillain DeadPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnDied, "BmGame.RBMBarkCoordinator.PawnDied");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FreeLock;
    /// <summary>
    /// Function: FreeLock
    /// </summary>
    public unsafe virtual void FreeLock(BmSDK.GameObject ExLockee)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreeLock, "BmGame.RBMBarkCoordinator.FreeLock");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExLockee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLock;
    /// <summary>
    /// Function: SetLock
    /// </summary>
    public unsafe virtual void SetLock(BmSDK.GameObject NewLockee)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLock, "BmGame.RBMBarkCoordinator.SetLock");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLockee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DialogueLockedByObjectOfClass;
    /// <summary>
    /// Function: DialogueLockedByObjectOfClass
    /// </summary>
    public unsafe virtual bool DialogueLockedByObjectOfClass(BmSDK.Class TestClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DialogueLockedByObjectOfClass, "BmGame.RBMBarkCoordinator.DialogueLockedByObjectOfClass");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestClass, paramsPtr + 0);
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

    private static BmSDK.Function __fn_DialogueLockedBySpecificObject;
    /// <summary>
    /// Function: DialogueLockedBySpecificObject
    /// </summary>
    public unsafe virtual bool DialogueLockedBySpecificObject(BmSDK.GameObject Obj)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DialogueLockedBySpecificObject, "BmGame.RBMBarkCoordinator.DialogueLockedBySpecificObject");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DialogueLockedBySpecificEvent;
    /// <summary>
    /// Function: DialogueLockedBySpecificEvent
    /// </summary>
    public unsafe virtual bool DialogueLockedBySpecificEvent(BmSDK.BmGame.RAlertEventCoordinatorBase Event)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DialogueLockedBySpecificEvent, "BmGame.RBMBarkCoordinator.DialogueLockedBySpecificEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddRegionFlagFromMapString;
    /// <summary>
    /// Function: AddRegionFlagFromMapString
    /// </summary>
    public unsafe static void AddRegionFlagFromMapString(BmSDK.FString MapStr, out BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRegionFlagFromMapString, "BmGame.RBMBarkCoordinator.AddRegionFlagFromMapString");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapStr, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ContextFlags);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContextFlags = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_AddLocationFlags;
    /// <summary>
    /// Function: AddLocationFlags
    /// </summary>
    public unsafe virtual void AddLocationFlags(BmSDK.Engine.Actor Subject, out BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLocationFlags, "BmGame.RBMBarkCoordinator.AddLocationFlags");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subject, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ContextFlags);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContextFlags = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GetLocationFlag;
    /// <summary>
    /// Function: GetLocationFlag
    /// </summary>
    public unsafe virtual BmSDK.FName GetLocationFlag(BmSDK.Engine.Actor Subject)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocationFlag, "BmGame.RBMBarkCoordinator.GetLocationFlag");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanPlayBark;
    /// <summary>
    /// Function: CanPlayBark
    /// </summary>
    public unsafe virtual bool CanPlayBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayBark, "BmGame.RBMBarkCoordinator.CanPlayBark");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopCurrentConversationIfPawnInvolved;
    /// <summary>
    /// Function: StopCurrentConversationIfPawnInvolved
    /// </summary>
    public unsafe virtual void StopCurrentConversationIfPawnInvolved(BmSDK.BmGame.RPawnVillain Pawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCurrentConversationIfPawnInvolved, "BmGame.RBMBarkCoordinator.StopCurrentConversationIfPawnInvolved");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopCurrentConversation;
    /// <summary>
    /// Function: StopCurrentConversation
    /// </summary>
    public unsafe virtual void StopCurrentConversation(bool bHardStop = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCurrentConversation, "BmGame.RBMBarkCoordinator.StopCurrentConversation");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHardStop, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPawnDestroyed;
    /// <summary>
    /// Function: NotifyPawnDestroyed
    /// </summary>
    public unsafe virtual void NotifyPawnDestroyed(BmSDK.BmGame.RPawnVillain Pawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPawnDestroyed, "BmGame.RBMBarkCoordinator.NotifyPawnDestroyed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartBarkConvo;
    /// <summary>
    /// Function: StartBarkConvo
    /// </summary>
    public unsafe virtual void StartBarkConvo(BmSDK.BmGame.RBarkConvo NewBarkConvo, BmSDK.BmGame.RBarkGroupContext BGC, bool bOrphan = default, System.IntPtr NewBarkFinished = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBarkConvo, "BmGame.RBMBarkCoordinator.StartBarkConvo");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBarkConvo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BGC, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOrphan, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBarkFinished, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBarkConvoForContext;
    /// <summary>
    /// Function: PlayBarkConvoForContext
    /// </summary>
    public unsafe virtual bool PlayBarkConvoForContext(BmSDK.TArray<BmSDK.Engine.Actor> OrderedSpeakerList, BmSDK.BmGame.RAlertEventCoordinatorBase NewOwningEvent, BmSDK.BmGame.RBarkFlagBase ContextFlags, BmSDK.BmGame.RBarkGroupContext GroupContext, System.IntPtr NewBarkFinished, bool bOrphan, out BmSDK.BmGame.RBarkFlagBase UsedLineContext, out int bFoundSomethingThatMatchedFlags)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBarkConvoForContext, "BmGame.RBMBarkCoordinator.PlayBarkConvoForContext");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrderedSpeakerList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwningEvent, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupContext, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBarkFinished, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOrphan, paramsPtr + 56);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out UsedLineContext);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UsedLineContext, paramsPtr + 60);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bFoundSomethingThatMatchedFlags);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFoundSomethingThatMatchedFlags, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        UsedLineContext = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 60);
        bFoundSomethingThatMatchedFlags = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 68);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_GetBarkFromFlagsAndSpeakers;
    /// <summary>
    /// Function: GetBarkFromFlagsAndSpeakers
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBarkConvo GetBarkFromFlagsAndSpeakers(BmSDK.BmGame.RBarkFlagBase ContextFlags, BmSDK.TArray<BmSDK.Engine.Actor> OrderedSpeakerList, out float Score, out int bFoundSomethingThatMatchedFlags)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBarkFromFlagsAndSpeakers, "BmGame.RBMBarkCoordinator.GetBarkFromFlagsAndSpeakers");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrderedSpeakerList, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Score);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bFoundSomethingThatMatchedFlags);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFoundSomethingThatMatchedFlags, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Score = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        bFoundSomethingThatMatchedFlags = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkConvo>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_PawnPlayBark;
    /// <summary>
    /// Function: PawnPlayBark
    /// </summary>
    public unsafe virtual bool PawnPlayBark(BmSDK.BmGame.RPawnVillain Speaker, BmSDK.BmGame.RBarkFlagBase ContextFlags, BmSDK.BmGame.RBarkGroupContext GroupContext = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnPlayBark, "BmGame.RBMBarkCoordinator.PawnPlayBark");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupContext, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_PawnIsCurrentSpeaker;
    /// <summary>
    /// Function: PawnIsCurrentSpeaker
    /// </summary>
    public unsafe virtual bool PawnIsCurrentSpeaker(BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnIsCurrentSpeaker, "BmGame.RBMBarkCoordinator.PawnIsCurrentSpeaker");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_HasBarksToPlay;
    /// <summary>
    /// Function: HasBarksToPlay
    /// </summary>
    public unsafe virtual bool HasBarksToPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBarksToPlay, "BmGame.RBMBarkCoordinator.HasBarksToPlay");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetLastSpeechTime;
    /// <summary>
    /// Function: ResetLastSpeechTime
    /// </summary>
    public unsafe virtual void ResetLastSpeechTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetLastSpeechTime, "BmGame.RBMBarkCoordinator.ResetLastSpeechTime");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DialogueLocked;
    /// <summary>
    /// Function: DialogueLocked
    /// </summary>
    public unsafe virtual bool DialogueLocked()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DialogueLocked, "BmGame.RBMBarkCoordinator.DialogueLocked");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasRunningBarks;
    /// <summary>
    /// Function: HasRunningBarks
    /// </summary>
    public unsafe virtual bool HasRunningBarks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasRunningBarks, "BmGame.RBMBarkCoordinator.HasRunningBarks");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAllBarksFromAnySpeakersInList;
    /// <summary>
    /// Function: GetAllBarksFromAnySpeakersInList
    /// </summary>
    public unsafe static void GetAllBarksFromAnySpeakersInList(BmSDK.TArray<BmSDK.Engine.Actor> SpeakerList, out BmSDK.TArray<BmSDK.BmGame.RBarkSet> OutList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllBarksFromAnySpeakersInList, "BmGame.RBMBarkCoordinator.GetAllBarksFromAnySpeakersInList");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakerList, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RBarkSet>>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_GetBarkFromBarksetList;
    /// <summary>
    /// Function: GetBarkFromBarksetList
    /// </summary>
    public unsafe static BmSDK.BmGame.RBarkConvo GetBarkFromBarksetList(BmSDK.TArray<BmSDK.BmGame.RBarkSet> BarkSetList, BmSDK.BmGame.RBarkFlagBase ContextFlags, BmSDK.TArray<BmSDK.Engine.Actor> OrderedSpeakers, out float Score, BmSDK.GameObject fallbackConvoParent, out int bFoundSomethingThatMatchedFlags)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBarkFromBarksetList, "BmGame.RBMBarkCoordinator.GetBarkFromBarksetList");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkSetList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrderedSpeakers, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Score);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fallbackConvoParent, paramsPtr + 44);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bFoundSomethingThatMatchedFlags);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFoundSomethingThatMatchedFlags, paramsPtr + 52);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Score = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
        bFoundSomethingThatMatchedFlags = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 52);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkConvo>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_GetBarkConvo;
    /// <summary>
    /// Function: GetBarkConvo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBarkConvo GetBarkConvo(BmSDK.BmGame.RPawnVillain Barker, BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBarkConvo, "BmGame.RBMBarkCoordinator.GetBarkConvo");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Barker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkConvo>(paramsPtr + 16);
    }

    /// <summary>
    /// Struct: FCoverageTestBucket
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FCoverageTestBucket
    {
        /// <summary>
        /// ObjectProperty: Query
        /// </summary>
        public unsafe BmSDK.BmGame.RBarkFlagBase Query
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: LineList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvo> LineList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvo>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: CurrentConvo
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvo CurrentConvo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvo>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: Tannoy
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerTannoy Tannoy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerTannoy>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// FloatProperty: TimeWithoutBark
    /// </summary>
    public unsafe float TimeWithoutBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: bBarksEnabled
    /// </summary>
    public unsafe bool bBarksEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// BoolProperty: bRandomBarksEnabled
    /// </summary>
    public unsafe bool bRandomBarksEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// BoolProperty: bReactiveBarksOnly
    /// </summary>
    public unsafe bool bReactiveBarksOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// BoolProperty: bPreventThugAmbientChatter
    /// </summary>
    public unsafe bool bPreventThugAmbientChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// BoolProperty: bPredIdleConfigSpeaking
    /// </summary>
    public unsafe bool bPredIdleConfigSpeaking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: MinRandomBarkTime
    /// </summary>
    public unsafe float MinRandomBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: CurrRandomBarkTime
    /// </summary>
    public unsafe float CurrRandomBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: TimeWithoutTannoyBark
    /// </summary>
    public unsafe float TimeWithoutTannoyBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: MinTannoyTime
    /// </summary>
    public unsafe float MinTannoyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: LockList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> LockList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: TimeWithoutLock
    /// </summary>
    public unsafe float TimeWithoutLock
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }
}
