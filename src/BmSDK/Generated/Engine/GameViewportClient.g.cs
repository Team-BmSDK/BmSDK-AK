#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameViewportClient<br/>
/// (size = 460)
/// (flags = 134217918)
/// </summary>
public partial class GameViewportClient : BmSDK.Engine.ScriptViewportClient, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameViewportClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GameViewportClient.
    /// </summary>
    public static GameViewportClient DefaultObject => (GameViewportClient)StaticClass().DefaultObject;

    internal GameViewportClient() { }

    /// <summary>
    /// Constructs a new GameViewportClient
    /// </summary>
    public GameViewportClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameViewportClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameViewportClient(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetHardwareMouseCursorVisibility;
    /// <summary>
    /// Function: SetHardwareMouseCursorVisibility
    /// </summary>
    public unsafe virtual void SetHardwareMouseCursorVisibility(bool bIsVisible)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHardwareMouseCursorVisibility, "Engine.GameViewportClient.SetHardwareMouseCursorVisibility");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugSetUISystemEnabled;
    /// <summary>
    /// Function: DebugSetUISystemEnabled
    /// </summary>
    public unsafe virtual void DebugSetUISystemEnabled(bool bOldUISystemActive, bool bGFxUISystemActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugSetUISystemEnabled, "Engine.GameViewportClient.DebugSetUISystemEnabled");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOldUISystemActive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGFxUISystemActive, paramsPtr + 4);
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

    private static BmSDK.Function __fn_BecomePrimaryPlayer;
    /// <summary>
    /// Function: BecomePrimaryPlayer
    /// </summary>
    public unsafe virtual void BecomePrimaryPlayer(int PlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BecomePrimaryPlayer, "Engine.GameViewportClient.BecomePrimaryPlayer");
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPrimaryPlayerSwitch;
    /// <summary>
    /// Function: OnPrimaryPlayerSwitch
    /// </summary>
    public unsafe virtual void OnPrimaryPlayerSwitch(BmSDK.Engine.LocalPlayer OldPrimaryPlayer, BmSDK.Engine.LocalPlayer NewPrimaryPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPrimaryPlayerSwitch, "Engine.GameViewportClient.OnPrimaryPlayerSwitch");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPrimaryPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPrimaryPlayer, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FixupOwnerReferences;
    /// <summary>
    /// Function: FixupOwnerReferences
    /// </summary>
    public unsafe virtual void FixupOwnerReferences(BmSDK.TArray<int> IDMappings)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FixupOwnerReferences, "Engine.GameViewportClient.FixupOwnerReferences");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IDMappings, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetPlayerOwner;
    /// <summary>
    /// Function: GetPlayerOwner
    /// </summary>
    public unsafe virtual BmSDK.Engine.LocalPlayer GetPlayerOwner(int PlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerOwner, "Engine.GameViewportClient.GetPlayerOwner");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LocalPlayer>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetDynamicShadows;
    /// <summary>
    /// Function: SetDynamicShadows
    /// </summary>
    public unsafe virtual void SetDynamicShadows(bool OnOrOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDynamicShadows, "Engine.GameViewportClient.SetDynamicShadows");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearProgressMessages;
    /// <summary>
    /// Function: ClearProgressMessages
    /// </summary>
    public unsafe virtual void ClearProgressMessages()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearProgressMessages, "Engine.GameViewportClient.ClearProgressMessages");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetProgressTime;
    /// <summary>
    /// Function: SetProgressTime
    /// </summary>
    public unsafe virtual void SetProgressTime(float T)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProgressTime, "Engine.GameViewportClient.SetProgressTime");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyConnectionError;
    /// <summary>
    /// Function: NotifyConnectionError
    /// </summary>
    public unsafe virtual void NotifyConnectionError(BmSDK.Engine.PlayerController.EProgressMessageType MessageType, BmSDK.FString Message = default, BmSDK.FString Title = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyConnectionError, "Engine.GameViewportClient.NotifyConnectionError");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetProgressMessage;
    /// <summary>
    /// Function: SetProgressMessage
    /// </summary>
    public unsafe virtual void SetProgressMessage(BmSDK.Engine.PlayerController.EProgressMessageType MessageType, BmSDK.FString Message, BmSDK.FString Title = default, bool bIgnoreFutureNetworkMessages = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProgressMessage, "Engine.GameViewportClient.SetProgressMessage");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreFutureNetworkMessages, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveLocalPlayer;
    /// <summary>
    /// Function: RemoveLocalPlayer
    /// </summary>
    public unsafe int RemoveLocalPlayer(BmSDK.Engine.LocalPlayer ExistingPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveLocalPlayer, "Engine.GameViewportClient.RemoveLocalPlayer");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExistingPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddLocalPlayer;
    /// <summary>
    /// Function: AddLocalPlayer
    /// </summary>
    public unsafe int AddLocalPlayer(BmSDK.Engine.LocalPlayer NewPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLocalPlayer, "Engine.GameViewportClient.AddLocalPlayer");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_NotifyPlayerRemoved;
    /// <summary>
    /// Function: NotifyPlayerRemoved
    /// </summary>
    public unsafe virtual void NotifyPlayerRemoved(int PlayerIndex, BmSDK.Engine.LocalPlayer RemovedPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPlayerRemoved, "Engine.GameViewportClient.NotifyPlayerRemoved");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemovedPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPlayerAdded;
    /// <summary>
    /// Function: NotifyPlayerAdded
    /// </summary>
    public unsafe virtual void NotifyPlayerAdded(int PlayerIndex, BmSDK.Engine.LocalPlayer AddedPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPlayerAdded, "Engine.GameViewportClient.NotifyPlayerAdded");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddedPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawTransitionMessage;
    /// <summary>
    /// Function: DrawTransitionMessage
    /// </summary>
    public unsafe virtual void DrawTransitionMessage(BmSDK.Engine.Canvas Canvas, BmSDK.FString Message)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTransitionMessage, "Engine.GameViewportClient.DrawTransitionMessage");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawTransition;
    /// <summary>
    /// Function: DrawTransition
    /// </summary>
    public unsafe virtual void DrawTransition(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTransition, "Engine.GameViewportClient.DrawTransition");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayProgressMessage;
    /// <summary>
    /// Function: DisplayProgressMessage
    /// </summary>
    public unsafe virtual void DisplayProgressMessage(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayProgressMessage, "Engine.GameViewportClient.DisplayProgressMessage");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostRender;
    /// <summary>
    /// Function: PostRender
    /// </summary>
    public unsafe virtual void PostRender(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostRender, "Engine.GameViewportClient.PostRender");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawTitleSafeArea;
    /// <summary>
    /// Function: DrawTitleSafeArea
    /// </summary>
    public unsafe virtual void DrawTitleSafeArea(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTitleSafeArea, "Engine.GameViewportClient.DrawTitleSafeArea");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateDeadZoneForAllSides;
    /// <summary>
    /// Function: CalculateDeadZoneForAllSides
    /// </summary>
    public unsafe virtual bool CalculateDeadZoneForAllSides(BmSDK.Engine.LocalPlayer LPlayer, BmSDK.Engine.Canvas Canvas, out float fTopSafeZone, out float fBottomSafeZone, out float fLeftSafeZone, out float fRightSafeZone, bool bUseMaxPercent = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateDeadZoneForAllSides, "Engine.GameViewportClient.CalculateDeadZoneForAllSides");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out fTopSafeZone);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTopSafeZone, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out fBottomSafeZone);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fBottomSafeZone, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out fLeftSafeZone);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fLeftSafeZone, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out fRightSafeZone);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fRightSafeZone, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseMaxPercent, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        fTopSafeZone = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
        fBottomSafeZone = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
        fLeftSafeZone = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        fRightSafeZone = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_CalculateSafeZoneValues;
    /// <summary>
    /// Function: CalculateSafeZoneValues
    /// </summary>
    public unsafe virtual void CalculateSafeZoneValues(out float out_Horizontal, out float out_Vertical, BmSDK.Engine.Canvas Canvas, int LocalPlayerIndex, bool bUseMaxPercent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateSafeZoneValues, "Engine.GameViewportClient.CalculateSafeZoneValues");
        byte* paramsPtr = stackalloc byte[40];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Horizontal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Horizontal, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Vertical);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Vertical, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalPlayerIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseMaxPercent, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_Horizontal = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        out_Vertical = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetPixelSizeOfScreen;
    /// <summary>
    /// Function: GetPixelSizeOfScreen
    /// </summary>
    public unsafe virtual void GetPixelSizeOfScreen(out float out_Width, out float out_Height, BmSDK.Engine.Canvas Canvas, int LocalPlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPixelSizeOfScreen, "Engine.GameViewportClient.GetPixelSizeOfScreen");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Width);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Width, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Height);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Height, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalPlayerIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_Width = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        out_Height = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_HasRightSafeZone;
    /// <summary>
    /// Function: HasRightSafeZone
    /// </summary>
    public unsafe virtual bool HasRightSafeZone(int LocalPlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasRightSafeZone, "Engine.GameViewportClient.HasRightSafeZone");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalPlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasLeftSafeZone;
    /// <summary>
    /// Function: HasLeftSafeZone
    /// </summary>
    public unsafe virtual bool HasLeftSafeZone(int LocalPlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLeftSafeZone, "Engine.GameViewportClient.HasLeftSafeZone");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalPlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasBottomSafeZone;
    /// <summary>
    /// Function: HasBottomSafeZone
    /// </summary>
    public unsafe virtual bool HasBottomSafeZone(int LocalPlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBottomSafeZone, "Engine.GameViewportClient.HasBottomSafeZone");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalPlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasTopSafeZone;
    /// <summary>
    /// Function: HasTopSafeZone
    /// </summary>
    public unsafe virtual bool HasTopSafeZone(int LocalPlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasTopSafeZone, "Engine.GameViewportClient.HasTopSafeZone");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalPlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ConvertLocalPlayerToGamePlayerIndex;
    /// <summary>
    /// Function: ConvertLocalPlayerToGamePlayerIndex
    /// </summary>
    public unsafe virtual int ConvertLocalPlayerToGamePlayerIndex(BmSDK.Engine.LocalPlayer LPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConvertLocalPlayerToGamePlayerIndex, "Engine.GameViewportClient.ConvertLocalPlayerToGamePlayerIndex");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetSubtitleRegion;
    /// <summary>
    /// Function: GetSubtitleRegion
    /// </summary>
    public unsafe virtual void GetSubtitleRegion(out System.Numerics.Vector2 MinPos, out System.Numerics.Vector2 MaxPos)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSubtitleRegion, "Engine.GameViewportClient.GetSubtitleRegion");
        byte* paramsPtr = stackalloc byte[16];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MinPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinPos, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MaxPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MinPos = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(paramsPtr + 0);
        MaxPos = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_LayoutPlayers;
    /// <summary>
    /// Function: LayoutPlayers
    /// </summary>
    public unsafe virtual void LayoutPlayers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LayoutPlayers, "Engine.GameViewportClient.LayoutPlayers");
        byte* paramsPtr = stackalloc byte[6];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateActiveSplitscreenType;
    /// <summary>
    /// Function: UpdateActiveSplitscreenType
    /// </summary>
    public unsafe virtual void UpdateActiveSplitscreenType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateActiveSplitscreenType, "Engine.GameViewportClient.UpdateActiveSplitscreenType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSplitscreenConfiguration;
    /// <summary>
    /// Function: GetSplitscreenConfiguration
    /// </summary>
    public unsafe virtual BmSDK.Engine.GameViewportClient.ESplitScreenType GetSplitscreenConfiguration()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSplitscreenConfiguration, "Engine.GameViewportClient.GetSplitscreenConfiguration");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetSplitscreenConfiguration;
    /// <summary>
    /// Function: SetSplitscreenConfiguration
    /// </summary>
    public unsafe virtual void SetSplitscreenConfiguration(BmSDK.Engine.GameViewportClient.ESplitScreenType SplitType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSplitscreenConfiguration, "Engine.GameViewportClient.SetSplitscreenConfiguration");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SplitType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GameSessionEnded;
    /// <summary>
    /// Function: GameSessionEnded
    /// </summary>
    public unsafe virtual void GameSessionEnded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GameSessionEnded, "Engine.GameViewportClient.GameSessionEnded");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InsertInteraction;
    /// <summary>
    /// Function: InsertInteraction
    /// </summary>
    public unsafe virtual int InsertInteraction(BmSDK.Engine.Interaction NewInteraction, int InIndex = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InsertInteraction, "Engine.GameViewportClient.InsertInteraction");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInteraction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CreateInitialPlayer;
    /// <summary>
    /// Function: CreateInitialPlayer
    /// </summary>
    public unsafe virtual bool CreateInitialPlayer(out BmSDK.FString OutError)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateInitialPlayer, "Engine.GameViewportClient.CreateInitialPlayer");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutError = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual bool Init(out BmSDK.FString OutError)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "Engine.GameViewportClient.Init");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutError = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetConsoleTarget;
    /// <summary>
    /// Function: SetConsoleTarget
    /// </summary>
    public unsafe virtual void SetConsoleTarget(int PlayerIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetConsoleTarget, "Engine.GameViewportClient.SetConsoleTarget");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowTitleSafeArea;
    /// <summary>
    /// Function: ShowTitleSafeArea
    /// </summary>
    public unsafe virtual void ShowTitleSafeArea()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowTitleSafeArea, "Engine.GameViewportClient.ShowTitleSafeArea");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSplit;
    /// <summary>
    /// Function: SetSplit
    /// </summary>
    public unsafe virtual void SetSplit(int Mode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSplit, "Engine.GameViewportClient.SetSplit");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugRemovePlayer;
    /// <summary>
    /// Function: DebugRemovePlayer
    /// </summary>
    public unsafe virtual void DebugRemovePlayer(int ControllerId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugRemovePlayer, "Engine.GameViewportClient.DebugRemovePlayer");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SSSwapControllers;
    /// <summary>
    /// Function: SSSwapControllers
    /// </summary>
    public unsafe virtual void SSSwapControllers()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SSSwapControllers, "Engine.GameViewportClient.SSSwapControllers");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCreatePlayer;
    /// <summary>
    /// Function: DebugCreatePlayer
    /// </summary>
    public unsafe virtual void DebugCreatePlayer(int ControllerId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCreatePlayer, "Engine.GameViewportClient.DebugCreatePlayer");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindPlayerByControllerId;
    /// <summary>
    /// Function: FindPlayerByControllerId
    /// </summary>
    public unsafe virtual BmSDK.Engine.LocalPlayer FindPlayerByControllerId(int ControllerId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPlayerByControllerId, "Engine.GameViewportClient.FindPlayerByControllerId");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LocalPlayer>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RemovePlayer;
    /// <summary>
    /// Function: RemovePlayer
    /// </summary>
    public unsafe virtual bool RemovePlayer(BmSDK.Engine.LocalPlayer ExPlayer)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePlayer, "Engine.GameViewportClient.RemovePlayer");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreatePlayer;
    /// <summary>
    /// Function: CreatePlayer
    /// </summary>
    public unsafe virtual BmSDK.Engine.LocalPlayer CreatePlayer(int ControllerId, out BmSDK.FString OutError, bool bSpawnActor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePlayer, "Engine.GameViewportClient.CreatePlayer");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpawnActor, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutError = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LocalPlayer>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SetMouse;
    /// <summary>
    /// Function: SetMouse
    /// </summary>
    public unsafe virtual void SetMouse(int X, int Y)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMouse, "Engine.GameViewportClient.SetMouse");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ForceUpdateMouseCursor;
    /// <summary>
    /// Function: ForceUpdateMouseCursor
    /// </summary>
    public unsafe virtual void ForceUpdateMouseCursor(bool bSetCursor)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceUpdateMouseCursor, "Engine.GameViewportClient.ForceUpdateMouseCursor");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetCursor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_NotifySplitscreenLayoutChanged;
    /// <summary>
    /// Function: NotifySplitscreenLayoutChanged
    /// </summary>
    public unsafe virtual void NotifySplitscreenLayoutChanged()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifySplitscreenLayoutChanged, "Engine.GameViewportClient.NotifySplitscreenLayoutChanged");
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

    private static BmSDK.Function __fn_SetCustomInteractionObject;
    /// <summary>
    /// Function: SetCustomInteractionObject
    /// </summary>
    public unsafe virtual void SetCustomInteractionObject(BmSDK.Engine.Interaction InInteraction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomInteractionObject, "Engine.GameViewportClient.SetCustomInteractionObject");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInteraction, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetCustomInteractionClass;
    /// <summary>
    /// Function: GetCustomInteractionClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetCustomInteractionClass(int InIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomInteractionClass, "Engine.GameViewportClient.GetCustomInteractionClass");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumCustomInteractions;
    /// <summary>
    /// Function: GetNumCustomInteractions
    /// </summary>
    public unsafe virtual int GetNumCustomInteractions()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCustomInteractions, "Engine.GameViewportClient.GetNumCustomInteractions");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldForceFullscreenViewport;
    /// <summary>
    /// Function: ShouldForceFullscreenViewport
    /// </summary>
    public unsafe virtual bool ShouldForceFullscreenViewport()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceFullscreenViewport, "Engine.GameViewportClient.ShouldForceFullscreenViewport");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMousePosition;
    /// <summary>
    /// Function: GetMousePosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector2 GetMousePosition()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMousePosition, "Engine.GameViewportClient.GetMousePosition");
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Is4x3;
    /// <summary>
    /// Function: Is4x3
    /// </summary>
    public unsafe virtual bool Is4x3()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Is4x3, "Engine.GameViewportClient.Is4x3");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Is16x9;
    /// <summary>
    /// Function: Is16x9
    /// </summary>
    public unsafe virtual bool Is16x9()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Is16x9, "Engine.GameViewportClient.Is16x9");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFullScreenViewport;
    /// <summary>
    /// Function: IsFullScreenViewport
    /// </summary>
    public unsafe virtual bool IsFullScreenViewport()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFullScreenViewport, "Engine.GameViewportClient.IsFullScreenViewport");
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCenterMonitorSize;
    /// <summary>
    /// Function: GetCenterMonitorSize
    /// </summary>
    public unsafe virtual void GetCenterMonitorSize(out System.Numerics.Vector2 out_ViewportSize)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCenterMonitorSize, "Engine.GameViewportClient.GetCenterMonitorSize");
        byte* paramsPtr = stackalloc byte[8];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_ViewportSize);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_ViewportSize, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ViewportSize = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetViewportSize;
    /// <summary>
    /// Function: GetViewportSize
    /// </summary>
    public unsafe virtual void GetViewportSize(out System.Numerics.Vector2 out_ViewportSize)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetViewportSize, "Engine.GameViewportClient.GetViewportSize");
        byte* paramsPtr = stackalloc byte[8];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_ViewportSize);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_ViewportSize, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ViewportSize = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ConsoleCommand;
    /// <summary>
    /// Function: ConsoleCommand
    /// </summary>
    public unsafe virtual BmSDK.FString ConsoleCommand(BmSDK.FString Command)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConsoleCommand, "Engine.GameViewportClient.ConsoleCommand");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Command, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HandleInputChar;
    /// <summary>
    /// Function: HandleInputChar
    /// </summary>
    public unsafe virtual bool HandleInputChar(int ControllerId, BmSDK.FString Unicode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleInputChar, "Engine.GameViewportClient.HandleInputChar");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Unicode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_HandleInputAxis;
    /// <summary>
    /// Function: HandleInputAxis
    /// </summary>
    public unsafe virtual bool HandleInputAxis(int ControllerId, BmSDK.FName Key, float Delta, float DeltaTime, bool bGamepad)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleInputAxis, "Engine.GameViewportClient.HandleInputAxis");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGamepad, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_HandleInputKey;
    /// <summary>
    /// Function: HandleInputKey
    /// </summary>
    public unsafe virtual bool HandleInputKey(int ControllerId, BmSDK.FName Key, BmSDK.GameObject.EInputEvent EventType, float AmountDepressed, bool bGamepad = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleInputKey, "Engine.GameViewportClient.HandleInputKey");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmountDepressed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGamepad, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Struct: FDebugDisplayProperty
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FDebugDisplayProperty
    {
        /// <summary>
        /// ObjectProperty: Obj
        /// </summary>
        public unsafe BmSDK.GameObject Obj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: PropertyName
        /// </summary>
        public unsafe BmSDK.FName PropertyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bSpecialProperty
        /// </summary>
        public unsafe bool bSpecialProperty
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bCountArray
        /// </summary>
        public unsafe bool bCountArray
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bCountObjInstances
        /// </summary>
        public unsafe bool bCountObjInstances
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FSplitscreenData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSplitscreenData
    {
        /// <summary>
        /// ArrayProperty: PlayerData
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.GameViewportClient.FPerPlayerSplitscreenData> PlayerData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameViewportClient.FPerPlayerSplitscreenData>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FPerPlayerSplitscreenData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FPerPlayerSplitscreenData
    {
        /// <summary>
        /// FloatProperty: SizeX
        /// </summary>
        public unsafe float SizeX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: SizeY
        /// </summary>
        public unsafe float SizeY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: OriginX
        /// </summary>
        public unsafe float OriginX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: OriginY
        /// </summary>
        public unsafe float OriginY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: ESetMode
    /// </summary>
    public enum ESetMode : byte
    {
        SetMode_Toggle = 0,
        SetMode_Enable = 1,
        SetMode_Disable = 2,
        SetMode_MAX = 3,
    }

    /// <summary>
    /// Enum: ESafeZoneType
    /// </summary>
    public enum ESafeZoneType : byte
    {
        eSZ_TOP = 0,
        eSZ_BOTTOM = 1,
        eSZ_LEFT = 2,
        eSZ_RIGHT = 3,
        eSZ_MAX = 4,
    }

    /// <summary>
    /// Enum: ESplitScreenType
    /// </summary>
    public enum ESplitScreenType : byte
    {
        eSST_NONE = 0,
        eSST_2P_HORIZONTAL = 1,
        eSST_2P_VERTICAL = 2,
        eSST_3P_FAVOR_TOP = 3,
        eSST_3P_FAVOR_BOTTOM = 4,
        eSST_4P = 5,
        eSST_MAX = 6,
    }

    /// <summary>
    /// Struct: FTitleSafeZoneArea
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FTitleSafeZoneArea
    {
        /// <summary>
        /// FloatProperty: MaxPercentX
        /// </summary>
        public unsafe float MaxPercentX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxPercentY
        /// </summary>
        public unsafe float MaxPercentY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: XbMaxPercentX
        /// </summary>
        public unsafe float XbMaxPercentX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: XbMaxPercentY
        /// </summary>
        public unsafe float XbMaxPercentY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: RecommendedPercentX
        /// </summary>
        public unsafe float RecommendedPercentX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: RecommendedPercentY
        /// </summary>
        public unsafe float RecommendedPercentY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FExportShowFlags_Mirror
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FExportShowFlags_Mirror
    {
    }

    /// <summary>
    /// Struct: FShowFlags_Mirror
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FShowFlags_Mirror
    {
        /// <summary>
        /// StructProperty: flags0
        /// </summary>
        public unsafe ulong flags0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: flags1
        /// </summary>
        public unsafe ulong flags1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// StructProperty: VfTable_FExec
    /// </summary>
    public unsafe System.IntPtr VfTable_FExec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: Viewport
    /// </summary>
    public unsafe System.IntPtr Viewport
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: ViewportFrame
    /// </summary>
    public unsafe System.IntPtr ViewportFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: GlobalInteractions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Interaction> GlobalInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Interaction>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ClassProperty: UIControllerClass
    /// </summary>
    public unsafe BmSDK.Class UIControllerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: UIController
    /// </summary>
    public unsafe BmSDK.Engine.UIInteraction UIController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIInteraction>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: ViewportConsole
    /// </summary>
    public unsafe BmSDK.Engine._Console ViewportConsole
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine._Console>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: CanvasObject
    /// </summary>
    public unsafe BmSDK.Engine.Canvas CanvasObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Canvas>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// StructProperty: ShowFlags
    /// </summary>
    public unsafe ref BmSDK.Engine.GameViewportClient.FExportShowFlags_Mirror ShowFlags
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.GameViewportClient.FExportShowFlags_Mirror>(Ptr + 164);

    /// <summary>
    /// StructProperty: RockShowFlags
    /// </summary>
    public unsafe ulong RockShowFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ByteProperty: ShowCollisionFilter
    /// </summary>
    public unsafe byte ShowCollisionFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ByteProperty: DesiredSplitscreenType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType DesiredSplitscreenType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 189); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 189); }
    }

    /// <summary>
    /// ByteProperty: ActiveSplitscreenType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType ActiveSplitscreenType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 190); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 190); }
    }

    /// <summary>
    /// ByteProperty: Default2PSplitType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType Default2PSplitType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 191); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 191); }
    }

    /// <summary>
    /// ByteProperty: Default3PSplitType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType Default3PSplitType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StrProperty: LoadingMessage
    /// </summary>
    public unsafe BmSDK.FString LoadingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StrProperty: SavingMessage
    /// </summary>
    public unsafe BmSDK.FString SavingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StrProperty: ConnectingMessage
    /// </summary>
    public unsafe BmSDK.FString ConnectingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// StrProperty: PausedMessage
    /// </summary>
    public unsafe BmSDK.FString PausedMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StrProperty: PrecachingMessage
    /// </summary>
    public unsafe BmSDK.FString PrecachingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bShowTitleSafeZone
    /// </summary>
    public unsafe bool bShowTitleSafeZone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bDisplayHardwareMouseCursor
    /// </summary>
    public unsafe bool bDisplayHardwareMouseCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDiffuseAndSpecular
    /// </summary>
    public unsafe bool bOverrideDiffuseAndSpecular
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bIsPlayInEditorViewport
    /// </summary>
    public unsafe bool bIsPlayInEditorViewport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bShowSystemMouseCursor
    /// </summary>
    public unsafe bool bShowSystemMouseCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bCollisionLight
    /// </summary>
    public unsafe bool bCollisionLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bDisableWorldRendering
    /// </summary>
    public unsafe bool bDisableWorldRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bDebugNoGFxUI
    /// </summary>
    public unsafe bool bDebugNoGFxUI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: TitleSafeZone
    /// </summary>
    public unsafe ref BmSDK.Engine.GameViewportClient.FTitleSafeZoneArea TitleSafeZone
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.GameViewportClient.FTitleSafeZoneArea>(Ptr + 280);

    /// <summary>
    /// IntProperty: ReflectionVolumeMode
    /// </summary>
    public unsafe int ReflectionVolumeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StructProperty: CollisionLightSavedShowFlags
    /// </summary>
    public unsafe ref BmSDK.Engine.GameViewportClient.FExportShowFlags_Mirror CollisionLightSavedShowFlags
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.GameViewportClient.FExportShowFlags_Mirror>(Ptr + 308);

    /// <summary>
    /// ArrayProperty: SplitscreenInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameViewportClient.FSplitscreenData> SplitscreenInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameViewportClient.FSplitscreenData>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: ProgressMessage
    /// </summary>
    public InlineArray<BmSDK.FString> ProgressMessage => new(2, Ptr + 340, 16, this);

    /// <summary>
    /// StrProperty: ProgressMessage
    /// </summary>
    public unsafe BmSDK.FString ProgressMessage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }
    /// <summary>
    /// StrProperty: ProgressMessage
    /// </summary>
    public unsafe BmSDK.FString ProgressMessage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: ProgressTimeOut
    /// </summary>
    public unsafe float ProgressTimeOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// FloatProperty: ProgressFadeTime
    /// </summary>
    public unsafe float ProgressFadeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ArrayProperty: DebugProperties
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameViewportClient.FDebugDisplayProperty> DebugProperties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameViewportClient.FDebugDisplayProperty>>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// StructProperty: ScaleformInteraction
    /// </summary>
    public unsafe System.IntPtr ScaleformInteraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// StructProperty: ViewFamily
    /// </summary>
    public unsafe System.IntPtr ViewFamily
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// DelegateProperty: __HandleInputKey__Delegate
    /// </summary>
    public unsafe System.IntPtr __HandleInputKey__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// DelegateProperty: __HandleInputAxis__Delegate
    /// </summary>
    public unsafe System.IntPtr __HandleInputAxis__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// DelegateProperty: __HandleInputChar__Delegate
    /// </summary>
    public unsafe System.IntPtr __HandleInputChar__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
}
