using System;

namespace Jcd.RichEnumerations;

/// <summary>
/// A rich Enum that's sortable with a Name property.
/// </summary>
/// <param name="value">The value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableNEnum</typeparam>
public abstract class SnEnum<TEnum>(int value, string name) : SnEnum<int, TEnum>(value, name)
    where TEnum : SnEnum<TEnum>, IComparable<TEnum>;

/// <summary>
/// A rich Enum that's sortable with a Name property.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
public abstract class SnEnum<TValue,TEnum>(TValue value, string name) :SEnum<TValue,TEnum>(value) where TValue : IEquatable<TValue>
    where TEnum : SnEnum<TValue,TEnum>, IComparable<TEnum>
{
    #region Constructor and Custom Properties
    
    /// <summary>
    /// The name of the instance. This should be unique.
    /// </summary>
    public string Name { get; } = name;

    #endregion

    /// <inheritdoc />
    public override string ToString()
    {
        return $"[{Value}] {Name}";
    }
}