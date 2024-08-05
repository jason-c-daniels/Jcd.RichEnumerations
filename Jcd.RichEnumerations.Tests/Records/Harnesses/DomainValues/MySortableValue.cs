#region

using Jcd.RichEnumerations.Records;

#endregion

namespace Jcd.RichEnumerations.Tests.Records.Harnesses.DomainValues;

public record MySortableValue(int value) : SortableDomainValue<MySortableValue>(value)
{
   public static readonly MySortableValue ValueOne = new(1);
   public static readonly MySortableValue ValueTwo = new(2);
   public static readonly MySortableValue ValueTen = new(10);

   public static explicit operator MySortableValue(int value)
   {
      return new MySortableValue(value);
   }
}