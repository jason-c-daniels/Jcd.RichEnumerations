#region

using Jcd.RichEnumerations.Records;

#endregion

namespace Jcd.RichEnumerations.Tests.Records.Harnesses.Enums;

public record MySimpleEnum2 : RichEnum<long, MySimpleEnum2>
{
   public static readonly MySimpleEnum2 ValueOne = new(1);
   public static readonly MySimpleEnum2 ValueTwo = new(2);
   public static readonly MySimpleEnum2 ValueTen = new(10);

   protected MySimpleEnum2(long value)
      : base(value)
   {
   }
}