#region

using Jcd.RichEnumerations.Wrappers;

#endregion

namespace Jcd.RichEnumerations.Tests.Wrappers;

public class NamedAndDescribedSortableRichEnumTests
{
   [Theory]
   [InlineData(1, "Name A", "Description A")]
   [InlineData(2, "Name B", "Description B")]
   public void Constructor_Set_Expected_Values(int id, string name, string desc)
   {
      var sut = new NamedAndDescribedSortableRichEnumHarness(id, name, desc);
      Assert.Equal(id,   sut.Value);
      Assert.Equal(name, sut.Name);
      Assert.Equal(desc, sut.Description);
   }

   [Theory]
   [InlineData(1, "Name A", "Description A")]
   [InlineData(2, "Name B", "Description B")]
   public void ToString_Contains_Value_And_Name(int id, string name, string desc)
   {
      var sut = new NamedAndDescribedSortableRichEnumHarness(id, name, desc);
      Assert.Contains(id.ToString(), sut.ToString());
      Assert.Contains(name,          sut.ToString());
      Assert.Contains(desc,          sut.ToString());
   }

   #region Nested type: NamedAndDescribedSortableRichEnumHarness

   private class NamedAndDescribedSortableRichEnumHarness : NamedAndDescribedSortableRichEnum<NamedAndDescribedSortableRichEnumHarness>
   {
      public NamedAndDescribedSortableRichEnumHarness(int value, string name, string desc)
         : base(value, name, desc)
      {
      }
   }

   #endregion
}