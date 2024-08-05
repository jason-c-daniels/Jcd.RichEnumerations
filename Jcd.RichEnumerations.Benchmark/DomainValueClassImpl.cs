using Jcd.RichEnumerations.Classes;

namespace Jcd.RichEnumerations.Benchmark;

public class DomainValueClassImpl(int value) : DomainValue<DomainValueClassImpl>(value);