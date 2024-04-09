// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedMember.Global

#region

using Jcd.RichEnumerations.Wrappers;

#endregion

namespace Jcd.RichEnumerations.Examples;

public class ExampleEnum2(long value, string name, string description) : NamedAndDescribedSortableRichEnum<long, ExampleEnum2>(value, name, description)
{
   public static readonly ExampleEnum2 Item2 = new(2, "ExampleEnum2.Item2", "The second item.");
   public static readonly ExampleEnum2 Item1 = new(1, "ExampleEnum2.Item1", "The first item.");
   public static readonly ExampleEnum2 Unset = new(0, "ExampleEnum2.Unset", "The value is not yet set.");
}