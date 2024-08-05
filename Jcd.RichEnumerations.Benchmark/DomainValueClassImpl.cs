#region

using Jcd.RichEnumerations.Classes;

#endregion

namespace Jcd.RichEnumerations.Benchmark;

public class DomainValueClassImpl(int value) : DomainValue<DomainValueClassImpl>(value);