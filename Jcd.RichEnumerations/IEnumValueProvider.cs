using System;

namespace Jcd.RichEnumerations;

/// <summary>
/// A helper interface to enable building auto casting into the data type aware Enum types. This helps minimize boilerplate code.
/// </summary>
/// <typeparam name="TValue">The type of the value</typeparam>
public interface IEnumValueProvider<out TValue>
    where TValue : IEquatable<TValue>
{
    /// <summary>
    /// The underlying value
    /// </summary>
    TValue Value { get; } 
}