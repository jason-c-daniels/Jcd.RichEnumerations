#region

using System;

#endregion

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" /> with a Description property.
/// </summary>
/// <typeparam name="TEnum">The type being derived from DescribedSortableRichEnum</typeparam>
public abstract record DescribedSortableRichEnum<TEnum> : DescribedSortableRichEnum<int, TEnum>
   where TEnum : DescribedSortableRichEnum<TEnum>, IComparable<TEnum>, ISortableRichEnumValueProvider<int>
{
   /// <summary>
   /// A <see cref="SortableRichEnum{TValue,TEnum}" /> with a Description property.
   /// </summary>
   /// <param name="value">The value of the instance. This must be unique.</param>
   /// <param name="description">The description of the instance. This should be unique.</param>
   /// <typeparam name="TEnum">The type being derived from DescribedSortableRichEnum</typeparam>
   protected DescribedSortableRichEnum(int value, string description)
      : base(value, description)
   {
   }
}