using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Jcd.RichEnumerations;

#pragma warning disable SA1402 // FileMayOnlyContainASingleType

/// <summary>
/// Provides access to all instances on the enumeration container by way of the .All property.
/// And allows lookup of items by value. This is used in <see cref="RichEnum{TValue,TEnum}"/> to provide conversion operators.
/// </summary>
/// <remarks>
/// NOTE: This is intended as a supporting class. Consumers should prefer <see cref="RichEnum{TValue,TEnum}"/> or <see cref="RichEnum{TEnum}"/> instead.
/// </remarks>
/// <typeparam name="TValue">The type of the .Value property on the TEnumeratedItem instances. This is used in the conversion operators.</typeparam>
/// <typeparam name="TEnumeration">The type of the enumeration containing the enumerated items</typeparam>
/// <typeparam name="TEnumeratedItem">The type of the enumerated data.</typeparam>
public abstract class RichEnumBase<TValue,TEnumeration,TEnumeratedItem> : RichEnumBase<TEnumeration,TEnumeratedItem>
    where TEnumeratedItem : IEquatable<TEnumeratedItem>, IRichEnumValueProvider<TValue>
    where TValue : IEquatable<TValue>
{
    private static Dictionary<TValue, TEnumeratedItem>? _byValue;
    /// <summary>
    /// A lookup of enumerated elements by their Value property.
    /// Useful for implementing conversion operators.
    /// </summary>
    public static IReadOnlyDictionary<TValue, TEnumeratedItem> ByValue => _byValue ??= All.ToDictionary(e => e.Value);
}

/// <summary>
/// Provides access to all instances on the enumeration container by way of the .All property.
/// </summary>
/// <remarks>
/// NOTE: This is intended as a supporting class. Consumers should prefer <see cref="RichEnum{TValue,TEnum}"/> or <see cref="RichEnum{TEnum}"/> instead.
/// </remarks>
/// <typeparam name="TEnumeration">The type of the enumeration containing the enumerated items</typeparam>
/// <typeparam name="TEnumeratedItem">The type of the enumerated data.</typeparam>
public abstract class RichEnumBase<TEnumeration,TEnumeratedItem>
    where TEnumeratedItem : IEquatable<TEnumeratedItem>
{
    private static List<TEnumeratedItem>? _all;
    
    /// <summary>
    /// All enumerated elements. Populated in static constructor.
    /// </summary>
    public static IReadOnlyList<TEnumeratedItem> All => _all ??= GetAll();

    private static List<TEnumeratedItem> GetAll()
    {
        var fields = typeof(TEnumeration).GetFields(
            BindingFlags.Public
            | BindingFlags.Static
            | BindingFlags.DeclaredOnly
        );

        var props = typeof(TEnumeration).GetProperties(
            BindingFlags.Public
            | BindingFlags.Static
            | BindingFlags.DeclaredOnly
        );

        var all = fields
                .Where(f => f.FieldType == typeof(TEnumeratedItem))
                .Select(f => f.GetValue(null))
                .Cast<TEnumeratedItem>()
                .Concat(
                    props
                        .Where(p => p.PropertyType == typeof(TEnumeratedItem))
                        .Select(p => p.GetValue(null))
                        .Cast<TEnumeratedItem>()
                )
                .ToList()
            ;
        return all;
    }
}