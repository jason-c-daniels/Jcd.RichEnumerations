#region

using System;
using System.Runtime.CompilerServices;

#endregion

namespace Jcd.RichEnumerations.Records;

/// <inheritdoc />
public abstract record SortableDomainValue<TValue, TType>
   : DomainValue<TValue, TType>
   , ISortableValueProvider<TValue>
   , IComparable<TType>
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TType : SortableDomainValue<TValue, TType>
{
   /// <inheritdoc />
   protected SortableDomainValue(TValue value)
      : base(value)
   {
   }

   #region Equality, Relational, GetHashCode, and ToString

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

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public virtual int CompareTo(TType other)
   {
      return CompareTo((SortableDomainValue<TValue, TType>) other);
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public int CompareTo(SortableDomainValue<TValue, TType>? other)
   {
      if (other == null)
      {
         return -1;
      }

      if (other.GetType() != GetType())
      {
         return -1;
      }

      return Value.CompareTo(other.Value);
   }

   /// <summary>
   /// Compares two <see cref="SortableDomainValue{TValue,TType}" /> instances to determine if the left hand side is less
   /// than
   /// the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is less than the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator <(SortableDomainValue<TValue, TType>? l, SortableDomainValue<TValue, TType>? r)
   {
      if (l is null)
      {
         return false;
      }

      return l.CompareTo(r) < 0;
   }

   /// <summary>
   /// Compares two <see cref="SortableDomainValue{TValue,TType}" /> instances to determine if the left hand side is greater
   /// than the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is greater than the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator >(SortableDomainValue<TValue, TType>? l, SortableDomainValue<TValue, TType>? r)
   {
      if (l is null && r is null)
      {
         return false;
      }

      if (l is not null)
      {
         return l.CompareTo(r) > 0;
      }

      return true;
   }

   /// <summary>
   /// Compares two <see cref="SortableDomainValue{TValue,TType}" /> instances to determine if the left hand side is less
   /// than
   /// or equal to the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is less than or equal to the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator <=(SortableDomainValue<TValue, TType>? l, SortableDomainValue<TValue, TType>? r)
   {
      if (l is null && r is null)
      {
         return true;
      }

      if (l is null)
      {
         return false;
      }

      return l.CompareTo(r) <= 0;
   }

   /// <summary>
   /// Compares two <see cref="SortableDomainValue{TValue,TType}" /> instances to determine if the left hand side is greater
   /// than or equal to the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is greater than or equal to the right hand side.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator >=(SortableDomainValue<TValue, TType>? l, SortableDomainValue<TValue, TType>? r)
   {
      if (l is null && r is null)
      {
         return true;
      }

      if (l is not null)
      {
         return l.CompareTo(r) >= 0;
      }

      return true;
   }

   #endregion
}