#region

using System;
using System.Runtime.CompilerServices;

#endregion

namespace Jcd.RichEnumerations.Records;

/// <summary>
/// A rich enum that can be sorted with a call to <c>.Sort()</c>.
/// </summary>
/// <typeparam name="TEnum">The type deriving from SortableEnum{TEnum}</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
public abstract record SortableRichEnumValue<TValue, TEnum>
   : SortableRichEnumBase<TValue, TEnum, TEnum>
   , ISortableValueProvider<TValue>
   , IComparable<TEnum>
   , IComparable<SortableRichEnumValue<TValue, TEnum>>
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnum : SortableRichEnumValue<TValue, TEnum>, ISortableValueProvider<TValue>
{
   /// <summary>
   /// creates an instance of <see cref="SortableRichEnumValue{TValue,TEnum}" />
   /// </summary>
   /// <param name="value">The value of the instance. This must be unique.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected SortableRichEnumValue(TValue value)
   {
      Value = value;
   }

   #region ISortableValueProvider<TValue> Members

   /// <inheritdoc />
   public TValue Value
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;

      protected init;
   }

   #endregion

   /// <summary>
   /// Explicit conversion to the underlying data type.
   /// </summary>
   /// <param name="e">The <see cref="SortableRichEnum{TValue,TEnum}" /> instance.</param>
   /// <returns>The .Value of the <see cref="SortableRichEnum{TValue,TEnum}" /> instance</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator TValue(SortableRichEnumValue<TValue, TEnum> e)
   {
      return e.Value;
   }

   #region Equality and Relational Operations

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public virtual int CompareTo(TEnum other)
   {
      return CompareTo((SortableRichEnumValue<TValue, TEnum>) other);
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public int CompareTo(SortableRichEnumValue<TValue, TEnum>? other)
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
   /// Compares two <see cref="SortableRichEnumValue{TValue,TEnum}" /> instances to determine if the left hand side is less
   /// than
   /// the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is less than the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator <(SortableRichEnumValue<TValue, TEnum>? l, SortableRichEnumValue<TValue, TEnum>? r)
   {
      if (l is null)
      {
         return false;
      }

      return l.CompareTo(r) < 0;
   }

   /// <summary>
   /// Compares two <see cref="SortableRichEnumValue{TValue,TEnum}" /> instances to determine if the left hand side is greater
   /// than the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is greater than the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator >(SortableRichEnumValue<TValue, TEnum>? l, SortableRichEnumValue<TValue, TEnum>? r)
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
   /// Compares two <see cref="SortableRichEnumValue{TValue,TEnum}" /> instances to determine if the left hand side is less
   /// than
   /// or equal to the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is less than or equal to the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator <=(SortableRichEnumValue<TValue, TEnum>? l, SortableRichEnumValue<TValue, TEnum>? r)
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
   /// Compares two <see cref="SortableRichEnumValue{TValue,TEnum}" /> instances to determine if the left hand side is greater
   /// than or equal to the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is greater than or equal to the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator >=(SortableRichEnumValue<TValue, TEnum>? l, SortableRichEnumValue<TValue, TEnum>? r)
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
}