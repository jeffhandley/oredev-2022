using System.Numerics;

namespace MathHelpers;

internal static class CalculateGeneric
{
    internal static double StandardDeviation<T>(IEnumerable<T> values, bool isSample = true)
        where T : INumber<T>
    {
        int count = values.Count();
        if (count < 2) return 0;

        double accumulator = 0;

        foreach (var value in values)
        {
            double deviation = double.CreateChecked(value) - Mean(values);
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));

        double Mean(IEnumerable<T> values)
        {
            double sum = 0;
            foreach (var value in values) sum += double.CreateChecked(value);
            return sum / count;
        }
    }

    internal static T Midpoint<T>() where T :
        IMinMaxValue<T>,
        IMultiplicativeIdentity<T, T>,
        IAdditionOperators<T, T, T>,
        IDivisionOperators<T, T, T>,
        IModulusOperators<T, T, T>
    {
        var two = T.MultiplicativeIdentity + T.MultiplicativeIdentity;

        var halfMin = T.MinValue / two;
        var halfMax = T.MaxValue / two;
        var mods = ((T.MinValue % two) + (T.MaxValue % two) / two);

        return halfMax + halfMin + mods;
    }
}
