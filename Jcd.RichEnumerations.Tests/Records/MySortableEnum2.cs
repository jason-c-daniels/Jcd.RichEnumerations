#region

using Jcd.RichEnumerations.Records;

#endregion

namespace Jcd.RichEnumerations.Tests.Records;

public record MySortableEnum2 : SortableRichEnum<long, MySortableEnum2>
{
   public static readonly MySortableEnum2 ValueTen = new(10);
   public static readonly MySortableEnum2 ValueTwo = new(2);
   public static readonly MySortableEnum2 ValueOne = new(1);
   public static readonly MySortableEnum2 ValueNegativeTen = new(-10);

   protected MySortableEnum2(long value)
      : base(value)
   {
   }
}