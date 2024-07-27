#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}" /> with a Description property.
/// </summary>
public abstract record DescribedRichEnum<TValue, TEnum> : RichEnum<TValue, TEnum>
   where TValue : IEquatable<TValue>
   where TEnum : DescribedRichEnum<TValue, TEnum>
{
   /// <summary>
   /// Constructs a <see cref="DescribedRichEnum{TValue,TEnum}" />
   /// </summary>
   /// <param name="value">the value for this instance. These must be unique.</param>
   /// <param name="description">The description for the instance. These should be unique.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected DescribedRichEnum(TValue value, string description)
      : base(value)
   {
      Description = description;
   }

   /// <summary>
   /// The description for the instance. These should be unique.
   /// </summary>
   public string Description
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   }
}