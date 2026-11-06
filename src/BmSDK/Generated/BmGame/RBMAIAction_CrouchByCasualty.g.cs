#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIAction_CrouchByCasualty<br/>
/// (size = 916)
/// (flags = 10485778)
/// </summary>
public partial class RBMAIAction_CrouchByCasualty : BmSDK.BmGame.RBMAIAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIAction_CrouchByCasualty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMAIAction_CrouchByCasualty.
    /// </summary>
    public static RBMAIAction_CrouchByCasualty DefaultObject => (RBMAIAction_CrouchByCasualty)StaticClass().DefaultObject;

    internal RBMAIAction_CrouchByCasualty() { }

    /// <summary>
    /// Constructs a new RBMAIAction_CrouchByCasualty
    /// </summary>
    public RBMAIAction_CrouchByCasualty(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIAction_CrouchByCasualty(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_CrouchByCasualty>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_CrouchByCasualty>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_CrouchByCasualty>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_CrouchByCasualty>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_CrouchByCasualty>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_CrouchByCasualty>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_CrouchByCasualty>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_CrouchByCasualty>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlayHangingGuyBark;
    /// <summary>
    /// Function: PlayHangingGuyBark
    /// </summary>
    public unsafe virtual void PlayHangingGuyBark()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHangingGuyBark, "BmGame.RBMAIAction_CrouchByCasualty.PlayHangingGuyBark");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAnimForGesture;
    /// <summary>
    /// Function: GetAnimForGesture
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig GetAnimForGesture(BmSDK.FString Gesture)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimForGesture, "BmGame.RBMAIAction_CrouchByCasualty.GetAnimForGesture");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gesture, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetStateFromDialogueTag;
    /// <summary>
    /// Function: GetStateFromDialogueTag
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIAction_CrouchByCasualty.CheckManDown_OverlayState GetStateFromDialogueTag(BmSDK.FString Gesture)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStateFromDialogueTag, "BmGame.RBMAIAction_CrouchByCasualty.GetStateFromDialogueTag");
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gesture, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIAction_CrouchByCasualty.CheckManDown_OverlayState>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HandleDialogueAnimation;
    /// <summary>
    /// Function: HandleDialogueAnimation
    /// </summary>
    public unsafe override void HandleDialogueAnimation(BmSDK.FString Gesture)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleDialogueAnimation, "BmGame.RBMAIAction_CrouchByCasualty.HandleDialogueAnimation");
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gesture, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAdditiveAnimForIndex;
    /// <summary>
    /// Function: GetAdditiveAnimForIndex
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig GetAdditiveAnimForIndex(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdditiveAnimForIndex, "BmGame.RBMAIAction_CrouchByCasualty.GetAdditiveAnimForIndex");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRandomAdditiveAnimIndex;
    /// <summary>
    /// Function: GetRandomAdditiveAnimIndex
    /// </summary>
    public unsafe virtual int GetRandomAdditiveAnimIndex()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomAdditiveAnimIndex, "BmGame.RBMAIAction_CrouchByCasualty.GetRandomAdditiveAnimIndex");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ActionTick;
    /// <summary>
    /// Function: ActionTick
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMAIAction.ActionTickResult ActionTick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActionTick, "BmGame.RBMAIAction_CrouchByCasualty.ActionTick");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIAction.ActionTickResult>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InitManUpPose;
    /// <summary>
    /// Function: InitManUpPose
    /// </summary>
    public unsafe virtual void InitManUpPose()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitManUpPose, "BmGame.RBMAIAction_CrouchByCasualty.InitManUpPose");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCrouch;
    /// <summary>
    /// Function: StartCrouch
    /// </summary>
    public unsafe virtual void StartCrouch(BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCrouch, "BmGame.RBMAIAction_CrouchByCasualty.StartCrouch");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmGame.RBMAIAction_CrouchByCasualty.OnDeactivate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmGame.RBMAIAction_CrouchByCasualty.OnActivate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCasualty;
    /// <summary>
    /// Function: SetCasualty
    /// </summary>
    public unsafe virtual void SetCasualty(BmSDK.BmGame.RPawnVillain NewCas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCasualty, "BmGame.RBMAIAction_CrouchByCasualty.SetCasualty");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndJokerHallucination;
    /// <summary>
    /// Function: EndJokerHallucination
    /// </summary>
    public unsafe virtual void EndJokerHallucination()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndJokerHallucination, "BmGame.RBMAIAction_CrouchByCasualty.EndJokerHallucination");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoJokerOverlay;
    /// <summary>
    /// Function: DoJokerOverlay
    /// </summary>
    public unsafe virtual void DoJokerOverlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoJokerOverlay, "BmGame.RBMAIAction_CrouchByCasualty.DoJokerOverlay");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoSlavedJokerHallucination;
    /// <summary>
    /// Function: DoSlavedJokerHallucination
    /// </summary>
    public unsafe virtual void DoSlavedJokerHallucination(bool bIgnoreCollisionCheck, float AngleOffset, System.Numerics.Vector3 refLoc, BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoSlavedJokerHallucination, "BmGame.RBMAIAction_CrouchByCasualty.DoSlavedJokerHallucination");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreCollisionCheck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleOffset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(refLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetJokerHallucinationFadeMultiplier;
    /// <summary>
    /// Function: GetJokerHallucinationFadeMultiplier
    /// </summary>
    public unsafe virtual int GetJokerHallucinationFadeMultiplier()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJokerHallucinationFadeMultiplier, "BmGame.RBMAIAction_CrouchByCasualty.GetJokerHallucinationFadeMultiplier");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: CheckManDown_OverlayState
    /// </summary>
    public enum CheckManDown_OverlayState : byte
    {
        CMD_Any = 0,
        CMD_FaceDown = 1,
        CMD_FaceBack = 2,
        CMD_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: Casualty
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Casualty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// BoolProperty: bStartedPlayConsole
    /// </summary>
    public unsafe bool bStartedPlayConsole
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 872); }
    }

    /// <summary>
    /// BoolProperty: bPlayedConsoleReply
    /// </summary>
    public unsafe bool bPlayedConsoleReply
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 872); }
    }

    /// <summary>
    /// StructProperty: LastAdditiveAnim
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId LastAdditiveAnim
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 876);

    /// <summary>
    /// StructProperty: transitionLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 transitionLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 884);

    /// <summary>
    /// StructProperty: transitionRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator transitionRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 896);

    /// <summary>
    /// ByteProperty: CurrentOverlayState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction_CrouchByCasualty.CheckManDown_OverlayState CurrentOverlayState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction_CrouchByCasualty.CheckManDown_OverlayState>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenJokerHallucinationOverlays
    /// </summary>
    public unsafe float TimeBetweenJokerHallucinationOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }
}
