using System;

// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.RichEnumerations;

#pragma warning disable SA1402 // FileMayOnlyContainASingleType

/// <summary>
/// A <see cref="RichEnum{TEnum}"/> containing Name and Value properties with int as the underlying Value data type. 
/// </summary>
/// <param name="value">The value for the instance. This must be unique.</param>
/// <param name="name">The name for the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type deriving from NdEnumeration</typeparam>
public abstract class NamedRichEnum<TEnum>(int value, string name) : NamedRichEnum<int, TEnum>(value, name)
   where TEnum : NamedRichEnum<TEnum>, IEquatable<TEnum>;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}"/> containing Name and Value properties. 
/// </summary>
/// <param name="value">The value for the instance. This must be unique.</param>
/// <param name="name">The name for the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type deriving from NdEnumeration</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
public abstract class NamedRichEnum<TValue, TEnum>(TValue value, string name)
   : RichEnum<TValue, TEnum>(value)
   where TValue : IEquatable<TValue>
   where TEnum : NamedRichEnum<TValue, TEnum>, IEquatable<TEnum>
{
   /// <summary>
   /// The name for the instance. This should be unique.
   /// </summary>
   public string Name { get; } = name;

   /// <inheritdoc />
   public override string ToString() { return $"[{Value}] {Name}"; }
}