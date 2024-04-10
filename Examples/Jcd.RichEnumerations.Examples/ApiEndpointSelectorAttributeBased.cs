#region

using Jcd.Reflection;

#endregion

namespace Jcd.RichEnumerations.Examples;
#pragma warning disable S1075

public class ApiEndpointSelectorAttributeBased
{
   #region FeatureEndpointType enum

   public enum FeatureEndpointType
   {
      [FeatureApiMetadata(1, 0, "https://localhost:9999/api/v1/feature1", "feature1 api endpoint, for v1")]
      AppFeature1V1

    , [FeatureApiMetadata(1, 1, "https://localhost:9999/api/v1/feature2", "feature2 api endpoint, for v1")]
      AppFeature2V1

    , [FeatureApiMetadata(2, 0, "https://localhost:9999/api/v2/feature1", "feature1 api endpoint, for v2")]
      AppFeature1V2

    , [FeatureApiMetadata(2, 0, "https://localhost:9999/api/v2/feature2", "feature2 api endpoint, for v2")]
      AppFeature2V2
   }

   #endregion

   public static void DoSomething()
   {
      Console.WriteLine($"Getting enum data embedded in attributes. See {nameof(ApiEndpointSelectorRichEnumBased)} for how to refactor this.");

      // 2. Decode the enum to metadata.
      var featureAsInt = 1; // obtained somehow (user input?)
      var feature = (FeatureEndpointType) featureAsInt;
      var metadata = feature.GetCustomAttributes<FeatureApiMetadataAttribute>()[0];

      var uri = metadata.ApiUri;

      // 3. Make the API call.
      Console.Write($"calling API endpoint at: {uri}");
   }

   #region Nested type: FeatureApiMetadataAttribute

   // 1. define the types
   [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
   public class FeatureApiMetadataAttribute(int majorVer, int minorVer, string apiUri, string description) : Attribute
   {
      public Version ApiVer { get; } = new(majorVer, minorVer);
      public string Description { get; } = description;
      public Uri ApiUri { get; } = new(apiUri);
   }

   #endregion
}