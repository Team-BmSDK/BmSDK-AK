#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RInventoryGadget<br/>
/// (size = 2068)
/// (flags = 144703667)
/// </summary>
public partial class RInventoryGadget : BmSDK.Engine.Inventory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RInventoryGadget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RInventoryGadget.
    /// </summary>
    public static RInventoryGadget DefaultObject => (RInventoryGadget)StaticClass().DefaultObject;

    internal RInventoryGadget() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInventoryGadget(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryGadget>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryGadget>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryGadget>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryGadget>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryGadget>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryGadget>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryGadget>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryGadget>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SpecialMoveCancelled;
    /// <summary>
    /// Function: SpecialMoveCancelled
    /// </summary>
    public unsafe virtual void SpecialMoveCancelled(BmSDK.BmGame.RSpecialMoveInstance SpecMove)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialMoveCancelled, "BmGame.RInventoryGadget.SpecialMoveCancelled");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OwnerDied;
    /// <summary>
    /// Function: OwnerDied
    /// </summary>
    public unsafe virtual void OwnerDied()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OwnerDied, "BmGame.RInventoryGadget.OwnerDied");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetForChallenge;
    /// <summary>
    /// Function: ResetForChallenge
    /// </summary>
    public unsafe virtual void ResetForChallenge(bool bChallengeStarted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetForChallenge, "BmGame.RInventoryGadget.ResetForChallenge");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChallengeStarted, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpgradeToSuperComboGadget;
    /// <summary>
    /// Function: UpgradeToSuperComboGadget
    /// </summary>
    public unsafe virtual bool UpgradeToSuperComboGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradeToSuperComboGadget, "BmGame.RInventoryGadget.UpgradeToSuperComboGadget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverridePostProcessSettings;
    /// <summary>
    /// Function: OverridePostProcessSettings
    /// </summary>
    public unsafe virtual void OverridePostProcessSettings(out BmSDK.Engine.PostProcessVolume.FPostProcessSettings PPSettings)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverridePostProcessSettings, "BmGame.RInventoryGadget.OverridePostProcessSettings");
        byte* paramsPtr = stackalloc byte[524];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PPSettings = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateSkeletalMeshDepthBias;
    /// <summary>
    /// Function: UpdateSkeletalMeshDepthBias
    /// </summary>
    public unsafe virtual void UpdateSkeletalMeshDepthBias(out BmSDK.BmGame.RInventoryGadget.FHighlightedMesh UpdateHighlightedMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSkeletalMeshDepthBias, "BmGame.RInventoryGadget.UpdateSkeletalMeshDepthBias");
        byte* paramsPtr = stackalloc byte[88];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        UpdateHighlightedMesh = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CreateNewHighlightStaticMesh;
    /// <summary>
    /// Function: CreateNewHighlightStaticMesh
    /// </summary>
    public unsafe virtual void CreateNewHighlightStaticMesh(int iCachedStaticMeshPosition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateNewHighlightStaticMesh, "BmGame.RInventoryGadget.CreateNewHighlightStaticMesh");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iCachedStaticMeshPosition, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CreateNewHighlightSkelMesh;
    /// <summary>
    /// Function: CreateNewHighlightSkelMesh
    /// </summary>
    public unsafe virtual void CreateNewHighlightSkelMesh(int iCachedSkelMeshPosition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateNewHighlightSkelMesh, "BmGame.RInventoryGadget.CreateNewHighlightSkelMesh");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iCachedSkelMeshPosition, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsHighlightedMeshCurrentTarget;
    /// <summary>
    /// Function: IsHighlightedMeshCurrentTarget
    /// </summary>
    public unsafe virtual bool IsHighlightedMeshCurrentTarget(BmSDK.Engine.MeshComponent CheckHighlightedMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHighlightedMeshCurrentTarget, "BmGame.RInventoryGadget.IsHighlightedMeshCurrentTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckHighlightedMesh, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AllowHighlightToBeHidden;
    /// <summary>
    /// Function: AllowHighlightToBeHidden
    /// </summary>
    public unsafe virtual bool AllowHighlightToBeHidden(BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CheckHighlightedMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowHighlightToBeHidden, "BmGame.RInventoryGadget.AllowHighlightToBeHidden");
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
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_UpdateHighlightMeshVisibility;
    /// <summary>
    /// Function: UpdateHighlightMeshVisibility
    /// </summary>
    public unsafe virtual void UpdateHighlightMeshVisibility(out BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CheckHighlightedMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHighlightMeshVisibility, "BmGame.RInventoryGadget.UpdateHighlightMeshVisibility");
        byte* paramsPtr = stackalloc byte[88];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CheckHighlightedMesh = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetCorrectMIC;
    /// <summary>
    /// Function: GetCorrectMIC
    /// </summary>
    public unsafe virtual BmSDK.Engine.MaterialInterface GetCorrectMIC(BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType TargetType, bool bShotByDisruptor, bool bSniperHasAmmoLeft, bool bWeaponReadyToExplode, bool bUpgradeNeeded, bool bNormalViewMode, bool bForCamouflageThug, bool bSpecialTrackerTarget, bool bCurrentTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCorrectMIC, "BmGame.RInventoryGadget.GetCorrectMIC");
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
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_SetCorrectMICOnMesh;
    /// <summary>
    /// Function: SetCorrectMICOnMesh
    /// </summary>
    public unsafe virtual void SetCorrectMICOnMesh(BmSDK.Engine.Actor NewActor, BmSDK.Engine.MeshComponent HighlightMesh, BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType TargetType, bool bShotByDisruptor, bool bSniperHasAmmoLeft, bool bWeaponReadyToExplode, bool bUpgradeNeeded, bool bNormalViewMode, bool bForCamouflageThug, bool bSpecialTrackerTarget, bool bCurrentTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCorrectMICOnMesh, "BmGame.RInventoryGadget.SetCorrectMICOnMesh");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighlightMesh, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShotByDisruptor, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSniperHasAmmoLeft, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWeaponReadyToExplode, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUpgradeNeeded, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNormalViewMode, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForCamouflageThug, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialTrackerTarget, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCurrentTarget, paramsPtr + 48);
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

    private static BmSDK.Function __fn_AddHighLightStaticMesh;
    /// <summary>
    /// Function: AddHighLightStaticMesh
    /// </summary>
    public unsafe virtual void AddHighLightStaticMesh(BmSDK.Engine.Actor NewActor, BmSDK.Engine.StaticMeshComponent StaticMesh, BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType TargetType, bool IsTagged, bool bSniperHasAmmoLeft, bool bCanStillBeShot, bool bExplosive, bool bNeedsUpgrade, bool bNormalViewMode, BmSDK.FString DescriptionText, bool bForCamouflageThug, bool bSpecialTrackerTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddHighLightStaticMesh, "BmGame.RInventoryGadget.AddHighLightStaticMesh");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StaticMesh, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsTagged, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSniperHasAmmoLeft, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStillBeShot, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExplosive, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNeedsUpgrade, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNormalViewMode, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DescriptionText, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForCamouflageThug, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialTrackerTarget, paramsPtr + 64);
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

    private static BmSDK.Function __fn_AddHighLightSkeletalMesh;
    /// <summary>
    /// Function: AddHighLightSkeletalMesh
    /// </summary>
    public unsafe virtual void AddHighLightSkeletalMesh(BmSDK.Engine.Actor NewActor, BmSDK.Engine.SkeletalMeshComponent SkelMesh, BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType TargetType, bool IsTagged, bool bSniperHasAmmoLeft, bool bCanStillBeShot, bool bExplosive, bool bNeedsUpgrade, bool bNormalViewMode, BmSDK.FString DescriptionText, bool bForCamouflageThug, bool bSpecialTrackerTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddHighLightSkeletalMesh, "BmGame.RInventoryGadget.AddHighLightSkeletalMesh");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsTagged, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSniperHasAmmoLeft, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStillBeShot, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExplosive, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNeedsUpgrade, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNormalViewMode, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DescriptionText, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForCamouflageThug, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialTrackerTarget, paramsPtr + 64);
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

    private static BmSDK.Function __fn_ClearOutLeastRelevantStaticMesh;
    /// <summary>
    /// Function: ClearOutLeastRelevantStaticMesh
    /// </summary>
    public unsafe virtual void ClearOutLeastRelevantStaticMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearOutLeastRelevantStaticMesh, "BmGame.RInventoryGadget.ClearOutLeastRelevantStaticMesh");
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

    private static BmSDK.Function __fn_ClearOutLeastRelevantSkeletalMesh;
    /// <summary>
    /// Function: ClearOutLeastRelevantSkeletalMesh
    /// </summary>
    public unsafe virtual void ClearOutLeastRelevantSkeletalMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearOutLeastRelevantSkeletalMesh, "BmGame.RInventoryGadget.ClearOutLeastRelevantSkeletalMesh");
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

    private static BmSDK.Function __fn_ClearHighlights;
    /// <summary>
    /// Function: ClearHighlights
    /// </summary>
    public unsafe virtual void ClearHighlights(bool bForceClear = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearHighlights, "BmGame.RInventoryGadget.ClearHighlights");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceClear, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PrimedUpdateIndividualTargetHighlight;
    /// <summary>
    /// Function: PrimedUpdateIndividualTargetHighlight
    /// </summary>
    public unsafe virtual void PrimedUpdateIndividualTargetHighlight(BmSDK.Engine.Actor CheckTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrimedUpdateIndividualTargetHighlight, "BmGame.RInventoryGadget.PrimedUpdateIndividualTargetHighlight");
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
    public unsafe virtual void PrimedUpdateHighlights()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrimedUpdateHighlights, "BmGame.RInventoryGadget.PrimedUpdateHighlights");
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

    private static BmSDK.Function __fn_HolsteredShouldHighlightBeMaintained;
    /// <summary>
    /// Function: HolsteredShouldHighlightBeMaintained
    /// </summary>
    public unsafe virtual bool HolsteredShouldHighlightBeMaintained(BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CheckHighlightedMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HolsteredShouldHighlightBeMaintained, "BmGame.RInventoryGadget.HolsteredShouldHighlightBeMaintained");
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
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_HolsteredUpdateHighlights;
    /// <summary>
    /// Function: HolsteredUpdateHighlights
    /// </summary>
    public unsafe virtual void HolsteredUpdateHighlights()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HolsteredUpdateHighlights, "BmGame.RInventoryGadget.HolsteredUpdateHighlights");
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

    private static BmSDK.Function __fn_SetupHighlights;
    /// <summary>
    /// Function: SetupHighlights
    /// </summary>
    public unsafe virtual void SetupHighlights()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupHighlights, "BmGame.RInventoryGadget.SetupHighlights");
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

    private static BmSDK.Function __fn_GetImpactAudioEvent;
    /// <summary>
    /// Function: GetImpactAudioEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetImpactAudioEvent(BmSDK.Engine.AkWwise.EAkWorldMaterial Mat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactAudioEvent, "BmGame.RInventoryGadget.GetImpactAudioEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_VillainWasDestroyedWithStickyBombAttached;
    /// <summary>
    /// Function: VillainWasDestroyedWithStickyBombAttached
    /// </summary>
    public unsafe virtual void VillainWasDestroyedWithStickyBombAttached(BmSDK.Engine.MeshComponent Bomb)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainWasDestroyedWithStickyBombAttached, "BmGame.RInventoryGadget.VillainWasDestroyedWithStickyBombAttached");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bomb, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetAimWalkPrimedPose;
    /// <summary>
    /// Function: GetGadgetAimWalkPrimedPose
    /// </summary>
    public unsafe virtual void GetGadgetAimWalkPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.FName OutCapeState, out BmSDK.FName OutCapeTransitionState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetAimWalkPrimedPose, "BmGame.RInventoryGadget.GetGadgetAimWalkPrimedPose");
        byte* paramsPtr = stackalloc byte[36];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StanceIsCrouched);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StanceIsCrouched, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeState, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeTransitionState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeTransitionState, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
        OutCapeTransitionState = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_UpdateCapeBlendWeights;
    /// <summary>
    /// Function: UpdateCapeBlendWeights
    /// </summary>
    public unsafe virtual void UpdateCapeBlendWeights(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCapeBlendWeights, "BmGame.RInventoryGadget.UpdateCapeBlendWeights");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayGadgetThought;
    /// <summary>
    /// Function: PlayGadgetThought
    /// </summary>
    public unsafe virtual bool PlayGadgetThought(BmSDK.Engine.AkDialogueSpeech NewSpeech, bool bUseCountdownTimer = default, bool bPlaySoundIfRejectedByCountdownTimer = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGadgetThought, "BmGame.RInventoryGadget.PlayGadgetThought");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSpeech, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseCountdownTimer, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaySoundIfRejectedByCountdownTimer, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UseGadgetPose;
    /// <summary>
    /// Function: UseGadgetPose
    /// </summary>
    public unsafe virtual bool UseGadgetPose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseGadgetPose, "BmGame.RInventoryGadget.UseGadgetPose");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnGadgetWheelSelected;
    /// <summary>
    /// Function: OnGadgetWheelSelected
    /// </summary>
    public unsafe virtual void OnGadgetWheelSelected()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGadgetWheelSelected, "BmGame.RInventoryGadget.OnGadgetWheelSelected");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowAimAt;
    /// <summary>
    /// Function: AllowAimAt
    /// </summary>
    public unsafe virtual bool AllowAimAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowAimAt, "BmGame.RInventoryGadget.AllowAimAt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateAliveProjectiles;
    /// <summary>
    /// Function: UpdateAliveProjectiles
    /// </summary>
    public unsafe virtual void UpdateAliveProjectiles(BmSDK.BmGame.RProjectile NewProjectile)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAliveProjectiles, "BmGame.RInventoryGadget.UpdateAliveProjectiles");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewProjectile, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetTargetDistance;
    /// <summary>
    /// Function: GetTargetDistance
    /// </summary>
    public unsafe virtual float GetTargetDistance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetDistance, "BmGame.RInventoryGadget.GetTargetDistance");
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThrowGadget;
    /// <summary>
    /// Function: ThrowGadget
    /// </summary>
    public unsafe virtual void ThrowGadget(System.Numerics.Vector3 ThrownFromPos, BmSDK.BmGame.RBMAIController.BRAECReactionType Type, int LaunchID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowGadget, "BmGame.RInventoryGadget.ThrowGadget");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowRun;
    /// <summary>
    /// Function: AllowRun
    /// </summary>
    public unsafe virtual bool AllowRun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowRun, "BmGame.RInventoryGadget.AllowRun");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetGadgetSoundSwitch;
    /// <summary>
    /// Function: SetGadgetSoundSwitch
    /// </summary>
    public unsafe virtual void SetGadgetSoundSwitch(BmSDK.Engine.AkSwitchName AudioSwitch)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGadgetSoundSwitch, "BmGame.RInventoryGadget.SetGadgetSoundSwitch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioSwitch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopGadgetSound;
    /// <summary>
    /// Function: StopGadgetSound
    /// </summary>
    public unsafe virtual void StopGadgetSound(BmSDK.Engine.AkEvent AudioEvent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGadgetSound, "BmGame.RInventoryGadget.StopGadgetSound");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayGadgetSound;
    /// <summary>
    /// Function: PlayGadgetSound
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkWwise.FAkSoundHandle PlayGadgetSound(BmSDK.Engine.AkEvent AudioEvent, bool Looping = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGadgetSound, "BmGame.RInventoryGadget.PlayGadgetSound");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Looping, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FireGadgetGliding;
    /// <summary>
    /// Function: FireGadgetGliding
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor FireGadgetGliding()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireGadgetGliding, "BmGame.RInventoryGadget.FireGadgetGliding");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FireGadgetCombat;
    /// <summary>
    /// Function: FireGadgetCombat
    /// </summary>
    public unsafe virtual bool FireGadgetCombat()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireGadgetCombat, "BmGame.RInventoryGadget.FireGadgetCombat");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CancelEmergencyFire;
    /// <summary>
    /// Function: CancelEmergencyFire
    /// </summary>
    public unsafe virtual void CancelEmergencyFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelEmergencyFire, "BmGame.RInventoryGadget.CancelEmergencyFire");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_quickFire;
    /// <summary>
    /// Function: quickFire
    /// </summary>
    public unsafe virtual void quickFire(bool OverridesCombatMove = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_quickFire, "BmGame.RInventoryGadget.quickFire");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridesCombatMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateXrayMaskMesh;
    /// <summary>
    /// Function: CreateXrayMaskMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent CreateXrayMaskMesh(BmSDK.Engine.SkeletalMeshComponent Template)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateXrayMaskMesh, "BmGame.RInventoryGadget.CreateXrayMaskMesh");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetActualLaunchLocation;
    /// <summary>
    /// Function: GetActualLaunchLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetActualLaunchLocation(System.Numerics.Vector3 DesiredLaunchLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActualLaunchLocation, "BmGame.RInventoryGadget.GetActualLaunchLocation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredLaunchLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_StopGetOutSound;
    /// <summary>
    /// Function: StopGetOutSound
    /// </summary>
    public unsafe virtual void StopGetOutSound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGetOutSound, "BmGame.RInventoryGadget.StopGetOutSound");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayGetOutSound;
    /// <summary>
    /// Function: PlayGetOutSound
    /// </summary>
    public unsafe virtual void PlayGetOutSound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGetOutSound, "BmGame.RInventoryGadget.PlayGetOutSound");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLevelChange;
    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe virtual void OnLevelChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelChange, "BmGame.RInventoryGadget.OnLevelChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe virtual void OnRoomChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.RInventoryGadget.OnRoomChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExittedPrimedMode;
    /// <summary>
    /// Function: ExittedPrimedMode
    /// </summary>
    public unsafe virtual void ExittedPrimedMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExittedPrimedMode, "BmGame.RInventoryGadget.ExittedPrimedMode");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowTutorial;
    /// <summary>
    /// Function: ShowTutorial
    /// </summary>
    public unsafe virtual void ShowTutorial()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowTutorial, "BmGame.RInventoryGadget.ShowTutorial");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayTutorial;
    /// <summary>
    /// Function: DisplayTutorial
    /// </summary>
    public unsafe virtual bool DisplayTutorial()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayTutorial, "BmGame.RInventoryGadget.DisplayTutorial");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTutorialText;
    /// <summary>
    /// Function: GetTutorialText
    /// </summary>
    public unsafe virtual BmSDK.FString GetTutorialText()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTutorialText, "BmGame.RInventoryGadget.GetTutorialText");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPromptName;
    /// <summary>
    /// Function: GetPromptName
    /// </summary>
    public unsafe static BmSDK.FName GetPromptName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPromptName, "BmGame.RInventoryGadget.GetPromptName");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe virtual bool GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RInventoryGadget.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetGadgetLookSensitivity;
    /// <summary>
    /// Function: GetGadgetLookSensitivity
    /// </summary>
    public unsafe virtual float GetGadgetLookSensitivity(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetLookSensitivity, "BmGame.RInventoryGadget.GetGadgetLookSensitivity");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindMultipleTargets;
    /// <summary>
    /// Function: FindMultipleTargets
    /// </summary>
    public unsafe virtual void FindMultipleTargets(System.Numerics.Vector3 LaunchPosition, BmSDK.Rotator LaunchAngle, float Range, float TargetAngle, out BmSDK.TArray<BmSDK.Engine.Actor> Targets, out BmSDK.TArray<int> PositionIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindMultipleTargets, "BmGame.RInventoryGadget.FindMultipleTargets");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchAngle, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Range, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetAngle, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Targets = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 32);
        PositionIndex = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 48);
        return;
    }

    private static BmSDK.Function __fn_FindAutoTarget;
    /// <summary>
    /// Function: FindAutoTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor FindAutoTarget(System.Numerics.Vector3 LaunchPosition, BmSDK.Rotator LaunchAngle, float Range, float TargetAngle, out int PositionIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAutoTarget, "BmGame.RInventoryGadget.FindAutoTarget");
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchAngle, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Range, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetAngle, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PositionIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionIndex, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PositionIndex = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_FollowCoverRotator;
    /// <summary>
    /// Function: FollowCoverRotator
    /// </summary>
    public unsafe virtual bool FollowCoverRotator(BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.Rotator CoverOffset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FollowCoverRotator, "BmGame.RInventoryGadget.FollowCoverRotator");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CoverOffset);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CoverOffset, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverOffset = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetPC;
    /// <summary>
    /// Function: GetPC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPlayerController GetPC()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPC, "BmGame.RInventoryGadget.GetPC");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerFlourishCamera;
    /// <summary>
    /// Function: TriggerFlourishCamera
    /// </summary>
    public unsafe virtual bool TriggerFlourishCamera()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFlourishCamera, "BmGame.RInventoryGadget.TriggerFlourishCamera");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanThrowGadget;
    /// <summary>
    /// Function: CanThrowGadget
    /// </summary>
    public unsafe virtual bool CanThrowGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanThrowGadget, "BmGame.RInventoryGadget.CanThrowGadget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanRun;
    /// <summary>
    /// Function: CanRun
    /// </summary>
    public unsafe virtual bool CanRun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRun, "BmGame.RInventoryGadget.CanRun");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPlayerMove;
    /// <summary>
    /// Function: CanPlayerMove
    /// </summary>
    public unsafe virtual bool CanPlayerMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayerMove, "BmGame.RInventoryGadget.CanPlayerMove");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPrimedPose;
    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe virtual BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState, out BmSDK.FName OutCapeTransitionState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmGame.RInventoryGadget.GetPrimedPose");
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
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
        OutCapeTransitionState = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetGadgetCamera;
    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe virtual BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetCamera, "BmGame.RInventoryGadget.GetGadgetCamera");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetAutoTargetOrigin;
    /// <summary>
    /// Function: GetAutoTargetOrigin
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAutoTargetOrigin(BmSDK.Rotator AimDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAutoTargetOrigin, "BmGame.RInventoryGadget.GetAutoTargetOrigin");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetCorrectedAutoTargetOrigin;
    /// <summary>
    /// Function: GetCorrectedAutoTargetOrigin
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCorrectedAutoTargetOrigin(out System.Numerics.Vector3 CameraPos, out BmSDK.Rotator AimDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCorrectedAutoTargetOrigin, "BmGame.RInventoryGadget.GetCorrectedAutoTargetOrigin");
        byte* paramsPtr = stackalloc byte[36];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraPos, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AimDirection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CameraPos = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        AimDirection = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetAutoTargetRotation;
    /// <summary>
    /// Function: GetAutoTargetRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetAutoTargetRotation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAutoTargetRotation, "BmGame.RInventoryGadget.GetAutoTargetRotation");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldGadgetAutoTarget;
    /// <summary>
    /// Function: ShouldGadgetAutoTarget
    /// </summary>
    public unsafe virtual bool ShouldGadgetAutoTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGadgetAutoTarget, "BmGame.RInventoryGadget.ShouldGadgetAutoTarget");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsGadgetPlayingAnAnimation;
    /// <summary>
    /// Function: IsGadgetPlayingAnAnimation
    /// </summary>
    public unsafe virtual bool IsGadgetPlayingAnAnimation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGadgetPlayingAnAnimation, "BmGame.RInventoryGadget.IsGadgetPlayingAnAnimation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayGadgetAnim;
    /// <summary>
    /// Function: PlayGadgetAnim
    /// </summary>
    public unsafe virtual void PlayGadgetAnim(BmSDK.FName GadgetAnim)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGadgetAnim, "BmGame.RInventoryGadget.PlayGadgetAnim");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetAnim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPotentialTargetPositions;
    /// <summary>
    /// Function: GetPotentialTargetPositions
    /// </summary>
    public unsafe virtual bool GetPotentialTargetPositions(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out BmSDK.TArray<System.Numerics.Vector3> PotentialTargetPositions, out BmSDK.Engine.Actor LineCheckActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPotentialTargetPositions, "BmGame.RInventoryGadget.GetPotentialTargetPositions");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TargetPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LineCheckActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineCheckActor, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TargetPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        PotentialTargetPositions = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 20);
        LineCheckActor = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_CheckOverrideTarget;
    /// <summary>
    /// Function: CheckOverrideTarget
    /// </summary>
    public unsafe virtual bool CheckOverrideTarget(BmSDK.Engine.Actor BatarangTarget, out System.Numerics.Vector3 BatarangTargetPosition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckOverrideTarget, "BmGame.RInventoryGadget.CheckOverrideTarget");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangTarget, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BatarangTargetPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangTargetPosition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BatarangTargetPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe virtual bool CheckAutoTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange, out byte DoLOSCheck)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmGame.RInventoryGadget.CheckAutoTarget");
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
        TargetPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
        OverrideMaxRange = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        DoLOSCheck = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_UpgradeGadget;
    /// <summary>
    /// Function: UpgradeGadget
    /// </summary>
    public unsafe virtual void UpgradeGadget(int NewUpgradeLevel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradeGadget, "BmGame.RInventoryGadget.UpgradeGadget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUpgradeLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffProjectiles;
    /// <summary>
    /// Function: TurnOffProjectiles
    /// </summary>
    public unsafe virtual void TurnOffProjectiles()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffProjectiles, "BmGame.RInventoryGadget.TurnOffProjectiles");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireProjectile;
    /// <summary>
    /// Function: FireProjectile
    /// </summary>
    public unsafe virtual void FireProjectile(System.Numerics.Vector3 ProjectileTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireProjectile, "BmGame.RInventoryGadget.FireProjectile");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjectileTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Visible;
    /// <summary>
    /// Function: Visible
    /// </summary>
    public unsafe virtual bool Visible()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Visible, "BmGame.RInventoryGadget.Visible");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Selectable;
    /// <summary>
    /// Function: Selectable
    /// </summary>
    public unsafe virtual bool Selectable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Selectable, "BmGame.RInventoryGadget.Selectable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnequipSelf;
    /// <summary>
    /// Function: UnequipSelf
    /// </summary>
    public unsafe virtual bool UnequipSelf()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipSelf, "BmGame.RInventoryGadget.UnequipSelf");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRealAiming;
    /// <summary>
    /// Function: GetRealAiming
    /// </summary>
    public unsafe virtual bool GetRealAiming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRealAiming, "BmGame.RInventoryGadget.GetRealAiming");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAiming;
    /// <summary>
    /// Function: GetAiming
    /// </summary>
    public unsafe virtual bool GetAiming()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAiming, "BmGame.RInventoryGadget.GetAiming");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AimGadget;
    /// <summary>
    /// Function: AimGadget
    /// </summary>
    public unsafe virtual bool AimGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimGadget, "BmGame.RInventoryGadget.AimGadget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CancelGadget;
    /// <summary>
    /// Function: CancelGadget
    /// </summary>
    public unsafe virtual void CancelGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelGadget, "BmGame.RInventoryGadget.CancelGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreRender;
    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe virtual void PreRender(BmSDK.Engine.Canvas HudCanvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreRender, "BmGame.RInventoryGadget.PreRender");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RInventoryGadget.DrawHUD");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerTick;
    /// <summary>
    /// Function: PlayerTick
    /// </summary>
    public unsafe virtual void PlayerTick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerTick, "BmGame.RInventoryGadget.PlayerTick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetName;
    /// <summary>
    /// Function: GetName
    /// </summary>
    public unsafe virtual BmSDK.FString GetName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetName, "BmGame.RInventoryGadget.GetName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ButtonReleased;
    /// <summary>
    /// Function: ButtonReleased
    /// </summary>
    public unsafe virtual void ButtonReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonReleased, "BmGame.RInventoryGadget.ButtonReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsCharging;
    /// <summary>
    /// Function: IsCharging
    /// </summary>
    public unsafe virtual bool IsCharging()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCharging, "BmGame.RInventoryGadget.IsCharging");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFiring;
    /// <summary>
    /// Function: IsFiring
    /// </summary>
    public unsafe virtual bool IsFiring()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFiring, "BmGame.RInventoryGadget.IsFiring");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AdditiveArmAvoidance;
    /// <summary>
    /// Function: AdditiveArmAvoidance
    /// </summary>
    public unsafe virtual void AdditiveArmAvoidance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdditiveArmAvoidance, "BmGame.RInventoryGadget.AdditiveArmAvoidance");
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugRestoreAmmo;
    /// <summary>
    /// Function: DebugRestoreAmmo
    /// </summary>
    public unsafe virtual void DebugRestoreAmmo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugRestoreAmmo, "BmGame.RInventoryGadget.DebugRestoreAmmo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestockAmmo;
    /// <summary>
    /// Function: RestockAmmo
    /// </summary>
    public unsafe virtual void RestockAmmo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestockAmmo, "BmGame.RInventoryGadget.RestockAmmo");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSingleIntAmmoValue;
    /// <summary>
    /// Function: GetSingleIntAmmoValue
    /// </summary>
    public unsafe virtual int GetSingleIntAmmoValue()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSingleIntAmmoValue, "BmGame.RInventoryGadget.GetSingleIntAmmoValue");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateGadgetHUDParams;
    /// <summary>
    /// Function: UpdateGadgetHUDParams
    /// </summary>
    public unsafe virtual void UpdateGadgetHUDParams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGadgetHUDParams, "BmGame.RInventoryGadget.UpdateGadgetHUDParams");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGadgetHighlight;
    /// <summary>
    /// Function: UpdateGadgetHighlight
    /// </summary>
    public unsafe virtual void UpdateGadgetHighlight(int HighlightedGadget, bool _bHighlighted)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGadgetHighlight, "BmGame.RInventoryGadget.UpdateGadgetHighlight");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighlightedGadget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_bHighlighted, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDisableTick;
    /// <summary>
    /// Function: CanDisableTick
    /// </summary>
    public unsafe virtual bool CanDisableTick()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDisableTick, "BmGame.RInventoryGadget.CanDisableTick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetQuickThrowFailedAnim;
    /// <summary>
    /// Function: GetQuickThrowFailedAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetQuickThrowFailedAnim()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQuickThrowFailedAnim, "BmGame.RInventoryGadget.GetQuickThrowFailedAnim");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryQuickFire;
    /// <summary>
    /// Function: TryQuickFire
    /// </summary>
    public unsafe virtual void TryQuickFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryQuickFire, "BmGame.RInventoryGadget.TryQuickFire");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RInventoryGadget.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanQuickFire;
    /// <summary>
    /// Function: CanQuickFire
    /// </summary>
    public unsafe virtual bool CanQuickFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanQuickFire, "BmGame.RInventoryGadget.CanQuickFire");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNextState;
    /// <summary>
    /// Function: GetNextState
    /// </summary>
    public unsafe virtual BmSDK.FName GetNextState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextState, "BmGame.RInventoryGadget.GetNextState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GadgetUsed;
    /// <summary>
    /// Function: GadgetUsed
    /// </summary>
    public unsafe virtual void GadgetUsed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetUsed, "BmGame.RInventoryGadget.GadgetUsed");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SecondaryFireReleased;
    /// <summary>
    /// Function: SecondaryFireReleased
    /// </summary>
    public unsafe virtual void SecondaryFireReleased()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecondaryFireReleased, "BmGame.RInventoryGadget.SecondaryFireReleased");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SecondaryButtonPressed;
    /// <summary>
    /// Function: SecondaryButtonPressed
    /// </summary>
    public unsafe virtual void SecondaryButtonPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecondaryButtonPressed, "BmGame.RInventoryGadget.SecondaryButtonPressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ButtonPressed;
    /// <summary>
    /// Function: ButtonPressed
    /// </summary>
    public unsafe virtual void ButtonPressed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonPressed, "BmGame.RInventoryGadget.ButtonPressed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnequipAllOtherGadgets;
    /// <summary>
    /// Function: UnequipAllOtherGadgets
    /// </summary>
    public unsafe virtual void UnequipAllOtherGadgets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipAllOtherGadgets, "BmGame.RInventoryGadget.UnequipAllOtherGadgets");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGadgetAttachedToHand;
    /// <summary>
    /// Function: IsGadgetAttachedToHand
    /// </summary>
    public unsafe virtual bool IsGadgetAttachedToHand()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGadgetAttachedToHand, "BmGame.RInventoryGadget.IsGadgetAttachedToHand");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe virtual void SetInXrayMode(bool On, bool bForceOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmGame.RInventoryGadget.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToHand;
    /// <summary>
    /// Function: AttachToHand
    /// </summary>
    public unsafe virtual void AttachToHand(BmSDK.FName CustomBone = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToHand, "BmGame.RInventoryGadget.AttachToHand");
        byte* paramsPtr = stackalloc byte[21];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateEquipBoneName;
    /// <summary>
    /// Function: CalculateEquipBoneName
    /// </summary>
    public unsafe virtual void CalculateEquipBoneName(out BmSDK.FName OutEquipBoneName, out BmSDK.FName OutEquipBoneName2, out BmSDK.Rotator OutRelativeRotation, BmSDK.FName CustomBone = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateEquipBoneName, "BmGame.RInventoryGadget.CalculateEquipBoneName");
        byte* paramsPtr = stackalloc byte[44];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutEquipBoneName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutEquipBoneName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutEquipBoneName2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutEquipBoneName2, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutRelativeRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutRelativeRotation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomBone, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutEquipBoneName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
        OutEquipBoneName2 = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
        OutRelativeRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_AttachToBelt;
    /// <summary>
    /// Function: AttachToBelt
    /// </summary>
    public unsafe virtual void AttachToBelt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToBelt, "BmGame.RInventoryGadget.AttachToBelt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldIgnoreScreenCheckForTarget;
    /// <summary>
    /// Function: ShouldIgnoreScreenCheckForTarget
    /// </summary>
    public unsafe virtual bool ShouldIgnoreScreenCheckForTarget(BmSDK.Engine.Actor TargetToCheck)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldIgnoreScreenCheckForTarget, "BmGame.RInventoryGadget.ShouldIgnoreScreenCheckForTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetToCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShouldAimAt;
    /// <summary>
    /// Function: ShouldAimAt
    /// </summary>
    public unsafe virtual bool ShouldAimAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldAimAt, "BmGame.RInventoryGadget.ShouldAimAt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CameraZoomChanged;
    /// <summary>
    /// Function: CameraZoomChanged
    /// </summary>
    public unsafe virtual void CameraZoomChanged(bool bCurrentlyZoomed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CameraZoomChanged, "BmGame.RInventoryGadget.CameraZoomChanged");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCurrentlyZoomed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetClassNameForHUD;
    /// <summary>
    /// Function: GetGadgetClassNameForHUD
    /// </summary>
    public unsafe virtual BmSDK.FName GetGadgetClassNameForHUD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetClassNameForHUD, "BmGame.RInventoryGadget.GetGadgetClassNameForHUD");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAimAtRotation;
    /// <summary>
    /// Function: GetAimAtRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetAimAtRotation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimAtRotation, "BmGame.RInventoryGadget.GetAimAtRotation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowCrossHair;
    /// <summary>
    /// Function: ShowCrossHair
    /// </summary>
    public unsafe virtual bool ShowCrossHair()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCrossHair, "BmGame.RInventoryGadget.ShowCrossHair");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowHighlightGadget;
    /// <summary>
    /// Function: ShowHighlightGadget
    /// </summary>
    public unsafe virtual void ShowHighlightGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowHighlightGadget, "BmGame.RInventoryGadget.ShowHighlightGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupRainMaterials;
    /// <summary>
    /// Function: SetupRainMaterials
    /// </summary>
    public unsafe virtual void SetupRainMaterials()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupRainMaterials, "BmGame.RInventoryGadget.SetupRainMaterials");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RInventoryGadget.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FHighlightedMesh
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial record struct FHighlightedMesh
    {
        /// <summary>
        /// ObjectProperty: TargetActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor TargetActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ComponentProperty: OriginalSkelMesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMeshComponent OriginalSkelMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ComponentProperty: HighlightSkelMesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMeshComponent HighlightSkelMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ComponentProperty: OriginalStaticMesh
        /// </summary>
        public unsafe BmSDK.Engine.StaticMeshComponent OriginalStaticMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ComponentProperty: HighlightStaticMesh
        /// </summary>
        public unsafe BmSDK.Engine.StaticMeshComponent HighlightStaticMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: CentreForTargetBounds
        /// </summary>
        public unsafe System.Numerics.Vector3 CentreForTargetBounds
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// NameProperty: nHitBoneName
        /// </summary>
        public unsafe BmSDK.FName nHitBoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bHasAmmoLeft
        /// </summary>
        public unsafe bool bHasAmmoLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }; }
        }

        /// <summary>
        /// ByteProperty: Type
        /// </summary>
        public unsafe BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: Tagged
        /// </summary>
        public unsafe bool Tagged
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bCanStillBeShot
        /// </summary>
        public unsafe bool bCanStillBeShot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bExplosive
        /// </summary>
        public unsafe bool bExplosive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bNeedsUpgrade
        /// </summary>
        public unsafe bool bNeedsUpgrade
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bNormalViewMode
        /// </summary>
        public unsafe bool bNormalViewMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bForCamouflageThug
        /// </summary>
        public unsafe bool bForCamouflageThug
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bSpecialTrackerTarget
        /// </summary>
        public unsafe bool bSpecialTrackerTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bCurrentTarget
        /// </summary>
        public unsafe bool bCurrentTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bHidden
        /// </summary>
        public unsafe bool bHidden
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: StillRelevant
        /// </summary>
        public unsafe bool StillRelevant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// StrProperty: HUDDescription
        /// </summary>
        public unsafe BmSDK.FString HUDDescription
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
    }

    /// <summary>
    /// Enum: EHighlightedTargetType
    /// </summary>
    public enum EHighlightedTargetType : byte
    {
        HTT_None = 0,
        HTT_Firearm = 1,
        HTT_StunStick = 2,
        HTT_Equipment = 3,
        HTT_Car = 4,
        HTT_Drone = 5,
        HTT_Tank = 6,
        HTT_Cache = 7,
        HTT_MAX = 8,
    }

    /// <summary>
    /// Enum: FGadgetIDs
    /// </summary>
    public enum FGadgetIDs : byte
    {
        FGID_None = 0,
        FGID_Batarang = 1,
        FGID_ExplosiveGel = 2,
        FGID_Batclaw = 3,
        FGID_UltraBatclaw = 4,
        FGID_Resonator = 5,
        FGID_LineLauncher = 6,
        FGID_BatarangMulti2 = 7,
        FGID_BatarangMulti3 = 8,
        FGID_RHD = 9,
        FGID_VoiceSynthesiser = 10,
        FGID_BatarangControlable = 11,
        FGID_JokerSpecs = 12,
        FGID_JokerGun = 13,
        FGID_JokerTeeth = 14,
        FGID_MAX = 15,
    }

    /// <summary>
    /// ByteProperty: GadgetState
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.GadgetEquipState GadgetState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.GadgetEquipState>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ByteProperty: GadgetType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction GadgetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 785); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 785); }
    }

    /// <summary>
    /// ByteProperty: QuickGadgetType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction QuickGadgetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 786); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 786); }
    }

    /// <summary>
    /// ByteProperty: ThrowType
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.BatarangThrowType ThrowType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.BatarangThrowType>(Ptr + 787); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 787); }
    }

    /// <summary>
    /// ByteProperty: HudGadgetId
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.FGadgetIDs HudGadgetId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.FGadgetIDs>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ByteProperty: HudSlot
    /// </summary>
    public unsafe byte HudSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 789); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 789); }
    }

    /// <summary>
    /// ByteProperty: HudSlotPC
    /// </summary>
    public unsafe byte HudSlotPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 790); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 790); }
    }

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ComponentProperty: Mesh2
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Mesh2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: XrayMaskMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMaskMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: CachedTargetClass
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass CachedTargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ObjectProperty: GadgetSelectMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface GadgetSelectMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: GetOutSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GetOutSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: OverrideTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass OverrideTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ObjectProperty: LastPlayedGadgetSpeech
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech LastPlayedGadgetSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ObjectProperty: FailedGadgetSpeechReplacementSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FailedGadgetSpeechReplacementSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// NameProperty: CurrEquippedBoneName
    /// </summary>
    public unsafe BmSDK.FName CurrEquippedBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// NameProperty: CurrEquippedBoneName2
    /// </summary>
    public unsafe BmSDK.FName CurrEquippedBoneName2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// NameProperty: EquipBoneName
    /// </summary>
    public unsafe BmSDK.FName EquipBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// NameProperty: EquipBoneName2
    /// </summary>
    public unsafe BmSDK.FName EquipBoneName2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: ThrowEquipBoneNameOverride
    /// </summary>
    public InlineArray<BmSDK.FName> ThrowEquipBoneNameOverride => new(13, Ptr + 904, 8, this);

    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: ThrowEquipBoneName2Override
    /// </summary>
    public InlineArray<BmSDK.FName> ThrowEquipBoneName2Override => new(13, Ptr + 1008, 8, this);

    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// NameProperty: UnequipBoneName
    /// </summary>
    public unsafe BmSDK.FName UnequipBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bSelectable
    /// </summary>
    public unsafe bool bSelectable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bAiming
    /// </summary>
    public unsafe bool bAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bAutomaticAiming
    /// </summary>
    public unsafe bool bAutomaticAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bNoQuickFire
    /// </summary>
    public unsafe bool bNoQuickFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUnequipToSocket
    /// </summary>
    public unsafe bool bUnequipToSocket
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bCanUseXRay
    /// </summary>
    public unsafe bool bCanUseXRay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bCanRechargeFromZeroAmmo
    /// </summary>
    public unsafe bool bCanRechargeFromZeroAmmo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUsableFromVantagePoints
    /// </summary>
    public unsafe bool bUsableFromVantagePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUsableFromCornerCover
    /// </summary>
    public unsafe bool bUsableFromCornerCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUsableFromCrawlSpace
    /// </summary>
    public unsafe bool bUsableFromCrawlSpace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bNotUsableFromWire
    /// </summary>
    public unsafe bool bNotUsableFromWire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bLeaveCoverAfterThrow
    /// </summary>
    public unsafe bool bLeaveCoverAfterThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bCanUseFromSilentPredator
    /// </summary>
    public unsafe bool bCanUseFromSilentPredator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bDontLockCornerAiming
    /// </summary>
    public unsafe bool bDontLockCornerAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bForceShowGadget
    /// </summary>
    public unsafe bool bForceShowGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bRunningThrow
    /// </summary>
    public unsafe bool bRunningThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bCanEquipWhileRecharging
    /// </summary>
    public unsafe bool bCanEquipWhileRecharging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bCanEquipWhileFlying
    /// </summary>
    public unsafe bool bCanEquipWhileFlying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bSelectableLast
    /// </summary>
    public unsafe bool bSelectableLast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: AutoTargetRequiresLOS
    /// </summary>
    public unsafe bool AutoTargetRequiresLOS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: MustAutoTarget
    /// </summary>
    public unsafe bool MustAutoTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUseAbsoluteTurnForGetOut
    /// </summary>
    public unsafe bool bUseAbsoluteTurnForGetOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUseRechargeDisplay
    /// </summary>
    public unsafe bool bUseRechargeDisplay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bDoLOSCheckFromPawn
    /// </summary>
    public unsafe bool bDoLOSCheckFromPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bGadgetCanBeMirrored
    /// </summary>
    public unsafe bool bGadgetCanBeMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bRecharging
    /// </summary>
    public unsafe bool bRecharging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bHighlighted
    /// </summary>
    public unsafe bool bHighlighted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bXRayMode
    /// </summary>
    public unsafe bool bXRayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bAllowGrappleUse
    /// </summary>
    public unsafe bool bAllowGrappleUse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bReverseButtonControlsOnPS3
    /// </summary>
    public unsafe bool bReverseButtonControlsOnPS3
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bEmergencyFire
    /// </summary>
    public unsafe bool bEmergencyFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bOverriddenCombatMove
    /// </summary>
    public unsafe bool bOverriddenCombatMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAllowRun
    /// </summary>
    public unsafe bool bOverrideAllowRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysUseHorizontalAutoTargetHelp
    /// </summary>
    public unsafe bool bAlwaysUseHorizontalAutoTargetHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bQuickGlideGadget
    /// </summary>
    public unsafe bool bQuickGlideGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bCanUseInteractableItemWhileAiming
    /// </summary>
    public unsafe bool bCanUseInteractableItemWhileAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bNeverTargetOffscreen
    /// </summary>
    public unsafe bool bNeverTargetOffscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreAngleCheck
    /// </summary>
    public unsafe bool bIgnoreAngleCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bGetOutSoundIsLooping
    /// </summary>
    public unsafe bool bGetOutSoundIsLooping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: ShownNoGadget
    /// </summary>
    public unsafe bool ShownNoGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bKeepCursorsWhenHolstered
    /// </summary>
    public unsafe bool bKeepCursorsWhenHolstered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bSharedWithNewGamePlus
    /// </summary>
    public unsafe bool bSharedWithNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bRequiresPawnForLOS
    /// </summary>
    public unsafe bool bRequiresPawnForLOS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bHideHighlightsInDetectiveMode
    /// </summary>
    public unsafe bool bHideHighlightsInDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bDontAutoTargetDown
    /// </summary>
    public unsafe bool bDontAutoTargetDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bOverrideWorldPPSettings
    /// </summary>
    public unsafe bool bOverrideWorldPPSettings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bOverrideTargetWeightsWhenZoomed
    /// </summary>
    public unsafe bool bOverrideTargetWeightsWhenZoomed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// NameProperty: GlobalFlag
    /// </summary>
    public unsafe BmSDK.FName GlobalFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// IntProperty: MaxAmmo
    /// </summary>
    public unsafe int MaxAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: Ammo
    /// </summary>
    public unsafe int Ammo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: CurrentRechargeTime
    /// </summary>
    public unsafe float CurrentRechargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: CurrentRechargeValOverride
    /// </summary>
    public unsafe int CurrentRechargeValOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// FloatProperty: InterThrowRechargeTime
    /// </summary>
    public unsafe float InterThrowRechargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: UpgradeLevel
    /// </summary>
    public unsafe int UpgradeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// IntProperty: MaxUpgradeLevel
    /// </summary>
    public unsafe int MaxUpgradeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: AutoTargetAnglePower
    /// </summary>
    public unsafe int AutoTargetAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetAngleWeight
    /// </summary>
    public unsafe float AutoTargetAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetRangeWeight
    /// </summary>
    public unsafe float AutoTargetRangeWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// StructProperty: AutoTargetExtCamRotationOffset
    /// </summary>
    public unsafe ref BmSDK.Rotator AutoTargetExtCamRotationOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1176);

    /// <summary>
    /// IntProperty: MaxCornerViewAngle
    /// </summary>
    public unsafe int MaxCornerViewAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// IntProperty: AmmoLast
    /// </summary>
    public unsafe int AmmoLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: LookSensitivity
    /// </summary>
    public unsafe float LookSensitivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// StructProperty: ThrowTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ThrowTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 1200);

    /// <summary>
    /// NameProperty: TargetClass
    /// </summary>
    public unsafe BmSDK.FName TargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// NameProperty: CachedTargetClassName
    /// </summary>
    public unsafe BmSDK.FName CachedTargetClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// StructProperty: EmergencyThrowDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EmergencyThrowDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1220);

    /// <summary>
    /// FloatProperty: AutoTargetPlaneOffset
    /// </summary>
    public unsafe float AutoTargetPlaneOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// StrProperty: TutorialText
    /// </summary>
    public unsafe BmSDK.FString TutorialText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// StrProperty: TutorialFlag
    /// </summary>
    public unsafe BmSDK.FString TutorialFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// StrProperty: GlidingSuccessIcon
    /// </summary>
    public unsafe BmSDK.FString GlidingSuccessIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// IntProperty: CurrHuDAmmo
    /// </summary>
    public unsafe int CurrHuDAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// IntProperty: CurrHuDRecharge
    /// </summary>
    public unsafe int CurrHuDRecharge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: DefaultHighlightTimerCheck
    /// </summary>
    public unsafe float DefaultHighlightTimerCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// FloatProperty: HighlightTimerCheck
    /// </summary>
    public unsafe float HighlightTimerCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// IntProperty: GadgetListEnum
    /// </summary>
    public unsafe int GadgetListEnum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// FloatProperty: DestructibleImpactMomentum
    /// </summary>
    public unsafe float DestructibleImpactMomentum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: DestructibleImpactDamage
    /// </summary>
    public unsafe float DestructibleImpactDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// StructProperty: GetOutSoundSoundHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle GetOutSoundSoundHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 1312);

    /// <summary>
    /// NameProperty: WireLeftTurn
    /// </summary>
    public unsafe BmSDK.FName WireLeftTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// NameProperty: WireRightTurn
    /// </summary>
    public unsafe BmSDK.FName WireRightTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// NameProperty: RailingLeftTurn
    /// </summary>
    public unsafe BmSDK.FName RailingLeftTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// NameProperty: RailingRightTurn
    /// </summary>
    public unsafe BmSDK.FName RailingRightTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// NameProperty: QuickFireCameraState
    /// </summary>
    public unsafe BmSDK.FName QuickFireCameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// StrProperty: AssociatedGadgetFlagName
    /// </summary>
    public unsafe BmSDK.FString AssociatedGadgetFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// StructProperty: MirrorRelativeRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator MirrorRelativeRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1384);

    /// <summary>
    /// ArrayProperty: CurrentHighlightTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> CurrentHighlightTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ArrayProperty: HighlightedMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh> HighlightedMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// IntProperty: iMaxHighlightMeshes
    /// </summary>
    public unsafe int iMaxHighlightMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// FloatProperty: fHighlightDepthBiasMinimumValue
    /// </summary>
    public unsafe float fHighlightDepthBiasMinimumValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// FloatProperty: fHighlightDepthBiasMaximumValue
    /// </summary>
    public unsafe float fHighlightDepthBiasMaximumValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// FloatProperty: fHighlightDepthBiasLerpStartDistance
    /// </summary>
    public unsafe float fHighlightDepthBiasLerpStartDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// FloatProperty: fHighlightDepthBiasLerpEndDistance
    /// </summary>
    public unsafe float fHighlightDepthBiasLerpEndDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// ArrayProperty: CachedSkelMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent> CachedSkelMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent>>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// ArrayProperty: CachedStaticMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.StaticMeshComponent> CachedStaticMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.StaticMeshComponent>>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// FloatProperty: fLastPlayedGadgetSpeechTime
    /// </summary>
    public unsafe float fLastPlayedGadgetSpeechTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// FloatProperty: fGadgetSpeechCooldownTime
    /// </summary>
    public unsafe float fGadgetSpeechCooldownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// ArrayProperty: RainMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> RainMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// NameProperty: RainParameterName
    /// </summary>
    public unsafe BmSDK.FName RainParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// FloatProperty: TargetCapeBlendWeight
    /// </summary>
    public unsafe float TargetCapeBlendWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// StructProperty: WorldPPSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.PostProcessVolume.FPostProcessSettings WorldPPSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 1516);

    /// <summary>
    /// StructProperty: vAdditiveArmAvoidanceTraceExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vAdditiveArmAvoidanceTraceExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2040);

    /// <summary>
    /// FloatProperty: fAdditiveArmAvoidanceRightBias
    /// </summary>
    public unsafe float fAdditiveArmAvoidanceRightBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// FloatProperty: fAdditiveArmAvoidanceTraceDistance
    /// </summary>
    public unsafe float fAdditiveArmAvoidanceTraceDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// FloatProperty: fAdditiveArmAvoidanceMaximumAvoidanceDistance
    /// </summary>
    public unsafe float fAdditiveArmAvoidanceMaximumAvoidanceDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// FloatProperty: fAdditiveArmAvoidanceInterpolationDistance
    /// </summary>
    public unsafe float fAdditiveArmAvoidanceInterpolationDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// Struct: FGlideGadgetTargetContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FGlideGadgetTargetContainer
    {
        /// <summary>
        /// StrProperty: IconAnimName
        /// </summary>
        public unsafe BmSDK.FString IconAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: TargetActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor TargetActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: CoverCornerType
    /// </summary>
    public enum CoverCornerType : byte
    {
        CCT_NoCorner = 0,
        CCT_LeftCorner = 1,
        CCT_RightCorner = 2,
        CCT_MAX = 3,
    }

    /// <summary>
    /// Enum: BatarangThrowType
    /// </summary>
    public enum BatarangThrowType : byte
    {
        BTT_NullThrow = 0,
        BTT_StandingThrow = 1,
        BTT_CoverLeftThrow = 2,
        BTT_CoverRightThrow = 3,
        BTT_VantagePointThrow = 4,
        BTT_WireThrow = 5,
        BTT_RailingThrow = 6,
        BTT_CeilingThrow = 7,
        BTT_CrawlSpaceThrow = 8,
        BTT_ComboThrow = 9,
        BTT_RunningComboThrow = 10,
        BTT_GlidingThrow = 11,
        BTT_WhipRappelThrow = 12,
        BTT_NUMBatarangThrowTypes = 13,
        BTT_MAX = 14,
    }

    /// <summary>
    /// Enum: PlayerWantsToCrouch
    /// </summary>
    public enum PlayerWantsToCrouch : byte
    {
        PWC_Crouch = 0,
        PWC_StandUp = 1,
        PWC_MAX = 2,
    }

    /// <summary>
    /// Enum: GadgetEquipState
    /// </summary>
    public enum GadgetEquipState : byte
    {
        GS_AttachedToBelt = 0,
        GS_AttachetToHand = 1,
        GS_None = 2,
        GS_MAX = 3,
    }
}
