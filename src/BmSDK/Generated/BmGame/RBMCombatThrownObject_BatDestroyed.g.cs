#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMCombatThrownObject_BatDestroyed<br/>
/// (size = 1188)
/// (flags = 10486290)
/// </summary>
public partial class RBMCombatThrownObject_BatDestroyed : BmSDK.BmGame.RBMCombatThrownObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMCombatThrownObject_BatDestroyed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMCombatThrownObject_BatDestroyed.
    /// </summary>
    public static RBMCombatThrownObject_BatDestroyed DefaultObject => (RBMCombatThrownObject_BatDestroyed)StaticClass().DefaultObject;

    internal RBMCombatThrownObject_BatDestroyed() { }

    /// <summary>
    /// Constructs a new RBMCombatThrownObject_BatDestroyed
    /// </summary>
    public RBMCombatThrownObject_BatDestroyed(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatThrownObject_BatDestroyed(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_BatDestroyed>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_BatDestroyed>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_BatDestroyed>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_BatDestroyed>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_BatDestroyed>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_BatDestroyed>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_BatDestroyed>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_BatDestroyed>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Drop;
    /// <summary>
    /// Function: Drop
    /// </summary>
    public unsafe override void Drop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Drop, "BmGame.RBMCombatThrownObject_BatDestroyed.Drop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMaxTimesCanBeUsed;
    /// <summary>
    /// Function: SetMaxTimesCanBeUsed
    /// </summary>
    public unsafe virtual void SetMaxTimesCanBeUsed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaxTimesCanBeUsed, "BmGame.RBMCombatThrownObject_BatDestroyed.SetMaxTimesCanBeUsed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CaughtByPlayer;
    /// <summary>
    /// Function: CaughtByPlayer
    /// </summary>
    public unsafe override void CaughtByPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CaughtByPlayer, "BmGame.RBMCombatThrownObject_BatDestroyed.CaughtByPlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBreakOnNextHit;
    /// <summary>
    /// Function: SetBreakOnNextHit
    /// </summary>
    public unsafe override void SetBreakOnNextHit()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBreakOnNextHit, "BmGame.RBMCombatThrownObject_BatDestroyed.SetBreakOnNextHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UsedByPlayer;
    /// <summary>
    /// Function: UsedByPlayer
    /// </summary>
    public unsafe override void UsedByPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsedByPlayer, "BmGame.RBMCombatThrownObject_BatDestroyed.UsedByPlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NumTimesCanBeUsed;
    /// <summary>
    /// Function: NumTimesCanBeUsed
    /// </summary>
    public unsafe override int NumTimesCanBeUsed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NumTimesCanBeUsed, "BmGame.RBMCombatThrownObject_BatDestroyed.NumTimesCanBeUsed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanStillBeUsedByPlayer;
    /// <summary>
    /// Function: CanStillBeUsedByPlayer
    /// </summary>
    public unsafe override bool CanStillBeUsedByPlayer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanStillBeUsedByPlayer, "BmGame.RBMCombatThrownObject_BatDestroyed.CanStillBeUsedByPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCanStillBeUsedByPlayer;
    /// <summary>
    /// Function: SetCanStillBeUsedByPlayer
    /// </summary>
    public unsafe override void SetCanStillBeUsedByPlayer(bool bStillUsable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCanStillBeUsedByPlayer, "BmGame.RBMCombatThrownObject_BatDestroyed.SetCanStillBeUsedByPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStillUsable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachAllAttachments;
    /// <summary>
    /// Function: DetachAllAttachments
    /// </summary>
    public unsafe override void DetachAllAttachments()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachAllAttachments, "BmGame.RBMCombatThrownObject_BatDestroyed.DetachAllAttachments");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoEvent;
    /// <summary>
    /// Function: DoEvent
    /// </summary>
    public unsafe override void DoEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoEvent, "BmGame.RBMCombatThrownObject_BatDestroyed.DoEvent");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnAttachment;
    /// <summary>
    /// Function: SpawnAttachment
    /// </summary>
    public unsafe virtual void SpawnAttachment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnAttachment, "BmGame.RBMCombatThrownObject_BatDestroyed.SpawnAttachment");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBMCombatThrownObject_BatDestroyed.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: MaxTimesCanBeUsed
    /// </summary>
    public unsafe int MaxTimesCanBeUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }
}
