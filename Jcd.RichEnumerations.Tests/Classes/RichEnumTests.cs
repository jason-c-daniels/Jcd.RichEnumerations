#region

using Jcd.RichEnumerations.Tests.Classes.Harnesses.Enums;

#endregion

namespace Jcd.RichEnumerations.Tests.Classes;

public class RichEnumTests
{
   [Fact]
   public void With_Default_Value_Type_Value_Is_Int32()
   {
      Assert.Equal(typeof(int), MySimpleEnum.ValueOne.Value.GetType());
   }

   [Fact]
   public void With_Custom_Value_Type_Value_Is_Long()
   {
      Assert.Equal(typeof(long), MySimpleEnum2.ValueOne.Value.GetType());
   }

   [Fact]
   public void With_Default_Value_Type_ByValue_Returns_Expected_Dictionary()
   {
      var dict = MySimpleEnum.ByValue;
      Assert.Contains(MySimpleEnum.ValueOne.Value, dict);
      Assert.Contains(MySimpleEnum.ValueTwo.Value, dict);
      Assert.Contains(MySimpleEnum.ValueTen.Value, dict);
   }

   [Fact]
   public void With_Default_Value_Type_All_Contains_Expected_Values()
   {
      Assert.Equal(3, MySimpleEnum.All.Count);
      Assert.Contains(MySimpleEnum.ValueOne, MySimpleEnum.All);
      Assert.Contains(MySimpleEnum.ValueTwo, MySimpleEnum.All);
      Assert.Contains(MySimpleEnum.ValueTen, MySimpleEnum.All);
   }

   [Fact]
   public void op_Equals_Returns_True_With_Two_Null_Values()
   {
      MySimpleEnum? v1 = null;
      MySimpleEnum? v2 = null;
      Assert.True(v1 == v2);
   }

   [Fact]
   public void op_Equals_Returns_False_With_One_Null_Value()
   {
      var v1 = MySimpleEnum.ValueOne;
      MySimpleEnum? v2 = null;
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
      Assert.Equal(expected, ((MySimpleEnum) value).ToString());
   }

   [Fact]
   public void GetHashCode_Returns_Expected_Value()
   {
      Assert.Equal(MySimpleEnum.ValueTen.Value ^ MySimpleEnum.ValueTen.GetType().GetHashCode(), MySimpleEnum.ValueTen.GetHashCode());
   }

   [Theory]
   [InlineData(1)]
   [InlineData(2)]
   [InlineData(10)]
   public void Conversion_Operator_Round_Trip_Returns_Original_Value(int value)
   {
      var enumValue = (MySimpleEnum) value;
      Assert.Equal(value, (int) enumValue);
   }

   [Theory]
   [InlineData(1,  1, true)]
   [InlineData(2,  2, true)]
   [InlineData(10, 1, false)]
   public void Equals_Operator_Returns_Expected_Value(int value1, int value2, bool expectedValue)
   {
      var ev1 = (MySimpleEnum) value1;
      var ev2 = (MySimpleEnum) value2;
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
      var ev1 = (MySimpleEnum) value1;
      var ev2 = (MySimpleEnum) value2;
      Assert.Equal(expectedValue, ev1 != ev2);
   }

   [Theory]
   [InlineData(1,  true)]
   [InlineData(2,  true)]
   [InlineData(3,  false)]
   [InlineData(4,  false)]
   [InlineData(10, true)]
   public void IsValid_Returns_The_Expected_Result(int value, bool expected)
   {
      Assert.Equal(expected, MySimpleEnum.IsValid(value));
   }

   [Theory]
   [InlineData(3)]
   [InlineData(5)]
   [InlineData(7)]
   [InlineData(111)]
   public void Conversion_Operator_Throws_Exception_When_Given_Invalid_Value(int value)
   {
      Assert.Throws<ArgumentException>(() => (MySimpleEnum) value);
   }

   [Fact]
   public void With_Custom_Value_Type_All_Contains_Expected_Values()
   {
      Assert.Equal(3, MySimpleEnum2.All.Count);
      Assert.Contains(MySimpleEnum2.ValueOne, MySimpleEnum2.All);
      Assert.Contains(MySimpleEnum2.ValueTwo, MySimpleEnum2.All);
      Assert.Contains(MySimpleEnum2.ValueTen, MySimpleEnum2.All);
   }
}