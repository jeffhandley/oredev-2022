#if NET7_0_OR_GREATER
namespace MathHelpers;

internal static partial class Program
{
    public static Int128[] int128s = new Int128[] { Int128.MinValue, 0, Int128.MaxValue };
    public static UInt128[] uint128s = new UInt128[] { UInt128.MinValue, 0, UInt128.MaxValue };
}
#endif
