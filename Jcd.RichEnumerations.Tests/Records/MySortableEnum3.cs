namespace Jcd.RichEnumerations.Tests.Records;

public record MySortableEnum3 : MySortableEnum2
{
   public new static readonly MySortableEnum3 ValueOne = new(1);

   protected MySortableEnum3(long value)
      : base(value)
   {
   }
}