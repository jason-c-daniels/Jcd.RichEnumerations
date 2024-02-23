// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

namespace Jcd.RichEnumerations;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}"/> with TValue set to int.
/// </summary>
/// <typeparam name="TEnum">The enumeration type. This will contain both the structure definition and the enumeration entries as public static readonly fields.</typeparam>
public abstract class RichEnum<TEnum>(int value) : RichEnum<int, TEnum>(value)
   where TEnum : RichEnum<TEnum>;