#region

using Jcd.RichEnumerations.Records.Wrappers;

#endregion

namespace Jcd.RichEnumerations.Tests.Records.Wrappers;

public class DescribedSortableRichEnumTests
{
   [Theory]
   [InlineData(1, "Description A")]
   [InlineData(2, "Description B")]
   public void Constructor_Sets_Expected_Values(int id, string desc)
   {
      var sut = new DescEnumHarness(id, desc);
      var sut2 = sut with { };
      Assert.Equal(id,   sut.Value);
      Assert.Equal(desc, sut.Description);
      Assert.Equal(id,   sut2.Value);
      Assert.Equal(desc, sut2.Description);
   }

   [Theory]
   [InlineData(1, "Description A")]
   [InlineData(2, "Description B")]
   public void ToString_Contains_Value_And_Description(int id, string desc)
   {
      var sut = new DescEnumHarness(id, desc);
      Assert.Contains(id.ToString(), sut.ToString());
      Assert.Contains(desc,          sut.ToString());
   }

   #region Nested type: DescEnumHarness

   private record DescEnumHarness : DescribedSortableRichEnum<DescEnumHarness>
   {
      public DescEnumHarness(int value, string desc)
         : base(value, desc)
      {
      }
   }

   #endregion
}