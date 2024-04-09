// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A <see cref="RichEnum{TEnum}" /> with a Description property.
/// </summary>
/// <typeparam name="TEnum">The type deriving from DEnumeration</typeparam>
public abstract record DescribedRichEnum<TEnum> : DescribedRichEnum<int, TEnum>
   where TEnum : DescribedRichEnum<TEnum>
{
   /// <summary>
   /// Constructs a <see cref="DescribedRichEnum{TValue,TEnum}" />
   /// </summary>
   /// <param name="value">the value for this instance. These must be unique.</param>
   /// <param name="description">The description for the instance. These should be unique.</param>
   protected DescribedRichEnum(int value, string description)
      : base(value, description)
   {
   }
}