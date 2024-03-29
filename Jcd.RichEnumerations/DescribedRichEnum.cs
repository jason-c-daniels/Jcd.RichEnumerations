﻿using System;

// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.RichEnumerations;

#pragma warning disable SA1402 // FileMayOnlyContainASingleType

/// <summary>
/// A <see cref="RichEnum{TEnum}"/> with a Description property.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="description">The description for the instance. These should be unique.</param>
/// <typeparam name="TEnum">The type deriving from DEnumeration</typeparam>
public abstract class DescribedRichEnum<TEnum>(int value, string description)
   : DescribedRichEnum<int, TEnum>(value, description)
   where TEnum : DescribedRichEnum<TEnum>, IComparable<TEnum>;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}"/> with a Description property.
/// </summary>
/// <param name="value">the value for this instance. These must be unique.</param>
/// <param name="description">The description for the instance. These should be unique.</param>
public abstract class DescribedRichEnum<TValue, TEnum>(TValue value, string description)
   : RichEnum<TValue, TEnum>(value)
   where TValue : IEquatable<TValue>
   where TEnum : DescribedRichEnum<TValue, TEnum>, IComparable<TEnum>
{
   /// <summary>
   /// The description for the instance. These should be unique.
   /// </summary>
   public string Description { get; } = description;

   /// <inheritdoc/>
   public override string ToString() { return $"[{Value}] {Description}"; }
}