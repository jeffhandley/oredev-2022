#if NET7_0_OR_GREATER
using System.Numerics;
namespace MathHelpers;

public static class CalculateGeneric
{
    internal static double StandardDeviation<T>(IEnumerable<T> values, bool isSample = true)
        where T : INumberBase<T>
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (T value in values)
        {
            double deviation = mean - double.CreateChecked(value);
            accumulator += deviation * deviation;
        }

        return double.Sqrt(accumulator / double.CreateChecked(isSample ? count - 1 : count));

        double Mean(IEnumerable<T> values)
        {
            double sum = 0;
            foreach (T value in values) sum += double.CreateChecked(value);

            return sum / double.CreateChecked(count);
        }
    }
}
#endif
