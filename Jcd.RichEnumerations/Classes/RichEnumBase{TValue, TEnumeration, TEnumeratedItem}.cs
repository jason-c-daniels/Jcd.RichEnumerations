#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Classes;

#pragma warning disable S2436

/// <summary>
/// Provides access to a lookup of all instances on the enumeration container by way of the <see cref="ByValue" />
/// property.
/// And allows lookup of items by value. This is used in <see cref="RichEnum{TValue,TEnum}" /> to provide conversion
/// operators.
/// </summary>
/// <remarks>
/// NOTE: This is intended as a supporting class. Consumers should prefer <see cref="RichEnum{TValue,TEnum}" /> or
/// <see cref="RichEnum{TEnum}" /> instead.
/// </remarks>
/// <typeparam name="TValue">
/// The type of the .Value property on the TEnumeratedItem instances. This is used in the
/// conversion operators.
/// </typeparam>
/// <typeparam name="TEnumeration">The type of the enumeration containing the enumerated items</typeparam>
/// <typeparam name="TEnumeratedItem">The type of the enumerated data.</typeparam>
public class RichEnumBase<TValue, TEnumeration, TEnumeratedItem> : RichEnumBase<TEnumeration, TEnumeratedItem>
   where TEnumeratedItem : IEquatable<TEnumeratedItem>, IValueProvider<TValue>
   where TValue : IEquatable<TValue>
{
   private static Dictionary<TValue, TEnumeratedItem>? byValue;

   /// <inheritdoc />
   protected RichEnumBase()
   {
   }

   /// <summary>
   /// Determines if the passed in value can be converted into the enumerated type.
   /// </summary>
   /// <param name="value"></param>
   /// <returns></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsValid(TValue value)
      => ByValue.ContainsKey(value);
   
   /// <summary>
   /// A lookup of enumerated elements by their Value property.
   /// Useful for implementing conversion operators.
   /// </summary>
   public static IReadOnlyDictionary<TValue, TEnumeratedItem> ByValue
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get { return byValue ??= All.ToDictionary(e => e.Value); }
   }
}