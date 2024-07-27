#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" /> with a Description property.
/// </summary>
/// <typeparam name="TEnum">The type being derived from <see cref="DescribedSortableRichEnum{TEnum}" /></typeparam>
public record DescribedSortableRichEnum<TEnum> : DescribedSortableRichEnum<int, TEnum>
   where TEnum : DescribedSortableRichEnum<TEnum>, IComparable<TEnum>, ISortableValueProvider<int>
{
   /// <summary>
   /// Constructs a <see cref="DescribedSortableRichEnum{TEnum}" />
   /// </summary>
   /// <param name="value">The value of the instance. This must be unique.</param>
   /// <param name="description">The description of the instance. This should be unique.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected DescribedSortableRichEnum(int value, string description)
      : base(value, description)
   {
   }
}