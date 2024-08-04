#region

using System.Runtime.CompilerServices;

using Jcd.RichEnumerations.Records;

#endregion

namespace Jcd.RichEnumerations.Tests.Records.Harnesses.DomainValues;

public record MySimpleValue(int value) : DomainValue<MySimpleValue>(value)
{
   public static readonly MySimpleValue ValueOne = new(1);
   public static readonly MySimpleValue ValueTwo = new(2);
   public static readonly MySimpleValue ValueTen = new(10);

   #region IEquatable<MySimpleValue?> Members

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override bool Equals(MySimpleValue? other)
   {
      return base.Equals(other);
   }

   #endregion

   public static explicit operator MySimpleValue(int value)
   {
      return new MySimpleValue(value);
   }

   public sealed override string ToString()
   {
      return base.ToString();
   }

   public override int GetHashCode()
   {
      return HashCode.Combine(base.GetHashCode(), value);
   }
}