using Jcd.RichEnumerations.Examples.CardSelector.Menuing;

// ReSharper disable HeapView.ObjectAllocation.Evident

namespace Jcd.RichEnumerations.Examples.CardSelector.Menus;

public class MainMenu : Menu<MainMenu, MainMenu.Item, MainMenu.Result>
{
   public class Result(int value, string name, string description, bool isFinalResult = false)
      : NamedAndDescribedRichEnum<Result>(value, name, description)
      , IMenuProcessingResult<Result>
   {
      public static readonly Result Success = new(1, "Continue", "Command was processed, continue processing.");

      public static readonly Result NotImplemented =
         new(0, "Not Implemented", "Command was recognized, but is not implemented.");

      public static readonly Result Exit = new(-1, "Exit", "Exit the application");
      public static          Result Default => NotImplemented;
      public                 bool   IsFinal { get; } = isFinalResult;
   }

   public class Item(string value, int order, string name) : MenuItem<Item>(value, order, name)
   {
      public static readonly Item ViewCardSummary      = new("VCS", 1, "View Card Summary");
      public static readonly Item ViewCardDetails      = new("VCD", 2, "View Card Details");
      public static readonly Item AddCard              = new("ADD", 3, "Add a card");
      public static readonly Item EditCard             = new("EDIT", 4, "Edit a card");
      public static readonly Item RemoveCard           = new("DEL", 5, "Remove a card");
      public static readonly Item ListAllCardSummaries = new("LAS", 999, "List all card summaries");
      public static readonly Item ListAllCardDetails   = new("LAD", 1000, "List all card details");
      public static readonly Item ShowMenu             = new("MENU", 9999, "Show this menu");
      public static readonly Item Exit                 = new("EXIT", int.MaxValue, "Leave the application");
   }

   public override Result ProcessSelections(string prompt = "")
   {
      do
      {
         var result = base.ProcessSelections(prompt);

         if (result == Result.NotImplemented)
         {
            Console.WriteLine("Command was recognized, but no action was implemented for it.");

            continue;
         }

         if (result.IsFinal) return result;
      }
      while (true);
   }
}