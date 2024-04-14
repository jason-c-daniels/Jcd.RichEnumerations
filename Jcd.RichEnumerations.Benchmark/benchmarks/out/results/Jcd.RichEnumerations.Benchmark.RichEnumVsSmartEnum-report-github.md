```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3447/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.104
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  Job-AUQGYF : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Runtime=.NET 8.0  Toolchain=net8.0  IterationTime=500.0000 ms
MaxIterationCount=15  MinIterationCount=10  WarmupCount=10

```
| Method                                | Mean         | Error      | StdDev     | Ratio  | RatioSD |
|-------------------------------------- |-------------:|-----------:|-----------:|-------:|--------:|
| RichEnumClassImplFromInt              |     4.629 ns |  0.1089 ns |  0.0720 ns |   1.00 |    0.00 |
| FlagEnumClassImplFromInt_Defined      |     5.128 ns |  0.0720 ns |  0.0428 ns |   1.11 |    0.02 |
| FlagEnumClassImplFromInt_Synthesized  |    48.553 ns |  1.2081 ns |  1.1300 ns |  10.43 |    0.29 |
| RichEnumRecordImplFromInt             |     5.355 ns |  0.1308 ns |  0.0684 ns |   1.16 |    0.02 |
| FlagEnumRecordImplFromInt_Defined     |     5.123 ns |  0.1301 ns |  0.0774 ns |   1.10 |    0.02 |
| FlagEnumRecordImplFromInt_Synthesized |    52.185 ns |  0.9644 ns |  0.5739 ns |  11.25 |    0.16 |
| SmartEnumFromInt                      |     4.452 ns |  0.0445 ns |  0.0294 ns |   0.96 |    0.02 |
| SmartFlagEnumFromInt_Defined          | 3,076.936 ns | 60.3121 ns | 39.8927 ns | 664.74 |    9.52 |
| SmartFlagEnumFromInt_Synthesized      | 3,262.331 ns | 64.1572 ns | 38.1789 ns | 703.50 |   14.16 |
