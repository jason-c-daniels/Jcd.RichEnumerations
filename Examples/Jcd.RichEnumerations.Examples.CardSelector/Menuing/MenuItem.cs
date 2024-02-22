// ReSharper disable HeapView.ObjectAllocation

namespace Jcd.RichEnumerations.Examples.CardSelector.Menuing;

public abstract class MenuItemProvider<TMenuItem>(string value, int order, string name)
   : NamedSortableRichEnum<CaseInsensitiveString, TMenuItem>(value, name)
   , IMenuItemProvider<CaseInsensitiveString, TMenuItem>
   where TMenuItem : MenuItemProvider<TMenuItem>
{
   #region Properties and Overrides

   /// <summary>
   /// Indicates if the underlying SortableRichEnum has been sorted.
   /// </summary>

   // ReSharper disable once StaticMemberInGenericType
   public static bool IsSorted { get; private set; }

   public int Order { get; } = order;

   public override int CompareTo(TMenuItem other) { return Order.CompareTo(other.Order); }

   public override string ToString() { return $"{Value} - {Name}"; }

   public static void SortItems()
   {
      if (IsSorted) return;
      Sort();
      IsSorted = true;
   }

   #endregion

   public static IReadOnlyList<TMenuItem>                              AllItems      => All;
   public static IReadOnlyDictionary<CaseInsensitiveString, TMenuItem> LookupByValue => ByValue;
}