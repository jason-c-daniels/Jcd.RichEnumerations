#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Classes;

/// <summary>
/// A base for sortable rich enumerations. This type provides a hook to sort the <see cref="RichEnum{TValue,TEnum}" />
/// <c>.All</c> collection.
/// <c>.Sort()</c> should be called once and only once during application startup.
/// </summary>
/// <param name="value">The value of the instance. This must be unique.</param>
/// <typeparam name="TEnum">The type deriving from SortableEnum{TEnum}</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
/// <example>
/// <code>
/// public class MySortableRichEnum(float value, string customText) : SortableRichEnum&lt;float,MySortableRichEnum&gt;(value)
/// {
///      public static readonly MySortableRichEnum Item1 = new (0.1f, "First Item");
///      public static readonly MySortableRichEnum Item2 = new (-0.1f, "Second Item");
///
///      public string CustomText => customText;
/// }
///
/// class Program
/// {
///    public void Main()
///    {
///       // Call Sort() during app startup.
///
///       // This sorts numerically, ascending.
///       MySortableRichEnum.Sort();
///
///       // This sorts numerically, descending.
///       MySortableRichEnum.Sort((x,y) => y.Value.CompareTo(x.Value));
///    }
/// }
/// </code>
/// </example>
public class SortableRichEnum<TValue, TEnum>(TValue value) : SortableRichEnumValue<TValue, TEnum>(value)
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnum : SortableRichEnum<TValue, TEnum>, ISortableValueProvider<TValue>
{
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
      if (ByValue.TryGetValue(value, out var result))
      {
         return result;
      }

      throw new ArgumentException($"Cannot convert to {typeof(TEnum)}. Invalid value.", nameof(value));
   }

   #endregion
}