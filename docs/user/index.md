# User Guide

This user guide explains the rationale for using DDD-style rich enumerations with examples,
and provides guidance on selecting and using the types provided in this library.

## What Are Rich Enumerations?

Rich enumerations are a technique popularized by Domain Driven Design.
They encapsulate tightly coupled data with the values often modeled using
the `enum` type in C#, and other languages. They provide a concise and
performant way of coupling pertinent data with the point of use, so the
programmer doesn't have to perform a lookup. (Or call an extension
method... etc.)

They are useful when looking to move away from various code smells.
(e.g. Enum for control flow. Adding attributes to enum entries...etc.)

### Benefits of Rich Enumerations

Rich enumerations have a couple of obvious benefits.

1. You get all the power of an object-oriented language underlying the implementation.
2. All of your data and constructs are colocated. You're keeping related concerns together.
3. You can associate very descriptive information with the individual values, easing the debugging process.

A possibly non-obvious benefit is that you can strictly enforce which values are allowed.
Indeed, this library takes that opinion. Attempting to cast a numeric value not represented
in the `RichEnum` derived type will result in an exception.

After all, enum values comprise a **closed set**. (i.e. no other values are allowed)
Yet the underlying implementation of the integral `enum` in C# allows casting an integer
to any `enum`. This is in violation of the concept of a _closed set._

### Downsides to Rich Enumerations

1. They are **not** constants and cannot be used where constants are required.
   (e.g. switch expressions and case statements can't use them)
2. If, for some reason, you need to reference one RichEnum instance when creating another you must define the referenced
   one first. Doing this can prove tricky, depending on the relationships involved. This is not true of regular enums.
   However, you should reconsider your approach to try and eliminate such interdependencies, before going down this path.
3. They're slower. While I've taken great pains to keep this library as performant as possible
   comparing values will still require a property access, which adds nanoseconds to each comparison.
   These add up over time, especially in tight loops. If your application is highly performance sensitive
   (e.g. near realtime and/or bulk data processing of millions of records per second) rich enumerations
   **may** consume more CPU time than wanted.

## When Should I Consider Using Rich Enumerations?

The uselessly obvious "when the benefits outweigh the downsides."
But how do you know when that's the case? This section will guide you through
some examples of times to seriously consider using _rich enumerations_ over the
built-in C# `enum`.

### Use Case 1: When you're attaching metadata to the individual values in an `enum`

This can be through `Attribute` types and using reflection to extract the information or more performant,
but an equally disconnected lookup table based or extension method on the `enum`. Any of those techniques
indicate that you have more than a single simple value to inspect. And finding at least a subset of that
data which can live with the value instantiation should improve the readability of your code.

#### Example: Refactoring Attributes Usage

```csharp

// Original: Using attributes, needs refactoring
// 1. Define the types.
[AttributeUsage(AttributeTargets.Enum|AttributeTargets.Field)]
public class FeatureApiMetadataAttribute(int majorVer, int minorVer, string apiUri, string description) : Attribute
{
   public Version ApiVer {get;} = new Version(majorVer,minorVer);
   public string Description {get;} = description;
   public Uri ApiUri {get;}=new (apiUri);
}

public enum FeatureEndpointType
{
   [FeatureApiMetadata(1,0,"https://localhost:9999/api/v1/feature1", "feature1 api endpoint, for v1")]
   AppFeature1V1,
   [FeatureApiMetadata(1,1,"https://localhost:9999/api/v1/feature2", "feature2 api endpoint, for v1")]
   AppFeature2V1,
   [FeatureApiMetadata(2,0,"https://localhost:9999/api/v2/feature1", "feature1 api endpoint, for v2")]
   AppFeature1V2,
   [FeatureApiMetadata(2,0,"https://localhost:9999/api/v2/feature2", "feature2 api endpoint, for v2")]
   AppFeature2V2,
}

// 2. Decode the enum to metadata.
var featureAsInt = ...; // obtained somehow (user input?)
var feature = (FeatureEndpointType) featureAsInt;
FeatureApiMetadata metadata = SomeReflectionHelper.GetAttribute<FeatureApiMetadataAttribute>(feature);

var uri = metadata.ApiUri;

// 3. Make the API call.
...
```

As you can see there's a lookup step for obtaining the Uri of the versioned endpoint.
Since it uses reflection, it's pretty costly. An advantage this has over doing
a lookup table is code comprehension. It's immediately obvious that more data is needed
than just a new entry in the enum.

And while we could certainly refactor the code to have a lookup table to remove
the expense incurred by using reflection. A lookup table requires knowledge of the lookup
table when adding entries in the enum. Failure to update that results in bugs, which
are hopefully caught in unit tests. But it's best to design code such that we don't
have to hope for errors to be caught, nor for performance to be "good enough."

Using a _rich enumeration_ avoids both sets of problems. We have all data co-located.
And we have fast access to the data.

Now let's take a look at what this code would look like as a `RichEnum`.

```csharp
// Refactored

// 1. Define the type and enumeration entries.
public class FeatureEndpointType(int value, Version apiVer, Uri apiUri, string description)
   : RichEnum<FeatureEndpointType>(value)
{
   #region enum values

   // THESE MUST BE FIELDS!
   public static readonly FeatureEndpointType AppFeature1V1 = new (1,new Version(1,0), new Uri("https://localhost:9999/api/v1/feature1"), "feature1 api endpoint, for v1");
   public static readonly FeatureEndpointType AppFeature2V1 = new (2,new Version(1,1), new Uri("https://localhost:9999/api/v1/feature2"), "feature2 api endpoint, for v1");
   public static readonly FeatureEndpointType AppFeature1V1 = new (3,new Version(2,0), new Uri("https://localhost:9999/api/v2/feature1"), "feature1 api endpoint, for v2");
   public static readonly FeatureEndpointType AppFeature2V1 = new (4,new Version(2,0), new Uri("https://localhost:9999/api/v2/feature2"), "feature2 api endpoint, for v2");

   #endregion

   #region Properties

   public Version ApiVer {get;} = apiVer;
   public Uri ApiUri {get;} = apiUri;
   public string Description {get;} = description;

   #endregion
}

// 2. Decode the enum to metadata.
var featureAsInt = ...; // obtained somehow (user input?)
var feature = (FeatureEndpointType) featureAsInt;

var uri = feature.ApiUri;

// 3. Make the API call.
...

```

It might not look like much has changed in step 2. But look closely.
You'll see that the attribute lookup is no longer there. This does two
things for us.

First, it improves the speed of the code. The `RichEnum`
conversion operator uses a `Dictionary` to look up the integer and converts
it to the `FeatureEndpointType` instance.

Second, it allows us to further condense the code, should conciseness be desired.

```csharp
// 2. Reduced to two lines.
var featureAsInt = ...; // obtained somehow (user input?)

var uri = ((FeatureEndpointType) featureAsInt).ApiUri;
```

With proper code construction, you can do an auto-conversion to the `RichEnum`
derived type, if appropriate for your code. While the library provided conversion
operators require an explicit conversion, you can always replace those with
implicit conversions in a derived type.

### Use Case 2: You're using enums to control program flow.

While one could argue that use case 1 is a subset of this one. However,
this section is about much more direct instances of using them to govern
control flow.

Take, for example, composing logic to determine which items to display
based on successive selections. Often this takes the form of drop down
or other selectable lists, with each selection populating the next list.

For this example, we'll model this as selecting a region and country
this way. To further restrict the amount of sample code, let's say
only three countries per region are allowed, and only three regions
are allowed. Let's pretend this is due to trade laws.

Since the dataset is so small there's hardly any need to put this into a
database at this time. (i.e. _Premature optimization is the root of all
evil._)

In this example, the control-flow that's being governed by the `enum` is
the selection of what to populate in the second list as well as what
text to display.

```csharp

public enum Region {
   Europe,
   NorthAmerica,
   Scandinavia
}

public enum Country {
   // North America
   Canada,
   // Scandinavia
   Denmark,
   // Europe
   France,
   // Europe
   Germany,
   // North America
   Mexico,
   // Scandinavia
   Norway,
   // Scandinavia
   Sweden,
   //Europe
   UnitedKingdom,
   // North America
   UnitedStates
}

Region region = GetRegion(); // get the selection from the UI, and if necessary translate to the enum.

var countries = GetCountries(continent);
var countryNames = countries.Select(c=>GetCountryName(c)).ToList();

//... display the list to the user...

List<Country> GetCountries(Region region) {
   return region switch
   {
      Region.Europe => [Country.France, Country.Germany, Country.UnitedKigndom],
      Region.Scandinavia => [Country.Denmark, Country.Norway, Country.Sweden],
      Region.NorthAmerica => [Country.Canada, Country.Mexico, Country.UnitedStates],
      _ => throw new ArgumentException("Invalid Value",nameof(region));
   };
}

string GetCountryName(Country country) {
   /// convert the Contry to a string.
}

```

While this code is straightforward and easy to follow, it will only remain so
as long as the total number of enum entries remains small.

Now let's see how we might refactor this using `RichEnum` derived types.

```csharp
using Jcd.RichEnumerations.Classes;

public class Country(int value, string name) : RichEnum<Country>(value)
{
   // North America
   public static readonly Country Canada = new(0,"Canada");
   // Scandinavia
   public static readonly Country Denmark = new(1,"Denmark");
   // Europe
   public static readonly Country France = new (2, "France");
   // Europe
   public static readonly Country Germany = new (3, "Germany");
   // North America
   public static readonly Country Mexico = new (4, "Mexico");
   // Scandinavia
   public static readonly Country Norway = new (5, "Norway");
   // Scandinavia
   public static readonly Country Sweden = new (6, "Sweden");
   //Europe
   public static readonly Country UnitedKingdom = new (7, "UnitedKingdom");
   // North America
   public static readonly Country UnitedStates = new (8, "UnitedStates");

   #region properties

   public string Name { get; } = name;

   #endregion
}

public class Region(int value, string name, Country[] countries) : RichEnum<Region>(value)
{
   #region Enum items

   public readonly static Region Europe = new(1, "Europe", [Country.France, Country.Germany, Country.UnitedKingdom]);
   public readonly static Region Scandinavia = new(2, "Scandinavia", [Country.Denmark, Country.Norway, Country.Sweden]);
   public readonly static Region NorthAmerica = new(3, "North America", [Country.Canada, Country.Mexico, Country.UnitedStates]);

   #endregion

   #region properties

   public IReadOnlyList<Country> Countries { get; } = countries;

   public string Name { get; } = name;

   #endregion
}

// now use the items
Region region = GetRegion(); // get the selection from the UI, and if necessary translate to the enum.

var countries = region.Countries;
var countryNames = countries.Select(c=>c.Name).ToList();

//... display the list to the user...

```

As you can see in this refactored example, there's no need to provide any lookups or conversion methods.
Also, the observant reader will have noticed that I omitted the **Region** specific name lookup/conversion
method in the standard `enum` based approach, but did not in the `RichEnum` based approach. As well,
I intentionally omitted the details of converting the Country to a string in the `enum` based approach
and hard coded it in the `RichEnum` approach.

In a real world application that supports multiple languages, both sets of code would use a resource
dictionary to look up the translated string. In the case of the `RichEnum` this could
happen at the point of construction (if the language isn't allowed to change during runtime)
or a key would be passed in and a resource look up could be performed each time the Name property
was read.

Regardless, the `RichEnum` approach is clearly the simpler code to write, understand and maintain.

## Which should I use, the `class` based or `record` based `RichEnum` implementation?

- Class based provides maximum portability. But, both have been extensively unit tested.

- If you need a `RichEnum` whose elements in `.All` need to be sorted, derive from
  `SortableRichEnum`. Otherwise `RichEnum` should suffice for most purposes.

- If your project needs, or coding standards insist on using either plain old `class` objects (POCO)
  or `record` classes, just use the correct namespace and you'll be ready to go.

- The POCO implementations live in `Jcd.RichEnumerations.Classes`.

- The `record` implementations live in `Jcd.RichEnumerations.Records`.

- Both have a sub-namespace called `Wrappers` which contain various derived types with
  commonly used properties already provided. (e.g. `NamedRichEnum`, which contains a name property.)
  These are provided to help minimize boilerplate code.

## Should I ever derive from `RichEnumBase`?

The `RichEnumBase` types exist primarily to make the rest of the
code possible, plus to support one very specific very advanced use case.

While the advanced use case rarely arises I'll describe it. Under some
rare circumstances it's advantageous, performance-wise, to have very large
number of instances of enumerated types. But placing all of them into one containing class
is onerous. Breaking them up into smaller, related groups, becomes desirable.

Yet the default implementation of `RichEnum` forbids this. Enter `RichEnumBase<TEnumeration,TEnumeratedItem>`.
The `TEnumeration` type parameter is the data type that will contain the individual entries. While
`TEnumeratedItem`. As long as `TEnumeratedItem` abides by the following contract,
you can enumerate values of that type, bound to any other type.

```csharp
// the required contract for RichEnumBase
    where TEnumeratedItem : IEquatable<TEnumeratedItem>
                          , IRichEnumValueProvider<TValue>

// the required contract for SortableRichEnumBase
    where TEnumeratedItem : IEquatable<TEnumeratedItem>
                          , IComparable<TEnumeratedItem>
                          , ISortableRichEnumValueProvider<TValue>

public interface IRichEnumValueProvider<out TValue>
   where TValue : IEquatable<TValue>
{
   TValue Value { get; }
}

public interface ISortableRichEnumValueProvider<out TValue> : IRichEnumValueProvider<TValue>
   where TValue : IEquatable<TValue>, IComparable<TValue>;

```

The biggest downside to using this type is it lacks any conversion operators,
equality operators, and relational operators (in the case of `SortableRichEnum`).

Your derived types will need to solve these problems, and they're non-trivial.

Example:

Assuming `MyItem` abides by the contract we could construct the following segregated enum:

```csharp
public class MyItemSetOne : RichEnumBase<MyItemSetOne,MyItem>
{
   public static readonly MyItem Item1 = new (1,nameof(Item1));
   public static readonly MyItem Item2 = new (2,nameof(Item2));
   public static readonly MyItem Item3 = new (3,nameof(Item3));
}

public class MyItemSetTwo : RichEnumBase<MyItemSetTwo,MyItem>
{
   public static readonly MyItem ItemFour = new (4,nameof(Item1));
   public static readonly MyItem ItemFive = new (5,nameof(Item2));
   public static readonly MyItem ItemSize = new (6,nameof(Item3));
}

public class MyItem(int value,string description) : IEquatable<MyItem>
                                                  , IRichEnumValueProvider<int>
{
   public int Value { get; } = value;
   public string Description { get; } = description;

   /// ... Implement Equals and GetHashCode ...
}

```

