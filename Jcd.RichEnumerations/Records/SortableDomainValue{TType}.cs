#region

using System.Runtime.CompilerServices;

#endregion

namespace Jcd.RichEnumerations.Records;

/// <inheritdoc />
public abstract record SortableDomainValue<TType> : SortableDomainValue<int, TType>
   where TType : SortableDomainValue<TType>
{
   /// <inheritdoc />
   protected SortableDomainValue(int value)
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
      return Value.GetHashCode() ^ GetType().GetHashCode();
   }
}