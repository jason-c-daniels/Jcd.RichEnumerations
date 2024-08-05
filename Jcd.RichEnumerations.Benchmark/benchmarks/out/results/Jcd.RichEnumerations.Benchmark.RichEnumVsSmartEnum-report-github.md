```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.107
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-KWDFTH : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Runtime=.NET 8.0  Toolchain=net8.0  IterationTime=500.0000 ms  
MaxIterationCount=15  MinIterationCount=10  WarmupCount=10  

```
| Method                                 | Mean         | Error      | StdDev     | Ratio  | RatioSD |
|--------------------------------------- |-------------:|-----------:|-----------:|-------:|--------:|
| DomainValueClassImpl_Constructor       |     2.283 ns |  0.0910 ns |  0.0542 ns |   0.50 |    0.01 |
| DomainValueRecordImpl_Constructor      |     2.283 ns |  0.0547 ns |  0.0325 ns |   0.50 |    0.01 |
| RichEnumClassImpl_IsValidOnValidInt    |     2.583 ns |  0.0770 ns |  0.0682 ns |   0.56 |    0.02 |
| RichEnumClassImpl_IsValidOnInvalidInt  |     3.566 ns |  0.0953 ns |  0.0744 ns |   0.78 |    0.02 |
| RichEnumClassImplFromInt               |     4.567 ns |  0.1153 ns |  0.0763 ns |   1.00 |    0.00 |
| FlagEnumClassImpl_IsValidOnValidInt    |     2.711 ns |  0.0830 ns |  0.0600 ns |   0.59 |    0.02 |
| FlagEnumClassImpl_IsValidOnInvalidInt  |     5.639 ns |  0.1445 ns |  0.0756 ns |   1.23 |    0.03 |
| FlagEnumClassImplFromInt_Defined       |     4.741 ns |  0.1146 ns |  0.0758 ns |   1.04 |    0.02 |
| FlagEnumClassImplFromInt_Synthesized   |    48.106 ns |  0.4180 ns |  0.2487 ns |  10.53 |    0.18 |
| RichEnumRecordImpl_IsValidOnValidInt   |     2.492 ns |  0.0622 ns |  0.0411 ns |   0.55 |    0.02 |
| RichEnumRecordImpl_IsValidOnInvalidInt |     3.180 ns |  0.0945 ns |  0.0738 ns |   0.70 |    0.03 |
| RichEnumRecordImplFromInt              |     4.802 ns |  0.0916 ns |  0.0606 ns |   1.05 |    0.02 |
| FlagEnumRecordImpl_IsValidOnValidInt   |     2.615 ns |  0.0613 ns |  0.0405 ns |   0.57 |    0.02 |
| FlagEnumRecordImpl_IsValidOnInvalidInt |     5.822 ns |  0.1496 ns |  0.0990 ns |   1.28 |    0.03 |
| FlagEnumRecordImplFromInt_Defined      |     5.072 ns |  0.2802 ns |  0.2621 ns |   1.14 |    0.06 |
| FlagEnumRecordImplFromInt_Synthesized  |    51.215 ns |  0.2142 ns |  0.1275 ns |  11.21 |    0.19 |
| SmartEnumFromInt                       |     4.166 ns |  0.1138 ns |  0.0752 ns |   0.91 |    0.02 |
| SmartFlagEnumFromInt_Defined           | 3,142.020 ns | 60.0117 ns | 39.6940 ns | 688.12 |   14.93 |
| SmartFlagEnumFromInt_Synthesized       | 3,346.951 ns | 22.9406 ns | 13.6516 ns | 732.83 |   11.77 |
