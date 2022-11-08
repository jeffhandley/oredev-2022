namespace MathHelpers;

internal static partial class Program
{
    private static IEnumerable<(string, double)> GetStandardDeviationsTyped()
    {
        yield return ("sbyte",  Calculate.StandardDeviation(sbytes));
        yield return ("byte",   Calculate.StandardDeviation(bytes));
        yield return ("short",  Calculate.StandardDeviation(shorts));
        yield return ("ushort", Calculate.StandardDeviation(sbytes));
        yield return ("int",    Calculate.StandardDeviation(ints));
        yield return ("uint",   Calculate.StandardDeviation(uints));
        yield return ("long",   Calculate.StandardDeviation(longs));
        yield return ("ulong",  Calculate.StandardDeviation(ulongs));
        yield return ("float",  Calculate.StandardDeviation(floats));
        yield return ("double", Calculate.StandardDeviation(doubles));
    }
}
