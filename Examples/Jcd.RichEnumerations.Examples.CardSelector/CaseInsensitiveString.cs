// ReSharper disable HeapView.ObjectAllocation.Evident

#pragma warning disable S4136

namespace Jcd.RichEnumerations.Examples.CardSelector;

public sealed class CaseInsensitiveString
   : IEquatable<CaseInsensitiveString>
   , IComparable<CaseInsensitiveString>
   , IComparable
{
   private readonly string value;

   private CaseInsensitiveString(string value)
   {
      this.value = value;
   }

   #region IComparable Members

   public int CompareTo(object? obj)
   {
      if (ReferenceEquals(null, obj))
      {
         return 1;
      }

      if (ReferenceEquals(this, obj))
      {
         return 0;
      }

      return obj is CaseInsensitiveString other
                ? CompareTo(other)
                : throw new ArgumentException($"Object must be of type {nameof(CaseInsensitiveString)}");
   }

   #endregion

   #region IComparable<CaseInsensitiveString> Members

   public int CompareTo(CaseInsensitiveString? other)
   {
      if (ReferenceEquals(this, other))
      {
         return 0;
      }

      if (ReferenceEquals(null, other))
      {
         return 1;
      }

      return string.Compare(value, other.value, StringComparison.InvariantCultureIgnoreCase);
   }

   #endregion

   #region IEquatable<CaseInsensitiveString> Members

   public bool Equals(CaseInsensitiveString? other)
   {
      return CompareTo(other) == 0;
   }

   #endregion

   public static bool operator <(CaseInsensitiveString? left, CaseInsensitiveString? right)
   {
      return Comparer<CaseInsensitiveString>.Default.Compare(left, right) < 0;
   }

   public static bool operator >(CaseInsensitiveString? left, CaseInsensitiveString? right)
   {
      return Comparer<CaseInsensitiveString>.Default.Compare(left, right) > 0;
   }

   public static bool operator <=(CaseInsensitiveString? left, CaseInsensitiveString? right)
   {
      return Comparer<CaseInsensitiveString>.Default.Compare(left, right) <= 0;
   }

   public static bool operator >=(CaseInsensitiveString? left, CaseInsensitiveString? right)
   {
      return Comparer<CaseInsensitiveString>.Default.Compare(left, right) >= 0;
   }

   public static bool operator ==(CaseInsensitiveString? left, CaseInsensitiveString? right)
   {
      return Equals(left, right);
   }

   public static bool operator !=(CaseInsensitiveString? left, CaseInsensitiveString? right)
   {
      return !Equals(left, right);
   }

   public override bool Equals(object? obj)
   {
      return CompareTo((CaseInsensitiveString) obj!) == 0;
   }

   public static implicit operator string(CaseInsensitiveString cis)
   {
      return cis.value;
   }

   public static implicit operator CaseInsensitiveString(string s)
   {
      return new CaseInsensitiveString(s);
   }

   public override string ToString()
   {
      return value;
   }

   public override int GetHashCode()
   {
      return value.GetHashCode();
   }
}