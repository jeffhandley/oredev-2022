namespace MathHelpers;

internal static partial class Program
{
    public static IEnumerable<(string, double)> GetStandardDeviations()
    {
        yield return (nameof(SByte), Calculate.StandardDeviation(sbytes));
        yield return (nameof(Byte), Calculate.StandardDeviation(bytes));
        yield return (nameof(Int16), Calculate.StandardDeviation(int16s));
        yield return (nameof(UInt16), Calculate.StandardDeviation(uint16s));
        yield return (nameof(Int32), Calculate.StandardDeviation(int32s));
        yield return (nameof(UInt32), Calculate.StandardDeviation(uint32s));
        yield return (nameof(Int64), Calculate.StandardDeviation(int64s));
        yield return (nameof(UInt64), Calculate.StandardDeviation(uint64s));
        yield return (nameof(Single), Calculate.StandardDeviation(singles));
        yield return (nameof(Double), Calculate.StandardDeviation(doubles));
    }
}
