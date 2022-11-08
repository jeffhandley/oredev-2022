namespace MathHelpers;

internal static class Program
{
    public static void Main(string[] args)
    {
        bool isSample = false;

        if (args[0] == "sample")
        {
            isSample = true;
            args = args[1..];
        }

        Console.WriteLine(StandardDeviation(args[0], args[1..], isSample));
    }

    private static double StandardDeviation(string type, string[] valueArgs, bool isSample) => type switch
    {
        "sbyte" => Calculate.StandardDeviation<sbyte, double>(valueArgs.Select(sbyte.Parse).Cast<sbyte>(), isSample),
        "byte" => Calculate.StandardDeviation<byte, double>(valueArgs.Select(byte.Parse).Cast<byte>(), isSample),
        "short" => Calculate.StandardDeviation<short, double>(valueArgs.Select(short.Parse).Cast<short>(), isSample),
        "ushort" => Calculate.StandardDeviation<ushort, double>(valueArgs.Select(ushort.Parse).Cast<ushort>(), isSample),
        "int" => Calculate.StandardDeviation<int, double>(valueArgs.Select(int.Parse).Cast<int>(), isSample),
        "uint" => Calculate.StandardDeviation<uint, double>(valueArgs.Select(uint.Parse).Cast<uint>(), isSample),
        "long" => Calculate.StandardDeviation<long, double>(valueArgs.Select(long.Parse).Cast<long>(), isSample),
        "ulong" => Calculate.StandardDeviation<ulong, double>(valueArgs.Select(ulong.Parse).Cast<ulong>(), isSample),
        "nint" => Calculate.StandardDeviation<nint, double>(valueArgs.Select(nint.Parse).Cast<nint>(), isSample),
        "nuint" => Calculate.StandardDeviation<nuint, double>(valueArgs.Select(nuint.Parse).Cast<nuint>(), isSample),
        "float" => Calculate.StandardDeviation<float, double>(valueArgs.Select(Single.Parse).Cast<float>(), isSample),
        "double" => Calculate.StandardDeviation<double, double>(valueArgs.Select(Double.Parse).Cast<double>(), isSample),
        _ => throw new NotSupportedException($"The specified type is not supported: {type}"),
    };
}
