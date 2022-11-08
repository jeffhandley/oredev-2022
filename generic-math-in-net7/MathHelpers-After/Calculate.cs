using System.Numerics;

namespace MathHelpers;

public static class Calculate
{
    internal static TResult Mean<T, TResult>(IEnumerable<T> values)
        where T : INumberBase<T>
        where TResult : INumberBase<TResult>
    {
        int count = values.Count();
        TResult sum = TResult.Zero;

        if (count > 0)
        {
            foreach (T value in values)
            {
                sum += TResult.CreateChecked(value);
            }
        }

        return sum / TResult.CreateChecked(count);
    }

    internal static TResult StandardDeviation<T, TResult>(IEnumerable<T> values, bool isSample)
        where T : INumberBase<T>
        where TResult : INumberBase<TResult>, IRootFunctions<TResult>
    {
        int count = values.Count();
        if (count < 2) return TResult.Zero;

        TResult mean = Mean<T, TResult>(values);
        TResult accumulator = TResult.Zero;

        foreach (T value in values)
        {
            TResult deviation = mean - TResult.CreateChecked(value);
            accumulator += deviation * deviation;
        }

        return TResult.Sqrt(accumulator / TResult.CreateChecked(isSample ? count - 1 : count));
    }
}
