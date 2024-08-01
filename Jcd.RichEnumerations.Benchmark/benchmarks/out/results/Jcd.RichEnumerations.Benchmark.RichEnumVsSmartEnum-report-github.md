```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.107
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-ILTRMD : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Runtime=.NET 8.0  Toolchain=net8.0  IterationTime=500.0000 ms
MaxIterationCount=15  MinIterationCount=10  WarmupCount=10

```
| Method                                | Mean         | Error       | StdDev      | Ratio  | RatioSD |
|-------------------------------------- |-------------:|------------:|------------:|-------:|--------:|
| RichEnumClassImplFromInt              |     7.332 ns |   0.2198 ns |   0.1948 ns |   1.00 |    0.00 |
| FlagEnumClassImplFromInt_Defined      |     8.609 ns |   0.3450 ns |   0.2693 ns |   1.17 |    0.05 |
| FlagEnumClassImplFromInt_Synthesized  |    50.653 ns |   2.3469 ns |   2.1953 ns |   6.91 |    0.34 |
| RichEnumRecordImplFromInt             |     7.299 ns |   0.1773 ns |   0.1173 ns |   0.99 |    0.03 |
| FlagEnumRecordImplFromInt_Defined     |     8.665 ns |   0.2047 ns |   0.1480 ns |   1.18 |    0.04 |
| FlagEnumRecordImplFromInt_Synthesized |    54.165 ns |   2.7507 ns |   2.5730 ns |   7.41 |    0.42 |
| SmartEnumFromInt                      |     4.343 ns |   0.1212 ns |   0.1012 ns |   0.59 |    0.02 |
| SmartFlagEnumFromInt_Defined          | 3,122.972 ns |  57.3543 ns |  34.1306 ns | 424.18 |   12.72 |
| SmartFlagEnumFromInt_Synthesized      | 3,358.491 ns | 131.9029 ns | 116.9285 ns | 458.54 |   23.96 |
