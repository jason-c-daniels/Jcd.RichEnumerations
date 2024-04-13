#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records;

/// <summary>
/// A rich enum that can be sorted with a call to <c>.Sort()</c>.
/// </summary>
/// <typeparam name="TEnum">The type deriving from SortableEnum{TEnum}</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
public record SortableRichEnum<TValue, TEnum>
   : SortableRichEnumBase<TValue, TEnum, TEnum>
   , ISortableRichEnumValueProvider<TValue>
   , IComparable<TEnum>
   , IComparable<SortableRichEnum<TValue, TEnum>>
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnum : SortableRichEnum<TValue, TEnum>, ISortableRichEnumValueProvider<TValue>
{
   /// <summary>
   /// creates an instance of <see cref="SortableRichEnum{TValue,TEnum}" />
   /// </summary>
   /// <param name="value">The value of the instance. This must be unique.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected SortableRichEnum(TValue value)
   {
      Value = value;
   }

   #region ISortableRichEnumValueProvider<TValue> Members

   /// <inheritdoc />
   public TValue Value
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   }

   #endregion

   #region Equality and Relational Operations

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public virtual int CompareTo(TEnum other)
   {
      return CompareTo((SortableRichEnum<TValue, TEnum>) other);
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public int CompareTo(SortableRichEnum<TValue, TEnum>? other)
   {
      if (other == null)
      {
         return -1;
      }

      if (other.GetType() != GetType())
      {
         return -1;
      }

      return Value.CompareTo(other.Value);
   }

   /// <summary>
   /// Compares two <see cref="SortableRichEnum{TValue,TEnum}" /> instances to determine if the left hand side is less than
   /// the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is less than the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator <(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
   {
      if (l is null)
      {
         return false;
      }

      return l.CompareTo(r) < 0;
   }

   /// <summary>
   /// Compares two <see cref="SortableRichEnum{TValue,TEnum}" /> instances to determine if the left hand side is greater
   /// than the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is greater than the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator >(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
   {
      if (l is null && r is null)
      {
         return false;
      }

      if (l is not null)
      {
         return l.CompareTo(r) > 0;
      }

      return true;
   }

   /// <summary>
   /// Compares two <see cref="SortableRichEnum{TValue,TEnum}" /> instances to determine if the left hand side is less than
   /// or equal to the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is less than or equal to the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator <=(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
   {
      if (l is null && r is null)
      {
         return true;
      }

      if (l is null)
      {
         return false;
      }

      return l.CompareTo(r) <= 0;
   }

   /// <summary>
   /// Compares two <see cref="SortableRichEnum{TValue,TEnum}" /> instances to determine if the left hand side is greater
   /// than or equal to the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is greater than or equal to the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator >=(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
   {
      if (l is null && r is null)
      {
         return true;
      }

      if (l is not null)
      {
         return l.CompareTo(r) >= 0;
      }

      return true;
   }

   #endregion

   #region conversion operators

   /// <summary>
   /// Explicit conversion to the underlying data type.
   /// </summary>
   /// <param name="e">The <see cref="SortableRichEnum{TValue,TEnum}" /> instance.</param>
   /// <returns>The .Value of the <see cref="SortableRichEnum{TValue,TEnum}" /> instance</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator TValue(SortableRichEnum<TValue, TEnum> e)
   {
      return e.Value;
   }

   /// <summary>
   /// Explicit conversion from the underlying data type to an <see cref="SortableRichEnum{TValue,TEnum}" />
   /// instance. This performs a lookup on the known values.
   /// </summary>
   /// <param name="value">The value to convert.</param>
   /// <returns>
   /// The instance of the <see cref="SortableRichEnum{TValue,TEnum}" />, if it exists.
   /// Throws an exception, otherwise.
   /// </returns>
   /// <exception cref="ArgumentException">If a value not present in the enum is provided.</exception>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator SortableRichEnum<TValue, TEnum>(TValue value)
   {
      if (ByValue.TryGetValue(value, out var result))
      {
         return result;
      }

      throw new ArgumentException($"Cannot convert to {typeof(TEnum)}. Invalid value.", nameof(value));
   }

   #endregion
}