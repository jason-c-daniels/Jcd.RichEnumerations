using System;

namespace Jcd.RichEnumerations;

/// <summary>
/// A rich Enum with .Value as an int.
/// </summary>
/// <typeparam name="TEnum">The enumeration type. This will contain both the structure definition and the enumeration entries as public static readonly fields.</typeparam>
public abstract class Enum<TEnum>(int value) : Enum<int, TEnum>(value)
    where TEnum : Enum<TEnum>;

/// <summary>
/// A rich Enum with .Value as a user provided type.
/// </summary>
/// <typeparam name="TEnum">The enumeration type. This will contain both the structure definition and the enumeration entries as public static readonly fields.</typeparam>
/// <typeparam name="TValue">The data type for .Value</typeparam>
public abstract class Enum<TValue, TEnum>(TValue value) : EnumBase<TValue, TEnum, TEnum>,
    IEquatable<TEnum>, 
    IEnumValueProvider<TValue>
    where TEnum : Enum<TValue, TEnum> 
    where TValue : IEquatable<TValue>
{
    /// <summary>
    /// The underlying value.
    /// </summary>
    public TValue Value { get; } = value;

    #region Equals,  GetHashCode, and ToString

    /// <inheritdoc />
    public override string ToString()
    {
        return Value.ToString();
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return Value.GetHashCode() ^ GetType().GetHashCode();
    }
    
    /// <inheritdoc />
    public override bool Equals(object? other)
    {
        if (other == null) return false;
        if (other.GetType() != GetType()) return false;
        return Equals((TEnum)other);
    }
    
    /// <summary>
    /// Compares the Value of the current Enum instance to the target instance for equality.
    /// </summary>
    /// <param name="other">The other instance to compare to</param>
    /// <returns>True if equivalent.</returns>
    public bool Equals(TEnum? other)
    {
        if (other == null) return false;
        return Value.Equals(other.Value);
    }

    /// <summary>
    /// Compares two Enum instances for equality.
    /// </summary>
    /// <param name="l">the left hand side of the comparison.</param>
    /// <param name="r">the right hand side of the comparison.</param>
    /// <returns>True if equivalent.</returns>
    public static bool operator ==(Enum<TValue, TEnum>? l, Enum<TValue, TEnum>? r)
    {
        if (l is null && r is null) return true; // both null, same value, return true.
        if (l is null || r is null) return false; // only one is null. Return false.
        return l.Equals(r);
    }
    
    /// <summary>
    /// Compares two Enum instances for inequality.
    /// </summary>
    /// <param name="l">the left hand side of the comparison.</param>
    /// <param name="r">the right hand side of the comparison.</param>
    /// <returns>True if not equivalent.</returns>
    public static bool operator !=(Enum<TValue, TEnum> l, Enum<TValue, TEnum> r)
    {
        return !(l == r);
    }
    
    #endregion
    
    #region conversion operators
    
    /// <summary>
    /// Explicit conversion to the underlying data type.
    /// </summary>
    /// <param name="e">The Enum instance.</param>
    /// <returns>The .Value of the Enum instance</returns>
    public static explicit operator TValue(Enum<TValue, TEnum> e) => e.Value;

    /// <summary>
    /// Explicit conversion from the underlying data type to an Enum instance. This performs a lookup on the known values.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The instance of the Enum, if it exists. Throws an exception, otherwise.</returns>
    /// <exception cref="ArgumentException">If a value not present in the enum is provided.</exception>
    public static explicit operator Enum<TValue, TEnum>(TValue value)
    {
        if (ByValue.TryGetValue(value, out var result)) return result;
        throw new ArgumentException($"Cannot convert to {typeof(TEnum)}. Invalid value.", nameof(value));
    }    
    #endregion
}