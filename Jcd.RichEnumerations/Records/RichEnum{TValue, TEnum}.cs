#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}" /> with .Value as a user defined type.
/// </summary>
/// <typeparam name="TEnum">
/// The enumeration type. This will contain both the structure definition and the enumeration
/// entries as public static readonly fields.
/// </typeparam>
/// <typeparam name="TValue">The data type for .Value</typeparam>
public record RichEnum<TValue, TEnum>
   : RichEnumValue<TValue, TEnum>
   where TEnum : RichEnum<TValue, TEnum>
   where TValue : IEquatable<TValue>
{
   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected RichEnum(TValue value) : base(value)
   {
   }

   #region conversion operators


   /// <summary>
   /// Explicit conversion from the underlying data type to an <see cref="RichEnum{TValue,TEnum}" /> instance. This
   /// performs a lookup on the known values.
   /// </summary>
   /// <param name="value">The value to convert.</param>
   /// <returns>
   /// The instance of the <see cref="RichEnum{TValue,TEnum}" />, if it exists. Throws an exception,
   /// otherwise.
   /// </returns>
   /// <exception cref="ArgumentException">If a value not present in the enum is provided.</exception>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator RichEnum<TValue, TEnum>(TValue value)
   {
      if (ByValue.TryGetValue(value, out var result))
      {
         return result;
      }

      throw new ArgumentException($"Cannot convert to {typeof(TEnum)}. Invalid value.", nameof(value));
   }

   #endregion
}
