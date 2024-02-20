using System;

namespace Jcd.RichEnumerations;

/// <summary>
/// A RichEnum containing Name and Value properties with int as the underlying Value data type. 
/// </summary>
/// <param name="value">The value for the instance. This must be unique.</param>
/// <param name="name">The name for the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type deriving from NdEnumeration</typeparam>
public abstract class NamedRichEnum<TEnum>(int value, string name) : NamedRichEnum<int,TEnum>(value, name) 
    where TEnum : NamedRichEnum<TEnum>, IComparable<TEnum>;

/// <summary>
/// A RichEnum containing Name and Value properties. 
/// </summary>
/// <param name="value">The value for the instance. This must be unique.</param>
/// <param name="name">The name for the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type deriving from NdEnumeration</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
public abstract class NamedRichEnum<TValue,TEnum>(TValue value, string name) : RichEnum<TValue,TEnum>(value) where TValue : IEquatable<TValue>
    where TEnum : NamedRichEnum<TValue,TEnum>, IComparable<TEnum>
{
    /// <summary>
    /// The name for the instance. This should be unique.
    /// </summary>
    public string Name { get; } = name;

    /// <inheritdoc />
    public override string ToString()
    {
        return $"[{Value}] {Name}";
    }
}