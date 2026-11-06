#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_BatCave<br/>
/// (size = 1192)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_BatCave : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_BatCave", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_BatCave.
    /// </summary>
    public static RGFxMovieUI_BatCave DefaultObject => (RGFxMovieUI_BatCave)StaticClass().DefaultObject;

    internal RGFxMovieUI_BatCave() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_BatCave
    /// </summary>
    public RGFxMovieUI_BatCave(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_BatCave Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_BatCave(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_BatCave>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_XI_SetZoom;
    /// <summary>
    /// Function: XI_SetZoom
    /// </summary>
    public unsafe virtual void XI_SetZoom(float InZoom)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_SetZoom, "BmScript.RGFxMovieUI_BatCave.XI_SetZoom");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InZoom, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmScript.RGFxMovieUI_BatCave.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_BatCaveCustomContentAction;
    /// <summary>
    /// Function: XI_BatCaveCustomContentAction
    /// </summary>
    public unsafe virtual void XI_BatCaveCustomContentAction(BmSDK.FString sAction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BatCaveCustomContentAction, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveCustomContentAction");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_BatCaveAnimate;
    /// <summary>
    /// Function: XI_BatCaveAnimate
    /// </summary>
    public unsafe virtual void XI_BatCaveAnimate()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BatCaveAnimate, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveAnimate");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_BatCaveNoir;
    /// <summary>
    /// Function: XI_BatCaveNoir
    /// </summary>
    public unsafe virtual void XI_BatCaveNoir()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BatCaveNoir, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveNoir");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_BatCaveLights;
    /// <summary>
    /// Function: XI_BatCaveLights
    /// </summary>
    public unsafe virtual void XI_BatCaveLights()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BatCaveLights, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveLights");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_BatCaveInspect;
    /// <summary>
    /// Function: XI_BatCaveInspect
    /// </summary>
    public unsafe virtual void XI_BatCaveInspect(bool bInspectMode)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BatCaveInspect, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveInspect");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInspectMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_BatCaveViewedItem;
    /// <summary>
    /// Function: XI_BatCaveViewedItem
    /// </summary>
    public unsafe virtual void XI_BatCaveViewedItem(BmSDK.FString sItem)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BatCaveViewedItem, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveViewedItem");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sItem, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_BatCaveLoadLevels;
    /// <summary>
    /// Function: XI_BatCaveLoadLevels
    /// </summary>
    public unsafe virtual void XI_BatCaveLoadLevels(BmSDK.FString sLevels, BmSDK.FString sFilter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BatCaveLoadLevels, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveLoadLevels");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sLevels, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sFilter, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_BatCaveSelectSkin;
    /// <summary>
    /// Function: XI_BatCaveSelectSkin
    /// </summary>
    public unsafe virtual void XI_BatCaveSelectSkin(BmSDK.FString sSkin)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BatCaveSelectSkin, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveSelectSkin");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sSkin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_BatCaveSelectCamera;
    /// <summary>
    /// Function: XI_BatCaveSelectCamera
    /// </summary>
    public unsafe virtual void XI_BatCaveSelectCamera(BmSDK.FString sCamera)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BatCaveSelectCamera, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveSelectCamera");
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCamera, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_BatCaveEnumerate;
    /// <summary>
    /// Function: XI_BatCaveEnumerate
    /// </summary>
    public unsafe virtual void XI_BatCaveEnumerate(BmSDK.FString sTargetPath)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_BatCaveEnumerate, "BmScript.RGFxMovieUI_BatCave.XI_BatCaveEnumerate");
        byte* paramsPtr = stackalloc byte[248];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sTargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_LevelsLoaded;
    /// <summary>
    /// Function: UC_LevelsLoaded
    /// </summary>
    public unsafe virtual void UC_LevelsLoaded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_LevelsLoaded, "BmScript.RGFxMovieUI_BatCave.UC_LevelsLoaded");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetInspectMode;
    /// <summary>
    /// Function: UC_SetInspectMode
    /// </summary>
    public unsafe virtual void UC_SetInspectMode(bool bInspect)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetInspectMode, "BmScript.RGFxMovieUI_BatCave.UC_SetInspectMode");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInspect, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetActiveSkin;
    /// <summary>
    /// Function: UC_SetActiveSkin
    /// </summary>
    public unsafe virtual void UC_SetActiveSkin(BmSDK.FString sSkinPackage, bool bActive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetActiveSkin, "BmScript.RGFxMovieUI_BatCave.UC_SetActiveSkin");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sSkinPackage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActive, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_SetItemImage;
    /// <summary>
    /// Function: UC_SetItemImage
    /// </summary>
    public unsafe virtual void UC_SetItemImage(BmSDK.FString Stab, BmSDK.FString sItem, BmSDK.FString sImage, BmSDK.GFxUI.GFxObject iImage)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_SetItemImage, "BmScript.RGFxMovieUI_BatCave.UC_SetItemImage");
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stab, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sItem, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sImage, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iImage, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UC_AddItem;
    /// <summary>
    /// Function: UC_AddItem
    /// </summary>
    public unsafe virtual void UC_AddItem(BmSDK.FString sPage, BmSDK.FString sName, BmSDK.FString sLevels, BmSDK.FString sParameters)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UC_AddItem, "BmScript.RGFxMovieUI_BatCave.UC_AddItem");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sLevels, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sParameters, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CustomContentLoadedSC;
    /// <summary>
    /// Function: CustomContentLoadedSC
    /// </summary>
    public unsafe virtual void CustomContentLoadedSC(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomContentLoadedSC, "BmScript.RGFxMovieUI_BatCave.CustomContentLoadedSC");
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CustomManifestLoadedSC;
    /// <summary>
    /// Function: CustomManifestLoadedSC
    /// </summary>
    public unsafe virtual void CustomManifestLoadedSC(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomManifestLoadedSC, "BmScript.RGFxMovieUI_BatCave.CustomManifestLoadedSC");
        byte* paramsPtr = stackalloc byte[256];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LevelStreamShowActive;
    /// <summary>
    /// Function: LevelStreamShowActive
    /// </summary>
    public unsafe virtual void LevelStreamShowActive(bool bShow)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelStreamShowActive, "BmScript.RGFxMovieUI_BatCave.LevelStreamShowActive");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LevelStreamLoadReferences;
    /// <summary>
    /// Function: LevelStreamLoadReferences
    /// </summary>
    public unsafe virtual int LevelStreamLoadReferences(BmSDK.FString sLevels, BmSDK.FString sFilter)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelStreamLoadReferences, "BmScript.RGFxMovieUI_BatCave.LevelStreamLoadReferences");
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sLevels, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sFilter, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_LevelStreamLoaded;
    /// <summary>
    /// Function: LevelStreamLoaded
    /// </summary>
    public unsafe virtual bool LevelStreamLoaded()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelStreamLoaded, "BmScript.RGFxMovieUI_BatCave.LevelStreamLoaded");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LevelStreamStoreOriginals;
    /// <summary>
    /// Function: LevelStreamStoreOriginals
    /// </summary>
    public unsafe virtual void LevelStreamStoreOriginals()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelStreamStoreOriginals, "BmScript.RGFxMovieUI_BatCave.LevelStreamStoreOriginals");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LevelStreamInArray;
    /// <summary>
    /// Function: LevelStreamInArray
    /// </summary>
    public unsafe virtual bool LevelStreamInArray(BmSDK.TArray<BmSDK.FString> aArray, BmSDK.FString sName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelStreamInArray, "BmScript.RGFxMovieUI_BatCave.LevelStreamInArray");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ForceLoadTexturesRequestMultiLevel;
    /// <summary>
    /// Function: ForceLoadTexturesRequestMultiLevel
    /// </summary>
    public unsafe virtual void ForceLoadTexturesRequestMultiLevel(BmSDK.TArray<BmSDK.FString> Levels)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceLoadTexturesRequestMultiLevel, "BmScript.RGFxMovieUI_BatCave.ForceLoadTexturesRequestMultiLevel");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Levels, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimerLoadingLevels;
    /// <summary>
    /// Function: TimerLoadingLevels
    /// </summary>
    public unsafe virtual void TimerLoadingLevels()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerLoadingLevels, "BmScript.RGFxMovieUI_BatCave.TimerLoadingLevels");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimerStreamingTextures;
    /// <summary>
    /// Function: TimerStreamingTextures
    /// </summary>
    public unsafe virtual void TimerStreamingTextures()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimerStreamingTextures, "BmScript.RGFxMovieUI_BatCave.TimerStreamingTextures");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LightsOnDelay;
    /// <summary>
    /// Function: LightsOnDelay
    /// </summary>
    public unsafe virtual void LightsOnDelay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LightsOnDelay, "BmScript.RGFxMovieUI_BatCave.LightsOnDelay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_XI_OnOut;
    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe override void XI_OnOut()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_XI_OnOut, "BmScript.RGFxMovieUI_BatCave.XI_OnOut");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmScript.RGFxMovieUI_BatCave.CloseScreen");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer iPlayer = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_BatCave.Init");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StrProperty: sManifest
    /// </summary>
    public unsafe BmSDK.FString sManifest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: m_sMoviePath
    /// </summary>
    public unsafe BmSDK.FString m_sMoviePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: m_aOriginalLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> m_aOriginalLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: m_aLoadingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> m_aLoadingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: m_aActiveLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> m_aActiveLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: m_bInspectReady
    /// </summary>
    public unsafe bool m_bInspectReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bSaveNeeded
    /// </summary>
    public unsafe bool m_bSaveNeeded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bBatmobilesAlwaysAvailable
    /// </summary>
    public unsafe bool m_bBatmobilesAlwaysAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bAllowHarleySkin
    /// </summary>
    public unsafe bool bAllowHarleySkin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bAllowRedhoodSkin
    /// </summary>
    public unsafe bool bAllowRedhoodSkin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: m_nLoadedReferenceCount
    /// </summary>
    public unsafe int m_nLoadedReferenceCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// DelegateProperty: __CustomManifestLoadedSC__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomManifestLoadedSC__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// DelegateProperty: __CustomContentLoadedSC__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomContentLoadedSC__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }
}
