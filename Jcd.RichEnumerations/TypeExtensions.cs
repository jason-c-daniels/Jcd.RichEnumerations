#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

#endregion

namespace Jcd.RichEnumerations;

internal static class TypeExtensions
{
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static List<TEnumeratedItem> GetPublicStaticFieldValues<TEnumeratedItem>(this Type type)
   {
      var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

      var allItems = fields.Where(f => f.FieldType == typeof(TEnumeratedItem)).Select(f => f.GetValue(null)).Cast<TEnumeratedItem>().Distinct().ToList();

      return allItems;
   }
}