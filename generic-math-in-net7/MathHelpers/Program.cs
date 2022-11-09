using System.Numerics;

namespace MathHelpers;

internal static partial class Program
{
    public static void Main()
    {
        var results = GetStandardDeviations();
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }

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
