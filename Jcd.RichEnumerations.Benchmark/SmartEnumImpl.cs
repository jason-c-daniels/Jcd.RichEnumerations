#region

using Ardalis.SmartEnum;

#endregion

namespace Jcd.RichEnumerations.Benchmark;

public class SmartEnumImpl(string name, int value) : SmartEnum<SmartEnumImpl>(name, value)
{
   public static readonly SmartEnumImpl Item1 = new("name 1", 1);
   public static readonly SmartEnumImpl Item2 = new("name 2", 2);
   public static readonly SmartEnumImpl Item3 = new("name 3", 3);
}