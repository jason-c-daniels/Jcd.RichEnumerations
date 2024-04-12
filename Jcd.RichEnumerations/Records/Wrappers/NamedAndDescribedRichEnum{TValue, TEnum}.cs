#region

using System;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A rich enumeration containing Description, Name and Value properties.
/// </summary>
/// <typeparam name="TEnum">The type deriving from NdEnumeration</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
public record NamedAndDescribedRichEnum<TValue, TEnum> : RichEnum<TValue, TEnum>
   where TValue : IEquatable<TValue>
   where TEnum : NamedAndDescribedRichEnum<TValue, TEnum>
{
   /// <summary>
   /// Constructs a <see cref="NamedAndDescribedRichEnum{TValue,TEnum}" />
   /// </summary>
   /// <param name="value">The value for the instance. This must be unique.</param>
   /// <param name="name">The name for the instance. This should be unique.</param>
   /// <param name="description">The description for the instance. This should be unique.</param>
   protected NamedAndDescribedRichEnum(TValue value, string name, string description)
      : base(value)
   {
      Name = name;
      Description = description;
   }

   /// <summary>The name for the instance. This should be unique.</summary>
   public string Name { get; }

   /// <summary>The description for the instance. This should be unique.</summary>
   public string Description { get; }
}