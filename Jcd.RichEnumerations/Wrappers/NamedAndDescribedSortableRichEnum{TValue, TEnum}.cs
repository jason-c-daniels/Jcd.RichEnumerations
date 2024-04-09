#region

using System;

#endregion

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
namespace Jcd.RichEnumerations.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" />  with Name and Description properties.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
/// <param name="description">The description of the instance. These should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableNdEnumeration</typeparam>
/// <typeparam name="TValue">The type of the value property.</typeparam>
public abstract class NamedAndDescribedSortableRichEnum<TValue, TEnum>(TValue value, string name, string description) : SortableRichEnum<TValue, TEnum>(value)
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnum : NamedAndDescribedSortableRichEnum<TValue, TEnum>, IComparable<TEnum>, ISortableRichEnumValueProvider<TValue>
{
   /// <summary>
   /// The name of the instance. This should be unique.
   /// </summary>
   public string Name { get; } = name;

   /// <summary>
   /// The description of the instance. This should be unique.
   /// </summary>
   public string Description { get; } = description;

   /// <inheritdoc />
   public override string ToString()
   {
      return $"[{Value}] {Name} - {Description}";
   }
}