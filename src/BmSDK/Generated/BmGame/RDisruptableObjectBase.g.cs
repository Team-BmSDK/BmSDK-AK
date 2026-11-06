#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDisruptableObjectBase<br/>
/// (size = 816)
/// (flags = 144703634)
/// </summary>
public partial class RDisruptableObjectBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDisruptableObjectBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RDisruptableObjectBase.
    /// </summary>
    public static RDisruptableObjectBase DefaultObject => (RDisruptableObjectBase)StaticClass().DefaultObject;

    internal RDisruptableObjectBase() { }

    /// <summary>
    /// Constructs a new RDisruptableObjectBase
    /// </summary>
    public RDisruptableObjectBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDisruptableObjectBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptableObjectBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ShouldPlayBombBarks;
    /// <summary>
    /// Function: ShouldPlayBombBarks
    /// </summary>
    public unsafe virtual bool ShouldPlayBombBarks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPlayBombBarks, "BmGame.RDisruptableObjectBase.ShouldPlayBombBarks");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisallowLongRangeResonator;
    /// <summary>
    /// Function: DisallowLongRangeResonator
    /// </summary>
    public unsafe virtual bool DisallowLongRangeResonator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisallowLongRangeResonator, "BmGame.RDisruptableObjectBase.DisallowLongRangeResonator");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayIconName;
    /// <summary>
    /// Function: GetDisplayIconName
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayIconName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayIconName, "BmGame.RDisruptableObjectBase.GetDisplayIconName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInputDialSeed;
    /// <summary>
    /// Function: GetInputDialSeed
    /// </summary>
    public unsafe virtual int GetInputDialSeed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInputDialSeed, "BmGame.RDisruptableObjectBase.GetInputDialSeed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPassword;
    /// <summary>
    /// Function: GetPassword
    /// </summary>
    public unsafe virtual BmSDK.FString GetPassword(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPassword, "BmGame.RDisruptableObjectBase.GetPassword");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPasswordArrayLength;
    /// <summary>
    /// Function: GetPasswordArrayLength
    /// </summary>
    public unsafe virtual int GetPasswordArrayLength()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPasswordArrayLength, "BmGame.RDisruptableObjectBase.GetPasswordArrayLength");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetResonatorMinigameStringReference;
    /// <summary>
    /// Function: GetResonatorMinigameStringReference
    /// </summary>
    public unsafe virtual BmSDK.FString GetResonatorMinigameStringReference()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResonatorMinigameStringReference, "BmGame.RDisruptableObjectBase.GetResonatorMinigameStringReference");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetResonatorWinScreenStringReference;
    /// <summary>
    /// Function: GetResonatorWinScreenStringReference
    /// </summary>
    public unsafe virtual BmSDK.FString GetResonatorWinScreenStringReference()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResonatorWinScreenStringReference, "BmGame.RDisruptableObjectBase.GetResonatorWinScreenStringReference");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRawDifficulty;
    /// <summary>
    /// Function: GetRawDifficulty
    /// </summary>
    public unsafe virtual int GetRawDifficulty()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRawDifficulty, "BmGame.RDisruptableObjectBase.GetRawDifficulty");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHackingTargetType;
    /// <summary>
    /// Function: GetHackingTargetType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectTargetType GetHackingTargetType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHackingTargetType, "BmGame.RDisruptableObjectBase.GetHackingTargetType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectTargetType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHackingNetworkType;
    /// <summary>
    /// Function: GetHackingNetworkType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectNetworkType GetHackingNetworkType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHackingNetworkType, "BmGame.RDisruptableObjectBase.GetHackingNetworkType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectNetworkType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActiveFlag;
    /// <summary>
    /// Function: GetActiveFlag
    /// </summary>
    public unsafe virtual BmSDK.FName GetActiveFlag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActiveFlag, "BmGame.RDisruptableObjectBase.GetActiveFlag");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDifficultyLevel;
    /// <summary>
    /// Function: GetDifficultyLevel
    /// </summary>
    public unsafe virtual int GetDifficultyLevel()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDifficultyLevel, "BmGame.RDisruptableObjectBase.GetDifficultyLevel");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasMultipleStages;
    /// <summary>
    /// Function: HasMultipleStages
    /// </summary>
    public unsafe virtual bool HasMultipleStages()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasMultipleStages, "BmGame.RDisruptableObjectBase.HasMultipleStages");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartResonatorMinigame;
    /// <summary>
    /// Function: StartResonatorMinigame
    /// </summary>
    public unsafe virtual void StartResonatorMinigame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartResonatorMinigame, "BmGame.RDisruptableObjectBase.StartResonatorMinigame");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FailedToDisrupt;
    /// <summary>
    /// Function: FailedToDisrupt
    /// </summary>
    public unsafe virtual void FailedToDisrupt()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FailedToDisrupt, "BmGame.RDisruptableObjectBase.FailedToDisrupt");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NextStage;
    /// <summary>
    /// Function: NextStage
    /// </summary>
    public unsafe virtual bool NextStage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextStage, "BmGame.RDisruptableObjectBase.NextStage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WillExplode;
    /// <summary>
    /// Function: WillExplode
    /// </summary>
    public unsafe virtual bool WillExplode()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillExplode, "BmGame.RDisruptableObjectBase.WillExplode");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetIconLocation;
    /// <summary>
    /// Function: GetIconLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetIconLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIconLocation, "BmGame.RDisruptableObjectBase.GetIconLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StillDisruptable;
    /// <summary>
    /// Function: StillDisruptable
    /// </summary>
    public unsafe virtual bool StillDisruptable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StillDisruptable, "BmGame.RDisruptableObjectBase.StillDisruptable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SecureAreaToContinueMessageDisplayed;
    /// <summary>
    /// Function: SecureAreaToContinueMessageDisplayed
    /// </summary>
    public unsafe virtual void SecureAreaToContinueMessageDisplayed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecureAreaToContinueMessageDisplayed, "BmGame.RDisruptableObjectBase.SecureAreaToContinueMessageDisplayed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PasswordFound;
    /// <summary>
    /// Function: PasswordFound
    /// </summary>
    public unsafe virtual void PasswordFound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PasswordFound, "BmGame.RDisruptableObjectBase.PasswordFound");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuccessfullyDisrupted;
    /// <summary>
    /// Function: SuccessfullyDisrupted
    /// </summary>
    public unsafe virtual void SuccessfullyDisrupted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfullyDisrupted, "BmGame.RDisruptableObjectBase.SuccessfullyDisrupted");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDifficulty;
    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe virtual void GetDifficulty(out float Threshold, out float BuildUpTime, out float LeftMaxAngVelocity, out float RightMaxAngVelocity, int DifficultyMod = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDifficulty, "BmGame.RDisruptableObjectBase.GetDifficulty");
        byte* paramsPtr = stackalloc byte[28];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Threshold);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Threshold, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BuildUpTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BuildUpTime, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LeftMaxAngVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftMaxAngVelocity, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RightMaxAngVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightMaxAngVelocity, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DifficultyMod, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Threshold = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        BuildUpTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        LeftMaxAngVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        RightMaxAngVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_InResonatorThreshold;
    /// <summary>
    /// Function: InResonatorThreshold
    /// </summary>
    public unsafe virtual void InResonatorThreshold(bool InThreshold)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InResonatorThreshold, "BmGame.RDisruptableObjectBase.InResonatorThreshold");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InThreshold, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RDisruptableObjectBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLeftResonantPosition;
    /// <summary>
    /// Function: GetLeftResonantPosition
    /// </summary>
    public unsafe virtual float GetLeftResonantPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeftResonantPosition, "BmGame.RDisruptableObjectBase.GetLeftResonantPosition");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRightResonantPosition;
    /// <summary>
    /// Function: GetRightResonantPosition
    /// </summary>
    public unsafe virtual float GetRightResonantPosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRightResonantPosition, "BmGame.RDisruptableObjectBase.GetRightResonantPosition");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaximumInteractionDistance;
    /// <summary>
    /// Function: GetMaximumInteractionDistance
    /// </summary>
    public unsafe virtual float GetMaximumInteractionDistance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaximumInteractionDistance, "BmGame.RDisruptableObjectBase.GetMaximumInteractionDistance");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_VeryLowSecurity;
    /// <summary>
    /// Function: VeryLowSecurity
    /// </summary>
    public unsafe virtual bool VeryLowSecurity()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VeryLowSecurity, "BmGame.RDisruptableObjectBase.VeryLowSecurity");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RequiresHighSecurityResonator;
    /// <summary>
    /// Function: RequiresHighSecurityResonator
    /// </summary>
    public unsafe virtual bool RequiresHighSecurityResonator()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequiresHighSecurityResonator, "BmGame.RDisruptableObjectBase.RequiresHighSecurityResonator");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopAlarmSound;
    /// <summary>
    /// Function: StopAlarmSound
    /// </summary>
    public unsafe virtual void StopAlarmSound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAlarmSound, "BmGame.RDisruptableObjectBase.StopAlarmSound");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAlarmSound;
    /// <summary>
    /// Function: PlayAlarmSound
    /// </summary>
    public unsafe virtual void PlayAlarmSound()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAlarmSound, "BmGame.RDisruptableObjectBase.PlayAlarmSound");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAlarmed;
    /// <summary>
    /// Function: IsAlarmed
    /// </summary>
    public unsafe virtual bool IsAlarmed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAlarmed, "BmGame.RDisruptableObjectBase.IsAlarmed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOverworldHintRange;
    /// <summary>
    /// Function: GetOverworldHintRange
    /// </summary>
    public unsafe virtual int GetOverworldHintRange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverworldHintRange, "BmGame.RDisruptableObjectBase.GetOverworldHintRange");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSatnavToRoadAtSameHeight;
    /// <summary>
    /// Function: GetSatnavToRoadAtSameHeight
    /// </summary>
    public unsafe virtual bool GetSatnavToRoadAtSameHeight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSatnavToRoadAtSameHeight, "BmGame.RDisruptableObjectBase.GetSatnavToRoadAtSameHeight");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSatnavToRoadBelow;
    /// <summary>
    /// Function: GetSatnavToRoadBelow
    /// </summary>
    public unsafe virtual bool GetSatnavToRoadBelow()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSatnavToRoadBelow, "BmGame.RDisruptableObjectBase.GetSatnavToRoadBelow");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCustomFlag;
    /// <summary>
    /// Function: GetCustomFlag
    /// </summary>
    public unsafe virtual BmSDK.FString GetCustomFlag()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomFlag, "BmGame.RDisruptableObjectBase.GetCustomFlag");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUnlockedChapter;
    /// <summary>
    /// Function: GetUnlockedChapter
    /// </summary>
    public unsafe virtual int GetUnlockedChapter()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedChapter, "BmGame.RDisruptableObjectBase.GetUnlockedChapter");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMapIconFloatUpAdjustment;
    /// <summary>
    /// Function: GetMapIconFloatUpAdjustment
    /// </summary>
    public unsafe virtual int GetMapIconFloatUpAdjustment()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMapIconFloatUpAdjustment, "BmGame.RDisruptableObjectBase.GetMapIconFloatUpAdjustment");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UseSecretLocation;
    /// <summary>
    /// Function: UseSecretLocation
    /// </summary>
    public unsafe virtual bool UseSecretLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseSecretLocation, "BmGame.RDisruptableObjectBase.UseSecretLocation");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretLocationZ;
    /// <summary>
    /// Function: GetSecretLocationZ
    /// </summary>
    public unsafe virtual int GetSecretLocationZ()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretLocationZ, "BmGame.RDisruptableObjectBase.GetSecretLocationZ");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretLocationY;
    /// <summary>
    /// Function: GetSecretLocationY
    /// </summary>
    public unsafe virtual int GetSecretLocationY()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretLocationY, "BmGame.RDisruptableObjectBase.GetSecretLocationY");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretLocationX;
    /// <summary>
    /// Function: GetSecretLocationX
    /// </summary>
    public unsafe virtual int GetSecretLocationX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretLocationX, "BmGame.RDisruptableObjectBase.GetSecretLocationX");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretZone;
    /// <summary>
    /// Function: GetSecretZone
    /// </summary>
    public unsafe virtual byte GetSecretZone()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretZone, "BmGame.RDisruptableObjectBase.GetSecretZone");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretPickupIndex;
    /// <summary>
    /// Function: GetSecretPickupIndex
    /// </summary>
    public unsafe virtual int GetSecretPickupIndex()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretPickupIndex, "BmGame.RDisruptableObjectBase.GetSecretPickupIndex");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretSubType;
    /// <summary>
    /// Function: GetSecretSubType
    /// </summary>
    public unsafe virtual BmSDK.FString GetSecretSubType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretSubType, "BmGame.RDisruptableObjectBase.GetSecretSubType");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSecretName;
    /// <summary>
    /// Function: GetSecretName
    /// </summary>
    public unsafe virtual BmSDK.FString GetSecretName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecretName, "BmGame.RDisruptableObjectBase.GetSecretName");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidSecret;
    /// <summary>
    /// Function: IsValidSecret
    /// </summary>
    public unsafe virtual bool IsValidSecret()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidSecret, "BmGame.RDisruptableObjectBase.IsValidSecret");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: DisruptableObjectDifficulty
    /// </summary>
    public enum DisruptableObjectDifficulty : byte
    {
        DOD_VeryEasy = 0,
        DOD_Easy = 1,
        DOD_Medium = 2,
        DOD_Hard = 3,
        DOD_VeryHard = 4,
        DOD_Stupid = 5,
        DOD_MAX = 6,
    }

    /// <summary>
    /// StructProperty: VfTable_IRSecretInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSecretInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ComponentProperty: StaticMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent StaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ByteProperty: Difficulty
    /// </summary>
    public unsafe BmSDK.BmGame.RDisruptableObjectBase.DisruptableObjectDifficulty Difficulty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDisruptableObjectBase.DisruptableObjectDifficulty>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ByteProperty: HackingNetworkType
    /// </summary>
    public unsafe BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectNetworkType HackingNetworkType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectNetworkType>(Ptr + 685); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 685); }
    }

    /// <summary>
    /// ByteProperty: HackingTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectTargetType HackingTargetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectTargetType>(Ptr + 686); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 686); }
    }

    /// <summary>
    /// StructProperty: DisruptableIconOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DisruptableIconOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 688);

    /// <summary>
    /// BoolProperty: bDisrupted
    /// </summary>
    public unsafe bool bDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bExplodes
    /// </summary>
    public unsafe bool bExplodes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bSecureAreaToContinueMessageDisplayed
    /// </summary>
    public unsafe bool bSecureAreaToContinueMessageDisplayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bRequiresHighSecurityResonator
    /// </summary>
    public unsafe bool bRequiresHighSecurityResonator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bDisableUntilGiveGadget
    /// </summary>
    public unsafe bool bDisableUntilGiveGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bDisabledForStory
    /// </summary>
    public unsafe bool bDisabledForStory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: RumbleEnabledInMinigame
    /// </summary>
    public unsafe bool RumbleEnabledInMinigame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bDisabledWithAreaSecureMessage
    /// </summary>
    public unsafe bool bDisabledWithAreaSecureMessage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bDisallowLongRangeResonator
    /// </summary>
    public unsafe bool bDisallowLongRangeResonator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// NameProperty: ActiveFlag
    /// </summary>
    public unsafe BmSDK.FName ActiveFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// IntProperty: FloatUpAdjust
    /// </summary>
    public unsafe int FloatUpAdjust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: RightResonantFrequency
    /// </summary>
    public unsafe float RightResonantFrequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: LeftResonantFrequency
    /// </summary>
    public unsafe float LeftResonantFrequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: ResonatorMinigamePackageReference
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ResonatorMinigamePackageReference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: ResonatorWinScreenPackageReference
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ResonatorWinScreenPackageReference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// StrProperty: ResonatorMinigameStringReference
    /// </summary>
    public unsafe BmSDK.FString ResonatorMinigameStringReference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ArrayProperty: PasswordArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PasswordArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// IntProperty: InputDialSeed
    /// </summary>
    public unsafe int InputDialSeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// IntProperty: InputDialRandomSeed
    /// </summary>
    public unsafe int InputDialRandomSeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// StrProperty: DisplayIconName
    /// </summary>
    public unsafe BmSDK.FString DisplayIconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// StrProperty: ResonatorWinScreenStringReference
    /// </summary>
    public unsafe BmSDK.FString ResonatorWinScreenStringReference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: fMaximumInteractionDistance
    /// </summary>
    public unsafe float fMaximumInteractionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }
}
