// A trivial sample app that demonstrates a couple of behaviors. 

using Jcd.RichEnumerations.Examples;

// ReSharper disable HeapView.ObjectAllocation

Console.WriteLine("ExampleEnum1 -- An unsortable enum. Listed in compiler order.");

// ReSharper disable once HeapView.ObjectAllocation.Possible
foreach (var e in ExampleEnum1.All) Console.WriteLine(e);

Console.WriteLine();
Console.WriteLine("ExampleEnum2 -- A sortable enum. Listed in compiler order.");

// ReSharper disable once HeapView.ObjectAllocation.Possible
foreach (var e in ExampleEnum2.All) Console.WriteLine(e);

Console.WriteLine();
Console.WriteLine("ExampleEnum2 -- A sortable enum.  After calling ExampleEnum2.Sort(). Listed in user defined sort order."
                 );
ExampleEnum2.Sort();

// ReSharper disable once HeapView.ObjectAllocation.Possible
foreach (var e in ExampleEnum2.All) Console.WriteLine(e);

Console.WriteLine();
Console.WriteLine("ExampleEnum2 From integers.");

for (var i = 0; i < 3; i++)
{
   var e = (ExampleEnum2) i;
   Console.WriteLine(e);
}

Console.WriteLine();
Console.WriteLine("Less than operator");
if (ExampleEnum2.Item1 < ExampleEnum2.Item2) Console.WriteLine($"{ExampleEnum2.Item1} < {ExampleEnum2.Item2}");