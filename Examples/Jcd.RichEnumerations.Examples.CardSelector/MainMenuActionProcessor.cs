using Jcd.RichEnumerations.Examples.CardSelector.Menus;

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.DelegateAllocation

namespace Jcd.RichEnumerations.Examples.CardSelector;

internal class MainMenuActionProcessor
{
   private readonly MainMenu            mainMenu    = new();
   private readonly CardActionProcessor cardActions = new();

   public void Run() { mainMenu.ProcessSelections(); }

   public MainMenuActionProcessor() { RegisterActions(); }

   private void RegisterActions()
   {
      mainMenu.RegisterAction(MainMenu.Item.Exit, Exit)
              .RegisterAction(MainMenu.Item.ShowMenu,             ShowMenu)
              .RegisterAction(MainMenu.Item.ListAllCardDetails,   ListAllCardDetails)
              .RegisterAction(MainMenu.Item.ListAllCardSummaries, ListAllCardSummaries)
              .RegisterAction(MainMenu.Item.ViewCardSummary,      ViewCardSummary)
              .RegisterAction(MainMenu.Item.ViewCardDetails,      ViewCardDetails)
              .RegisterAction(MainMenu.Item.AddCard,              AddCard)
              .RegisterAction(MainMenu.Item.EditCard,             EditCard)
              .RegisterAction(MainMenu.Item.RemoveCard,           RemoveCard);
   }

   private static MainMenu.Result Exit(string _) { return MainMenu.Result.Exit; }

   private MainMenu.Result ShowMenu(string _)
   {
      mainMenu.Show();

      return MainMenu.Result.Success;
   }

   private static MainMenu.Result ListAllCardDetails(string _)
   {
      CardActionProcessor.ForAllCards(CardActionProcessor.ShowCardDetails);

      return MainMenu.Result.Success;
   }

   private static MainMenu.Result ListAllCardSummaries(string _)
   {
      CardActionProcessor.ForAllCards(CardActionProcessor.ShowCardSummary);

      return MainMenu.Result.Success;
   }

   private static MainMenu.Result ViewCardSummary(string cardIdentifier)
   {
      CardActionProcessor.ForCard(cardIdentifier, CardActionProcessor.ShowCardSummary);

      return MainMenu.Result.Success;
   }

   private static MainMenu.Result ViewCardDetails(string cardIdentifier)
   {
      CardActionProcessor.ForCard(cardIdentifier, CardActionProcessor.ShowCardDetails);

      return MainMenu.Result.Success;
   }

   private MainMenu.Result AddCard(string cardName)
   {
      cardActions.AddNewCard(cardName);
      mainMenu.Show();

      return MainMenu.Result.Success;
   }

   private MainMenu.Result EditCard(string cardIdentifier)
   {
      CardActionProcessor.ForCard(cardIdentifier, cardActions.EditCard);
      mainMenu.Show();

      return MainMenu.Result.Success;
   }

   private MainMenu.Result RemoveCard(string cardIdentifier)
   {
      CardActionProcessor.ForCard(cardIdentifier, cardActions.RemoveCard);
      mainMenu.Show();

      return MainMenu.Result.Success;
   }
}