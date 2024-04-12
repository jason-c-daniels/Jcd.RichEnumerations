#region

using System;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Classes;

/// <summary>
/// A base for sortable rich enumerations. This type provides a hook to sort the <see cref="RichEnum{TValue,TEnum}" />
/// <c>.All</c> collection.
/// <c>.Sort()</c> should be called once and only once during application startup.
/// </summary>
/// <param name="value">The value of the instance. This must be unique.</param>
/// <typeparam name="TEnum">The type deriving from SortableEnum{TEnum}</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
/// <example>
/// <code>
/// public class MySortableRichEnum(float value, string customText) : SortableRichEnum&lt;float,MySortableRichEnum&gt;(value)
/// {
///      public static readonly MySortableRichEnum Item1 = new (0.1f, "First Item");
///      public static readonly MySortableRichEnum Item2 = new (-0.1f, "Second Item");
///
///      public string CustomText => customText;
/// }
///
/// class Program
/// {
///    public void Main()
///    {
///       // Call Sort() during app startup.
///
///       // This sorts numerically, ascending.
///       MySortableRichEnum.Sort();
///
///       // This sorts numerically, descending.
///       MySortableRichEnum.Sort((x,y) => y.Value.CompareTo(x.Value));
///    }
/// }
/// </code>
/// </example>
public class SortableRichEnum<TValue, TEnum>(TValue value) : SortableRichEnumBase<TValue, TEnum, TEnum>
                                                           , IEquatable<TEnum>
                                                           , IComparable<TEnum>
                                                           , IComparable<SortableRichEnum<TValue, TEnum>>
                                                           , ISortableRichEnumValueProvider<TValue>
   where TValue : IEquatable<TValue>, IComparable<TValue>
   where TEnum : SortableRichEnum<TValue, TEnum>, ISortableRichEnumValueProvider<TValue>
{
   #region ISortableRichEnumValueProvider<TValue> Members

   /// <inheritdoc />
   public TValue Value { get; } = value;

   #endregion

   #region Equality, Relational, GetHashCode, and ToString

   /// <inheritdoc />
   public override string ToString()
   {
      return Value.ToString();
   }

   /// <inheritdoc />
   public override int GetHashCode()
   {
      return Value.GetHashCode() ^ GetType().GetHashCode();
   }

   /// <inheritdoc />
   public override bool Equals(object? obj)
   {
      return obj is not null && obj.GetType() == GetType() && Equals((TEnum) obj);
   }

   /// <summary>
   /// Compares the Value of the current <see cref="SortableRichEnum{TValue,TEnum}" /> instance to the
   /// target instance for equality.
   /// </summary>
   /// <param name="other">The other instance to compare to</param>
   /// <returns>True if equivalent.</returns>
   public virtual bool Equals(TEnum? other)
   {
      return other is not null && Value.Equals(other.Value);
   }

   /// <inheritdoc />
   public virtual int CompareTo(TEnum other)
   {
      return CompareTo((SortableRichEnum<TValue, TEnum>) other);
   }

   /// <inheritdoc />
   public int CompareTo(SortableRichEnum<TValue, TEnum>? other)
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
   /// Compares two <see cref="SortableRichEnum{TValue,TEnum}" /> instances for equality.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if equivalent.</returns>
   public static bool operator ==(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
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
   /// Compares two <see cref="SortableRichEnum{TValue,TEnum}" /> instances for inequality.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if not equivalent.</returns>
   public static bool operator !=(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
   {
      return !(l == r);
   }

   /// <summary>
   /// Compares two <see cref="SortableRichEnum{TValue,TEnum}" /> instances to determine if the left hand side is less than
   /// the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is less than the right hand side.</returns>
   public static bool operator <(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
   {
      if (l is null)
      {
         return false;
      }

      return l.CompareTo(r) < 0;
   }

   /// <summary>
   /// Compares two <see cref="SortableRichEnum{TValue,TEnum}" /> instances to determine if the left hand side is greater
   /// than the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is greater than the right hand side.</returns>
   public static bool operator >(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
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
   /// Compares two <see cref="SortableRichEnum{TValue,TEnum}" /> instances to determine if the left hand side is less than
   /// or equal to the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is less than or equal to the right hand side.</returns>
   public static bool operator <=(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
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
   /// Compares two <see cref="SortableRichEnum{TValue,TEnum}" /> instances to determine if the left hand side is greater
   /// than or equal to the right hand side.
   /// </summary>
   /// <param name="l">the left hand side of the comparison.</param>
   /// <param name="r">the right hand side of the comparison.</param>
   /// <returns>True if the left hand side is greater than or equal to the right hand side.</returns>
   public static bool operator >=(SortableRichEnum<TValue, TEnum>? l, SortableRichEnum<TValue, TEnum>? r)
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

   #region conversion operators

   /// <summary>
   /// Explicit conversion to the underlying data type.
   /// </summary>
   /// <param name="e">The <see cref="SortableRichEnum{TValue,TEnum}" /> instance.</param>
   /// <returns>The .Value of the <see cref="SortableRichEnum{TValue,TEnum}" /> instance</returns>
   public static explicit operator TValue(SortableRichEnum<TValue, TEnum> e)
   {
      return e.Value;
   }

   /// <summary>
   /// Explicit conversion from the underlying data type to an <see cref="SortableRichEnum{TValue,TEnum}" />
   /// instance. This performs a lookup on the known values.
   /// </summary>
   /// <param name="value">The value to convert.</param>
   /// <returns>
   /// The instance of the <see cref="SortableRichEnum{TValue,TEnum}" />, if it exists.
   /// Throws an exception, otherwise.
   /// </returns>
   /// <exception cref="ArgumentException">If a value not present in the enum is provided.</exception>
   public static explicit operator SortableRichEnum<TValue, TEnum>(TValue value)
   {
      if (ByValue.TryGetValue(value, out var result))
      {
         return result;
      }

      throw new ArgumentException($"Cannot convert to {typeof(TEnum)}. Invalid value.", nameof(value));
   }

   #endregion
}