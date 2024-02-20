using System;

namespace Jcd.RichEnumerations;

/// <summary>
/// A rich enumeration containing Description, Name and Value properties with int as the underlying Value data type. 
/// </summary>
/// <param name="value">The value for the instance. This must be unique.</param>
/// <param name="name">The name for the instance. This should be unique.</param>
/// <param name="description">The description for the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type deriving from NdEnum</typeparam>
public abstract class NdEnum<TEnum>(int value, string name, string description) : NdEnum<int,TEnum>(value, name, description) 
    where TEnum : NdEnum<TEnum>;

/// <summary>
/// A rich enumeration containing Description, Name and Value properties. 
/// </summary>
/// <param name="value">The value for the instance. This must be unique.</param>
/// <param name="name">The name for the instance. This should be unique.</param>
/// <param name="description">The description for the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type deriving from NdEnum</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
public abstract class NdEnum<TValue,TEnum>(TValue value, string name, string description) : Enum<TValue,TEnum>(value) where TValue : IEquatable<TValue>
where TEnum : NdEnum<TValue,TEnum>
{
    #region Constructor and Custom Properties
    
    /// <summary>
    /// The name for the instance. This should be unique.
    /// </summary>
    public string Name { get; } = name;
    
    /// <summary>
    /// The description for the instance. This should be unique.
    /// </summary>
    public string Description { get; } = description;

    #endregion

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"[{Value}] {Name} - {Description}";
    }
}