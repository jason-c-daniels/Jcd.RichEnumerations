#region

using Jcd.RichEnumerations.Classes;

#endregion

namespace Jcd.RichEnumerations.Tests.Classes;

public class MySimpleEnum(int value) : RichEnum<MySimpleEnum>(value)
{
   public static readonly MySimpleEnum ValueOne = new(1);
   public static readonly MySimpleEnum ValueTwo = new(2);
   public static readonly MySimpleEnum ValueTen = new(10);
}