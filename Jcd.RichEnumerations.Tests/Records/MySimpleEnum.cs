#region

using Jcd.RichEnumerations.Records;

#endregion

namespace Jcd.RichEnumerations.Tests.Records;

public record MySimpleEnum : RichEnum<MySimpleEnum>
{
   public static readonly MySimpleEnum ValueOne = new(1);
   public static readonly MySimpleEnum ValueTwo = new(2);
   public static readonly MySimpleEnum ValueTen = new(10);

   protected MySimpleEnum(int value)
      : base(value)
   {
   }
}