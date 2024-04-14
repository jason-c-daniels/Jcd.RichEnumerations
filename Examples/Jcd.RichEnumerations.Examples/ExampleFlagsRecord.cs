#region

using Jcd.RichEnumerations.Records;

#endregion

namespace Jcd.RichEnumerations.Examples;

public record ExampleFlagsRecord : FlagEnum<ExampleFlagsRecord>
{
   public static readonly ExampleFlagsRecord Flag1 = new(0b0001, nameof(Flag1));
   public static readonly ExampleFlagsRecord Flag2 = new(0b0010, nameof(Flag2));
   public static readonly ExampleFlagsRecord Flag3 = new(0b0100, nameof(Flag3));
   public static readonly ExampleFlagsRecord AllFlagsClass = new(Flag1 | Flag2 | Flag3, nameof(AllFlagsClass));

   public ExampleFlagsRecord(ulong value, string name)
      : base(value, name)
   {
   }

   public ExampleFlagsRecord()
      : this(0, "")
   {
   }

   public override string ToString()
   {
      return Name;
   }
}