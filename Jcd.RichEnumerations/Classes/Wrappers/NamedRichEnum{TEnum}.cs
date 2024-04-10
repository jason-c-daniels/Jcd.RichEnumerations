#region

using System;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Classes.Wrappers;

/// <summary>
/// A <see cref="RichEnum{TEnum}" /> containing Name and Value properties with int as the underlying Value data type.
/// </summary>
/// <param name="value">The value for the instance. This must be unique.</param>
/// <param name="name">The name for the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type deriving from NdEnumeration</typeparam>
public abstract class NamedRichEnum<TEnum>(int value, string name) : NamedRichEnum<int, TEnum>(value, name)
   where TEnum : NamedRichEnum<TEnum>, IEquatable<TEnum>;