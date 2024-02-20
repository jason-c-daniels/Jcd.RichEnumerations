using System;

namespace Jcd.RichEnumerations;

#pragma warning disable SA1402 // FileMayOnlyContainASingleType

/// <summary>
/// A SortableRichEnum with a Name property.
/// </summary>
/// <param name="value">The value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableNEnumeration</typeparam>
public abstract class NamedSortableRichEnum<TEnum>(int value, string name) : NamedSortableRichEnum<int, TEnum>(value, name)
    where TEnum : NamedSortableRichEnum<TEnum>, IComparable<TEnum>;

/// <summary>
/// A SortableRichEnum with a Name property.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
public abstract class NamedSortableRichEnum<TValue,TEnum>(TValue value, string name) :SortableRichEnum<TValue,TEnum>(value) where TValue : IEquatable<TValue>
    where TEnum : NamedSortableRichEnum<TValue,TEnum>, IComparable<TEnum>
{
    /// <summary>
    /// The name of the instance. This should be unique.
    /// </summary>
    public string Name { get; } = name;

    /// <inheritdoc />
    public override string ToString()
    {
        return $"[{Value}] {Name}";
    }
}