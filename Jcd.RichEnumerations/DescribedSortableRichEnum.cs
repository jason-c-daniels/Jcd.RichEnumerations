using System;

namespace Jcd.RichEnumerations;

#pragma warning disable SA1402 // FileMayOnlyContainASingleType

/// <summary>
/// A SortableRichEnum with a Description property.
/// </summary>
/// <param name="value">The value of the instance. This must be unique.</param>
/// <param name="description">The description of the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableDEnumeration</typeparam>
public abstract class DescribedSortableRichEnum<TEnum>(int value, string description)
    : DescribedSortableRichEnum<int, TEnum>(value, description)
    where TEnum : DescribedSortableRichEnum<TEnum>, IComparable<TEnum>;

/// <summary>
/// A SortableRichEnum with a Description property.
/// </summary>
/// <param name="value">The value of the instance. This must be unique.</param>
/// <param name="description">The description of the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableDEnumeration</typeparam>
/// <typeparam name="TValue">The type of the .Value property</typeparam>
public abstract class DescribedSortableRichEnum<TValue,TEnum>(TValue value, string description) :SortableRichEnum<TValue,TEnum>(value) where TValue : IEquatable<TValue>
    where TEnum : DescribedSortableRichEnum<TValue,TEnum>, IComparable<TEnum>
{
    /// <summary>
    /// The description of the instance.
    /// </summary>
    public string Description { get; } = description;

    /// <inheritdoc />
    public override string ToString()
    {
        return $"[{Value}] {Description}";
    }
}
