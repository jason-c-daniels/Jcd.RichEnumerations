// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

namespace Jcd.RichEnumerations.Classes;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}" /> with TValue set to int.
/// </summary>
/// <typeparam name="TEnum">
/// The enumeration type. This will contain both the structure definition and the enumeration
/// entries as public static readonly fields.
/// </typeparam>
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
public abstract class RichEnum<TEnum>(int value) : RichEnum<int, TEnum>(value)
   where TEnum : RichEnum<TEnum>;