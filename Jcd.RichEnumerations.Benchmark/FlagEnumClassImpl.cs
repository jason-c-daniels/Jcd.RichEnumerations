using Jcd.RichEnumerations.Classes;

namespace Jcd.RichEnumerations.Benchmark;

public class FlagEnumClassImpl(string name, ulong value) : FlagEnum<FlagEnumClassImpl>(value, name)
{
   public static readonly FlagEnumClassImpl Flag1 = new(nameof(Flag1), 1);
   public static readonly FlagEnumClassImpl Flag2 = new(nameof(Flag2), 2);
   public static readonly FlagEnumClassImpl Flag3 = new(nameof(Flag3), 4);
   public static readonly FlagEnumClassImpl AllFlags = new(nameof(AllFlags), Flag1|Flag2|Flag3);

   public FlagEnumClassImpl()
      : this("",0)
   {
   }
}