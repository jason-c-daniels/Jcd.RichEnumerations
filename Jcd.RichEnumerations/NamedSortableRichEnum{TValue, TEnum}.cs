using System;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
namespace Jcd.RichEnumerations;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}"/> with a Name property.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
public abstract class NamedSortableRichEnum<TValue, TEnum>(TValue value, string name)
   : SortableRichEnum<TValue, TEnum>(value)
   where TValue : IEquatable<TValue>
   where TEnum : NamedSortableRichEnum<TValue, TEnum>
{
   /// <summary>
   /// The name of the instance. This should be unique.
   /// </summary>
   public string Name { get; } = name;

   /// <inheritdoc />
   public override string ToString() { return $"[{Value}] {Name}"; }
}