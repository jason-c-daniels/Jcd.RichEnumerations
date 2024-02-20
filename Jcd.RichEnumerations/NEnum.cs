using System;

namespace Jcd.RichEnumerations;

/// <summary>
/// A rich enumeration containing Name and Value properties with int as the underlying Value data type. 
/// </summary>
/// <param name="value">The value for the instance. This must be unique.</param>
/// <param name="name">The name for the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type deriving from NdEnum</typeparam>
public abstract class NEnum<TEnum>(int value, string name) : NEnum<int,TEnum>(value, name) 
    where TEnum : NEnum<TEnum>, IComparable<TEnum>;

/// <summary>
/// A rich enumeration containing Name and Value properties. 
/// </summary>
/// <param name="value">The value for the instance. This must be unique.</param>
/// <param name="name">The name for the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type deriving from NdEnum</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
public abstract class NEnum<TValue,TEnum>(TValue value, string name) : Enum<TValue,TEnum>(value) where TValue : IEquatable<TValue>
    where TEnum : NEnum<TValue,TEnum>, IComparable<TEnum>
{
    #region Constructor and Custom Properties
    
    /// <summary>
    /// The name for the instance. This should be unique.
    /// </summary>
    public string Name { get; } = name;

    #endregion

    /// <inheritdoc />
    public override string ToString()
    {
        return $"[{Value}] {Name}";
    }
}