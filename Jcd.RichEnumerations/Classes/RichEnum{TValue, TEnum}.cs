#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Classes;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}" /> with Value as a user defined type.
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
public abstract class RichEnum<TValue, TEnum>(TValue value) : RichEnumValue<TValue, TEnum>(value)
   where TEnum : RichEnum<TValue, TEnum>
   where TValue : IEquatable<TValue>
{
   #region conversion operators

   /// <summary>
   /// Explicit conversion from the underlying data type to an <see cref="RichEnum{TValue,TEnum}" /> instance. This
   /// performs a lookup on the known values.
   /// </summary>
   /// <param name="value">The value to convert.</param>
   /// <returns>The instance of the <see cref="RichEnum{TValue,TEnum}" />, if it exists. Throws an exception, otherwise.</returns>
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