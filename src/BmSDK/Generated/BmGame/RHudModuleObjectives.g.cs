#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleObjectives<br/>
/// (size = 256)
/// (flags = 18)
/// </summary>
public partial class RHudModuleObjectives : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleObjectives", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudModuleObjectives.
    /// </summary>
    public static RHudModuleObjectives DefaultObject => (RHudModuleObjectives)StaticClass().DefaultObject;

    internal RHudModuleObjectives() { }

    /// <summary>
    /// Constructs a new RHudModuleObjectives
    /// </summary>
    public RHudModuleObjectives(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleObjectives Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleObjectives(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudModuleObjectives>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_XI_ObjectiveBarFilled;
    /// <summary>
    /// Function: XI_ObjectiveBarFilled
    /// </summary>
    public unsafe virtual void XI_ObjectiveBarFilled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ObjectiveBarFilled, "BmGame.RHudModuleObjectives.XI_ObjectiveBarFilled");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_ObjectiveItemShown;
    /// <summary>
    /// Function: XI_ObjectiveItemShown
    /// </summary>
    public unsafe virtual void XI_ObjectiveItemShown(int arrow_type, BmSDK.FString CustomIconString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_ObjectiveItemShown, "BmGame.RHudModuleObjectives.XI_ObjectiveItemShown");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(arrow_type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIconString, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlushObjectivePrivate;
    /// <summary>
    /// Function: FlushObjectivePrivate
    /// </summary>
    public unsafe virtual void FlushObjectivePrivate(BmSDK.FString Title)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushObjectivePrivate, "BmGame.RHudModuleObjectives.FlushObjectivePrivate");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddObjectivePrivate;
    /// <summary>
    /// Function: AddObjectivePrivate
    /// </summary>
    public unsafe virtual void AddObjectivePrivate(float Time, BmSDK.FString Title, BmSDK.FString Desc, BmSDK.FString OrgDesc, int ArrowType, bool bForceShowMap, BmSDK.FString BackPrompt, bool bNoDuplicates, bool bPulseCompassIndicatorm, BmSDK.FString mostWantedUnlocksString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddObjectivePrivate, "BmGame.RHudModuleObjectives.AddObjectivePrivate");
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desc, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrgDesc, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrowType, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceShowMap, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BackPrompt, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoDuplicates, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPulseCompassIndicatorm, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mostWantedUnlocksString, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectivesPromptCallback;
    /// <summary>
    /// Function: ObjectivesPromptCallback
    /// </summary>
    public unsafe virtual void ObjectivesPromptCallback(BmSDK.FString PadStr, BmSDK.FString KeyStr)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectivesPromptCallback, "BmGame.RHudModuleObjectives.ObjectivesPromptCallback");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PadStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyStr, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendQueuedInfo;
    /// <summary>
    /// Function: SendQueuedInfo
    /// </summary>
    public unsafe virtual void SendQueuedInfo()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendQueuedInfo, "BmGame.RHudModuleObjectives.SendQueuedInfo");
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudModuleObjectives.Close");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudModuleObjectives.Init");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// ArrayProperty: ObjectiveItemAppearanceEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> ObjectiveItemAppearanceEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
}
