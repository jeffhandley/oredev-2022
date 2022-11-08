namespace MathHelpers;

internal static partial class Program
{
    private static readonly sbyte[] sbytes = new sbyte[] { sbyte.MinValue, 0, sbyte.MaxValue };
    private static readonly byte[] bytes = new byte[] { byte.MinValue, 0, byte.MaxValue };
    private static readonly short[] shorts = new short[] { short.MinValue, 0, short.MaxValue };
    private static readonly ushort[] ushorts = new ushort[] { ushort.MinValue, 0, ushort.MaxValue };
    private static readonly int[] ints = new int[] { int.MinValue, 0, int.MaxValue };
    private static readonly uint[] uints = new uint[] { uint.MinValue, 0, uint.MaxValue };
    private static readonly long[] longs = new long[] { long.MinValue, 0, long.MaxValue };
    private static readonly ulong[] ulongs = new ulong[] { ulong.MinValue, 0, ulong.MaxValue };
    private static readonly float[] floats = new float[] { float.MinValue, 0, float.MaxValue };
    private static readonly double[] doubles = new double[] { double.MinValue, 0, double.MaxValue };

    public static void Main()
    {
        ShowResults(GetStandardDeviationsTyped());
        Console.WriteLine(new string('~', 40));

        ShowResults(GetStandardDeviationsGeneric());
        Console.ReadKey();
    }

    public static void ShowResults(IEnumerable<(string Type, double StdDev)> results)
    {
        foreach (var r in results)
        {
            Console.WriteLine($"{r.Type}: {r.StdDev}");
        }
    }
}
