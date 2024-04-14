#region

using Jcd.RichEnumerations.Records;

#endregion

namespace Jcd.RichEnumerations.Tests.Records;

public record MyFlagEnum2 : FlagEnum<MyFlagEnum2>
{
   public static MyFlagEnum2 Flag1 = new(1, nameof(Flag1));
   public static MyFlagEnum2 Flag2 = new(1 << 1, nameof(Flag2));
   public static MyFlagEnum2 Flag3 = new(1 << 2, nameof(Flag3));
   public static MyFlagEnum2 Flag4 = new(1 << 3, nameof(Flag4));
   public static MyFlagEnum2 CompoundFlag1 = new(Flag1 | Flag3, nameof(CompoundFlag1));
   public static MyFlagEnum2 CompoundFlag2 = new(Flag2 | Flag4, nameof(CompoundFlag2));

   public MyFlagEnum2(ulong value, string name)
      : base(value, name)
   {
   }

   public MyFlagEnum2()
      : this(0, "")
   {
   }
}