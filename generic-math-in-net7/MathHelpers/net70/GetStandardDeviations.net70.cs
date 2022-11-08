namespace MathHelpers;

internal static partial class Program
{
    internal static IEnumerable<(string, double)> GetStandardDeviationsGeneric()
    {
#if NET7_0_OR_GREATER
        yield return ("sbyte",  Calculate.StandardDeviation<sbyte>(sbytes));
        yield return ("byte",   Calculate.StandardDeviation<byte>(bytes));
        yield return ("short",  Calculate.StandardDeviation<short>(shorts));
        yield return ("ushort", Calculate.StandardDeviation<ushort>(ushorts));
        yield return ("int",    Calculate.StandardDeviation<int>(ints));
        yield return ("uint",   Calculate.StandardDeviation<uint>(uints));
        yield return ("long",   Calculate.StandardDeviation<long>(longs));
        yield return ("ulong",  Calculate.StandardDeviation<ulong>(ulongs));
        yield return ("float",  Calculate.StandardDeviation<float>(floats));
        yield return ("double", Calculate.StandardDeviation<double>(doubles));
#else
        return Enumerable.Empty<(string, double)>();
#endif
    }
}
