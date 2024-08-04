#region

using System.Runtime.CompilerServices;

#endregion

namespace Jcd.RichEnumerations.Records;

/// <inheritdoc />
public abstract record DomainValue<TType> : DomainValue<int, TType>
   where TType : DomainValue<int, TType>
{
   /// <inheritdoc />
   protected DomainValue(int value)
      : base(value)
   {
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override string ToString()
   {
      return Value.ToString();
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override int GetHashCode()
   {
      return base.GetHashCode();
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override bool Equals(TType? other)
   {
      return base.Equals(other);
   }
}