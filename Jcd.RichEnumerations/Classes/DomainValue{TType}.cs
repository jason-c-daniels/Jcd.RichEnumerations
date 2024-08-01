namespace Jcd.RichEnumerations.Classes;

/// <inheritdoc />
public abstract class DomainValue<TType>(int value) : DomainValue<int, TType>(value)
   where TType : DomainValue<int, TType>;