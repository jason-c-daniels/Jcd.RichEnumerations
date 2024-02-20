using System;

namespace Jcd.RichEnumerations;

/// <summary>
/// A rich Enum with Name and Description properties. The type of the Value property is int.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
/// <param name="description">The description of the instance. These should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableNdEnum</typeparam>
public abstract class SNdEnum<TEnum>(int value, string name, string description) : SNdEnum<int,TEnum>(value, name, description) 
    where TEnum : SNdEnum<TEnum>, IComparable<TEnum>;

/// <summary>
/// A base rich Enum with Name and Description properties.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
/// <param name="description">The description of the instance. These should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableNdEnum</typeparam>
/// <typeparam name="TValue">The type of the value property.</typeparam>
public abstract class SNdEnum<TValue,TEnum>(TValue value, string name, string description) :
    SEnum<TValue,TEnum>(value) where TValue : IEquatable<TValue>
    where TEnum : SNdEnum<TValue,TEnum>, IComparable<TEnum>
{
    #region Constructor and Custom Properties
    
    /// <summary>
    /// The name of the instance. This should be unique.
    /// </summary>
    public string Name { get; } = name;
    
    /// <summary>
    /// The description of the instance. This should be unique.
    /// </summary>
    public string Description { get; } = description;

    #endregion

    /// <inheritdoc />
    public override string ToString()
    {
        return $"[{Value}] {Name} - {Description}";
    }
}