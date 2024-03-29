﻿using System;

// ReSharper disable HeapView.PossibleBoxingAllocation

namespace Jcd.RichEnumerations;

#pragma warning disable SA1402 // FileMayOnlyContainASingleType

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}"/> with TValue set to int.
/// </summary>
/// <typeparam name="TEnum">The enumeration type. This will contain both the structure definition and the enumeration entries as public static readonly fields.</typeparam>
public abstract class RichEnum<TEnum>(int value) : RichEnum<int, TEnum>(value)
   where TEnum : RichEnum<TEnum>;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}"/> with .Value as a user provided type.
/// </summary>
/// <typeparam name="TEnum">The enumeration type. This will contain both the structure definition and the enumeration entries as public static readonly fields.</typeparam>
/// <typeparam name="TValue">The data type for .Value</typeparam>
public abstract class RichEnum<TValue, TEnum>(TValue value) : RichEnumBase<TValue, TEnum, TEnum>
                                                            , IEquatable<TEnum>
                                                            , IRichEnumValueProvider<TValue>
   where TEnum : RichEnum<TValue, TEnum>
   where TValue : IEquatable<TValue>
{
   /// <summary>
   /// The underlying value.
   /// </summary>
   public TValue Value { get; } = value;

   #region Equals,  GetHashCode, and ToString

   /// <inheritdoc />
   public override string ToString() { return Value.ToString(); }

   /// <inheritdoc />
   public override int GetHashCode() { return Value.GetHashCode() ^ GetType().GetHashCode(); }

   /// <inheritdoc />
   public override bool Equals(object? other)
   {
      return other is not null && other.GetType() == GetType() && Equals((TEnum) other);
   }

   /// <summary>
   /// Compares the Value of the current <see cref="RichEnum{TValue,TEnum}"/> instance to the target instance for equality.
   /// </summary>
   /// <param name="other">The other instance to compare to</param>
   /// <returns>True if equivalent.</returns>
   public virtual bool Equals(TEnum? other) { return other is not null && Value.Equals(other.Value); }

   /// <summary>
   /// Compares two <see cref="RichEnum{TValue,TEnum}"/> instances for equality.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if equivalent.</returns>
   public static bool operator ==(RichEnum<TValue, TEnum>? l, RichEnum<TValue, TEnum>? r)
   {
      if (l is null && r is null) return true;  // both null, same value, return true.
      if (l is null || r is null) return false; // only one is null. Return false.

      return l.Equals(r);
   }

   /// <summary>
   /// Compares two <see cref="RichEnum{TValue,TEnum}"/> instances for inequality.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if not equivalent.</returns>
   public static bool operator !=(RichEnum<TValue, TEnum> l, RichEnum<TValue, TEnum> r) { return !(l == r); }

   #endregion

   #region conversion operators

   /// <summary>
   /// Explicit conversion to the underlying data type.
   /// </summary>
   /// <param name="e">The <see cref="RichEnum{TValue,TEnum}"/> instance.</param>
   /// <returns>The .Value of the <see cref="RichEnum{TValue,TEnum}"/> instance</returns>
   public static explicit operator TValue(RichEnum<TValue, TEnum> e) { return e.Value; }

   /// <summary>
   /// Explicit conversion from the underlying data type to an <see cref="RichEnum{TValue,TEnum}"/> instance. This performs a lookup on the known values.
   /// </summary>
   /// <param name="value">The value to convert.</param>
   /// <returns>The instance of the <see cref="RichEnum{TValue,TEnum}"/>, if it exists. Throws an exception, otherwise.</returns>
   /// <exception cref="ArgumentException">If a value not present in the enum is provided.</exception>
   public static explicit operator RichEnum<TValue, TEnum>(TValue value)
   {
      if (ByValue.TryGetValue(value, out var result)) return result;

      throw new ArgumentException($"Cannot convert to {typeof(TEnum)}. Invalid value.", nameof(value));
   }

   #endregion
}