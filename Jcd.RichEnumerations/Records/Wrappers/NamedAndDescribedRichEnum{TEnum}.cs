namespace Jcd.RichEnumerations.Records.Wrappers;

/// <summary>
/// A rich enumeration containing Description, Name and Value properties with int as the underlying Value data type.
/// </summary>
/// <typeparam name="TEnum">The type deriving from NdEnumeration</typeparam>
public abstract record NamedAndDescribedRichEnum<TEnum> : NamedAndDescribedRichEnum<int, TEnum>
   where TEnum : NamedAndDescribedRichEnum<TEnum>
{
   /// <summary>
   /// Constructs a <see cref="NamedAndDescribedRichEnum{TEnum}" />.
   /// </summary>
   /// <param name="value">The value for the instance. This must be unique.</param>
   /// <param name="name">The name for the instance. This should be unique.</param>
   /// <param name="description">The description for the instance. This should be unique.</param>
   protected NamedAndDescribedRichEnum(int value, string name, string description)
      : base(value, name, description)
   {
   }
}