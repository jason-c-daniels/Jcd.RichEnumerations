#region

using Jcd.RichEnumerations.Classes;

#endregion

namespace Jcd.RichEnumerations.Tests.Classes;

public class MySortableEnum2(long value) : SortableRichEnum<long, MySortableEnum2>(value)
{
   public static readonly MySortableEnum2 ValueTen = new(10);
   public static readonly MySortableEnum2 ValueTwo = new(2);
   public static readonly MySortableEnum2 ValueOne = new(1);
   public static readonly MySortableEnum2 ValueNegativeTen = new(-10);
}