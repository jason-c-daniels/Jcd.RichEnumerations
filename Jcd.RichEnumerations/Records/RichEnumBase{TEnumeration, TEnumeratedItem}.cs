#region

using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
public record RichEnumBase<TEnumeration, TEnumeratedItem>
{
   private static List<TEnumeratedItem>? all;

   /// <summary>
   /// All enumerated elements. Populated in static constructor.
   /// </summary>
   public static IReadOnlyList<TEnumeratedItem> All => all ??= GetAll();

   /// <summary>
   /// 
   /// </summary>
   protected RichEnumBase()
   {
   }

   private static List<TEnumeratedItem> GetAll()
   {
      var fields = typeof(TEnumeration).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

      var allItems = fields.Where(f => f.FieldType == typeof(TEnumeratedItem)).Select(f => f.GetValue(null)).Cast<TEnumeratedItem>().ToList();

      return allItems;
   }
}