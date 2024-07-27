#region

using Jcd.RichEnumerations.Classes;

#endregion

namespace Jcd.RichEnumerations.Tests.Classes.Harnesses.DomainValues;

public class MySimpleValue2(long value) : DomainValue<long, MySimpleValue2>(value)
{
   public static readonly MySimpleValue2 ValueOne = new(1);
   public static readonly MySimpleValue2 ValueTwo = new(2);
   public static readonly MySimpleValue2 ValueTen = new(10);

   public static explicit operator MySimpleValue2(long value)
   {
      return new MySimpleValue2(value);
   }
}