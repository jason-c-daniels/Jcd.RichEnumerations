#region

using System;
using System.Runtime.CompilerServices;

#endregion

namespace Jcd.RichEnumerations.Records;

/// <summary>
/// A <see cref="DomainValue{TValue,TType}" /> is an open set of values which may
/// share an underlying integral data type with others, but need semantic separation,
/// such as database row identifier columns. Using these prevents accidentally using
/// one in place of another.
/// </summary>
/// <typeparam name="TType">The domain specific type.</typeparam>
/// <typeparam name="TValue">The data type for underlying value.</typeparam>
public record DomainValue<TValue, TType>
   : IEquatable<TType>
   , IValueProvider<TValue>
   where TType : DomainValue<TValue, TType>
   where TValue : IEquatable<TValue>
{
   /// <summary>
   /// A <see cref="DomainValue{TValue,TType}" /> is an open set of values which may
   /// share an underlying integral data type with others, but need semantic separation,
   /// such as database row identifier columns. Using these prevents accidentally using
   /// one in place of another.
   /// </summary>
   /// <typeparam name="TType">The domain specific type.</typeparam>
   /// <typeparam name="TValue">The data type for underlying value.</typeparam>
   protected DomainValue(TValue value)
   {
      Value = value;
   }

   #region IValueProvider<TValue> Members

   /// <summary>
   /// The underlying value.
   /// </summary>
   public TValue Value
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   }

   #endregion

   /// <summary>
   /// Explicit conversion to the underlying data type.
   /// </summary>
   /// <param name="e">The <see cref="DomainValue{TValue,TType}" /> instance.</param>
   /// <returns>The .Value of the <see cref="DomainValue{TValue,TType}" /> instance</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator TValue(DomainValue<TValue, TType> e)
   {
      return e.Value;
   }

   #region Equals,  GetHashCode, and ToString

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override int GetHashCode()
   {
      return Value.GetHashCode() ^ GetType().GetHashCode();
   }

   /// <summary>
   /// Compares the Value of the current <see cref="DomainValue{TValue,TType}" /> instance to the target instance for
   /// equality.
   /// </summary>
   /// <param name="other">The other instance to compare to</param>
   /// <returns>True if equivalent.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public virtual bool Equals(TType? other)
   {
      return other is not null && Value.Equals(other.Value);
   }

   #endregion
}