#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineRecentPlayersList<br/>
/// (size = 172)
/// (flags = 22)
/// </summary>
public partial class OnlineRecentPlayersList : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineRecentPlayersList", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as OnlineRecentPlayersList.
    /// </summary>
    public static OnlineRecentPlayersList DefaultObject => (OnlineRecentPlayersList)StaticClass().DefaultObject;

    internal OnlineRecentPlayersList() { }

    /// <summary>
    /// Constructs a new OnlineRecentPlayersList
    /// </summary>
    public OnlineRecentPlayersList(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineRecentPlayersList Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineRecentPlayersList(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineRecentPlayersList>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineRecentPlayersList>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineRecentPlayersList>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineRecentPlayersList>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineRecentPlayersList>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineRecentPlayersList>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineRecentPlayersList>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineRecentPlayersList>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetCurrentPlayersListCount;
    /// <summary>
    /// Function: GetCurrentPlayersListCount
    /// </summary>
    public unsafe virtual int GetCurrentPlayersListCount()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentPlayersListCount, "Engine.OnlineRecentPlayersList.GetCurrentPlayersListCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCurrentPlayersList;
    /// <summary>
    /// Function: SetCurrentPlayersList
    /// </summary>
    public unsafe virtual void SetCurrentPlayersList(BmSDK.TArray<BmSDK.Engine.OnlineRecentPlayersList.FCurrentPlayerMet> Players)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPlayersList, "Engine.OnlineRecentPlayersList.SetCurrentPlayersList");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Players, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCurrentPlayersList;
    /// <summary>
    /// Function: ShowCurrentPlayersList
    /// </summary>
    public unsafe virtual bool ShowCurrentPlayersList(byte LocalUserNum, BmSDK.FString Title, BmSDK.FString Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCurrentPlayersList, "Engine.OnlineRecentPlayersList.ShowCurrentPlayersList");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ShowLastPartyPlayerList;
    /// <summary>
    /// Function: ShowLastPartyPlayerList
    /// </summary>
    public unsafe virtual bool ShowLastPartyPlayerList(byte LocalUserNum, BmSDK.FString Title, BmSDK.FString Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLastPartyPlayerList, "Engine.OnlineRecentPlayersList.ShowLastPartyPlayerList");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ShowRecentPartiesPlayerList;
    /// <summary>
    /// Function: ShowRecentPartiesPlayerList
    /// </summary>
    public unsafe virtual bool ShowRecentPartiesPlayerList(byte LocalUserNum, BmSDK.FString Title, BmSDK.FString Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowRecentPartiesPlayerList, "Engine.OnlineRecentPlayersList.ShowRecentPartiesPlayerList");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ShowRecentPlayerList;
    /// <summary>
    /// Function: ShowRecentPlayerList
    /// </summary>
    public unsafe virtual bool ShowRecentPlayerList(byte LocalUserNum, BmSDK.FString Title, BmSDK.FString Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowRecentPlayerList, "Engine.OnlineRecentPlayersList.ShowRecentPlayerList");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_SetLastParty;
    /// <summary>
    /// Function: SetLastParty
    /// </summary>
    public unsafe virtual void SetLastParty(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PartyLeader, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> PartyMembers)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastParty, "Engine.OnlineRecentPlayersList.SetLastParty");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartyLeader, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PartyMembers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GetTeamForCurrentPlayer;
    /// <summary>
    /// Function: GetTeamForCurrentPlayer
    /// </summary>
    public unsafe virtual int GetTeamForCurrentPlayer(BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamForCurrentPlayer, "Engine.OnlineRecentPlayersList.GetTeamForCurrentPlayer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetSkillForCurrentPlayer;
    /// <summary>
    /// Function: GetSkillForCurrentPlayer
    /// </summary>
    public unsafe virtual int GetSkillForCurrentPlayer(BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSkillForCurrentPlayer, "Engine.OnlineRecentPlayersList.GetSkillForCurrentPlayer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPlayersFromCurrentPlayers;
    /// <summary>
    /// Function: GetPlayersFromCurrentPlayers
    /// </summary>
    public unsafe virtual void GetPlayersFromCurrentPlayers(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayersFromCurrentPlayers, "Engine.OnlineRecentPlayersList.GetPlayersFromCurrentPlayers");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Players = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayersFromRecentParties;
    /// <summary>
    /// Function: GetPlayersFromRecentParties
    /// </summary>
    public unsafe virtual void GetPlayersFromRecentParties(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayersFromRecentParties, "Engine.OnlineRecentPlayersList.GetPlayersFromRecentParties");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Players = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentParties;
    /// <summary>
    /// Function: ClearRecentParties
    /// </summary>
    public unsafe virtual void ClearRecentParties()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentParties, "Engine.OnlineRecentPlayersList.ClearRecentParties");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPartyToRecentParties;
    /// <summary>
    /// Function: AddPartyToRecentParties
    /// </summary>
    public unsafe virtual void AddPartyToRecentParties(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PartyLeader, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> PartyMembers)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPartyToRecentParties, "Engine.OnlineRecentPlayersList.AddPartyToRecentParties");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartyLeader, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PartyMembers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentPlayers;
    /// <summary>
    /// Function: ClearRecentPlayers
    /// </summary>
    public unsafe virtual void ClearRecentPlayers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentPlayers, "Engine.OnlineRecentPlayersList.ClearRecentPlayers");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPlayerToRecentPlayers;
    /// <summary>
    /// Function: AddPlayerToRecentPlayers
    /// </summary>
    public unsafe virtual void AddPlayerToRecentPlayers(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPlayerToRecentPlayers, "Engine.OnlineRecentPlayersList.AddPlayerToRecentPlayers");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FCurrentPlayerMet
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FCurrentPlayerMet
    {
        /// <summary>
        /// IntProperty: TeamNum
        /// </summary>
        public unsafe int TeamNum
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Skill
        /// </summary>
        public unsafe int Skill
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: NetId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FRecentParty
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FRecentParty
    {
        /// <summary>
        /// StructProperty: PartyLeader
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId PartyLeader
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: PartyMembers
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> PartyMembers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: RecentPlayers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> RecentPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: RecentParties
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineRecentPlayersList.FRecentParty> RecentParties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineRecentPlayersList.FRecentParty>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: LastParty
    /// </summary>
    public unsafe ref BmSDK.Engine.OnlineRecentPlayersList.FRecentParty LastParty
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.OnlineRecentPlayersList.FRecentParty>(Ptr + 116);

    /// <summary>
    /// IntProperty: MaxRecentPlayers
    /// </summary>
    public unsafe int MaxRecentPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// IntProperty: MaxRecentParties
    /// </summary>
    public unsafe int MaxRecentParties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: RecentPlayersAddIndex
    /// </summary>
    public unsafe int RecentPlayersAddIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: RecentPartiesAddIndex
    /// </summary>
    public unsafe int RecentPartiesAddIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ArrayProperty: CurrentPlayers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineRecentPlayersList.FCurrentPlayerMet> CurrentPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineRecentPlayersList.FCurrentPlayerMet>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
