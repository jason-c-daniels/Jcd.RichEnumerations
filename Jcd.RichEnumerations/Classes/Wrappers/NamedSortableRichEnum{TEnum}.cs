// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

namespace Jcd.RichEnumerations.Classes.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" /> with a Name property.
/// </summary>
/// <param name="value">The value for this instance. These must be unique.</param>
/// <param name="name">The name of this instance. These should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableNEnumeration</typeparam>
public abstract class NamedSortableRichEnum<TEnum>(int value, string name) : NamedSortableRichEnum<int, TEnum>(value, name)
   where TEnum : NamedSortableRichEnum<TEnum>, ISortableRichEnumValueProvider<int>;