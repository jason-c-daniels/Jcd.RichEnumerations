#region

using Jcd.RichEnumerations.Classes;

#endregion

namespace Jcd.RichEnumerations.Tests.Classes;

public class MySimpleEnum2(long value) : RichEnum<long, MySimpleEnum2>(value)
{
   public static readonly MySimpleEnum2 ValueOne = new(1);
   public static readonly MySimpleEnum2 ValueTwo = new(2);
   public static readonly MySimpleEnum2 ValueTen = new(10);
}