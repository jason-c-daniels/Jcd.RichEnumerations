#region

using System.Runtime.CompilerServices;

#endregion

namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A <see cref="SortableRichEnum{TValue,TEnum}" /> with a Name property.
/// </summary>
/// <typeparam name="TEnum">The type being derived from <see cref="NamedSortableRichEnum{TEnum}" /></typeparam>
public abstract record NamedSortableRichEnum<TEnum> : NamedSortableRichEnum<int, TEnum>
   where TEnum : NamedSortableRichEnum<TEnum>, ISortableValueProvider<int>
{
   /// <summary>
   /// Constructs a <see cref="NamedSortableRichEnum{TEnum}" />.
   /// </summary>
   /// <param name="value">The value for this instance. These must be unique.</param>
   /// <param name="name">The name of this instance. These should be unique.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   protected NamedSortableRichEnum(int value, string name)
      : base(value, name)
   {
   }
}