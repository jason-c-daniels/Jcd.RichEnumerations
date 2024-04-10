namespace Jcd.RichEnumerations.Records;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}" /> with TValue set to int.
/// </summary>
/// <typeparam name="TEnum">
/// The enumeration type. This will contain both the structure definition and the enumeration
/// entries as public static readonly fields.
/// </typeparam>
public abstract record RichEnum<TEnum> : RichEnum<int, TEnum>
   where TEnum : RichEnum<TEnum>
{
   /// <inheritdoc />
   protected RichEnum(int value)
      : base(value)
   {
   }
}