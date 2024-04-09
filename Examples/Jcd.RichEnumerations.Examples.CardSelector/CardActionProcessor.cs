#region

using Jcd.RichEnumerations.Examples.CardSelector.Menus;

#endregion

// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.DelegateAllocation

namespace Jcd.RichEnumerations.Examples.CardSelector;

public class CardActionProcessor
{
   private readonly EditCardMenu editCardMenu = new();
   private readonly YesNoMenu yesNoMenu = new();
   private CreditCard activeCard = new();

   public CardActionProcessor()
   {
      RegisterActions();
   }

   private void RegisterActions()
   {
      editCardMenu.RegisterAction(EditCardMenu.Item.SetNumber, SetNumber)
                  .RegisterAction(EditCardMenu.Item.SetCcv,      SetCcv)
                  .RegisterAction(EditCardMenu.Item.SetName,     SetName)
                  .RegisterAction(EditCardMenu.Item.SetBrand,    SetBrand)
                  .RegisterAction(EditCardMenu.Item.SetBank,     SetBank)
                  .RegisterAction(EditCardMenu.Item.SetExp,      SetExp)
                  .RegisterAction(EditCardMenu.Item.ViewDetails, ViewDetails)
                  .RegisterAction(EditCardMenu.Item.ShowMenu,    ShowMenu)
                  .RegisterAction(EditCardMenu.Item.Save,        Save)
                  .RegisterAction(EditCardMenu.Item.Discard,     Discard);
   }

   private static EditCardMenu.Result Discard(string _)
   {
      return EditCardMenu.Result.Discarded;
   }

   private EditCardMenu.Result Save(string _)
   {
      Func<CreditCard, bool> saveMethod = activeCard.IsNew
                                             ? CreditCard.AddCard
                                             : CreditCard.UpdateCard;

      if (saveMethod(activeCard))
      {
         return EditCardMenu.Result.Saved;
      }

      Console.WriteLine("Save failed.");

      return EditCardMenu.Result.Failed;
   }

   private EditCardMenu.Result ShowMenu(string _)
   {
      editCardMenu.Show();

      return EditCardMenu.Result.Succeeded;
   }

   private EditCardMenu.Result ViewDetails(string _)
   {
      ShowCardDetails(activeCard);

      return EditCardMenu.Result.Succeeded;
   }

   private EditCardMenu.Result SetExp(string expDate)
   {
      activeCard.ExpirationDate = expDate;
      Console.WriteLine($"EXP set to: {expDate}");

      return EditCardMenu.Result.Succeeded;
   }

   private EditCardMenu.Result SetBank(string bankName)
   {
      activeCard.BankName = bankName;
      Console.WriteLine($"BANK set to: {bankName}");

      return EditCardMenu.Result.Succeeded;
   }

   private static EditCardMenu.Result SetBrand(string brandKey)
   {
      Console.WriteLine("set BRAND not implemented.");

      return EditCardMenu.Result.Failed;
   }

   private EditCardMenu.Result SetName(string name)
   {
      activeCard.Name = name;
      Console.WriteLine($"NAME set to: {name}");

      return EditCardMenu.Result.Succeeded;
   }

   private EditCardMenu.Result SetCcv(string ccv)
   {
      activeCard.Ccv = ccv;
      Console.WriteLine($"CCV set to: {ccv}");

      return EditCardMenu.Result.Succeeded;
   }

   private EditCardMenu.Result SetNumber(string num)
   {
      activeCard.CardNumber = num;
      Console.WriteLine($"NUM set to: {num}");

      return EditCardMenu.Result.Succeeded;
   }

   public void AddNewCard(string? name)
   {
      var card = new CreditCard { IsNew = true };

      if (!string.IsNullOrEmpty(name?.Trim()))
      {
         card.Name = name;
      }

      EditCard(card);
   }

   public void EditCard(CreditCard card)
   {
      activeCard = card.Clone();
      Console.WriteLine("Editing Card:");
      Console.WriteLine(card.GetCardDetails());
      editCardMenu.ProcessSelections();
   }

   public void RemoveCard(CreditCard card)
   {
      var result = yesNoMenu.ProcessSelections($"You're about to remove card: \"{card.Name}\" which expires on {card.ExpirationDate}");

      if (result == YesNoMenu.Result.No)
      {
         return;
      }

      CreditCard.RemoveCardById(card.Id);
      Console.WriteLine($"Credit Card Removed: {card.Name}; EXP: {card.ExpirationDate}");
   }

   public static void ShowCardDetails(CreditCard card)
   {
      Console.WriteLine(card.GetCardDetails());
   }

   public static void ShowCardSummary(CreditCard card)
   {
      Console.WriteLine(card.GetCardSummary());
   }

   public static void ForCard(string? cardIdentifier, Action<CreditCard> action)
   {
      if (string.IsNullOrEmpty(cardIdentifier?.Trim()))
      {
         Console.WriteLine("You must provide a credit card name, ID, or Number for this command.");
         Console.WriteLine();

         return;
      }

      var card = CreditCard.FindByNameIdOrNumber(cardIdentifier);

      if (card == null)
      {
         Console.WriteLine($"Unable to find a card with ID, Name or Number of: {cardIdentifier}");
         Console.WriteLine();

         return;
      }

      action(card);
   }

   public static void ForAllCards(Action<CreditCard> action)
   {
      // ReSharper disable once HeapView.ObjectAllocation.Possible
      foreach (var card in CreditCard.All)
      {
         action?.Invoke(card);
      }

      Console.WriteLine();
   }
}