#region

using Jcd.RichEnumerations.Classes;

#endregion

namespace Jcd.RichEnumerations.Examples;

public class CountrySelectorRichEnumBased
{
   public static void DoSomething()
   {
      // now use the items
      var region = GetRegion(); // get the selection from the UI, and if necessary translate to the enum.

      var countries = region.Countries;
      var countryNames = countries.Select(c => c.Name).ToList();

      foreach (var country in countryNames)
      {
         Console.WriteLine(country);
      }

      Console.WriteLine();
   }

   private static Region GetRegion()
   {
      // get input from user. Just hardcoded for this example.
      return Region.Europe;
   }

   #region Nested type: Country

   public class Country(int value, string name) : RichEnum<Country>(value)
   {
      // North America
      public static readonly Country Canada = new(0, "Canada");

      // Scandinavia
      public static readonly Country Denmark = new(1, "Denmark");

      // Europe
      public static readonly Country France = new(2, "France");

      // Europe
      public static readonly Country Germany = new(3, "Germany");

      // North America
      public static readonly Country Mexico = new(4, "Mexico");

      // Scandinavia
      public static readonly Country Norway = new(5, "Norway");

      // Scandinavia
      public static readonly Country Sweden = new(6, "Sweden");

      //Europe
      public static readonly Country UnitedKingdom = new(7, "UnitedKingdom");

      // North America
      public static readonly Country UnitedStates = new(8, "UnitedStates");

      #region properties

      public string Name { get; } = name;

      #endregion
   }

   #endregion

   #region Nested type: Region

   public class Region(int value, string name, Country[] countries) : RichEnum<Region>(value)
   {
      #region Enum items

      public static readonly Region Europe = new(1, "Europe", [Country.France, Country.Germany, Country.UnitedKingdom]);
      public static readonly Region Scandinavia = new(2, "Scandinavia", [Country.Denmark, Country.Norway, Country.Sweden]);
      public static readonly Region NorthAmerica = new(3, "North America", [Country.Canada, Country.Mexico, Country.UnitedStates]);

      #endregion

      #region properties

      public IReadOnlyList<Country> Countries { get; } = countries;

      public string Name { get; } = name;

      #endregion
   }

   #endregion
}