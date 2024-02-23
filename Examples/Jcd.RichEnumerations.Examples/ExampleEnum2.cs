// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedMember.Global

namespace Jcd.RichEnumerations.Examples;

public class ExampleEnum2(int value, string name, string description)
   : NamedAndDescribedSortableRichEnum<ExampleEnum2>(value, name, description)
{
   #region Enumerated items

   public static readonly ExampleEnum2 Item2 = new(2, "ExampleEnum2.Item2", "The second item.");
   public static readonly ExampleEnum2 Item1 = new(1, "ExampleEnum2.Item1", "The first item.");
   public static readonly ExampleEnum2 Unset = new(0, "ExampleEnum2.Unset", "The value is not yet set.");

   #endregion

   /// <summary>
   /// Compares two instances by their Value property.
   /// </summary>
   /// <param name="other">The other instance to compare to.</param>
   /// <returns>-1 if this instance is less than the other, 1 if this instance is greater than the other. 0 if they are equal.</returns>
   public override int CompareTo(ExampleEnum2 other) { return Value.CompareTo(other.Value); }
}