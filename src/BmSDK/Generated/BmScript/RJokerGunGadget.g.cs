#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RJokerGunGadget<br/>
/// (size = 2428)
/// (flags = 10485810)
/// </summary>
public partial class RJokerGunGadget : BmSDK.BmGame.RJokerGunGadgetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RJokerGunGadget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RJokerGunGadget.
    /// </summary>
    public static RJokerGunGadget DefaultObject => (RJokerGunGadget)StaticClass().DefaultObject;

    internal RJokerGunGadget() { }

    /// <summary>
    /// Constructs a new RJokerGunGadget
    /// </summary>
    public RJokerGunGadget(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RJokerGunGadget(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdateWalkingVelocity;
    /// <summary>
    /// Function: UpdateWalkingVelocity
    /// </summary>
    public unsafe virtual void UpdateWalkingVelocity(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateWalkingVelocity, "BmScript.RJokerGunGadget.UpdateWalkingVelocity");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe override bool CheckAutoTarget(BmSDK.Engine.Actor BatarangTarget, out System.Numerics.Vector3 BatarangTargetPosition, out float OverridePriority, out float OverrideMaxRange, out byte DoLOSCheck)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmScript.RJokerGunGadget.CheckAutoTarget");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BatarangTargetPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
        OverrideMaxRange = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        DoLOSCheck = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_PreRender;
    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe override void PreRender(BmSDK.Engine.Canvas HudCanvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreRender, "BmScript.RJokerGunGadget.PreRender");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelGadget;
    /// <summary>
    /// Function: CancelGadget
    /// </summary>
    public unsafe override void CancelGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelGadget, "BmScript.RJokerGunGadget.CancelGadget");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AimGadget;
    /// <summary>
    /// Function: AimGadget
    /// </summary>
    public unsafe override bool AimGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimGadget, "BmScript.RJokerGunGadget.AimGadget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetJokerGunAutoFireAnim;
    /// <summary>
    /// Function: GetJokerGunAutoFireAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetJokerGunAutoFireAnim(BmSDK.Rotator ThrowDirection, out BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc AimingConfig)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJokerGunAutoFireAnim, "BmScript.RJokerGunGadget.GetJokerGunAutoFireAnim");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDirection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AimingConfig = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CalculateAutoTarget;
    /// <summary>
    /// Function: CalculateAutoTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor CalculateAutoTarget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateAutoTarget, "BmScript.RJokerGunGadget.CalculateAutoTarget");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateGadgetLookSensitivity;
    /// <summary>
    /// Function: UpdateGadgetLookSensitivity
    /// </summary>
    public unsafe virtual void UpdateGadgetLookSensitivity(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGadgetLookSensitivity, "BmScript.RJokerGunGadget.UpdateGadgetLookSensitivity");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RJokerGunGadget.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateHitImpulse;
    /// <summary>
    /// Function: CalculateHitImpulse
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 CalculateHitImpulse(BmSDK.Engine.Actor.FImpactInfo HitImpactInfo, int HitVillainIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateHitImpulse, "BmScript.RJokerGunGadget.CalculateHitImpulse");
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitImpactInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillainIndex, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 100);
    }

    private static BmSDK.Function __fn_CalculateHitDamage;
    /// <summary>
    /// Function: CalculateHitDamage
    /// </summary>
    public unsafe virtual float CalculateHitDamage(BmSDK.Engine.Actor.FImpactInfo HitImpactInfo)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateHitDamage, "BmScript.RJokerGunGadget.CalculateHitDamage");
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitImpactInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_AlertPeopleToGunFire;
    /// <summary>
    /// Function: AlertPeopleToGunFire
    /// </summary>
    public unsafe virtual void AlertPeopleToGunFire()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertPeopleToGunFire, "BmScript.RJokerGunGadget.AlertPeopleToGunFire");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerGunFireRumble;
    /// <summary>
    /// Function: TriggerGunFireRumble
    /// </summary>
    public unsafe virtual void TriggerGunFireRumble()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGunFireRumble, "BmScript.RJokerGunGadget.TriggerGunFireRumble");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerGunMuzzleFlashEffect;
    /// <summary>
    /// Function: TriggerGunMuzzleFlashEffect
    /// </summary>
    public unsafe virtual void TriggerGunMuzzleFlashEffect()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGunMuzzleFlashEffect, "BmScript.RJokerGunGadget.TriggerGunMuzzleFlashEffect");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetImpactMaterial;
    /// <summary>
    /// Function: GetImpactMaterial
    /// </summary>
    public unsafe virtual BmSDK.Engine.RPhysicalMaterialProperty GetImpactMaterial(BmSDK.Engine.Actor.FImpactInfo Impact)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactMaterial, "BmScript.RJokerGunGadget.GetImpactMaterial");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_CreateHitEffect;
    /// <summary>
    /// Function: CreateHitEffect
    /// </summary>
    public unsafe virtual void CreateHitEffect(bool bHitSomething, BmSDK.Engine.Actor.FImpactInfo HitImpactInfo, bool bSpawnTracer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHitEffect, "BmScript.RJokerGunGadget.CreateHitEffect");
        byte* paramsPtr = stackalloc byte[204];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHitSomething, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitImpactInfo, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpawnTracer, paramsPtr + 100);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireGunServer;
    /// <summary>
    /// Function: FireGunServer
    /// </summary>
    public unsafe virtual void FireGunServer(BmSDK.Rotator FireRotation, System.Numerics.Vector3 FirePosition, bool bNoDamage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireGunServer, "BmScript.RJokerGunGadget.FireGunServer");
        byte* paramsPtr = stackalloc byte[520];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireRotation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirePosition, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoDamage, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTwoface;
    /// <summary>
    /// Function: IsTwoface
    /// </summary>
    public unsafe virtual bool IsTwoface(BmSDK.BmGame.RPawnVillain HitVillain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTwoface, "BmScript.RJokerGunGadget.IsTwoface");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsRiddlerHostage;
    /// <summary>
    /// Function: IsRiddlerHostage
    /// </summary>
    public unsafe virtual bool IsRiddlerHostage(BmSDK.BmGame.RPawnVillain HitVillain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRiddlerHostage, "BmScript.RJokerGunGadget.IsRiddlerHostage");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsRiddler;
    /// <summary>
    /// Function: IsRiddler
    /// </summary>
    public unsafe virtual bool IsRiddler(BmSDK.BmGame.RPawnVillain HitVillain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRiddler, "BmScript.RJokerGunGadget.IsRiddler");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsPenguin;
    /// <summary>
    /// Function: IsPenguin
    /// </summary>
    public unsafe virtual bool IsPenguin(BmSDK.BmGame.RPawnVillain HitVillain)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPenguin, "BmScript.RJokerGunGadget.IsPenguin");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TriggerGunEffects;
    /// <summary>
    /// Function: TriggerGunEffects
    /// </summary>
    public unsafe virtual void TriggerGunEffects()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGunEffects, "BmScript.RJokerGunGadget.TriggerGunEffects");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireGunClient;
    /// <summary>
    /// Function: FireGunClient
    /// </summary>
    public unsafe virtual void FireGunClient()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireGunClient, "BmScript.RJokerGunGadget.FireGunClient");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireGun;
    /// <summary>
    /// Function: FireGun
    /// </summary>
    public unsafe virtual void FireGun()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireGun, "BmScript.RJokerGunGadget.FireGun");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShootVentThug;
    /// <summary>
    /// Function: ShootVentThug
    /// </summary>
    public unsafe virtual void ShootVentThug()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShootVentThug, "BmScript.RJokerGunGadget.ShootVentThug");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateBulletTrajectory;
    /// <summary>
    /// Function: CalculateBulletTrajectory
    /// </summary>
    public unsafe virtual void CalculateBulletTrajectory(bool bFirst)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateBulletTrajectory, "BmScript.RJokerGunGadget.CalculateBulletTrajectory");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFirst, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetLookSensitivity;
    /// <summary>
    /// Function: GetGadgetLookSensitivity
    /// </summary>
    public unsafe override float GetGadgetLookSensitivity(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetLookSensitivity, "BmScript.RJokerGunGadget.GetGadgetLookSensitivity");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AdditiveArmAvoidance;
    /// <summary>
    /// Function: AdditiveArmAvoidance
    /// </summary>
    public unsafe override void AdditiveArmAvoidance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdditiveArmAvoidance, "BmScript.RJokerGunGadget.AdditiveArmAvoidance");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldAimAt;
    /// <summary>
    /// Function: ShouldAimAt
    /// </summary>
    public unsafe override bool ShouldAimAt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldAimAt, "BmScript.RJokerGunGadget.ShouldAimAt");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanThrowGadget;
    /// <summary>
    /// Function: CanThrowGadget
    /// </summary>
    public unsafe override bool CanThrowGadget()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanThrowGadget, "BmScript.RJokerGunGadget.CanThrowGadget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGadgetCamera;
    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe override BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetCamera, "BmScript.RJokerGunGadget.GetGadgetCamera");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPrimedPose;
    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe override BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState, out BmSDK.FName OutCapeTransitionState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmScript.RJokerGunGadget.GetPrimedPose");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
        OutCapeTransitionState = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_CameraZoomChanged;
    /// <summary>
    /// Function: CameraZoomChanged
    /// </summary>
    public unsafe override void CameraZoomChanged(bool bCurrentlyZoomed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CameraZoomChanged, "BmScript.RJokerGunGadget.CameraZoomChanged");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCurrentlyZoomed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPromptName;
    /// <summary>
    /// Function: GetPromptName
    /// </summary>
    public unsafe static BmSDK.FName GetPromptName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPromptName, "BmScript.RJokerGunGadget.GetPromptName");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetJokerRoom3;
    /// <summary>
    /// Function: SetJokerRoom3
    /// </summary>
    public unsafe override void SetJokerRoom3(bool On)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetJokerRoom3, "BmScript.RJokerGunGadget.SetJokerRoom3");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAutomaticZoomCamera;
    /// <summary>
    /// Function: SetAutomaticZoomCamera
    /// </summary>
    public unsafe virtual void SetAutomaticZoomCamera(bool On)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAutomaticZoomCamera, "BmScript.RJokerGunGadget.SetAutomaticZoomCamera");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: CurrTransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CurrTransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 2088);

    /// <summary>
    /// StructProperty: CurrOverlayId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId CurrOverlayId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 2092);

    /// <summary>
    /// FloatProperty: DefaultHitDamage
    /// </summary>
    public unsafe float DefaultHitDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// FloatProperty: DefaultHitImpulse
    /// </summary>
    public unsafe float DefaultHitImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// FloatProperty: DefaultHitLift
    /// </summary>
    public unsafe float DefaultHitLift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// FloatProperty: BulletImpulseReductionProportionPerVillain
    /// </summary>
    public unsafe float BulletImpulseReductionProportionPerVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// IntProperty: MaxNumVillainsWhichCanBeShotWithSingleBullet
    /// </summary>
    public unsafe int MaxNumVillainsWhichCanBeShotWithSingleBullet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetAngle
    /// </summary>
    public unsafe float AutoTargetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// FloatProperty: MaxTracerDiffAngle
    /// </summary>
    public unsafe float MaxTracerDiffAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetRange
    /// </summary>
    public unsafe float AutoTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// NameProperty: MuzzleFlashSocketName
    /// </summary>
    public unsafe BmSDK.FName MuzzleFlashSocketName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ObjectProperty: HitEffectParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitEffectParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: GunTracerParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GunTracerParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ObjectProperty: GunFireRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform GunFireRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ObjectProperty: LoadedGunFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LoadedGunFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// ObjectProperty: CurrentBestTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentBestTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// ObjectProperty: PenguinHandTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor PenguinHandTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ObjectProperty: penguin
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain penguin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: AutoAimFireDirections
    /// </summary>
    public InlineArray<BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection> AutoAimFireDirections => new(3, Ptr + 2204, 44, this);

    /// <summary>
    /// StructProperty: AutoAimFireDirections
    /// </summary>
    public unsafe ref BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection AutoAimFireDirections_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection>(Ptr + 2204);
    /// <summary>
    /// StructProperty: AutoAimFireDirections
    /// </summary>
    public unsafe ref BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection AutoAimFireDirections_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection>(Ptr + 2248);
    /// <summary>
    /// StructProperty: AutoAimFireDirections
    /// </summary>
    public unsafe ref BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection AutoAimFireDirections_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection>(Ptr + 2292);

    /// <summary>
    /// StructProperty: LastFireRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator LastFireRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2336);

    /// <summary>
    /// StructProperty: LastFirePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastFirePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2348);

    /// <summary>
    /// IntProperty: BlunderbusShots
    /// </summary>
    public unsafe int BlunderbusShots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// FloatProperty: BlunderbusRandom
    /// </summary>
    public unsafe float BlunderbusRandom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// BoolProperty: bTwoFaceIntro
    /// </summary>
    public unsafe bool bTwoFaceIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bRoom3
    /// </summary>
    public unsafe bool bRoom3
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bClickAim
    /// </summary>
    public unsafe bool bClickAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bInStumble
    /// </summary>
    public unsafe bool bInStumble
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: InvertAdditiveVal
    /// </summary>
    public unsafe bool InvertAdditiveVal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bForceDisableCrossHair
    /// </summary>
    public unsafe bool bForceDisableCrossHair
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bFirstShot
    /// </summary>
    public unsafe bool bFirstShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bManageWalkingVelocity
    /// </summary>
    public unsafe bool bManageWalkingVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bAllowShootInTwofaceIntro
    /// </summary>
    public unsafe bool bAllowShootInTwofaceIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// FloatProperty: DistForBringGunInToMax
    /// </summary>
    public unsafe float DistForBringGunInToMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// FloatProperty: DistForBringGunIn
    /// </summary>
    public unsafe float DistForBringGunIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// FloatProperty: BringInLerpVal
    /// </summary>
    public unsafe float BringInLerpVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// FloatProperty: CurrentBringInVal
    /// </summary>
    public unsafe float CurrentBringInVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// ArrayProperty: ActorsHitThisShot
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ActorsHitThisShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// StructProperty: WalkingPawnVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WalkingPawnVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2404);

    /// <summary>
    /// FloatProperty: WalkingPawnAccel
    /// </summary>
    public unsafe float WalkingPawnAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// FloatProperty: WalkingMaxSpeed
    /// </summary>
    public unsafe float WalkingMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// FloatProperty: AimingMaxSpeed
    /// </summary>
    public unsafe float AimingMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }
}
