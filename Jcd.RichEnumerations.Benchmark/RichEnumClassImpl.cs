#region

using Jcd.RichEnumerations.Classes.Wrappers;

#endregion

namespace Jcd.RichEnumerations.Benchmark;

public class RichEnumClassImpl(string name, int value) : NamedRichEnum<RichEnumClassImpl>(value, name)
{
   public static readonly RichEnumClassImpl Item1 = new("name 1", 1);
   public static readonly RichEnumClassImpl Item2 = new("name 2", 2);
   public static readonly RichEnumClassImpl Item3 = new("name 3", 3);
}