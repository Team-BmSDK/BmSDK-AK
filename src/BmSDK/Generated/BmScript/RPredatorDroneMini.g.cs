#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPredatorDroneMini<br/>
/// (size = 3688)
/// (flags = 10486326)
/// </summary>
public partial class RPredatorDroneMini : BmSDK.BmScript.RHelicopterIntermediate, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPredatorDroneMini", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPredatorDroneMini.
    /// </summary>
    public static RPredatorDroneMini DefaultObject => (RPredatorDroneMini)StaticClass().DefaultObject;

    internal RPredatorDroneMini() { }

    /// <summary>
    /// Constructs a new RPredatorDroneMini
    /// </summary>
    public RPredatorDroneMini(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPredatorDroneMini(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_AlertToBatmansPosition;
    /// <summary>
    /// Function: AlertToBatmansPosition
    /// </summary>
    public unsafe override void AlertToBatmansPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertToBatmansPosition, "BmScript.RPredatorDroneMini.AlertToBatmansPosition");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ZapTimer;
    /// <summary>
    /// Function: ZapTimer
    /// </summary>
    public unsafe virtual void ZapTimer()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ZapTimer, "BmScript.RPredatorDroneMini.ZapTimer");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ZapClosePlayer;
    /// <summary>
    /// Function: ZapClosePlayer
    /// </summary>
    public unsafe virtual void ZapClosePlayer(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ZapClosePlayer, "BmScript.RPredatorDroneMini.ZapClosePlayer");
        byte* paramsPtr = stackalloc byte[256];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "BmScript.RPredatorDroneMini.Bump");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBasePawn;
    /// <summary>
    /// Function: CanBasePawn
    /// </summary>
    public unsafe override bool CanBasePawn(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBasePawn, "BmScript.RPredatorDroneMini.CanBasePawn");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ChangeHelicopterDPG;
    /// <summary>
    /// Function: ChangeHelicopterDPG
    /// </summary>
    public unsafe override void ChangeHelicopterDPG(BmSDK.Engine.Scene.ESceneDepthPriorityGroup NewDPG)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeHelicopterDPG, "BmScript.RPredatorDroneMini.ChangeHelicopterDPG");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDPG, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillMinidroneToMinidroneControllerLine;
    /// <summary>
    /// Function: KillMinidroneToMinidroneControllerLine
    /// </summary>
    public unsafe virtual void KillMinidroneToMinidroneControllerLine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillMinidroneToMinidroneControllerLine, "BmScript.RPredatorDroneMini.KillMinidroneToMinidroneControllerLine");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMinidroneToMinidroneControllerLine;
    /// <summary>
    /// Function: UpdateMinidroneToMinidroneControllerLine
    /// </summary>
    public unsafe virtual void UpdateMinidroneToMinidroneControllerLine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMinidroneToMinidroneControllerLine, "BmScript.RPredatorDroneMini.UpdateMinidroneToMinidroneControllerLine");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MinidroneIsBeingTargetedByRHD;
    /// <summary>
    /// Function: MinidroneIsBeingTargetedByRHD
    /// </summary>
    public unsafe override void MinidroneIsBeingTargetedByRHD()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MinidroneIsBeingTargetedByRHD, "BmScript.RPredatorDroneMini.MinidroneIsBeingTargetedByRHD");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool On, bool bForceOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmScript.RPredatorDroneMini.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitByDisruptor;
    /// <summary>
    /// Function: HitByDisruptor
    /// </summary>
    public unsafe override void HitByDisruptor(System.Numerics.Vector3 ShotDirection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByDisruptor, "BmScript.RPredatorDroneMini.HitByDisruptor");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShotDirection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__QueryIsOneOfBestTargets;
    /// <summary>
    /// Function: _QueryIsOneOfBestTargets
    /// </summary>
    public unsafe virtual bool _QueryIsOneOfBestTargets(BmSDK.Engine.Actor hActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__QueryIsOneOfBestTargets, "BmScript.RPredatorDroneMini._QueryIsOneOfBestTargets");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn__QueryGetVantagePointToTargets;
    /// <summary>
    /// Function: _QueryGetVantagePointToTargets
    /// </summary>
    public unsafe virtual void _QueryGetVantagePointToTargets(out System.Numerics.Vector3 vVantagePoint, out System.Numerics.Vector3 vVantageTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__QueryGetVantagePointToTargets, "BmScript.RPredatorDroneMini._QueryGetVantagePointToTargets");
        byte* paramsPtr = stackalloc byte[80];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out vVantagePoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vVantagePoint, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out vVantageTarget);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vVantageTarget, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        vVantagePoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        vVantageTarget = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetVantageTarget;
    /// <summary>
    /// Function: GetVantageTarget
    /// </summary>
    public unsafe virtual int GetVantageTarget(out System.Numerics.Vector3 vVantageTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVantageTarget, "BmScript.RPredatorDroneMini.GetVantageTarget");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out vVantageTarget);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vVantageTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        vVantageTarget = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn__QueryGetAimLocation;
    /// <summary>
    /// Function: _QueryGetAimLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 _QueryGetAimLocation(BmSDK.Engine.Actor hActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__QueryGetAimLocation, "BmScript.RPredatorDroneMini._QueryGetAimLocation");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn__QueryIsCurious;
    /// <summary>
    /// Function: _QueryIsCurious
    /// </summary>
    public unsafe virtual bool _QueryIsCurious(BmSDK.Engine.Actor hActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__QueryIsCurious, "BmScript.RPredatorDroneMini._QueryIsCurious");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn__QueryIsEnemy;
    /// <summary>
    /// Function: _QueryIsEnemy
    /// </summary>
    public unsafe virtual bool _QueryIsEnemy(BmSDK.Engine.Actor hActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__QueryIsEnemy, "BmScript.RPredatorDroneMini._QueryIsEnemy");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn__QueryIsIgnored;
    /// <summary>
    /// Function: _QueryIsIgnored
    /// </summary>
    public unsafe override bool _QueryIsIgnored(BmSDK.Engine.Actor hActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__QueryIsIgnored, "BmScript.RPredatorDroneMini._QueryIsIgnored");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn__QueryIsWithinRange;
    /// <summary>
    /// Function: _QueryIsWithinRange
    /// </summary>
    public unsafe virtual bool _QueryIsWithinRange(System.Numerics.Vector3 vA, System.Numerics.Vector3 vB, float fDistance)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__QueryIsWithinRange, "BmScript.RPredatorDroneMini._QueryIsWithinRange");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vB, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDistance, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn__QueryAllTargetsWithinRange;
    /// <summary>
    /// Function: _QueryAllTargetsWithinRange
    /// </summary>
    public unsafe virtual bool _QueryAllTargetsWithinRange(System.Numerics.Vector3 vPosition, float fDistance, float fHeightMin = default, float fHeightMax = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__QueryAllTargetsWithinRange, "BmScript.RPredatorDroneMini._QueryAllTargetsWithinRange");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDistance, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fHeightMin, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fHeightMax, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn__WeaponNotifyRoomOfAttack;
    /// <summary>
    /// Function: _WeaponNotifyRoomOfAttack
    /// </summary>
    public unsafe virtual void _WeaponNotifyRoomOfAttack()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__WeaponNotifyRoomOfAttack, "BmScript.RPredatorDroneMini._WeaponNotifyRoomOfAttack");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__WeaponDoDamage;
    /// <summary>
    /// Function: _WeaponDoDamage
    /// </summary>
    public unsafe virtual void _WeaponDoDamage(BmSDK.Engine.Actor hActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__WeaponDoDamage, "BmScript.RPredatorDroneMini._WeaponDoDamage");
        byte* paramsPtr = stackalloc byte[264];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__KillNearbyThugsWithExplosion;
    /// <summary>
    /// Function: _KillNearbyThugsWithExplosion
    /// </summary>
    public unsafe virtual void _KillNearbyThugsWithExplosion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__KillNearbyThugsWithExplosion, "BmScript.RPredatorDroneMini._KillNearbyThugsWithExplosion");
        byte* paramsPtr = stackalloc byte[328];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__ObjectStateExplode;
    /// <summary>
    /// Function: _ObjectStateExplode
    /// </summary>
    public unsafe virtual void _ObjectStateExplode(bool bAlertOfExplosion = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__ObjectStateExplode, "BmScript.RPredatorDroneMini._ObjectStateExplode");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlertOfExplosion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__ObjectStateCollide;
    /// <summary>
    /// Function: _ObjectStateCollide
    /// </summary>
    public unsafe virtual bool _ObjectStateCollide(System.Numerics.Vector3 vSource, System.Numerics.Vector3 vDestination, out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__ObjectStateCollide, "BmScript.RPredatorDroneMini._ObjectStateCollide");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vSource, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vDestination, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn__UpdateTargetsSearchLightPosition;
    /// <summary>
    /// Function: _UpdateTargetsSearchLightPosition
    /// </summary>
    public unsafe virtual void _UpdateTargetsSearchLightPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateTargetsSearchLightPosition, "BmScript.RPredatorDroneMini._UpdateTargetsSearchLightPosition");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__UpdateTargetsVisibility;
    /// <summary>
    /// Function: _UpdateTargetsVisibility
    /// </summary>
    public unsafe virtual int _UpdateTargetsVisibility(float fDeltaTime, bool bExpireTargets = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateTargetsVisibility, "BmScript.RPredatorDroneMini._UpdateTargetsVisibility");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExpireTargets, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn__UpdateTargetsOfSearchLights;
    /// <summary>
    /// Function: _UpdateTargetsOfSearchLights
    /// </summary>
    public unsafe virtual void _UpdateTargetsOfSearchLights(float fDeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateTargetsOfSearchLights, "BmScript.RPredatorDroneMini._UpdateTargetsOfSearchLights");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInvestigateState;
    /// <summary>
    /// Function: GetInvestigateState
    /// </summary>
    public unsafe virtual BmSDK.FName GetInvestigateState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInvestigateState, "BmScript.RPredatorDroneMini.GetInvestigateState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPursueTargetsState;
    /// <summary>
    /// Function: GetPursueTargetsState
    /// </summary>
    public unsafe virtual BmSDK.FName GetPursueTargetsState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPursueTargetsState, "BmScript.RPredatorDroneMini.GetPursueTargetsState");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn__UpdateTargetsRefreshListWithDelay;
    /// <summary>
    /// Function: _UpdateTargetsRefreshListWithDelay
    /// </summary>
    public unsafe virtual void _UpdateTargetsRefreshListWithDelay(float fDeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateTargetsRefreshListWithDelay, "BmScript.RPredatorDroneMini._UpdateTargetsRefreshListWithDelay");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__UpdateTargetsSourceLocation;
    /// <summary>
    /// Function: _UpdateTargetsSourceLocation
    /// </summary>
    public unsafe virtual void _UpdateTargetsSourceLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateTargetsSourceLocation, "BmScript.RPredatorDroneMini._UpdateTargetsSourceLocation");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__UpdateSearchLightVisuals;
    /// <summary>
    /// Function: _UpdateSearchLightVisuals
    /// </summary>
    public unsafe virtual void _UpdateSearchLightVisuals(float fDeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateSearchLightVisuals, "BmScript.RPredatorDroneMini._UpdateSearchLightVisuals");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__UpdateSearchLightRandomPositions;
    /// <summary>
    /// Function: _UpdateSearchLightRandomPositions
    /// </summary>
    public unsafe virtual void _UpdateSearchLightRandomPositions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateSearchLightRandomPositions, "BmScript.RPredatorDroneMini._UpdateSearchLightRandomPositions");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__UpdateSearchLightRadialScanPositions;
    /// <summary>
    /// Function: _UpdateSearchLightRadialScanPositions
    /// </summary>
    public unsafe virtual void _UpdateSearchLightRadialScanPositions(float fDeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateSearchLightRadialScanPositions, "BmScript.RPredatorDroneMini._UpdateSearchLightRadialScanPositions");
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__UpdateSearchLightSourceLocation;
    /// <summary>
    /// Function: _UpdateSearchLightSourceLocation
    /// </summary>
    public unsafe virtual void _UpdateSearchLightSourceLocation(float fDeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateSearchLightSourceLocation, "BmScript.RPredatorDroneMini._UpdateSearchLightSourceLocation");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__UpdateMovementPursueTargets;
    /// <summary>
    /// Function: _UpdateMovementPursueTargets
    /// </summary>
    public unsafe virtual bool _UpdateMovementPursueTargets(float fDeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateMovementPursueTargets, "BmScript.RPredatorDroneMini._UpdateMovementPursueTargets");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn__UpdateMovementMalfunction;
    /// <summary>
    /// Function: _UpdateMovementMalfunction
    /// </summary>
    public unsafe virtual bool _UpdateMovementMalfunction(float fDeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateMovementMalfunction, "BmScript.RPredatorDroneMini._UpdateMovementMalfunction");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn__UpdateMovementTowardPositionWithFacing;
    /// <summary>
    /// Function: _UpdateMovementTowardPositionWithFacing
    /// </summary>
    public unsafe virtual bool _UpdateMovementTowardPositionWithFacing(float fDeltaTime, float fVelocity, System.Numerics.Vector3 vPosition, System.Numerics.Vector3 vFacing, bool bSlowOnApproach)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateMovementTowardPositionWithFacing, "BmScript.RPredatorDroneMini._UpdateMovementTowardPositionWithFacing");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fVelocity, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vPosition, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vFacing, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSlowOnApproach, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn__UpdateMovementTowardNextPoint;
    /// <summary>
    /// Function: _UpdateMovementTowardNextPoint
    /// </summary>
    public unsafe virtual bool _UpdateMovementTowardNextPoint(float fDeltaTime, float fVelocity)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateMovementTowardNextPoint, "BmScript.RPredatorDroneMini._UpdateMovementTowardNextPoint");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fVelocity, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn__UpdateStateMeander;
    /// <summary>
    /// Function: _UpdateStateMeander
    /// </summary>
    public unsafe virtual bool _UpdateStateMeander(float fDeltaTime, bool bLookAtTargets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__UpdateStateMeander, "BmScript.RPredatorDroneMini._UpdateStateMeander");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLookAtTargets, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn__InitializeMalfunctionProperties;
    /// <summary>
    /// Function: _InitializeMalfunctionProperties
    /// </summary>
    public unsafe virtual void _InitializeMalfunctionProperties(float fDuration, float fIntensity = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__InitializeMalfunctionProperties, "BmScript.RPredatorDroneMini._InitializeMalfunctionProperties");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDuration, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fIntensity, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__InitializeMeanderProperties;
    /// <summary>
    /// Function: _InitializeMeanderProperties
    /// </summary>
    public unsafe virtual void _InitializeMeanderProperties(float fOverrideTime = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__InitializeMeanderProperties, "BmScript.RPredatorDroneMini._InitializeMeanderProperties");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fOverrideTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__InitializeSearchLightColors;
    /// <summary>
    /// Function: _InitializeSearchLightColors
    /// </summary>
    public unsafe virtual void _InitializeSearchLightColors(BmSDK.BmScript.RPredatorDroneMini.LightColorState eState)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__InitializeSearchLightColors, "BmScript.RPredatorDroneMini._InitializeSearchLightColors");
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__InitializeAllSearchLightTargets;
    /// <summary>
    /// Function: _InitializeAllSearchLightTargets
    /// </summary>
    public unsafe virtual void _InitializeAllSearchLightTargets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__InitializeAllSearchLightTargets, "BmScript.RPredatorDroneMini._InitializeAllSearchLightTargets");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__InitializeSearchLightTarget;
    /// <summary>
    /// Function: _InitializeSearchLightTarget
    /// </summary>
    public unsafe virtual void _InitializeSearchLightTarget(int nIndex, BmSDK.Engine.Actor hActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__InitializeSearchLightTarget, "BmScript.RPredatorDroneMini._InitializeSearchLightTarget");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hActor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn__ValidatePlayerCharacter;
    /// <summary>
    /// Function: _ValidatePlayerCharacter
    /// </summary>
    public unsafe virtual void _ValidatePlayerCharacter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn__ValidatePlayerCharacter, "BmScript.RPredatorDroneMini._ValidatePlayerCharacter");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlertRoomToBatman;
    /// <summary>
    /// Function: AlertRoomToBatman
    /// </summary>
    public unsafe virtual void AlertRoomToBatman(int CallbackFlags, BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle, int MarkerID, int MarkerTypeID, float Duration)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertRoomToBatman, "BmScript.RPredatorDroneMini.AlertRoomToBatman");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CallbackFlags, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandle, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerID, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerTypeID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsSpecialTutorialMinidrone;
    /// <summary>
    /// Function: IsSpecialTutorialMinidrone
    /// </summary>
    public unsafe override bool IsSpecialTutorialMinidrone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpecialTutorialMinidrone, "BmScript.RPredatorDroneMini.IsSpecialTutorialMinidrone");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AbandonedByController;
    /// <summary>
    /// Function: AbandonedByController
    /// </summary>
    public unsafe override void AbandonedByController()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AbandonedByController, "BmScript.RPredatorDroneMini.AbandonedByController");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttackTargets;
    /// <summary>
    /// Function: AttackTargets
    /// </summary>
    public unsafe virtual void AttackTargets(bool bSelfDestruct = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttackTargets, "BmScript.RPredatorDroneMini.AttackTargets");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSelfDestruct, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTargets;
    /// <summary>
    /// Function: GetTargets
    /// </summary>
    public unsafe override void GetTargets(out BmSDK.TArray<BmSDK.Engine.Actor> Targets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargets, "BmScript.RPredatorDroneMini.GetTargets");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Targets = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_IsLockedOntoTarget;
    /// <summary>
    /// Function: IsLockedOntoTarget
    /// </summary>
    public unsafe virtual bool IsLockedOntoTarget(BmSDK.Engine.Actor hActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLockedOntoTarget, "BmScript.RPredatorDroneMini.IsLockedOntoTarget");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetTargetMode;
    /// <summary>
    /// Function: SetTargetMode
    /// </summary>
    public unsafe virtual void SetTargetMode(BmSDK.BmScript.RPredatorDroneMini.SearchLightTargetMode eSearchLightTargetMode, BmSDK.Engine.Actor hTarget = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetMode, "BmScript.RPredatorDroneMini.SetTargetMode");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eSearchLightTargetMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNumberOfMinidroneSearchLightTargets;
    /// <summary>
    /// Function: GetNumberOfMinidroneSearchLightTargets
    /// </summary>
    public unsafe override int GetNumberOfMinidroneSearchLightTargets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumberOfMinidroneSearchLightTargets, "BmScript.RPredatorDroneMini.GetNumberOfMinidroneSearchLightTargets");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetControlActor;
    /// <summary>
    /// Function: GetControlActor
    /// </summary>
    public unsafe override BmSDK.Engine.Actor GetControlActor()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetControlActor, "BmScript.RPredatorDroneMini.GetControlActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetControlActor;
    /// <summary>
    /// Function: SetControlActor
    /// </summary>
    public unsafe virtual void SetControlActor(BmSDK.BmScript.RPawnVillainGunMiniDroneController hController)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlActor, "BmScript.RPredatorDroneMini.SetControlActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hController, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetArkhamKnightControlActor;
    /// <summary>
    /// Function: SetArkhamKnightControlActor
    /// </summary>
    public unsafe virtual void SetArkhamKnightControlActor(BmSDK.BmGame.RPawnVillainGunPredBase hController)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetArkhamKnightControlActor, "BmScript.RPredatorDroneMini.SetArkhamKnightControlActor");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hController, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSecondary;
    /// <summary>
    /// Function: TriggerSecondary
    /// </summary>
    public unsafe override bool TriggerSecondary(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSecondary, "BmScript.RPredatorDroneMini.TriggerSecondary");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Trigger;
    /// <summary>
    /// Function: Trigger
    /// </summary>
    public unsafe override bool Trigger(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Trigger, "BmScript.RPredatorDroneMini.Trigger");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanTrigger;
    /// <summary>
    /// Function: CanTrigger
    /// </summary>
    public unsafe override bool CanTrigger(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTrigger, "BmScript.RPredatorDroneMini.CanTrigger");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetInteractionPromptSecondary;
    /// <summary>
    /// Function: GetInteractionPromptSecondary
    /// </summary>
    public unsafe override BmSDK.FString GetInteractionPromptSecondary()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionPromptSecondary, "BmScript.RPredatorDroneMini.GetInteractionPromptSecondary");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldInteractionPromptBeDisplayedInCentreOfScreen;
    /// <summary>
    /// Function: ShouldInteractionPromptBeDisplayedInCentreOfScreen
    /// </summary>
    public unsafe override bool ShouldInteractionPromptBeDisplayedInCentreOfScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldInteractionPromptBeDisplayedInCentreOfScreen, "BmScript.RPredatorDroneMini.ShouldInteractionPromptBeDisplayedInCentreOfScreen");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractionPrompt;
    /// <summary>
    /// Function: GetInteractionPrompt
    /// </summary>
    public unsafe override BmSDK.FString GetInteractionPrompt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionPrompt, "BmScript.RPredatorDroneMini.GetInteractionPrompt");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayDescription;
    /// <summary>
    /// Function: GetDisplayDescription
    /// </summary>
    public unsafe override BmSDK.FString GetDisplayDescription()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayDescription, "BmScript.RPredatorDroneMini.GetDisplayDescription");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayTargetLocation;
    /// <summary>
    /// Function: GetDisplayTargetLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetDisplayTargetLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayTargetLocation, "BmScript.RPredatorDroneMini.GetDisplayTargetLocation");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanInvestigateLocation;
    /// <summary>
    /// Function: CanInvestigateLocation
    /// </summary>
    public unsafe virtual bool CanInvestigateLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanInvestigateLocation, "BmScript.RPredatorDroneMini.CanInvestigateLocation");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeTargettedByRHD;
    /// <summary>
    /// Function: CanBeTargettedByRHD
    /// </summary>
    public unsafe override bool CanBeTargettedByRHD(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTargettedByRHD, "BmScript.RPredatorDroneMini.CanBeTargettedByRHD");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RequiresBlindDroneUpgrade;
    /// <summary>
    /// Function: RequiresBlindDroneUpgrade
    /// </summary>
    public unsafe override bool RequiresBlindDroneUpgrade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequiresBlindDroneUpgrade, "BmScript.RPredatorDroneMini.RequiresBlindDroneUpgrade");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NeedDisplayRefresh;
    /// <summary>
    /// Function: NeedDisplayRefresh
    /// </summary>
    public unsafe override bool NeedDisplayRefresh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NeedDisplayRefresh, "BmScript.RPredatorDroneMini.NeedDisplayRefresh");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayIconName;
    /// <summary>
    /// Function: GetDisplayIconName
    /// </summary>
    public unsafe override BmSDK.FString GetDisplayIconName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayIconName, "BmScript.RPredatorDroneMini.GetDisplayIconName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayLockOnState;
    /// <summary>
    /// Function: GetDisplayLockOnState
    /// </summary>
    public unsafe override BmSDK.FString GetDisplayLockOnState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayLockOnState, "BmScript.RPredatorDroneMini.GetDisplayLockOnState");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanTargetTroughWalls;
    /// <summary>
    /// Function: CanTargetTroughWalls
    /// </summary>
    public unsafe override bool CanTargetTroughWalls()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTargetTroughWalls, "BmScript.RPredatorDroneMini.CanTargetTroughWalls");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInteractionType;
    /// <summary>
    /// Function: GetInteractionType
    /// </summary>
    public unsafe override BmSDK.BmGame.RRemoteControlLowSecurityInterface.EOmnitronInteractionType GetInteractionType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInteractionType, "BmScript.RPredatorDroneMini.GetInteractionType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRemoteControlLowSecurityInterface.EOmnitronInteractionType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMiniGameHelpPrompt;
    /// <summary>
    /// Function: GetMiniGameHelpPrompt
    /// </summary>
    public unsafe override void GetMiniGameHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMiniGameHelpPrompt, "BmScript.RPredatorDroneMini.GetMiniGameHelpPrompt");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerRight;
    /// <summary>
    /// Function: TriggerRight
    /// </summary>
    public unsafe override void TriggerRight(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerRight, "BmScript.RPredatorDroneMini.TriggerRight");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerLeft;
    /// <summary>
    /// Function: TriggerLeft
    /// </summary>
    public unsafe override void TriggerLeft(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLeft, "BmScript.RPredatorDroneMini.TriggerLeft");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupPlayerGrapplePoint;
    /// <summary>
    /// Function: SetupPlayerGrapplePoint
    /// </summary>
    public unsafe override void SetupPlayerGrapplePoint()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupPlayerGrapplePoint, "BmScript.RPredatorDroneMini.SetupPlayerGrapplePoint");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMaximumMiniDroneControllerInteractionDistance;
    /// <summary>
    /// Function: GetMaximumMiniDroneControllerInteractionDistance
    /// </summary>
    public unsafe override float GetMaximumMiniDroneControllerInteractionDistance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaximumMiniDroneControllerInteractionDistance, "BmScript.RPredatorDroneMini.GetMaximumMiniDroneControllerInteractionDistance");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCodesHaventBeenDownloadedYetBatmanThought;
    /// <summary>
    /// Function: GetCodesHaventBeenDownloadedYetBatmanThought
    /// </summary>
    public unsafe override BmSDK.Engine.AkDialogueSpeech GetCodesHaventBeenDownloadedYetBatmanThought()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCodesHaventBeenDownloadedYetBatmanThought, "BmScript.RPredatorDroneMini.GetCodesHaventBeenDownloadedYetBatmanThought");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HaveCodesFinishedDownloading;
    /// <summary>
    /// Function: HaveCodesFinishedDownloading
    /// </summary>
    public unsafe override bool HaveCodesFinishedDownloading()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HaveCodesFinishedDownloading, "BmScript.RPredatorDroneMini.HaveCodesFinishedDownloading");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DownloadCodes;
    /// <summary>
    /// Function: DownloadCodes
    /// </summary>
    public unsafe override float DownloadCodes(float fDelta)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DownloadCodes, "BmScript.RPredatorDroneMini.DownloadCodes");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDelta, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UnBlind;
    /// <summary>
    /// Function: UnBlind
    /// </summary>
    public unsafe override void UnBlind()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnBlind, "BmScript.RPredatorDroneMini.UnBlind");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetXrayMeshLevel;
    /// <summary>
    /// Function: SetXrayMeshLevel
    /// </summary>
    public unsafe override void SetXrayMeshLevel(bool bForce = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXrayMeshLevel, "BmScript.RPredatorDroneMini.SetXrayMeshLevel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBlindedTimeRemaining;
    /// <summary>
    /// Function: GetBlindedTimeRemaining
    /// </summary>
    public unsafe override float GetBlindedTimeRemaining()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlindedTimeRemaining, "BmScript.RPredatorDroneMini.GetBlindedTimeRemaining");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBlinded;
    /// <summary>
    /// Function: IsBlinded
    /// </summary>
    public unsafe override bool IsBlinded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBlinded, "BmScript.RPredatorDroneMini.IsBlinded");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ControllerWasHitByDisruptor;
    /// <summary>
    /// Function: ControllerWasHitByDisruptor
    /// </summary>
    public unsafe virtual void ControllerWasHitByDisruptor(float fDisruptorTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ControllerWasHitByDisruptor, "BmScript.RPredatorDroneMini.ControllerWasHitByDisruptor");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDisruptorTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStunnedByRECDuration;
    /// <summary>
    /// Function: GetStunnedByRECDuration
    /// </summary>
    public unsafe virtual float GetStunnedByRECDuration()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunnedByRECDuration, "BmScript.RPredatorDroneMini.GetStunnedByRECDuration");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByREC;
    /// <summary>
    /// Function: HitByREC
    /// </summary>
    public unsafe override void HitByREC(System.Numerics.Vector3 vHitLocation, System.Numerics.Vector3 vAttackerLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByREC, "BmScript.RPredatorDroneMini.HitByREC");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vHitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vAttackerLocation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggleHidden;
    /// <summary>
    /// Function: OnToggleHidden
    /// </summary>
    public unsafe override void OnToggleHidden(BmSDK.Engine.SeqAct_ToggleHidden iAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggleHidden, "BmScript.RPredatorDroneMini.OnToggleHidden");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDroneSpawner;
    /// <summary>
    /// Function: SetDroneSpawner
    /// </summary>
    public unsafe override void SetDroneSpawner(BmSDK.BmScript.RSeqAct_SpawnDrone SpawnAct)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDroneSpawner, "BmScript.RPredatorDroneMini.SetDroneSpawner");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnAct, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamageFromWeapon;
    /// <summary>
    /// Function: TakeDamageFromWeapon
    /// </summary>
    public unsafe override BmSDK.Engine.Actor.EWeaponDamageResult TakeDamageFromWeapon(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default, bool bHeadShot = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamageFromWeapon, "BmScript.RPredatorDroneMini.TakeDamageFromWeapon");
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
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 108);
    }

    private static BmSDK.Function __fn_FlyingVehicleSuspendOnManyTanks;
    /// <summary>
    /// Function: FlyingVehicleSuspendOnManyTanks
    /// </summary>
    public unsafe override bool FlyingVehicleSuspendOnManyTanks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlyingVehicleSuspendOnManyTanks, "BmScript.RPredatorDroneMini.FlyingVehicleSuspendOnManyTanks");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RPredatorDroneMini.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInThermalMode;
    /// <summary>
    /// Function: SetInThermalMode
    /// </summary>
    public unsafe virtual void SetInThermalMode(bool On, bool bForceOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInThermalMode, "BmScript.RPredatorDroneMini.SetInThermalMode");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: m_hSpawner
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_SpawnDrone m_hSpawner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_SpawnDrone>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// ObjectProperty: m_hController
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnVillainGunMiniDroneController m_hController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnVillainGunMiniDroneController>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// ObjectProperty: m_hArkhamKnightController
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainGunPredBase m_hArkhamKnightController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainGunPredBase>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// ObjectProperty: m_hBehaviorMeanderPatrolPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint m_hBehaviorMeanderPatrolPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 3172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3172); }
    }

    /// <summary>
    /// ObjectProperty: m_hBehaviorInvestigateTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor m_hBehaviorInvestigateTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }

    /// <summary>
    /// ObjectProperty: m_XrayMIC_Normal
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant m_XrayMIC_Normal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3188); }
    }

    /// <summary>
    /// ObjectProperty: m_XrayMIC_Disrupted
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant m_XrayMIC_Disrupted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3196); }
    }

    /// <summary>
    /// ObjectProperty: m_XrayMIC_Blinded
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant m_XrayMIC_Blinded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// ObjectProperty: m_hCodesHaventBeenDownloadedYetThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech m_hCodesHaventBeenDownloadedYetThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// ObjectProperty: m_hSearchLightSpecifiedTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor m_hSearchLightSpecifiedTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3220); }
    }

    /// <summary>
    /// ObjectProperty: m_ExplosionCachedTargetClass
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass m_ExplosionCachedTargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3228); }
    }

    /// <summary>
    /// ObjectProperty: AudioMovementLoopingEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioMovementLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3236); }
    }

    /// <summary>
    /// ObjectProperty: AudioDestroyEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioDestroyEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3244); }
    }

    /// <summary>
    /// ObjectProperty: AudioElectrocuteLoopingEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioElectrocuteLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3252); }
    }

    /// <summary>
    /// ObjectProperty: AudioAlarm
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioAlarm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3260); }
    }

    /// <summary>
    /// ObjectProperty: ZapClosePlayerSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZapClosePlayerSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3268); }
    }

    /// <summary>
    /// ComponentProperty: m_MiniDroneToControllerLinePSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent m_MiniDroneToControllerLinePSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3276); }
    }

    /// <summary>
    /// ComponentProperty: RHDInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent RHDInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 3284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3284); }
    }

    /// <summary>
    /// ComponentProperty: m_hElectricShield
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent m_hElectricShield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3292); }
    }

    /// <summary>
    /// ComponentProperty: m_hWeaponFlareEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent m_hWeaponFlareEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3300); }
    }

    /// <summary>
    /// ComponentProperty: m_hWeaponPowerUpEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent m_hWeaponPowerUpEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3308); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorMeanderReturnToPath
    /// </summary>
    public unsafe bool m_bBehaviorMeanderReturnToPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorPursueAllowFreeForm
    /// </summary>
    public unsafe bool m_bBehaviorPursueAllowFreeForm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorPursueTargetsAlertPlayerToRoom
    /// </summary>
    public unsafe bool m_bBehaviorPursueTargetsAlertPlayerToRoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorPursueTargetsAlertSoundPlayed
    /// </summary>
    public unsafe bool m_bBehaviorPursueTargetsAlertSoundPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorAttackAllTargets
    /// </summary>
    public unsafe bool m_bBehaviorAttackAllTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorAttackThenSelfDestruct
    /// </summary>
    public unsafe bool m_bBehaviorAttackThenSelfDestruct
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorAttackPoweredUp
    /// </summary>
    public unsafe bool m_bBehaviorAttackPoweredUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorAttackRoomNotified
    /// </summary>
    public unsafe bool m_bBehaviorAttackRoomNotified
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorMeanderKeepAllTargets
    /// </summary>
    public unsafe bool m_bBehaviorMeanderKeepAllTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorArrivedAtInvestigateLocation
    /// </summary>
    public unsafe bool m_bBehaviorArrivedAtInvestigateLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bMovementPursueFreeForm
    /// </summary>
    public unsafe bool m_bMovementPursueFreeForm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bMovementMalfunctionVibrateCycle
    /// </summary>
    public unsafe bool m_bMovementMalfunctionVibrateCycle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bCodesDownloaded
    /// </summary>
    public unsafe bool m_bCodesDownloaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bCanSelfDestruct
    /// </summary>
    public unsafe bool m_bCanSelfDestruct
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bNeverTargetPlayer
    /// </summary>
    public unsafe bool m_bNeverTargetPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: bDeliberatelyAbandoned
    /// </summary>
    public unsafe bool bDeliberatelyAbandoned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bInDetectiveMode
    /// </summary>
    public unsafe bool m_bInDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bRHDTarget
    /// </summary>
    public unsafe bool m_bRHDTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bMiniDroneToControllerLineActive
    /// </summary>
    public unsafe bool m_bMiniDroneToControllerLineActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bMiniDroneToControllerLineInDetectiveMode
    /// </summary>
    public unsafe bool m_bMiniDroneToControllerLineInDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bSpecialTutorialMiniDrone
    /// </summary>
    public unsafe bool m_bSpecialTutorialMiniDrone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// ByteProperty: m_eBehaviorStunnedSource
    /// </summary>
    public unsafe BmSDK.BmScript.RPredatorDroneMini.MalfunctionSource m_eBehaviorStunnedSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPredatorDroneMini.MalfunctionSource>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }

    /// <summary>
    /// ByteProperty: m_eSearchLightTargetMode
    /// </summary>
    public unsafe BmSDK.BmScript.RPredatorDroneMini.SearchLightTargetMode m_eSearchLightTargetMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPredatorDroneMini.SearchLightTargetMode>(Ptr + 3321); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3321); }
    }

    /// <summary>
    /// FloatProperty: m_fBehaviorPursueTargetsAttackDelay
    /// </summary>
    public unsafe float m_fBehaviorPursueTargetsAttackDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3324); }
    }

    /// <summary>
    /// FloatProperty: m_fBehaviorAttackPowerUpTime
    /// </summary>
    public unsafe float m_fBehaviorAttackPowerUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3328); }
    }

    /// <summary>
    /// FloatProperty: m_fBehaviorAttackWeaponTime
    /// </summary>
    public unsafe float m_fBehaviorAttackWeaponTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3332); }
    }

    /// <summary>
    /// FloatProperty: m_fBehaviorInvestigateLocationTime
    /// </summary>
    public unsafe float m_fBehaviorInvestigateLocationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3336); }
    }

    /// <summary>
    /// StructProperty: m_vMovementMeanderSourcePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 m_vMovementMeanderSourcePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3340);

    /// <summary>
    /// StructProperty: m_vMovementMeanderOffsetPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 m_vMovementMeanderOffsetPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3352);

    /// <summary>
    /// StructProperty: m_vMovementMeanderFacingDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 m_vMovementMeanderFacingDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3364);

    /// <summary>
    /// FloatProperty: m_fMovementMeanderFacingTime
    /// </summary>
    public unsafe float m_fMovementMeanderFacingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMeanderDuration
    /// </summary>
    public unsafe float m_fMovementMeanderDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3380); }
    }

    /// <summary>
    /// StructProperty: m_vMovementPursueVantagePoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 m_vMovementPursueVantagePoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3384);

    /// <summary>
    /// StructProperty: m_vMovementPursueVantageTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 m_vMovementPursueVantageTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3396);

    /// <summary>
    /// StructProperty: m_vMovementPursueFacingDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 m_vMovementPursueFacingDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3408);

    /// <summary>
    /// FloatProperty: m_fMovementPursueRePathTime
    /// </summary>
    public unsafe float m_fMovementPursueRePathTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3420); }
    }

    /// <summary>
    /// StructProperty: m_vMovementUncontrolledStrayDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 m_vMovementUncontrolledStrayDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3424);

    /// <summary>
    /// FloatProperty: m_fMovementUncontrolledStraySwagger
    /// </summary>
    public unsafe float m_fMovementUncontrolledStraySwagger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3436); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementUncontrolledTime
    /// </summary>
    public unsafe float m_fMovementUncontrolledTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementUncontrolledVelocity
    /// </summary>
    public unsafe float m_fMovementUncontrolledVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3444); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementUncontrolledSwagger
    /// </summary>
    public unsafe float m_fMovementUncontrolledSwagger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3448); }
    }

    /// <summary>
    /// IntProperty: m_nMovementUncontrolledSpin
    /// </summary>
    public unsafe int m_nMovementUncontrolledSpin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3452); }
    }

    /// <summary>
    /// StructProperty: m_vMovementMalfunctionOriginPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 m_vMovementMalfunctionOriginPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3456);

    /// <summary>
    /// StructProperty: m_vMovementMalfunctionShiftPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 m_vMovementMalfunctionShiftPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3468);

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionShiftAmount
    /// </summary>
    public unsafe float m_fMovementMalfunctionShiftAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionShiftDelay
    /// </summary>
    public unsafe float m_fMovementMalfunctionShiftDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3484); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionVibrateDelay
    /// </summary>
    public unsafe float m_fMovementMalfunctionVibrateDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3488); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionVibrateAmount
    /// </summary>
    public unsafe float m_fMovementMalfunctionVibrateAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3492); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionVibrateDelta
    /// </summary>
    public unsafe float m_fMovementMalfunctionVibrateDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionDuration
    /// </summary>
    public unsafe float m_fMovementMalfunctionDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// FloatProperty: m_fCodesDownloadTime
    /// </summary>
    public unsafe float m_fCodesDownloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// FloatProperty: m_fMaximumMiniDroneControllerInteractionDistance
    /// </summary>
    public unsafe float m_fMaximumMiniDroneControllerInteractionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3508); }
    }

    /// <summary>
    /// ArrayProperty: m_aSearchLights
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterIntermediateBase.FSearchLightData> m_aSearchLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterIntermediateBase.FSearchLightData>>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// IntProperty: m_nSearchLightTargets
    /// </summary>
    public unsafe int m_nSearchLightTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3528); }
    }

    /// <summary>
    /// StructProperty: m_vSearchLightSourcePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 m_vSearchLightSourcePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3532);

    /// <summary>
    /// StructProperty: m_rSearchLightSourceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator m_rSearchLightSourceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3544);

    /// <summary>
    /// StructProperty: m_rSearchLightSourceDirection
    /// </summary>
    public unsafe ref BmSDK.Rotator m_rSearchLightSourceDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3556);

    /// <summary>
    /// FloatProperty: m_fSearchLightMoveInterpolationSpeed
    /// </summary>
    public unsafe float m_fSearchLightMoveInterpolationSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanTiltDesired
    /// </summary>
    public unsafe float m_fSearchLightScanTiltDesired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3572); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanTiltCurrent
    /// </summary>
    public unsafe float m_fSearchLightScanTiltCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanBaseAngle
    /// </summary>
    public unsafe float m_fSearchLightScanBaseAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3580); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanOffsetAngle
    /// </summary>
    public unsafe float m_fSearchLightScanOffsetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanRotateSpeedDesired
    /// </summary>
    public unsafe float m_fSearchLightScanRotateSpeedDesired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3588); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanRotateSpeedCurrent
    /// </summary>
    public unsafe float m_fSearchLightScanRotateSpeedCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanSpreadDesired
    /// </summary>
    public unsafe float m_fSearchLightScanSpreadDesired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3596); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanSpreadCurrent
    /// </summary>
    public unsafe float m_fSearchLightScanSpreadCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightBlindDelay
    /// </summary>
    public unsafe float m_fSearchLightBlindDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3604); }
    }

    /// <summary>
    /// ArrayProperty: m_aTargetList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterIntermediateBase.FTargetData> m_aTargetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterIntermediateBase.FTargetData>>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// ArrayProperty: m_aTargetIgnoreList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> m_aTargetIgnoreList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// FloatProperty: m_fTargetRefreshDelay
    /// </summary>
    public unsafe float m_fTargetRefreshDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// StructProperty: m_vTargetSourcePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 m_vTargetSourcePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3644);

    /// <summary>
    /// StructProperty: m_vTargetSourceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator m_vTargetSourceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3656);

    /// <summary>
    /// NameProperty: m_ExplosionTargetClass
    /// </summary>
    public unsafe BmSDK.FName m_ExplosionTargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3668); }
    }

    /// <summary>
    /// NameProperty: m_ExplosionCachedTargetClassName
    /// </summary>
    public unsafe BmSDK.FName m_ExplosionCachedTargetClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3676); }
    }

    /// <summary>
    /// FloatProperty: m_fExplosionKillRange
    /// </summary>
    public unsafe float m_fExplosionKillRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }

    /// <summary>
    /// Enum: MalfunctionSource
    /// </summary>
    public enum MalfunctionSource : byte
    {
        MALS_Generic = 0,
        MALS_ControllerDisrupted = 1,
        MALS_ElectronicPulse = 2,
        MALS_MAX = 3,
    }

    /// <summary>
    /// Enum: LightColorState
    /// </summary>
    public enum LightColorState : byte
    {
        LCS_Off = 0,
        LCS_Standard = 1,
        LCS_Investigate = 2,
        LCS_Attack = 3,
        LCS_Malfunction = 4,
        LCS_MAX = 5,
    }

    /// <summary>
    /// Enum: SearchLightTargetMode
    /// </summary>
    public enum SearchLightTargetMode : byte
    {
        SLTM_Nothing = 0,
        SLTM_Standard = 1,
        SLTM_AllOrNothing = 2,
        SLTM_Specified = 3,
        SLTM_MAX = 4,
    }
}
