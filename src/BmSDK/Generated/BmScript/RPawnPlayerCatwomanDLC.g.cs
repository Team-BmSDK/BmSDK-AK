#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerCatwomanDLC<br/>
/// (size = 10416)
/// (flags = 10486326)
/// </summary>
public partial class RPawnPlayerCatwomanDLC : BmSDK.BmScript.RPawnPlayerCatwoman, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerCatwomanDLC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerCatwomanDLC.
    /// </summary>
    public static RPawnPlayerCatwomanDLC DefaultObject => (RPawnPlayerCatwomanDLC)StaticClass().DefaultObject;

    internal RPawnPlayerCatwomanDLC() { }

    /// <summary>
    /// Constructs a new RPawnPlayerCatwomanDLC
    /// </summary>
    public RPawnPlayerCatwomanDLC(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerCatwomanDLC(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanDLC>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanDLC>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanDLC>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanDLC>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanDLC>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanDLC>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanDLC>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanDLC>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetJumpToChuteToCrawlSpaceMove;
    /// <summary>
    /// Function: GetJumpToChuteToCrawlSpaceMove
    /// </summary>
    public unsafe override BmSDK.BmGame.RSpecialMoveConfig GetJumpToChuteToCrawlSpaceMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJumpToChuteToCrawlSpaceMove, "BmScript.RPawnPlayerCatwomanDLC.GetJumpToChuteToCrawlSpaceMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCrawlSpaceToChuteMove;
    /// <summary>
    /// Function: GetCrawlSpaceToChuteMove
    /// </summary>
    public unsafe override BmSDK.BmGame.RSpecialMoveConfig GetCrawlSpaceToChuteMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCrawlSpaceToChuteMove, "BmScript.RPawnPlayerCatwomanDLC.GetCrawlSpaceToChuteMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InvestigateModeEyes;
    /// <summary>
    /// Function: InvestigateModeEyes
    /// </summary>
    public unsafe override void InvestigateModeEyes(bool bOnOrOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InvestigateModeEyes, "BmScript.RPawnPlayerCatwomanDLC.InvestigateModeEyes");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnOrOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCornerCoverIdleOverlayAnimset;
    /// <summary>
    /// Function: GetCornerCoverIdleOverlayAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetCornerCoverIdleOverlayAnimset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCornerCoverIdleOverlayAnimset, "BmScript.RPawnPlayerCatwomanDLC.GetCornerCoverIdleOverlayAnimset");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerPounceToCeilingMove;
    /// <summary>
    /// Function: TriggerPounceToCeilingMove
    /// </summary>
    public unsafe override void TriggerPounceToCeilingMove(System.Numerics.Vector3 Position)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPounceToCeilingMove, "BmScript.RPawnPlayerCatwomanDLC.TriggerPounceToCeilingMove");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmScript.RPawnPlayerCatwomanDLC.CanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetupPlayerSpecificCombatAnimsets;
    /// <summary>
    /// Function: SetupPlayerSpecificCombatAnimsets
    /// </summary>
    public unsafe override void SetupPlayerSpecificCombatAnimsets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupPlayerSpecificCombatAnimsets, "BmScript.RPawnPlayerCatwomanDLC.SetupPlayerSpecificCombatAnimsets");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanGlideKickWindows;
    /// <summary>
    /// Function: CanGlideKickWindows
    /// </summary>
    public unsafe override bool CanGlideKickWindows()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanGlideKickWindows, "BmScript.RPawnPlayerCatwomanDLC.CanGlideKickWindows");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OpenGrateFromBelow;
    /// <summary>
    /// Function: OpenGrateFromBelow
    /// </summary>
    public unsafe override void OpenGrateFromBelow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenGrateFromBelow, "BmScript.RPawnPlayerCatwomanDLC.OpenGrateFromBelow");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenGrateFromAbove;
    /// <summary>
    /// Function: OpenGrateFromAbove
    /// </summary>
    public unsafe override void OpenGrateFromAbove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenGrateFromAbove, "BmScript.RPawnPlayerCatwomanDLC.OpenGrateFromAbove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnPossessed;
    /// <summary>
    /// Function: UnPossessed
    /// </summary>
    public unsafe override void UnPossessed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnPossessed, "BmScript.RPawnPlayerCatwomanDLC.UnPossessed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDefaultInventory;
    /// <summary>
    /// Function: AddDefaultInventory
    /// </summary>
    public unsafe override void AddDefaultInventory()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDefaultInventory, "BmScript.RPawnPlayerCatwomanDLC.AddDefaultInventory");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: TripChargedUpThugTransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TripChargedUpThugTransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 10412);
}
