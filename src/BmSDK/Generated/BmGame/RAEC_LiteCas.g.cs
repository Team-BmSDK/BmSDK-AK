#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_LiteCas<br/>
/// (size = 784)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_LiteCas : BmSDK.BmGame.RAEC_CasualtyBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_LiteCas", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_LiteCas.
    /// </summary>
    public static RAEC_LiteCas DefaultObject => (RAEC_LiteCas)StaticClass().DefaultObject;

    internal RAEC_LiteCas() { }

    /// <summary>
    /// Constructs a new RAEC_LiteCas
    /// </summary>
    public RAEC_LiteCas(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_LiteCas(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_LiteCas>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_LiteCas>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_LiteCas>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_LiteCas>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_LiteCas>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_LiteCas>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_LiteCas>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_LiteCas>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PostCutNotify;
    /// <summary>
    /// Function: PostCutNotify
    /// </summary>
    public unsafe override void PostCutNotify(System.Numerics.Vector3 ImpactLoc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostCutNotify, "BmGame.RAEC_LiteCas.PostCutNotify");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyRopeCut;
    /// <summary>
    /// Function: NotifyRopeCut
    /// </summary>
    public unsafe override void NotifyRopeCut(BmSDK.BmGame.RBatarangProjectile Brang)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyRopeCut, "BmGame.RAEC_LiteCas.NotifyRopeCut");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Brang, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryStopKicking;
    /// <summary>
    /// Function: TryStopKicking
    /// </summary>
    public unsafe virtual void TryStopKicking()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryStopKicking, "BmGame.RAEC_LiteCas.TryStopKicking");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CasFound;
    /// <summary>
    /// Function: CasFound
    /// </summary>
    public unsafe override void CasFound(BmSDK.BmGame.RBMAIController Spotter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CasFound, "BmGame.RAEC_LiteCas.CasFound");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SonicBatarangTakedown;
    /// <summary>
    /// Function: SonicBatarangTakedown
    /// </summary>
    public unsafe override void SonicBatarangTakedown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SonicBatarangTakedown, "BmGame.RAEC_LiteCas.SonicBatarangTakedown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainScreamed;
    /// <summary>
    /// Function: VillainScreamed
    /// </summary>
    public unsafe override void VillainScreamed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainScreamed, "BmGame.RAEC_LiteCas.VillainScreamed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnTakenDown;
    /// <summary>
    /// Function: PawnTakenDown
    /// </summary>
    public unsafe override void PawnTakenDown(bool bGlideKicked, bool bDropAttacked, BmSDK.BmGame.RHidePoint inGlideKickOriginHidePoint, System.Numerics.Vector3 GlideKickHidePointPerchPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnTakenDown, "BmGame.RAEC_LiteCas.PawnTakenDown");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGlideKicked, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDropAttacked, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inGlideKickOriginHidePoint, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GlideKickHidePointPerchPos, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAIThoughts;
    /// <summary>
    /// Function: GetAIThoughts
    /// </summary>
    public unsafe override void GetAIThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIThoughts, "BmGame.RAEC_LiteCas.GetAIThoughts");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }
}
