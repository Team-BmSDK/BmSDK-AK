namespace BmSDK.Framework;

public sealed class GameDefineSteam : GameDefine
{
    public override string Name => "Steam";

    // Globals
    public override IntPtr GNames => 0x3A208B8;
    public override IntPtr GObjObjects => 0x340CBE4;
    public override IntPtr GError => 0x3A20AA8;

    // app (global)
    public override IntPtr AppRealloc => 0xFA2A60;
    public override IntPtr AppFree => 0xFA2A80;
    public override IntPtr EngineTick => 0x5B1DA0;

    // UObject (static)
    public override IntPtr StaticFindObject => 0xF3B7F0;
    public override IntPtr StaticConstructObject => 0xF470B0;
    public override IntPtr LoadPackage => 0xF46DA0;
    public override IntPtr CollectGarbage => 0xF2C280;

    // UObject (local)
    public override IntPtr ProcessEvent => 0xF90CD0;
    public override IntPtr ProcessInternal => 0xF90B30;
    public override IntPtr CallFunction => 0xF95AA0;
    public override IntPtr AddObject => 0xF388F0;
    public override IntPtr ConditionalDestroy => 0xF38D80;
    public override IntPtr FindFunction => 0xF3DB80;
    public override IntPtr ConditionalPostLoad => 0xF430F0;
    public override IntPtr AddToRoot => 0xF2D440;
    public override IntPtr RemoveFromRoot => 0xF2D460;

    // UClass (local)
    public override IntPtr GetDefaultObject => 0xF92870;

    // UWorld (local)
    public override IntPtr SpawnActor => 0xACBC70;

    // FWindowsViewport (local)
    public override IntPtr ProcessDeferredMessage => 0x105D400;

    // FName (local)
    public override IntPtr NameInit => 0xF37BF0;

    // FString (local)
    public override IntPtr StringCtor => 0x41D0;
}
