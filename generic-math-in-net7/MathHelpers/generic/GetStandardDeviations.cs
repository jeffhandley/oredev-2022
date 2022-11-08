using System.Numerics;

namespace MathHelpers;

internal static partial class Program
{
    public static IEnumerable<(string, double)> GetStandardDeviationsGeneric()
    {
        yield return (nameof(SByte), CalculateGeneric.StandardDeviation(sbytes));
        yield return (nameof(Byte), CalculateGeneric.StandardDeviation(bytes));
        yield return (nameof(Int16), CalculateGeneric.StandardDeviation(int16s));
        yield return (nameof(UInt16), CalculateGeneric.StandardDeviation(uint16s));
        yield return (nameof(Int32), CalculateGeneric.StandardDeviation(int32s));
        yield return (nameof(UInt32), CalculateGeneric.StandardDeviation(uint32s));
        yield return (nameof(Int64), CalculateGeneric.StandardDeviation(int64s));
        yield return (nameof(UInt64), CalculateGeneric.StandardDeviation(uint64s));
        yield return (nameof(Single), CalculateGeneric.StandardDeviation(singles));
        yield return (nameof(Double), CalculateGeneric.StandardDeviation(doubles));
        yield return (nameof(Int128), CalculateGeneric.StandardDeviation(int128s));
        yield return (nameof(Half), CalculateGeneric.StandardDeviation(halves));
    }
}
