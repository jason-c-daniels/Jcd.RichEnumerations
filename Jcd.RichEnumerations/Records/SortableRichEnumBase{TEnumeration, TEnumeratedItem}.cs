#region

using System;
using System.Collections.Generic;

#endregion

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
namespace Jcd.RichEnumerations.Records;

/// <summary>
/// A base for sortable rich enumerations. This type provides a hook to sort the .All collection.
/// <c>.Sort()</c> should be called once and only once during application startup.
/// </summary>
/// <remarks>
/// NOTE: This is intended as a supporting class. Consumers should prefer <see cref="SortableRichEnum{TValue,TEnum}" />
/// or <see cref="SortableRichEnum{TEnum}" /> instead.
/// </remarks>
/// <typeparam name="TEnumeration">The type of the enumeration containing the enumerated items</typeparam>
/// <typeparam name="TEnumeratedItem">The type of the enumerated data.</typeparam>
public abstract record SortableRichEnumBase<TEnumeration, TEnumeratedItem> : RichEnumBase<TEnumeration, TEnumeratedItem>
   where TEnumeratedItem : IComparable<TEnumeratedItem>
{
   /// <summary>
   /// Sorts the .All collection. This should be called once and only once during application startup.
   /// </summary>
   /// <param name="comparison">An optional custom comparer</param>
   public static void Sort(Comparison<TEnumeratedItem>? comparison = null)
   {
      var all = (List<TEnumeratedItem>) All;

      if (comparison != null)
      {
         all.Sort(comparison);
      }
      else
      {
         all.Sort();
      }
   }
}