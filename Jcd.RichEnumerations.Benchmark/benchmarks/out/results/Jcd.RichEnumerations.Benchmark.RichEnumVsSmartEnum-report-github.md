```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.107
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-RYTHAU : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Runtime=.NET 8.0  Toolchain=net8.0  IterationTime=500.0000 ms
MaxIterationCount=15  MinIterationCount=10  WarmupCount=10

```

| Method                                 |         Mean |      Error |     StdDev |  Ratio | RatioSD |
|----------------------------------------|-------------:|-----------:|-----------:|-------:|--------:|
| DomainValueClassImpl_Constructor       |     2.387 ns |  0.1603 ns |  0.1499 ns |   0.53 |    0.04 |
| DomainValueRecordImpl_Constructor      |     2.343 ns |  0.1137 ns |  0.0950 ns |   0.52 |    0.02 |
| RichEnumClassImpl_IsValidOnValidInt    |     2.522 ns |  0.0760 ns |  0.0550 ns |   0.55 |    0.01 |
| RichEnumClassImpl_IsValidOnInvalidInt  |     3.607 ns |  0.0657 ns |  0.0434 ns |   0.79 |    0.02 |
| RichEnumClassImplFromInt               |     4.573 ns |  0.1300 ns |  0.0860 ns |   1.00 |    0.00 |
| FlagEnumClassImpl_IsValidOnValidInt    |     2.714 ns |  0.0858 ns |  0.0670 ns |   0.60 |    0.02 |
| FlagEnumClassImpl_IsValidOnInvalidInt  |     6.077 ns |  0.1365 ns |  0.0903 ns |   1.33 |    0.03 |
| FlagEnumClassImplFromInt_Defined       |     4.909 ns |  0.1520 ns |  0.1099 ns |   1.07 |    0.04 |
| FlagEnumClassImplFromInt_Synthesized   |    45.925 ns |  0.9134 ns |  0.4777 ns |  10.08 |    0.21 |
| RichEnumRecordImpl_IsValidOnValidInt   |     2.584 ns |  0.0778 ns |  0.0650 ns |   0.57 |    0.02 |
| RichEnumRecordImpl_IsValidOnInvalidInt |     3.281 ns |  0.0980 ns |  0.0917 ns |   0.71 |    0.03 |
| RichEnumRecordImplFromInt              |     4.726 ns |  0.1393 ns |  0.1007 ns |   1.03 |    0.02 |
| FlagEnumRecordImpl_IsValidOnValidInt   |     2.657 ns |  0.1065 ns |  0.0996 ns |   0.58 |    0.02 |
| FlagEnumRecordImpl_IsValidOnInvalidInt |     5.920 ns |  0.1479 ns |  0.1384 ns |   1.29 |    0.03 |
| FlagEnumRecordImplFromInt_Defined      |     4.592 ns |  0.1417 ns |  0.0938 ns |   1.00 |    0.03 |
| FlagEnumRecordImplFromInt_Synthesized  |    53.565 ns |  1.0604 ns |  0.8854 ns |  11.70 |    0.23 |
| SmartEnumFromInt                       |     4.139 ns |  0.1051 ns |  0.0625 ns |   0.91 |    0.01 |
| SmartFlagEnumFromInt_Defined           | 3,198.214 ns | 59.4932 ns | 52.7392 ns | 697.12 |   20.94 |
| SmartFlagEnumFromInt_Synthesized       | 3,296.425 ns | 64.6848 ns | 42.7850 ns | 721.00 |   13.87 |
