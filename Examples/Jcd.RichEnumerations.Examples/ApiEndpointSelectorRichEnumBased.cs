#region

using Jcd.RichEnumerations.Classes;

#pragma warning disable S1075

#endregion

namespace Jcd.RichEnumerations.Examples;

public class ApiEndpointSelectorRichEnumBased
{
   public static void DoSomething()
   {
      Console.WriteLine($"Using a RichEnum instead of attaching metadata with attributes. See {nameof(ApiEndpointSelectorAttributeBased)} for the original code this refactors."
                       );

      // 2. Decode the enum to metadata.
      var featureAsInt = 1; // obtained somehow (user input?)
      var feature = (FeatureEndpointType) featureAsInt;

      // 3. Make the API call.
      Console.Write($"calling API endpoint at: {feature.ApiUri}");

      // or as a single line:
      Console.Write($"calling API endpoint at: {((FeatureEndpointType) featureAsInt).ApiUri}");
   }

   #region Nested type: FeatureEndpointType

   // 1. define the type
   public class FeatureEndpointType(int value, Version apiVer, Uri apiUri, string description) : RichEnum<FeatureEndpointType>(value)
   {
      #region enum values

      // THESE MUST BE FIELDS!

      public static readonly FeatureEndpointType AppFeature1V1 =
         new(1, new Version(1, 0), new Uri("https://localhost:9999/api/v1/feature1"), "feature1 api endpoint, for v1");

      public static readonly FeatureEndpointType AppFeature2V1 =
         new(2, new Version(1, 1), new Uri("https://localhost:9999/api/v1/feature2"), "feature2 api endpoint, for v1");

      public static readonly FeatureEndpointType AppFeature1V2 =
         new(3, new Version(2, 0), new Uri("https://localhost:9999/api/v2/feature1"), "feature1 api endpoint, for v2");

      public static readonly FeatureEndpointType AppFeature2V2 =
         new(4, new Version(2, 0), new Uri("https://localhost:9999/api/v2/feature2"), "feature2 api endpoint, for v2");

      #endregion

      #region Properties

      public Version ApiVer { get; } = apiVer;
      public Uri ApiUri { get; } = apiUri;
      public string Description { get; } = description;

      #endregion
   }

   #endregion
}