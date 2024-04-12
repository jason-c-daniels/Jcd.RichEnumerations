#region

using System;
using System.Collections.Generic;
using System.Linq;

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
public class SortableRichEnumBase<TValue, TEnumeration, TEnumeratedItem> : SortableRichEnumBase<TEnumeration, TEnumeratedItem>
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnumeratedItem : IEquatable<TEnumeratedItem>, IComparable<TEnumeratedItem>, ISortableRichEnumValueProvider<TValue>
{
   protected SortableRichEnumBase(){}
   
   private static Dictionary<TValue, TEnumeratedItem>? byValue;

   /// <summary>
   /// A lookup of enumerated elements by their Value property.
   /// Useful for implementing conversion operators.
   /// </summary>
   public static IReadOnlyDictionary<TValue, TEnumeratedItem> ByValue => byValue ??= All.ToDictionary(e => e.Value);


}