```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.107
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-ERGTTC : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Runtime=.NET 8.0  Toolchain=net8.0  IterationTime=500.0000 ms  
MaxIterationCount=15  MinIterationCount=10  WarmupCount=10  

```

| Method                                |         Mean |       Error |      StdDev |  Ratio | RatioSD |
|---------------------------------------|-------------:|------------:|------------:|-------:|--------:|
| RichEnumClassImplFromInt              |     4.479 ns |   0.0656 ns |   0.0390 ns |   1.00 |    0.00 |
| FlagEnumClassImplFromInt_Defined      |     5.359 ns |   0.3554 ns |   0.3151 ns |   1.21 |    0.08 |
| FlagEnumClassImplFromInt_Synthesized  |    51.128 ns |   2.6057 ns |   2.3099 ns |  11.53 |    0.66 |
| RichEnumRecordImplFromInt             |     5.040 ns |   0.1330 ns |   0.1110 ns |   1.13 |    0.03 |
| FlagEnumRecordImplFromInt_Defined     |     5.044 ns |   0.1086 ns |   0.0719 ns |   1.13 |    0.02 |
| FlagEnumRecordImplFromInt_Synthesized |    50.095 ns |   0.8046 ns |   0.5818 ns |  11.19 |    0.19 |
| SmartEnumFromInt                      |     4.717 ns |   0.5727 ns |   0.5358 ns |   1.07 |    0.14 |
| SmartFlagEnumFromInt_Defined          | 3,326.138 ns | 260.6011 ns | 243.7664 ns | 769.09 |   58.46 |
| SmartFlagEnumFromInt_Synthesized      | 3,297.533 ns |  69.0711 ns |  53.9262 ns | 736.41 |   15.94 |
