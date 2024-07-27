#region

using System;

#endregion

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
namespace Jcd.RichEnumerations.Classes.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" />  with Name and Description properties. The type of the Value
/// property is <see cref="int" />.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
/// <param name="description">The description of the instance. These should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableNdEnumeration</typeparam>
public abstract class NamedAndDescribedSortableRichEnum<TEnum>
   (int value, string name, string description) : NamedAndDescribedSortableRichEnum<int, TEnum>(value, name, description)
   where TEnum : NamedAndDescribedSortableRichEnum<TEnum>, IComparable<TEnum>, ISortableValueProvider<int>;