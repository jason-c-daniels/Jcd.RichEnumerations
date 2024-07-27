#region

using Jcd.RichEnumerations.Records;

#pragma warning disable CS8851 // Record defines 'Equals' but not 'GetHashCode'.

#endregion

namespace Jcd.RichEnumerations.Tests.Records.Harnesses.Enums;

public record MyFlagEnum : FlagEnum<MyFlagEnum>
{
   public static MyFlagEnum Flag1 = new(1, nameof(Flag1));
   public static MyFlagEnum Flag2 = new(1 << 1, nameof(Flag2));
   public static MyFlagEnum Flag3 = new(1 << 2, nameof(Flag3));
   public static MyFlagEnum Flag4 = new(1 << 3, nameof(Flag4));
   public static MyFlagEnum CompoundFlag1 = new(Flag1 | Flag3, nameof(CompoundFlag1));
   public static MyFlagEnum CompoundFlag2 = new(Flag2 | Flag4, nameof(CompoundFlag2));

   public MyFlagEnum(ulong value, string name)
      : base(value, name)
   {
   }

   public MyFlagEnum()
      : this(0, "")
   {
   }

   #region IEquatable<MyFlagEnum?> Members

   public new virtual bool Equals(MyFlagEnum? other)
   {
      return base.Equals(other);
   }

   #endregion

   public override string ToString()
   {
      return Name;
   }
}