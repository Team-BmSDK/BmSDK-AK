#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerCatwoman<br/>
/// (size = 10412)
/// (flags = 10485814)
/// </summary>
public partial class RPawnPlayerCatwoman : BmSDK.BmGame.RPawnPlayerCatwomanBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerCatwoman", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerCatwoman.
    /// </summary>
    public static RPawnPlayerCatwoman DefaultObject => (RPawnPlayerCatwoman)StaticClass().DefaultObject;

    internal RPawnPlayerCatwoman() { }

    /// <summary>
    /// Constructs a new RPawnPlayerCatwoman
    /// </summary>
    public RPawnPlayerCatwoman(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerCatwoman(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ClimbOnWall;
    /// <summary>
    /// Function: ClimbOnWall
    /// </summary>
    public unsafe override void ClimbOnWall()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClimbOnWall, "BmScript.RPawnPlayerCatwoman.ClimbOnWall");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFailedPairedAnimMoveAnimset;
    /// <summary>
    /// Function: GetFailedPairedAnimMoveAnimset
    /// </summary>
    public unsafe override void GetFailedPairedAnimMoveAnimset(out BmSDK.Engine.AnimSet MyAnimset, BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFailedPairedAnimMoveAnimset, "BmScript.RPawnPlayerCatwoman.GetFailedPairedAnimMoveAnimset");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MyAnimset = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CanJumpOffWallStick;
    /// <summary>
    /// Function: CanJumpOffWallStick
    /// </summary>
    public unsafe override bool CanJumpOffWallStick(BmSDK.BmGame.RSpecialMoveConfig Config, BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanJumpOffWallStick, "BmScript.RPawnPlayerCatwoman.CanJumpOffWallStick");
        byte* paramsPtr = stackalloc byte[160];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_DieOnCeilingsOnly;
    /// <summary>
    /// Function: DieOnCeilingsOnly
    /// </summary>
    public unsafe virtual void DieOnCeilingsOnly(bool bOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DieOnCeilingsOnly, "BmScript.RPawnPlayerCatwoman.DieOnCeilingsOnly");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUnlockedMeleeArmourLevel;
    /// <summary>
    /// Function: GetUnlockedMeleeArmourLevel
    /// </summary>
    public unsafe override int GetUnlockedMeleeArmourLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedMeleeArmourLevel, "BmScript.RPawnPlayerCatwoman.GetUnlockedMeleeArmourLevel");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUnlockedBallisticArmourLevel;
    /// <summary>
    /// Function: GetUnlockedBallisticArmourLevel
    /// </summary>
    public unsafe override int GetUnlockedBallisticArmourLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedBallisticArmourLevel, "BmScript.RPawnPlayerCatwoman.GetUnlockedBallisticArmourLevel");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPersistentMeleeArmour;
    /// <summary>
    /// Function: SetPersistentMeleeArmour
    /// </summary>
    public unsafe override void SetPersistentMeleeArmour(int armour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPersistentMeleeArmour, "BmScript.RPawnPlayerCatwoman.SetPersistentMeleeArmour");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPersistentBallisticArmour;
    /// <summary>
    /// Function: SetPersistentBallisticArmour
    /// </summary>
    public unsafe override void SetPersistentBallisticArmour(int armour)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPersistentBallisticArmour, "BmScript.RPawnPlayerCatwoman.SetPersistentBallisticArmour");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPersistentMeleeArmour;
    /// <summary>
    /// Function: GetPersistentMeleeArmour
    /// </summary>
    public unsafe override int GetPersistentMeleeArmour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPersistentMeleeArmour, "BmScript.RPawnPlayerCatwoman.GetPersistentMeleeArmour");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPersistentBallisticArmour;
    /// <summary>
    /// Function: GetPersistentBallisticArmour
    /// </summary>
    public unsafe override int GetPersistentBallisticArmour()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPersistentBallisticArmour, "BmScript.RPawnPlayerCatwoman.GetPersistentBallisticArmour");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnHelicopterHit;
    /// <summary>
    /// Function: OnHelicopterHit
    /// </summary>
    public unsafe override void OnHelicopterHit(BmSDK.BmGame.RHelicopterBase Heli, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnHelicopterHit, "BmScript.RPawnPlayerCatwoman.OnHelicopterHit");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heli, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStrikeTrailPS;
    /// <summary>
    /// Function: GetStrikeTrailPS
    /// </summary>
    public unsafe override BmSDK.Engine.ParticleSystem GetStrikeTrailPS(BmSDK.Class StrikeDmgType, bool bIsSuperStrike, int ComboLevel)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeTrailPS, "BmScript.RPawnPlayerCatwoman.GetStrikeTrailPS");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSuperStrike, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboLevel, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PlayCrowStartledLine;
    /// <summary>
    /// Function: PlayCrowStartledLine
    /// </summary>
    public unsafe override void PlayCrowStartledLine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCrowStartledLine, "BmScript.RPawnPlayerCatwoman.PlayCrowStartledLine");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CantPullOffGrateLine;
    /// <summary>
    /// Function: CantPullOffGrateLine
    /// </summary>
    public unsafe override void CantPullOffGrateLine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CantPullOffGrateLine, "BmScript.RPawnPlayerCatwoman.CantPullOffGrateLine");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMaterialParameters;
    /// <summary>
    /// Function: UpdateMaterialParameters
    /// </summary>
    public unsafe virtual void UpdateMaterialParameters(bool bForceIndoor = default, bool bForceOutdoor = default, float ForceBrightness = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMaterialParameters, "BmScript.RPawnPlayerCatwoman.UpdateMaterialParameters");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceIndoor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOutdoor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceBrightness, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLevelChange;
    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe override void OnLevelChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelChange, "BmScript.RPawnPlayerCatwoman.OnLevelChange");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmScript.RPawnPlayerCatwoman.OnRoomChange");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSpeakDuringDeath;
    /// <summary>
    /// Function: CanSpeakDuringDeath
    /// </summary>
    public unsafe override bool CanSpeakDuringDeath(BmSDK.Engine.AkDialogueSpeech Speech)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpeakDuringDeath, "BmScript.RPawnPlayerCatwoman.CanSpeakDuringDeath");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speech, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CoughTimer;
    /// <summary>
    /// Function: CoughTimer
    /// </summary>
    public unsafe virtual void CoughTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CoughTimer, "BmScript.RPawnPlayerCatwoman.CoughTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmScript.RPawnPlayerCatwoman.TakeDamage");
        byte* paramsPtr = stackalloc byte[224];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerInterrogationMove;
    /// <summary>
    /// Function: TriggerInterrogationMove
    /// </summary>
    public unsafe override void TriggerInterrogationMove(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerInterrogationMove, "BmScript.RPawnPlayerCatwoman.TriggerInterrogationMove");
        byte* paramsPtr = stackalloc byte[184];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayWhipImpactFX;
    /// <summary>
    /// Function: PlayWhipImpactFX
    /// </summary>
    public unsafe virtual void PlayWhipImpactFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayWhipImpactFX, "BmScript.RPawnPlayerCatwoman.PlayWhipImpactFX");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayPounceHardLandFX;
    /// <summary>
    /// Function: PlayPounceHardLandFX
    /// </summary>
    public unsafe virtual void PlayPounceHardLandFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayPounceHardLandFX, "BmScript.RPawnPlayerCatwoman.PlayPounceHardLandFX");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayPounceLandFX;
    /// <summary>
    /// Function: PlayPounceLandFX
    /// </summary>
    public unsafe virtual void PlayPounceLandFX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayPounceLandFX, "BmScript.RPawnPlayerCatwoman.PlayPounceLandFX");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InvestigateModeEyes;
    /// <summary>
    /// Function: InvestigateModeEyes
    /// </summary>
    public unsafe override void InvestigateModeEyes(bool bOnOrOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InvestigateModeEyes, "BmScript.RPawnPlayerCatwoman.InvestigateModeEyes");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnOrOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetAutoSwing;
    /// <summary>
    /// Function: ResetAutoSwing
    /// </summary>
    public unsafe override void ResetAutoSwing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetAutoSwing, "BmScript.RPawnPlayerCatwoman.ResetAutoSwing");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerAerialWhipPounce;
    /// <summary>
    /// Function: TriggerAerialWhipPounce
    /// </summary>
    public unsafe override bool TriggerAerialWhipPounce()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAerialWhipPounce, "BmScript.RPawnPlayerCatwoman.TriggerAerialWhipPounce");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEdgeSwingGrappleLocation;
    /// <summary>
    /// Function: GetEdgeSwingGrappleLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetEdgeSwingGrappleLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingGrappleLocation, "BmScript.RPawnPlayerCatwoman.GetEdgeSwingGrappleLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEdgeSwingWallLocation;
    /// <summary>
    /// Function: GetEdgeSwingWallLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetEdgeSwingWallLocation(out System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingWallLocation, "BmScript.RPawnPlayerCatwoman.GetEdgeSwingWallLocation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        WallNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetEdgeSwingStartLocation;
    /// <summary>
    /// Function: GetEdgeSwingStartLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetEdgeSwingStartLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingStartLocation, "BmScript.RPawnPlayerCatwoman.GetEdgeSwingStartLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAutoSwingToGargoyle;
    /// <summary>
    /// Function: IsAutoSwingToGargoyle
    /// </summary>
    public unsafe override bool IsAutoSwingToGargoyle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAutoSwingToGargoyle, "BmScript.RPawnPlayerCatwoman.IsAutoSwingToGargoyle");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAutoSwing;
    /// <summary>
    /// Function: IsAutoSwing
    /// </summary>
    public unsafe override bool IsAutoSwing()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAutoSwing, "BmScript.RPawnPlayerCatwoman.IsAutoSwing");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidClimbStartPoint;
    /// <summary>
    /// Function: IsValidClimbStartPoint
    /// </summary>
    public unsafe override bool IsValidClimbStartPoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidClimbStartPoint, "BmScript.RPawnPlayerCatwoman.IsValidClimbStartPoint");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFirstClimbPoint;
    /// <summary>
    /// Function: GetFirstClimbPoint
    /// </summary>
    public unsafe override void GetFirstClimbPoint(out System.Numerics.Vector3 Position, out System.Numerics.Vector3 Normal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFirstClimbPoint, "BmScript.RPawnPlayerCatwoman.GetFirstClimbPoint");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Position = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        Normal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_RecalculatePath;
    /// <summary>
    /// Function: RecalculatePath
    /// </summary>
    public unsafe override void RecalculatePath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecalculatePath, "BmScript.RPawnPlayerCatwoman.RecalculatePath");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasPath;
    /// <summary>
    /// Function: HasPath
    /// </summary>
    public unsafe override bool HasPath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasPath, "BmScript.RPawnPlayerCatwoman.HasPath");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearPath;
    /// <summary>
    /// Function: ClearPath
    /// </summary>
    public unsafe override void ClearPath()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPath, "BmScript.RPawnPlayerCatwoman.ClearPath");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPickPocketing;
    /// <summary>
    /// Function: TriggerPickPocketing
    /// </summary>
    public unsafe override void TriggerPickPocketing(BmSDK.BmGame.RPawnVillain Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPickPocketing, "BmScript.RPawnPlayerCatwoman.TriggerPickPocketing");
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnFootstepParticles;
    /// <summary>
    /// Function: SpawnFootstepParticles
    /// </summary>
    public unsafe override void SpawnFootstepParticles(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact, System.Numerics.Vector3 FootLocation, BmSDK.Engine.RPhysicalMaterialProperty Property)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFootstepParticles, "BmScript.RPawnPlayerCatwoman.SpawnFootstepParticles");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FootLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Property, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStunMove;
    /// <summary>
    /// Function: GetStunMove
    /// </summary>
    public unsafe override BmSDK.Class GetStunMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunMove, "BmScript.RPawnPlayerCatwoman.GetStunMove");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OpenGrateFromBelow;
    /// <summary>
    /// Function: OpenGrateFromBelow
    /// </summary>
    public unsafe virtual void OpenGrateFromBelow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenGrateFromBelow, "BmScript.RPawnPlayerCatwoman.OpenGrateFromBelow");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenGrateFromAbove;
    /// <summary>
    /// Function: OpenGrateFromAbove
    /// </summary>
    public unsafe virtual void OpenGrateFromAbove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenGrateFromAbove, "BmScript.RPawnPlayerCatwoman.OpenGrateFromAbove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerGrateFromCeilingMove;
    /// <summary>
    /// Function: TriggerGrateFromCeilingMove
    /// </summary>
    public unsafe override void TriggerGrateFromCeilingMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGrateFromCeilingMove, "BmScript.RPawnPlayerCatwoman.TriggerGrateFromCeilingMove");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerGrateToCeilingMove;
    /// <summary>
    /// Function: TriggerGrateToCeilingMove
    /// </summary>
    public unsafe override void TriggerGrateToCeilingMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGrateToCeilingMove, "BmScript.RPawnPlayerCatwoman.TriggerGrateToCeilingMove");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PounceOnThug;
    /// <summary>
    /// Function: PounceOnThug
    /// </summary>
    public unsafe override void PounceOnThug(BmSDK.BmGame.RPawnVillain Target)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PounceOnThug, "BmScript.RPawnPlayerCatwoman.PounceOnThug");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerHitAndDropFromCeilingMove;
    /// <summary>
    /// Function: TriggerHitAndDropFromCeilingMove
    /// </summary>
    public unsafe override void TriggerHitAndDropFromCeilingMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerHitAndDropFromCeilingMove, "BmScript.RPawnPlayerCatwoman.TriggerHitAndDropFromCeilingMove");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCeilingToCatwalkFarMove;
    /// <summary>
    /// Function: TriggerCeilingToCatwalkFarMove
    /// </summary>
    public unsafe override void TriggerCeilingToCatwalkFarMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCeilingToCatwalkFarMove, "BmScript.RPawnPlayerCatwoman.TriggerCeilingToCatwalkFarMove");
        byte* paramsPtr = stackalloc byte[264];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCeilingToCatwalkCloseMove;
    /// <summary>
    /// Function: TriggerCeilingToCatwalkCloseMove
    /// </summary>
    public unsafe override void TriggerCeilingToCatwalkCloseMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCeilingToCatwalkCloseMove, "BmScript.RPawnPlayerCatwoman.TriggerCeilingToCatwalkCloseMove");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCeilingClimbCam;
    /// <summary>
    /// Function: SetCeilingClimbCam
    /// </summary>
    public unsafe virtual void SetCeilingClimbCam()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCeilingClimbCam, "BmScript.RPawnPlayerCatwoman.SetCeilingClimbCam");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCatwalkToCeilingVeryFarMove;
    /// <summary>
    /// Function: TriggerCatwalkToCeilingVeryFarMove
    /// </summary>
    public unsafe virtual void TriggerCatwalkToCeilingVeryFarMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCatwalkToCeilingVeryFarMove, "BmScript.RPawnPlayerCatwoman.TriggerCatwalkToCeilingVeryFarMove");
        byte* paramsPtr = stackalloc byte[300];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCatwalkToCeilingFarMove;
    /// <summary>
    /// Function: TriggerCatwalkToCeilingFarMove
    /// </summary>
    public unsafe override void TriggerCatwalkToCeilingFarMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCatwalkToCeilingFarMove, "BmScript.RPawnPlayerCatwoman.TriggerCatwalkToCeilingFarMove");
        byte* paramsPtr = stackalloc byte[304];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCatwalkToCeilingCloseMove;
    /// <summary>
    /// Function: TriggerCatwalkToCeilingCloseMove
    /// </summary>
    public unsafe override void TriggerCatwalkToCeilingCloseMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCatwalkToCeilingCloseMove, "BmScript.RPawnPlayerCatwoman.TriggerCatwalkToCeilingCloseMove");
        byte* paramsPtr = stackalloc byte[184];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerDangleToCeilingMove;
    /// <summary>
    /// Function: TriggerDangleToCeilingMove
    /// </summary>
    public unsafe override void TriggerDangleToCeilingMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerDangleToCeilingMove, "BmScript.RPawnPlayerCatwoman.TriggerDangleToCeilingMove");
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCeilingToDangleMove;
    /// <summary>
    /// Function: TriggerCeilingToDangleMove
    /// </summary>
    public unsafe override void TriggerCeilingToDangleMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCeilingToDangleMove, "BmScript.RPawnPlayerCatwoman.TriggerCeilingToDangleMove");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerDropFromCeilingMove;
    /// <summary>
    /// Function: TriggerDropFromCeilingMove
    /// </summary>
    public unsafe override void TriggerDropFromCeilingMove()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerDropFromCeilingMove, "BmScript.RPawnPlayerCatwoman.TriggerDropFromCeilingMove");
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPounceToCeilingMove;
    /// <summary>
    /// Function: TriggerPounceToCeilingMove
    /// </summary>
    public unsafe override void TriggerPounceToCeilingMove(System.Numerics.Vector3 Position)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPounceToCeilingMove, "BmScript.RPawnPlayerCatwoman.TriggerPounceToCeilingMove");
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HopOffVantagePoint;
    /// <summary>
    /// Function: HopOffVantagePoint
    /// </summary>
    public unsafe override void HopOffVantagePoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HopOffVantagePoint, "BmScript.RPawnPlayerCatwoman.HopOffVantagePoint");
        byte* paramsPtr = stackalloc byte[224];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAttachToPawn;
    /// <summary>
    /// Function: StopAttachToPawn
    /// </summary>
    public unsafe virtual void StopAttachToPawn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAttachToPawn, "BmScript.RPawnPlayerCatwoman.StopAttachToPawn");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAttachToPawn;
    /// <summary>
    /// Function: StartAttachToPawn
    /// </summary>
    public unsafe virtual void StartAttachToPawn(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Locator)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttachToPawn, "BmScript.RPawnPlayerCatwoman.StartAttachToPawn");
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Locator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.RPawnPlayerCatwoman.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveAllGadgets;
    /// <summary>
    /// Function: DebugGiveAllGadgets
    /// </summary>
    public unsafe override void DebugGiveAllGadgets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveAllGadgets, "BmScript.RPawnPlayerCatwoman.DebugGiveAllGadgets");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDefaultInventory;
    /// <summary>
    /// Function: AddDefaultInventory
    /// </summary>
    public unsafe override void AddDefaultInventory()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDefaultInventory, "BmScript.RPawnPlayerCatwoman.AddDefaultInventory");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool On, bool bForceOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmScript.RPawnPlayerCatwoman.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeFallingDamage;
    /// <summary>
    /// Function: TakeFallingDamage
    /// </summary>
    public unsafe override void TakeFallingDamage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeFallingDamage, "BmScript.RPawnPlayerCatwoman.TakeFallingDamage");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupPlayerSpecificCombatAnimsets;
    /// <summary>
    /// Function: SetupPlayerSpecificCombatAnimsets
    /// </summary>
    public unsafe override void SetupPlayerSpecificCombatAnimsets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupPlayerSpecificCombatAnimsets, "BmScript.RPawnPlayerCatwoman.SetupPlayerSpecificCombatAnimsets");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RPawnPlayerCatwoman.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: PounceLandFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem PounceLandFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 10340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10340); }
    }

    /// <summary>
    /// ObjectProperty: PounceHardLandFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem PounceHardLandFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 10348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10348); }
    }

    /// <summary>
    /// ObjectProperty: HairMaterialInst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HairMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10356); }
    }

    /// <summary>
    /// ObjectProperty: HairCWC1MaterialInst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HairCWC1MaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10364); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceInterrogation
    /// </summary>
    public unsafe bool bDebugForceInterrogation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10372) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10372); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10372); }
    }

    /// <summary>
    /// BoolProperty: bAllowDeathCoughSpeech
    /// </summary>
    public unsafe bool bAllowDeathCoughSpeech
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10372) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10372); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10372); }
    }

    /// <summary>
    /// BoolProperty: bDieOnCeilingsOnly
    /// </summary>
    public unsafe bool bDieOnCeilingsOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10372) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10372); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10372); }
    }

    /// <summary>
    /// BoolProperty: bForceInstantDeath
    /// </summary>
    public unsafe bool bForceInstantDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10372) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10372); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10372); }
    }

    /// <summary>
    /// StructProperty: CoughTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CoughTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 10376);

    /// <summary>
    /// ArrayProperty: SkinMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> SkinMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 10380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10380); }
    }

    /// <summary>
    /// NameProperty: OWBrightnessMaterialParameterName
    /// </summary>
    public unsafe BmSDK.FName OWBrightnessMaterialParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 10396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10396); }
    }

    /// <summary>
    /// FloatProperty: BrightnessIndoors
    /// </summary>
    public unsafe float BrightnessIndoors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10404); }
    }

    /// <summary>
    /// FloatProperty: BrightnessOutdoors
    /// </summary>
    public unsafe float BrightnessOutdoors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10408); }
    }

    /// <summary>
    /// Enum: ECatwomanGadgetList
    /// </summary>
    public enum ECatwomanGadgetList : byte
    {
        CWGL_BullWhip = 0,
        CWGL_Bolas = 1,
        CWGL_Caltrops = 2,
        CWGL_BullWhipCombatDisarm = 3,
        CWGL_MAX = 4,
    }
}
