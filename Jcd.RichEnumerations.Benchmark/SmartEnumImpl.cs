using Ardalis.SmartEnum;

namespace Jcd.RichEnumerations.Benchmark;

public class SmartEnumImpl(string name, int value) : SmartEnum<SmartEnumImpl>(name, value)
{
   public static readonly SmartEnumImpl Item1 = new SmartEnumImpl("name 1", 1);
   public static readonly SmartEnumImpl Item2 = new SmartEnumImpl("name 2", 2);
   public static readonly SmartEnumImpl Item3 = new SmartEnumImpl("name 3", 3);
}