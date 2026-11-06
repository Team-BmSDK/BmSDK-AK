#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHUD<br/>
/// (size = 1528)
/// (flags = 10485790)
/// </summary>
public partial class RHUD : BmSDK.BmGame.RHUDBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHUD", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHUD.
    /// </summary>
    public static RHUD DefaultObject => (RHUD)StaticClass().DefaultObject;

    internal RHUD() { }

    /// <summary>
    /// Constructs a new RHUD
    /// </summary>
    public RHUD(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHUD(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHUD>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHUD>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHUD>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHUD>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHUD>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHUD>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHUD>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHUD>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ShouldDrawHUD;
    /// <summary>
    /// Function: ShouldDrawHUD
    /// </summary>
    public unsafe override bool ShouldDrawHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDrawHUD, "BmGame.RHUD.ShouldDrawHUD");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SavedGame;
    /// <summary>
    /// Function: SavedGame
    /// </summary>
    public unsafe virtual void SavedGame(BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SavedGame, "BmGame.RHUD.SavedGame");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RHUD.DrawHUD");
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreRender;
    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe override void PreRender()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreRender, "BmGame.RHUD.PreRender");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawEventVisualisation;
    /// <summary>
    /// Function: DrawEventVisualisation
    /// </summary>
    public unsafe virtual void DrawEventVisualisation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawEventVisualisation, "BmGame.RHUD.DrawEventVisualisation");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawRouterDebug;
    /// <summary>
    /// Function: DrawRouterDebug
    /// </summary>
    public unsafe virtual void DrawRouterDebug(BmSDK.Engine.Canvas C)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawRouterDebug, "BmGame.RHUD.DrawRouterDebug");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawThoughts;
    /// <summary>
    /// Function: DrawThoughts
    /// </summary>
    public unsafe virtual void DrawThoughts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawThoughts, "BmGame.RHUD.DrawThoughts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawThoughtList;
    /// <summary>
    /// Function: DrawThoughtList
    /// </summary>
    public unsafe virtual void DrawThoughtList(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, System.Numerics.Vector3 WorldPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawThoughtList, "BmGame.RHUD.DrawThoughtList");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldPos, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DrawShadowedText;
    /// <summary>
    /// Function: DrawShadowedText
    /// </summary>
    public unsafe virtual void DrawShadowedText(float TX, float TY, BmSDK.FString Text, float Scale = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawShadowedText, "BmGame.RHUD.DrawShadowedText");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveOverlay;
    /// <summary>
    /// Function: RemoveOverlay
    /// </summary>
    public unsafe virtual void RemoveOverlay(BmSDK.BmGame.RHUDInterface hInterface)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveOverlay, "BmGame.RHUD.RemoveOverlay");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hInterface, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNewOverlay;
    /// <summary>
    /// Function: SetNewOverlay
    /// </summary>
    public unsafe virtual void SetNewOverlay(BmSDK.BmGame.RHUD.ECinematicPriorities Priority, BmSDK.BmGame.RHUDInterface hInterface)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNewOverlay, "BmGame.RHUD.SetNewOverlay");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hInterface, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlockLevelName;
    /// <summary>
    /// Function: BlockLevelName
    /// </summary>
    public unsafe virtual bool BlockLevelName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockLevelName, "BmGame.RHUD.BlockLevelName");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawCinematicOverlay;
    /// <summary>
    /// Function: DrawCinematicOverlay
    /// </summary>
    public unsafe virtual void DrawCinematicOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawCinematicOverlay, "BmGame.RHUD.DrawCinematicOverlay");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreRenderCinematicOverlay;
    /// <summary>
    /// Function: PreRenderCinematicOverlay
    /// </summary>
    public unsafe virtual void PreRenderCinematicOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreRenderCinematicOverlay, "BmGame.RHUD.PreRenderCinematicOverlay");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowLoadingPrompt;
    /// <summary>
    /// Function: ShowLoadingPrompt
    /// </summary>
    public unsafe virtual void ShowLoadingPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLoadingPrompt, "BmGame.RHUD.ShowLoadingPrompt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearSkipPrompt;
    /// <summary>
    /// Function: ClearSkipPrompt
    /// </summary>
    public unsafe virtual void ClearSkipPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearSkipPrompt, "BmGame.RHUD.ClearSkipPrompt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSkipPrompt;
    /// <summary>
    /// Function: ShowSkipPrompt
    /// </summary>
    public unsafe virtual void ShowSkipPrompt(bool bAButtonToSkip)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSkipPrompt, "BmGame.RHUD.ShowSkipPrompt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAButtonToSkip, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsShowingSkipPrompt;
    /// <summary>
    /// Function: IsShowingSkipPrompt
    /// </summary>
    public unsafe virtual bool IsShowingSkipPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsShowingSkipPrompt, "BmGame.RHUD.IsShowingSkipPrompt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// ArrayProperty: CinematicOverlay
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHUDInterface> CinematicOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHUDInterface>>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// StrProperty: SavedGameName
    /// </summary>
    public unsafe BmSDK.FString SavedGameName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// FloatProperty: SavedGameTime
    /// </summary>
    public unsafe float SavedGameTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: ShowSkipPromptTime
    /// </summary>
    public unsafe float ShowSkipPromptTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: ShowLoadingPromptTime
    /// </summary>
    public unsafe float ShowLoadingPromptTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// FloatProperty: CinematicPromptFadeTime
    /// </summary>
    public unsafe float CinematicPromptFadeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// FloatProperty: CinematicPromptShowTime
    /// </summary>
    public unsafe float CinematicPromptShowTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// Enum: ECinematicPriorities
    /// </summary>
    public enum ECinematicPriorities : byte
    {
        CP_Front = 0,
        CP_Middle = 1,
        CP_End = 2,
        CP_MAX = 3,
    }
}
