#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MHackableObjectBase<br/>
/// (size = 1096)
/// (flags = 10485779)
/// </summary>
public partial class MHackableObjectBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MHackableObjectBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MHackableObjectBase.
    /// </summary>
    public static MHackableObjectBase DefaultObject => (MHackableObjectBase)StaticClass().DefaultObject;

    internal MHackableObjectBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHackableObjectBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnToggle;
    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe virtual void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggle, "BmGame.MHackableObjectBase.OnToggle");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.MHackableObjectBase.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.MHackableObjectBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCompleteEvent;
    /// <summary>
    /// Function: TriggerCompleteEvent
    /// </summary>
    public unsafe virtual bool TriggerCompleteEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCompleteEvent, "BmGame.MHackableObjectBase.TriggerCompleteEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CreateHackMaskMesh;
    /// <summary>
    /// Function: CreateHackMaskMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.StaticMeshComponent CreateHackMaskMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHackMaskMesh, "BmGame.MHackableObjectBase.CreateHackMaskMesh");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ChangeHighlightType;
    /// <summary>
    /// Function: ChangeHighlightType
    /// </summary>
    public unsafe virtual void ChangeHighlightType(BmSDK.BmGame.MHackableInterface.EHackableObjectState newHighlightType, bool bForce = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeHighlightType, "BmGame.MHackableObjectBase.ChangeHighlightType");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newHighlightType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSubroutineDescription;
    /// <summary>
    /// Function: GetSubroutineDescription
    /// </summary>
    public unsafe virtual BmSDK.FString GetSubroutineDescription(BmSDK.BmGame.MHackableInterface.FSubroutineDefinition Definition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSubroutineDescription, "BmGame.MHackableObjectBase.GetSubroutineDescription");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Definition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_GetSubroutineName;
    /// <summary>
    /// Function: GetSubroutineName
    /// </summary>
    public unsafe virtual BmSDK.FString GetSubroutineName(BmSDK.BmGame.MHackableInterface.FSubroutineDefinition Definition)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSubroutineName, "BmGame.MHackableObjectBase.GetSubroutineName");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Definition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_IsSubroutineTypeDisable;
    /// <summary>
    /// Function: IsSubroutineTypeDisable
    /// </summary>
    public unsafe virtual bool IsSubroutineTypeDisable(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSubroutineTypeDisable, "BmGame.MHackableObjectBase.IsSubroutineTypeDisable");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetSubroutineNameAndDescriptionModifiedByKismet;
    /// <summary>
    /// Function: SetSubroutineNameAndDescriptionModifiedByKismet
    /// </summary>
    public unsafe virtual void SetSubroutineNameAndDescriptionModifiedByKismet(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType, BmSDK.FString NewSubroutineName, BmSDK.FString NewSubroutineDescription)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubroutineNameAndDescriptionModifiedByKismet, "BmGame.MHackableObjectBase.SetSubroutineNameAndDescriptionModifiedByKismet");
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSubroutineName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSubroutineDescription, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableSubroutineType;
    /// <summary>
    /// Function: DisableSubroutineType
    /// </summary>
    public unsafe virtual void DisableSubroutineType(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType, bool NewIsDisable)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableSubroutineType, "BmGame.MHackableObjectBase.DisableSubroutineType");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewIsDisable, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsObjectEnable;
    /// <summary>
    /// Function: IsObjectEnable
    /// </summary>
    public unsafe virtual bool IsObjectEnable()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsObjectEnable, "BmGame.MHackableObjectBase.IsObjectEnable");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetInHackableMode;
    /// <summary>
    /// Function: SetInHackableMode
    /// </summary>
    public unsafe virtual void SetInHackableMode(bool On, bool bForce)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInHackableMode, "BmGame.MHackableObjectBase.SetInHackableMode");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHackableState;
    /// <summary>
    /// Function: GetHackableState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MHackableInterface.EHackableObjectState GetHackableState()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHackableState, "BmGame.MHackableObjectBase.GetHackableState");
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackableObjectState>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayTargetLocation;
    /// <summary>
    /// Function: GetDisplayTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDisplayTargetLocation()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayTargetLocation, "BmGame.MHackableObjectBase.GetDisplayTargetLocation");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSubroutineDefinitionForType;
    /// <summary>
    /// Function: GetSubroutineDefinitionForType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MHackableInterface.FSubroutineDefinition GetSubroutineDefinitionForType(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSubroutineDefinitionForType, "BmGame.MHackableObjectBase.GetSubroutineDefinitionForType");
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.FSubroutineDefinition>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumberOfSubroutineTypes;
    /// <summary>
    /// Function: GetNumberOfSubroutineTypes
    /// </summary>
    public unsafe virtual int GetNumberOfSubroutineTypes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumberOfSubroutineTypes, "BmGame.MHackableObjectBase.GetNumberOfSubroutineTypes");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyOnHack;
    /// <summary>
    /// Function: NotifyOnHack
    /// </summary>
    public unsafe virtual void NotifyOnHack(BmSDK.Engine.Actor HackedObject, BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyOnHack, "BmGame.MHackableObjectBase.NotifyOnHack");
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackedObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCancelEvent;
    /// <summary>
    /// Function: TriggerCancelEvent
    /// </summary>
    public unsafe virtual bool TriggerCancelEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCancelEvent, "BmGame.MHackableObjectBase.TriggerCancelEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TriggerEvent;
    /// <summary>
    /// Function: TriggerEvent
    /// </summary>
    public unsafe virtual bool TriggerEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerEvent, "BmGame.MHackableObjectBase.TriggerEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetOutputIndexForEvent;
    /// <summary>
    /// Function: GetOutputIndexForEvent
    /// </summary>
    public unsafe virtual int GetOutputIndexForEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOutputIndexForEvent, "BmGame.MHackableObjectBase.GetOutputIndexForEvent");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_NeedToDisplayNumberOfTargets;
    /// <summary>
    /// Function: NeedToDisplayNumberOfTargets
    /// </summary>
    public unsafe virtual bool NeedToDisplayNumberOfTargets()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NeedToDisplayNumberOfTargets, "BmGame.MHackableObjectBase.NeedToDisplayNumberOfTargets");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeExecuted;
    /// <summary>
    /// Function: CanBeExecuted
    /// </summary>
    public unsafe virtual bool CanBeExecuted()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeExecuted, "BmGame.MHackableObjectBase.CanBeExecuted");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanInterrupt;
    /// <summary>
    /// Function: CanInterrupt
    /// </summary>
    public unsafe virtual bool CanInterrupt(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanInterrupt, "BmGame.MHackableObjectBase.CanInterrupt");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ExecuteSubroutine;
    /// <summary>
    /// Function: ExecuteSubroutine
    /// </summary>
    public unsafe virtual bool ExecuteSubroutine(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExecuteSubroutine, "BmGame.MHackableObjectBase.ExecuteSubroutine");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SpawnSubroutine;
    /// <summary>
    /// Function: SpawnSubroutine
    /// </summary>
    public unsafe virtual void SpawnSubroutine(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSubroutine, "BmGame.MHackableObjectBase.SpawnSubroutine");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnPreviewSubroutine;
    /// <summary>
    /// Function: SpawnPreviewSubroutine
    /// </summary>
    public unsafe virtual void SpawnPreviewSubroutine(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPreviewSubroutine, "BmGame.MHackableObjectBase.SpawnPreviewSubroutine");
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAffectedActors;
    /// <summary>
    /// Function: GetAffectedActors
    /// </summary>
    public unsafe virtual void GetAffectedActors(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass, out BmSDK.TArray<BmSDK.Engine.Actor> AffectedActors)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAffectedActors, "BmGame.MHackableObjectBase.GetAffectedActors");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AffectedActors = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetPossibleSubroutineTypes;
    /// <summary>
    /// Function: GetPossibleSubroutineTypes
    /// </summary>
    public unsafe virtual void GetPossibleSubroutineTypes(out BmSDK.TArray<BmSDK.BmGame.MHackableInterface.EHackSubroutineType> PossibleTypes)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPossibleSubroutineTypes, "BmGame.MHackableObjectBase.GetPossibleSubroutineTypes");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleTypes = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MHackableInterface.EHackSubroutineType>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentSubroutineType;
    /// <summary>
    /// Function: GetCurrentSubroutineType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MHackableInterface.EHackSubroutineType GetCurrentSubroutineType()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentSubroutineType, "BmGame.MHackableObjectBase.GetCurrentSubroutineType");
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackSubroutineType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPreviewSubroutine;
    /// <summary>
    /// Function: GetPreviewSubroutine
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MHackSubroutine GetPreviewSubroutine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPreviewSubroutine, "BmGame.MHackableObjectBase.GetPreviewSubroutine");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentSubroutine;
    /// <summary>
    /// Function: GetCurrentSubroutine
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MHackSubroutine GetCurrentSubroutine()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentSubroutine, "BmGame.MHackableObjectBase.GetCurrentSubroutine");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe virtual void SetInXrayMode(bool On, bool bForceOff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmGame.MHackableObjectBase.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateXrayMaskMesh;
    /// <summary>
    /// Function: CreateXrayMaskMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.StaticMeshComponent CreateXrayMaskMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateXrayMaskMesh, "BmGame.MHackableObjectBase.CreateXrayMaskMesh");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateStateMesh;
    /// <summary>
    /// Function: UpdateStateMesh
    /// </summary>
    public unsafe virtual void UpdateStateMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStateMesh, "BmGame.MHackableObjectBase.UpdateStateMesh");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateHighlightMesh;
    /// <summary>
    /// Function: CreateHighlightMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.StaticMeshComponent CreateHighlightMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHighlightMesh, "BmGame.MHackableObjectBase.CreateHighlightMesh");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetupHighlightMaterial;
    /// <summary>
    /// Function: SetupHighlightMaterial
    /// </summary>
    public unsafe virtual void SetupHighlightMaterial()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupHighlightMaterial, "BmGame.MHackableObjectBase.SetupHighlightMaterial");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: StaticMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent StaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: HackingViewMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface HackingViewMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DetectiveModeMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: DisableStateStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh DisableStateStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine CurrentSubroutine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: PreviewSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine PreviewSubroutine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: HighlightMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance HighlightMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: HighlightMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HighlightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: EnableStateStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh EnableStateStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ComponentProperty: HighlightStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent HighlightStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ComponentProperty: XRayMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent XRayMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ComponentProperty: DLCXtraMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent DLCXtraMaskMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: Interactions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent Interactions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ArrayProperty: SupportedSubroutines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MHackableInterface.FSubroutineDefinition> SupportedSubroutines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MHackableInterface.FSubroutineDefinition>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// StructProperty: TargetPositionOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetPositionOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 788);

    /// <summary>
    /// InterfaceProperty: NotifyObjectOnHack
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface NotifyObjectOnHack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// IntProperty: EnableAfterHackCount
    /// </summary>
    public unsafe int EnableAfterHackCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ByteProperty: CurrentHighlightType
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.EHackableObjectState CurrentHighlightType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackableObjectState>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: SubroutinesTypeDisabled
    /// </summary>
    public InlineArray<byte> SubroutinesTypeDisabled => new(8, Ptr + 821, 1, this);

    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 821); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 821); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 822); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 822); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 823); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 823); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 825); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 825); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 826); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 826); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 827); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 827); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// IntProperty: RoomHackedCount
    /// </summary>
    public unsafe int RoomHackedCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bHacked
    /// </summary>
    public unsafe bool bHacked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bUsingEnableStateMesh
    /// </summary>
    public unsafe bool bUsingEnableStateMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: SubroutinesNameModifiedByKismet
    /// </summary>
    public InlineArray<BmSDK.FString> SubroutinesNameModifiedByKismet => new(8, Ptr + 840, 16, this);

    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public InlineArray<BmSDK.FString> SubroutinesDescriptionModifiedByKismet => new(8, Ptr + 968, 16, this);

    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
}
