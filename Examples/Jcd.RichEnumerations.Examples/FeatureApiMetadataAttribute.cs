namespace Jcd.RichEnumerations.Examples;

public class EnumExample
{
   [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
   public class FeatureApiMetadataAttribute(int majorVer, int minorVer, string apiUri, string description) : Attribute
   {
      public Version ApiVer { get; } = new Version(majorVer, minorVer);
      public string Description { get; } = description;
      public Uri ApiUri { get; } = new(apiUri);
   }
   
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
      
     ,
   }
}