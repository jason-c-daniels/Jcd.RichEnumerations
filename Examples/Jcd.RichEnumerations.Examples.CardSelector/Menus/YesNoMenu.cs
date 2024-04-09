#region

using Jcd.RichEnumerations.Classes.Wrappers;
using Jcd.RichEnumerations.Examples.CardSelector.Menuing;

#endregion

// ReSharper disable HeapView.ObjectAllocation.Evident

namespace Jcd.RichEnumerations.Examples.CardSelector.Menus;

public class YesNoMenu : Menu<YesNoMenu, YesNoMenu.Item, YesNoMenu.Result>
{
   public YesNoMenu()
   {
      RegisterAction(Item.Yes, _ => Result.Yes);
      RegisterAction(Item.No,  _ => Result.No);
   }

   #region Nested type: Item

   public class Item(string value, int order, string name) : MenuItem<Item>(value, order, name)
   {
      public static readonly Item Yes = new("Y", 0, "Yes");
      public static readonly Item No = new("N", 1, "No");
   }

   #endregion

   #region Nested type: Result

   public class Result(int value, string name, bool isFinalResult = true) : NamedRichEnum<Result>(value, name)
                                                                          , IMenuProcessingResult<Result>
   {
      public static readonly Result Yes = new(1, "Yes");
      public static readonly Result No = new(0, "No");

      #region IMenuProcessingResult<Result> Members

      public static Result Default => No;
      public bool IsFinal { get; } = isFinalResult;

      #endregion
   }

   #endregion
}