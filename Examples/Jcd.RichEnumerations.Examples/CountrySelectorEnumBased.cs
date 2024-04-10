namespace Jcd.RichEnumerations.Examples;

public class CountrySelectorEnumBased
{
   #region Country enum

   public enum Country
   {
      // North America
      Canada
     ,

      // Scandinavia
      Denmark
     ,

      // Europe
      France
     ,

      // Europe
      Germany
     ,

      // North America
      Mexico
     ,

      // Scandinavia
      Norway
     ,

      // Scandinavia
      Sweden
     ,

      //Europe
      UnitedKingdom
     ,

      // North America
      UnitedStates
   }

   #endregion

   #region Region enum

   public enum Region
   {
      Europe
    , NorthAmerica
    , Scandinavia
   }

   #endregion

   public static void DoSomething()
   {
      var region = GetRegion(); // get the selection from the UI, and if necessary translate to the enum.

      var countries = GetCountries(region);
      var countryNames = countries.Select(c => GetCountryName(c)).ToList();

      //... display the list to the user...
      foreach (var country in countryNames)
      {
         Console.WriteLine(country);
      }

      Console.WriteLine();
   }

   private static Country[] GetCountries(Region region)
   {
      return region switch
             {
                Region.Europe       => [Country.France, Country.Germany, Country.UnitedKingdom]
              , Region.Scandinavia  => [Country.Denmark, Country.Norway, Country.Sweden]
              , Region.NorthAmerica => [Country.Canada, Country.Mexico, Country.UnitedStates]
              , _                   => throw new ArgumentException("Invalid Value", nameof(region))
             };
   }

   private static string GetCountryName(Country country)
   {
      // convert the Country to a localized string.
      // just call ToString for this example.
      return country.ToString();
   }

   private static Region GetRegion()
   {
      // get input from user. Just hardcoded for this example.
      return Region.Europe;
   }
}