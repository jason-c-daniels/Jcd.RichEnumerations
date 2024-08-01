#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Classes;

#pragma warning disable S2436

/// <summary>
/// A base for sortable rich enumerations where the .Value property is present on the enumerated type.
/// This type provides a hook to sort the .All collection. <c>.Sort()</c> should be called once and only once during
/// application startup.
/// </summary>
/// <remarks>
/// NOTE: This is intended as a supporting class. Consumers should prefer <see cref="SortableRichEnum{TEnum}" /> or
/// <see cref="SortableRichEnum{TEnum}" /> instead.
/// </remarks>
/// <typeparam name="TValue">
/// The type of the .Value property on the TEnumeratedItem instances. This is used in the
/// conversion operators.
/// </typeparam>
/// <typeparam name="TEnumeration">The type of the enumeration containing the enumerated items</typeparam>
/// <typeparam name="TEnumeratedItem">The type of the enumerated data.</typeparam>
public abstract class SortableRichEnumBase<TValue, TEnumeration, TEnumeratedItem> : SortableRichEnumBase<TEnumeration, TEnumeratedItem>
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnumeratedItem : IEquatable<TEnumeratedItem>, IComparable<TEnumeratedItem>, ISortableValueProvider<TValue>
{
   private static Dictionary<TValue, TEnumeratedItem>? byValue;

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected SortableRichEnumBase()
   {
   }

   /// <summary>
   /// Determines if the passed in value can be converted into the enumerated type.
   /// </summary>
   /// <param name="value"></param>
   /// <returns></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsValid(TValue value)
      => ByValue.ContainsKey(value);

   /// <summary>
   /// A lookup of enumerated elements by their Value property.
   /// Useful for implementing conversion operators.
   /// </summary>
   public static IReadOnlyDictionary<TValue, TEnumeratedItem> ByValue
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get { return byValue ??= All.ToDictionary(e => e.Value); }
   }
}