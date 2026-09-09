namespace BmSDK.Framework;

internal abstract class GameDefine
{
    public static GameDefine Current { get; } = new GameDefineSteam();

    public abstract string Name { get; }

    // Globals
    public abstract IntPtr GNames { get; }
    public abstract IntPtr GObjObjects { get; }
    public abstract IntPtr GError { get; }

    // app (global)
    public abstract IntPtr AppRealloc { get; }
    public abstract IntPtr AppFree { get; }
    public abstract IntPtr EngineTick { get; }

    // UObject (static)
    public abstract IntPtr StaticFindObject { get; }
    public abstract IntPtr StaticConstructObject { get; }
    public abstract IntPtr LoadPackage { get; }
    public abstract IntPtr CollectGarbage { get; }

    // UObject (local)
    public abstract IntPtr ProcessEvent { get; }
    public abstract IntPtr ProcessInternal { get; }
    public abstract IntPtr CallFunction { get; }
    public abstract IntPtr AddObject { get; }
    public abstract IntPtr ConditionalDestroy { get; }
    public abstract IntPtr FindFunction { get; }
    public abstract IntPtr ConditionalPostLoad { get; }
    public abstract IntPtr AddToRoot { get; }
    public abstract IntPtr RemoveFromRoot { get; }

    // UClass (local)
    public abstract IntPtr GetDefaultObject { get; }

    // UWorld (local)
    public abstract IntPtr SpawnActor { get; }

    // FWindowsViewport (local)
    public abstract IntPtr ProcessDeferredMessage { get; }

    // FName (local)
    public abstract IntPtr NameInit { get; }

    // FString (local)
    public abstract IntPtr StringCtor { get; }

    // Identical across builds, so not per-define
    public static class MemberOffsets
    {
        public const IntPtr Object__ObjectInternalInteger = 48;
        public const IntPtr Object__Outer = 52;
        public const IntPtr Object__Name = 60;
        public const IntPtr Object__Class = 68;
        public const IntPtr Struct__SuperStruct = 92;
        public const IntPtr Class__ClassFlags = 244;
    }
}
