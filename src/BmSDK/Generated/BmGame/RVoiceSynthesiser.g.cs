#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RVoiceSynthesiser<br/>
/// (size = 2625)
/// (flags = 144703667)
/// </summary>
public partial class RVoiceSynthesiser : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVoiceSynthesiser", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RVoiceSynthesiser.
    /// </summary>
    public static RVoiceSynthesiser DefaultObject => (RVoiceSynthesiser)StaticClass().DefaultObject;

    internal RVoiceSynthesiser() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVoiceSynthesiser(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVoiceSynthesiser>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVoiceSynthesiser>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVoiceSynthesiser>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVoiceSynthesiser>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVoiceSynthesiser>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVoiceSynthesiser>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVoiceSynthesiser>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVoiceSynthesiser>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DontDisplayFailIcon;
    /// <summary>
    /// Function: DontDisplayFailIcon
    /// </summary>
    public unsafe virtual void DontDisplayFailIcon()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DontDisplayFailIcon, "BmGame.RVoiceSynthesiser.DontDisplayFailIcon");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetForChallenge;
    /// <summary>
    /// Function: ResetForChallenge
    /// </summary>
    public unsafe override void ResetForChallenge(bool bChallengeStarted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetForChallenge, "BmGame.RVoiceSynthesiser.ResetForChallenge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChallengeStarted, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PerformVoiceSynthesiserFloorTrace;
    /// <summary>
    /// Function: PerformVoiceSynthesiserFloorTrace
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor PerformVoiceSynthesiserFloorTrace(out System.Numerics.Vector3 vHitLocation, out System.Numerics.Vector3 vHitNormal, System.Numerics.Vector3 vCheckEnd, System.Numerics.Vector3 vCheckStart, BmSDK.Component.ECollisionFilter TraceCollisionFilter, System.Numerics.Vector3 vCheckExtent, out BmSDK.Engine.Actor.FTraceHitInfo MyHitInfo, int iTraceFlags)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PerformVoiceSynthesiserFloorTrace, "BmGame.RVoiceSynthesiser.PerformVoiceSynthesiserFloorTrace");
        byte* paramsPtr = stackalloc byte[116];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out vHitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vHitLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out vHitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vHitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vCheckEnd, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vCheckStart, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceCollisionFilter, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vCheckExtent, paramsPtr + 52);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MyHitInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MyHitInfo, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iTraceFlags, paramsPtr + 104);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        vHitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        vHitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        MyHitInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FTraceHitInfo>(paramsPtr + 64);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 108);
    }

    private static BmSDK.Function __fn_AllowHighlightToBeHidden;
    /// <summary>
    /// Function: AllowHighlightToBeHidden
    /// </summary>
    public unsafe override bool AllowHighlightToBeHidden(BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CheckHighlightedMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowHighlightToBeHidden, "BmGame.RVoiceSynthesiser.AllowHighlightToBeHidden");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckHighlightedMesh, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_GetCorrectMIC;
    /// <summary>
    /// Function: GetCorrectMIC
    /// </summary>
    public unsafe override BmSDK.Engine.MaterialInterface GetCorrectMIC(BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType TargetType, bool bShotByDisruptor, bool bSniperHasAmmoLeft, bool bWeaponReadyToExplode, bool bUpgradeNeeded, bool bNormalViewMode, bool bForCamouflageThug, bool bSpecialTrackerTarget, bool bCurrentTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCorrectMIC, "BmGame.RVoiceSynthesiser.GetCorrectMIC");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShotByDisruptor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSniperHasAmmoLeft, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWeaponReadyToExplode, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUpgradeNeeded, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNormalViewMode, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForCamouflageThug, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialTrackerTarget, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCurrentTarget, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.MaterialInterface>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_PrimedUpdateIndividualTargetHighlight;
    /// <summary>
    /// Function: PrimedUpdateIndividualTargetHighlight
    /// </summary>
    public unsafe override void PrimedUpdateIndividualTargetHighlight(BmSDK.Engine.Actor CheckTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrimedUpdateIndividualTargetHighlight, "BmGame.RVoiceSynthesiser.PrimedUpdateIndividualTargetHighlight");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckTarget, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PrimedUpdateHighlights;
    /// <summary>
    /// Function: PrimedUpdateHighlights
    /// </summary>
    public unsafe override void PrimedUpdateHighlights()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrimedUpdateHighlights, "BmGame.RVoiceSynthesiser.PrimedUpdateHighlights");
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

    private static BmSDK.Function __fn_GetPotentialTargetPositions;
    /// <summary>
    /// Function: GetPotentialTargetPositions
    /// </summary>
    public unsafe override bool GetPotentialTargetPositions(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 InTargetPosition, out BmSDK.TArray<System.Numerics.Vector3> PotentialTargetPositions, out BmSDK.Engine.Actor LineCheckActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPotentialTargetPositions, "BmGame.RVoiceSynthesiser.GetPotentialTargetPositions");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InTargetPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTargetPosition, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LineCheckActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineCheckActor, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InTargetPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        PotentialTargetPositions = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 20);
        LineCheckActor = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RVoiceSynthesiser.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForPylon;
    /// <summary>
    /// Function: CheckForPylon
    /// </summary>
    public unsafe virtual BmSDK.Engine.Pylon CheckForPylon(System.Numerics.Vector3 CheckLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForPylon, "BmGame.RVoiceSynthesiser.CheckForPylon");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Pylon>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetNormalDisplayState;
    /// <summary>
    /// Function: SetNormalDisplayState
    /// </summary>
    public unsafe virtual void SetNormalDisplayState(BmSDK.BmGame.RVoiceSynthesiser.EVoiceSynthesiserScreenState NewScreenState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNormalDisplayState, "BmGame.RVoiceSynthesiser.SetNormalDisplayState");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScreenState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetNormalDisplay;
    /// <summary>
    /// Function: ResetNormalDisplay
    /// </summary>
    public unsafe virtual void ResetNormalDisplay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetNormalDisplay, "BmGame.RVoiceSynthesiser.ResetNormalDisplay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartNormalDisplay;
    /// <summary>
    /// Function: StartNormalDisplay
    /// </summary>
    public unsafe virtual void StartNormalDisplay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNormalDisplay, "BmGame.RVoiceSynthesiser.StartNormalDisplay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetCalibrationDisplay;
    /// <summary>
    /// Function: ResetCalibrationDisplay
    /// </summary>
    public unsafe virtual void ResetCalibrationDisplay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCalibrationDisplay, "BmGame.RVoiceSynthesiser.ResetCalibrationDisplay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCalibrationDisplay;
    /// <summary>
    /// Function: StartCalibrationDisplay
    /// </summary>
    public unsafe virtual void StartCalibrationDisplay(BmSDK.GFxUI.SwfMovie CalibrationSWF, BmSDK.Engine.TextureRenderTarget2D CalibrationRenderTexture)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCalibrationDisplay, "BmGame.RVoiceSynthesiser.StartCalibrationDisplay");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CalibrationSWF, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CalibrationRenderTexture, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetRechargeTime;
    /// <summary>
    /// Function: ResetRechargeTime
    /// </summary>
    public unsafe virtual void ResetRechargeTime()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetRechargeTime, "BmGame.RVoiceSynthesiser.ResetRechargeTime");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe override void OnRoomChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.RVoiceSynthesiser.OnRoomChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnequipSelf;
    /// <summary>
    /// Function: UnequipSelf
    /// </summary>
    public unsafe override bool UnequipSelf()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipSelf, "BmGame.RVoiceSynthesiser.UnequipSelf");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_KillStartupBeams;
    /// <summary>
    /// Function: KillStartupBeams
    /// </summary>
    public unsafe virtual void KillStartupBeams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillStartupBeams, "BmGame.RVoiceSynthesiser.KillStartupBeams");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateStartupBeams;
    /// <summary>
    /// Function: UpdateStartupBeams
    /// </summary>
    public unsafe virtual void UpdateStartupBeams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStartupBeams, "BmGame.RVoiceSynthesiser.UpdateStartupBeams");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateStartupBeams;
    /// <summary>
    /// Function: CreateStartupBeams
    /// </summary>
    public unsafe virtual void CreateStartupBeams(BmSDK.TArray<BmSDK.Engine.Actor> Targets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateStartupBeams, "BmGame.RVoiceSynthesiser.CreateStartupBeams");
        byte* paramsPtr = stackalloc byte[25];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Targets, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartStartupBeams;
    /// <summary>
    /// Function: StartStartupBeams
    /// </summary>
    public unsafe virtual void StartStartupBeams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartStartupBeams, "BmGame.RVoiceSynthesiser.StartStartupBeams");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffThugDestinationBeams;
    /// <summary>
    /// Function: TurnOffThugDestinationBeams
    /// </summary>
    public unsafe virtual void TurnOffThugDestinationBeams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffThugDestinationBeams, "BmGame.RVoiceSynthesiser.TurnOffThugDestinationBeams");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnAndUpdateThugDestinationBeams;
    /// <summary>
    /// Function: TurnOnAndUpdateThugDestinationBeams
    /// </summary>
    public unsafe virtual void TurnOnAndUpdateThugDestinationBeams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnAndUpdateThugDestinationBeams, "BmGame.RVoiceSynthesiser.TurnOnAndUpdateThugDestinationBeams");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectStartLocationOfThugDestinationBeam;
    /// <summary>
    /// Function: SelectStartLocationOfThugDestinationBeam
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 SelectStartLocationOfThugDestinationBeam(BmSDK.BmGame.RPawnVillain Thug, System.Numerics.Vector3 vTargetLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectStartLocationOfThugDestinationBeam, "BmGame.RVoiceSynthesiser.SelectStartLocationOfThugDestinationBeam");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thug, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vTargetLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_TurnOffThugSelectionBoxes;
    /// <summary>
    /// Function: TurnOffThugSelectionBoxes
    /// </summary>
    public unsafe virtual void TurnOffThugSelectionBoxes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffThugSelectionBoxes, "BmGame.RVoiceSynthesiser.TurnOffThugSelectionBoxes");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnAndUpdateThugSelectionBoxes;
    /// <summary>
    /// Function: TurnOnAndUpdateThugSelectionBoxes
    /// </summary>
    public unsafe virtual void TurnOnAndUpdateThugSelectionBoxes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnAndUpdateThugSelectionBoxes, "BmGame.RVoiceSynthesiser.TurnOnAndUpdateThugSelectionBoxes");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveLockedVillain;
    /// <summary>
    /// Function: RemoveLockedVillain
    /// </summary>
    public unsafe virtual void RemoveLockedVillain(BmSDK.BmGame.RPawnVillain OldThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveLockedVillain, "BmGame.RVoiceSynthesiser.RemoveLockedVillain");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddNewLockedVillain;
    /// <summary>
    /// Function: AddNewLockedVillain
    /// </summary>
    public unsafe virtual void AddNewLockedVillain(BmSDK.BmGame.RPawnVillain NewThug)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNewLockedVillain, "BmGame.RVoiceSynthesiser.AddNewLockedVillain");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearTargetList;
    /// <summary>
    /// Function: ClearTargetList
    /// </summary>
    public unsafe virtual void ClearTargetList()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearTargetList, "BmGame.RVoiceSynthesiser.ClearTargetList");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetNumberOfStrikes;
    /// <summary>
    /// Function: ResetNumberOfStrikes
    /// </summary>
    public unsafe virtual void ResetNumberOfStrikes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetNumberOfStrikes, "BmGame.RVoiceSynthesiser.ResetNumberOfStrikes");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForExplosiveGelledWeakWallTakedown;
    /// <summary>
    /// Function: CheckForExplosiveGelledWeakWallTakedown
    /// </summary>
    public unsafe virtual void CheckForExplosiveGelledWeakWallTakedown(BmSDK.BmGame.RPawnVillain GelTargetPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForExplosiveGelledWeakWallTakedown, "BmGame.RVoiceSynthesiser.CheckForExplosiveGelledWeakWallTakedown");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GelTargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPawnDied;
    /// <summary>
    /// Function: NotifyPawnDied
    /// </summary>
    public unsafe virtual void NotifyPawnDied(BmSDK.BmGame.RPawnVillain DeadPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPawnDied, "BmGame.RVoiceSynthesiser.NotifyPawnDied");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindFakeTacticianEvent;
    /// <summary>
    /// Function: FindFakeTacticianEvent
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSeqEvent_FakeTacticianOrder FindFakeTacticianEvent(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindFakeTacticianEvent, "BmGame.RVoiceSynthesiser.FindFakeTacticianEvent");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSeqEvent_FakeTacticianOrder>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GiveFakeTacticianOrders;
    /// <summary>
    /// Function: GiveFakeTacticianOrders
    /// </summary>
    public unsafe virtual void GiveFakeTacticianOrders()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveFakeTacticianOrders, "BmGame.RVoiceSynthesiser.GiveFakeTacticianOrders");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInvalidIconString;
    /// <summary>
    /// Function: GetInvalidIconString
    /// </summary>
    public unsafe virtual BmSDK.FString GetInvalidIconString()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInvalidIconString, "BmGame.RVoiceSynthesiser.GetInvalidIconString");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGoodIconString;
    /// <summary>
    /// Function: GetGoodIconString
    /// </summary>
    public unsafe virtual BmSDK.FString GetGoodIconString()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGoodIconString, "BmGame.RVoiceSynthesiser.GetGoodIconString");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GoodIntroIconTimer;
    /// <summary>
    /// Function: GoodIntroIconTimer
    /// </summary>
    public unsafe virtual void GoodIntroIconTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoodIntroIconTimer, "BmGame.RVoiceSynthesiser.GoodIntroIconTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGoodIntroIconBeingDisplayed;
    /// <summary>
    /// Function: IsGoodIntroIconBeingDisplayed
    /// </summary>
    public unsafe virtual bool IsGoodIntroIconBeingDisplayed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGoodIntroIconBeingDisplayed, "BmGame.RVoiceSynthesiser.IsGoodIntroIconBeingDisplayed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SuccessIconTimer;
    /// <summary>
    /// Function: SuccessIconTimer
    /// </summary>
    public unsafe virtual void SuccessIconTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessIconTimer, "BmGame.RVoiceSynthesiser.SuccessIconTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsSuccessIconBeingDisplayed;
    /// <summary>
    /// Function: IsSuccessIconBeingDisplayed
    /// </summary>
    public unsafe virtual bool IsSuccessIconBeingDisplayed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSuccessIconBeingDisplayed, "BmGame.RVoiceSynthesiser.IsSuccessIconBeingDisplayed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FailIconTimer;
    /// <summary>
    /// Function: FailIconTimer
    /// </summary>
    public unsafe virtual void FailIconTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FailIconTimer, "BmGame.RVoiceSynthesiser.FailIconTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFailIconBeingDisplayed;
    /// <summary>
    /// Function: IsFailIconBeingDisplayed
    /// </summary>
    public unsafe virtual bool IsFailIconBeingDisplayed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFailIconBeingDisplayed, "BmGame.RVoiceSynthesiser.IsFailIconBeingDisplayed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawTargets;
    /// <summary>
    /// Function: DrawTargets
    /// </summary>
    public unsafe virtual void DrawTargets(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTargets, "BmGame.RVoiceSynthesiser.DrawTargets");
        byte* paramsPtr = stackalloc byte[77];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaceFakePredThugTarget;
    /// <summary>
    /// Function: PlaceFakePredThugTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor PlaceFakePredThugTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaceFakePredThugTarget, "BmGame.RVoiceSynthesiser.PlaceFakePredThugTarget");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGadgetCamera;
    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe override BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetCamera, "BmGame.RVoiceSynthesiser.GetGadgetCamera");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPrimedPose;
    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe override BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState, out BmSDK.FName OutCapeTransitionState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmGame.RVoiceSynthesiser.GetPrimedPose");
        byte* paramsPtr = stackalloc byte[36];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StanceIsCrouched);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StanceIsCrouched, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MirroredNess);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredNess, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeState, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeTransitionState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeTransitionState, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        OutCapeTransitionState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override bool GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RVoiceSynthesiser.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetLethalTrapType;
    /// <summary>
    /// Function: GetLethalTrapType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMRoomAIState.VoiceSynthesiserLethalTrap GetLethalTrapType(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLethalTrapType, "BmGame.RVoiceSynthesiser.GetLethalTrapType");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMRoomAIState.VoiceSynthesiserLethalTrap>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsTargetAnObjectThatAThugCanInteractWith;
    /// <summary>
    /// Function: IsTargetAnObjectThatAThugCanInteractWith
    /// </summary>
    public unsafe virtual bool IsTargetAnObjectThatAThugCanInteractWith(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTargetAnObjectThatAThugCanInteractWith, "BmGame.RVoiceSynthesiser.IsTargetAnObjectThatAThugCanInteractWith");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanFakePredatorBroadcast;
    /// <summary>
    /// Function: CanFakePredatorBroadcast
    /// </summary>
    public unsafe virtual bool CanFakePredatorBroadcast()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanFakePredatorBroadcast, "BmGame.RVoiceSynthesiser.CanFakePredatorBroadcast");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFiringAnimationOverlay;
    /// <summary>
    /// Function: GetFiringAnimationOverlay
    /// </summary>
    public unsafe virtual BmSDK.FName GetFiringAnimationOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFiringAnimationOverlay, "BmGame.RVoiceSynthesiser.GetFiringAnimationOverlay");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Fire;
    /// <summary>
    /// Function: Fire
    /// </summary>
    public unsafe virtual void Fire(bool bSecondary = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Fire, "BmGame.RVoiceSynthesiser.Fire");
        byte* paramsPtr = stackalloc byte[65];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSecondary, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCommanderIsStillTalkingGadgetThought;
    /// <summary>
    /// Function: PlayCommanderIsStillTalkingGadgetThought
    /// </summary>
    public unsafe virtual void PlayCommanderIsStillTalkingGadgetThought(BmSDK.BmGame.RBMRoomAIState RoomState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCommanderIsStillTalkingGadgetThought, "BmGame.RVoiceSynthesiser.PlayCommanderIsStillTalkingGadgetThought");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoomState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayVoiceSynthesiserHasBeenDisabledGadgetThought;
    /// <summary>
    /// Function: PlayVoiceSynthesiserHasBeenDisabledGadgetThought
    /// </summary>
    public unsafe virtual void PlayVoiceSynthesiserHasBeenDisabledGadgetThought(BmSDK.BmGame.RBMRoomAIState RoomState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayVoiceSynthesiserHasBeenDisabledGadgetThought, "BmGame.RVoiceSynthesiser.PlayVoiceSynthesiserHasBeenDisabledGadgetThought");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoomState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRoomCommanderSpeaking;
    /// <summary>
    /// Function: IsRoomCommanderSpeaking
    /// </summary>
    public unsafe virtual bool IsRoomCommanderSpeaking(BmSDK.BmGame.RJokerTannoy Tannoy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRoomCommanderSpeaking, "BmGame.RVoiceSynthesiser.IsRoomCommanderSpeaking");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tannoy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindProhibitedEvent;
    /// <summary>
    /// Function: FindProhibitedEvent
    /// </summary>
    public unsafe virtual bool FindProhibitedEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindProhibitedEvent, "BmGame.RVoiceSynthesiser.FindProhibitedEvent");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasCustomSynthEvent;
    /// <summary>
    /// Function: HasCustomSynthEvent
    /// </summary>
    public unsafe virtual bool HasCustomSynthEvent(BmSDK.Engine.Actor TestActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasCustomSynthEvent, "BmGame.RVoiceSynthesiser.HasCustomSynthEvent");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetThugInvestigateLocationForTarget;
    /// <summary>
    /// Function: GetThugInvestigateLocationForTarget
    /// </summary>
    public unsafe virtual void GetThugInvestigateLocationForTarget(BmSDK.Engine.Actor Target, out BmSDK.TArray<System.Numerics.Vector3> vInvestigateLocations)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThugInvestigateLocationForTarget, "BmGame.RVoiceSynthesiser.GetThugInvestigateLocationForTarget");
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        vInvestigateLocations = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GetTargetMarkerLocationForTarget;
    /// <summary>
    /// Function: GetTargetMarkerLocationForTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetTargetMarkerLocationForTarget(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetMarkerLocationForTarget, "BmGame.RVoiceSynthesiser.GetTargetMarkerLocationForTarget");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_WhichThugIsPlayerAimingAt;
    /// <summary>
    /// Function: WhichThugIsPlayerAimingAt
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain WhichThugIsPlayerAimingAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WhichThugIsPlayerAimingAt, "BmGame.RVoiceSynthesiser.WhichThugIsPlayerAimingAt");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe override bool CheckAutoTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange, out byte DoLOSCheck)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmGame.RVoiceSynthesiser.CheckAutoTarget");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TargetPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverridePriority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridePriority, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverrideMaxRange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaxRange, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DoLOSCheck);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoLOSCheck, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TargetPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        OverrideMaxRange = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        DoLOSCheck = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_InitGoalDataInstance;
    /// <summary>
    /// Function: InitGoalDataInstance
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RMultiDestGoalData InitGoalDataInstance(BmSDK.TArray<System.Numerics.Vector3> vPotentialDestinations)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitGoalDataInstance, "BmGame.RVoiceSynthesiser.InitGoalDataInstance");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vPotentialDestinations, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RMultiDestGoalData>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UpdateTarget;
    /// <summary>
    /// Function: UpdateTarget
    /// </summary>
    public unsafe virtual void UpdateTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTarget, "BmGame.RVoiceSynthesiser.UpdateTarget");
        byte* paramsPtr = stackalloc byte[232];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanControlTarget;
    /// <summary>
    /// Function: CanControlTarget
    /// </summary>
    public unsafe virtual bool CanControlTarget(BmSDK.BmGame.RPawnVillain TestTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanControlTarget, "BmGame.RVoiceSynthesiser.CanControlTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RVoiceSynthesiser.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EVoiceSynthesiserScreenState
    /// </summary>
    public enum EVoiceSynthesiserScreenState : byte
    {
        VSSS_None = 0,
        VSSS_Idle = 1,
        VSSS_ValidThugTarget = 2,
        VSSS_ValidInvestigationTarget = 3,
        VSSS_UnableToUse = 4,
        VSSS_MAX = 5,
    }

    /// <summary>
    /// ArrayProperty: LockedPredatorTargetList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVoiceSynthesiser.FVoiceSynthTargetStruct> LockedPredatorTargetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVoiceSynthesiser.FVoiceSynthTargetStruct>>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// ObjectProperty: LockedTargetFakeTacticianEvent
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqEvent_FakeTacticianOrder LockedTargetFakeTacticianEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqEvent_FakeTacticianOrder>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// ObjectProperty: FakeTacticianVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RFakeTacticianVolume FakeTacticianVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFakeTacticianVolume>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTargetWhileRecharging
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentTargetWhileRecharging
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// ObjectProperty: LastThugToReceiveAnOrder
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastThugToReceiveAnOrder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// ObjectProperty: FakeTargetThug
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain FakeTargetThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ObjectProperty: FindTargetPathHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle FindTargetPathHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// ObjectProperty: FindTargetGoalData
    /// </summary>
    public unsafe BmSDK.BmGame.RMultiDestGoalData FindTargetGoalData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMultiDestGoalData>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ObjectProperty: DisableIdleConfigThugSequenceAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_DisableVoiceSynthesiserOnIdleConfigThug DisableIdleConfigThugSequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_DisableVoiceSynthesiserOnIdleConfigThug>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: DummyAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_SonicBatarang DummyAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_SonicBatarang>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ObjectProperty: RestrictedTargetsSequenceAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_RestrictVoiceSynthesiserTargets RestrictedTargetsSequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_RestrictVoiceSynthesiserTargets>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ObjectProperty: VoiceSynthesiserIsStillRechargingThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech VoiceSynthesiserIsStillRechargingThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// ObjectProperty: ThugIsTooBusyThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ThugIsTooBusyThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// ObjectProperty: ThugIsChasingBatmanThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ThugIsChasingBatmanThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ObjectProperty: NeedToSelectThugTargetThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech NeedToSelectThugTargetThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// ObjectProperty: TargetIsNotValidThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech TargetIsNotValidThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// ObjectProperty: TargetIsNotReachableThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech TargetIsNotReachableThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }

    /// <summary>
    /// ObjectProperty: ThugIsNotWearingHeadsetThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ThugIsNotWearingHeadsetThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// ObjectProperty: RobotIsRiddlerControlledThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech RobotIsRiddlerControlledThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// ObjectProperty: ArkhamKnightHasDisabledVoiceSynthesiserThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ArkhamKnightHasDisabledVoiceSynthesiserThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// ObjectProperty: HarleyQuinnHasDisabledVoiceSynthesiserThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech HarleyQuinnHasDisabledVoiceSynthesiserThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// ObjectProperty: ScarecrowHasDisabledVoiceSynthesiserThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ScarecrowHasDisabledVoiceSynthesiserThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// ObjectProperty: DeathstrokeHasDisabledVoiceSynthesiserThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech DeathstrokeHasDisabledVoiceSynthesiserThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// ObjectProperty: RandomThugDudeHasDisabledVoiceSynthesiserThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech RandomThugDudeHasDisabledVoiceSynthesiserThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// ObjectProperty: CommanderIsInSameRoomThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CommanderIsInSameRoomThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// ObjectProperty: ArkhamKnightIsCurrentlyTalkingThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ArkhamKnightIsCurrentlyTalkingThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// ObjectProperty: HarleyQuinnIsCurrentlyTalkingThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech HarleyQuinnIsCurrentlyTalkingThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// ObjectProperty: DeathstrokeIsCurrentlyTalkingThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech DeathstrokeIsCurrentlyTalkingThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: ThugsAreWaryOfTargetThought
    /// </summary>
    public InlineArray<BmSDK.Engine.AkDialogueSpeech> ThugsAreWaryOfTargetThought => new(6, Ptr + 2308, 8, this);

    /// <summary>
    /// ObjectProperty: ThugsAreWaryOfTargetThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ThugsAreWaryOfTargetThought_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }
    /// <summary>
    /// ObjectProperty: ThugsAreWaryOfTargetThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ThugsAreWaryOfTargetThought_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }
    /// <summary>
    /// ObjectProperty: ThugsAreWaryOfTargetThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ThugsAreWaryOfTargetThought_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }
    /// <summary>
    /// ObjectProperty: ThugsAreWaryOfTargetThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ThugsAreWaryOfTargetThought_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }
    /// <summary>
    /// ObjectProperty: ThugsAreWaryOfTargetThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ThugsAreWaryOfTargetThought_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }
    /// <summary>
    /// ObjectProperty: ThugsAreWaryOfTargetThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech ThugsAreWaryOfTargetThought_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// ObjectProperty: TargetDestinationSelectedSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TargetDestinationSelectedSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2356); }
    }

    /// <summary>
    /// ObjectProperty: RobotTargetDestinationSelectedSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RobotTargetDestinationSelectedSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// ObjectProperty: TargetOnFocusSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TargetOnFocusSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// ObjectProperty: TargetSelectedSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TargetSelectedSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// ObjectProperty: TargetDeselectedSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TargetDeselectedSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// ObjectProperty: EventCoordinatorInvestigatingTargetMarkerVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem EventCoordinatorInvestigatingTargetMarkerVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// ObjectProperty: EventCoordinatorInvestigatingBeamVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem EventCoordinatorInvestigatingBeamVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// ObjectProperty: EventCoordinatorInvestigatingSelectedPawnVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem EventCoordinatorInvestigatingSelectedPawnVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// ObjectProperty: CurrentlyInvestigatingBeamVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem CurrentlyInvestigatingBeamVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// ObjectProperty: CurrentlyInvestigatingSelectedPawnVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem CurrentlyInvestigatingSelectedPawnVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// ObjectProperty: StartupBeamVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem StartupBeamVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// ObjectProperty: TargetHighlightMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant TargetHighlightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// ObjectProperty: ScreenMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ScreenMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// ObjectProperty: NormalScreenRenderTexture
    /// </summary>
    public unsafe BmSDK.Engine.TextureRenderTarget2D NormalScreenRenderTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TextureRenderTarget2D>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// ObjectProperty: NormalScreenGFxMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovie NormalScreenGFxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovie>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// ObjectProperty: NormalScreenSWF
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie NormalScreenSWF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// ObjectProperty: CalibrationScreenGFxMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovie CalibrationScreenGFxMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovie>(Ptr + 2484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2484); }
    }

    /// <summary>
    /// ComponentProperty: DecidingLocationTargetMarkerVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DecidingLocationTargetMarkerVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// ArrayProperty: SecondaryTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> SecondaryTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }

    /// <summary>
    /// StructProperty: vSuccessfulOrderTargetLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vSuccessfulOrderTargetLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2516);

    /// <summary>
    /// BoolProperty: bPlacedFakeTarget
    /// </summary>
    public unsafe bool bPlacedFakeTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2528); }
    }

    /// <summary>
    /// BoolProperty: bLastTargetPathSearchWasSuccessful
    /// </summary>
    public unsafe bool bLastTargetPathSearchWasSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2528); }
    }

    /// <summary>
    /// BoolProperty: bLastTargetLocationWasCompletelyInvalid
    /// </summary>
    public unsafe bool bLastTargetLocationWasCompletelyInvalid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2528); }
    }

    /// <summary>
    /// BoolProperty: bPathingToNewInteractiveObject
    /// </summary>
    public unsafe bool bPathingToNewInteractiveObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2528); }
    }

    /// <summary>
    /// BoolProperty: bTargetGroundCheckOk
    /// </summary>
    public unsafe bool bTargetGroundCheckOk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2528); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasSynthesisedRobotSpeech
    /// </summary>
    public unsafe bool bBatmanHasSynthesisedRobotSpeech
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2528); }
    }

    /// <summary>
    /// BoolProperty: bStartupBeamsShouldBeDisplayed
    /// </summary>
    public unsafe bool bStartupBeamsShouldBeDisplayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2528); }
    }

    /// <summary>
    /// BoolProperty: bStartupBeamArrayHasBeenInitialised
    /// </summary>
    public unsafe bool bStartupBeamArrayHasBeenInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2528); }
    }

    /// <summary>
    /// BoolProperty: bSecondaryTargetsShouldBeDisplayed
    /// </summary>
    public unsafe bool bSecondaryTargetsShouldBeDisplayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2528); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2528); }
    }

    /// <summary>
    /// StructProperty: FakeTargetLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FakeTargetLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2532);

    /// <summary>
    /// StructProperty: GroundLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GroundLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2544);

    /// <summary>
    /// StructProperty: GroundNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GroundNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2556);

    /// <summary>
    /// StructProperty: vInteractiveTargetThugInvestigateLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vInteractiveTargetThugInvestigateLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2568);

    /// <summary>
    /// FloatProperty: fMaximumVoiceLockInteractionDistanceSquared
    /// </summary>
    public unsafe float fMaximumVoiceLockInteractionDistanceSquared
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// IntProperty: iMaximumNumberOfStartupBeams
    /// </summary>
    public unsafe int iMaximumNumberOfStartupBeams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// ArrayProperty: StartupBeams
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVoiceSynthesiser.FVoiceSynthTargetStruct> StartupBeams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVoiceSynthesiser.FVoiceSynthTargetStruct>>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// FloatProperty: fExtendedCooldownTime
    /// </summary>
    public unsafe float fExtendedCooldownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// IntProperty: iMaximumNumberOfStrikesBeforeExtendedCooldown
    /// </summary>
    public unsafe int iMaximumNumberOfStrikesBeforeExtendedCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// IntProperty: iCurrentNumberOfStrikes
    /// </summary>
    public unsafe int iCurrentNumberOfStrikes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// FloatProperty: fDelayAfterWhichATakedownWillNotBeAStrike
    /// </summary>
    public unsafe float fDelayAfterWhichATakedownWillNotBeAStrike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// FloatProperty: fLastThugReactionRunningTime
    /// </summary>
    public unsafe float fLastThugReactionRunningTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// ByteProperty: eCurrentScreenState
    /// </summary>
    public unsafe BmSDK.BmGame.RVoiceSynthesiser.EVoiceSynthesiserScreenState eCurrentScreenState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVoiceSynthesiser.EVoiceSynthesiserScreenState>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// Struct: FVoiceSynthTargetStruct
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FVoiceSynthTargetStruct
    {
        /// <summary>
        /// ComponentProperty: Beam
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent Beam
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ComponentProperty: Box
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent Box
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: Villain
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnVillain Villain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: Target
        /// </summary>
        public unsafe BmSDK.Engine.Actor Target
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bCurrentlyTargetted
        /// </summary>
        public unsafe bool bCurrentlyTargetted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }
    }
}
