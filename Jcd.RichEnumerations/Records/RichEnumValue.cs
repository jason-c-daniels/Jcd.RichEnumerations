#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records;

/// <summary>
/// A <see cref="RichEnumValue{TValue,TEnum}" /> with .Value as a user defined type.
/// </summary>
/// <typeparam name="TEnum">
/// The enumeration type. This will contain both the structure definition and the enumeration
/// entries as public static readonly fields.
/// </typeparam>
/// <typeparam name="TValue">The data type for .Value</typeparam>
public record RichEnumValue<TValue, TEnum>
   : RichEnumBase<TValue, TEnum, TEnum>
   , IRichEnumValueProvider<TValue>
   where TEnum : RichEnumValue<TValue, TEnum>
   where TValue : IEquatable<TValue>
{
   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected RichEnumValue(TValue value)
   {
      Value = value;
   }

   #region IRichEnumValueProvider<TValue> Members

   /// <summary>
   /// The underlying value.
   /// </summary>
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
   /// <param name="e">The <see cref="RichEnum{TValue,TEnum}" /> instance.</param>
   /// <returns>The .Value of the <see cref="RichEnum{TValue,TEnum}" /> instance</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator TValue(RichEnumValue<TValue, TEnum> e)
   {
      return e.Value;
   }
}