#region

using Jcd.RichEnumerations.Tests.Classes.Harnesses.Enums;

#endregion

namespace Jcd.RichEnumerations.Tests.Classes;

public class SortableRichEnumTests
{
   [Fact]
   public void Default_ValueType_Value_Is_Int32()
   {
      Assert.Equal(typeof(int), MySortableEnum.ValueOne.Value.GetType());
   }

   [Fact]
   public void With_Custom_Value_Type_Value_Is_Long()
   {
      Assert.Equal(typeof(long), MySortableEnum2.ValueOne.Value.GetType());
   }

   [Fact]
   public void Default_ValueType_ByValue_Returns_Expected_Dictionary()
   {
      var dict = MySortableEnum.ByValue;
      Assert.Contains(MySortableEnum.ValueOne.Value, dict);
      Assert.Contains(MySortableEnum.ValueTwo.Value, dict);
      Assert.Contains(MySortableEnum.ValueTen.Value, dict);
   }

   [Fact]
   public void Default_ValueType_All_Contains_Expected_Values()
   {
      Assert.Equal(3, MySortableEnum.All.Count);
      Assert.Contains(MySortableEnum.ValueOne, MySortableEnum.All);
      Assert.Contains(MySortableEnum.ValueTwo, MySortableEnum.All);
      Assert.Contains(MySortableEnum.ValueTen, MySortableEnum.All);
   }

   [Fact]
   public void op_Equals_Returns_True_With_Two_Null_Values()
   {
      MySortableEnum? v1 = null;
      MySortableEnum? v2 = null;
      Assert.True(v1 == v2);
   }

   [Fact]
   public void op_Equals_Returns_False_With_One_Null_Value()
   {
      var v1 = MySortableEnum.ValueOne;
      MySortableEnum? v2 = null;
      Assert.False(v1 == v2);
      v2 = v1;
      v1 = null;
      Assert.False(v1 == v2);
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
   [InlineData(1,  "1")]
   [InlineData(2,  "2")]
   [InlineData(10, "10")]
   public void ToString_Returns_Expected_String(int value, string expected)
   {
      Assert.Equal(expected, ((MySortableEnum) value).ToString());
   }

   [Fact]
   public void GetHashCode_Returns_Expected_Value()
   {
      Assert.Equal(MySortableEnum.ValueTen.Value ^ MySortableEnum.ValueTen.GetType().GetHashCode(), MySortableEnum.ValueTen.GetHashCode());
   }

   [Theory]
   [InlineData(1)]
   [InlineData(2)]
   [InlineData(10)]
   public void Conversion_Operator_Round_Trip_Returns_Original_Value(int value)
   {
      var enumValue = (MySortableEnum) value;
      Assert.Equal(value, (int) enumValue);
   }

   [Theory]
   [InlineData(1,  1,    0)]
   [InlineData(1,  2,    -1)]
   [InlineData(10, 1,    1)]
   [InlineData(1,  null, -1)]
   public void CompareTo_Returns_Expected_Value(int value1, int? value2, int expectedValue)
   {
      var ev1 = (MySortableEnum) value1;
      var ev2 = value2 == null
                   ? null
                   : (MySortableEnum) value2;
      Assert.Equal(expectedValue, ev1.CompareTo(ev2!));
   }

   [Theory]
   [InlineData(1,    1,    false)]
   [InlineData(1,    2,    false)]
   [InlineData(10,   1,    true)]
   [InlineData(null, null, false)]
   [InlineData(1,    null, false)]
   [InlineData(null, 2,    true)]
   public void GreaterThan_Operator_Returns_Expected_Value(int? value1, int? value2, bool expectedValue)
   {
      var ev1 = value1 == null
                   ? null
                   : (MySortableEnum) value1;
      var ev2 = value2 == null
                   ? null
                   : (MySortableEnum) value2;
      Assert.Equal(expectedValue, ev1 > ev2);
   }

   [Theory]
   [InlineData(1,    1,    true)]
   [InlineData(1,    2,    false)]
   [InlineData(10,   1,    true)]
   [InlineData(null, null, true)]
   [InlineData(1,    null, false)]
   [InlineData(null, 2,    true)]
   public void GreaterThanOrEqual_Operator_Returns_Expected_Value(int? value1, int? value2, bool expectedValue)
   {
      var ev1 = value1 == null
                   ? null
                   : (MySortableEnum) value1;
      var ev2 = value2 == null
                   ? null
                   : (MySortableEnum) value2;
      Assert.Equal(expectedValue, ev1 >= ev2);
   }

   [Theory]
   [InlineData(1,    1,    false)]
   [InlineData(1,    2,    true)]
   [InlineData(10,   1,    false)]
   [InlineData(null, null, false)]
   [InlineData(1,    null, true)]
   [InlineData(null, 2,    false)]
   public void LessThan_Operator_Returns_Expected_Value(int? value1, int? value2, bool expectedValue)
   {
      var ev1 = value1 == null
                   ? null
                   : (MySortableEnum) value1;
      var ev2 = value2 == null
                   ? null
                   : (MySortableEnum) value2;
      Assert.Equal(expectedValue, ev1 < ev2);
   }

   [Theory]
   [InlineData(1,    1,    true)]
   [InlineData(1,    2,    true)]
   [InlineData(10,   1,    false)]
   [InlineData(null, null, true)]
   [InlineData(1,    null, true)]
   [InlineData(null, 2,    false)]
   public void LessThanOrEqual_Operator_Returns_Expected_Value(int? value1, int? value2, bool expectedValue)
   {
      var ev1 = value1 == null
                   ? null
                   : (MySortableEnum) value1;
      var ev2 = value2 == null
                   ? null
                   : (MySortableEnum) value2;
      Assert.Equal(expectedValue, ev1 <= ev2);
   }

   [Theory]
   [InlineData(1,  1, true)]
   [InlineData(2,  2, true)]
   [InlineData(10, 1, false)]
   public void Equals_Operator_Returns_Expected_Value(int value1, int value2, bool expectedValue)
   {
      var ev1 = (MySortableEnum) value1;
      var ev2 = (MySortableEnum) value2;
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
      var ev1 = (MySortableEnum) value1;
      var ev2 = (MySortableEnum) value2;
      Assert.Equal(expectedValue, ev1 != ev2);
   }

   [Theory]
   [InlineData(3)]
   [InlineData(5)]
   [InlineData(7)]
   [InlineData(111)]
   public void Conversion_Operator_Throws_Exception_When_Given_Invalid_Value(int value)
   {
      Assert.Throws<ArgumentException>(() => (MySortableEnum) value);
   }

   [Fact]
   public void With_Custom_Value_Type_All_Contains_Expected_Values()
   {
      Assert.Equal(4, MySortableEnum2.All.Count);
      Assert.Contains(MySortableEnum2.ValueOne,         MySortableEnum2.All);
      Assert.Contains(MySortableEnum2.ValueTwo,         MySortableEnum2.All);
      Assert.Contains(MySortableEnum2.ValueTen,         MySortableEnum2.All);
      Assert.Contains(MySortableEnum2.ValueNegativeTen, MySortableEnum2.All);
   }

   [Fact]
   public void CompareTo_Derived_Type_Returns_NonZero()
   {
      Assert.NotEqual(0, MySortableEnum2.ValueOne.CompareTo(MySortableEnum3.ValueOne));
   }

   [Fact]
   public void Sort_With_Default_Comparison_Sorts_Ascending_Numerically()
   {
      var unsorted = MySortableEnum2.All.ToList();
      var sorted = unsorted.ToList();
      sorted.Sort((x, y) => x.Value.CompareTo(y.Value));
      MySortableEnum2.Sort();
      Assert.Equal(sorted, MySortableEnum2.All);
   }

   [Fact]
   public void Sort_With_Custom_Comparison_Sorts_Ascending_Numerically()
   {
      var unsorted = MySortableEnum2.All.ToList();
      var sorted = unsorted.ToList();
      Comparison<MySortableEnum2> c = (x, y) => y.Value.CompareTo(x.Value);
      sorted.Sort(c);
      MySortableEnum2.Sort(c);
      Assert.Equal(sorted, MySortableEnum2.All);
   }
}