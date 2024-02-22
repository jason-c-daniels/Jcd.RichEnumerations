// ReSharper disable HeapView.ObjectAllocation.Evident

namespace Jcd.RichEnumerations.Examples.CardSelector;

public class CaseInsensitiveString
   : IEquatable<CaseInsensitiveString>
   , IComparable<CaseInsensitiveString>
{
   private readonly string value;

   private CaseInsensitiveString(string value) { this.value = value; }

   public bool Equals(CaseInsensitiveString? other) { return CompareTo(other) == 0; }

   public int CompareTo(CaseInsensitiveString? other)
   {
      return other == null ? 1 : string.Compare(value, other.value, StringComparison.InvariantCultureIgnoreCase);
   }

   public static implicit operator string(CaseInsensitiveString cis) { return cis.value; }

   public static implicit operator CaseInsensitiveString(string s) { return new CaseInsensitiveString(s); }

   public override string ToString() { return value; }

   public override int GetHashCode() { return value.ToUpper().GetHashCode(); }

   public override bool Equals(object? obj) { return CompareTo((CaseInsensitiveString) obj!) == 0; }
}