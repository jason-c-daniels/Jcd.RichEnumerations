using System;
using System.Collections.Generic;
using System.Linq;

namespace Jcd.RichEnumerations;

/// <summary>
/// A base for sortable rich enumerations where the .Value property is present on the enumerated type.
/// This type provides a hook to sort the .All collection. .Sort should be called only once and only once in the application startup. 
/// </summary>
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
    private static Dictionary<TValue, TEnumeratedItem>? _byValue;
    
    /// <summary>
    /// A lookup of enumerated elements by their Value property.
    /// Useful for implementing conversion operators.
    /// </summary>
    protected static IReadOnlyDictionary<TValue, TEnumeratedItem> ByValue => _byValue ??= All.ToDictionary(e => e.Value);
}

/// <summary>
/// A base for sortable rich enumerations. This type provides a hook to sort the .All collection.
/// .Sort should be called only once and only once in the application startup. 
/// </summary>
/// <typeparam name="TEnumeration">The type of the enumeration containing the enumerated items</typeparam>
/// <typeparam name="TEnumeratedItem">The type of the enumerated data.</typeparam>
public abstract class SortableRichEnumBase<TEnumeration, TEnumeratedItem>
    : RichEnumBase<TEnumeration, TEnumeratedItem>
    where TEnumeratedItem : IEquatable<TEnumeratedItem>, IComparable<TEnumeratedItem>
{
    /// <summary>
    /// Sorts the .All collection. This should be called only once and only once in the application startup.
    /// </summary>
    /// <param name="comparison">An optional custom comparer</param>
    public static void Sort(IComparer<TEnumeratedItem>? comparison = null)
    {
        var all = ((List<TEnumeratedItem>)All);
        if (comparison != null) all.Sort(comparison);
        else all.Sort();
    }
}
