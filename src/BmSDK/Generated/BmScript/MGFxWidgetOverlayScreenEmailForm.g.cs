#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxWidgetOverlayScreenEmailForm<br/>
/// (size = 352)
/// (flags = 18)
/// </summary>
public partial class MGFxWidgetOverlayScreenEmailForm : BmSDK.BmScript.MGFxWidgetOverlayScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxWidgetOverlayScreenEmailForm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxWidgetOverlayScreenEmailForm.
    /// </summary>
    public static MGFxWidgetOverlayScreenEmailForm DefaultObject => (MGFxWidgetOverlayScreenEmailForm)StaticClass().DefaultObject;

    internal MGFxWidgetOverlayScreenEmailForm() { }

    /// <summary>
    /// Constructs a new MGFxWidgetOverlayScreenEmailForm
    /// </summary>
    public MGFxWidgetOverlayScreenEmailForm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetOverlayScreenEmailForm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetOverlayScreenEmailForm(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenEmailForm>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenEmailForm>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenEmailForm>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenEmailForm>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenEmailForm>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenEmailForm>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenEmailForm>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetOverlayScreenEmailForm>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ThreadSafeInvalidate;
    /// <summary>
    /// Function: ThreadSafeInvalidate
    /// </summary>
    public unsafe override void ThreadSafeInvalidate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThreadSafeInvalidate, "BmScript.MGFxWidgetOverlayScreenEmailForm.ThreadSafeInvalidate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBladeKeyboardFinished;
    /// <summary>
    /// Function: OnBladeKeyboardFinished
    /// </summary>
    public unsafe virtual void OnBladeKeyboardFinished(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBladeKeyboardFinished, "BmScript.MGFxWidgetOverlayScreenEmailForm.OnBladeKeyboardFinished");
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSystemBlade;
    /// <summary>
    /// Function: ShowSystemBlade
    /// </summary>
    public unsafe virtual void ShowSystemBlade()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSystemBlade, "BmScript.MGFxWidgetOverlayScreenEmailForm.ShowSystemBlade");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseAgeDropDown;
    /// <summary>
    /// Function: CloseAgeDropDown
    /// </summary>
    public unsafe virtual void CloseAgeDropDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseAgeDropDown, "BmScript.MGFxWidgetOverlayScreenEmailForm.CloseAgeDropDown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenAgeDropDown;
    /// <summary>
    /// Function: OpenAgeDropDown
    /// </summary>
    public unsafe virtual void OpenAgeDropDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenAgeDropDown, "BmScript.MGFxWidgetOverlayScreenEmailForm.OpenAgeDropDown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushAgeDropDownData;
    /// <summary>
    /// Function: PushAgeDropDownData
    /// </summary>
    public unsafe virtual void PushAgeDropDownData(BmSDK.TArray<int> ages)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushAgeDropDownData, "BmScript.MGFxWidgetOverlayScreenEmailForm.PushAgeDropDownData");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ages, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHidePassword;
    /// <summary>
    /// Function: SetHidePassword
    /// </summary>
    public unsafe virtual void SetHidePassword(bool checkVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHidePassword, "BmScript.MGFxWidgetOverlayScreenEmailForm.SetHidePassword");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(checkVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetReceiveEmails;
    /// <summary>
    /// Function: SetReceiveEmails
    /// </summary>
    public unsafe virtual void SetReceiveEmails(bool checkVal)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetReceiveEmails, "BmScript.MGFxWidgetOverlayScreenEmailForm.SetReceiveEmails");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(checkVal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFormData;
    /// <summary>
    /// Function: GetFormData
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.FString> GetFormData()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFormData, "BmScript.MGFxWidgetOverlayScreenEmailForm.GetFormData");
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SendData;
    /// <summary>
    /// Function: SendData
    /// </summary>
    public unsafe override void SendData()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendData, "BmScript.MGFxWidgetOverlayScreenEmailForm.SendData");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearFormErrors;
    /// <summary>
    /// Function: ClearFormErrors
    /// </summary>
    public unsafe virtual void ClearFormErrors()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFormErrors, "BmScript.MGFxWidgetOverlayScreenEmailForm.ClearFormErrors");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushFormErrors;
    /// <summary>
    /// Function: PushFormErrors
    /// </summary>
    public unsafe virtual void PushFormErrors(BmSDK.TArray<BmSDK.FString> Errors)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushFormErrors, "BmScript.MGFxWidgetOverlayScreenEmailForm.PushFormErrors");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Errors, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickVerify;
    /// <summary>
    /// Function: QuickVerify
    /// </summary>
    public unsafe virtual bool QuickVerify(BmSDK.TArray<BmSDK.FString> Data, out BmSDK.BmGame.MWBIDEmailFormScreenMessage Message, bool bOnlyEmail = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickVerify, "BmScript.MGFxWidgetOverlayScreenEmailForm.QuickVerify");
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Message);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEmail, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Message = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MWBIDEmailFormScreenMessage>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ScrollList;
    /// <summary>
    /// Function: ScrollList
    /// </summary>
    public unsafe virtual void ScrollList(bool bIsDown)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScrollList, "BmScript.MGFxWidgetOverlayScreenEmailForm.ScrollList");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsDown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavDown;
    /// <summary>
    /// Function: NavDown
    /// </summary>
    public unsafe override void NavDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavDown, "BmScript.MGFxWidgetOverlayScreenEmailForm.NavDown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavUp;
    /// <summary>
    /// Function: NavUp
    /// </summary>
    public unsafe override void NavUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavUp, "BmScript.MGFxWidgetOverlayScreenEmailForm.NavUp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavRight;
    /// <summary>
    /// Function: NavRight
    /// </summary>
    public unsafe override void NavRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavRight, "BmScript.MGFxWidgetOverlayScreenEmailForm.NavRight");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavLeft;
    /// <summary>
    /// Function: NavLeft
    /// </summary>
    public unsafe override void NavLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavLeft, "BmScript.MGFxWidgetOverlayScreenEmailForm.NavLeft");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMouseWheel;
    /// <summary>
    /// Function: OnMouseWheel
    /// </summary>
    public unsafe override void OnMouseWheel(int btnIdx, bool directionUp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMouseWheel, "BmScript.MGFxWidgetOverlayScreenEmailForm.OnMouseWheel");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(btnIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(directionUp, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMouseDown;
    /// <summary>
    /// Function: OnMouseDown
    /// </summary>
    public unsafe override void OnMouseDown(int btnIdx)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMouseDown, "BmScript.MGFxWidgetOverlayScreenEmailForm.OnMouseDown");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(btnIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressTab;
    /// <summary>
    /// Function: OnPressTab
    /// </summary>
    public unsafe override void OnPressTab()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressTab, "BmScript.MGFxWidgetOverlayScreenEmailForm.OnPressTab");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressB;
    /// <summary>
    /// Function: OnPressB
    /// </summary>
    public unsafe override void OnPressB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressB, "BmScript.MGFxWidgetOverlayScreenEmailForm.OnPressB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressA;
    /// <summary>
    /// Function: OnPressA
    /// </summary>
    public unsafe override void OnPressA()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressA, "BmScript.MGFxWidgetOverlayScreenEmailForm.OnPressA");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnKeyUp;
    /// <summary>
    /// Function: OnKeyUp
    /// </summary>
    public unsafe override void OnKeyUp(int Key)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnKeyUp, "BmScript.MGFxWidgetOverlayScreenEmailForm.OnKeyUp");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFocussed;
    /// <summary>
    /// Function: SetFocussed
    /// </summary>
    public unsafe virtual void SetFocussed(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFocussed, "BmScript.MGFxWidgetOverlayScreenEmailForm.SetFocussed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetButtonID;
    /// <summary>
    /// Function: SetButtonID
    /// </summary>
    public unsafe virtual void SetButtonID(int Id)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetButtonID, "BmScript.MGFxWidgetOverlayScreenEmailForm.SetButtonID");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetButtonLabel;
    /// <summary>
    /// Function: SetButtonLabel
    /// </summary>
    public unsafe virtual void SetButtonLabel(int Id, BmSDK.FString Label)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetButtonLabel, "BmScript.MGFxWidgetOverlayScreenEmailForm.SetButtonLabel");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupTextBox;
    /// <summary>
    /// Function: SetupTextBox
    /// </summary>
    public unsafe virtual void SetupTextBox(int Id, BmSDK.FString Text, bool isPassword)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupTextBox, "BmScript.MGFxWidgetOverlayScreenEmailForm.SetupTextBox");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isPassword, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTitle;
    /// <summary>
    /// Function: SetTitle
    /// </summary>
    public unsafe virtual void SetTitle(BmSDK.FString Title)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTitle, "BmScript.MGFxWidgetOverlayScreenEmailForm.SetTitle");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WidgetInitialized;
    /// <summary>
    /// Function: WidgetInitialized
    /// </summary>
    public unsafe override bool WidgetInitialized(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmScript.MGFxWidgetOverlayScreenEmailForm.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.MGFxWidgetOverlayScreenEmailForm.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// InterfaceProperty: PlayerInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerInterface PlayerInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerInterface>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ArrayProperty: ButtonGroup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> ButtonGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ArrayProperty: ErrorHighlights
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> ErrorHighlights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: Cache_TextFields
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> Cache_TextFields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: SelectedButton
    /// </summary>
    public unsafe int SelectedButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// StrProperty: CurrentAge
    /// </summary>
    public unsafe BmSDK.FString CurrentAge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// ObjectProperty: TitleLabel
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject TitleLabel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ObjectProperty: EmailForm
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject EmailForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// BoolProperty: bShouldReceiveEmails
    /// </summary>
    public unsafe bool bShouldReceiveEmails
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bHidePassword
    /// </summary>
    public unsafe bool bHidePassword
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bIsCreate
    /// </summary>
    public unsafe bool bIsCreate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bIsDropDownCollapsed
    /// </summary>
    public unsafe bool bIsDropDownCollapsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bIsConsoleKeyboardOpen
    /// </summary>
    public unsafe bool bIsConsoleKeyboardOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// StrProperty: BladeKeyboardResult
    /// </summary>
    public unsafe BmSDK.FString BladeKeyboardResult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// IntProperty: MIN_AGE
    /// </summary>
    public unsafe int MIN_AGE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: MAX_AGE
    /// </summary>
    public unsafe int MAX_AGE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: MIN_PASSWORD_LEN
    /// </summary>
    public unsafe int MIN_PASSWORD_LEN
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: MAX_PASSWORD_LEN
    /// </summary>
    public unsafe int MAX_PASSWORD_LEN
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: AGE_DROPDOWN_SLOTS
    /// </summary>
    public unsafe int AGE_DROPDOWN_SLOTS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// DelegateProperty: __OnBladeKeyboardFinished__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnBladeKeyboardFinished__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
}
