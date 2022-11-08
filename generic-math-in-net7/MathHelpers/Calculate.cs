namespace MathHelpers;

public static partial class Calculate
{
    internal static double Mean(IEnumerable<sbyte> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (sbyte value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<sbyte> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (sbyte value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

    internal static double Mean(IEnumerable<byte> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (byte value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<byte> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (byte value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

    internal static double Mean(IEnumerable<short> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (short value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<short> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (short value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

    internal static double Mean(IEnumerable<ushort> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (ushort value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<ushort> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (ushort value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

    internal static double Mean(IEnumerable<int> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (int value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<int> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (int value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

    internal static double Mean(IEnumerable<uint> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (uint value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<uint> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (uint value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

    internal static double Mean(IEnumerable<long> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (long value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<long> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (long value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

    internal static double Mean(IEnumerable<ulong> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (ulong value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<ulong> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (ulong value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

    internal static double Mean(IEnumerable<nint> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (nint value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<nint> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (nint value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

    internal static double Mean(IEnumerable<nuint> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (nuint value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<nuint> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (nuint value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

    internal static double Mean(IEnumerable<float> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (float value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<float> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (float value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

    internal static double Mean(IEnumerable<double> values)
    {
        int count = values.Count();
        if (count == 0) return 0;

        double sum = 0;

        foreach (double value in values)
        {
            sum += value;
        }

        return sum / count;
    }

    internal static double StandardDeviation(IEnumerable<double> values, bool isSample = true)
    {
        int count = values.Count();
        if (count < 2) return 0;

        double mean = Mean(values);
        double accumulator = 0;

        foreach (double value in values)
        {
            double deviation = value - mean;
            accumulator += deviation * deviation;
        }

        return Math.Sqrt(accumulator / (isSample ? count - 1 : count));
    }

}
