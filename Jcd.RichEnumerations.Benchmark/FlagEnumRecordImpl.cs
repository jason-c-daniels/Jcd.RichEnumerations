using Jcd.RichEnumerations.Records;

namespace Jcd.RichEnumerations.Benchmark;

public record FlagEnumRecordImpl(string name, ulong value) : FlagEnum<FlagEnumRecordImpl>(value, name)
{
   public static readonly FlagEnumRecordImpl Flag1 = new(nameof(Flag1), 1);
   public static readonly FlagEnumRecordImpl Flag2 = new(nameof(Flag2), 2);
   public static readonly FlagEnumRecordImpl Flag3 = new(nameof(Flag3), 4);
   public static readonly FlagEnumRecordImpl AllFlags = new(nameof(AllFlags), Flag1|Flag2|Flag3);

   public FlagEnumRecordImpl()
      : this("",0)
   {
   }
}