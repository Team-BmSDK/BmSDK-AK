using System.Reflection;

namespace BmSDK.Framework;

/// <summary>
/// Runs mod code (lifecycle callbacks, redirects) so that an exception is logged and the game keeps
/// running. Before this, any exception escaping a mod callback ended the process.
/// </summary>
/// <remarks>
/// The first unhandled exception unloads the mod it came from, at the next engine tick (see
/// <see cref="ScriptManager.UnloadModOf"/>): a broken mod can't keep throwing, and its author finds
/// one error in the log. Saving a script reloads it. Exceptions inside BmSDK's own detour code are
/// not handled here: there the state may be corrupt, and the process still exits.
/// </remarks>
internal static class ModGuard
{
    /// <summary>
    /// Runs <paramref name="action"/>, the callback <paramref name="what"/> of <paramref name="owner"/>
    /// (a script or component), logging as <paramref name="sender"/>. Returns false if it threw.
    /// </summary>
    public static bool Run(object owner, string sender, string what, Action action)
    {
        Debug.PushSender(sender);
        try
        {
            action();
            return true;
        }
        catch (Exception ex)
        {
            Report(owner.GetType().Assembly, ex, what);
            return false;
        }
        finally
        {
            Debug.PopSender();
        }
    }

    /// <summary>
    /// Logs an exception that mod code in <paramref name="modAssembly"/> threw, as
    /// <paramref name="sender"/>, and unloads that mod.
    /// </summary>
    public static void Report(Assembly modAssembly, string sender, Exception ex, string describe)
    {
        Debug.PushSender(sender);
        try
        {
            Report(modAssembly, ex, describe);
        }
        finally
        {
            Debug.PopSender();
        }
    }

    private static void Report(Assembly modAssembly, Exception ex, string describe)
    {
        // Once the mod is on its way out, further exceptions from it (a redirect hit many times before
        // the next tick) add nothing.
        if (ScriptManager.IsUnloadPending(modAssembly))
        {
            return;
        }

        // The first line reaches the on-screen overlay; the stack trace goes to the log only.
        Debug.LogError($"{describe} threw {ex.GetType().Name}: {ex.Message}");
        if (ex.StackTrace is { } trace)
        {
            Debug.Log(trace, skipSender: true);
        }

        ScriptManager.UnloadModOf(modAssembly, describe);
    }
}
