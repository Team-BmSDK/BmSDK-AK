#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieModularHud<br/>
/// (size = 1028)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovieModularHud : BmSDK.BmGame.RGFxMovieModularHudBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieModularHud", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieModularHud.
    /// </summary>
    public static RGFxMovieModularHud DefaultObject => (RGFxMovieModularHud)StaticClass().DefaultObject;

    internal RGFxMovieModularHud() { }

    /// <summary>
    /// Constructs a new RGFxMovieModularHud
    /// </summary>
    public RGFxMovieModularHud(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieModularHud Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieModularHud(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHud>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHud>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHud>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHud>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHud>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHud>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHud>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieModularHud>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_NotifyFriendBeatYou;
    /// <summary>
    /// Function: NotifyFriendBeatYou
    /// </summary>
    public unsafe override void NotifyFriendBeatYou()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFriendBeatYou, "BmGame.RGFxMovieModularHud.NotifyFriendBeatYou");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_HeavyTankScan_ThreeDeeAnimComplete;
    /// <summary>
    /// Function: DXI_HeavyTankScan_ThreeDeeAnimComplete
    /// </summary>
    public unsafe virtual void DXI_HeavyTankScan_ThreeDeeAnimComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_HeavyTankScan_ThreeDeeAnimComplete, "BmGame.RGFxMovieModularHud.DXI_HeavyTankScan_ThreeDeeAnimComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_HeavyTankScan_ScanResolved;
    /// <summary>
    /// Function: DXI_HeavyTankScan_ScanResolved
    /// </summary>
    public unsafe virtual void DXI_HeavyTankScan_ScanResolved(float proportion_revealed_this_scan, float total_proportion_revealed, float scan_angle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_HeavyTankScan_ScanResolved, "BmGame.RGFxMovieModularHud.DXI_HeavyTankScan_ScanResolved");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(proportion_revealed_this_scan, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(total_proportion_revealed, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(scan_angle, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_SuicideCars_NotifyOutroComplete;
    /// <summary>
    /// Function: DXI_SuicideCars_NotifyOutroComplete
    /// </summary>
    public unsafe virtual void DXI_SuicideCars_NotifyOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_SuicideCars_NotifyOutroComplete, "BmGame.RGFxMovieModularHud.DXI_SuicideCars_NotifyOutroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseSuicideCarsHud;
    /// <summary>
    /// Function: CloseSuicideCarsHud
    /// </summary>
    public unsafe virtual void CloseSuicideCarsHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseSuicideCarsHud, "BmGame.RGFxMovieModularHud.CloseSuicideCarsHud");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSuicideCarsLevel;
    /// <summary>
    /// Function: SetSuicideCarsLevel
    /// </summary>
    public unsafe virtual void SetSuicideCarsLevel(float _CurrentSuicideCarsLevel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSuicideCarsLevel, "BmGame.RGFxMovieModularHud.SetSuicideCarsLevel");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CurrentSuicideCarsLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Beacon_NotifyOutroComplete;
    /// <summary>
    /// Function: DXI_Beacon_NotifyOutroComplete
    /// </summary>
    public unsafe virtual void DXI_Beacon_NotifyOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Beacon_NotifyOutroComplete, "BmGame.RGFxMovieModularHud.DXI_Beacon_NotifyOutroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Boss_NotifyOutroComplete;
    /// <summary>
    /// Function: DXI_Boss_NotifyOutroComplete
    /// </summary>
    public unsafe virtual void DXI_Boss_NotifyOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Boss_NotifyOutroComplete, "BmGame.RGFxMovieModularHud.DXI_Boss_NotifyOutroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Extra_NotifyOutroComplete;
    /// <summary>
    /// Function: DXI_Extra_NotifyOutroComplete
    /// </summary>
    public unsafe virtual void DXI_Extra_NotifyOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Extra_NotifyOutroComplete, "BmGame.RGFxMovieModularHud.DXI_Extra_NotifyOutroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_LocalRadarOffscreen;
    /// <summary>
    /// Function: DXI_LocalRadarOffscreen
    /// </summary>
    public unsafe virtual void DXI_LocalRadarOffscreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_LocalRadarOffscreen, "BmGame.RGFxMovieModularHud.DXI_LocalRadarOffscreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ShutdownFilmBombCounter;
    /// <summary>
    /// Function: DXI_ShutdownFilmBombCounter
    /// </summary>
    public unsafe virtual void DXI_ShutdownFilmBombCounter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ShutdownFilmBombCounter, "BmGame.RGFxMovieModularHud.DXI_ShutdownFilmBombCounter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_BespokeHudOffscreen;
    /// <summary>
    /// Function: DXI_BespokeHudOffscreen
    /// </summary>
    public unsafe virtual void DXI_BespokeHudOffscreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_BespokeHudOffscreen, "BmGame.RGFxMovieModularHud.DXI_BespokeHudOffscreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ApcLocationNoLongerRequired;
    /// <summary>
    /// Function: DXI_ApcLocationNoLongerRequired
    /// </summary>
    public unsafe virtual void DXI_ApcLocationNoLongerRequired()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ApcLocationNoLongerRequired, "BmGame.RGFxMovieModularHud.DXI_ApcLocationNoLongerRequired");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShutDownAlertsHud;
    /// <summary>
    /// Function: ShutDownAlertsHud
    /// </summary>
    public unsafe virtual void ShutDownAlertsHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutDownAlertsHud, "BmGame.RGFxMovieModularHud.ShutDownAlertsHud");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_AlertsAndSurveillanceHudNoLongerRequired;
    /// <summary>
    /// Function: DXI_AlertsAndSurveillanceHudNoLongerRequired
    /// </summary>
    public unsafe virtual void DXI_AlertsAndSurveillanceHudNoLongerRequired()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_AlertsAndSurveillanceHudNoLongerRequired, "BmGame.RGFxMovieModularHud.DXI_AlertsAndSurveillanceHudNoLongerRequired");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenAlertsAndSurveillanceHud;
    /// <summary>
    /// Function: OpenAlertsAndSurveillanceHud
    /// </summary>
    public unsafe virtual void OpenAlertsAndSurveillanceHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenAlertsAndSurveillanceHud, "BmGame.RGFxMovieModularHud.OpenAlertsAndSurveillanceHud");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_TriggerSpeech;
    /// <summary>
    /// Function: DXI_TriggerSpeech
    /// </summary>
    public unsafe virtual void DXI_TriggerSpeech(BmSDK.FString sName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_TriggerSpeech, "BmGame.RGFxMovieModularHud.DXI_TriggerSpeech");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ChallengeResultsClose;
    /// <summary>
    /// Function: DXI_ChallengeResultsClose
    /// </summary>
    public unsafe virtual void DXI_ChallengeResultsClose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ChallengeResultsClose, "BmGame.RGFxMovieModularHud.DXI_ChallengeResultsClose");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ChallengeResults;
    /// <summary>
    /// Function: DXI_ChallengeResults
    /// </summary>
    public unsafe virtual void DXI_ChallengeResults()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ChallengeResults, "BmGame.RGFxMovieModularHud.DXI_ChallengeResults");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_CountdownComplete;
    /// <summary>
    /// Function: DXI_CountdownComplete
    /// </summary>
    public unsafe virtual void DXI_CountdownComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_CountdownComplete, "BmGame.RGFxMovieModularHud.DXI_CountdownComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_OnChallengeClose;
    /// <summary>
    /// Function: DXI_OnChallengeClose
    /// </summary>
    public unsafe virtual void DXI_OnChallengeClose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_OnChallengeClose, "BmGame.RGFxMovieModularHud.DXI_OnChallengeClose");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseChallengeModeMovie;
    /// <summary>
    /// Function: CloseChallengeModeMovie
    /// </summary>
    public unsafe virtual void CloseChallengeModeMovie()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseChallengeModeMovie, "BmGame.RGFxMovieModularHud.CloseChallengeModeMovie");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenChallengeModeModule;
    /// <summary>
    /// Function: OpenChallengeModeModule
    /// </summary>
    public unsafe virtual void OpenChallengeModeModule(BmSDK.GFxUI.SwfMovie NewMovieInfo = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenChallengeModeModule, "BmGame.RGFxMovieModularHud.OpenChallengeModeModule");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMovieInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_CloseRoomMovie;
    /// <summary>
    /// Function: DXI_CloseRoomMovie
    /// </summary>
    public unsafe virtual void DXI_CloseRoomMovie()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_CloseRoomMovie, "BmGame.RGFxMovieModularHud.DXI_CloseRoomMovie");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenRoomNameModule;
    /// <summary>
    /// Function: OpenRoomNameModule
    /// </summary>
    public unsafe virtual void OpenRoomNameModule()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenRoomNameModule, "BmGame.RGFxMovieModularHud.OpenRoomNameModule");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ObjectiveBarFilled;
    /// <summary>
    /// Function: DXI_ObjectiveBarFilled
    /// </summary>
    public unsafe virtual void DXI_ObjectiveBarFilled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ObjectiveBarFilled, "BmGame.RGFxMovieModularHud.DXI_ObjectiveBarFilled");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ObjectiveQueueBusy;
    /// <summary>
    /// Function: DXI_ObjectiveQueueBusy
    /// </summary>
    public unsafe virtual void DXI_ObjectiveQueueBusy()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ObjectiveQueueBusy, "BmGame.RGFxMovieModularHud.DXI_ObjectiveQueueBusy");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ObjectiveQueueEmpty;
    /// <summary>
    /// Function: DXI_ObjectiveQueueEmpty
    /// </summary>
    public unsafe virtual void DXI_ObjectiveQueueEmpty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ObjectiveQueueEmpty, "BmGame.RGFxMovieModularHud.DXI_ObjectiveQueueEmpty");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ObjectiveItemShown;
    /// <summary>
    /// Function: DXI_ObjectiveItemShown
    /// </summary>
    public unsafe virtual void DXI_ObjectiveItemShown(int arrow_type, BmSDK.FString CustomIconString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ObjectiveItemShown, "BmGame.RGFxMovieModularHud.DXI_ObjectiveItemShown");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(arrow_type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIconString, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ObjectivesCallback_PulseCompassIndicator;
    /// <summary>
    /// Function: DXI_ObjectivesCallback_PulseCompassIndicator
    /// </summary>
    public unsafe virtual void DXI_ObjectivesCallback_PulseCompassIndicator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ObjectivesCallback_PulseCompassIndicator, "BmGame.RGFxMovieModularHud.DXI_ObjectivesCallback_PulseCompassIndicator");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ForceShowMap;
    /// <summary>
    /// Function: DXI_ForceShowMap
    /// </summary>
    public unsafe virtual void DXI_ForceShowMap(BmSDK.FString ObjectParam)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ForceShowMap, "BmGame.RGFxMovieModularHud.DXI_ForceShowMap");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectParam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_ObjectivesPromptCallback;
    /// <summary>
    /// Function: DXI_ObjectivesPromptCallback
    /// </summary>
    public unsafe virtual void DXI_ObjectivesPromptCallback(BmSDK.FString KeyType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_ObjectivesPromptCallback, "BmGame.RGFxMovieModularHud.DXI_ObjectivesPromptCallback");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseObjectivesModule;
    /// <summary>
    /// Function: CloseObjectivesModule
    /// </summary>
    public unsafe virtual void CloseObjectivesModule()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseObjectivesModule, "BmGame.RGFxMovieModularHud.CloseObjectivesModule");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenObjectivesModule;
    /// <summary>
    /// Function: OpenObjectivesModule
    /// </summary>
    public unsafe virtual void OpenObjectivesModule()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenObjectivesModule, "BmGame.RGFxMovieModularHud.OpenObjectivesModule");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_DetectiveJammer_NotifyOutroComplete;
    /// <summary>
    /// Function: DXI_DetectiveJammer_NotifyOutroComplete
    /// </summary>
    public unsafe virtual void DXI_DetectiveJammer_NotifyOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_DetectiveJammer_NotifyOutroComplete, "BmGame.RGFxMovieModularHud.DXI_DetectiveJammer_NotifyOutroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDetectiveModeJammed;
    /// <summary>
    /// Function: SetDetectiveModeJammed
    /// </summary>
    public unsafe virtual void SetDetectiveModeJammed(bool is_jammed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDetectiveModeJammed, "BmGame.RGFxMovieModularHud.SetDetectiveModeJammed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_jammed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDetectiveModeCompromisedLevel;
    /// <summary>
    /// Function: SetDetectiveModeCompromisedLevel
    /// </summary>
    public unsafe virtual void SetDetectiveModeCompromisedLevel(float JammingProportion, BmSDK.BmGame.RGFxMovieModularHud.EDetectiveModeDetectorStates StateEnum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDetectiveModeCompromisedLevel, "BmGame.RGFxMovieModularHud.SetDetectiveModeCompromisedLevel");
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JammingProportion, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateEnum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateJammingModulePrivate;
    /// <summary>
    /// Function: CreateJammingModulePrivate
    /// </summary>
    public unsafe virtual void CreateJammingModulePrivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateJammingModulePrivate, "BmGame.RGFxMovieModularHud.CreateJammingModulePrivate");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Batmobile_VirusOutroComplete;
    /// <summary>
    /// Function: DXI_Batmobile_VirusOutroComplete
    /// </summary>
    public unsafe virtual void DXI_Batmobile_VirusOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Batmobile_VirusOutroComplete, "BmGame.RGFxMovieModularHud.DXI_Batmobile_VirusOutroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Batmobile_NotifyOutroComplete;
    /// <summary>
    /// Function: DXI_Batmobile_NotifyOutroComplete
    /// </summary>
    public unsafe virtual void DXI_Batmobile_NotifyOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Batmobile_NotifyOutroComplete, "BmGame.RGFxMovieModularHud.DXI_Batmobile_NotifyOutroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShutDownBatmobileHud;
    /// <summary>
    /// Function: ShutDownBatmobileHud
    /// </summary>
    public unsafe virtual void ShutDownBatmobileHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutDownBatmobileHud, "BmGame.RGFxMovieModularHud.ShutDownBatmobileHud");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeployBatmobileHud;
    /// <summary>
    /// Function: DeployBatmobileHud
    /// </summary>
    public unsafe virtual void DeployBatmobileHud(bool DeployInActiveState = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeployBatmobileHud, "BmGame.RGFxMovieModularHud.DeployBatmobileHud");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeployInActiveState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_HealthBar_PostCombatSummaryFinished;
    /// <summary>
    /// Function: DXI_HealthBar_PostCombatSummaryFinished
    /// </summary>
    public unsafe virtual void DXI_HealthBar_PostCombatSummaryFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_HealthBar_PostCombatSummaryFinished, "BmGame.RGFxMovieModularHud.DXI_HealthBar_PostCombatSummaryFinished");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_DownloadProgress_NotifyOutroComplete;
    /// <summary>
    /// Function: DXI_DownloadProgress_NotifyOutroComplete
    /// </summary>
    public unsafe virtual void DXI_DownloadProgress_NotifyOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_DownloadProgress_NotifyOutroComplete, "BmGame.RGFxMovieModularHud.DXI_DownloadProgress_NotifyOutroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_DownloadProgress_NotifyIntroComplete;
    /// <summary>
    /// Function: DXI_DownloadProgress_NotifyIntroComplete
    /// </summary>
    public unsafe virtual void DXI_DownloadProgress_NotifyIntroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_DownloadProgress_NotifyIntroComplete, "BmGame.RGFxMovieModularHud.DXI_DownloadProgress_NotifyIntroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeployDownloadProgressHud;
    /// <summary>
    /// Function: DeployDownloadProgressHud
    /// </summary>
    public unsafe virtual void DeployDownloadProgressHud(BmSDK.FString InitialiseText, BmSDK.FString DownloadText, BmSDK.FString CompleteText, BmSDK.FString DownloadAnim = default, BmSDK.FString InitialiseAnim = default, BmSDK.FString CompleteAnim = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeployDownloadProgressHud, "BmGame.RGFxMovieModularHud.DeployDownloadProgressHud");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialiseText, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DownloadText, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompleteText, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DownloadAnim, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialiseAnim, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompleteAnim, paramsPtr + 80);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_SetMainPrompt;
    /// <summary>
    /// Function: SetMainPrompt
    /// </summary>
    public unsafe virtual void SetMainPrompt(int Id, BmSDK.FString Label, float Alpha = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMainPrompt, "BmGame.RGFxMovieModularHud.SetMainPrompt");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrompt;
    /// <summary>
    /// Function: SetPrompt
    /// </summary>
    public unsafe virtual void SetPrompt(int Id, BmSDK.FString Label, float Alpha = default, bool bAsMain = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompt, "BmGame.RGFxMovieModularHud.SetPrompt");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAsMain, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPromptWithLocalise;
    /// <summary>
    /// Function: SetPromptWithLocalise
    /// </summary>
    public unsafe virtual void SetPromptWithLocalise(int Id, BmSDK.FString Label, float Alpha = default, bool bAsMain = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPromptWithLocalise, "BmGame.RGFxMovieModularHud.SetPromptWithLocalise");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAsMain, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReLayoutPrompts;
    /// <summary>
    /// Function: ReLayoutPrompts
    /// </summary>
    public unsafe virtual void ReLayoutPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReLayoutPrompts, "BmGame.RGFxMovieModularHud.ReLayoutPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPrompts;
    /// <summary>
    /// Function: ClearPrompts
    /// </summary>
    public unsafe virtual void ClearPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPrompts, "BmGame.RGFxMovieModularHud.ClearPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInfoText;
    /// <summary>
    /// Function: SetInfoText
    /// </summary>
    public unsafe virtual void SetInfoText(BmSDK.FString PadText, BmSDK.FString AltPcText, int Justification = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInfoText, "BmGame.RGFxMovieModularHud.SetInfoText");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PadText, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltPcText, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Justification, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Scanner_ScannerAnimComplete;
    /// <summary>
    /// Function: DXI_Scanner_ScannerAnimComplete
    /// </summary>
    public unsafe virtual void DXI_Scanner_ScannerAnimComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Scanner_ScannerAnimComplete, "BmGame.RGFxMovieModularHud.DXI_Scanner_ScannerAnimComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Scanner_NotifyOutroComplete;
    /// <summary>
    /// Function: DXI_Scanner_NotifyOutroComplete
    /// </summary>
    public unsafe virtual void DXI_Scanner_NotifyOutroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Scanner_NotifyOutroComplete, "BmGame.RGFxMovieModularHud.DXI_Scanner_NotifyOutroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Scanner_NotifyIntroComplete;
    /// <summary>
    /// Function: DXI_Scanner_NotifyIntroComplete
    /// </summary>
    public unsafe virtual void DXI_Scanner_NotifyIntroComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Scanner_NotifyIntroComplete, "BmGame.RGFxMovieModularHud.DXI_Scanner_NotifyIntroComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScanningComplete;
    /// <summary>
    /// Function: ScanningComplete
    /// </summary>
    public unsafe virtual void ScanningComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScanningComplete, "BmGame.RGFxMovieModularHud.ScanningComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AbortScanning;
    /// <summary>
    /// Function: AbortScanning
    /// </summary>
    public unsafe virtual void AbortScanning()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AbortScanning, "BmGame.RGFxMovieModularHud.AbortScanning");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartScanning;
    /// <summary>
    /// Function: StartScanning
    /// </summary>
    public unsafe virtual void StartScanning()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartScanning, "BmGame.RGFxMovieModularHud.StartScanning");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShutdownScanner;
    /// <summary>
    /// Function: ShutdownScanner
    /// </summary>
    public unsafe virtual void ShutdownScanner()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutdownScanner, "BmGame.RGFxMovieModularHud.ShutdownScanner");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeployScanner;
    /// <summary>
    /// Function: DeployScanner
    /// </summary>
    public unsafe virtual void DeployScanner()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeployScanner, "BmGame.RGFxMovieModularHud.DeployScanner");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_SetContents;
    /// <summary>
    /// Function: DXI_SetContents
    /// </summary>
    public unsafe virtual void DXI_SetContents(BmSDK.FString contents_string, bool bScanned)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_SetContents, "BmGame.RGFxMovieModularHud.DXI_SetContents");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(contents_string, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bScanned, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DXI_Detective_SetScannerAnimation;
    /// <summary>
    /// Function: DXI_Detective_SetScannerAnimation
    /// </summary>
    public unsafe virtual void DXI_Detective_SetScannerAnimation(BmSDK.FString scanner_anim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DXI_Detective_SetScannerAnimation, "BmGame.RGFxMovieModularHud.DXI_Detective_SetScannerAnimation");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(scanner_anim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDetectiveModeSelection;
    /// <summary>
    /// Function: SetDetectiveModeSelection
    /// </summary>
    public unsafe virtual bool SetDetectiveModeSelection(float location_x, float location_y, float location_depth, BmSDK.FString Heading, BmSDK.FString Description, bool Warning)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDetectiveModeSelection, "BmGame.RGFxMovieModularHud.SetDetectiveModeSelection");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Warning, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_GetNPCCountString_DLCHarleyQuinn;
    /// <summary>
    /// Function: GetNPCCountString_DLCHarleyQuinn
    /// </summary>
    public unsafe virtual BmSDK.FString GetNPCCountString_DLCHarleyQuinn(int Armed, int UnArmed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNPCCountString_DLCHarleyQuinn, "BmGame.RGFxMovieModularHud.GetNPCCountString_DLCHarleyQuinn");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Armed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnArmed, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetNPCCountString;
    /// <summary>
    /// Function: GetNPCCountString
    /// </summary>
    public unsafe virtual BmSDK.FString GetNPCCountString(int Armed, int UnArmed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNPCCountString, "BmGame.RGFxMovieModularHud.GetNPCCountString");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Armed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnArmed, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetBatmobileMode;
    /// <summary>
    /// Function: SetBatmobileMode
    /// </summary>
    public unsafe virtual void SetBatmobileMode(bool is_batmobile)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmobileMode, "BmGame.RGFxMovieModularHud.SetBatmobileMode");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_batmobile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IndividualDeferredInterfaceCall;
    /// <summary>
    /// Function: IndividualDeferredInterfaceCall
    /// </summary>
    public unsafe virtual void IndividualDeferredInterfaceCall(BmSDK.TArray<BmSDK.FString> param_array)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IndividualDeferredInterfaceCall, "BmGame.RGFxMovieModularHud.IndividualDeferredInterfaceCall");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(param_array, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessDeferredInterfaceCallsNative;
    /// <summary>
    /// Function: ProcessDeferredInterfaceCallsNative
    /// </summary>
    public unsafe virtual void ProcessDeferredInterfaceCallsNative(BmSDK.FString DeferredExternalInterfaceCalls)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessDeferredInterfaceCallsNative, "BmGame.RGFxMovieModularHud.ProcessDeferredInterfaceCallsNative");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeferredExternalInterfaceCalls, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ProcessDeferredInterfaceCalls;
    /// <summary>
    /// Function: ProcessDeferredInterfaceCalls
    /// </summary>
    public unsafe virtual void ProcessDeferredInterfaceCalls()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessDeferredInterfaceCalls, "BmGame.RGFxMovieModularHud.ProcessDeferredInterfaceCalls");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManualAdvanceTick;
    /// <summary>
    /// Function: ManualAdvanceTick
    /// </summary>
    public unsafe override void ManualAdvanceTick(float DeltaT)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManualAdvanceTick, "BmGame.RGFxMovieModularHud.ManualAdvanceTick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaT, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanUpForCutscene;
    /// <summary>
    /// Function: CleanUpForCutscene
    /// </summary>
    public unsafe override void CleanUpForCutscene()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanUpForCutscene, "BmGame.RGFxMovieModularHud.CleanUpForCutscene");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetColorTransform;
    /// <summary>
    /// Function: SetColorTransform
    /// </summary>
    public unsafe override void SetColorTransform(float RedOffset, float GreenOffset, float BlueOffset, float RedScalar, float GreenScalar, float BlueScalar)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetColorTransform, "BmGame.RGFxMovieModularHud.SetColorTransform");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RedOffset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GreenOffset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlueOffset, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RedScalar, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GreenScalar, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlueScalar, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetJokerColorTransform;
    /// <summary>
    /// Function: SetJokerColorTransform
    /// </summary>
    public unsafe virtual void SetJokerColorTransform()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetJokerColorTransform, "BmGame.RGFxMovieModularHud.SetJokerColorTransform");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHudVisibility;
    /// <summary>
    /// Function: UpdateHudVisibility
    /// </summary>
    public unsafe override void UpdateHudVisibility(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHudVisibility, "BmGame.RGFxMovieModularHud.UpdateHudVisibility");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManuallySetHudVisibility;
    /// <summary>
    /// Function: ManuallySetHudVisibility
    /// </summary>
    public unsafe override void ManuallySetHudVisibility(bool bVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManuallySetHudVisibility, "BmGame.RGFxMovieModularHud.ManuallySetHudVisibility");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSelectiveVisibilityModule;
    /// <summary>
    /// Function: SetSelectiveVisibilityModule
    /// </summary>
    public unsafe override void SetSelectiveVisibilityModule(BmSDK.FString module_name)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSelectiveVisibilityModule, "BmGame.RGFxMovieModularHud.SetSelectiveVisibilityModule");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(module_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShakeEntireHud;
    /// <summary>
    /// Function: ShakeEntireHud
    /// </summary>
    public unsafe override void ShakeEntireHud(bool FlashAndShake = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShakeEntireHud, "BmGame.RGFxMovieModularHud.ShakeEntireHud");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlashAndShake, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleBatmobileHud;
    /// <summary>
    /// Function: ToggleBatmobileHud
    /// </summary>
    public unsafe virtual void ToggleBatmobileHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleBatmobileHud, "BmGame.RGFxMovieModularHud.ToggleBatmobileHud");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleRadarHud;
    /// <summary>
    /// Function: ToggleRadarHud
    /// </summary>
    public unsafe virtual void ToggleRadarHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleRadarHud, "BmGame.RGFxMovieModularHud.ToggleRadarHud");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleTargetsHud;
    /// <summary>
    /// Function: ToggleTargetsHud
    /// </summary>
    public unsafe virtual void ToggleTargetsHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleTargetsHud, "BmGame.RGFxMovieModularHud.ToggleTargetsHud");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleMainHud;
    /// <summary>
    /// Function: ToggleMainHud
    /// </summary>
    public unsafe virtual void ToggleMainHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleMainHud, "BmGame.RGFxMovieModularHud.ToggleMainHud");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMinimalHudMode;
    /// <summary>
    /// Function: SetMinimalHudMode
    /// </summary>
    public unsafe virtual void SetMinimalHudMode(bool _MinimalHudMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMinimalHudMode, "BmGame.RGFxMovieModularHud.SetMinimalHudMode");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MinimalHudMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMinimalHudBecausePlayerJustDied;
    /// <summary>
    /// Function: SetMinimalHudBecausePlayerJustDied
    /// </summary>
    public unsafe virtual void SetMinimalHudBecausePlayerJustDied()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMinimalHudBecausePlayerJustDied, "BmGame.RGFxMovieModularHud.SetMinimalHudBecausePlayerJustDied");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerRestoredToLife;
    /// <summary>
    /// Function: PlayerRestoredToLife
    /// </summary>
    public unsafe virtual void PlayerRestoredToLife()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerRestoredToLife, "BmGame.RGFxMovieModularHud.PlayerRestoredToLife");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvestigateModeAuto;
    /// <summary>
    /// Function: SetInvestigateModeAuto
    /// </summary>
    public unsafe virtual void SetInvestigateModeAuto()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvestigateModeAuto, "BmGame.RGFxMovieModularHud.SetInvestigateModeAuto");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckCleanupForDisposableHud;
    /// <summary>
    /// Function: CheckCleanupForDisposableHud
    /// </summary>
    public unsafe virtual void CheckCleanupForDisposableHud()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckCleanupForDisposableHud, "BmGame.RGFxMovieModularHud.CheckCleanupForDisposableHud");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDisposableGfxMovie;
    /// <summary>
    /// Function: GetDisposableGfxMovie
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGFxMovieModularHud_Disposable GetDisposableGfxMovie()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisposableGfxMovie, "BmGame.RGFxMovieModularHud.GetDisposableGfxMovie");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGFxMovieModularHud_Disposable>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AnyDisposableModulesWaitingToInitialise;
    /// <summary>
    /// Function: AnyDisposableModulesWaitingToInitialise
    /// </summary>
    public unsafe virtual bool AnyDisposableModulesWaitingToInitialise()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyDisposableModulesWaitingToInitialise, "BmGame.RGFxMovieModularHud.AnyDisposableModulesWaitingToInitialise");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnClose;
    /// <summary>
    /// Function: OnClose
    /// </summary>
    public unsafe override void OnClose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClose, "BmGame.RGFxMovieModularHud.OnClose");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieModularHud.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EDetectiveModeDetectorStates
    /// </summary>
    public enum EDetectiveModeDetectorStates : byte
    {
        EDMD_Filling = 0,
        EDMD_Emptying = 1,
        EDMD_AlmostFullWarning = 2,
        EDMD_Full = 3,
        EDMD_MAX = 4,
    }

    /// <summary>
    /// Enum: ENpcHeartBeatType
    /// </summary>
    public enum ENpcHeartBeatType : byte
    {
        ENpcHeartBeatType_Fine = 0,
        ENpcHeartBeatType_Nervous = 1,
        ENpcHeartBeatType_Terrified = 2,
        ENpcHeartBeatType_Unconscious = 3,
        ENpcHeartBeatType_FearGas = 4,
        ENpcHeartBeatType_Injured = 5,
        ENpcHeartBeatType_RobotDead = 6,
        ENpcHeartBeatType_RobotDormant = 7,
        ENpcHeartBeatType_RobotActive = 8,
        ENpcHeartBeatType_EmotionalDistress = 9,
        ENpcHeartBeatType_Unknown = 10,
        ENpcHeartBeatType_Agitated = 11,
        ENpcHeartBeatType_MAX = 12,
    }

    /// <summary>
    /// Enum: ObjIcon
    /// </summary>
    public enum ObjIcon : byte
    {
        OI_Arrow = 0,
        OI_Ticked = 1,
        OI_Unlocked = 2,
        OI_SideStory = 3,
        OI_SideStoryTick = 4,
        OI_PointOfInterest = 5,
        OI_ARChallenge = 6,
        OI_Waypoint = 7,
        OI_Switchpoint = 8,
        OI_Challenge = 9,
        OI_ObjectiveBatmobile = 10,
        OI_ObjectiveCustomIconName = 11,
        OI_MAX = 12,
    }

    /// <summary>
    /// BoolProperty: bCommonElementsInitialised
    /// </summary>
    public unsafe bool bCommonElementsInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileModeRequested
    /// </summary>
    public unsafe bool bBatmobileModeRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileModeActive
    /// </summary>
    public unsafe bool bBatmobileModeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bPromptSystemAvailable
    /// </summary>
    public unsafe bool bPromptSystemAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bObjectivesVisible
    /// </summary>
    public unsafe bool bObjectivesVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bStandingStill
    /// </summary>
    public unsafe bool bStandingStill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: MinimalHudMode
    /// </summary>
    public unsafe bool MinimalHudMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: MinimalHudBecausePlayerJustDied
    /// </summary>
    public unsafe bool MinimalHudBecausePlayerJustDied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: TargetsModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleTargets TargetsModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleTargets>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: HealthBarModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleHealthBar HealthBarModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleHealthBar>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: StoryModeModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleStoryMode StoryModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleStoryMode>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: CrimeSceneInfoModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleCrimeSceneInfo CrimeSceneInfoModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleCrimeSceneInfo>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleDetectiveMode DetectiveModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleDetectiveMode>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: ExtraSequenceModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleExtraSequence ExtraSequenceModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleExtraSequence>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: DownloadProgressModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleDownloadProgress DownloadProgressModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleDownloadProgress>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBatmobile BatmobileModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBatmobile>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeJammingModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleDetectiveModeJamming DetectiveModeJammingModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleDetectiveModeJamming>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: HackingModeModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleHackingMode HackingModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleHackingMode>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: ScannerModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleScanner ScannerModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleScanner>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: ForensicDetailModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleForensicDetail ForensicDetailModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleForensicDetail>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: ObjectivesModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleObjectives ObjectivesModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleObjectives>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: RoomNameModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleRoomName RoomNameModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleRoomName>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: BespokeModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBespokeBase BespokeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBespokeBase>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: LocalRadarModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleLocalRadar LocalRadarModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleLocalRadar>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeModeModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleChallengeMode ChallengeModeModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleChallengeMode>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: AlertsAndSurveillanceModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleAlertsAndSurveillance AlertsAndSurveillanceModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleAlertsAndSurveillance>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBoss BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBoss>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: ForensicBeaconModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleForensicBeaconTracking ForensicBeaconModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleForensicBeaconTracking>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: HeavyTankScanModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleHeavyTankScanBase HeavyTankScanModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleHeavyTankScanBase>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: SuicideCarsModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleSuicideCars SuicideCarsModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleSuicideCars>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ObjectProperty: MinigameSequence
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_MinigameSequenceBase MinigameSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_MinigameSequenceBase>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: FireflyModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleFirefly FireflyModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleFirefly>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ObjectProperty: TargetsEtcGfxMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieModularHud_TargetsEtc TargetsEtcGfxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieModularHud_TargetsEtc>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ObjectProperty: LocalRadarGfxMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieModularHud_LocalRadar LocalRadarGfxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieModularHud_LocalRadar>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileGfxMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieModularHud_Batmobile BatmobileGfxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieModularHud_Batmobile>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: DisposableGfxMovies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMovieModularHud_Disposable> DisposableGfxMovies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMovieModularHud_Disposable>>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_RedOffset
    /// </summary>
    public unsafe float ColTrans_RedOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_GreenOffset
    /// </summary>
    public unsafe float ColTrans_GreenOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_BlueOffset
    /// </summary>
    public unsafe float ColTrans_BlueOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_RedScalar
    /// </summary>
    public unsafe float ColTrans_RedScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_GreenScalar
    /// </summary>
    public unsafe float ColTrans_GreenScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// FloatProperty: ColTrans_BlueScalar
    /// </summary>
    public unsafe float ColTrans_BlueScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// StructProperty: BatmanLastPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmanLastPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1012);

    /// <summary>
    /// IntProperty: ViewUpgradePromptDuration
    /// </summary>
    public unsafe int ViewUpgradePromptDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
}
