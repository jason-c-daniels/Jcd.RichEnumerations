#region

using Jcd.RichEnumerations.Records;

#endregion

namespace Jcd.RichEnumerations.Tests.Records.Harnesses.DomainValues;

public record MySortableValue2(long value) : SortableDomainValue<long, MySortableValue2>(value)
{
   public static readonly MySortableValue2 ValueTen = new(10);
   public static readonly MySortableValue2 ValueTwo = new(2);
   public static readonly MySortableValue2 ValueOne = new(1);
   public static readonly MySortableValue2 ValueNegativeTen = new(-10);

   public static explicit operator MySortableValue2(long value)
   {
      return new MySortableValue2(value);
   }
}