#if NET7_0_OR_GREATER
using System.Numerics;
namespace MathHelpers;

public static partial class Calculate
{
    internal static double Mean<T>(IEnumerable<T> values)
        where T : INumberBase<T>
    {
        int count = values.Count();
        double sum = 0;

        if (count > 0)
        {
            foreach (T value in values)
            {
                sum += double.CreateChecked(value);
            }
        }

        return sum / double.CreateChecked(count);
    }

    internal static double StandardDeviation<T>(IEnumerable<T> values, bool isSample = true)
        where T : INumberBase<T>
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean<T>(values);
        double accumulator = 0;

        foreach (T value in values)
        {
            double deviation = mean - double.CreateChecked(value);
            accumulator += deviation * deviation;
        }

        return double.Sqrt(accumulator / double.CreateChecked(isSample ? count - 1 : count));
    }
}
#endif