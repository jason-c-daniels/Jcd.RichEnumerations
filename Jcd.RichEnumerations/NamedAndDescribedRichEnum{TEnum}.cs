// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

namespace Jcd.RichEnumerations;

/// <summary>
/// A rich enumeration containing Description, Name and Value properties with int as the underlying Value data type. 
/// </summary>
/// <param name="value">The value for the instance. This must be unique.</param>
/// <param name="name">The name for the instance. This should be unique.</param>
/// <param name="description">The description for the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type deriving from NdEnumeration</typeparam>
public abstract class NamedAndDescribedRichEnum<TEnum>(int value, string name, string description)
   : NamedAndDescribedRichEnum<int, TEnum>(value, name, description)
   where TEnum : NamedAndDescribedRichEnum<TEnum>;