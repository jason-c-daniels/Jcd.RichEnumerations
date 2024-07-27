#region

using System;
using System.Runtime.CompilerServices;

#endregion

namespace Jcd.RichEnumerations.Classes;

/// <summary>
/// A <see cref="RichEnumValue{TValue,TEnum}" /> with Value as a user defined type.
/// </summary>
/// <typeparam name="TEnum">
/// The enumeration type. This will contain both the structure definition and the enumeration
/// entries as public static readonly fields.
/// </typeparam>
/// <typeparam name="TValue">The data type for .Value</typeparam>
/// <example>
/// <code>
/// public class MyRichEnum(float value, string customText) : RichEnum&lt;float,MyRichEnum&gt;(value)
/// {
///      public static readonly MyRichEnum Item1 = new (1.0f, "First Item");
///      public static readonly MyRichEnum Item2 = new (2.1f, "Second Item");
///
///      public string CustomText => customText;
/// }
/// </code>
/// </example>
public class RichEnumValue<TValue, TEnum>(TValue value) : RichEnumBase<TValue, TEnum, TEnum>
                                                        , IEquatable<TEnum>
                                                        , IValueProvider<TValue>
   where TEnum : RichEnumValue<TValue, TEnum>
   where TValue : IEquatable<TValue>
{
   #region IValueProvider<TValue> Members

   /// <summary>
   /// The underlying value.
   /// </summary>
   public TValue Value
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;

      protected init;
   } = value;

   #endregion

   /// <summary>
   /// Explicit conversion to the underlying data type.
   /// </summary>
   /// <param name="e">The <see cref="RichEnum{TValue,TEnum}" /> instance.</param>
   /// <returns>The .Value of the <see cref="RichEnum{TValue,TEnum}" /> instance</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator TValue(RichEnumValue<TValue, TEnum> e)
   {
      return e.Value;
   }

   #region Equals,  GetHashCode, and ToString

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override string ToString()
   {
      return Value.ToString();
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override int GetHashCode()
   {
      return Value.GetHashCode() ^ GetType().GetHashCode();
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override bool Equals(object? obj)
   {
      return obj is not null && obj.GetType() == GetType() && Equals((TEnum) obj);
   }

   /// <summary>
   /// Compares the Value of the current <see cref="RichEnum{TValue,TEnum}" /> instance to the target instance for
   /// equality.
   /// </summary>
   /// <param name="other">The other instance to compare to</param>
   /// <returns>True if equivalent.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public virtual bool Equals(TEnum? other)
   {
      return other is not null && Value.Equals(other.Value);
   }

   /// <summary>
   /// Compares two <see cref="RichEnum{TValue,TEnum}" /> instances for equality.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if equivalent.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator ==(RichEnumValue<TValue, TEnum>? l, RichEnumValue<TValue, TEnum>? r)
   {
      if (l is null && r is null)
      {
         return true; // both null, same value, return true.
      }

      if (l is null || r is null)
      {
         return false; // only one is null. Return false.
      }

      return l.Equals(r);
   }

   /// <summary>
   /// Compares two <see cref="RichEnum{TValue,TEnum}" /> instances for inequality.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if not equivalent.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator !=(RichEnumValue<TValue, TEnum> l, RichEnumValue<TValue, TEnum> r)
   {
      return !(l == r);
   }

   #endregion
}