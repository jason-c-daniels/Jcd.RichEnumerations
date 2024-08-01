#region

using Jcd.RichEnumerations.Tests.Classes.Harnesses.DomainValues;

#endregion

namespace Jcd.RichEnumerations.Tests.Classes;

public class DomainValueTests
{
   [Fact]
   public void With_Default_Value_Type_Value_Is_Int32()
   {
      Assert.Equal(typeof(int), MySimpleValue.ValueOne.Value.GetType());
   }

   [Fact]
   public void With_Custom_Value_Type_Value_Is_Long()
   {
      Assert.Equal(typeof(long), MySimpleValue2.ValueOne.Value.GetType());
   }

   [Fact]
   public void op_Equals_Returns_True_With_Two_Null_Values()
   {
      MySimpleValue? v1 = null;
      MySimpleValue? v2 = null;
      Assert.True(v1 == v2);
   }

   [Fact]
   public void op_Equals_Returns_False_With_One_Null_Value()
   {
      var v1 = MySimpleValue.ValueOne;
      MySimpleValue? v2 = null;
      Assert.False(v1 == v2);
      v2 = v1;
      v1 = null;
      Assert.False(v1 == v2);
   }

   [Theory]
   [InlineData(1,  "1")]
   [InlineData(2,  "2")]
   [InlineData(10, "10")]
   public void ToString_Returns_Expected_String(int value, string expected)
   {
      Assert.Equal(expected, ((MySimpleValue) value).ToString());
   }

   [Fact]
   public void GetHashCode_Returns_Expected_Value()
   {
      Assert.Equal(MySimpleValue.ValueTen.Value ^ MySimpleValue.ValueTen.GetType().GetHashCode(), MySimpleValue.ValueTen.GetHashCode());
   }

   [Theory]
   [InlineData(1)]
   [InlineData(2)]
   [InlineData(10)]
   public void Conversion_Operator_Round_Trip_Returns_Original_Value(int value)
   {
      var enumValue = (MySimpleValue) value;
      Assert.Equal(value, (int) enumValue);
   }

   [Theory]
   [InlineData(1,  1, true)]
   [InlineData(2,  2, true)]
   [InlineData(10, 1, false)]
   public void Equals_Operator_Returns_Expected_Value(int value1, int value2, bool expectedValue)
   {
      var ev1 = (MySimpleValue) value1;
      var ev2 = (MySimpleValue) value2;
      Assert.Equal(expectedValue, ev1 == ev2);
   }

   [Theory]
   [InlineData(1,  1, false)]
   [InlineData(2,  2, false)]
   [InlineData(10, 1, true)]
   [InlineData(10, 2, true)]
   [InlineData(2,  1, true)]
   public void Not_Equals_Operator_Returns_Expected_Value(int value1, int value2, bool expectedValue)
   {
      var ev1 = (MySimpleValue) value1;
      var ev2 = (MySimpleValue) value2;
      Assert.Equal(expectedValue, ev1 != ev2);
   }
}