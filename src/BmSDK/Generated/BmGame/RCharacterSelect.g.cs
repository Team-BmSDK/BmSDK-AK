#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCharacterSelect<br/>
/// (size = 909)
/// (flags = 144704146)
/// </summary>
public partial class RCharacterSelect : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCharacterSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCharacterSelect.
    /// </summary>
    public static RCharacterSelect DefaultObject => (RCharacterSelect)StaticClass().DefaultObject;

    internal RCharacterSelect() { }

    /// <summary>
    /// Constructs a new RCharacterSelect
    /// </summary>
    public RCharacterSelect(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacterSelect(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCharacterSelect>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacterSelect>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCharacterSelect>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacterSelect>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacterSelect>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacterSelect>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCharacterSelect>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacterSelect>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetCharacters;
    /// <summary>
    /// Function: SetCharacters
    /// </summary>
    public unsafe virtual void SetCharacters(BmSDK.FString LeftCharacterName, BmSDK.FString RightCharacterName, bool Player1Ready, bool Player2Ready)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCharacters, "BmGame.RCharacterSelect.SetCharacters");
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftCharacterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightCharacterName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player1Ready, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player2Ready, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCharacterConfigIndex;
    /// <summary>
    /// Function: GetCharacterConfigIndex
    /// </summary>
    public unsafe virtual int GetCharacterConfigIndex(BmSDK.FString CharacterName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCharacterConfigIndex, "BmGame.RCharacterSelect.GetCharacterConfigIndex");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaSeconds)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RCharacterSelect.Tick");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaSeconds, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickPlayer;
    /// <summary>
    /// Function: TickPlayer
    /// </summary>
    public unsafe virtual void TickPlayer(float DeltaSeconds, out BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer Player, BmSDK.Engine.Actor PositionDummy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickPlayer, "BmGame.RCharacterSelect.TickPlayer");
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaSeconds, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionDummy, paramsPtr + 92);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Player = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RCharacterSelect.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RightPlayerBlendToIdle;
    /// <summary>
    /// Function: RightPlayerBlendToIdle
    /// </summary>
    public unsafe virtual void RightPlayerBlendToIdle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RightPlayerBlendToIdle, "BmGame.RCharacterSelect.RightPlayerBlendToIdle");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LeftPlayerBlendToIdle;
    /// <summary>
    /// Function: LeftPlayerBlendToIdle
    /// </summary>
    public unsafe virtual void LeftPlayerBlendToIdle()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LeftPlayerBlendToIdle, "BmGame.RCharacterSelect.LeftPlayerBlendToIdle");
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetReady;
    /// <summary>
    /// Function: SetReady
    /// </summary>
    public unsafe virtual void SetReady(out BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer Player, bool bNewValue, BmSDK.FName BlendToIdleFunction)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetReady, "BmGame.RCharacterSelect.SetReady");
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendToIdleFunction, paramsPtr + 92);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Player = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetConfig;
    /// <summary>
    /// Function: GetConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAddContentCharacterSelect GetConfig(int Index)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetConfig, "BmGame.RCharacterSelect.GetConfig");
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAddContentCharacterSelect>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SyncMesh;
    /// <summary>
    /// Function: SyncMesh
    /// </summary>
    public unsafe virtual void SyncMesh(out BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer Player, BmSDK.BmGame.RAddContentCharacterSelect Config, BmSDK.Engine.Actor PositionDummy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SyncMesh, "BmGame.RCharacterSelect.SyncMesh");
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionDummy, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Player = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ClearMaterials;
    /// <summary>
    /// Function: ClearMaterials
    /// </summary>
    public unsafe virtual void ClearMaterials(BmSDK.Engine.SkeletalMeshComponent Mesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMaterials, "BmGame.RCharacterSelect.ClearMaterials");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mesh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SyncMeshPosition;
    /// <summary>
    /// Function: SyncMeshPosition
    /// </summary>
    public unsafe virtual void SyncMeshPosition(BmSDK.Engine.SkeletalMeshComponent Mesh, BmSDK.Engine.Actor PositionDummy, System.Numerics.Vector3 PositionOffset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SyncMeshPosition, "BmGame.RCharacterSelect.SyncMeshPosition");
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionDummy, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionOffset, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConstructCape;
    /// <summary>
    /// Function: ConstructCape
    /// </summary>
    public unsafe virtual void ConstructCape(out BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer Player, BmSDK.Engine.Actor PositionDummy, BmSDK.Engine.SkeletalMeshComponent Parent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConstructCape, "BmGame.RCharacterSelect.ConstructCape");
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionDummy, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Parent, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Player = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ConstructAttachMesh;
    /// <summary>
    /// Function: ConstructAttachMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent ConstructAttachMesh()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConstructAttachMesh, "BmGame.RCharacterSelect.ConstructAttachMesh");
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ConstructExtraMesh;
    /// <summary>
    /// Function: ConstructExtraMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent ConstructExtraMesh(BmSDK.Engine.Actor PositionDummy, BmSDK.Engine.SkeletalMeshComponent Parent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConstructExtraMesh, "BmGame.RCharacterSelect.ConstructExtraMesh");
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionDummy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Parent, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ConstructMainMesh;
    /// <summary>
    /// Function: ConstructMainMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent ConstructMainMesh(BmSDK.Engine.Actor PositionDummy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConstructMainMesh, "BmGame.RCharacterSelect.ConstructMainMesh");
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionDummy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RemoveAllConfigs;
    /// <summary>
    /// Function: RemoveAllConfigs
    /// </summary>
    public unsafe virtual void RemoveAllConfigs()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAllConfigs, "BmGame.RCharacterSelect.RemoveAllConfigs");
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddConfig;
    /// <summary>
    /// Function: AddConfig
    /// </summary>
    public unsafe virtual void AddConfig(BmSDK.BmGame.RAddContentCharacterSelect CharConfig)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddConfig, "BmGame.RCharacterSelect.AddConfig");
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TermCharacterSelectPhysics;
    /// <summary>
    /// Function: TermCharacterSelectPhysics
    /// </summary>
    public unsafe virtual void TermCharacterSelectPhysics()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TermCharacterSelectPhysics, "BmGame.RCharacterSelect.TermCharacterSelectPhysics");
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

    private static BmSDK.Function __fn_InitCharacterSelectPhysics;
    /// <summary>
    /// Function: InitCharacterSelectPhysics
    /// </summary>
    public unsafe virtual void InitCharacterSelectPhysics()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitCharacterSelectPhysics, "BmGame.RCharacterSelect.InitCharacterSelectPhysics");
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

    /// <summary>
    /// Struct: FCharacterSelectPlayer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial record struct FCharacterSelectPlayer
    {
        /// <summary>
        /// ComponentProperty: Mesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMeshComponent Mesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: ExtraMeshes
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent> ExtraMeshes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: AttachMeshes
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent> AttachMeshes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ComponentProperty: CapeMesh
        /// </summary>
        public unsafe BmSDK.BmGame.RCapeSkeletalMeshComponent CapeMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeSkeletalMeshComponent>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ComponentProperty: CapeComponent
        /// </summary>
        public unsafe BmSDK.BmGame.RCapeComponent CapeComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeComponent>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ComponentProperty: CapeRenderingComponent
        /// </summary>
        public unsafe BmSDK.BmGame.RCapeRenderingComponent CapeRenderingComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeRenderingComponent>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// IntProperty: CurrentConfigIndex
        /// </summary>
        public unsafe int CurrentConfigIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// IntProperty: PendingConfigIndex
        /// </summary>
        public unsafe int PendingConfigIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: CachedReady
        /// </summary>
        public unsafe bool CachedReady
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentTimeTillRandomAnimation
        /// </summary>
        public unsafe float CurrentTimeTillRandomAnimation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// NameProperty: BlendToIdleFunctionName
        /// </summary>
        public unsafe BmSDK.FName BlendToIdleFunctionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: CharacterConfigs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAddContentCharacterSelect> CharacterConfigs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAddContentCharacterSelect>>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: CapeConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeConfig CapeConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeConfig>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: CapeAnimTree
    /// </summary>
    public unsafe BmSDK.Engine.AnimTree CapeAnimTree
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimTree>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: LeftPositionDummy
    /// </summary>
    public unsafe BmSDK.Engine.Actor LeftPositionDummy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: RightPositionDummy
    /// </summary>
    public unsafe BmSDK.Engine.Actor RightPositionDummy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ComponentProperty: CapeComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeComponent CapeComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeComponent>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StructProperty: LeftPlayer
    /// </summary>
    public unsafe ref BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer LeftPlayer
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer>(Ptr + 724);

    /// <summary>
    /// StructProperty: RightPlayer
    /// </summary>
    public unsafe ref BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer RightPlayer
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RCharacterSelect.FCharacterSelectPlayer>(Ptr + 812);

    /// <summary>
    /// FloatProperty: TimeTillRandomAnimation
    /// </summary>
    public unsafe float TimeTillRandomAnimation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: LightingChannels
    /// </summary>
    public unsafe ref BmSDK.Engine.LightComponent.FLightingChannelContainer LightingChannels
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.LightComponent.FLightingChannelContainer>(Ptr + 904);

    /// <summary>
    /// ByteProperty: DepthPriorityGroup
    /// </summary>
    public unsafe BmSDK.Engine.Scene.ESceneDepthPriorityGroup DepthPriorityGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Scene.ESceneDepthPriorityGroup>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
}
