using Jcd.RichEnumerations.Records.Wrappers;

namespace Jcd.RichEnumerations.Benchmark;

public record RichEnumRecordImpl(string name, int value) : NamedRichEnum<RichEnumRecordImpl>(value,name)
{
   public static readonly RichEnumRecordImpl Item1 = new ("name 1", 1);
   public static readonly RichEnumRecordImpl Item2 = new ("name 2", 2);
   public static readonly RichEnumRecordImpl Item3 = new ("name 3", 3);
}