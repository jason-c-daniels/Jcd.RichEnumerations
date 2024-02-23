// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global

// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable HeapView.DelegateAllocation

namespace Jcd.RichEnumerations.Examples.CardSelector;

public class CreditCardBrand(int value, string name, string abbreviation, string description)
   : NamedAndDescribedRichEnum<CreditCardBrand>(value, name, description)
{
   public static readonly CreditCardBrand Unset           = new(0, nameof(Unset), "NA", "No value has been provided.");
   public static readonly CreditCardBrand AmericanExpress = new(1, nameof(AmericanExpress), "AE", "American Express");
   public static readonly CreditCardBrand Discover        = new(2, nameof(Discover), "DSC", "Discover");
   public static readonly CreditCardBrand Mastercard      = new(3, nameof(Mastercard), "MC", "Mastercard");
   public static readonly CreditCardBrand Visa            = new(4, nameof(Visa), "V", "Visa");

   public static CreditCardBrand? FromNameOrAbbreviation(string nameOrAbbreviation)
   {
      return All.FirstOrDefault(b =>
                                   string.Compare(b.Name
                                                , nameOrAbbreviation
                                                , StringComparison.InvariantCultureIgnoreCase
                                                 )
                                == 0
                                || string.Compare(b.Abbreviation
                                                , nameOrAbbreviation
                                                , StringComparison.InvariantCultureIgnoreCase
                                                 )
                                == 0
                               );
   }

   public string Abbreviation { get; } = abbreviation;
}