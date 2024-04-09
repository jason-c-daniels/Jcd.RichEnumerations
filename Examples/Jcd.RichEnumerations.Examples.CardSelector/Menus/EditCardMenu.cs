#region

using Jcd.RichEnumerations.Examples.CardSelector.Menuing;
using Jcd.RichEnumerations.Wrappers;

#endregion

// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable HeapView.ObjectAllocation.Evident

namespace Jcd.RichEnumerations.Examples.CardSelector.Menus;

public class EditCardMenu : Menu<EditCardMenu, EditCardMenu.Item, EditCardMenu.Result>
{
   protected override (Item? command, string args, string cmdText) ParseCommand(string? input)
   {
      input = input?.Trim() ?? string.Empty;
      var results = input.Split(' ', 2).Concat(new[] { string.Empty }).Take(2).ToArray();
      var item = GetItem(results[0]);

      return item != null
                ? (item, results[1], results[0])
                : ParseByName(input);
   }

   private static (Item? command, string args, string cmdText) ParseByName(string input)
   {
      // ReSharper disable once HeapView.ObjectAllocation.Possible
      var result = Item.All.FirstOrDefault(item => input.StartsWith(item.Name, StringComparison.InvariantCultureIgnoreCase));

      if (result != null)
      {
         return (result, input.Remove(0, result.Name.Length).Trim(), input[..result.Name.Length]);
      }

      var invalidCommand = input.Split(' ', 2).Concat(new[] { string.Empty }).Take(2).ToArray();

      return (null, invalidCommand[1], invalidCommand[0]);
   }

   public override Result ProcessSelections(string prompt = "")
   {
      do
      {
         var result = base.ProcessSelections(prompt);

         if (result == Result.UnmappedCommand)
         {
            Console.WriteLine("Command was recognized, but no action was mapped.");

            continue;
         }

         if (result.IsFinal)
         {
            return result;
         }
      }
      while (true);
   }

   #region Nested type: Item

   public class Item(string value, int order, string name) : MenuItem<Item>(value, order, name)
   {
      public static readonly Item SetName = new("NAME", 0, "Set Name");
      public static readonly Item SetBrand = new("BRAND", 1, "Set Brand");
      public static readonly Item SetBank = new("BANK", 2, "Set Bank");
      public static readonly Item SetNumber = new("NUM", 3, "Set Number");
      public static readonly Item SetExp = new("EXP", 4, "Set Expiration");
      public static readonly Item SetCcv = new("CCV", 5, "Set CCV");
      public static readonly Item ViewDetails = new("VIEW", 6, "View Details");
      public static readonly Item ShowMenu = new("MENU", 10000, "Show Menu");
      public static readonly Item Discard = new("DSC", 10020, "Discard");
      public static readonly Item Save = new("SAV", 10030, "Save");
   }

   #endregion

   #region Nested type: Result

   public class Result(int value, string name, string description, bool isFinalResult = false) : NamedAndDescribedRichEnum<Result>(value, name, description)
                                                                                               , IMenuProcessingResult<Result>
   {
      public static readonly Result Discarded = new(255, "Discarded", "Edits were discarded", true);
      public static readonly Result Saved = new(254, "Saved", "Edits were saved", true);
      public static readonly Result Succeeded = new(1, "Change Succeeded", "An attempt to change some data succeeded.");
      public static readonly Result Failed = new(-1, "Change Failed", "An attempt to change some data failed.");

      public static readonly Result UnmappedCommand = new(int.MinValue, "A command hook was not mapped.", "An attempt to change some data failed.", true);

      #region IMenuProcessingResult<Result> Members

      public static Result Default => UnmappedCommand;
      public bool IsFinal { get; } = isFinalResult;

      #endregion
   }

   #endregion
}