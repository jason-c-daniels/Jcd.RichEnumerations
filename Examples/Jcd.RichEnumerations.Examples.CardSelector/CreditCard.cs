using System.Text;

// ReSharper disable HeapView.DelegateAllocation

// ReSharper disable StringLiteralTypo
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable UnusedMember.Global

namespace Jcd.RichEnumerations.Examples.CardSelector;

/// <remarks>
/// Instead of creating a backing store we're cheating and using a RichEnumBase derived type
///  to provide the list of initial credit cards. Don't do this in a production application.
/// It's an awful practice. This is here just as a shortcut to demonstrating the proper use
/// of RichEnums with MenuItem derived types. In a real app you'd have a backing story and
/// likely use a DDD Entity. This is a poor approximation of that.
/// </remarks>
public class CreditCard
(
   int             id
 , string?         name
 , CreditCardBrand brand
 , string?         bankName
 , string?         cardNumber
 , string?         ccv
 , string?         expirationDate
 , bool            isNew = false
) : RichEnumBase<CreditCard, CreditCard>
  , IEquatable<CreditCard>
{
   public static readonly CreditCard MyAmex1 = new(1
                                                 , "Capitaleers Amex"
                                                 , CreditCardBrand.AmericanExpress
                                                 , "Capitaleers"
                                                 , "1234-5678-9012-5678"
                                                 , "123"
                                                 , "2029-01"
                                                  );

   public static readonly CreditCard MyAmex2 = new(2
                                                 , "Finmong Amex"
                                                 , CreditCardBrand.AmericanExpress
                                                 , "Finacemongers"
                                                 , "2345-6789-0125-6781"
                                                 , "234"
                                                 , "2027-07"
                                                  );

   public static readonly CreditCard BlathersVisa = new(3
                                                      , "My Visa"
                                                      , CreditCardBrand.Visa
                                                      , "Blather's Group LLC"
                                                      , "3456-7890-1256-7812"
                                                      , "345"
                                                      , "2026-03"
                                                       );

   #region Properties and Constructors

   public CreditCard() : this("UNSET"
                            , CreditCardBrand.Unset
                            , "UNSET"
                            , "UNSET"
                            , "UNSET"
                            , "UNSET"
                             )
   {
   }

   public CreditCard(
      string?         name
    , CreditCardBrand brand
    , string?         bankName
    , string?         cardNumber
    , string?         ccv
    , string?         expirationDate
   ) : this(All.Max(i => i.Id) + 1
          , name
          , brand
          , bankName
          , cardNumber
          , ccv
          , expirationDate
           )
   {
   }

   /// <summary>
   /// 
   /// </summary>
   public int Id { get; } = id;

   /// <summary>
   /// The user provided name of the card.
   /// </summary>
   public string? Name { get; set; } = name;

   /// <summary>
   /// The credit card brand: Amex, Visa...etc.
   /// </summary>
   public CreditCardBrand Brand { get; set; } = brand;

   /// <summary>
   /// The bank issuing the card.
   /// </summary>
   public string? BankName { get; set; } = bankName;

   /// <summary>
   /// The card number.
   /// </summary>
   public string? CardNumber { get; set; } = cardNumber;

   /// <summary>
   /// The CCV for the card.
   /// </summary>
   public string? Ccv { get; set; } = ccv;

   /// <summary>
   /// The expiration date for the card.
   /// </summary>
   public string? ExpirationDate { get; set; } = expirationDate;

   public bool IsNew { get; set; } = isNew;

   #endregion

   public string GetCardSummary() { return $"ID: {Id}; Name: {Name}; Brand: {Brand.Name}; Exp: {ExpirationDate}"; }

   public string GetCardDetails()
   {
      const int width = -30;
      var       sb    = new StringBuilder();
      sb.Append($"ID    : {Id,width}");
      sb.AppendLine($"Name     : {Name}");
      sb.Append($"Brand : {Brand.Name,width}");
      sb.AppendLine($"Bank Name: {BankName}");
      sb.AppendLine($"Number: {CardNumber}");
      sb.Append($"Exp   : {ExpirationDate,width}");
      sb.AppendLine($"CCV      : {Ccv}");

      return sb.ToString();
   }

   // ReSharper disable once HeapView.ClosureAllocation
   public static CreditCard? FindByNameIdOrNumber(string? key)
   {
      return All.FirstOrDefault(b =>
                                   string.Compare(b.Name,       key, StringComparison.InvariantCultureIgnoreCase) == 0
                                || string.Compare(b.CardNumber, key, StringComparison.InvariantCultureIgnoreCase) == 0
                                || (int.TryParse(key, out var id) && b.Id == id)
                               );
   }

   public static void RemoveCardById(int id)
   {
      var card = All.FirstOrDefault(c => c.Id == id);

      if (card == null) return;
      ((List<CreditCard>) All).Remove(card);
   }

   public static bool AddCard(CreditCard newCard)
   {
      var card = All.FirstOrDefault(c => c.Id == newCard.Id);
      card ??=
         All.FirstOrDefault(c => string.Compare(c.Name, newCard.Name, StringComparison.InvariantCultureIgnoreCase) == 0
                           );

      if (card != null) return false;
      ((List<CreditCard>) All).Add(newCard);
      newCard.IsNew = false;

      return true;
   }

   public static bool UpdateCard(CreditCard cardData)
   {
      var card = All.FirstOrDefault(c => c.Id == cardData.Id);

      if (card == null) return false;
      card.Name           = cardData.Name;
      card.Brand          = cardData.Brand;
      card.BankName       = cardData.BankName;
      card.CardNumber     = cardData.CardNumber;
      card.Ccv            = cardData.Ccv;
      card.ExpirationDate = cardData.ExpirationDate;

      return true;
   }

   public bool Equals(CreditCard? other) { return other is not null && Id == other.Id; }

   public CreditCard Clone()
   {
      return new CreditCard(Id
                          , Name
                          , Brand
                          , BankName
                          , CardNumber
                          , Ccv
                          , ExpirationDate
                          , IsNew
                           );
   }

   public override bool Equals(object? obj) { return Equals(obj as CreditCard); }

   public override int GetHashCode() { return Id ^ GetType().GetHashCode(); }
}