#region

using Jcd.RichEnumerations.Classes;

#endregion

namespace Jcd.RichEnumerations.Tests.Classes.Harnesses.DomainValues;

public class MySimpleValue(int value) : DomainValue<MySimpleValue>(value)
{
   public static readonly MySimpleValue ValueOne = new(1);
   public static readonly MySimpleValue ValueTwo = new(2);
   public static readonly MySimpleValue ValueTen = new(10);

   public static explicit operator MySimpleValue(int value)
   {
      return new MySimpleValue(value);
   }
}