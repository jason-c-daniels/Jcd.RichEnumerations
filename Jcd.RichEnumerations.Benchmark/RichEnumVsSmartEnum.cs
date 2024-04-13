using BenchmarkDotNet.Attributes;

namespace Jcd.RichEnumerations.Benchmark;

public class RichEnumVsSmartEnum
{
   [Benchmark(Baseline = true)]
   public RichEnumClassImpl RichEnumClassImplFromInt()
      => (RichEnumClassImpl) 1;

   [Benchmark]
   public RichEnumRecordImpl RichEnumRecordImplFromInt()
      => (RichEnumRecordImpl) 1;

   [Benchmark]
   public SmartEnumImpl SmartEnumFromInt()
      => (SmartEnumImpl) 1;
}