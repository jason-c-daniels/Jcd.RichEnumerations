```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.107
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-AQFVYU : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Runtime=.NET 8.0  Toolchain=net8.0  IterationTime=500.0000 ms  
MaxIterationCount=15  MinIterationCount=10  WarmupCount=10  

```

| Method                                 |         Mean |      Error |     StdDev |  Ratio | RatioSD |
|----------------------------------------|-------------:|-----------:|-----------:|-------:|--------:|
| RichEnumClassImpl_IsValidOnValidInt    |     2.554 ns |  0.1075 ns |  0.0897 ns |   0.59 |    0.03 |
| RichEnumClassImpl_IsValidOnInvalidInt  |     3.643 ns |  0.1097 ns |  0.1026 ns |   0.84 |    0.03 |
| RichEnumClassImplFromInt               |     4.332 ns |  0.1263 ns |  0.0835 ns |   1.00 |    0.00 |
| FlagEnumClassImpl_IsValidOnValidInt    |     3.220 ns |  0.3217 ns |  0.3009 ns |   0.76 |    0.05 |
| FlagEnumClassImpl_IsValidOnInvalidInt  |     5.416 ns |  0.0678 ns |  0.0448 ns |   1.25 |    0.03 |
| FlagEnumClassImplFromInt_Defined       |     8.348 ns |  0.0839 ns |  0.0439 ns |   1.93 |    0.04 |
| FlagEnumClassImplFromInt_Synthesized   |    56.482 ns |  2.2959 ns |  2.1476 ns |  13.11 |    0.62 |
| RichEnumRecordImpl_IsValidOnValidInt   |     2.540 ns |  0.1316 ns |  0.1231 ns |   0.60 |    0.02 |
| RichEnumRecordImpl_IsValidOnInvalidInt |     3.278 ns |  0.0564 ns |  0.0373 ns |   0.76 |    0.02 |
| RichEnumRecordImplFromInt              |     4.775 ns |  0.0856 ns |  0.0566 ns |   1.10 |    0.02 |
| FlagEnumRecordImpl_IsValidOnValidInt   |     2.537 ns |  0.0341 ns |  0.0203 ns |   0.58 |    0.01 |
| FlagEnumRecordImpl_IsValidOnInvalidInt |     5.563 ns |  0.0610 ns |  0.0404 ns |   1.28 |    0.02 |
| FlagEnumRecordImplFromInt_Defined      |     8.282 ns |  0.0733 ns |  0.0436 ns |   1.91 |    0.04 |
| FlagEnumRecordImplFromInt_Synthesized  |    51.775 ns |  0.4900 ns |  0.2916 ns |  11.94 |    0.24 |
| SmartEnumFromInt                       |     3.929 ns |  0.0368 ns |  0.0219 ns |   0.91 |    0.02 |
| SmartFlagEnumFromInt_Defined           | 3,014.954 ns | 48.2617 ns | 28.7197 ns | 695.08 |   16.20 |
| SmartFlagEnumFromInt_Synthesized       | 3,159.417 ns | 45.0138 ns | 29.7738 ns | 729.65 |   16.22 |
