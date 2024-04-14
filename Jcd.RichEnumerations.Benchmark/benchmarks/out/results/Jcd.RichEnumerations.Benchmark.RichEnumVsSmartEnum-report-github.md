```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3447/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.104
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  Job-QCWLJF : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Runtime=.NET 8.0  Toolchain=net8.0  IterationTime=500.0000 ms  
MaxIterationCount=15  MinIterationCount=10  WarmupCount=10  

```
| Method                                | Mean         | Error      | StdDev     | Ratio  | RatioSD |
|-------------------------------------- |-------------:|-----------:|-----------:|-------:|--------:|
| RichEnumClassImplFromInt              |     4.525 ns |  0.0531 ns |  0.0316 ns |   1.00 |    0.00 |
| FlagEnumClassImplFromInt_Defined      |     5.037 ns |  0.1397 ns |  0.1090 ns |   1.11 |    0.02 |
| FlagEnumClassImplFromInt_Synthesized  |    46.018 ns |  0.9449 ns |  0.8376 ns |  10.20 |    0.25 |
| RichEnumRecordImplFromInt             |     5.118 ns |  0.1484 ns |  0.1388 ns |   1.14 |    0.03 |
| FlagEnumRecordImplFromInt_Defined     |     4.915 ns |  0.1338 ns |  0.1186 ns |   1.10 |    0.03 |
| FlagEnumRecordImplFromInt_Synthesized |    49.626 ns |  0.9572 ns |  0.5006 ns |  10.96 |    0.15 |
| SmartEnumFromInt                      |     4.237 ns |  0.0578 ns |  0.0302 ns |   0.94 |    0.01 |
| SmartFlagEnumFromInt_Defined          | 2,987.080 ns | 19.6095 ns | 11.6693 ns | 660.21 |    5.70 |
| SmartFlagEnumFromInt_Synthesized      | 3,131.327 ns | 28.3360 ns | 16.8623 ns | 692.08 |    5.78 |
