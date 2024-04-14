#region

using Jcd.RichEnumerations.Classes;

#endregion

namespace Jcd.RichEnumerations.Examples;

public class ExampleFlagsClass(ulong value, string name) : FlagEnum<ExampleFlagsClass>(value, name)
{
   public static readonly ExampleFlagsClass Flag1 = new(0b0001, nameof(Flag1));
   public static readonly ExampleFlagsClass Flag2 = new(0b0010, nameof(Flag2));
   public static readonly ExampleFlagsClass Flag3 = new(0b0100, nameof(Flag3));
   public static readonly ExampleFlagsClass AllFlagsClass = new(Flag1 | Flag2 | Flag3, nameof(AllFlagsClass));

   public ExampleFlagsClass()
      : this(0, "")
   {
   }
}