using Jcd.RichEnumerations.Records;

namespace Jcd.RichEnumerations.Benchmark;

public record DomainValueRecordImpl(int value) : DomainValue<DomainValueRecordImpl>(value);