﻿#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Classes.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" /> with a Description property.
/// </summary>
/// <param name="value">The value of the instance. This must be unique.</param>
/// <param name="description">The description of the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type being derived from SortableDEnumeration</typeparam>
/// <typeparam name="TValue">The type of the .Value property</typeparam>
public abstract class DescribedSortableRichEnum<TValue, TEnum>(TValue value, string description) : SortableRichEnum<TValue, TEnum>(value)
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnum : DescribedSortableRichEnum<TValue, TEnum>, IComparable<TEnum>, ISortableValueProvider<TValue>
{
   /// <summary>
   /// The description of the instance.
   /// </summary>
   public string Description
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   } = description;

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override string ToString()
   {
      return $"[{Value}] {Description}";
   }
}