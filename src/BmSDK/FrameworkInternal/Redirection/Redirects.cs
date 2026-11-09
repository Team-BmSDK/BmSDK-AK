using System.Reflection;

namespace BmSDK.Framework.Redirection;

/// <summary>
/// Defines the API contract for any kind of redirect no matter the backing implementation.
/// This is used to generalize global and local redirects when queuing them in
/// <see cref="RedirectManager.AcquireRedirects(GameObject, string)"/>.
/// </summary>
internal interface IGenericRedirect
{
    /// <summary>
    /// Invoker to the actual custom implementation of the redirected function.
    /// </summary>
    MethodInvoker Invoker { get; }

    /// <summary>
    /// Function called from within the UObject::ProcessInternal() context to execute the redirect.
    /// </summary>
    unsafe void Run(GameObject selfObj, Function funcObj, FFrame* stackPtr, IntPtr Result);

    /// <summary>Who to blame in the log when the redirect throws.</summary>
    string SenderName { get; }

    /// <summary>The mod assembly the redirect belongs to; it is unloaded when the redirect throws.</summary>
    Assembly ModAssembly { get; }
}

/// <summary>
/// Record storing data of a currently registered global redirect necessary to execute it.
/// </summary>
/// <param name="TargetType">Type that the redirect applies to</param>
/// <param name="AllowSubtypes">Whether child classes of <paramref name="TargetType"/>
/// should be redirected too</param>
/// <param name="RedirectMethod">Method to call on redirect</param>
/// <param name="SourceAssembly">Mod which registered this redirect</param>
internal sealed record GlobalRedirectorInfo(
    Type TargetType,
    bool AllowSubtypes,
    MethodInfo RedirectMethod,
    Assembly SourceAssembly
) : IGenericRedirect
{
    public MethodInvoker Invoker { get; } = MethodInvoker.Create(RedirectMethod);

    private Type[]? _paramTypes;

    public Type[] GetParamTypes(Function func)
    {
        _paramTypes ??= RedirectMethod
            .GetParameters()
            .Select(param => param.ParameterType)
            .Skip(func.IsStatic ? 0 : 1)
            .ToArray();

        return _paramTypes;
    }

    public unsafe void Run(GameObject selfObj, Function funcObj, FFrame* stackPtr, nint Result) =>
        RedirectManager.Global.ExecuteRedirector(this, selfObj, funcObj, stackPtr, Result);

    public string SenderName => RedirectMethod.DeclaringType?.FullName ?? SourceAssembly.GetName().Name ?? "redirect";

    public Assembly ModAssembly => SourceAssembly;
}

/// <summary>
/// Record storing data of a currently registered local redirect necessary to execute it.
/// </summary>
/// <param name="Component">The ScriptComponent that declares the redirect</param>
/// <param name="RedirectMethod">Method to call on redirect</param>
/// <param name="Invoker">The cached invoker of the redirect method</param>
internal sealed record LocalRedirectorInfo(
    IScriptComponent Component,
    MethodInfo RedirectMethod,
    MethodInvoker Invoker
) : IGenericRedirect
{
    /// <summary>
    /// Gathers managed parameter types using the redirector
    /// </summary>
    public Type[] ParamTypes { get; } =
        RedirectMethod.GetParameters().Select(param => param.ParameterType).ToArray();

    public unsafe void Run(GameObject selfObj, Function funcObj, FFrame* stackPtr, nint Result) =>
        RedirectManager.Local.ExecuteRedirector(this, selfObj, funcObj, stackPtr, Result);

    public string SenderName => Component.GetType().FullName ?? "component redirect";

    public Assembly ModAssembly => Component.GetType().Assembly;
}

/// <summary>
/// Record storing data necessary to register local redirects when a ScriptComponent is attached.
/// This is used to avoid unnecessary repeated reflection.
/// </summary>
/// <param name="TargetType">Type that the redirect applies to</param>
/// <param name="FuncPath">The UE3 declaration path of the method to redirect.
/// If the method is not defined in <see cref="TargetType"/>, path could lead to super.</param>
/// <param name="RedirectMethod">Method to call on redirect</param>
internal readonly record struct CachedLocalRedirector(
    Type TargetType,
    string FuncPath,
    MethodInfo RedirectMethod
)
{
    public MethodInvoker Invoker { get; } = MethodInvoker.Create(RedirectMethod);
}

/// <summary>
/// Record storing the data necessary to call multiple redirectors recursively.
/// Used in <see cref="RedirectManager.ExecuteRedirector(GameObject, Function, string, FFrame*, nint)"/>.
/// </summary>
/// <param name="TargetObj">Object the method is run on</param>
/// <param name="TargetFunc">Method being redirected</param>
/// <param name="Redirs">Each redirect that still exists for the
/// particular call of <paramref name="TargetFunc"/></param>
internal sealed record RedirectCall(
    GameObject TargetObj,
    Function TargetFunc,
    IGenericRedirect[] Redirs
)
{
    private int _currIndex = 0;

    /// <summary>Whether the original function has run for this call (by a redirect, or as the base).</summary>
    public bool OriginalRan;

    public IGenericRedirect? NextRedirect() =>
        _currIndex < Redirs.Length ? Redirs[_currIndex++] : null;

    public unsafe void RunOriginal(FFrame* stackPtr, IntPtr result)
    {
        OriginalRan = true;

        // Copy over args to new buffer for call to original function
        var paramsSize = TargetFunc.GetParamsBytes();

        // 16-aligned like the engine's own parameter frames (natives store SSE returns with movdqa).
        var argsPtr = stackalloc byte[TargetFunc.PropertiesSize + 16];
        argsPtr = (byte*)(((nint)argsPtr + 15) & ~(nint)15);
        Buffer.MemoryCopy(
            stackPtr->Locals.ToPointer(),
            argsPtr,
            paramsSize,
            paramsSize
        );

        // Call the actual target function and not an override
        GameFunctions.ProcessEvent(
            TargetObj.Ptr,
            TargetFunc.Ptr,
            (IntPtr)argsPtr,
            IntPtr.Zero
        );

        // If there is a return value, pass it through
        TargetFunc.ResolveReturn();
        if (TargetFunc.ReturnSize > 0)
        {
            Buffer.MemoryCopy(
                argsPtr + TargetFunc.ReturnOffset,
                result.ToPointer(),
                TargetFunc.ReturnSize,
                TargetFunc.ReturnSize
            );
        }
    }
}
