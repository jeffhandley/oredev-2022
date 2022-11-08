#if NET7_0_OR_GREATER
namespace MathHelpers;

internal static partial class Program
{
    public static IEnumerable<(string, double)> GetStandardDeviationsGeneric()
    {
        yield return (nameof(SByte),    CalculateGeneric.StandardDeviation<SByte>(sbytes));
        yield return (nameof(Byte),     CalculateGeneric.StandardDeviation<Byte>(bytes));
        yield return (nameof(Int16),    CalculateGeneric.StandardDeviation<Int16>(int16s));
        yield return (nameof(UInt16),   CalculateGeneric.StandardDeviation<UInt16>(uint16s));
        yield return (nameof(Int32),    CalculateGeneric.StandardDeviation<Int32>(int32s));
        yield return (nameof(UInt32),   CalculateGeneric.StandardDeviation<UInt32>(uint32s));
        yield return (nameof(Int64),    CalculateGeneric.StandardDeviation<Int64>(int64s));
        yield return (nameof(UInt64),   CalculateGeneric.StandardDeviation<UInt64>(uint64s));
        yield return (nameof(Int128),   CalculateGeneric.StandardDeviation<Int128>(int128s));
        yield return (nameof(UInt128),  CalculateGeneric.StandardDeviation<UInt128>(uint128s));
        yield return (nameof(Single),   CalculateGeneric.StandardDeviation<Single>(singles));
        yield return (nameof(Double),   CalculateGeneric.StandardDeviation<Double>(doubles));
    }
}
#endif