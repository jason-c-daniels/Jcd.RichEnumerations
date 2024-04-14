using Ardalis.SmartEnum;

namespace Jcd.RichEnumerations.Benchmark;

public class SmartFlagEnumImpl(string name, int value) : SmartFlagEnum<SmartFlagEnumImpl>(name, value)
{
   public static readonly SmartFlagEnumImpl Flag1 = new(nameof(Flag1), 1);
   public static readonly SmartFlagEnumImpl Flag2 = new(nameof(Flag2), 2);
   public static readonly SmartFlagEnumImpl Flag3 = new(nameof(Flag3), 3);
}