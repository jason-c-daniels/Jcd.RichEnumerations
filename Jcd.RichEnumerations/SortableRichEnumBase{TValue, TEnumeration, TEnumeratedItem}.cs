using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
namespace Jcd.RichEnumerations;

/// <summary>
/// A base for sortable rich enumerations where the .Value property is present on the enumerated type.
/// This type provides a hook to sort the .All collection. .Sort should be called only once and only once in the application startup. 
/// </summary>
/// <remarks>
/// NOTE: This is intended as a supporting class. Consumers should prefer <see cref="SortableRichEnum{TEnum}"/> or <see cref="SortableRichEnum{TEnum}"/> instead.
/// </remarks>
/// <typeparam name="TValue">The type of the .Value property on the TEnumeratedItem instances. This is used in the conversion operators.</typeparam>
/// <typeparam name="TEnumeration">The type of the enumeration containing the enumerated items</typeparam>
/// <typeparam name="TEnumeratedItem">The type of the enumerated data.</typeparam>
public abstract class SortableRichEnumBase<TValue, TEnumeration, TEnumeratedItem>
   : SortableRichEnumBase<TEnumeration, TEnumeratedItem>
   where TValue : IEquatable<TValue>
   where TEnumeratedItem : IEquatable<TEnumeratedItem>,
   IComparable<TEnumeratedItem>,
   IRichEnumValueProvider<TValue>
{
   private static Dictionary<TValue, TEnumeratedItem>? byValue;

   /// <summary>
   /// A lookup of enumerated elements by their Value property.
   /// Useful for implementing conversion operators.
   /// </summary>
   protected static IReadOnlyDictionary<TValue, TEnumeratedItem> ByValue => byValue ??= All.ToDictionary(e => e.Value);
}