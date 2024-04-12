#region

using Jcd.RichEnumerations.Classes.Wrappers;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable MemberCanBePrivate.Global

#pragma warning disable S2743

#endregion

namespace Jcd.RichEnumerations.Examples.CardSelector.Menuing;

public class MenuItem<TMenuItem>(string value, int order, string name) : NamedSortableRichEnum<CaseInsensitiveString, TMenuItem>(value, name)
                                                                                , IMenuItemProvider<CaseInsensitiveString, TMenuItem>
   where TMenuItem : MenuItem<TMenuItem>
{
   #region IMenuItemProvider<CaseInsensitiveString,TMenuItem> Members

   public static IReadOnlyList<TMenuItem> AllItems => All;
   public static IReadOnlyDictionary<CaseInsensitiveString, TMenuItem> LookupByValue => ByValue;

   #endregion

   #region Properties and Overrides

   /// <summary>
   /// Indicates if the underlying SortableRichEnum has been sorted.
   /// </summary>

   // ReSharper disable once StaticMemberInGenericType
   public static bool IsSorted { get; private set; }

   public int Order { get; } = order;

   public override int CompareTo(TMenuItem other)
   {
      return Order.CompareTo(other.Order);
   }

   public override string ToString()
   {
      return $"{Value} - {Name}";
   }

   public static void SortItems()
   {
      if (IsSorted)
      {
         return;
      }

      Sort();
      IsSorted = true;
   }

   #endregion
}