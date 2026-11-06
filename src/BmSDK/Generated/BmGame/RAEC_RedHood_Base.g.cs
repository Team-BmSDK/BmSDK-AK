#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_RedHood_Base<br/>
/// (size = 724)
/// (flags = 10485778)
/// </summary>
public partial class RAEC_RedHood_Base : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_RedHood_Base", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_RedHood_Base.
    /// </summary>
    public static RAEC_RedHood_Base DefaultObject => (RAEC_RedHood_Base)StaticClass().DefaultObject;

    internal RAEC_RedHood_Base() { }

    /// <summary>
    /// Constructs a new RAEC_RedHood_Base
    /// </summary>
    public RAEC_RedHood_Base(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_RedHood_Base(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_RedHood_Base>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_RedHood_Base>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_RedHood_Base>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_RedHood_Base>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_RedHood_Base>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_RedHood_Base>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_RedHood_Base>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_RedHood_Base>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_HandleBarkEventPlayed;
    /// <summary>
    /// Function: HandleBarkEventPlayed
    /// </summary>
    public unsafe virtual void HandleBarkEventPlayed(BmSDK.FName EventVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleBarkEventPlayed, "BmGame.RAEC_RedHood_Base.HandleBarkEventPlayed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSearchChatBark;
    /// <summary>
    /// Function: GetSearchChatBark
    /// </summary>
    public unsafe virtual void GetSearchChatBark(out BmSDK.BmGame.RBarkConvo SearchConvo, out float Score)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSearchChatBark, "BmGame.RAEC_RedHood_Base.GetSearchChatBark");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SearchConvo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchConvo, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Score);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SearchConvo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkConvo>(paramsPtr + 0);
        Score = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_IsDownToLastThugsAndRedHoodIsGone;
    /// <summary>
    /// Function: IsDownToLastThugsAndRedHoodIsGone
    /// </summary>
    public unsafe virtual bool IsDownToLastThugsAndRedHoodIsGone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDownToLastThugsAndRedHoodIsGone, "BmGame.RAEC_RedHood_Base.IsDownToLastThugsAndRedHoodIsGone");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayerKickIsIncoming;
    /// <summary>
    /// Function: PlayerKickIsIncoming
    /// </summary>
    public unsafe virtual bool PlayerKickIsIncoming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerKickIsIncoming, "BmGame.RAEC_RedHood_Base.PlayerKickIsIncoming");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInPlay;
    /// <summary>
    /// Function: IsInPlay
    /// </summary>
    public unsafe virtual bool IsInPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInPlay, "BmGame.RAEC_RedHood_Base.IsInPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawVolState;
    /// <summary>
    /// Function: DrawVolState
    /// </summary>
    public unsafe virtual void DrawVolState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawVolState, "BmGame.RAEC_RedHood_Base.DrawVolState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KickedOffVantageToFloor;
    /// <summary>
    /// Function: KickedOffVantageToFloor
    /// </summary>
    public unsafe virtual void KickedOffVantageToFloor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KickedOffVantageToFloor, "BmGame.RAEC_RedHood_Base.KickedOffVantageToFloor");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KickedOffVantage;
    /// <summary>
    /// Function: KickedOffVantage
    /// </summary>
    public unsafe virtual void KickedOffVantage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KickedOffVantage, "BmGame.RAEC_RedHood_Base.KickedOffVantage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPlayerGrapplingUp;
    /// <summary>
    /// Function: NotifyPlayerGrapplingUp
    /// </summary>
    public unsafe virtual void NotifyPlayerGrapplingUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPlayerGrapplingUp, "BmGame.RAEC_RedHood_Base.NotifyPlayerGrapplingUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveRedhoodToSafety;
    /// <summary>
    /// Function: MoveRedhoodToSafety
    /// </summary>
    public unsafe virtual void MoveRedhoodToSafety()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveRedhoodToSafety, "BmGame.RAEC_RedHood_Base.MoveRedhoodToSafety");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bThugsPlayedResponseToRHBeingKickedOff
    /// </summary>
    public unsafe bool bThugsPlayedResponseToRHBeingKickedOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }
}
