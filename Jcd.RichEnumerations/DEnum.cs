using System;

namespace Jcd.RichEnumerations;

/// <summary>
/// A rich Enum with a Description property.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="description">The description for the instance. These should be unique.</param>
/// <typeparam name="TEnum">The type deriving from DEnum</typeparam>
public abstract class DEnum<TEnum>(int value, string description) : DEnum<int, TEnum>(value, description)
    where TEnum : DEnum<TEnum>, IComparable<TEnum>;

/// <summary>
/// A rich Enum with a Description property.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="description">The description for the instance. These should be unique.</param>
public abstract class DEnum<TValue,TEnum>(TValue value, string description) : Enum<TValue,TEnum>(value) where TValue : IEquatable<TValue>
    where TEnum : DEnum<TValue,TEnum>, IComparable<TEnum>
{
    #region Constructor and Custom Properties
    
    /// <summary>
    /// The description for the instance. These should be unique.
    /// </summary>
    public string Description { get; } = description;

    #endregion

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"[{Value}] {Description}";
    }
}