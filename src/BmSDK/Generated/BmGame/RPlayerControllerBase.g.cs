#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPlayerControllerBase<br/>
/// (size = 1916)
/// (flags = 144703638)
/// </summary>
public partial class RPlayerControllerBase : BmSDK.Engine.PlayerController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPlayerControllerBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPlayerControllerBase.
    /// </summary>
    public static RPlayerControllerBase DefaultObject => (RPlayerControllerBase)StaticClass().DefaultObject;

    internal RPlayerControllerBase() { }

    /// <summary>
    /// Constructs a new RPlayerControllerBase
    /// </summary>
    public RPlayerControllerBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPlayerControllerBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_LoadingFinished;
    /// <summary>
    /// Function: LoadingFinished
    /// </summary>
    public unsafe void LoadingFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadingFinished, "BmGame.RPlayerControllerBase.LoadingFinished");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadingNearlyFinished;
    /// <summary>
    /// Function: LoadingNearlyFinished
    /// </summary>
    public unsafe virtual void LoadingNearlyFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadingNearlyFinished, "BmGame.RPlayerControllerBase.LoadingNearlyFinished");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheatDown;
    /// <summary>
    /// Function: CheatDown
    /// </summary>
    public unsafe virtual void CheatDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheatDown, "BmGame.RPlayerControllerBase.CheatDown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheatUp;
    /// <summary>
    /// Function: CheatUp
    /// </summary>
    public unsafe virtual void CheatUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheatUp, "BmGame.RPlayerControllerBase.CheatUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheatRight;
    /// <summary>
    /// Function: CheatRight
    /// </summary>
    public unsafe virtual void CheatRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheatRight, "BmGame.RPlayerControllerBase.CheatRight");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheatLeft;
    /// <summary>
    /// Function: CheatLeft
    /// </summary>
    public unsafe virtual void CheatLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheatLeft, "BmGame.RPlayerControllerBase.CheatLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPlayerControllerBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDynamicPostProcess;
    /// <summary>
    /// Function: OnDynamicPostProcess
    /// </summary>
    public unsafe virtual void OnDynamicPostProcess(BmSDK.BmGame.RSeqAct_DynamicPostProcess inAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDynamicPostProcess, "BmGame.RPlayerControllerBase.OnDynamicPostProcess");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RPlayerControllerBase.DrawHUD");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerTick;
    /// <summary>
    /// Function: PlayerTick
    /// </summary>
    public unsafe override void PlayerTick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerTick, "BmGame.RPlayerControllerBase.PlayerTick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableCinematicMode;
    /// <summary>
    /// Function: DisableCinematicMode
    /// </summary>
    public unsafe virtual void DisableCinematicMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableCinematicMode, "BmGame.RPlayerControllerBase.DisableCinematicMode");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSkippedCutscene;
    /// <summary>
    /// Function: OnSkippedCutscene
    /// </summary>
    public unsafe virtual void OnSkippedCutscene()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSkippedCutscene, "BmGame.RPlayerControllerBase.OnSkippedCutscene");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SkipCutscene;
    /// <summary>
    /// Function: SkipCutscene
    /// </summary>
    public unsafe virtual void SkipCutscene(bool bForce = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SkipCutscene, "BmGame.RPlayerControllerBase.SkipCutscene");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InCinematicMode;
    /// <summary>
    /// Function: InCinematicMode
    /// </summary>
    public unsafe virtual bool InCinematicMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InCinematicMode, "BmGame.RPlayerControllerBase.InCinematicMode");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerCauseEvent;
    /// <summary>
    /// Function: ServerCauseEvent
    /// </summary>
    public unsafe override void ServerCauseEvent(BmSDK.FName EventName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerCauseEvent, "BmGame.RPlayerControllerBase.ServerCauseEvent");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleLookInvertControls;
    /// <summary>
    /// Function: ToggleLookInvertControls
    /// </summary>
    public unsafe virtual void ToggleLookInvertControls()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleLookInvertControls, "BmGame.RPlayerControllerBase.ToggleLookInvertControls");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCamNormalSpeed;
    /// <summary>
    /// Function: DebugCamNormalSpeed
    /// </summary>
    public unsafe virtual void DebugCamNormalSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCamNormalSpeed, "BmGame.RPlayerControllerBase.DebugCamNormalSpeed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCamMoreSpeed;
    /// <summary>
    /// Function: DebugCamMoreSpeed
    /// </summary>
    public unsafe virtual void DebugCamMoreSpeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCamMoreSpeed, "BmGame.RPlayerControllerBase.DebugCamMoreSpeed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCamSingleFrameStep;
    /// <summary>
    /// Function: DebugCamSingleFrameStep
    /// </summary>
    public unsafe virtual void DebugCamSingleFrameStep()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCamSingleFrameStep, "BmGame.RPlayerControllerBase.DebugCamSingleFrameStep");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleSpeed;
    /// <summary>
    /// Function: ToggleSpeed
    /// </summary>
    public unsafe virtual void ToggleSpeed(float Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleSpeed, "BmGame.RPlayerControllerBase.ToggleSpeed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickLoad;
    /// <summary>
    /// Function: QuickLoad
    /// </summary>
    public unsafe virtual void QuickLoad()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickLoad, "BmGame.RPlayerControllerBase.QuickLoad");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TTOffset;
    /// <summary>
    /// Function: TTOffset
    /// </summary>
    public unsafe virtual void TTOffset(float O)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TTOffset, "BmGame.RPlayerControllerBase.TTOffset");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ToggleGfx;
    /// <summary>
    /// Function: ToggleGfx
    /// </summary>
    public unsafe virtual void ToggleGfx()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleGfx, "BmGame.RPlayerControllerBase.ToggleGfx");
        byte* paramsPtr = stackalloc byte[0];
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

    private static BmSDK.Function __fn_GPU;
    /// <summary>
    /// Function: GPU
    /// </summary>
    public unsafe virtual void GPU()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GPU, "BmGame.RPlayerControllerBase.GPU");
        byte* paramsPtr = stackalloc byte[0];
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

    private static BmSDK.Function __fn_FlushPressedKeys;
    /// <summary>
    /// Function: FlushPressedKeys
    /// </summary>
    public unsafe virtual void FlushPressedKeys()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushPressedKeys, "BmGame.RPlayerControllerBase.FlushPressedKeys");
        byte* paramsPtr = stackalloc byte[0];
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

    private static BmSDK.Function __fn_ResetPlayerMovementInput;
    /// <summary>
    /// Function: ResetPlayerMovementInput
    /// </summary>
    public unsafe override void ResetPlayerMovementInput()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPlayerMovementInput, "BmGame.RPlayerControllerBase.ResetPlayerMovementInput");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugLevelLoad;
    /// <summary>
    /// Function: DebugLevelLoad
    /// </summary>
    public unsafe virtual void DebugLevelLoad(BmSDK.FString LevelName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugLevelLoad, "BmGame.RPlayerControllerBase.DebugLevelLoad");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuNumber;
    /// <summary>
    /// Function: DebugMenuNumber
    /// </summary>
    public unsafe virtual void DebugMenuNumber(int Num)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuNumber, "BmGame.RPlayerControllerBase.DebugMenuNumber");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Num, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuStepDown;
    /// <summary>
    /// Function: DebugMenuStepDown
    /// </summary>
    public unsafe virtual void DebugMenuStepDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuStepDown, "BmGame.RPlayerControllerBase.DebugMenuStepDown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuStepUp;
    /// <summary>
    /// Function: DebugMenuStepUp
    /// </summary>
    public unsafe virtual void DebugMenuStepUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuStepUp, "BmGame.RPlayerControllerBase.DebugMenuStepUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuDownReleased;
    /// <summary>
    /// Function: DebugMenuDownReleased
    /// </summary>
    public unsafe virtual void DebugMenuDownReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuDownReleased, "BmGame.RPlayerControllerBase.DebugMenuDownReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuDownPressed;
    /// <summary>
    /// Function: DebugMenuDownPressed
    /// </summary>
    public unsafe virtual void DebugMenuDownPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuDownPressed, "BmGame.RPlayerControllerBase.DebugMenuDownPressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuUpReleased;
    /// <summary>
    /// Function: DebugMenuUpReleased
    /// </summary>
    public unsafe virtual void DebugMenuUpReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuUpReleased, "BmGame.RPlayerControllerBase.DebugMenuUpReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuUpPressed;
    /// <summary>
    /// Function: DebugMenuUpPressed
    /// </summary>
    public unsafe virtual void DebugMenuUpPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuUpPressed, "BmGame.RPlayerControllerBase.DebugMenuUpPressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuRightReleased;
    /// <summary>
    /// Function: DebugMenuRightReleased
    /// </summary>
    public unsafe virtual void DebugMenuRightReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuRightReleased, "BmGame.RPlayerControllerBase.DebugMenuRightReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuRightPressed;
    /// <summary>
    /// Function: DebugMenuRightPressed
    /// </summary>
    public unsafe virtual void DebugMenuRightPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuRightPressed, "BmGame.RPlayerControllerBase.DebugMenuRightPressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuLeftReleased;
    /// <summary>
    /// Function: DebugMenuLeftReleased
    /// </summary>
    public unsafe virtual void DebugMenuLeftReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuLeftReleased, "BmGame.RPlayerControllerBase.DebugMenuLeftReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuLeftPressed;
    /// <summary>
    /// Function: DebugMenuLeftPressed
    /// </summary>
    public unsafe virtual void DebugMenuLeftPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuLeftPressed, "BmGame.RPlayerControllerBase.DebugMenuLeftPressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuSelectY;
    /// <summary>
    /// Function: DebugMenuSelectY
    /// </summary>
    public unsafe virtual void DebugMenuSelectY()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuSelectY, "BmGame.RPlayerControllerBase.DebugMenuSelectY");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuSelectX;
    /// <summary>
    /// Function: DebugMenuSelectX
    /// </summary>
    public unsafe virtual void DebugMenuSelectX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuSelectX, "BmGame.RPlayerControllerBase.DebugMenuSelectX");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuSelectB;
    /// <summary>
    /// Function: DebugMenuSelectB
    /// </summary>
    public unsafe virtual void DebugMenuSelectB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuSelectB, "BmGame.RPlayerControllerBase.DebugMenuSelectB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuSelectA;
    /// <summary>
    /// Function: DebugMenuSelectA
    /// </summary>
    public unsafe virtual void DebugMenuSelectA()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuSelectA, "BmGame.RPlayerControllerBase.DebugMenuSelectA");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuNextPage;
    /// <summary>
    /// Function: DebugMenuNextPage
    /// </summary>
    public unsafe virtual void DebugMenuNextPage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuNextPage, "BmGame.RPlayerControllerBase.DebugMenuNextPage");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuPrevPage;
    /// <summary>
    /// Function: DebugMenuPrevPage
    /// </summary>
    public unsafe virtual void DebugMenuPrevPage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuPrevPage, "BmGame.RPlayerControllerBase.DebugMenuPrevPage");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleDebugMenu;
    /// <summary>
    /// Function: ToggleDebugMenu
    /// </summary>
    public unsafe virtual void ToggleDebugMenu()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleDebugMenu, "BmGame.RPlayerControllerBase.ToggleDebugMenu");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuOff;
    /// <summary>
    /// Function: DebugMenuOff
    /// </summary>
    public unsafe virtual void DebugMenuOff()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuOff, "BmGame.RPlayerControllerBase.DebugMenuOff");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuOn;
    /// <summary>
    /// Function: DebugMenuOn
    /// </summary>
    public unsafe virtual void DebugMenuOn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuOn, "BmGame.RPlayerControllerBase.DebugMenuOn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuQualifyOffB;
    /// <summary>
    /// Function: DebugMenuQualifyOffB
    /// </summary>
    public unsafe virtual void DebugMenuQualifyOffB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuQualifyOffB, "BmGame.RPlayerControllerBase.DebugMenuQualifyOffB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuQualifyOnB;
    /// <summary>
    /// Function: DebugMenuQualifyOnB
    /// </summary>
    public unsafe virtual void DebugMenuQualifyOnB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuQualifyOnB, "BmGame.RPlayerControllerBase.DebugMenuQualifyOnB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuQualifyOffT;
    /// <summary>
    /// Function: DebugMenuQualifyOffT
    /// </summary>
    public unsafe virtual void DebugMenuQualifyOffT()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuQualifyOffT, "BmGame.RPlayerControllerBase.DebugMenuQualifyOffT");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugMenuQualifyOnT;
    /// <summary>
    /// Function: DebugMenuQualifyOnT
    /// </summary>
    public unsafe virtual void DebugMenuQualifyOnT()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugMenuQualifyOnT, "BmGame.RPlayerControllerBase.DebugMenuQualifyOnT");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDebugQualifier;
    /// <summary>
    /// Function: IsDebugQualifier
    /// </summary>
    public unsafe virtual bool IsDebugQualifier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDebugQualifier, "BmGame.RPlayerControllerBase.IsDebugQualifier");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: ActiveMenu
    /// </summary>
    public unsafe BmSDK.BmGame.RDynamicMenu ActiveMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDynamicMenu>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// ObjectProperty: StoredMenu
    /// </summary>
    public unsafe BmSDK.BmGame.RDynamicMenu StoredMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDynamicMenu>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ObjectProperty: DebugMenu
    /// </summary>
    public unsafe BmSDK.BmGame.RDebugMenu DebugMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDebugMenu>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// ObjectProperty: StoredPawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn StoredPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ObjectProperty: ActiveCinematicMode
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_CinematicMode ActiveCinematicMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_CinematicMode>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// ClassProperty: DebugMenuClass
    /// </summary>
    public unsafe BmSDK.Class DebugMenuClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// IntProperty: bSpectatorStepFrame
    /// </summary>
    public unsafe int bSpectatorStepFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bUnpauseOnGPUProfileExit
    /// </summary>
    public unsafe bool bUnpauseOnGPUProfileExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// BoolProperty: bShowSurfaceTypes
    /// </summary>
    public unsafe bool bShowSurfaceTypes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// BoolProperty: bCauseEventSkipCutscene
    /// </summary>
    public unsafe bool bCauseEventSkipCutscene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// BoolProperty: bInBink
    /// </summary>
    public unsafe bool bInBink
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// BoolProperty: PersistentCinematicModeHudSuppression
    /// </summary>
    public unsafe bool PersistentCinematicModeHudSuppression
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// BoolProperty: LastCinematicModeHidHud
    /// </summary>
    public unsafe bool LastCinematicModeHidHud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// BoolProperty: IsLoadingFinished
    /// </summary>
    public unsafe bool IsLoadingFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// BoolProperty: DebugMenuQualifierT
    /// </summary>
    public unsafe bool DebugMenuQualifierT
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// BoolProperty: DebugMenuQualifierB
    /// </summary>
    public unsafe bool DebugMenuQualifierB
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1896); }
    }

    /// <summary>
    /// ArrayProperty: DebugActiveCinematicModes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DebugActiveCinematicModes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }
}
