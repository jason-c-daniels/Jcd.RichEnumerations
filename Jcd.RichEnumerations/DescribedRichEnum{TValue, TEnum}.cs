using System;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
namespace Jcd.RichEnumerations;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}"/> with a Description property.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="description">The description for the instance. These should be unique.</param>
public abstract class DescribedRichEnum<TValue, TEnum>(TValue value, string description)
   : RichEnum<TValue, TEnum>(value)
   where TValue : IEquatable<TValue>
   where TEnum : DescribedRichEnum<TValue, TEnum>, IComparable<TEnum>
{
   /// <summary>
   /// The description for the instance. These should be unique.
   /// </summary>
   public string Description { get; } = description;

   /// <inheritdoc/>
   public override string ToString() { return $"[{Value}] {Description}"; }
}