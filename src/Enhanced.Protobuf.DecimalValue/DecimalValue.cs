namespace Enhanced.Protobuf;

/// <summary>
///     Represents a decimal value with high precision.
/// </summary>
partial class DecimalValue
{
    internal DecimalValue(long units, int nanos)
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
    public static implicit operator decimal(DecimalValue? value)
    {
        if (value is null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        return value.ToDecimalUnsafe();
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
    public static implicit operator decimal?(DecimalValue? value)
    {
        return value?.ToDecimalUnsafe();
    }

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
        return value.ToDecimalValueUnsafe();
    }

    /// <summary>
    ///     Converts a <see cref="decimal" /> to a <see cref="DecimalValue" />.
    /// </summary>
    /// <param name="value">
    ///     The <see cref="decimal" /> to convert.
    /// </param>
    /// <returns>
    ///     The <see cref="DecimalValue" /> value.
    /// </returns>
    public static implicit operator DecimalValue?(decimal? value)
    {
        return value?.ToDecimalValueUnsafe();
    }
}
