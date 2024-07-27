#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" />  with Name and Description properties. The type of the Value
/// property is <see cref="int" />.
/// </summary>
/// <typeparam name="TEnum">The type being derived from SortableNdEnumeration</typeparam>
public abstract record NamedAndDescribedSortableRichEnum<TEnum> : NamedAndDescribedSortableRichEnum<int, TEnum>
   where TEnum : NamedAndDescribedSortableRichEnum<TEnum>, IComparable<TEnum>, ISortableValueProvider<int>
{
   /// <summary>
   /// Constructs a <see cref="NamedAndDescribedSortableRichEnum{TEnum}" />
   /// </summary>
   /// <param name="value">the value for this instance. These must be unique.</param>
   /// <param name="name">The name of this instance. These should be unique.</param>
   /// <param name="description">The description of the instance. These should be unique.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected NamedAndDescribedSortableRichEnum(int value, string name, string description)
      : base(value, name, description)
   {
   }
}