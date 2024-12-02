namespace Enhanced.Protobuf;

internal static class Conversion
{
    private const decimal NanoFactor = 1_000_000_000;

    public static decimal ToDecimalUnsafe(this DecimalValue value)
    {
        return value.Units + value.Nanos / NanoFactor;
    }

    public static DecimalValue ToDecimalValueUnsafe(this decimal value)
    {
        var units = decimal.ToInt64(value);
        var nanos = decimal.ToInt32((value - units) * NanoFactor);
        return new DecimalValue(units, nanos);
    }
}
