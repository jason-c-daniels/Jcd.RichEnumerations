﻿// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedMember.Global

#region

using Jcd.RichEnumerations.Classes.Wrappers;

#endregion

namespace Jcd.RichEnumerations.Examples;

public class ExampleEnum1(int value, string name, string description) : NamedAndDescribedRichEnum<ExampleEnum1>(value, name, description)
{
   public static readonly ExampleEnum1 Item2 = new(2, "Item2", "The second item.");
   public static readonly ExampleEnum1 Item1 = new(1, "Item1", "The first item.");
   public static readonly ExampleEnum1 Unset = new(0, "Unset", "The value is not yet set.");

   /// <summary>
   /// An override of the default ToString implementation.
   /// </summary>
   /// <returns></returns>
   public override string ToString()
   {
      return $"Name={Name}; Value = {Value}; Description={Description}";
   }
}