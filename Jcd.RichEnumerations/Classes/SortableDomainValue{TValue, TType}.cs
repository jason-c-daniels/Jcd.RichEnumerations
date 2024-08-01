#region

using System;
using System.Runtime.CompilerServices;

#endregion

namespace Jcd.RichEnumerations.Classes;

/// <inheritdoc />
public abstract class SortableDomainValue<TValue, TType>(TValue value) : DomainValue<TValue, TType>(value)
                                                                       , ISortableValueProvider<TValue>
                                                                       , IComparable<TType>
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TType : SortableDomainValue<TValue, TType>
{
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
      return base.GetHashCode();
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override bool Equals(object? obj)
   {
      return obj is not null && obj.GetType() == GetType() && Equals((TType) obj);
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
   /// Compares two <see cref="SortableDomainValue{TValue,TType}" /> instances for equality.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if equivalent.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator ==(SortableDomainValue<TValue, TType>? l, SortableDomainValue<TValue, TType>? r)
   {
      if (l is null && r is null)
      {
         return true; // both null, same value, return true.
      }

      if (l is null || r is null)
      {
         return false; // only one is null. Return false.
      }

      return l.Equals(r);
   }

   /// <summary>
   /// Compares two <see cref="SortableDomainValue{TValue,TType}" /> instances for inequality.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if not equivalent.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator !=(SortableDomainValue<TValue, TType>? l, SortableDomainValue<TValue, TType>? r)
   {
      return !(l == r);
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