#region

using Jcd.RichEnumerations.Tests.Records.Harnesses.DomainValues;

#endregion

namespace Jcd.RichEnumerations.Tests.Records;

public class SortableDomainValueTests
{
   [Fact]
   public void Default_ValueType_Value_Is_Int32()
   {
      Assert.Equal(typeof(int), MySortableValue.ValueOne.Value.GetType());
   }

   [Fact]
   public void With_Custom_Value_Type_Value_Is_Long()
   {
      Assert.Equal(typeof(long), MySortableValue2.ValueOne.Value.GetType());
   }

   [Fact]
   public void op_Equals_Returns_True_With_Two_Null_Values()
   {
      MySortableValue? v1 = null;
      MySortableValue? v2 = null;
      Assert.True(v1 == v2);
   }

   [Fact]
   public void op_Equals_Returns_False_With_One_Null_Value()
   {
      var v1 = MySortableValue.ValueOne;
      MySortableValue? v2 = null;
      Assert.False(v1 == v2);
      v2 = v1;
      v1 = null;
      Assert.False(v1 == v2);
   }

   [Theory]
   [InlineData(3,  "3")]
   [InlineData(2,  "2")]
   [InlineData(10, "10")]
   public void ToString_Returns_Expected_String(int value, string expected)
   {
      Assert.Contains(expected, ((MySortableValue) value).ToString());
   }

   [Fact]
   public void GetHashCode_Returns_Unique_Value_Per_Type()
   {
      Assert.NotEqual(MySortableValue.ValueTen.GetHashCode(), MySortableValue2.ValueTen.GetHashCode());
   }

   [Theory]
   [InlineData(1)]
   [InlineData(2)]
   [InlineData(10)]
   public void Conversion_Operator_Round_Trip_Returns_Original_Value(int value)
   {
      var enumValue = (MySortableValue) value;
      Assert.Equal(value, (int) enumValue);
   }

   [Theory]
   [InlineData(1,  1,    0)]
   [InlineData(1,  2,    -1)]
   [InlineData(10, 1,    1)]
   [InlineData(1,  null, -1)]
   public void CompareTo_Returns_Expected_Value(int value1, int? value2, int expectedValue)
   {
      var ev1 = (MySortableValue) value1;
      var ev2 = value2 == null
                   ? null
                   : (MySortableValue) value2;
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
                   : (MySortableValue) value1;
      var ev2 = value2 == null
                   ? null
                   : (MySortableValue) value2;
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
                   : (MySortableValue) value1;
      var ev2 = value2 == null
                   ? null
                   : (MySortableValue) value2;
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
                   : (MySortableValue) value1;
      var ev2 = value2 == null
                   ? null
                   : (MySortableValue) value2;
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
                   : (MySortableValue) value1;
      var ev2 = value2 == null
                   ? null
                   : (MySortableValue) value2;
      Assert.Equal(expectedValue, ev1 <= ev2);
   }

   [Theory]
   [InlineData(1,  1, true)]
   [InlineData(2,  2, true)]
   [InlineData(10, 1, false)]
   public void Equals_Operator_Returns_Expected_Value(int value1, int value2, bool expectedValue)
   {
      var ev1 = (MySortableValue) value1;
      var ev2 = (MySortableValue) value2;
      Assert.Equal(expectedValue, ev1 == ev2);
   }

   [Theory]
   [InlineData(1,  1,  false)]
   [InlineData(2,  2,  false)]
   [InlineData(10, 1,  true)]
   [InlineData(10, 2,  true)]
   [InlineData(1,  10, true)]
   [InlineData(1,  20, true)]
   [InlineData(2,  1,  true)]
   public void Not_Equals_Operator_Returns_Expected_Value(int value1, int value2, bool expectedValue)
   {
      var ev1 = (MySortableValue) value1;
      var ev2 = (MySortableValue) value2;
      Assert.Equal(expectedValue, ev1 != ev2);
   }

   [Fact]
   public void CompareTo_Derived_Type_Returns_NonZero()
   {
      Assert.NotEqual(0, MySortableValue2.ValueOne.CompareTo(MySortableValue3.ValueTwo2));
   }
}