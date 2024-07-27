#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" /> with a Name property.
/// </summary>
public abstract record NamedSortableRichEnum<TValue, TEnum> : SortableRichEnum<TValue, TEnum>
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnum : NamedSortableRichEnum<TValue, TEnum>, ISortableValueProvider<TValue>
{
   /// <summary>
   /// A <see cref="SortableRichEnum{TValue,TEnum}" /> with a Name property.
   /// </summary>
   /// <param name="value">the value for this instance. These must be unique.</param>
   /// <param name="name">The name of this instance. These should be unique.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected NamedSortableRichEnum(TValue value, string name)
      : base(value)
   {
      Name = name;
   }

   /// <summary>
   /// The name of the instance. This should be unique.
   /// </summary>
   public string Name
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   }
}