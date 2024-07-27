#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" />  with Name and Description properties.
/// </summary>
/// <typeparam name="TEnum">The type being derived from SortableNdEnumeration</typeparam>
/// <typeparam name="TValue">The type of the value property.</typeparam>
public record NamedAndDescribedSortableRichEnum<TValue, TEnum> : SortableRichEnum<TValue, TEnum>
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnum : NamedAndDescribedSortableRichEnum<TValue, TEnum>, IComparable<TEnum>, ISortableValueProvider<TValue>
{
   /// <summary>
   /// Constructs a <see cref="NamedAndDescribedSortableRichEnum{TValue,TEnum}" />
   /// </summary>
   /// <param name="value">the value for this instance. These must be unique.</param>
   /// <param name="name">The name of this instance. These should be unique.</param>
   /// <param name="description">The description of the instance. These should be unique.</param>
   protected NamedAndDescribedSortableRichEnum(TValue value, string name, string description)
      : base(value)
   {
      Name = name;
      Description = description;
   }

   /// <summary>
   /// The name of the instance. This should be unique.
   /// </summary>
   public string Name
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   }

   /// <summary>
   /// The description of the instance. This should be unique.
   /// </summary>
   public string Description
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   }
}