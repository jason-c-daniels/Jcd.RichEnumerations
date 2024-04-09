// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable HeapView.DelegateAllocation

#region

using Jcd.RichEnumerations.Classes.Wrappers;

#endregion

namespace Jcd.RichEnumerations.Examples.CardSelector;

public class CreditCardBrand(int value, string name, string abbreviation, string description) : NamedAndDescribedRichEnum<CreditCardBrand>(value, name, description)
{
   public static readonly CreditCardBrand Unset = new(0, nameof(Unset), "NA", "No value has been provided.");
   public static readonly CreditCardBrand AmericanExpress = new(1, nameof(AmericanExpress), "AE", "American Express");
   public static readonly CreditCardBrand Discover = new(2, nameof(Discover), "DSC", "Discover");
   public static readonly CreditCardBrand Mastercard = new(3, nameof(Mastercard), "MC", "Mastercard");
   public static readonly CreditCardBrand Visa = new(4, nameof(Visa), "V", "Visa");

   #region Instance Properties and Methods

   public string Abbreviation { get; } = abbreviation;

   public static CreditCardBrand? FromNameOrAbbreviation(string key)
   {
      return All.FirstOrDefault(b => StringsMatch(key, b.Name) || StringsMatch(key, b.Abbreviation));
   }

   private const StringComparison StringMatchOptions = StringComparison.InvariantCultureIgnoreCase;

   private static bool StringsMatch(string first, string second)
   {
      return string.Compare(first, second, StringMatchOptions) == 0;
   }

   #endregion
}