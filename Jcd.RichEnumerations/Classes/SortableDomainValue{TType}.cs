namespace Jcd.RichEnumerations.Classes;

/// <inheritdoc />
public abstract class SortableDomainValue<TType>(int value) : SortableDomainValue<int, TType>(value)
   where TType : SortableDomainValue<TType>;