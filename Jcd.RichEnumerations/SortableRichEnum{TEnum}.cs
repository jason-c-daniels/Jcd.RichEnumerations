// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

namespace Jcd.RichEnumerations;

/// <summary>
/// A rich enum that can be sorted with a call to .Sort.
/// </summary>
/// <param name="value">The value of the instance. This must be unique.</param>
/// <typeparam name="TEnum">The type deriving from SortableEnum{TEnum}</typeparam>
public abstract class SortableRichEnum<TEnum>(int value) : SortableRichEnum<int, TEnum>(value)
   where TEnum : SortableRichEnum<TEnum>;