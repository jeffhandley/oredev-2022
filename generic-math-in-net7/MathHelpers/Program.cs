using System.Numerics;

namespace MathHelpers;

internal static partial class Program
{
    public static void Main()
    {
        var mid = CalculateGeneric.Midpoint<WeirdNumber>();
        Console.WriteLine($"Min: {WeirdNumber.MinValue} | Mid: {mid} | Max: {WeirdNumber.MaxValue}");
        Console.WriteLine($"(Min+Mid): {WeirdNumber.MinValue + mid} | (Max-Mid): {WeirdNumber.MaxValue - mid}");

        Console.ReadKey();
    }

    public static void ShowResults(IEnumerable<(string Type, double StdDev)> results)
    {
        foreach (var r in results)
        {
            Console.WriteLine($"{r.Type}: {r.StdDev}");
        }
    }

    public struct WeirdNumber :
        IMinMaxValue<WeirdNumber>,
        IAdditionOperators<WeirdNumber, WeirdNumber, WeirdNumber>,
        IMultiplicativeIdentity<WeirdNumber, WeirdNumber>,
        IDivisionOperators<WeirdNumber, WeirdNumber, WeirdNumber>,
        IModulusOperators<WeirdNumber, WeirdNumber, WeirdNumber>,
        ISubtractionOperators<WeirdNumber, WeirdNumber, WeirdNumber>
    {
        public static WeirdNumber MinValue { get; } = new WeirdNumber(-10);
        public static WeirdNumber MaxValue { get; } = new WeirdNumber(40);

        public static WeirdNumber MultiplicativeIdentity => new WeirdNumber(1);

        public static WeirdNumber operator +(WeirdNumber left, WeirdNumber right)
        {
            return new WeirdNumber(left.Value + right.Value);
        }

        public static WeirdNumber operator /(WeirdNumber left, WeirdNumber right)
        {
            return new WeirdNumber(left.Value / right.Value);
        }

        public static WeirdNumber operator %(WeirdNumber left, WeirdNumber right)
        {
            return new WeirdNumber(left.Value % right.Value);
        }

        public static WeirdNumber operator -(WeirdNumber left, WeirdNumber right)
        {
            return new WeirdNumber(left.Value - right.Value);
        }

        private int Value { get; init; }
        public WeirdNumber(int num)
        {
            Value = num;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
