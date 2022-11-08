namespace MathHelpers;

internal static partial class Program
{
    public static void Main()
    {
        ShowResults(GetStandardDeviations());
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
