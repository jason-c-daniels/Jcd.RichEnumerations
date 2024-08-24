#region

using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Records;

/// <summary>
/// Provides access to all instances on the enumeration container by way of the <see cref="All" /> property.
/// </summary>
/// <remarks>
/// NOTE: This is intended as a supporting class. Consumers should prefer <see cref="RichEnum{TValue,TEnum}" /> or
/// <see cref="RichEnum{TEnum}" /> instead.
/// </remarks>
/// <typeparam name="TEnumeration">The type of the enumeration containing the enumerated items</typeparam>
/// <typeparam name="TEnumeratedItem">The type of the enumerated data.</typeparam>
public abstract record RichEnumBase<TEnumeration, TEnumeratedItem>
{
   private static List<TEnumeratedItem>? all;

   /// <summary>
   /// </summary>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected RichEnumBase()
   {
   }

   /// <summary>
   /// All enumerated elements. Populated in static constructor.
   /// </summary>
   public static IReadOnlyList<TEnumeratedItem> All
   {
      get { return all ??= typeof(TEnumeration).GetPublicStaticFieldValues<TEnumeratedItem>(); }
   }
}