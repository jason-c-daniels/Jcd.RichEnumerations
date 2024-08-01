#region

using Jcd.RichEnumerations.Classes;

#endregion

namespace Jcd.RichEnumerations.Tests.Classes.Harnesses.DomainValues;

public class MySortableValue(int value) : SortableDomainValue<MySortableValue>(value)
{
   public static readonly MySortableValue ValueOne = new(1);
   public static readonly MySortableValue ValueTwo = new(2);
   public static readonly MySortableValue ValueTen = new(10);

   public static explicit operator MySortableValue(int value)
   {
      return new MySortableValue(value);
   }
}