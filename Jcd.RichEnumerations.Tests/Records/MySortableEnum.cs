﻿#region

using Jcd.RichEnumerations.Records;

#endregion

namespace Jcd.RichEnumerations.Tests.Records;

public record MySortableEnum : SortableRichEnum<MySortableEnum>
{
   public static readonly MySortableEnum ValueOne = new(1);
   public static readonly MySortableEnum ValueTwo = new(2);
   public static readonly MySortableEnum ValueTen = new(10);

   protected MySortableEnum(int value)
      : base(value)
   {
   }
}