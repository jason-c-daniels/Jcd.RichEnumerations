#region

using System;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" /> with a Description property.
/// </summary>
/// <typeparam name="TEnum">The type being derived from SortableDEnumeration</typeparam>
/// <typeparam name="TValue">The type of the .Value property</typeparam>
public record DescribedSortableRichEnum<TValue, TEnum> : SortableRichEnum<TValue, TEnum>
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnum : DescribedSortableRichEnum<TValue, TEnum>, IComparable<TEnum>, ISortableRichEnumValueProvider<TValue>
{
   /// <summary>
   /// Constructs a <see cref="DescribedSortableRichEnum{TValue,TEnum}" />.
   /// </summary>
   /// <param name="value">The value of the instance. This must be unique.</param>
   /// <param name="description">The description of the instance. This should be unique.</param>
   protected DescribedSortableRichEnum(TValue value, string description)
      : base(value)
   {
      Description = description;
   }

   /// <summary>
   /// The description of the instance.
   /// </summary>
   public string Description { get; }
}