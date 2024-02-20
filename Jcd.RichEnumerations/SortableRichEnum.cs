using System;

namespace Jcd.RichEnumerations;

#pragma warning disable SA1402 // FileMayOnlyContainASingleType

/// <summary>
/// A rich enum that can be sorted with a call to .Sort.
/// </summary>
/// <param name="value">The value of the instance. This must be unique.</param>
/// <typeparam name="TEnum">The type deriving from SortableEnum{TEnum}</typeparam>
public abstract class SortableRichEnum<TEnum>(int value) : SortableRichEnum<int, TEnum>(value)
    where TEnum : SortableRichEnum<TEnum>;

/// <summary>
/// A rich enum that can be sorted with a call to .Sort.
/// </summary>
/// <param name="value">The value of the instance. This must be unique.</param>
/// <typeparam name="TEnum">The type deriving from SortableEnum{TEnum}</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
public abstract class SortableRichEnum<TValue, TEnum>(TValue value) :
    SortableRichEnumBase<TValue, TEnum, TEnum>,
    IEquatable<TEnum>,
    IRichEnumValueProvider<TValue>,
    IComparable<TEnum>,
    IComparable<SortableRichEnum<TValue, TEnum>>
    where TValue : IEquatable<TValue>
    where TEnum : SortableRichEnum<TValue, TEnum> 
{
    /// <summary>
    /// The underlying value.
    /// </summary>
    public TValue Value { get; } = value;

    #region Equality, Relational, GetHashCode, and ToString

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
        if (other.GetType() != GetType()) return false;
        return Value.Equals(other.Value);
    }
    
    /// <inheritdoc />
    public abstract int CompareTo(TEnum other);

    /// <inheritdoc />
    public int CompareTo(SortableRichEnum<TValue, TEnum>? other)
    {
        if (other == null) return -1;
        if (other.GetType() != GetType()) return -1;
        return this.CompareTo((TEnum)other);
    }

    /// <summary>
    /// Compares two Enum instances for equality.
    /// </summary>
    /// <param name="l">the left hand side of the comparison.</param>
    /// <param name="r">the right hand side of the comparison.</param>
    /// <returns>True if equivalent.</returns>
    public static bool operator ==(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
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
    public static bool operator !=(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
    {
        return !(l == r);
    }

    /// <summary>
    /// Compares two SEnum instances to determine if the left hand side is less than the right hand side.
    /// </summary>
    /// <param name="l">the left hand side of the comparison.</param>
    /// <param name="r">the right hand side of the comparison.</param>
    /// <returns>True if the left hand side is less than the right hand side.</returns>
    public static bool operator <(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
    {
        if (l is null || r is null) return false;
        return l.CompareTo(r) < 0;
    }

    /// <summary>
    /// Compares two SEnum instances to determine if the left hand side is greater than the right hand side.
    /// </summary>
    /// <param name="l">the left hand side of the comparison.</param>
    /// <param name="r">the right hand side of the comparison.</param>
    /// <returns>True if the left hand side is greater than the right hand side.</returns>
    public static bool operator >(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
    {
        if (l is null || r is null) return false;
        return l.CompareTo(r) > 0;
    }
    
    /// <summary>
    /// Compares two SEnum instances to determine if the left hand side is less than or equal to the right hand side.
    /// </summary>
    /// <param name="l">the left hand side of the comparison.</param>
    /// <param name="r">the right hand side of the comparison.</param>
    /// <returns>True if the left hand side is less than or equal to the right hand side.</returns>
    public static bool operator <=(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
    {
        if (l is null && r is null) return true;
        if (l is null || r is null) return false;
        return l.CompareTo(r) <= 0;
    }

    /// <summary>
    /// Compares two SEnum instances to determine if the left hand side is greater than or equal to the right hand side.
    /// </summary>
    /// <param name="l">the left hand side of the comparison.</param>
    /// <param name="r">the right hand side of the comparison.</param>
    /// <returns>True if the left hand side is greater than or equal to the right hand side.</returns>
    public static bool operator >=(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
    {
        if (l is null && r is null) return true;
        if (l is null || r is null) return false;
        return l.CompareTo(r) >= 0;
    }
    
    #endregion

    #region conversion operators
    
    /// <summary>
    /// Explicit conversion to the underlying data type.
    /// </summary>
    /// <param name="e">The Enum instance.</param>
    /// <returns>The .Value of the Enum instance</returns>
    public static explicit operator TValue(SortableRichEnum<TValue, TEnum> e) => e.Value;

    /// <summary>
    /// Explicit conversion from the underlying data type to an Enum instance. This performs a lookup on the known values.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The instance of the Enum, if it exists. Throws an exception, otherwise.</returns>
    /// <exception cref="ArgumentException">If a value not present in the enum is provided.</exception>
    public static explicit operator SortableRichEnum<TValue, TEnum>(TValue value)
    {
        if (ByValue.TryGetValue(value, out var result)) return result;
        throw new ArgumentException($"Cannot convert to {typeof(TEnum)}. Invalid value.", nameof(value));
    }    
    #endregion
}