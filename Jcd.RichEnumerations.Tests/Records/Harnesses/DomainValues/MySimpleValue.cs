#region

using Jcd.RichEnumerations.Records;

#endregion

namespace Jcd.RichEnumerations.Tests.Records.Harnesses.DomainValues;

public record MySimpleValue(int value) : DomainValue<MySimpleValue>(value)
{
   public static readonly MySimpleValue ValueOne = new(1);
   public static readonly MySimpleValue ValueTwo = new(2);
   public static readonly MySimpleValue ValueTen = new(10);

   public static explicit operator MySimpleValue(int value)
   {
      return new MySimpleValue(value);
   }
}