#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RCommandBeaconBase<br/>
/// (size = 1192)
/// (flags = 144703635)
/// </summary>
public partial class RCommandBeaconBase : BmSDK.BmGame.RSpecialMoveEnvironmentObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCommandBeaconBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCommandBeaconBase.
    /// </summary>
    public static RCommandBeaconBase DefaultObject => (RCommandBeaconBase)StaticClass().DefaultObject;

    internal RCommandBeaconBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCommandBeaconBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetWinchingAllowed;
    /// <summary>
    /// Function: SetWinchingAllowed
    /// </summary>
    public unsafe virtual void SetWinchingAllowed(bool bAllowed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWinchingAllowed, "BmGame.RCommandBeaconBase.SetWinchingAllowed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamageFromWeapon;
    /// <summary>
    /// Function: TakeDamageFromWeapon
    /// </summary>
    public unsafe override BmSDK.Engine.Actor.EWeaponDamageResult TakeDamageFromWeapon(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default, bool bHeadShot = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamageFromWeapon, "BmGame.RCommandBeaconBase.TakeDamageFromWeapon");
        byte* paramsPtr = stackalloc byte[109];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHeadShot, paramsPtr + 104);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 108);
    }

    private static BmSDK.Function __fn_AllowLongRangeTargeting;
    /// <summary>
    /// Function: AllowLongRangeTargeting
    /// </summary>
    public unsafe virtual bool AllowLongRangeTargeting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowLongRangeTargeting, "BmGame.RCommandBeaconBase.AllowLongRangeTargeting");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsGenerator;
    /// <summary>
    /// Function: IsGenerator
    /// </summary>
    public unsafe virtual bool IsGenerator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGenerator, "BmGame.RCommandBeaconBase.IsGenerator");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ApplyRevs;
    /// <summary>
    /// Function: ApplyRevs
    /// </summary>
    public unsafe virtual void ApplyRevs(float Revs, BmSDK.BmGame.RPlayerController Controller)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyRevs, "BmGame.RCommandBeaconBase.ApplyRevs");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Revs, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Controller, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRevsMaxDelta;
    /// <summary>
    /// Function: GetRevsMaxDelta
    /// </summary>
    public unsafe virtual float GetRevsMaxDelta()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRevsMaxDelta, "BmGame.RCommandBeaconBase.GetRevsMaxDelta");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRevs;
    /// <summary>
    /// Function: GetRevs
    /// </summary>
    public unsafe virtual float GetRevs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRevs, "BmGame.RCommandBeaconBase.GetRevs");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowRevPrompt;
    /// <summary>
    /// Function: ShowRevPrompt
    /// </summary>
    public unsafe virtual bool ShowRevPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowRevPrompt, "BmGame.RCommandBeaconBase.ShowRevPrompt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CustomPromptButtonPressed;
    /// <summary>
    /// Function: CustomPromptButtonPressed
    /// </summary>
    public unsafe virtual void CustomPromptButtonPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomPromptButtonPressed, "BmGame.RCommandBeaconBase.CustomPromptButtonPressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCustomPrompt;
    /// <summary>
    /// Function: ShowCustomPrompt
    /// </summary>
    public unsafe virtual bool ShowCustomPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCustomPrompt, "BmGame.RCommandBeaconBase.ShowCustomPrompt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AlwaysShowElectricEffectsOnCable;
    /// <summary>
    /// Function: AlwaysShowElectricEffectsOnCable
    /// </summary>
    public unsafe virtual bool AlwaysShowElectricEffectsOnCable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlwaysShowElectricEffectsOnCable, "BmGame.RCommandBeaconBase.AlwaysShowElectricEffectsOnCable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllowElectrifyHUD;
    /// <summary>
    /// Function: AllowElectrifyHUD
    /// </summary>
    public unsafe virtual bool AllowElectrifyHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowElectrifyHUD, "BmGame.RCommandBeaconBase.AllowElectrifyHUD");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPoweredUp;
    /// <summary>
    /// Function: IsPoweredUp
    /// </summary>
    public unsafe virtual bool IsPoweredUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPoweredUp, "BmGame.RCommandBeaconBase.IsPoweredUp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BlocksInteraction;
    /// <summary>
    /// Function: BlocksInteraction
    /// </summary>
    public unsafe virtual bool BlocksInteraction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlocksInteraction, "BmGame.RCommandBeaconBase.BlocksInteraction");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopElectricityEffects;
    /// <summary>
    /// Function: StopElectricityEffects
    /// </summary>
    public unsafe virtual void StopElectricityEffects()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopElectricityEffects, "BmGame.RCommandBeaconBase.StopElectricityEffects");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartElectricityEffects;
    /// <summary>
    /// Function: StartElectricityEffects
    /// </summary>
    public unsafe virtual void StartElectricityEffects()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartElectricityEffects, "BmGame.RCommandBeaconBase.StartElectricityEffects");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WinchAborted;
    /// <summary>
    /// Function: WinchAborted
    /// </summary>
    public unsafe virtual void WinchAborted(int Reason)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WinchAborted, "BmGame.RCommandBeaconBase.WinchAborted");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WinchReleased;
    /// <summary>
    /// Function: WinchReleased
    /// </summary>
    public unsafe virtual void WinchReleased(BmSDK.BmGame.RBatmobileWinch Winch)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WinchReleased, "BmGame.RCommandBeaconBase.WinchReleased");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WinchAttached;
    /// <summary>
    /// Function: WinchAttached
    /// </summary>
    public unsafe virtual void WinchAttached(BmSDK.BmGame.RBatmobileWinch Winch)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WinchAttached, "BmGame.RCommandBeaconBase.WinchAttached");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWinchTargetLocation;
    /// <summary>
    /// Function: GetWinchTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetWinchTargetLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWinchTargetLocation, "BmGame.RCommandBeaconBase.GetWinchTargetLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSideStory;
    /// <summary>
    /// Function: IsSideStory
    /// </summary>
    public unsafe virtual bool IsSideStory()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSideStory, "BmGame.RCommandBeaconBase.IsSideStory");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearArea;
    /// <summary>
    /// Function: ClearArea
    /// </summary>
    public unsafe virtual void ClearArea(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearArea, "BmGame.RCommandBeaconBase.ClearArea");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Interact;
    /// <summary>
    /// Function: Interact
    /// </summary>
    public unsafe override void Interact(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Interact, "BmGame.RCommandBeaconBase.Interact");
        byte* paramsPtr = stackalloc byte[208];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInteractButton;
    /// <summary>
    /// Function: GetInteractButton
    /// </summary>
    public unsafe override BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton GetInteractButton(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractButton, "BmGame.RCommandBeaconBase.GetInteractButton");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OverridePreviousLines;
    /// <summary>
    /// Function: OverridePreviousLines
    /// </summary>
    public unsafe override bool OverridePreviousLines()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverridePreviousLines, "BmGame.RCommandBeaconBase.OverridePreviousLines");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUpperPrompt;
    /// <summary>
    /// Function: GetUpperPrompt
    /// </summary>
    public unsafe override BmSDK.FString GetUpperPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpperPrompt, "BmGame.RCommandBeaconBase.GetUpperPrompt");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverridesRun;
    /// <summary>
    /// Function: OverridesRun
    /// </summary>
    public unsafe override float OverridesRun(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverridesRun, "BmGame.RCommandBeaconBase.OverridesRun");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanReachItem;
    /// <summary>
    /// Function: CanReachItem
    /// </summary>
    public unsafe override bool CanReachItem(BmSDK.Engine.Pawn CheckingPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReachItem, "BmGame.RCommandBeaconBase.CanReachItem");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckingPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetLocationOffset;
    /// <summary>
    /// Function: GetLocationOffset
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetLocationOffset()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocationOffset, "BmGame.RCommandBeaconBase.GetLocationOffset");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanUseInCinematicMode;
    /// <summary>
    /// Function: CanUseInCinematicMode
    /// </summary>
    public unsafe override bool CanUseInCinematicMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseInCinematicMode, "BmGame.RCommandBeaconBase.CanUseInCinematicMode");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MustBeCrouched;
    /// <summary>
    /// Function: MustBeCrouched
    /// </summary>
    public unsafe override bool MustBeCrouched(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MustBeCrouched, "BmGame.RCommandBeaconBase.MustBeCrouched");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsButtonPrompt;
    /// <summary>
    /// Function: IsButtonPrompt
    /// </summary>
    public unsafe override bool IsButtonPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsButtonPrompt, "BmGame.RCommandBeaconBase.IsButtonPrompt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsActive;
    /// <summary>
    /// Function: IsActive
    /// </summary>
    public unsafe override bool IsActive(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActive, "BmGame.RCommandBeaconBase.IsActive");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPriority;
    /// <summary>
    /// Function: GetPriority
    /// </summary>
    public unsafe override float GetPriority()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPriority, "BmGame.RCommandBeaconBase.GetPriority");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFOVDegrees;
    /// <summary>
    /// Function: GetFOVDegrees
    /// </summary>
    public unsafe override float GetFOVDegrees(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVDegrees, "BmGame.RCommandBeaconBase.GetFOVDegrees");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetHeightRange;
    /// <summary>
    /// Function: GetHeightRange
    /// </summary>
    public unsafe override float GetHeightRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeightRange, "BmGame.RCommandBeaconBase.GetHeightRange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRange;
    /// <summary>
    /// Function: GetRange
    /// </summary>
    public unsafe override float GetRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRange, "BmGame.RCommandBeaconBase.GetRange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPrompt;
    /// <summary>
    /// Function: GetPrompt
    /// </summary>
    public unsafe override BmSDK.FString GetPrompt(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrompt, "BmGame.RCommandBeaconBase.GetPrompt");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShutdownHUD;
    /// <summary>
    /// Function: ShutdownHUD
    /// </summary>
    public unsafe virtual void ShutdownHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutdownHUD, "BmGame.RCommandBeaconBase.ShutdownHUD");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryUpdateTimerHUD;
    /// <summary>
    /// Function: TryUpdateTimerHUD
    /// </summary>
    public unsafe virtual void TryUpdateTimerHUD(float RemainingTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryUpdateTimerHUD, "BmGame.RCommandBeaconBase.TryUpdateTimerHUD");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemainingTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveOutOfVirusRangeTimer;
    /// <summary>
    /// Function: RemoveOutOfVirusRangeTimer
    /// </summary>
    public unsafe virtual void RemoveOutOfVirusRangeTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveOutOfVirusRangeTimer, "BmGame.RCommandBeaconBase.RemoveOutOfVirusRangeTimer");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitHUD;
    /// <summary>
    /// Function: InitHUD
    /// </summary>
    public unsafe virtual void InitHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHUD, "BmGame.RCommandBeaconBase.InitHUD");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetXrayHighlight;
    /// <summary>
    /// Function: SetXrayHighlight
    /// </summary>
    public unsafe virtual void SetXrayHighlight(bool bEnabled)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXrayHighlight, "BmGame.RCommandBeaconBase.SetXrayHighlight");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryPlayBeaconDialogue;
    /// <summary>
    /// Function: TryPlayBeaconDialogue
    /// </summary>
    public unsafe virtual void TryPlayBeaconDialogue(BmSDK.BmGame.RSeqEvent_CommandBeaconDialogueTrigger.CommandBeaconDialogue DialogueEnum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryPlayBeaconDialogue, "BmGame.RCommandBeaconBase.TryPlayBeaconDialogue");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueEnum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindDialogueTriggerEvent;
    /// <summary>
    /// Function: FindDialogueTriggerEvent
    /// </summary>
    public unsafe virtual bool FindDialogueTriggerEvent()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindDialogueTriggerEvent, "BmGame.RCommandBeaconBase.FindDialogueTriggerEvent");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerBMBLAttack;
    /// <summary>
    /// Function: TriggerBMBLAttack
    /// </summary>
    public unsafe virtual void TriggerBMBLAttack(BmSDK.BmGame.RVehicleBatmobileBase Bmbl)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerBMBLAttack, "BmGame.RCommandBeaconBase.TriggerBMBLAttack");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bmbl, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyBMBLTeleported;
    /// <summary>
    /// Function: NotifyBMBLTeleported
    /// </summary>
    public unsafe virtual void NotifyBMBLTeleported()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyBMBLTeleported, "BmGame.RCommandBeaconBase.NotifyBMBLTeleported");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RCommandBeaconBase.Destroyed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RCommandBeaconBase.PreStreamOut");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RCommandBeaconBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerFailExplosion;
    /// <summary>
    /// Function: TriggerFailExplosion
    /// </summary>
    public unsafe virtual void TriggerFailExplosion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFailExplosion, "BmGame.RCommandBeaconBase.TriggerFailExplosion");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BMBLExitedOuterDist;
    /// <summary>
    /// Function: BMBLExitedOuterDist
    /// </summary>
    public unsafe virtual void BMBLExitedOuterDist()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BMBLExitedOuterDist, "BmGame.RCommandBeaconBase.BMBLExitedOuterDist");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BMBLEnteredOuterDist;
    /// <summary>
    /// Function: BMBLEnteredOuterDist
    /// </summary>
    public unsafe virtual void BMBLEnteredOuterDist()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BMBLEnteredOuterDist, "BmGame.RCommandBeaconBase.BMBLEnteredOuterDist");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyDronesDead;
    /// <summary>
    /// Function: NotifyDronesDead
    /// </summary>
    public unsafe virtual void NotifyDronesDead()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyDronesDead, "BmGame.RCommandBeaconBase.NotifyDronesDead");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VirusUploadComplete;
    /// <summary>
    /// Function: VirusUploadComplete
    /// </summary>
    public unsafe virtual void VirusUploadComplete()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VirusUploadComplete, "BmGame.RCommandBeaconBase.VirusUploadComplete");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VirusUploadStarted;
    /// <summary>
    /// Function: VirusUploadStarted
    /// </summary>
    public unsafe virtual void VirusUploadStarted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VirusUploadStarted, "BmGame.RCommandBeaconBase.VirusUploadStarted");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnInteractFailBecauseBMBLUnavailable;
    /// <summary>
    /// Function: OnInteractFailBecauseBMBLUnavailable
    /// </summary>
    public unsafe virtual void OnInteractFailBecauseBMBLUnavailable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnInteractFailBecauseBMBLUnavailable, "BmGame.RCommandBeaconBase.OnInteractFailBecauseBMBLUnavailable");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnInteractFail;
    /// <summary>
    /// Function: OnInteractFail
    /// </summary>
    public unsafe virtual void OnInteractFail()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnInteractFail, "BmGame.RCommandBeaconBase.OnInteractFail");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialMoveFinished;
    /// <summary>
    /// Function: SpecialMoveFinished
    /// </summary>
    public unsafe override void SpecialMoveFinished()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialMoveFinished, "BmGame.RCommandBeaconBase.SpecialMoveFinished");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCanTriggerReinforcements;
    /// <summary>
    /// Function: SetCanTriggerReinforcements
    /// </summary>
    public unsafe virtual void SetCanTriggerReinforcements(bool bAllowed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCanTriggerReinforcements, "BmGame.RCommandBeaconBase.SetCanTriggerReinforcements");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDestroyedFlagName;
    /// <summary>
    /// Function: GetDestroyedFlagName
    /// </summary>
    public unsafe virtual BmSDK.FString GetDestroyedFlagName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDestroyedFlagName, "BmGame.RCommandBeaconBase.GetDestroyedFlagName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBeaconDestroyed;
    /// <summary>
    /// Function: IsBeaconDestroyed
    /// </summary>
    public unsafe virtual bool IsBeaconDestroyed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBeaconDestroyed, "BmGame.RCommandBeaconBase.IsBeaconDestroyed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetBeaconDestroyedFlag;
    /// <summary>
    /// Function: SetBeaconDestroyedFlag
    /// </summary>
    public unsafe virtual void SetBeaconDestroyedFlag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBeaconDestroyedFlag, "BmGame.RCommandBeaconBase.SetBeaconDestroyedFlag");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebug;
    /// <summary>
    /// Function: DrawDebug
    /// </summary>
    public unsafe virtual void DrawDebug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebug, "BmGame.RCommandBeaconBase.DrawDebug");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlockLevelName;
    /// <summary>
    /// Function: BlockLevelName
    /// </summary>
    public unsafe virtual bool BlockLevelName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockLevelName, "BmGame.RCommandBeaconBase.BlockLevelName");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PreRender;
    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe virtual void PreRender(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreRender, "BmGame.RCommandBeaconBase.PreRender");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RCommandBeaconBase.DrawHUD");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggle;
    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe override void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggle, "BmGame.RCommandBeaconBase.OnToggle");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestorePoweredUpState;
    /// <summary>
    /// Function: RestorePoweredUpState
    /// </summary>
    public unsafe virtual bool RestorePoweredUpState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestorePoweredUpState, "BmGame.RCommandBeaconBase.RestorePoweredUpState");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateWinch;
    /// <summary>
    /// Function: UpdateWinch
    /// </summary>
    public unsafe virtual void UpdateWinch(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateWinch, "BmGame.RCommandBeaconBase.UpdateWinch");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetState;
    /// <summary>
    /// Function: SetState
    /// </summary>
    public unsafe virtual void SetState(BmSDK.BmGame.RCommandBeaconBase.eCommandBeaconState NewState, bool bSilent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetState, "BmGame.RCommandBeaconBase.SetState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSilent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AudioUpdateLight;
    /// <summary>
    /// Function: AudioUpdateLight
    /// </summary>
    public unsafe virtual void AudioUpdateLight(BmSDK.Engine.PointLightComponent Light, float dt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioUpdateLight, "BmGame.RCommandBeaconBase.AudioUpdateLight");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Light, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dt, paramsPtr + 8);
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

    private static BmSDK.Function __fn_CheckBMBLRange;
    /// <summary>
    /// Function: CheckBMBLRange
    /// </summary>
    public unsafe virtual void CheckBMBLRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckBMBLRange, "BmGame.RCommandBeaconBase.CheckBMBLRange");
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

    private static BmSDK.Function __fn_TryTriggerBMBLAttack;
    /// <summary>
    /// Function: TryTriggerBMBLAttack
    /// </summary>
    public unsafe virtual void TryTriggerBMBLAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTriggerBMBLAttack, "BmGame.RCommandBeaconBase.TryTriggerBMBLAttack");
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

    private static BmSDK.Function __fn_GetHostileRange;
    /// <summary>
    /// Function: GetHostileRange
    /// </summary>
    public unsafe virtual float GetHostileRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHostileRange, "BmGame.RCommandBeaconBase.GetHostileRange");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFriendlyRange;
    /// <summary>
    /// Function: GetFriendlyRange
    /// </summary>
    public unsafe virtual float GetFriendlyRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFriendlyRange, "BmGame.RCommandBeaconBase.GetFriendlyRange");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldBeInPoweredDownState;
    /// <summary>
    /// Function: ShouldBeInPoweredDownState
    /// </summary>
    public unsafe virtual bool ShouldBeInPoweredDownState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldBeInPoweredDownState, "BmGame.RCommandBeaconBase.ShouldBeInPoweredDownState");
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

    private static BmSDK.Function __fn_InStasis;
    /// <summary>
    /// Function: InStasis
    /// </summary>
    public unsafe virtual bool InStasis()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InStasis, "BmGame.RCommandBeaconBase.InStasis");
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

    private static BmSDK.Function __fn_Tick_Native;
    /// <summary>
    /// Function: Tick_Native
    /// </summary>
    public unsafe virtual void Tick_Native(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick_Native, "BmGame.RCommandBeaconBase.Tick_Native");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    /// <summary>
    /// Enum: eCommandBeaconState
    /// </summary>
    public enum eCommandBeaconState : byte
    {
        eCBS_ToggledHidden = 0,
        eCBS_Dormant = 1,
        eCBS_VirusUploadInProgress = 2,
        eCBS_VirusOutOfRange = 3,
        eCBS_DronesDefeated = 4,
        eCBS_DronesDefeatedOutOfRange = 5,
        eCBS_Broken = 6,
        eCBS_MAX = 7,
    }

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: SeqAct
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_CommandBeacon SeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_CommandBeacon>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: AudioDestroySound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioDestroySound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: AudioLightBrightnessParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName AudioLightBrightnessParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: InteractMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig InteractMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: BeaconAsset
    /// </summary>
    public unsafe BmSDK.BmGame.RBeaconAsset BeaconAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBeaconAsset>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: combatAreaCentreActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor combatAreaCentreActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ObjectProperty: DialogueTriggerEvent
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqEvent_CommandBeaconDialogueTrigger DialogueTriggerEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqEvent_CommandBeaconDialogueTrigger>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ObjectProperty: XrayMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ObjectProperty: virusUploadStartSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent virusUploadStartSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ObjectProperty: virusUploadFailSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent virusUploadFailSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: virusUploadSuccessSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent virusUploadSuccessSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ObjectProperty: timerBeep
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent timerBeep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: GaugesActor
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshActor GaugesActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshActor>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: PowerStartEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PowerStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ObjectProperty: VehiclePowerStartEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent VehiclePowerStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: PowerRevsParamName
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName PowerRevsParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: RevsController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RevsController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ObjectProperty: GuagesMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant GuagesMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ObjectProperty: AttachedToWinch
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileWinch AttachedToWinch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileWinch>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ObjectProperty: AnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence AnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ObjectProperty: AttackParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem AttackParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ObjectProperty: AttackSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AttackSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ObjectProperty: lightsArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RCommandBeaconLightsBase lightsArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCommandBeaconLightsBase>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ObjectProperty: lightsInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RCommandBeaconLightsBase lightsInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCommandBeaconLightsBase>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ObjectProperty: ExplodeRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ExplodeRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ComponentProperty: AttackParticleSystem_Mine
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent AttackParticleSystem_Mine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ComponentProperty: ElectricityEffectComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ElectricityEffectComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ComponentProperty: FailExplosionVFX_x
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FailExplosionVFX_x
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ComponentProperty: ControlledExplosionVFX_x
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ControlledExplosionVFX_x
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ComponentProperty: smokeVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent smokeVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ComponentProperty: radiusVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent radiusVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: overrideFailDist
    /// </summary>
    public unsafe float overrideFailDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// FloatProperty: abandonTime
    /// </summary>
    public unsafe float abandonTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: abandonTimeRemaining
    /// </summary>
    public unsafe float abandonTimeRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: MinPeriodBetweenDialogue
    /// </summary>
    public unsafe float MinPeriodBetweenDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// BoolProperty: bSkipSpecialMove
    /// </summary>
    public unsafe bool bSkipSpecialMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: SideStory
    /// </summary>
    public unsafe bool SideStory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bCanTriggerReinforcements
    /// </summary>
    public unsafe bool bCanTriggerReinforcements
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bInteractedWaitingForVirus
    /// </summary>
    public unsafe bool bInteractedWaitingForVirus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bCanDetectPlayer
    /// </summary>
    public unsafe bool bCanDetectPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bNoPriorInteraction
    /// </summary>
    public unsafe bool bNoPriorInteraction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bInteractDisabledByKismet
    /// </summary>
    public unsafe bool bInteractDisabledByKismet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bLightBrightnessIncreasing
    /// </summary>
    public unsafe bool bLightBrightnessIncreasing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bNeedToSetVirusHUDActive
    /// </summary>
    public unsafe bool bNeedToSetVirusHUDActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bNeedToSetVirusHUDComplete
    /// </summary>
    public unsafe bool bNeedToSetVirusHUDComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: PoweredUp
    /// </summary>
    public unsafe bool PoweredUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: PowerRevsGlobal
    /// </summary>
    public unsafe bool PowerRevsGlobal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bWinchCustomButtonPressed
    /// </summary>
    public unsafe bool bWinchCustomButtonPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToPowerDownIfBMBLNearby
    /// </summary>
    public unsafe bool bNeedsToPowerDownIfBMBLNearby
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bmblWasInRange
    /// </summary>
    public unsafe bool bmblWasInRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: winchInteractionsAttached
    /// </summary>
    public unsafe bool winchInteractionsAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: winchingAllowedByBeacon
    /// </summary>
    public unsafe bool winchingAllowedByBeacon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bHasStartedBlockingBMBLMovement
    /// </summary>
    public unsafe bool bHasStartedBlockingBMBLMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bKismetStoppedBlockingBMBLMovement
    /// </summary>
    public unsafe bool bKismetStoppedBlockingBMBLMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// StrProperty: DifficultyString
    /// </summary>
    public unsafe BmSDK.FString DifficultyString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: HUDElementVisRange
    /// </summary>
    public unsafe float HUDElementVisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// IntProperty: Difficulty_One_To_Five
    /// </summary>
    public unsafe int Difficulty_One_To_Five
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: BMBLOutOfBoundsDistance
    /// </summary>
    public unsafe float BMBLOutOfBoundsDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ByteProperty: beaconState
    /// </summary>
    public unsafe BmSDK.BmGame.RCommandBeaconBase.eCommandBeaconState beaconState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCommandBeaconBase.eCommandBeaconState>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ByteProperty: previousBeaconState
    /// </summary>
    public unsafe BmSDK.BmGame.RCommandBeaconBase.eCommandBeaconState previousBeaconState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCommandBeaconBase.eCommandBeaconState>(Ptr + 1009); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1009); }
    }

    /// <summary>
    /// ByteProperty: MostRecentDialogueEnum
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqEvent_CommandBeaconDialogueTrigger.CommandBeaconDialogue MostRecentDialogueEnum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqEvent_CommandBeaconDialogueTrigger.CommandBeaconDialogue>(Ptr + 1010); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1010); }
    }

    /// <summary>
    /// FloatProperty: BMBLDist
    /// </summary>
    public unsafe float BMBLDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// FloatProperty: prevBMBLDist
    /// </summary>
    public unsafe float prevBMBLDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: LastDialogueTime
    /// </summary>
    public unsafe float LastDialogueTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: bLightPulsePeriod_idle
    /// </summary>
    public unsafe float bLightPulsePeriod_idle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: bLightPulsePeriod_active
    /// </summary>
    public unsafe float bLightPulsePeriod_active
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: LightBrightness
    /// </summary>
    public unsafe float LightBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: radiusVFXInitialSize
    /// </summary>
    public unsafe float radiusVFXInitialSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: LastHUDTimerDrawTime
    /// </summary>
    public unsafe float LastHUDTimerDrawTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StrProperty: everInteractedFlag
    /// </summary>
    public unsafe BmSDK.FString everInteractedFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// IntProperty: prevRemainingTime
    /// </summary>
    public unsafe int prevRemainingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: GaugeMaterialIndex
    /// </summary>
    public unsafe int GaugeMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// NameProperty: GaugePowerInputName
    /// </summary>
    public unsafe BmSDK.FName GaugePowerInputName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// NameProperty: GaugePowerOutputName
    /// </summary>
    public unsafe BmSDK.FName GaugePowerOutputName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// FloatProperty: RevsMultiplier
    /// </summary>
    public unsafe float RevsMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// FloatProperty: MaxRevs
    /// </summary>
    public unsafe float MaxRevs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// FloatProperty: MaxRevsHoldTime
    /// </summary>
    public unsafe float MaxRevsHoldTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: RevsDeltaLimit
    /// </summary>
    public unsafe float RevsDeltaLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// FloatProperty: RevsVelLimit
    /// </summary>
    public unsafe float RevsVelLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// FloatProperty: CurrentRevs
    /// </summary>
    public unsafe float CurrentRevs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// FloatProperty: CurrentRevsVel
    /// </summary>
    public unsafe float CurrentRevsVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxRevsTime
    /// </summary>
    public unsafe float CurrentMaxRevsTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// FloatProperty: InputRevs
    /// </summary>
    public unsafe float InputRevs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// StructProperty: WinchAttachLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WinchAttachLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1120);

    /// <summary>
    /// FloatProperty: winchInitiationDuration
    /// </summary>
    public unsafe float winchInitiationDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: winchCustomButtonPressTime
    /// </summary>
    public unsafe float winchCustomButtonPressTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// StrProperty: focusDetailString
    /// </summary>
    public unsafe BmSDK.FString focusDetailString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// NameProperty: coreExposeAnimName
    /// </summary>
    public unsafe BmSDK.FName coreExposeAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// FloatProperty: timeTillCanAttack
    /// </summary>
    public unsafe float timeTillCanAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: MineRange
    /// </summary>
    public unsafe float MineRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// FloatProperty: MineDamage
    /// </summary>
    public unsafe float MineDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// FloatProperty: MineImpulse
    /// </summary>
    public unsafe float MineImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenMineAttacks
    /// </summary>
    public unsafe float TimeBetweenMineAttacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// FloatProperty: friendlyRangeExtra
    /// </summary>
    public unsafe float friendlyRangeExtra
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// IntProperty: numForcedTicksNeeded
    /// </summary>
    public unsafe int numForcedTicksNeeded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
}
