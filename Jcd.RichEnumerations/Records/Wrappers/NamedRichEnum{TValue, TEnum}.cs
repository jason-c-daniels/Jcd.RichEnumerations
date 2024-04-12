#region

using System;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}" /> containing Name and Value properties.
/// </summary>
/// <typeparam name="TEnum">The type deriving from NdEnumeration</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
public record NamedRichEnum<TValue, TEnum> : RichEnum<TValue, TEnum>
   where TValue : IEquatable<TValue>
   where TEnum : NamedRichEnum<TValue, TEnum>, IEquatable<TEnum>
{
   /// <summary>
   /// Constructs a <see cref="NamedRichEnum{TValue,TEnum}" />.
   /// </summary>
   /// <param name="value">The value for the instance. This must be unique.</param>
   /// <param name="name">The name for the instance. This should be unique.</param>
   protected NamedRichEnum(TValue value, string name)
      : base(value)
   {
      Name = name;
   }

   /// <summary>
   /// The name for the instance. This should be unique.
   /// </summary>
   public string Name { get; }
}