using System.Runtime.CompilerServices;

namespace Jcd.RichEnumerations.Records;

/// <summary>
/// A rich enum that can be sorted with a call to <c>.Sort()</c>.
/// </summary>
/// <typeparam name="TEnum">The type deriving from SortableEnum{TEnum}</typeparam>
/// <example>
/// <code>
/// public class MySortableRichEnum(int value, string customText) : SortableRichEnum&lt;MySortableRichEnum&gt;(value)
/// {
///      public static readonly MySortableRichEnum Item1 = new (1, "First Item");
///      public static readonly MySortableRichEnum Item2 = new (-1, "Second Item");
///
///      public string CustomText => customText;
/// }
///
/// // ...
/// class Program
/// {
///    public void Main()
///    {
///       // Call .Sort during app startup.
///
///       // This sorts numerically, ascending.
///       MySortableRichEnum.Sort();
///
///       // This sorts numerically, descending.
///       MySortableRichEnum.Sort((x,y) => y.Value.CompareTo(x.Value));
///    }
/// }
///
/// </code>
/// </example>
public record SortableRichEnum<TEnum> : SortableRichEnum<int, TEnum>
   where TEnum : SortableRichEnum<TEnum>, ISortableRichEnumValueProvider<int>
{
   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected SortableRichEnum(int value)
      : base(value)
   {
   }
}