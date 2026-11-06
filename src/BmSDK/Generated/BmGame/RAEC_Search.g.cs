#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Search<br/>
/// (size = 816)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_Search : BmSDK.BmGame.RAEC_SearchBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Search", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Search.
    /// </summary>
    public static RAEC_Search DefaultObject => (RAEC_Search)StaticClass().DefaultObject;

    internal RAEC_Search() { }

    /// <summary>
    /// Constructs a new RAEC_Search
    /// </summary>
    public RAEC_Search(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Search(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ReassignToCornerTerrified;
    /// <summary>
    /// Function: ReassignToCornerTerrified
    /// </summary>
    public unsafe virtual void ReassignToCornerTerrified(BmSDK.BmGame.RAEC_Search_Sub_Terrified CornerLeader, BmSDK.BmGame.RCornerWallMarker StartCorner, BmSDK.BmGame.RCornerWallMarker EndCorner)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToCornerTerrified, "BmGame.RAEC_Search.ReassignToCornerTerrified");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerLeader, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCorner, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndCorner, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignFromTerrorCorner;
    /// <summary>
    /// Function: AssignFromTerrorCorner
    /// </summary>
    public unsafe virtual void AssignFromTerrorCorner(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignFromTerrorCorner, "BmGame.RAEC_Search.AssignFromTerrorCorner");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToSniperPoint;
    /// <summary>
    /// Function: AssignToSniperPoint
    /// </summary>
    public unsafe virtual void AssignToSniperPoint(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToSniperPoint, "BmGame.RAEC_Search.AssignToSniperPoint");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToRunToGuardVol;
    /// <summary>
    /// Function: AssignToRunToGuardVol
    /// </summary>
    public unsafe virtual void AssignToRunToGuardVol(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToRunToGuardVol, "BmGame.RAEC_Search.AssignToRunToGuardVol");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToSmashGenerators;
    /// <summary>
    /// Function: AssignToSmashGenerators
    /// </summary>
    public unsafe virtual void AssignToSmashGenerators(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToSmashGenerators, "BmGame.RAEC_Search.AssignToSmashGenerators");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToGrenadeTunnel;
    /// <summary>
    /// Function: AssignToGrenadeTunnel
    /// </summary>
    public unsafe virtual void AssignToGrenadeTunnel(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToGrenadeTunnel, "BmGame.RAEC_Search.AssignToGrenadeTunnel");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToIncendiaryGrenade;
    /// <summary>
    /// Function: AssignToIncendiaryGrenade
    /// </summary>
    public unsafe virtual void AssignToIncendiaryGrenade(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToIncendiaryGrenade, "BmGame.RAEC_Search.AssignToIncendiaryGrenade");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToSmashGargoyles;
    /// <summary>
    /// Function: AssignToSmashGargoyles
    /// </summary>
    public unsafe virtual void AssignToSmashGargoyles(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToSmashGargoyles, "BmGame.RAEC_Search.AssignToSmashGargoyles");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToPlaceFloorMines;
    /// <summary>
    /// Function: AssignToPlaceFloorMines
    /// </summary>
    public unsafe virtual void AssignToPlaceFloorMines(BmSDK.BmGame.RBMAIController NewMember, BmSDK.BmGame.RThugMineablePointFloor MinePoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToPlaceFloorMines, "BmGame.RAEC_Search.AssignToPlaceFloorMines");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinePoint, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignFromThermalFail;
    /// <summary>
    /// Function: AssignFromThermalFail
    /// </summary>
    public unsafe virtual void AssignFromThermalFail(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignFromThermalFail, "BmGame.RAEC_Search.AssignFromThermalFail");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SearchAssign;
    /// <summary>
    /// Function: SearchAssign
    /// </summary>
    public unsafe override void SearchAssign(BmSDK.BmGame.RBMAIController NewMember, bool bHasHintLoc = default, System.Numerics.Vector3 HintLoc = default, BmSDK.BmGame.RAEC_Search_Group PreviousParent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SearchAssign, "BmGame.RAEC_Search.SearchAssign");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasHintLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HintLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousParent, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAssign;
    /// <summary>
    /// Function: OnAssign
    /// </summary>
    public unsafe override void OnAssign(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAssign, "BmGame.RAEC_Search.OnAssign");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendToHostage;
    /// <summary>
    /// Function: SendToHostage
    /// </summary>
    public unsafe virtual void SendToHostage(BmSDK.BmGame.RBMAIController NewHostageTakerCon, BmSDK.BmGame.RPawnFriendly Hostage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendToHostage, "BmGame.RAEC_Search.SendToHostage");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHostageTakerCon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Hostage, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToGuardPoint;
    /// <summary>
    /// Function: AssignToGuardPoint
    /// </summary>
    public unsafe virtual void AssignToGuardPoint(BmSDK.BmGame.RBMAIController NewGuardCon, BmSDK.BmGame.RGuardPoint GuardPoint)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToGuardPoint, "BmGame.RAEC_Search.AssignToGuardPoint");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGuardCon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GuardPoint, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSnipe;
    /// <summary>
    /// Function: CanSnipe
    /// </summary>
    public unsafe override bool CanSnipe()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSnipe, "BmGame.RAEC_Search.CanSnipe");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetNewFearLevel;
    /// <summary>
    /// Function: SetNewFearLevel
    /// </summary>
    public unsafe override void SetNewFearLevel(BmSDK.BmGame.RBMRoomAIState.VillainFearLevel FearLevel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNewFearLevel, "BmGame.RAEC_Search.SetNewFearLevel");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FearLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishTopLevelAEC;
    /// <summary>
    /// Function: FinishTopLevelAEC
    /// </summary>
    public unsafe override void FinishTopLevelAEC(BmSDK.BmGame.RBMAIController StolenCon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishTopLevelAEC, "BmGame.RAEC_Search.FinishTopLevelAEC");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StolenCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
