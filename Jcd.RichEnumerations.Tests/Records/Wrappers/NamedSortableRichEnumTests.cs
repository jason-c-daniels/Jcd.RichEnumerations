#region

using Jcd.RichEnumerations.Records.Wrappers;

#endregion

namespace Jcd.RichEnumerations.Tests.Records.Wrappers;

public class NamedSortableRichEnumTests
{
   [Theory]
   [InlineData(1, "Name A")]
   [InlineData(2, "Name B")]
   public void Constructor_Sets_Expected_Values(int id, string desc)
   {
      var sut = new NamedEnumHarness(id, desc);
      var sut2 = sut with { };
      Assert.Equal(id,   sut.Value);
      Assert.Equal(desc, sut.Name);
      Assert.Equal(id,   sut2.Value);
      Assert.Equal(desc, sut2.Name);
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

   private record NamedEnumHarness : NamedSortableRichEnum<NamedEnumHarness>
   {
      public NamedEnumHarness(int value, string desc)
         : base(value, desc)
      {
      }
   }

   #endregion
}