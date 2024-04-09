namespace Jcd.RichEnumerations.Tests;

public class MySortableEnum3(long value) : MySortableEnum2(value)
{
   public new static readonly MySortableEnum3 ValueOne = new(1);
}