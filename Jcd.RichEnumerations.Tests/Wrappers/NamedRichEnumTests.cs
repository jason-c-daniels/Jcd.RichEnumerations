#region

using Jcd.RichEnumerations.Wrappers;

#endregion

namespace Jcd.RichEnumerations.Tests.Wrappers;

public class NamedRichEnumTests
{
   [Theory]
   [InlineData(1, "Name A")]
   [InlineData(2, "Name B")]
   public void Constructor_Set_Expected_Values(int id, string desc)
   {
      var sut = new NamedEnumHarness(id, desc);
      Assert.Equal(id,   sut.Value);
      Assert.Equal(desc, sut.Name);
      Assert.Contains(id.ToString(), sut.ToString());
      Assert.Contains(desc,          sut.ToString());
   }

   [Theory]
   [InlineData(1, "Name A")]
   [InlineData(2, "Name B")]
   public void ToString_Contains_Value_And_Name(int id, string desc)
   {
      var sut = new NamedEnumHarness(id, desc);
      Assert.Contains(id.ToString(), sut.ToString());
      Assert.Contains(desc,          sut.ToString());
   }

   #region Nested type: NamedEnumHarness

   private class NamedEnumHarness : NamedRichEnum<NamedEnumHarness>
   {
      public NamedEnumHarness(int value, string desc)
         : base(value, desc)
      {
      }
   }

   #endregion
}