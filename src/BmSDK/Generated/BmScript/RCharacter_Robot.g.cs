#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_Robot<br/>
/// (size = 392)
/// (flags = 18)
/// </summary>
public partial class RCharacter_Robot : BmSDK.BmGame.RCharacter_Thug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_Robot", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCharacter_Robot.
    /// </summary>
    public static RCharacter_Robot DefaultObject => (RCharacter_Robot)StaticClass().DefaultObject;

    internal RCharacter_Robot() { }

    /// <summary>
    /// Constructs a new RCharacter_Robot
    /// </summary>
    public RCharacter_Robot(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_Robot Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_Robot(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCharacter_Robot>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacter_Robot>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCharacter_Robot>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacter_Robot>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacter_Robot>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacter_Robot>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCharacter_Robot>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacter_Robot>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetStrikeImpactCue_BodyKick;
    /// <summary>
    /// Function: GetStrikeImpactCue_BodyKick
    /// </summary>
    public unsafe static BmSDK.Engine.AkEvent GetStrikeImpactCue_BodyKick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeImpactCue_BodyKick, "BmScript.RCharacter_Robot.GetStrikeImpactCue_BodyKick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeImpactCue_BodyPunchQuick;
    /// <summary>
    /// Function: GetStrikeImpactCue_BodyPunchQuick
    /// </summary>
    public unsafe static BmSDK.Engine.AkEvent GetStrikeImpactCue_BodyPunchQuick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeImpactCue_BodyPunchQuick, "BmScript.RCharacter_Robot.GetStrikeImpactCue_BodyPunchQuick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeImpactCue_BodyPunch;
    /// <summary>
    /// Function: GetStrikeImpactCue_BodyPunch
    /// </summary>
    public unsafe static BmSDK.Engine.AkEvent GetStrikeImpactCue_BodyPunch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeImpactCue_BodyPunch, "BmScript.RCharacter_Robot.GetStrikeImpactCue_BodyPunch");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeImpactCue_HeadKick;
    /// <summary>
    /// Function: GetStrikeImpactCue_HeadKick
    /// </summary>
    public unsafe static BmSDK.Engine.AkEvent GetStrikeImpactCue_HeadKick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeImpactCue_HeadKick, "BmScript.RCharacter_Robot.GetStrikeImpactCue_HeadKick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeImpactCue_HeadPunchQuick;
    /// <summary>
    /// Function: GetStrikeImpactCue_HeadPunchQuick
    /// </summary>
    public unsafe static BmSDK.Engine.AkEvent GetStrikeImpactCue_HeadPunchQuick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeImpactCue_HeadPunchQuick, "BmScript.RCharacter_Robot.GetStrikeImpactCue_HeadPunchQuick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeImpactCue_HeadPunch;
    /// <summary>
    /// Function: GetStrikeImpactCue_HeadPunch
    /// </summary>
    public unsafe static BmSDK.Engine.AkEvent GetStrikeImpactCue_HeadPunch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeImpactCue_HeadPunch, "BmScript.RCharacter_Robot.GetStrikeImpactCue_HeadPunch");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeImpactCue_CounterBlock;
    /// <summary>
    /// Function: GetStrikeImpactCue_CounterBlock
    /// </summary>
    public unsafe static BmSDK.Engine.AkEvent GetStrikeImpactCue_CounterBlock()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeImpactCue_CounterBlock, "BmScript.RCharacter_Robot.GetStrikeImpactCue_CounterBlock");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeImpactCue_FinishingBlow;
    /// <summary>
    /// Function: GetStrikeImpactCue_FinishingBlow
    /// </summary>
    public unsafe static BmSDK.Engine.AkEvent GetStrikeImpactCue_FinishingBlow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeImpactCue_FinishingBlow, "BmScript.RCharacter_Robot.GetStrikeImpactCue_FinishingBlow");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// NameProperty: CanOnlyBeHitBy
    /// </summary>
    public unsafe BmSDK.FName CanOnlyBeHitBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
}
