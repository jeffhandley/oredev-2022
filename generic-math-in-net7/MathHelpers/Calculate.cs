namespace MathHelpers;

public static class Calculate
{
    internal static double StandardDeviation(IEnumerable<sbyte> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double accumulator = 0;

        foreach (var value in values)
        {
            double deviation = value - Mean(values);
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));

        double Mean(IEnumerable<sbyte> values)
        {
            double sum = 0;
            foreach (var value in values) sum += value;
            return sum / count;
        }
    }

    internal static double StandardDeviation(IEnumerable<byte> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double accumulator = 0;

        foreach (var value in values)
        {
            double deviation = value - Mean(values);
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));

        double Mean(IEnumerable<byte> values)
        {
            double sum = 0;
            foreach (var value in values) sum += value;
            return sum / count;
        }
    }

    internal static double StandardDeviation(IEnumerable<short> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double accumulator = 0;

        foreach (var value in values)
        {
            double deviation = value - Mean(values);
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));

        double Mean(IEnumerable<short> values)
        {
            double sum = 0;
            foreach (var value in values) sum += value;
            return sum / count;
        }
    }

    internal static double StandardDeviation(IEnumerable<ushort> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double accumulator = 0;

        foreach (var value in values)
        {
            double deviation = value - Mean(values);
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));

        double Mean(IEnumerable<ushort> values)
        {
            double sum = 0;
            foreach (var value in values) sum += value;
            return sum / count;
        }
    }

    internal static double StandardDeviation(IEnumerable<int> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double accumulator = 0;

        foreach (var value in values)
        {
            double deviation = value - Mean(values);
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));

        double Mean(IEnumerable<int> values)
        {
            double sum = 0;
            foreach (var value in values) sum += value;
            return sum / count;
        }
    }

    internal static double StandardDeviation(IEnumerable<uint> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double accumulator = 0;

        foreach (var value in values)
        {
            double deviation = value - Mean(values);
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));

        double Mean(IEnumerable<uint> values)
        {
            double sum = 0;
            foreach (var value in values) sum += value;
            return sum / count;
        }
    }

    internal static double StandardDeviation(IEnumerable<long> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double accumulator = 0;

        foreach (var value in values)
        {
            double deviation = value - Mean(values);
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));

        double Mean(IEnumerable<long> values)
        {
            double sum = 0;
            foreach (var value in values) sum += value;
            return sum / count;
        }
    }

    internal static double StandardDeviation(IEnumerable<ulong> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double accumulator = 0;

        foreach (var value in values)
        {
            double deviation = value - Mean(values);
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));

        double Mean(IEnumerable<ulong> values)
        {
            double sum = 0;
            foreach (var value in values) sum += value;
            return sum / count;
        }
    }

    internal static double StandardDeviation(IEnumerable<float> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double accumulator = 0;

        foreach (var value in values)
        {
            double deviation = value - Mean(values);
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));

        double Mean(IEnumerable<float> values)
        {
            double sum = 0;
            foreach (var value in values) sum += value;
            return sum / count;
        }
    }

    internal static double StandardDeviation(IEnumerable<double> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double accumulator = 0;

        foreach (var value in values)
        {
            double deviation = value - Mean(values);
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));

        double Mean(IEnumerable<double> values)
        {
            double sum = 0;
            foreach (var value in values) sum += value;
            return sum / count;
        }
    }
}