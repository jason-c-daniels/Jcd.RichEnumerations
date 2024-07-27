namespace Jcd.RichEnumerations.Classes;

#pragma warning disable S2094

// ReSharper disable once UnusedType.Global
/// <summary>
/// Provides plain old classes to simplify creating and using DDD-style Rich Enumerations.
/// </summary>
/// <example>
/// <code>
/// public class MyRichEnum(int value, string customText) : RichEnum&lt;MyRichEnum&gt;(value)
/// {
///      public static readonly MyRichEnum Item1 = new (1, "First Item");
///      public static readonly MyRichEnum Item2 = new (2, "Second Item");
/// 
///      public string CustomText => customText;
/// }
/// </code>
/// </example>
internal class NamespaceDoc;