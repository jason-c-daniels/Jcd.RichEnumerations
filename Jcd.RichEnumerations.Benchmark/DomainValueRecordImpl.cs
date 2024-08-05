#region

using Jcd.RichEnumerations.Records;

#endregion

namespace Jcd.RichEnumerations.Benchmark;

public record DomainValueRecordImpl(int value) : DomainValue<DomainValueRecordImpl>(value);