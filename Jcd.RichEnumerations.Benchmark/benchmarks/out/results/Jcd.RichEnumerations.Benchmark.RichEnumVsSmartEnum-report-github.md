```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3447/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.104
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  Job-DRDOLL : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Runtime=.NET 8.0  Toolchain=net8.0  IterationTime=250.0000 ms
MaxIterationCount=15  MinIterationCount=10  WarmupCount=10

```

| Method                    |     Mean |     Error |    StdDev | Ratio |
|---------------------------|---------:|----------:|----------:|------:|
| RichEnumClassImplFromInt  | 4.729 ns | 0.0669 ns | 0.0442 ns |  1.00 |
| RichEnumRecordImplFromInt | 5.168 ns | 0.0369 ns | 0.0193 ns |  1.09 |
| SmartEnumFromInt          | 4.409 ns | 0.0546 ns | 0.0325 ns |  0.93 |
