#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RSpecialMovieInstance_MinigameBase<br/>
/// (size = 896)
/// (flags = 144703635)
/// </summary>
public partial class RSpecialMovieInstance_MinigameBase : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMovieInstance_MinigameBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMovieInstance_MinigameBase.
    /// </summary>
    public static RSpecialMovieInstance_MinigameBase DefaultObject => (RSpecialMovieInstance_MinigameBase)StaticClass().DefaultObject;

    internal RSpecialMovieInstance_MinigameBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMovieInstance_MinigameBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdatePCResonatorPos;
    /// <summary>
    /// Function: UpdatePCResonatorPos
    /// </summary>
    public unsafe virtual void UpdatePCResonatorPos(BmSDK.BmGame.RPlayerInput Input, float DeltaTime, float TurnSpeed, float Accel, float Decel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePCResonatorPos, "BmGame.RSpecialMovieInstance_MinigameBase.UpdatePCResonatorPos");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Input, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnSpeed, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Accel, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Decel, paramsPtr + 20);
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

    private static BmSDK.Function __fn_GetLeftAndRightAngles;
    /// <summary>
    /// Function: GetLeftAndRightAngles
    /// </summary>
    public unsafe virtual void GetLeftAndRightAngles(out float LeftAngle, out float RightAngle, float RawLeftX, float RawLeftY, float RawRightX, float RawRightY)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeftAndRightAngles, "BmGame.RSpecialMovieInstance_MinigameBase.GetLeftAndRightAngles");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LeftAngle);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftAngle, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RightAngle);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightAngle, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RawLeftX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RawLeftY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RawRightX, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RawRightY, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LeftAngle = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        RightAngle = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_InterpThumbStraight;
    /// <summary>
    /// Function: InterpThumbStraight
    /// </summary>
    public unsafe virtual float InterpThumbStraight(float DesiredPos, float CurrentPos, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterpThumbStraight, "BmGame.RSpecialMovieInstance_MinigameBase.InterpThumbStraight");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
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

    private static BmSDK.Function __fn_InterpThumb;
    /// <summary>
    /// Function: InterpThumb
    /// </summary>
    public unsafe virtual float InterpThumb(float DesiredPos, float CurrentPos, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterpThumb, "BmGame.RSpecialMovieInstance_MinigameBase.InterpThumb");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
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

    private static BmSDK.Function __fn_FindDistanceFromPointToLine;
    /// <summary>
    /// Function: FindDistanceFromPointToLine
    /// </summary>
    public unsafe virtual float FindDistanceFromPointToLine(float nodePointX, float nodePointY, float laserPointX, float laserPointY, float laser_angle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindDistanceFromPointToLine, "BmGame.RSpecialMovieInstance_MinigameBase.FindDistanceFromPointToLine");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nodePointX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nodePointY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laserPointX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laserPointY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laser_angle, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_DoGameOver;
    /// <summary>
    /// Function: DoGameOver
    /// </summary>
    public unsafe virtual void DoGameOver(bool did_player_win)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGameOver, "BmGame.RSpecialMovieInstance_MinigameBase.DoGameOver");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(did_player_win, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNodeState;
    /// <summary>
    /// Function: SetNodeState
    /// </summary>
    public unsafe virtual void SetNodeState(int side_index, int node_index, int iState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNodeState, "BmGame.RSpecialMovieInstance_MinigameBase.SetNodeState");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(side_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node_index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iState, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBeamIntersectNodes;
    /// <summary>
    /// Function: SetBeamIntersectNodes
    /// </summary>
    public unsafe virtual void SetBeamIntersectNodes(int node1, int node2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBeamIntersectNodes, "BmGame.RSpecialMovieInstance_MinigameBase.SetBeamIntersectNodes");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node2, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBombMeterProportion;
    /// <summary>
    /// Function: SetBombMeterProportion
    /// </summary>
    public unsafe virtual void SetBombMeterProportion(float Proportion)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBombMeterProportion, "BmGame.RSpecialMovieInstance_MinigameBase.SetBombMeterProportion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupMadHatterMinigame;
    /// <summary>
    /// Function: SetupMadHatterMinigame
    /// </summary>
    public unsafe virtual void SetupMadHatterMinigame(float fHitArea, float fProportion, float fLaserSpeed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupMadHatterMinigame, "BmGame.RSpecialMovieInstance_MinigameBase.SetupMadHatterMinigame");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fHitArea, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fProportion, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fLaserSpeed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLaserPositionAndAngle;
    /// <summary>
    /// Function: SetLaserPositionAndAngle
    /// </summary>
    public unsafe virtual void SetLaserPositionAndAngle(int side_index, float fDollyX, float fDollyY, float fAngleToFocus)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLaserPositionAndAngle, "BmGame.RSpecialMovieInstance_MinigameBase.SetLaserPositionAndAngle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(side_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDollyX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDollyY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fAngleToFocus, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickIntersect;
    /// <summary>
    /// Function: TickIntersect
    /// </summary>
    public unsafe virtual void TickIntersect(BmSDK.TArray<int> aNodesLeft, BmSDK.TArray<int> aNodesRight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickIntersect, "BmGame.RSpecialMovieInstance_MinigameBase.TickIntersect");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNodesLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNodesRight, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurveData;
    /// <summary>
    /// Function: SetCurveData
    /// </summary>
    public unsafe virtual void SetCurveData(float CurveAngleRange, float CurveAngleMin, float CurveAngleMax, float CurveRadiusHorz, float CurveRadiusVert, float CurveCentreX, float CurveCentreY, float CurveFocusX, float CurveFocusY)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurveData, "BmGame.RSpecialMovieInstance_MinigameBase.SetCurveData");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveAngleRange, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveAngleMin, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveAngleMax, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveRadiusHorz, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveRadiusVert, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveCentreX, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveCentreY, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveFocusX, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveFocusY, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StickStartsOrStopsMoving;
    /// <summary>
    /// Function: StickStartsOrStopsMoving
    /// </summary>
    public unsafe virtual void StickStartsOrStopsMoving(int stick_index, bool is_moving)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StickStartsOrStopsMoving, "BmGame.RSpecialMovieInstance_MinigameBase.StickStartsOrStopsMoving");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stick_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_moving, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MiniGameBarProportion;
    /// <summary>
    /// Function: MiniGameBarProportion
    /// </summary>
    public unsafe virtual void MiniGameBarProportion(float barProportion)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MiniGameBarProportion, "BmGame.RSpecialMovieInstance_MinigameBase.MiniGameBarProportion");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(barProportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MiniGameLost;
    /// <summary>
    /// Function: MiniGameLost
    /// </summary>
    public unsafe virtual void MiniGameLost()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MiniGameLost, "BmGame.RSpecialMovieInstance_MinigameBase.MiniGameLost");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MiniGameWon;
    /// <summary>
    /// Function: MiniGameWon
    /// </summary>
    public unsafe virtual void MiniGameWon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MiniGameWon, "BmGame.RSpecialMovieInstance_MinigameBase.MiniGameWon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCalibrationComplete;
    /// <summary>
    /// Function: PlayCalibrationComplete
    /// </summary>
    public unsafe virtual void PlayCalibrationComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCalibrationComplete, "BmGame.RSpecialMovieInstance_MinigameBase.PlayCalibrationComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WinClearPrompts;
    /// <summary>
    /// Function: WinClearPrompts
    /// </summary>
    public unsafe virtual void WinClearPrompts()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WinClearPrompts, "BmGame.RSpecialMovieInstance_MinigameBase.WinClearPrompts");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AudioParams;
    /// <summary>
    /// Function: AudioParams
    /// </summary>
    public unsafe virtual void AudioParams(float audioSpeedMod, float audioValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioParams, "BmGame.RSpecialMovieInstance_MinigameBase.AudioParams");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(audioSpeedMod, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(audioValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopVoicePlayback;
    /// <summary>
    /// Function: StopVoicePlayback
    /// </summary>
    public unsafe virtual void StopVoicePlayback()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopVoicePlayback, "BmGame.RSpecialMovieInstance_MinigameBase.StopVoicePlayback");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartVoicePlayback;
    /// <summary>
    /// Function: StartVoicePlayback
    /// </summary>
    public unsafe virtual void StartVoicePlayback()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartVoicePlayback, "BmGame.RSpecialMovieInstance_MinigameBase.StartVoicePlayback");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClosingDialogueBoxAfterOutro;
    /// <summary>
    /// Function: ClosingDialogueBoxAfterOutro
    /// </summary>
    public unsafe virtual void ClosingDialogueBoxAfterOutro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClosingDialogueBoxAfterOutro, "BmGame.RSpecialMovieInstance_MinigameBase.ClosingDialogueBoxAfterOutro");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClosingDialogueBoxAfterScan;
    /// <summary>
    /// Function: ClosingDialogueBoxAfterScan
    /// </summary>
    public unsafe virtual void ClosingDialogueBoxAfterScan()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClosingDialogueBoxAfterScan, "BmGame.RSpecialMovieInstance_MinigameBase.ClosingDialogueBoxAfterScan");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClosingDialogueBoxAfterIntro;
    /// <summary>
    /// Function: ClosingDialogueBoxAfterIntro
    /// </summary>
    public unsafe virtual void ClosingDialogueBoxAfterIntro()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClosingDialogueBoxAfterIntro, "BmGame.RSpecialMovieInstance_MinigameBase.ClosingDialogueBoxAfterIntro");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayVoiceNormal;
    /// <summary>
    /// Function: PlayVoiceNormal
    /// </summary>
    public unsafe virtual void PlayVoiceNormal()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayVoiceNormal, "BmGame.RSpecialMovieInstance_MinigameBase.PlayVoiceNormal");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAudio;
    /// <summary>
    /// Function: PlayAudio
    /// </summary>
    public unsafe virtual void PlayAudio()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAudio, "BmGame.RSpecialMovieInstance_MinigameBase.PlayAudio");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: PCLeftThumbVel
    /// </summary>
    public unsafe float PCLeftThumbVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: PCRightThumbVel
    /// </summary>
    public unsafe float PCRightThumbVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: PCLeftThumbPos
    /// </summary>
    public unsafe float PCLeftThumbPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// FloatProperty: PCRightThumbPos
    /// </summary>
    public unsafe float PCRightThumbPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// BoolProperty: GameReady
    /// </summary>
    public unsafe bool GameReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }
}
