namespace BmSDK.Framework;

/// <summary>
/// Keyboard and mouse-button state as the game's window receives it, and swallowing keys so the game
/// never sees them.
/// </summary>
/// <remarks>
/// BmSDK reads key messages before the engine does. A swallowed key still reaches scripts
/// (<see cref="Script.OnKeyDown"/>, <see cref="IsDown"/>) but its press and release are dropped
/// before the engine's input bindings see them, so a mod's menu key no longer also fires the game's
/// action bound to it. A release is only dropped when its press was, so the game never sees a key
/// stuck down. Mouse buttons use the <see cref="Keys.LButton"/>, <see cref="Keys.RButton"/>,
/// <see cref="Keys.MButton"/>, <see cref="Keys.XButton1"/> and <see cref="Keys.XButton2"/> keys.
/// <para/>
/// Swallowed keys are global state shared by all mods and survive a hot reload: unswallow keys when
/// your mod no longer needs them (e.g. in <see cref="Script.OnUnload"/>).
/// </remarks>
public static class Keyboard
{
    /// <summary>Whether the key is currently held, as far as the game's window knows.</summary>
    public static bool IsDown(Keys key) => InputManager.IsDown(key);

    /// <summary>Stops the engine seeing this key's presses and releases until <see cref="Unswallow"/>.</summary>
    public static void Swallow(Keys key) => InputManager.SetSwallowed(key, true);

    /// <summary>Lets the engine see this key again.</summary>
    public static void Unswallow(Keys key) => InputManager.SetSwallowed(key, false);

    /// <summary>Lets the engine see every key again.</summary>
    public static void UnswallowAll() => InputManager.UnswallowAll();

    /// <summary>Whether the engine is currently kept from seeing this key.</summary>
    public static bool IsSwallowed(Keys key) => InputManager.IsSwallowed(key);
}
