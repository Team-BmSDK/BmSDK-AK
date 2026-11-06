#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDynamicMenu<br/>
/// (size = 960)
/// (flags = 144703634)
/// </summary>
public partial class RDynamicMenu : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDynamicMenu", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RDynamicMenu.
    /// </summary>
    public static RDynamicMenu DefaultObject => (RDynamicMenu)StaticClass().DefaultObject;

    internal RDynamicMenu() { }

    /// <summary>
    /// Constructs a new RDynamicMenu
    /// </summary>
    public RDynamicMenu(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDynamicMenu(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDynamicMenu>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDynamicMenu>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDynamicMenu>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDynamicMenu>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDynamicMenu>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDynamicMenu>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDynamicMenu>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDynamicMenu>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_RenderItem;
    /// <summary>
    /// Function: RenderItem
    /// </summary>
    public unsafe virtual void RenderItem(BmSDK.FString Label, BmSDK.FString Item)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RenderItem, "BmGame.RDynamicMenu.RenderItem");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RenderCustomItem;
    /// <summary>
    /// Function: RenderCustomItem
    /// </summary>
    public unsafe virtual void RenderCustomItem(BmSDK.FString Label, BmSDK.FString Item, byte R, byte G, byte B)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RenderCustomItem, "BmGame.RDynamicMenu.RenderCustomItem");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 33);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 34);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldRenderItem;
    /// <summary>
    /// Function: ShouldRenderItem
    /// </summary>
    public unsafe virtual bool ShouldRenderItem(BmSDK.FString Label, bool readOnly = default, bool labelOnly = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldRenderItem, "BmGame.RDynamicMenu.ShouldRenderItem");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(readOnly, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(labelOnly, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ReadPad;
    /// <summary>
    /// Function: ReadPad
    /// </summary>
    public unsafe void ReadPad(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadPad, "BmGame.RDynamicMenu.ReadPad");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPageFormatting;
    /// <summary>
    /// Function: ResetPageFormatting
    /// </summary>
    public unsafe void ResetPageFormatting()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPageFormatting, "BmGame.RDynamicMenu.ResetPageFormatting");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoMenu;
    /// <summary>
    /// Function: DoMenu
    /// </summary>
    public unsafe virtual bool DoMenu(BmSDK.Engine.Canvas C, float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoMenu, "BmGame.RDynamicMenu.DoMenu");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DoMenuInternal;
    /// <summary>
    /// Function: DoMenuInternal
    /// </summary>
    public unsafe virtual bool DoMenuInternal(BmSDK.Engine.Canvas C)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoMenuInternal, "BmGame.RDynamicMenu.DoMenuInternal");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PressedNumber;
    /// <summary>
    /// Function: PressedNumber
    /// </summary>
    public unsafe virtual void PressedNumber(int Num)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PressedNumber, "BmGame.RDynamicMenu.PressedNumber");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Num, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PressedStepDown;
    /// <summary>
    /// Function: PressedStepDown
    /// </summary>
    public unsafe virtual void PressedStepDown()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PressedStepDown, "BmGame.RDynamicMenu.PressedStepDown");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PressedStepUp;
    /// <summary>
    /// Function: PressedStepUp
    /// </summary>
    public unsafe virtual void PressedStepUp()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PressedStepUp, "BmGame.RDynamicMenu.PressedStepUp");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleasedInput;
    /// <summary>
    /// Function: ReleasedInput
    /// </summary>
    public unsafe virtual void ReleasedInput(int Input)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleasedInput, "BmGame.RDynamicMenu.ReleasedInput");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Input, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PressedInput;
    /// <summary>
    /// Function: PressedInput
    /// </summary>
    public unsafe virtual void PressedInput(int Input)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PressedInput, "BmGame.RDynamicMenu.PressedInput");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Input, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectCurrentItemY;
    /// <summary>
    /// Function: SelectCurrentItemY
    /// </summary>
    public unsafe virtual void SelectCurrentItemY()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectCurrentItemY, "BmGame.RDynamicMenu.SelectCurrentItemY");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectCurrentItemX;
    /// <summary>
    /// Function: SelectCurrentItemX
    /// </summary>
    public unsafe virtual void SelectCurrentItemX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectCurrentItemX, "BmGame.RDynamicMenu.SelectCurrentItemX");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectCurrentItemB;
    /// <summary>
    /// Function: SelectCurrentItemB
    /// </summary>
    public unsafe virtual void SelectCurrentItemB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectCurrentItemB, "BmGame.RDynamicMenu.SelectCurrentItemB");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectCurrentItemA;
    /// <summary>
    /// Function: SelectCurrentItemA
    /// </summary>
    public unsafe virtual void SelectCurrentItemA()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectCurrentItemA, "BmGame.RDynamicMenu.SelectCurrentItemA");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoToNextPage;
    /// <summary>
    /// Function: GoToNextPage
    /// </summary>
    public unsafe virtual void GoToNextPage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoToNextPage, "BmGame.RDynamicMenu.GoToNextPage");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoToPrevPage;
    /// <summary>
    /// Function: GoToPrevPage
    /// </summary>
    public unsafe virtual void GoToPrevPage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoToPrevPage, "BmGame.RDynamicMenu.GoToPrevPage");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDisplayed;
    /// <summary>
    /// Function: SetDisplayed
    /// </summary>
    public unsafe virtual void SetDisplayed(bool On)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDisplayed, "BmGame.RDynamicMenu.SetDisplayed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPage;
    /// <summary>
    /// Function: SetPage
    /// </summary>
    public unsafe virtual void SetPage(BmSDK.FString PageTitle)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPage, "BmGame.RDynamicMenu.SetPage");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PageTitle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldPauseGame;
    /// <summary>
    /// Function: ShouldPauseGame
    /// </summary>
    public unsafe virtual bool ShouldPauseGame()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPauseGame, "BmGame.RDynamicMenu.ShouldPauseGame");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PageSetNumberShortcut;
    /// <summary>
    /// Function: PageSetNumberShortcut
    /// </summary>
    public unsafe virtual void PageSetNumberShortcut(int Num, int Page = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PageSetNumberShortcut, "BmGame.RDynamicMenu.PageSetNumberShortcut");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Num, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Page, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemSetNumberShortcut;
    /// <summary>
    /// Function: ItemSetNumberShortcut
    /// </summary>
    public unsafe virtual void ItemSetNumberShortcut(int Num)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemSetNumberShortcut, "BmGame.RDynamicMenu.ItemSetNumberShortcut");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Num, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemGap;
    /// <summary>
    /// Function: ItemGap
    /// </summary>
    public unsafe virtual void ItemGap()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemGap, "BmGame.RDynamicMenu.ItemGap");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemFRO;
    /// <summary>
    /// Function: ItemFRO
    /// </summary>
    public unsafe virtual void ItemFRO(BmSDK.FString Label, float Value, byte R = default, byte G = default, byte B = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemFRO, "BmGame.RDynamicMenu.ItemFRO");
        byte* paramsPtr = stackalloc byte[23];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 21);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 22);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemIRO;
    /// <summary>
    /// Function: ItemIRO
    /// </summary>
    public unsafe virtual void ItemIRO(BmSDK.FString Label, int Value, byte R = default, byte G = default, byte B = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemIRO, "BmGame.RDynamicMenu.ItemIRO");
        byte* paramsPtr = stackalloc byte[23];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 21);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 22);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemBRO;
    /// <summary>
    /// Function: ItemBRO
    /// </summary>
    public unsafe virtual void ItemBRO(BmSDK.FString Label, bool Value, byte R = default, byte G = default, byte B = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemBRO, "BmGame.RDynamicMenu.ItemBRO");
        byte* paramsPtr = stackalloc byte[23];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 21);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 22);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemRO;
    /// <summary>
    /// Function: ItemRO
    /// </summary>
    public unsafe virtual void ItemRO(BmSDK.FString Label, byte R = default, byte G = default, byte B = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemRO, "BmGame.RDynamicMenu.ItemRO");
        byte* paramsPtr = stackalloc byte[19];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 17);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 18);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RItemCol;
    /// <summary>
    /// Function: RItemCol
    /// </summary>
    public unsafe virtual BmSDK.GameObject.FColor RItemCol(BmSDK.FString Label, BmSDK.GameObject.FColor Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RItemCol, "BmGame.RDynamicMenu.RItemCol");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FColor>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_RItemV;
    /// <summary>
    /// Function: RItemV
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 RItemV(BmSDK.FString label1, BmSDK.FString label2, BmSDK.FString label3, System.Numerics.Vector3 Value, float MinValue, float MaxValue, float StepSize)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RItemV, "BmGame.RDynamicMenu.RItemV");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(label1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(label2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(label3, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StepSize, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_RItemFExp;
    /// <summary>
    /// Function: RItemFExp
    /// </summary>
    public unsafe virtual float RItemFExp(BmSDK.FString Label, float Value, float MinValue, float MaxValue, float stepMult)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RItemFExp, "BmGame.RDynamicMenu.RItemFExp");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stepMult, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_RItemF;
    /// <summary>
    /// Function: RItemF
    /// </summary>
    public unsafe virtual float RItemF(BmSDK.FString Label, float Value, float MinValue, float MaxValue, float StepSize)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RItemF, "BmGame.RDynamicMenu.RItemF");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StepSize, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_RItemByte;
    /// <summary>
    /// Function: RItemByte
    /// </summary>
    public unsafe virtual byte RItemByte(BmSDK.FString Label, byte Value, int MinValue, int MaxValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RItemByte, "BmGame.RDynamicMenu.RItemByte");
        byte* paramsPtr = stackalloc byte[29];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_RItemI;
    /// <summary>
    /// Function: RItemI
    /// </summary>
    public unsafe virtual int RItemI(BmSDK.FString Label, int Value, int MinValue, int MaxValue, int Step = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RItemI, "BmGame.RDynamicMenu.RItemI");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Step, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_RItemL;
    /// <summary>
    /// Function: RItemL
    /// </summary>
    public unsafe virtual int RItemL(BmSDK.FString Label, int Value, BmSDK.TArray<BmSDK.FString> List, BmSDK.TArray<BmSDK.FString> details = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RItemL, "BmGame.RDynamicMenu.RItemL");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(List, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(details, paramsPtr + 36);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_RItemB;
    /// <summary>
    /// Function: RItemB
    /// </summary>
    public unsafe virtual bool RItemB(BmSDK.FString Label, bool Value, BmSDK.FString details = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RItemB, "BmGame.RDynamicMenu.RItemB");
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(details, paramsPtr + 20);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ItemButtonExtended;
    /// <summary>
    /// Function: ItemButtonExtended
    /// </summary>
    public unsafe virtual int ItemButtonExtended(BmSDK.FString Label, bool highlight = default, byte R = default, byte G = default, byte B = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemButtonExtended, "BmGame.RDynamicMenu.ItemButtonExtended");
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(highlight, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 21);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 22);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ItemButton;
    /// <summary>
    /// Function: ItemButton
    /// </summary>
    public unsafe virtual bool ItemButton(BmSDK.FString Label, bool highlight = default, BmSDK.FString details = default, byte R = default, byte G = default, byte B = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemButton, "BmGame.RDynamicMenu.ItemButton");
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(highlight, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(details, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 37);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 38);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_ItemCol;
    /// <summary>
    /// Function: ItemCol
    /// </summary>
    public unsafe virtual bool ItemCol(BmSDK.FString Label, out BmSDK.GameObject.FColor Value)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemCol, "BmGame.RDynamicMenu.ItemCol");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FColor>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ItemV;
    /// <summary>
    /// Function: ItemV
    /// </summary>
    public unsafe virtual bool ItemV(BmSDK.FString label1, BmSDK.FString label2, BmSDK.FString label3, out System.Numerics.Vector3 Value, float MinValue, float MaxValue, float StepSize)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemV, "BmGame.RDynamicMenu.ItemV");
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(label1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(label2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(label3, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StepSize, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_ItemFExp;
    /// <summary>
    /// Function: ItemFExp
    /// </summary>
    public unsafe virtual bool ItemFExp(BmSDK.FString Label, out float Value, float MinValue, float MaxValue, float stepMult)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemFExp, "BmGame.RDynamicMenu.ItemFExp");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stepMult, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ItemF;
    /// <summary>
    /// Function: ItemF
    /// </summary>
    public unsafe virtual bool ItemF(BmSDK.FString Label, out float Value, float MinValue, float MaxValue, float StepSize)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemF, "BmGame.RDynamicMenu.ItemF");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StepSize, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ItemByte;
    /// <summary>
    /// Function: ItemByte
    /// </summary>
    public unsafe virtual bool ItemByte(BmSDK.FString Label, out byte Value, int MinValue, int MaxValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemByte, "BmGame.RDynamicMenu.ItemByte");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ItemI;
    /// <summary>
    /// Function: ItemI
    /// </summary>
    public unsafe virtual bool ItemI(BmSDK.FString Label, out int Value, int MinValue, int MaxValue, int Step = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemI, "BmGame.RDynamicMenu.ItemI");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Step, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ItemLabelL;
    /// <summary>
    /// Function: ItemLabelL
    /// </summary>
    public unsafe virtual bool ItemLabelL(out int Value, BmSDK.TArray<BmSDK.FString> List)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemLabelL, "BmGame.RDynamicMenu.ItemLabelL");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(List, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ItemL;
    /// <summary>
    /// Function: ItemL
    /// </summary>
    public unsafe virtual bool ItemL(BmSDK.FString Label, out int Value, BmSDK.TArray<BmSDK.FString> List, BmSDK.TArray<BmSDK.FString> details = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemL, "BmGame.RDynamicMenu.ItemL");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(List, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(details, paramsPtr + 36);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_UpdateItemL;
    /// <summary>
    /// Function: UpdateItemL
    /// </summary>
    public unsafe virtual bool UpdateItemL(out int Value, BmSDK.TArray<BmSDK.FString> List)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateItemL, "BmGame.RDynamicMenu.UpdateItemL");
        byte* paramsPtr = stackalloc byte[24];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(List, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_Title;
    /// <summary>
    /// Function: Title
    /// </summary>
    public unsafe virtual bool Title(BmSDK.FString _Title, bool bUseNumberShortcut = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Title, "BmGame.RDynamicMenu.Title");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_Title, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseNumberShortcut, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetTitleFont;
    /// <summary>
    /// Function: SetTitleFont
    /// </summary>
    public unsafe virtual void SetTitleFont(BmSDK.Engine.Font NewTitleFont)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTitleFont, "BmGame.RDynamicMenu.SetTitleFont");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTitleFont, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetItemFont;
    /// <summary>
    /// Function: SetItemFont
    /// </summary>
    public unsafe virtual void SetItemFont(BmSDK.Engine.Font NewItemFont)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetItemFont, "BmGame.RDynamicMenu.SetItemFont");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewItemFont, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaSeconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RDynamicMenu.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaSeconds, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RDynamicMenu.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NumberInputFExp;
    /// <summary>
    /// Function: NumberInputFExp
    /// </summary>
    public unsafe virtual bool NumberInputFExp(out float Value, float MinValue, float MaxValue, float stepMult)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NumberInputFExp, "BmGame.RDynamicMenu.NumberInputFExp");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stepMult, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_NumberInputF;
    /// <summary>
    /// Function: NumberInputF
    /// </summary>
    public unsafe virtual bool NumberInputF(out float Value, float MinValue, float MaxValue, float StepSize)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NumberInputF, "BmGame.RDynamicMenu.NumberInputF");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StepSize, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_NumberInputB;
    /// <summary>
    /// Function: NumberInputB
    /// </summary>
    public unsafe virtual bool NumberInputB(out byte Value, int MinValue, int MaxValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NumberInputB, "BmGame.RDynamicMenu.NumberInputB");
        byte* paramsPtr = stackalloc byte[16];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_NumberInputI;
    /// <summary>
    /// Function: NumberInputI
    /// </summary>
    public unsafe virtual bool NumberInputI(out int Value, int MinValue, int MaxValue, int Step)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NumberInputI, "BmGame.RDynamicMenu.NumberInputI");
        byte* paramsPtr = stackalloc byte[20];
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinValue, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Step, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PressedIn;
    /// <summary>
    /// Function: PressedIn
    /// </summary>
    public unsafe virtual bool PressedIn()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PressedIn, "BmGame.RDynamicMenu.PressedIn");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PressedInY;
    /// <summary>
    /// Function: PressedInY
    /// </summary>
    public unsafe virtual bool PressedInY()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PressedInY, "BmGame.RDynamicMenu.PressedInY");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PressedInX;
    /// <summary>
    /// Function: PressedInX
    /// </summary>
    public unsafe virtual bool PressedInX()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PressedInX, "BmGame.RDynamicMenu.PressedInX");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PressedInB;
    /// <summary>
    /// Function: PressedInB
    /// </summary>
    public unsafe virtual bool PressedInB()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PressedInB, "BmGame.RDynamicMenu.PressedInB");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PressedInA;
    /// <summary>
    /// Function: PressedInA
    /// </summary>
    public unsafe virtual bool PressedInA()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PressedInA, "BmGame.RDynamicMenu.PressedInA");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PressedRight;
    /// <summary>
    /// Function: PressedRight
    /// </summary>
    public unsafe bool PressedRight()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PressedRight, "BmGame.RDynamicMenu.PressedRight");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PressedLeft;
    /// <summary>
    /// Function: PressedLeft
    /// </summary>
    public unsafe bool PressedLeft()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PressedLeft, "BmGame.RDynamicMenu.PressedLeft");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnThisItem;
    /// <summary>
    /// Function: OnThisItem
    /// </summary>
    public unsafe virtual bool OnThisItem()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnThisItem, "BmGame.RDynamicMenu.OnThisItem");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnThisPage;
    /// <summary>
    /// Function: OnThisPage
    /// </summary>
    public unsafe virtual bool OnThisPage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnThisPage, "BmGame.RDynamicMenu.OnThisPage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitialisingPage;
    /// <summary>
    /// Function: InitialisingPage
    /// </summary>
    public unsafe virtual bool InitialisingPage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialisingPage, "BmGame.RDynamicMenu.InitialisingPage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBeingDisplayed;
    /// <summary>
    /// Function: IsBeingDisplayed
    /// </summary>
    public unsafe virtual bool IsBeingDisplayed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBeingDisplayed, "BmGame.RDynamicMenu.IsBeingDisplayed");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitialisingThisPage;
    /// <summary>
    /// Function: InitialisingThisPage
    /// </summary>
    public unsafe virtual bool InitialisingThisPage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialisingThisPage, "BmGame.RDynamicMenu.InitialisingThisPage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ViewingThisPage;
    /// <summary>
    /// Function: ViewingThisPage
    /// </summary>
    public unsafe virtual bool ViewingThisPage()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ViewingThisPage, "BmGame.RDynamicMenu.ViewingThisPage");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoMenuItems;
    /// <summary>
    /// Function: DoMenuItems
    /// </summary>
    public unsafe virtual void DoMenuItems()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoMenuItems, "BmGame.RDynamicMenu.DoMenuItems");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMenuClosed;
    /// <summary>
    /// Function: OnMenuClosed
    /// </summary>
    public unsafe virtual void OnMenuClosed()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMenuClosed, "BmGame.RDynamicMenu.OnMenuClosed");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMenuOpened;
    /// <summary>
    /// Function: OnMenuOpened
    /// </summary>
    public unsafe virtual void OnMenuOpened()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMenuOpened, "BmGame.RDynamicMenu.OnMenuOpened");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EDynamicMenuButton
    /// </summary>
    public enum EDynamicMenuButton : byte
    {
        DMB_A = 0,
        DMB_B = 1,
        DMB_X = 2,
        DMB_Y = 3,
        DMB_MAX = 4,
    }

    /// <summary>
    /// Struct: FDebugPageInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FDebugPageInfo
    {
        /// <summary>
        /// StrProperty: Title
        /// </summary>
        public unsafe BmSDK.FString Title
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bUseNumberShortcut
        /// </summary>
        public unsafe bool bUseNumberShortcut
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: ShowEntries
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDynamicMenu.FShowEntry> ShowEntries
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDynamicMenu.FShowEntry>>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: PauseGameWhileActive
    /// </summary>
    public unsafe bool PauseGameWhileActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: BeingDisplayed
    /// </summary>
    public unsafe bool BeingDisplayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: Changed
    /// </summary>
    public unsafe bool Changed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: SelectPressedA
    /// </summary>
    public unsafe bool SelectPressedA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: SelectPressedB
    /// </summary>
    public unsafe bool SelectPressedB
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: SelectPressedX
    /// </summary>
    public unsafe bool SelectPressedX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: SelectPressedY
    /// </summary>
    public unsafe bool SelectPressedY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: ShownLastFrame
    /// </summary>
    public unsafe bool ShownLastFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreGaps
    /// </summary>
    public unsafe bool bIgnoreGaps
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: bCanDisableTick
    /// </summary>
    public unsafe bool bCanDisableTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: UseAnalogueControls
    /// </summary>
    public unsafe bool UseAnalogueControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 684); }
    }

    /// <summary>
    /// IntProperty: PadInput
    /// </summary>
    public unsafe int PadInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// IntProperty: PersistentPadInput
    /// </summary>
    public unsafe int PersistentPadInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: Canvas
    /// </summary>
    public unsafe BmSDK.Engine.Canvas Canvas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Canvas>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: PC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerControllerBase PC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerControllerBase>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: ItemFont
    /// </summary>
    public unsafe BmSDK.Engine.Font ItemFont
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Font>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: TitleFont
    /// </summary>
    public unsafe BmSDK.Engine.Font TitleFont
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Font>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: PageList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDynamicMenu.FDebugPageInfo> PageList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDynamicMenu.FDebugPageInfo>>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// IntProperty: PageCount
    /// </summary>
    public unsafe int PageCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// IntProperty: ItemCount
    /// </summary>
    public unsafe int ItemCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// IntProperty: SelectedItem
    /// </summary>
    public unsafe int SelectedItem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: SelectedItemTime
    /// </summary>
    public unsafe float SelectedItemTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// IntProperty: SelectedPage
    /// </summary>
    public unsafe int SelectedPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// IntProperty: LastPageCount
    /// </summary>
    public unsafe int LastPageCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StrProperty: ForcePage
    /// </summary>
    public unsafe BmSDK.FString ForcePage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: MenuX
    /// </summary>
    public unsafe float MenuX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// FloatProperty: MenuBottom
    /// </summary>
    public unsafe float MenuBottom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// FloatProperty: Width
    /// </summary>
    public unsafe float Width
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// FloatProperty: SelectedPageWidth
    /// </summary>
    public unsafe float SelectedPageWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: SelectedPageHeight
    /// </summary>
    public unsafe float SelectedPageHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// IntProperty: SelectedPageWidthChars
    /// </summary>
    public unsafe int SelectedPageWidthChars
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: yOffset
    /// </summary>
    public unsafe float yOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: SelectedItemY
    /// </summary>
    public unsafe float SelectedItemY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: X
    /// </summary>
    public unsafe float X
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: Y
    /// </summary>
    public unsafe float Y
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// IntProperty: Pad
    /// </summary>
    public unsafe int Pad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: LastPad
    /// </summary>
    public unsafe int LastPad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// FloatProperty: RepeatTime
    /// </summary>
    public unsafe float RepeatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// IntProperty: RepeatFrame
    /// </summary>
    public unsafe int RepeatFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: NextRepeatTime
    /// </summary>
    public unsafe float NextRepeatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: NumberItemShortcut
    /// </summary>
    public InlineArray<int> NumberItemShortcut => new(10, Ptr + 844, 4, this);

    /// <summary>
    /// IntProperty: NumberItemShortcut
    /// </summary>
    public unsafe int NumberItemShortcut_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }
    /// <summary>
    /// IntProperty: NumberItemShortcut
    /// </summary>
    public unsafe int NumberItemShortcut_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }
    /// <summary>
    /// IntProperty: NumberItemShortcut
    /// </summary>
    public unsafe int NumberItemShortcut_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
    /// <summary>
    /// IntProperty: NumberItemShortcut
    /// </summary>
    public unsafe int NumberItemShortcut_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }
    /// <summary>
    /// IntProperty: NumberItemShortcut
    /// </summary>
    public unsafe int NumberItemShortcut_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }
    /// <summary>
    /// IntProperty: NumberItemShortcut
    /// </summary>
    public unsafe int NumberItemShortcut_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }
    /// <summary>
    /// IntProperty: NumberItemShortcut
    /// </summary>
    public unsafe int NumberItemShortcut_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }
    /// <summary>
    /// IntProperty: NumberItemShortcut
    /// </summary>
    public unsafe int NumberItemShortcut_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }
    /// <summary>
    /// IntProperty: NumberItemShortcut
    /// </summary>
    public unsafe int NumberItemShortcut_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
    /// <summary>
    /// IntProperty: NumberItemShortcut
    /// </summary>
    public unsafe int NumberItemShortcut_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: NumberPageShortcut
    /// </summary>
    public InlineArray<int> NumberPageShortcut => new(10, Ptr + 884, 4, this);

    /// <summary>
    /// IntProperty: NumberPageShortcut
    /// </summary>
    public unsafe int NumberPageShortcut_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }
    /// <summary>
    /// IntProperty: NumberPageShortcut
    /// </summary>
    public unsafe int NumberPageShortcut_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }
    /// <summary>
    /// IntProperty: NumberPageShortcut
    /// </summary>
    public unsafe int NumberPageShortcut_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }
    /// <summary>
    /// IntProperty: NumberPageShortcut
    /// </summary>
    public unsafe int NumberPageShortcut_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }
    /// <summary>
    /// IntProperty: NumberPageShortcut
    /// </summary>
    public unsafe int NumberPageShortcut_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }
    /// <summary>
    /// IntProperty: NumberPageShortcut
    /// </summary>
    public unsafe int NumberPageShortcut_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
    /// <summary>
    /// IntProperty: NumberPageShortcut
    /// </summary>
    public unsafe int NumberPageShortcut_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
    /// <summary>
    /// IntProperty: NumberPageShortcut
    /// </summary>
    public unsafe int NumberPageShortcut_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }
    /// <summary>
    /// IntProperty: NumberPageShortcut
    /// </summary>
    public unsafe int NumberPageShortcut_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }
    /// <summary>
    /// IntProperty: NumberPageShortcut
    /// </summary>
    public unsafe int NumberPageShortcut_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// FloatProperty: TitleY
    /// </summary>
    public unsafe float TitleY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// FloatProperty: MenuY
    /// </summary>
    public unsafe float MenuY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// FloatProperty: MenuXGap
    /// </summary>
    public unsafe float MenuXGap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: MenuDataWidth
    /// </summary>
    public unsafe float MenuDataWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: ItemH
    /// </summary>
    public unsafe float ItemH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: ItemGapH
    /// </summary>
    public unsafe float ItemGapH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// FloatProperty: InitRepeatTime
    /// </summary>
    public unsafe float InitRepeatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: MinRepeatTime
    /// </summary>
    public unsafe float MinRepeatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// IntProperty: InitRepeatFrames
    /// </summary>
    public unsafe int InitRepeatFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// Struct: FShowEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FShowEntry
    {
        /// <summary>
        /// BoolProperty: Value
        /// </summary>
        public unsafe bool Value
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Label
        /// </summary>
        public unsafe BmSDK.FString Label
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: Command
        /// </summary>
        public unsafe BmSDK.FString Command
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }
}
