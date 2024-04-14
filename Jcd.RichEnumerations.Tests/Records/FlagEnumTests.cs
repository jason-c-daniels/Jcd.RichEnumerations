namespace Jcd.RichEnumerations.Tests.Records;

public class FlagEnumTests
{
   [Fact]
   public void With_Default_Value_Type_Value_Is_UInt64()
   {
      Assert.Equal(typeof(ulong), MyFlagEnum.Flag1.Value.GetType());
   }

   [Fact]
   public void With_Default_Value_Type_ByValue_Returns_Expected_Dictionary()
   {
      var dict = MyFlagEnum.ByValue;
      Assert.Contains(MyFlagEnum.Flag1.Value, dict);
      Assert.Contains(MyFlagEnum.Flag2.Value, dict);
      Assert.Contains(MyFlagEnum.Flag4.Value, dict);
   }

   [Fact]
   public void With_Default_Value_Type_All_Contains_Expected_Values()
   {
      Assert.Equal(6, MyFlagEnum.All.Count);
      Assert.Contains(MyFlagEnum.Flag1, MyFlagEnum.All);
      Assert.Contains(MyFlagEnum.Flag2, MyFlagEnum.All);
      Assert.Contains(MyFlagEnum.Flag4, MyFlagEnum.All);
   }

   [Fact]
   public void op_Equals_Returns_True_With_Two_Null_Values()
   {
      MyFlagEnum? v1 = null;
      MyFlagEnum? v2 = null;
      Assert.True(v1 == v2);
   }

   [Fact]
   public void op_Equals_Returns_False_With_One_Null_Value()
   {
      var v1 = MyFlagEnum.Flag1;
      MyFlagEnum? v2 = null;
      Assert.False(v1 == v2);
      v2 = v1;
      v1 = null;
      Assert.False(v1 == v2);
   }

   [Theory]
   [InlineData(1, "Flag1")]
   [InlineData(2, "Flag2")]
   [InlineData(4, "Flag3")]
   public void ToString_Contains_Expected_String(ulong value, string expected)
   {
      Assert.Contains(expected, ((MyFlagEnum) value).ToString());
   }

   [Fact]
   public void GetHashCode_Returns_Different_Values_For_Different_Types()
   {
      Assert.NotEqual(MyFlagEnum.Flag4.GetHashCode(), MyFlagEnum2.Flag4.GetHashCode());
   }

   [Theory]
   [InlineData(1)]
   [InlineData(2)]
   [InlineData(4)]
   public void Conversion_Operator_Round_Trip_Returns_Original_Value(ulong value)
   {
      var enumValue = (MyFlagEnum) value;
      Assert.Equal(value, (ulong) enumValue);
   }

   [Theory]
   [InlineData(1, "Flag1",          false)]
   [InlineData(2, "Flag2",          false)]
   [InlineData(3, "[Flag1, Flag2]", true)]
   [InlineData(4, "Flag3",          false)]
   public void Conversion_Operator_Sets_Expected_Properties(ulong value, string name, bool isSynthesized)
   {
      var enumValue = (MyFlagEnum) value;
      Assert.Equal(value,         enumValue.Value);
      Assert.Equal(name,          enumValue.Name);
      Assert.Equal(isSynthesized, enumValue.IsSynthesized);
   }

   [Theory]
   [InlineData(1, 2, 1 | 2)]
   [InlineData(2, 4, 2 | 4)]
   [InlineData(4, 8, 4 | 8)]
   public void op_BitwiseOr_On_Two_FlagEnums_Returns_Expected_Value(ulong v1, ulong v2, ulong expected)
   {
      var f1 = (MyFlagEnum) v1;
      var f2 = (MyFlagEnum) v2;
      Assert.Equal(expected, f1 | f2);
   }

   [Theory]
   [InlineData(1, 2, 1 | 2)]
   [InlineData(2, 4, 2 | 4)]
   [InlineData(4, 8, 4 | 8)]
   public void op_BitwiseOr_On_FlagEnum_And_UInt64_Returns_Expected_Value(ulong v1, ulong v2, ulong expected)
   {
      var f1 = (MyFlagEnum) v1;
      Assert.Equal(expected, f1 | v2);
      Assert.Equal(expected, v2 | f1);
   }

   [Theory]
   [InlineData(1, 1, true)]
   [InlineData(2, 2, true)]
   [InlineData(3, 3, true)]
   [InlineData(4, 1, false)]
   [InlineData(5, 3, false)]
   public void Equals_Operator_Returns_Expected_Value(ulong value1, ulong value2, bool expectedValue)
   {
      var ev1 = (MyFlagEnum) value1;
      var ev2 = (MyFlagEnum) value2;
      Assert.Equal(expectedValue, ev1 == ev2);
   }

   [Theory]
   [InlineData(1, 1, false)]
   [InlineData(2, 2, false)]
   [InlineData(4, 1, true)]
   [InlineData(8, 2, true)]
   [InlineData(2, 1, true)]
   public void Not_Equals_Operator_Returns_Expected_Value(ulong value1, ulong value2, bool expectedValue)
   {
      var ev1 = (MyFlagEnum) value1;
      var ev2 = (MyFlagEnum) value2;
      Assert.Equal(expectedValue, ev1 != ev2);
   }

   [Theory]
   [InlineData(33)]
   [InlineData(55)]
   [InlineData(117)]
   [InlineData(111)]
   public void Conversion_Operator_Throws_Exception_When_Given_Invalid_Value(ulong value)
   {
      Assert.Throws<ArgumentException>(() => (MyFlagEnum) value);
   }
}