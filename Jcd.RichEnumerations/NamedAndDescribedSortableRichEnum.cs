using System;

namespace Jcd.RichEnumerations;

/// <summary>
/// A SortableRichEnum with Name and Description properties. The type of the Value property is int.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
/// <param name="description">The description of the instance. These should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableNdEnumeration</typeparam>
public abstract class NamedAndDescribedSortableRichEnum<TEnum>(int value, string name, string description) : NamedAndDescribedSortableRichEnum<int,TEnum>(value, name, description) 
    where TEnum : NamedAndDescribedSortableRichEnum<TEnum>, IComparable<TEnum>;

/// <summary>
/// A SortableRichEnum with Name and Description properties.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
/// <param name="description">The description of the instance. These should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableNdEnumeration</typeparam>
/// <typeparam name="TValue">The type of the value property.</typeparam>
public abstract class NamedAndDescribedSortableRichEnum<TValue,TEnum>(TValue value, string name, string description) :
    SortableRichEnum<TValue,TEnum>(value) where TValue : IEquatable<TValue>
    where TEnum : NamedAndDescribedSortableRichEnum<TValue,TEnum>, IComparable<TEnum>
{
    /// <summary>
    /// The name of the instance. This should be unique.
    /// </summary>
    public string Name { get; } = name;
    
    /// <summary>
    /// The description of the instance. This should be unique.
    /// </summary>
    public string Description { get; } = description;

    /// <inheritdoc />
    public override string ToString()
    {
        return $"[{Value}] {Name} - {Description}";
    }
}