namespace System.Runtime.CompilerServices
{
    using System;

    /// <summary>
    /// Attribute required for extension methods for NETMF 4.1
    /// </summary>
    /// <remarks>
    /// v4.2 comes with support for extension methods.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class ExtensionAttribute : Attribute { }
}
