using System;

namespace Jcd.RichEnumerations;


/// <summary>
/// A rich Enum with a Description property.
/// </summary>
/// <param name="value">The value of the instance. This must be unique.</param>
/// <param name="description">The description of the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableDEnum</typeparam>
public abstract class SdEnum<TEnum>(int value, string description)
    : SdEnum<int, TEnum>(value, description)
    where TEnum : SdEnum<TEnum>, IComparable<TEnum>;

/// <summary>
/// A rich Enum with a Description property.
/// </summary>
/// <param name="value">The value of the instance. This must be unique.</param>
/// <param name="description">The description of the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableDEnum</typeparam>
/// <typeparam name="TValue">The type of the .Value property</typeparam>
public abstract class SdEnum<TValue,TEnum>(TValue value, string description) :SEnum<TValue,TEnum>(value) where TValue : IEquatable<TValue>
    where TEnum : SdEnum<TValue,TEnum>, IComparable<TEnum>
{
    #region Constructor and Custom Properties
    
    /// <summary>
    /// The description of the instance.
    /// </summary>
    public string Description { get; } = description;

    #endregion

    /// <inheritdoc />
    public override string ToString()
    {
        return $"[{Value}] {Description}";
    }
}
