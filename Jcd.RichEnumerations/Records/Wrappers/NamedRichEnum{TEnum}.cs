#region

using System;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A <see cref="RichEnum{TEnum}" /> containing Name and Value properties with int as the underlying Value data type.
/// </summary>
/// <typeparam name="TEnum">The type deriving from NdEnumeration</typeparam>
public abstract record NamedRichEnum<TEnum> : NamedRichEnum<int, TEnum>
   where TEnum : NamedRichEnum<TEnum>, IEquatable<TEnum>
{
   /// <summary>
   /// Constructs a <see cref="NamedRichEnum{TEnum}" />.
   /// </summary>
   /// <param name="value">The value for the instance. This must be unique.</param>
   /// <param name="name">The name for the instance. This should be unique.</param>
   protected NamedRichEnum(int value, string name)
      : base(value, name)
   {
   }
}