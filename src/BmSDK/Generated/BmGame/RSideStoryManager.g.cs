#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSideStoryManager<br/>
/// (size = 312)
/// (flags = 134217874)
/// </summary>
public partial class RSideStoryManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSideStoryManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSideStoryManager.
    /// </summary>
    public static RSideStoryManager DefaultObject => (RSideStoryManager)StaticClass().DefaultObject;

    internal RSideStoryManager() { }

    /// <summary>
    /// Constructs a new RSideStoryManager
    /// </summary>
    public RSideStoryManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSideStoryManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSideStoryManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSideStoryManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSideStoryManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSideStoryManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSideStoryManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSideStoryManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSideStoryManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSideStoryManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSideStoryManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetLocalisedRiddleFromRefName;
    /// <summary>
    /// Function: GetLocalisedRiddleFromRefName
    /// </summary>
    public unsafe virtual BmSDK.FString GetLocalisedRiddleFromRefName(BmSDK.FString RefName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalisedRiddleFromRefName, "BmGame.RSideStoryManager.GetLocalisedRiddleFromRefName");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CreateActorGroup;
    /// <summary>
    /// Function: CreateActorGroup
    /// </summary>
    public unsafe virtual int CreateActorGroup(BmSDK.FString SideStoryIconName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateActorGroup, "BmGame.RSideStoryManager.CreateActorGroup");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIconName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetActorGroupIndex;
    /// <summary>
    /// Function: GetActorGroupIndex
    /// </summary>
    public unsafe virtual int GetActorGroupIndex(BmSDK.FString SideStoryIconName, bool CreateIfDoesntExist = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorGroupIndex, "BmGame.RSideStoryManager.GetActorGroupIndex");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIconName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreateIfDoesntExist, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetActorIndex;
    /// <summary>
    /// Function: GetActorIndex
    /// </summary>
    public unsafe virtual int GetActorIndex(int ActorGroupIndex, BmSDK.Engine.Actor TheActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorIndex, "BmGame.RSideStoryManager.GetActorIndex");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorGroupIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RemoveActorFromGroup;
    /// <summary>
    /// Function: RemoveActorFromGroup
    /// </summary>
    public unsafe virtual void RemoveActorFromGroup(int ActorGroupIndex, BmSDK.Engine.Actor TheActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveActorFromGroup, "BmGame.RSideStoryManager.RemoveActorFromGroup");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorGroupIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeregisterVisualDiscoveryActor;
    /// <summary>
    /// Function: DeregisterVisualDiscoveryActor
    /// </summary>
    public unsafe virtual void DeregisterVisualDiscoveryActor(BmSDK.Engine.Actor TheActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeregisterVisualDiscoveryActor, "BmGame.RSideStoryManager.DeregisterVisualDiscoveryActor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterVisualDiscoveryActor;
    /// <summary>
    /// Function: RegisterVisualDiscoveryActor
    /// </summary>
    public unsafe virtual void RegisterVisualDiscoveryActor(BmSDK.Engine.Actor TheActor, BmSDK.FString SideStoryIconName, int SideStoryDiscoveryHeight, bool bIsMainActor = default, bool CanBeDiscoveredDuringCloudburst = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterVisualDiscoveryActor, "BmGame.RSideStoryManager.RegisterVisualDiscoveryActor");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIconName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryDiscoveryHeight, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsMainActor, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanBeDiscoveredDuringCloudburst, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCustomTrailWaypointDistance;
    /// <summary>
    /// Function: GetCustomTrailWaypointDistance
    /// </summary>
    public unsafe virtual float GetCustomTrailWaypointDistance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomTrailWaypointDistance, "BmGame.RSideStoryManager.GetCustomTrailWaypointDistance");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMidKnightfall;
    /// <summary>
    /// Function: GetMidKnightfall
    /// </summary>
    public unsafe virtual int GetMidKnightfall()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMidKnightfall, "BmGame.RSideStoryManager.GetMidKnightfall");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetKnightfallState;
    /// <summary>
    /// Function: GetKnightfallState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSideStoryManager.KnightfallState GetKnightfallState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKnightfallState, "BmGame.RSideStoryManager.GetKnightfallState");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSideStoryManager.KnightfallState>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetSideStoryDiscoveryState;
    /// <summary>
    /// Function: SetSideStoryDiscoveryState
    /// </summary>
    public unsafe virtual bool SetSideStoryDiscoveryState(int SSIndex, BmSDK.FString IconName, byte DiscoveryState, bool bAddToAutoPan = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSideStoryDiscoveryState, "BmGame.RSideStoryManager.SetSideStoryDiscoveryState");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SSIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DiscoveryState, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddToAutoPan, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_CanSideStoryBeReaddedOnceRemoved;
    /// <summary>
    /// Function: CanSideStoryBeReaddedOnceRemoved
    /// </summary>
    public unsafe virtual bool CanSideStoryBeReaddedOnceRemoved(BmSDK.FString StoryName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSideStoryBeReaddedOnceRemoved, "BmGame.RSideStoryManager.CanSideStoryBeReaddedOnceRemoved");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StoryName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetDiscoveryState;
    /// <summary>
    /// Function: GetDiscoveryState
    /// </summary>
    public unsafe virtual byte GetDiscoveryState(BmSDK.FString IconName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDiscoveryState, "BmGame.RSideStoryManager.GetDiscoveryState");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetRGI;
    /// <summary>
    /// Function: GetRGI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo GetRGI()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRGI, "BmGame.RSideStoryManager.GetRGI");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveIconFromMap;
    /// <summary>
    /// Function: RemoveIconFromMap
    /// </summary>
    public unsafe virtual void RemoveIconFromMap(int SSIndex, BmSDK.FString IconName, bool MakeUnavailableInsteadOfActuallyRemoved = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveIconFromMap, "BmGame.RSideStoryManager.RemoveIconFromMap");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SSIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MakeUnavailableInsteadOfActuallyRemoved, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddIconToMap;
    /// <summary>
    /// Function: AddIconToMap
    /// </summary>
    public unsafe virtual void AddIconToMap(int SSIndex, BmSDK.FString IconName, bool bAddToAutoPan, bool ShowDiscoveryOnHud, BmSDK.Engine.Actor HudDiscoveryActor = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddIconToMap, "BmGame.RSideStoryManager.AddIconToMap");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SSIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddToAutoPan, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowDiscoveryOnHud, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudDiscoveryActor, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeIconDiscoverable;
    /// <summary>
    /// Function: MakeIconDiscoverable
    /// </summary>
    public unsafe virtual void MakeIconDiscoverable(int SSIndex, BmSDK.FString IconName, bool bAddToAutoPan)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeIconDiscoverable, "BmGame.RSideStoryManager.MakeIconDiscoverable");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SSIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddToAutoPan, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugDiscoverAllIcons;
    /// <summary>
    /// Function: DebugDiscoverAllIcons
    /// </summary>
    public unsafe virtual void DebugDiscoverAllIcons()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugDiscoverAllIcons, "BmGame.RSideStoryManager.DebugDiscoverAllIcons");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMainActorForGroup;
    /// <summary>
    /// Function: GetMainActorForGroup
    /// </summary>
    public unsafe virtual int GetMainActorForGroup(int GroupIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMainActorForGroup, "BmGame.RSideStoryManager.GetMainActorForGroup");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GroupActorSpotted;
    /// <summary>
    /// Function: GroupActorSpotted
    /// </summary>
    public unsafe virtual void GroupActorSpotted(int GroupIndex, BmSDK.Engine.Actor TheActor, bool ShowDiscoveryOnHud = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GroupActorSpotted, "BmGame.RSideStoryManager.GroupActorSpotted");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowDiscoveryOnHud, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFocusDetailForSideStory;
    /// <summary>
    /// Function: GetFocusDetailForSideStory
    /// </summary>
    public unsafe virtual BmSDK.FString GetFocusDetailForSideStory(int ss_index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFocusDetailForSideStory, "BmGame.RSideStoryManager.GetFocusDetailForSideStory");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ss_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ChooseBestSideStoryForIntel;
    /// <summary>
    /// Function: ChooseBestSideStoryForIntel
    /// </summary>
    public unsafe virtual BmSDK.FString ChooseBestSideStoryForIntel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseBestSideStoryForIntel, "BmGame.RSideStoryManager.ChooseBestSideStoryForIntel");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumberOfDifferentSideStoryMissionsOnMap;
    /// <summary>
    /// Function: GetNumberOfDifferentSideStoryMissionsOnMap
    /// </summary>
    public unsafe virtual int GetNumberOfDifferentSideStoryMissionsOnMap()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumberOfDifferentSideStoryMissionsOnMap, "BmGame.RSideStoryManager.GetNumberOfDifferentSideStoryMissionsOnMap");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckWhetherIntelValid;
    /// <summary>
    /// Function: CheckWhetherIntelValid
    /// </summary>
    public unsafe virtual bool CheckWhetherIntelValid(BmSDK.FString SideStoryIntelState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckWhetherIntelValid, "BmGame.RSideStoryManager.CheckWhetherIntelValid");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIntelState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_InvalidIntelIfNoLongerValid;
    /// <summary>
    /// Function: InvalidIntelIfNoLongerValid
    /// </summary>
    public unsafe virtual void InvalidIntelIfNoLongerValid()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InvalidIntelIfNoLongerValid, "BmGame.RSideStoryManager.InvalidIntelIfNoLongerValid");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearIntel;
    /// <summary>
    /// Function: ClearIntel
    /// </summary>
    public unsafe virtual void ClearIntel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearIntel, "BmGame.RSideStoryManager.ClearIntel");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveIntelPoint;
    /// <summary>
    /// Function: GiveIntelPoint
    /// </summary>
    public unsafe virtual void GiveIntelPoint(int UnlessThisManyIconsAlreadyOnMap)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveIntelPoint, "BmGame.RSideStoryManager.GiveIntelPoint");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlessThisManyIconsAlreadyOnMap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayLowUrgencyOpenWheelMessageCheck;
    /// <summary>
    /// Function: DisplayLowUrgencyOpenWheelMessageCheck
    /// </summary>
    public unsafe virtual void DisplayLowUrgencyOpenWheelMessageCheck()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayLowUrgencyOpenWheelMessageCheck, "BmGame.RSideStoryManager.DisplayLowUrgencyOpenWheelMessageCheck");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDesignerLowUrgency;
    /// <summary>
    /// Function: SetDesignerLowUrgency
    /// </summary>
    public unsafe virtual void SetDesignerLowUrgency(bool IsLowUrgency, int GiveIntelUnlessThisManyDifferentIconsAlreadyOnMap = default, bool GivePenguinIntel = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDesignerLowUrgency, "BmGame.RSideStoryManager.SetDesignerLowUrgency");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsLowUrgency, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GiveIntelUnlessThisManyDifferentIconsAlreadyOnMap, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GivePenguinIntel, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MaxAndFinishedCountPerIsland;
    /// <summary>
    /// Function: MaxAndFinishedCountPerIsland
    /// </summary>
    public unsafe virtual BmSDK.TArray<int> MaxAndFinishedCountPerIsland(BmSDK.FString sMission, int District)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MaxAndFinishedCountPerIsland, "BmGame.RSideStoryManager.MaxAndFinishedCountPerIsland");
        byte* paramsPtr = stackalloc byte[264];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sMission, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(District, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_AnyRadialMapIconsActive;
    /// <summary>
    /// Function: AnyRadialMapIconsActive
    /// </summary>
    public unsafe virtual bool AnyRadialMapIconsActive(int SideStoryIndex, BmSDK.BmGame.RPersistentData pData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyRadialMapIconsActive, "BmGame.RSideStoryManager.AnyRadialMapIconsActive");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pData, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanShowIntelForSideStory;
    /// <summary>
    /// Function: CanShowIntelForSideStory
    /// </summary>
    public unsafe virtual bool CanShowIntelForSideStory(BmSDK.FString SideStoryName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanShowIntelForSideStory, "BmGame.RSideStoryManager.CanShowIntelForSideStory");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetIntelMapIconThenClearIntel;
    /// <summary>
    /// Function: GetIntelMapIconThenClearIntel
    /// </summary>
    public unsafe virtual BmSDK.FString GetIntelMapIconThenClearIntel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIntelMapIconThenClearIntel, "BmGame.RSideStoryManager.GetIntelMapIconThenClearIntel");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsRadialMapIconStory;
    /// <summary>
    /// Function: IsRadialMapIconStory
    /// </summary>
    public unsafe virtual bool IsRadialMapIconStory(BmSDK.FString StoryName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRadialMapIconStory, "BmGame.RSideStoryManager.IsRadialMapIconStory");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StoryName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SideStoryRequiresTracker;
    /// <summary>
    /// Function: SideStoryRequiresTracker
    /// </summary>
    public unsafe virtual bool SideStoryRequiresTracker(BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum TheSideStory)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SideStoryRequiresTracker, "BmGame.RSideStoryManager.SideStoryRequiresTracker");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheSideStory, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetIntelSideStory;
    /// <summary>
    /// Function: GetIntelSideStory
    /// </summary>
    public unsafe virtual BmSDK.FString GetIntelSideStory(bool ChooseBestIfCurrentlyWild = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIntelSideStory, "BmGame.RSideStoryManager.GetIntelSideStory");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChooseBestIfCurrentlyWild, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetApcIntelAvailable;
    /// <summary>
    /// Function: SetApcIntelAvailable
    /// </summary>
    public unsafe virtual void SetApcIntelAvailable(bool is_available)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetApcIntelAvailable, "BmGame.RSideStoryManager.SetApcIntelAvailable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_available, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardPenguinIntel;
    /// <summary>
    /// Function: AwardPenguinIntel
    /// </summary>
    public unsafe virtual void AwardPenguinIntel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardPenguinIntel, "BmGame.RSideStoryManager.AwardPenguinIntel");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPenguinIntel;
    /// <summary>
    /// Function: ClearPenguinIntel
    /// </summary>
    public unsafe virtual void ClearPenguinIntel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPenguinIntel, "BmGame.RSideStoryManager.ClearPenguinIntel");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPenguinIntelAvailable;
    /// <summary>
    /// Function: IsPenguinIntelAvailable
    /// </summary>
    public unsafe virtual bool IsPenguinIntelAvailable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPenguinIntelAvailable, "BmGame.RSideStoryManager.IsPenguinIntelAvailable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentActiveSideStory;
    /// <summary>
    /// Function: GetCurrentActiveSideStory
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum GetCurrentActiveSideStory()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentActiveSideStory, "BmGame.RSideStoryManager.GetCurrentActiveSideStory");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActiveSideStoryFromString;
    /// <summary>
    /// Function: GetActiveSideStoryFromString
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum GetActiveSideStoryFromString(BmSDK.FString SideStoryName, out BmSDK.FString ShortenedName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActiveSideStoryFromString, "BmGame.RSideStoryManager.GetActiveSideStoryFromString");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ShortenedName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetStringFromActiveSideStoryEnum;
    /// <summary>
    /// Function: GetStringFromActiveSideStoryEnum
    /// </summary>
    public unsafe virtual BmSDK.FString GetStringFromActiveSideStoryEnum(int the_enum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringFromActiveSideStoryEnum, "BmGame.RSideStoryManager.GetStringFromActiveSideStoryEnum");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_enum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetSideStoryNameFromEnum;
    /// <summary>
    /// Function: GetSideStoryNameFromEnum
    /// </summary>
    public unsafe virtual BmSDK.FString GetSideStoryNameFromEnum(int the_enum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSideStoryNameFromEnum, "BmGame.RSideStoryManager.GetSideStoryNameFromEnum");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_enum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetDebugSideStoryIntel;
    /// <summary>
    /// Function: SetDebugSideStoryIntel
    /// </summary>
    public unsafe virtual void SetDebugSideStoryIntel(int the_enum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDebugSideStoryIntel, "BmGame.RSideStoryManager.SetDebugSideStoryIntel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_enum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFocusDetailBySideStoryIconName;
    /// <summary>
    /// Function: GetFocusDetailBySideStoryIconName
    /// </summary>
    public unsafe virtual BmSDK.FString GetFocusDetailBySideStoryIconName(BmSDK.FString SideStoryIconName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFocusDetailBySideStoryIconName, "BmGame.RSideStoryManager.GetFocusDetailBySideStoryIconName");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIconName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ShowDebugSpheres;
    /// <summary>
    /// Function: ShowDebugSpheres
    /// </summary>
    public unsafe virtual void ShowDebugSpheres()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowDebugSpheres, "BmGame.RSideStoryManager.ShowDebugSpheres");
        byte* paramsPtr = stackalloc byte[33];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickDiscoveryTargets;
    /// <summary>
    /// Function: TickDiscoveryTargets
    /// </summary>
    public unsafe virtual void TickDiscoveryTargets(float DeltaT)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickDiscoveryTargets, "BmGame.RSideStoryManager.TickDiscoveryTargets");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaT, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDiscoveryTarget;
    /// <summary>
    /// Function: AddDiscoveryTarget
    /// </summary>
    public unsafe virtual void AddDiscoveryTarget(BmSDK.Engine.Actor TheActor, BmSDK.FString AnimName, float ShowDuration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDiscoveryTarget, "BmGame.RSideStoryManager.AddDiscoveryTarget");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowDuration, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendDummyHudTargetToFlash;
    /// <summary>
    /// Function: SendDummyHudTargetToFlash
    /// </summary>
    public unsafe virtual void SendDummyHudTargetToFlash()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendDummyHudTargetToFlash, "BmGame.RSideStoryManager.SendDummyHudTargetToFlash");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectiveSystemSetsActiveSideStory;
    /// <summary>
    /// Function: ObjectiveSystemSetsActiveSideStory
    /// </summary>
    public unsafe virtual void ObjectiveSystemSetsActiveSideStory(BmSDK.FString ActiveSideStoryName, BmSDK.FString SideStoryMapMarker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectiveSystemSetsActiveSideStory, "BmGame.RSideStoryManager.ObjectiveSystemSetsActiveSideStory");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActiveSideStoryName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryMapMarker, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetObjectiveTypeByIconString;
    /// <summary>
    /// Function: GetObjectiveTypeByIconString
    /// </summary>
    public unsafe virtual BmSDK.FString GetObjectiveTypeByIconString(BmSDK.FString IconString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjectiveTypeByIconString, "BmGame.RSideStoryManager.GetObjectiveTypeByIconString");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetMissionWheelHighlights;
    /// <summary>
    /// Function: SetMissionWheelHighlights
    /// </summary>
    public unsafe virtual void SetMissionWheelHighlights(BmSDK.FString ActiveSideStoryName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMissionWheelHighlights, "BmGame.RSideStoryManager.SetMissionWheelHighlights");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActiveSideStoryName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetActiveSideStory;
    /// <summary>
    /// Function: SetActiveSideStory
    /// </summary>
    public unsafe virtual void SetActiveSideStory(BmSDK.FString ActiveSideStoryName, BmSDK.FString OptionalSideStoryMapMarker = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActiveSideStory, "BmGame.RSideStoryManager.SetActiveSideStory");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActiveSideStoryName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptionalSideStoryMapMarker, paramsPtr + 16);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_SetActiveSideStoryByEnumWithoutMapMarker;
    /// <summary>
    /// Function: SetActiveSideStoryByEnumWithoutMapMarker
    /// </summary>
    public unsafe virtual void SetActiveSideStoryByEnumWithoutMapMarker(BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum the_side_story)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActiveSideStoryByEnumWithoutMapMarker, "BmGame.RSideStoryManager.SetActiveSideStoryByEnumWithoutMapMarker");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_side_story, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MarkActiveSideStoryComplete;
    /// <summary>
    /// Function: MarkActiveSideStoryComplete
    /// </summary>
    public unsafe virtual void MarkActiveSideStoryComplete(BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum the_side_story)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkActiveSideStoryComplete, "BmGame.RSideStoryManager.MarkActiveSideStoryComplete");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_side_story, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectiveSystemClearsActiveSideStory;
    /// <summary>
    /// Function: ObjectiveSystemClearsActiveSideStory
    /// </summary>
    public unsafe virtual void ObjectiveSystemClearsActiveSideStory(bool MainPathObjective)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectiveSystemClearsActiveSideStory, "BmGame.RSideStoryManager.ObjectiveSystemClearsActiveSideStory");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MainPathObjective, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayRiddlerHint;
    /// <summary>
    /// Function: PlayRiddlerHint
    /// </summary>
    public unsafe virtual BmSDK.FString PlayRiddlerHint(BmSDK.FString RefName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRiddlerHint, "BmGame.RSideStoryManager.PlayRiddlerHint");
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsLockupWaypoint;
    /// <summary>
    /// Function: IsLockupWaypoint
    /// </summary>
    public unsafe virtual bool IsLockupWaypoint(BmSDK.FString waypoint_name)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLockupWaypoint, "BmGame.RSideStoryManager.IsLockupWaypoint");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(waypoint_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_InitialiseManager;
    /// <summary>
    /// Function: InitialiseManager
    /// </summary>
    public unsafe virtual void InitialiseManager()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseManager, "BmGame.RSideStoryManager.InitialiseManager");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SideStoryEnumToString;
    /// <summary>
    /// Function: SideStoryEnumToString
    /// </summary>
    public unsafe virtual BmSDK.FString SideStoryEnumToString(BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum SideStory)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SideStoryEnumToString, "BmGame.RSideStoryManager.SideStoryEnumToString");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStory, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindLineOfSightActor;
    /// <summary>
    /// Function: FindLineOfSightActor
    /// </summary>
    public unsafe virtual bool FindLineOfSightActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindLineOfSightActor, "BmGame.RSideStoryManager.FindLineOfSightActor");
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

    private static BmSDK.Function __fn_IsSideStoryActorVisible;
    /// <summary>
    /// Function: IsSideStoryActorVisible
    /// </summary>
    public unsafe virtual float IsSideStoryActorVisible(int group_index, int actor_index, bool is_zoomed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSideStoryActorVisible, "BmGame.RSideStoryManager.IsSideStoryActorVisible");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(group_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actor_index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_zoomed, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe virtual void Tick(BmSDK.BmGame.RPlayerController RPC, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RSideStoryManager.Tick");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
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

    private static BmSDK.Function __fn_IsAnyMissionDialogueLoading;
    /// <summary>
    /// Function: IsAnyMissionDialogueLoading
    /// </summary>
    public unsafe virtual bool IsAnyMissionDialogueLoading()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyMissionDialogueLoading, "BmGame.RSideStoryManager.IsAnyMissionDialogueLoading");
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

    private static BmSDK.Function __fn_IsWheelDialoguePlayingOfType;
    /// <summary>
    /// Function: IsWheelDialoguePlayingOfType
    /// </summary>
    public unsafe virtual int IsWheelDialoguePlayingOfType(byte Type)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWheelDialoguePlayingOfType, "BmGame.RSideStoryManager.IsWheelDialoguePlayingOfType");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StopOrCancelMissionDialogue;
    /// <summary>
    /// Function: StopOrCancelMissionDialogue
    /// </summary>
    public unsafe virtual void StopOrCancelMissionDialogue(int DialogueIndex, bool bUseFade)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopOrCancelMissionDialogue, "BmGame.RSideStoryManager.StopOrCancelMissionDialogue");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseFade, paramsPtr + 4);
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

    private static BmSDK.Function __fn_CancelAllMissionDialogue;
    /// <summary>
    /// Function: CancelAllMissionDialogue
    /// </summary>
    public unsafe virtual void CancelAllMissionDialogue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelAllMissionDialogue, "BmGame.RSideStoryManager.CancelAllMissionDialogue");
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

    private static BmSDK.Function __fn_PlayMissionWheelDialogue;
    /// <summary>
    /// Function: PlayMissionWheelDialogue
    /// </summary>
    public unsafe virtual void PlayMissionWheelDialogue(int DialogueIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayMissionWheelDialogue, "BmGame.RSideStoryManager.PlayMissionWheelDialogue");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueIndex, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetMissionDialogueState_;
    /// <summary>
    /// Function: SetMissionDialogueState_
    /// </summary>
    public unsafe virtual void SetMissionDialogueState_(int DialogueIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMissionDialogueState_, "BmGame.RSideStoryManager.SetMissionDialogueState_");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueIndex, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetOfMissionDialogue;
    /// <summary>
    /// Function: SetOfMissionDialogue
    /// </summary>
    public unsafe virtual void SetOfMissionDialogue(BmSDK.FString PackageName, byte Type, bool bUseFadeOnOldDialogue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOfMissionDialogue, "BmGame.RSideStoryManager.SetOfMissionDialogue");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseFadeOnOldDialogue, paramsPtr + 20);
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

    private static BmSDK.Function __fn_TickMissionDialogue;
    /// <summary>
    /// Function: TickMissionDialogue
    /// </summary>
    public unsafe virtual void TickMissionDialogue(BmSDK.BmGame.RPlayerController RPC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickMissionDialogue, "BmGame.RSideStoryManager.TickMissionDialogue");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
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
    /// Enum: ActiveSideStoryEnum
    /// </summary>
    public enum ActiveSideStoryEnum : byte
    {
        ASSE_None = 0,
        ASSE_Unknown = 1,
        ASSE_Firefly = 2,
        ASSE_Pyg = 3,
        ASSE_ManBat = 4,
        ASSE_Penguin = 5,
        ASSE_Blackfire = 6,
        ASSE_Hush = 7,
        ASSE_Azrael = 8,
        ASSE_Drones = 9,
        ASSE_Bank = 10,
        ASSE_WatchTowers = 11,
        ASSE_Riddler = 12,
        ASSE_Firecrews = 13,
        ASSE_APC = 14,
        ASSE_Militia = 15,
        ASSE_Challenge = 16,
        ASSE_DLC_Freeze = 17,
        ASSE_DLC_Ras = 18,
        ASSE_DLC_MadHatter = 19,
        ASSE_DLC_Croc = 20,
        ASSE_MAX = 21,
    }

    /// <summary>
    /// Enum: IntelEnabledSideStories
    /// </summary>
    public enum IntelEnabledSideStories : byte
    {
        IESS_Firecrew = 0,
        IESS_Pyg = 1,
        IESS_Azrael = 2,
        IESS_MAX = 3,
    }

    /// <summary>
    /// Enum: SideStoryDiscoveryState
    /// </summary>
    public enum SideStoryDiscoveryState : byte
    {
        SSDS_Unavailable = 0,
        SSDS_Discoverable = 1,
        SSDS_On_Map = 2,
        SSDS_Removed = 3,
        SSDS_MAX = 4,
    }

    /// <summary>
    /// Struct: FMissionDialogue
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FMissionDialogue
    {
        /// <summary>
        /// IntProperty: SpeechInstanceId
        /// </summary>
        public unsafe int SpeechInstanceId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: PackageName
        /// </summary>
        public unsafe BmSDK.FString PackageName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: FullRef
        /// </summary>
        public unsafe BmSDK.FString FullRef
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ObjectProperty: AKLine
        /// </summary>
        public unsafe BmSDK.Engine.AkDialogueConversation AKLine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ByteProperty: DlgState
        /// </summary>
        public unsafe byte DlgState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ByteProperty: dlgType
        /// </summary>
        public unsafe byte dlgType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 45); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 45); }; }
        }

        /// <summary>
        /// StructProperty: StartLoadTime
        /// </summary>
        public unsafe double StartLoadTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: StartPlayTime
        /// </summary>
        public unsafe double StartPlayTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: Loaded
        /// </summary>
        public unsafe bool Loaded
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: Cancelled
        /// </summary>
        public unsafe bool Cancelled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: CancelWithFade
        /// </summary>
        public unsafe bool CancelWithFade
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: Finished
        /// </summary>
        public unsafe bool Finished
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Enum: KnightfallState
    /// </summary>
    public enum KnightfallState : byte
    {
        KFS_None = 0,
        KFS_Begin = 1,
        KFS_HalfCompleteFinished = 2,
        KFS_FullCompleteFinished = 3,
        KFS_HalfComplete = 4,
        KFS_FullComplete = 5,
        KFS_HalfWayPointSet = 6,
        KFS_FullWayPointSet = 7,
        KFS_MAX = 8,
    }

    /// <summary>
    /// Enum: MissionDialogueType
    /// </summary>
    public enum MissionDialogueType : byte
    {
        MDT_InsideWheel = 0,
        MDT_OutsideWheel = 1,
        MDT_MAX = 2,
    }

    /// <summary>
    /// Enum: MissionDialogueState
    /// </summary>
    public enum MissionDialogueState : byte
    {
        MDS_Initial = 0,
        MDS_Loading = 1,
        MDS_Playing = 2,
        MDS_MAX = 3,
    }

    /// <summary>
    /// Struct: FDiscoveryHudTarget
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FDiscoveryHudTarget
    {
        /// <summary>
        /// StrProperty: UniqueName
        /// </summary>
        public unsafe BmSDK.FString UniqueName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: TimeRemaining
        /// </summary>
        public unsafe float TimeRemaining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FRiddlerHintEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FRiddlerHintEntry
    {
        /// <summary>
        /// StrProperty: RefName
        /// </summary>
        public unsafe BmSDK.FString RefName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: AkLineRef
        /// </summary>
        public unsafe BmSDK.Engine.AkHash AkLineRef
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkHash>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: Who
        /// </summary>
        public unsafe BmSDK.FString Who
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FSideStoryVisibleEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSideStoryVisibleEntry
    {
        /// <summary>
        /// FloatProperty: ActorDotProd
        /// </summary>
        public unsafe float ActorDotProd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: GroupIndex
        /// </summary>
        public unsafe int GroupIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: ActorIndex
        /// </summary>
        public unsafe int ActorIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FSideStoryActorGroup
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FSideStoryActorGroup
    {
        /// <summary>
        /// ArrayProperty: TheActors
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FSideStoryVisualDiscoveryActor> TheActors
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FSideStoryVisualDiscoveryActor>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: SideStoryIconName
        /// </summary>
        public unsafe BmSDK.FString SideStoryIconName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: DiscoveryState
        /// </summary>
        public unsafe byte DiscoveryState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: TimeSliceActorIndex
        /// </summary>
        public unsafe int TimeSliceActorIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: CanDiscoverThroughWalls
        /// </summary>
        public unsafe bool CanDiscoverThroughWalls
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FSideStoryVisualDiscoveryActor
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSideStoryVisualDiscoveryActor
    {
        /// <summary>
        /// ObjectProperty: TheActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor TheActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: DiscoveryDistanceThresholdSquared
        /// </summary>
        public unsafe int DiscoveryDistanceThresholdSquared
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bIsMainActor
        /// </summary>
        public unsafe bool bIsMainActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: CanBeDiscoveredDuringCloudburst
        /// </summary>
        public unsafe bool CanBeDiscoveredDuringCloudburst
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// StructProperty: VfTable_AkDialogueListener
    /// </summary>
    public unsafe System.IntPtr VfTable_AkDialogueListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerHints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FRiddlerHintEntry> RiddlerHints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FRiddlerHintEntry>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: CurrentFocusActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentFocusActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: PreviousFrameFocusActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor PreviousFrameFocusActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: TimeActorInFocus
    /// </summary>
    public unsafe float TimeActorInFocus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: ActorGroups
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FSideStoryActorGroup> ActorGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FSideStoryActorGroup>>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ArrayProperty: VisibleEntryList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FSideStoryVisibleEntry> VisibleEntryList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FSideStoryVisibleEntry>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// StructProperty: CameraLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 160);

    /// <summary>
    /// StructProperty: CameraDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 172);

    /// <summary>
    /// IntProperty: BestGroupIndex
    /// </summary>
    public unsafe int BestGroupIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// IntProperty: BestActorIndex
    /// </summary>
    public unsafe int BestActorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// IntProperty: CachedGroupIndex
    /// </summary>
    public unsafe int CachedGroupIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StrProperty: CachedFocusDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFocusDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// IntProperty: TimeSliceGroupIndex
    /// </summary>
    public unsafe int TimeSliceGroupIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// FloatProperty: ChapterNineIntelRecurrencePeriod
    /// </summary>
    public unsafe float ChapterNineIntelRecurrencePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// ArrayProperty: DiscoveryTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FDiscoveryHudTarget> DiscoveryTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FDiscoveryHudTarget>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: MissionDialogueArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FMissionDialogue> MissionDialogueArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FMissionDialogue>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: MissionDialogueArrayQueued
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FMissionDialogue> MissionDialogueArrayQueued
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSideStoryManager.FMissionDialogue>>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// IntProperty: MissionLoadingDlgIndex
    /// </summary>
    public unsafe int MissionLoadingDlgIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ByteProperty: CurrentlyActiveSideStory
    /// </summary>
    public unsafe BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum CurrentlyActiveSideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StrProperty: CurrentlyActiveSideStoryName
    /// </summary>
    public unsafe BmSDK.FString CurrentlyActiveSideStoryName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StrProperty: CurrentlyActiveSideStoryMapMarker
    /// </summary>
    public unsafe BmSDK.FString CurrentlyActiveSideStoryMapMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: IsInitialised
    /// </summary>
    public unsafe bool IsInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 308); }
    }

    /// <summary>
    /// BoolProperty: ForceOpenWheelPromptAfterReload
    /// </summary>
    public unsafe bool ForceOpenWheelPromptAfterReload
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 308); }
    }
}
