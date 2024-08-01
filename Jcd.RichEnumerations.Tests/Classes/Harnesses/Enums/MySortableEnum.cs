#region

using Jcd.RichEnumerations.Classes;

#endregion

namespace Jcd.RichEnumerations.Tests.Classes.Harnesses.Enums;

public class MySortableEnum(int value) : SortableRichEnum<MySortableEnum>(value)
{
   public static readonly MySortableEnum ValueOne = new(1);
   public static readonly MySortableEnum ValueTwo = new(2);
   public static readonly MySortableEnum ValueTen = new(10);
}