namespace Enhanced.Protobuf;

/// <summary>
///     Represents a decimal value with high precision.
/// </summary>
partial class DecimalValue
{
    private const decimal NanoFactor = 1_000_000_000;

    private DecimalValue(long units, int nanos)
    {
        Units = units;
        Nanos = nanos;
    }

    /// <summary>
    ///     Converts a <see cref="DecimalValue" /> to a <see cref="decimal" />.
    /// </summary>
    /// <param name="value">
    ///     The <see cref="DecimalValue" /> to convert.
    /// </param>
    /// <returns>
    ///     The <see cref="decimal" /> value.
    /// </returns>
    public static implicit operator decimal(DecimalValue value) => value.Units + value.Nanos / NanoFactor;

    /// <summary>
    ///     Converts a <see cref="decimal" /> to a <see cref="DecimalValue" />.
    /// </summary>
    /// <param name="value">
    ///     The <see cref="decimal" /> to convert.
    /// </param>
    /// <returns>
    ///     The <see cref="DecimalValue" /> value.
    /// </returns>
    public static implicit operator DecimalValue(decimal value)
    {
        var units = decimal.ToInt64(value);
        var nanos = decimal.ToInt32((value - units) * NanoFactor);
        return new DecimalValue(units, nanos);
    }
}
