// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

namespace Jcd.RichEnumerations.Classes.Wrappers;

/// <summary>
/// A <see cref="RichEnum{TEnum}" /> with a Description property.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="description">The description for the instance. These should be unique.</param>
/// <typeparam name="TEnum">The type deriving from DEnumeration</typeparam>
public abstract class DescribedRichEnum<TEnum>(int value, string description) : DescribedRichEnum<int, TEnum>(value, description)
   where TEnum : DescribedRichEnum<TEnum>;