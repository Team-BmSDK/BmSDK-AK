#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDataProvider_OnlineProfileSettings<br/>
/// (size = 152)
/// (flags = 134217886)
/// </summary>
public partial class UIDataProvider_OnlineProfileSettings : BmSDK.Engine.UIDataProvider_OnlinePlayerStorage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataProvider_OnlineProfileSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as UIDataProvider_OnlineProfileSettings.
    /// </summary>
    public static UIDataProvider_OnlineProfileSettings DefaultObject => (UIDataProvider_OnlineProfileSettings)StaticClass().DefaultObject;

    internal UIDataProvider_OnlineProfileSettings() { }

    /// <summary>
    /// Constructs a new UIDataProvider_OnlineProfileSettings
    /// </summary>
    public UIDataProvider_OnlineProfileSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDataProvider_OnlineProfileSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataProvider_OnlineProfileSettings(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnStorageDeviceChange;
    /// <summary>
    /// Function: OnStorageDeviceChange
    /// </summary>
    public unsafe override void OnStorageDeviceChange()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStorageDeviceChange, "Engine.UIDataProvider_OnlineProfileSettings.OnStorageDeviceChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshStorageData;
    /// <summary>
    /// Function: RefreshStorageData
    /// </summary>
    public unsafe override void RefreshStorageData()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshStorageData, "Engine.UIDataProvider_OnlineProfileSettings.RefreshStorageData");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearReadCompleteDelegate;
    /// <summary>
    /// Function: ClearReadCompleteDelegate
    /// </summary>
    public unsafe override void ClearReadCompleteDelegate(BmSDK.Engine.OnlinePlayerInterface PlayerInterface, byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadCompleteDelegate, "Engine.UIDataProvider_OnlineProfileSettings.ClearReadCompleteDelegate");
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInterface, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadCompleteDelegate;
    /// <summary>
    /// Function: AddReadCompleteDelegate
    /// </summary>
    public unsafe override void AddReadCompleteDelegate(BmSDK.Engine.OnlinePlayerInterface PlayerInterface, byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadCompleteDelegate, "Engine.UIDataProvider_OnlineProfileSettings.AddReadCompleteDelegate");
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInterface, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetData;
    /// <summary>
    /// Function: GetData
    /// </summary>
    public unsafe override bool GetData(BmSDK.Engine.OnlinePlayerInterface PlayerInterface, byte LocalUserNum)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetData, "Engine.UIDataProvider_OnlineProfileSettings.GetData");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInterface, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_WriteData;
    /// <summary>
    /// Function: WriteData
    /// </summary>
    public unsafe override bool WriteData(BmSDK.Engine.OnlinePlayerInterface PlayerInterface, byte LocalUserNum, int DeviceID, BmSDK.Engine.OnlinePlayerStorage PlayerStorage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteData, "Engine.UIDataProvider_OnlineProfileSettings.WriteData");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInterface, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ReadData;
    /// <summary>
    /// Function: ReadData
    /// </summary>
    public unsafe override bool ReadData(BmSDK.Engine.OnlinePlayerInterface PlayerInterface, byte LocalUserNum, int DeviceID, BmSDK.Engine.OnlinePlayerStorage PlayerStorage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadData, "Engine.UIDataProvider_OnlineProfileSettings.ReadData");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInterface, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }
}
