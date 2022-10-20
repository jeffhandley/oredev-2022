using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SessionMatch
{
    internal static class ArgumentNullException
    {
        public static void ThrowIfNullOrEmpty([NotNull] string? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            System.ArgumentNullException.ThrowIfNullOrEmpty(argument, paramName);
        }

        public static void ThrowIfNullOrEmpty([NotNull] string?[]? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            System.ArgumentNullException.ThrowIfNull(argument, paramName);
            if (argument.Length == 0) { throw new System.ArgumentNullException(paramName); }
        }
    }
}
