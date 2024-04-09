#region

using Jcd.RichEnumerations.Wrappers;

#endregion

namespace Jcd.RichEnumerations.Tests.Wrappers;

public class DescribedRichEnumTests
{
   [Theory]
   [InlineData(1, "Description A")]
   [InlineData(2, "Description B")]
   public void Constructor_Set_Expected_Values(int id, string desc)
   {
      var sut = new DescEnumHarness(id, desc);
      Assert.Equal(id,   sut.Value);
      Assert.Equal(desc, sut.Description);
      Assert.Contains(id.ToString(), sut.ToString());
      Assert.Contains(desc,          sut.ToString());
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

   private class DescEnumHarness : DescribedRichEnum<DescEnumHarness>
   {
      public DescEnumHarness(int value, string desc)
         : base(value, desc)
      {
      }
   }

   #endregion
}