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
public abstract record SortableRichEnum<TValue, TEnum> : SortableRichEnumValue<TValue, TEnum>
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnum : SortableRichEnum<TValue, TEnum>, ISortableValueProvider<TValue>
{
   /// <summary>
   /// creates an instance of <see cref="SortableRichEnum{TValue,TEnum}" />
   /// </summary>
   /// <param name="value">The value of the instance. This must be unique.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected SortableRichEnum(TValue value)
      : base(value)
   {
      Value = value;
   }

   #region conversion operators

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
      if (IsValid(value))
      {
         return ByValue[value];
      }

      throw new ArgumentException($"Cannot convert to {typeof(TEnum)}. Invalid value.", nameof(value));
   }

   #endregion
}