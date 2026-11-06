#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkVehicle<br/>
/// (size = 2128)
/// (flags = 144704182)
/// </summary>
public partial class AkVehicle : BmSDK.Engine.SVehicle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkVehicle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as AkVehicle.
    /// </summary>
    public static AkVehicle DefaultObject => (AkVehicle)StaticClass().DefaultObject;

    internal AkVehicle() { }

    /// <summary>
    /// Constructs a new AkVehicle
    /// </summary>
    public AkVehicle(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkVehicle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkVehicle>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_AudioRemoteWheelSpinActive;
    /// <summary>
    /// Function: AudioRemoteWheelSpinActive
    /// </summary>
    public unsafe virtual bool AudioRemoteWheelSpinActive()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioRemoteWheelSpinActive, "Engine.AkVehicle.AudioRemoteWheelSpinActive");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AudioEject;
    /// <summary>
    /// Function: AudioEject
    /// </summary>
    public unsafe virtual void AudioEject()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioEject, "Engine.AkVehicle.AudioEject");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AudioRemoteWheelSpin;
    /// <summary>
    /// Function: AudioRemoteWheelSpin
    /// </summary>
    public unsafe virtual void AudioRemoteWheelSpin(bool Active)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioRemoteWheelSpin, "Engine.AkVehicle.AudioRemoteWheelSpin");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Active, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AudioRemoteCalledIn;
    /// <summary>
    /// Function: AudioRemoteCalledIn
    /// </summary>
    public unsafe virtual void AudioRemoteCalledIn(bool remoting)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioRemoteCalledIn, "Engine.AkVehicle.AudioRemoteCalledIn");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(remoting, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StopVehicleSounds;
    /// <summary>
    /// Function: StopVehicleSounds
    /// </summary>
    public unsafe override void StopVehicleSounds()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopVehicleSounds, "Engine.AkVehicle.StopVehicleSounds");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnLeft;
    /// <summary>
    /// Function: PawnLeft
    /// </summary>
    public unsafe virtual void PawnLeft(BmSDK.Engine.Pawn P, bool trunk)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnLeft, "Engine.AkVehicle.PawnLeft");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(trunk, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnEntered;
    /// <summary>
    /// Function: PawnEntered
    /// </summary>
    public unsafe virtual void PawnEntered(BmSDK.Engine.Pawn P, bool trunk)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnEntered, "Engine.AkVehicle.PawnEntered");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(trunk, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DriverLeft;
    /// <summary>
    /// Function: DriverLeft
    /// </summary>
    public unsafe override void DriverLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DriverLeft, "Engine.AkVehicle.DriverLeft");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DriverEnter;
    /// <summary>
    /// Function: DriverEnter
    /// </summary>
    public unsafe override bool DriverEnter(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DriverEnter, "Engine.AkVehicle.DriverEnter");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "Engine.AkVehicle.Died");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_AudioSetSwitch;
    /// <summary>
    /// Function: AudioSetSwitch
    /// </summary>
    public unsafe virtual void AudioSetSwitch(BmSDK.Engine.AkSwitchName switchToSet)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioSetSwitch, "Engine.AkVehicle.AudioSetSwitch");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(switchToSet, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AudioSkidToStop;
    /// <summary>
    /// Function: AudioSkidToStop
    /// </summary>
    public unsafe virtual void AudioSkidToStop(float timeBeforeSkidStops)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioSkidToStop, "Engine.AkVehicle.AudioSkidToStop");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeBeforeSkidStops, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AudioSetDrivingHillFactor;
    /// <summary>
    /// Function: AudioSetDrivingHillFactor
    /// </summary>
    public unsafe virtual void AudioSetDrivingHillFactor(float factor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioSetDrivingHillFactor, "Engine.AkVehicle.AudioSetDrivingHillFactor");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(factor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AudioSetDrivingMode;
    /// <summary>
    /// Function: AudioSetDrivingMode
    /// </summary>
    public unsafe virtual void AudioSetDrivingMode(BmSDK.Engine.AkVehicleSoundInfo.EDrivingModes DrivingMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioSetDrivingMode, "Engine.AkVehicle.AudioSetDrivingMode");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrivingMode, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AudioVehicleHasBeenTeleported;
    /// <summary>
    /// Function: AudioVehicleHasBeenTeleported
    /// </summary>
    public unsafe virtual void AudioVehicleHasBeenTeleported(float SecondToSettle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioVehicleHasBeenTeleported, "Engine.AkVehicle.AudioVehicleHasBeenTeleported");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondToSettle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AudioGetClutch;
    /// <summary>
    /// Function: AudioGetClutch
    /// </summary>
    public unsafe virtual bool AudioGetClutch()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioGetClutch, "Engine.AkVehicle.AudioGetClutch");
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

    private static BmSDK.Function __fn_AudioSquealing;
    /// <summary>
    /// Function: AudioSquealing
    /// </summary>
    public unsafe virtual void AudioSquealing(float squealAmount)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioSquealing, "Engine.AkVehicle.AudioSquealing");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(squealAmount, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AudioDrifting;
    /// <summary>
    /// Function: AudioDrifting
    /// </summary>
    public unsafe override void AudioDrifting(bool isDrifting)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioDrifting, "Engine.AkVehicle.AudioDrifting");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isDrifting, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AudioWheelSpinning;
    /// <summary>
    /// Function: AudioWheelSpinning
    /// </summary>
    public unsafe override void AudioWheelSpinning(bool setWheelSpinning)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioWheelSpinning, "Engine.AkVehicle.AudioWheelSpinning");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(setWheelSpinning, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AudioForceBrake;
    /// <summary>
    /// Function: AudioForceBrake
    /// </summary>
    public unsafe virtual void AudioForceBrake(bool setForceBrake)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioForceBrake, "Engine.AkVehicle.AudioForceBrake");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(setForceBrake, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AudioStopAllWheels;
    /// <summary>
    /// Function: AudioStopAllWheels
    /// </summary>
    public unsafe override void AudioStopAllWheels()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioStopAllWheels, "Engine.AkVehicle.AudioStopAllWheels");
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

    private static BmSDK.Function __fn_AudioStopWheelSqueal;
    /// <summary>
    /// Function: AudioStopWheelSqueal
    /// </summary>
    public unsafe override void AudioStopWheelSqueal(BmSDK.FName WheelBone)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioStopWheelSqueal, "Engine.AkVehicle.AudioStopWheelSqueal");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WheelBone, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AudioUpdateWheelSqueal;
    /// <summary>
    /// Function: AudioUpdateWheelSqueal
    /// </summary>
    public unsafe override void AudioUpdateWheelSqueal(BmSDK.FName WheelBone, float SquealValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioUpdateWheelSqueal, "Engine.AkVehicle.AudioUpdateWheelSqueal");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WheelBone, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SquealValue, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetNumSteerableWheelsOnGround;
    /// <summary>
    /// Function: GetNumSteerableWheelsOnGround
    /// </summary>
    public unsafe virtual int GetNumSteerableWheelsOnGround()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumSteerableWheelsOnGround, "Engine.AkVehicle.GetNumSteerableWheelsOnGround");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumWheelsOnFlatGround;
    /// <summary>
    /// Function: GetNumWheelsOnFlatGround
    /// </summary>
    public unsafe virtual int GetNumWheelsOnFlatGround(float flatNormalZ)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumWheelsOnFlatGround, "Engine.AkVehicle.GetNumWheelsOnFlatGround");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(flatNormalZ, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumWheelsOnGround;
    /// <summary>
    /// Function: GetNumWheelsOnGround
    /// </summary>
    public unsafe virtual int GetNumWheelsOnGround()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumWheelsOnGround, "Engine.AkVehicle.GetNumWheelsOnGround");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AudioVehicleRotating;
    /// <summary>
    /// Function: AudioVehicleRotating
    /// </summary>
    public unsafe virtual bool AudioVehicleRotating()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioVehicleRotating, "Engine.AkVehicle.AudioVehicleRotating");
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

    private static BmSDK.Function __fn_AudioAltGetForceWheelSpin;
    /// <summary>
    /// Function: AudioAltGetForceWheelSpin
    /// </summary>
    public unsafe virtual bool AudioAltGetForceWheelSpin()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioAltGetForceWheelSpin, "Engine.AkVehicle.AudioAltGetForceWheelSpin");
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

    private static BmSDK.Function __fn_AudioGetForceStop;
    /// <summary>
    /// Function: AudioGetForceStop
    /// </summary>
    public unsafe virtual bool AudioGetForceStop()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioGetForceStop, "Engine.AkVehicle.AudioGetForceStop");
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

    private static BmSDK.Function __fn_AudioAltRPMIsPriority;
    /// <summary>
    /// Function: AudioAltRPMIsPriority
    /// </summary>
    public unsafe virtual bool AudioAltRPMIsPriority(int Mode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioAltRPMIsPriority, "Engine.AkVehicle.AudioAltRPMIsPriority");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AudioGetAlternateLoad;
    /// <summary>
    /// Function: AudioGetAlternateLoad
    /// </summary>
    public unsafe virtual float AudioGetAlternateLoad(int Mode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioGetAlternateLoad, "Engine.AkVehicle.AudioGetAlternateLoad");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AudioGetAlternateRPMVector;
    /// <summary>
    /// Function: AudioGetAlternateRPMVector
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 AudioGetAlternateRPMVector()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioGetAlternateRPMVector, "Engine.AkVehicle.AudioGetAlternateRPMVector");
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AudioGetAlternateRPM;
    /// <summary>
    /// Function: AudioGetAlternateRPM
    /// </summary>
    public unsafe virtual float AudioGetAlternateRPM(int Mode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioGetAlternateRPM, "Engine.AkVehicle.AudioGetAlternateRPM");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AudioInAlternativeMode;
    /// <summary>
    /// Function: AudioInAlternativeMode
    /// </summary>
    public unsafe virtual int AudioInAlternativeMode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioInAlternativeMode, "Engine.AkVehicle.AudioInAlternativeMode");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AudioGetRPM;
    /// <summary>
    /// Function: AudioGetRPM
    /// </summary>
    public unsafe virtual float AudioGetRPM(bool unlerped = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AudioGetRPM, "Engine.AkVehicle.AudioGetRPM");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(unlerped, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    /// <summary>
    /// ObjectProperty: NewVehicleSound
    /// </summary>
    public unsafe BmSDK.Engine.AkVehicleSoundVar NewVehicleSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkVehicleSoundVar>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// ObjectProperty: LastDriver
    /// </summary>
    public unsafe BmSDK.Engine.Pawn LastDriver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// ComponentProperty: VehicleSound
    /// </summary>
    public unsafe BmSDK.Engine.AkVehicleSound VehicleSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkVehicleSound>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// ArrayProperty: WhooshBys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkWwise.FSimpleWhooshBy> WhooshBys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkWwise.FSimpleWhooshBy>>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// BoolProperty: OldOutputBrake
    /// </summary>
    public unsafe bool OldOutputBrake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// BoolProperty: bIsOnJump
    /// </summary>
    public unsafe bool bIsOnJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// BoolProperty: bTwoWheelsOnJump
    /// </summary>
    public unsafe bool bTwoWheelsOnJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// BoolProperty: bWasOnJump
    /// </summary>
    public unsafe bool bWasOnJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// BoolProperty: bIsOnBigJump
    /// </summary>
    public unsafe bool bIsOnBigJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// BoolProperty: bIsOnAutoAlignJump
    /// </summary>
    public unsafe bool bIsOnAutoAlignJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// FloatProperty: SpeedDelta
    /// </summary>
    public unsafe float SpeedDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// FloatProperty: ForceSqueal
    /// </summary>
    public unsafe float ForceSqueal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// FloatProperty: BrakeOnStoppedCounter
    /// </summary>
    public unsafe float BrakeOnStoppedCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }
}
