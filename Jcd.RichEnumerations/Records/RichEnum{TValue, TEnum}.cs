#region

using System;

#endregion

namespace Jcd.RichEnumerations.Records;

/// <summary>
/// A <see cref="Classes.RichEnum{TValue,TEnum}" /> with .Value as a user provided type.
/// </summary>
/// <typeparam name="TEnum">
/// The enumeration type. This will contain both the structure definition and the enumeration
/// entries as public static readonly fields.
/// </typeparam>
/// <typeparam name="TValue">The data type for .Value</typeparam>
public abstract record RichEnum<TValue, TEnum>
   : RichEnumBase<TValue, TEnum, TEnum>
   , IRichEnumValueProvider<TValue>
   where TEnum : RichEnum<TValue, TEnum>
   where TValue : IEquatable<TValue>
{
   /// <inheritdoc />
   protected RichEnum(TValue value)
      : base(value)
   {
   }

   #region conversion operators

   /// <summary>
   /// Explicit conversion to the underlying data type.
   /// </summary>
   /// <param name="e">The <see cref="Classes.RichEnum{TValue,TEnum}" /> instance.</param>
   /// <returns>The .Value of the <see cref="Classes.RichEnum{TValue,TEnum}" /> instance</returns>
   public static explicit operator TValue(RichEnum<TValue, TEnum> e)
   {
      return e.Value;
   }

   /// <summary>
   /// Explicit conversion from the underlying data type to an <see cref="Classes.RichEnum{TValue,TEnum}" /> instance. This
   /// performs a lookup on the known values.
   /// </summary>
   /// <param name="value">The value to convert.</param>
   /// <returns>
   /// The instance of the <see cref="Classes.RichEnum{TValue,TEnum}" />, if it exists. Throws an exception,
   /// otherwise.
   /// </returns>
   /// <exception cref="ArgumentException">If a value not present in the enum is provided.</exception>
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