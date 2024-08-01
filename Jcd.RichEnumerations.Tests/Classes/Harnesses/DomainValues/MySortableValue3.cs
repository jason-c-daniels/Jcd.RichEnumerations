namespace Jcd.RichEnumerations.Tests.Classes.Harnesses.DomainValues;

public class MySortableValue3(long value) : MySortableValue2(value)
{
   public static readonly MySortableValue3 ValueTwo2 = new(2);

   public static explicit operator MySortableValue3(long value)
   {
      return new MySortableValue3(value);
   }
}