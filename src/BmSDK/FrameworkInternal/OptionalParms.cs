using System.Runtime.CompilerServices;

namespace BmSDK.Framework;

/// <summary>
/// Stops UObject::ProcessEvent from freeing optional string/array arguments of script functions
/// before the call runs.
/// </summary>
/// <remarks>
/// ProcessEvent copies the caller's parameters into the call's frame, then evaluates the default
/// value of every optional parameter into the CALLER's buffer (EX_DefaultParmValue with the
/// "evaluate" flag set). For a parameter that owns memory, that assignment frees the value the
/// caller passed, which the frame still points at, so the function reads freed memory (e.g.
/// SplitString's delimiter arrived as one garbage character). The default never reaches the
/// frame anyway, so skipping that pass changes nothing else.
/// <para/>
/// While suspended, the function's optional parameters lose CPF_OptionalParm, so ProcessEvent
/// skips the pass. The script function then meets its default-value block at the top of its body
/// and skips it (EX_DefaultParmValue without the flag jumps over its expression). Only functions
/// where a real default would be assigned over a string, array, map or struct are touched;
/// anything unexpected in the block leaves the function untouched (stock behaviour).
/// <para/>
/// Natives are never touched: their bytecode is the default-value block followed by the reads of
/// their parameters, so skipping the pass would also need their script pointer moved past the
/// block. No native in Batman: Arkham Knight's BmGame package has such a default; three in
/// Engine/IpDrv do (AkDialogue.AllowAnimOnlyDialogue, AkDialogue.NotifySurveillanceDialogue,
/// OnlineSubsystemCommonImpl.StartCustomContentRequest) and keep the stock behaviour.
/// </remarks>
internal static unsafe class OptionalParms
{
    private const int UStruct_ScriptData = 108;
    private const int UStruct_ScriptNum = 116;

    private const byte EX_Nothing = 0x0B;
    private const byte EX_DefaultParmValue = 0x49;

    private sealed class Plan
    {
        public required Property[] Optional;
        public int Depth;
    }

    private static readonly ConditionalWeakTable<Function, Plan?> s_plans = [];

    /// <summary>
    /// Suspends the optional parameters of the script function <paramref name="func"/> for one
    /// call. Pass the result to <see cref="Resume"/> after the call.
    /// </summary>
    public static object? Suspend(Function func)
    {
        var plan = s_plans.GetValue(func, MakePlan);
        if (plan is null)
        {
            return null;
        }

        // A nested call of the same function (made while it runs) finds it already suspended.
        if (plan.Depth++ > 0)
        {
            return plan;
        }

        foreach (var prop in plan.Optional)
        {
            prop.PropertyFlags &= ~Property.EPropertyFlags.CPF_OptionalParm;
        }

        return plan;
    }

    public static void Resume(Function func, object? token)
    {
        if (token is not Plan plan || --plan.Depth > 0)
        {
            return;
        }

        foreach (var prop in plan.Optional)
        {
            prop.PropertyFlags |= Property.EPropertyFlags.CPF_OptionalParm;
        }
    }

    private static Plan? MakePlan(Function func)
    {
        if (func.FunctionFlags.HasFlag(Function.EFunctionFlags.FUNC_Native))
        {
            return null;
        }

        var optional = func.EnumerateParams()
            .Where(p => p.PropertyFlags.HasFlag(Property.EPropertyFlags.CPF_OptionalParm))
            .ToArray();
        if (optional.Length == 0)
        {
            return null;
        }

        // Walk the default-value block exactly as ProcessEvent's pass would: one entry per
        // optional parameter, either EX_Nothing or EX_DefaultParmValue <u16 size> <size bytes>.
        var code = *(byte**)(func.Ptr + UStruct_ScriptData);
        var length = *(int*)(func.Ptr + UStruct_ScriptNum);
        if (code is null || length <= 0)
        {
            return Reject(func, "no bytecode");
        }

        var pos = 0;
        var harmful = false;
        foreach (var prop in optional)
        {
            if (pos >= length)
            {
                return Reject(func, "default-value block runs past the bytecode");
            }

            if (code[pos] == EX_Nothing)
            {
                pos += 1;
            }
            else if (code[pos] == EX_DefaultParmValue && pos + 3 <= length)
            {
                pos += 3 + *(ushort*)(code + pos + 1);

                // Only a real default assigned over a value that owns memory frees anything.
                harmful |= OwnsMemory(prop);
            }
            else
            {
                return Reject(func, $"unexpected opcode 0x{code[pos]:X2} in default-value block");
            }
        }

        if (pos > length)
        {
            return Reject(func, "default-value block runs past the bytecode");
        }

        // Nothing would be freed: leave the call exactly as it was.
        return harmful ? new Plan { Optional = optional } : null;
    }

    /// <summary>
    /// Strings, arrays and maps own memory; a struct may hold one, so it counts too.
    /// </summary>
    private static bool OwnsMemory(Property prop) =>
        prop.Class.Name.ToString() is "StrProperty" or "ArrayProperty" or "MapProperty" or "StructProperty";

    private static Plan? Reject(Function func, string reason)
    {
        Debug.LogWarning(
            $"Optional parameters of {func.GetPathName()} left as is ({reason}); "
                + "optional string/array arguments may be freed before the call runs."
        );
        return null;
    }
}
