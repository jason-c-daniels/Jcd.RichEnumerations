```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.107
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-FKFPDD : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Runtime=.NET 8.0  Toolchain=net8.0  IterationTime=500.0000 ms  
MaxIterationCount=15  MinIterationCount=10  WarmupCount=10  

```

| Method                                 |         Mean |      Error |     StdDev |  Ratio | RatioSD |
|----------------------------------------|-------------:|-----------:|-----------:|-------:|--------:|
| RichEnumClassImpl_IsValidOnValidInt    |     2.565 ns |  0.0531 ns |  0.0278 ns |   0.55 |    0.02 |
| RichEnumClassImpl_IsValidOnInvalidInt  |     3.768 ns |  0.1767 ns |  0.1653 ns |   0.80 |    0.05 |
| RichEnumClassImplFromInt               |     4.736 ns |  0.2134 ns |  0.1996 ns |   1.00 |    0.00 |
| FlagEnumClassImpl_IsValidOnValidInt    |     2.949 ns |  0.2060 ns |  0.1826 ns |   0.62 |    0.04 |
| FlagEnumClassImpl_IsValidOnInvalidInt  |     5.847 ns |  0.3121 ns |  0.2919 ns |   1.24 |    0.08 |
| FlagEnumClassImplFromInt_Defined       |     4.975 ns |  0.2090 ns |  0.1955 ns |   1.05 |    0.05 |
| FlagEnumClassImplFromInt_Synthesized   |    49.826 ns |  0.9442 ns |  0.7372 ns |  10.53 |    0.40 |
| RichEnumRecordImpl_IsValidOnValidInt   |     2.581 ns |  0.1311 ns |  0.1226 ns |   0.55 |    0.02 |
| RichEnumRecordImpl_IsValidOnInvalidInt |     3.378 ns |  0.1004 ns |  0.0890 ns |   0.72 |    0.04 |
| RichEnumRecordImplFromInt              |     4.737 ns |  0.1587 ns |  0.1239 ns |   1.00 |    0.05 |
| FlagEnumRecordImpl_IsValidOnValidInt   |     2.712 ns |  0.0786 ns |  0.0614 ns |   0.57 |    0.02 |
| FlagEnumRecordImpl_IsValidOnInvalidInt |     5.606 ns |  0.0901 ns |  0.0596 ns |   1.19 |    0.05 |
| FlagEnumRecordImplFromInt_Defined      |     4.766 ns |  0.1298 ns |  0.0772 ns |   1.01 |    0.05 |
| FlagEnumRecordImplFromInt_Synthesized  |    51.209 ns |  1.1401 ns |  1.0664 ns |  10.83 |    0.48 |
| SmartEnumFromInt                       |     4.119 ns |  0.0868 ns |  0.0574 ns |   0.87 |    0.04 |
| SmartFlagEnumFromInt_Defined           | 3,125.983 ns | 61.8501 ns | 40.9100 ns | 662.05 |   27.26 |
| SmartFlagEnumFromInt_Synthesized       | 3,283.287 ns | 50.4939 ns | 26.4093 ns | 702.69 |   25.99 |
