#region

using System;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Classes.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" /> with a Description property.
/// </summary>
/// <param name="value">The value of the instance. This must be unique.</param>
/// <param name="description">The description of the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type being derived from DescribedSortableRichEnum</typeparam>
public abstract class DescribedSortableRichEnum<TEnum>(int value, string description) : DescribedSortableRichEnum<int, TEnum>(value, description)
   where TEnum : DescribedSortableRichEnum<TEnum>, IComparable<TEnum>, ISortableRichEnumValueProvider<int>;