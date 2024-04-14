#region

using BenchmarkDotNet.Attributes;

#endregion

namespace Jcd.RichEnumerations.Benchmark;

public class RichEnumVsSmartEnum
{
   [Benchmark(Baseline = true)]
   public RichEnumClassImpl RichEnumClassImplFromInt()
   {
      return (RichEnumClassImpl) 1;
   }

   [Benchmark]
   public RichEnumRecordImpl RichEnumRecordImplFromInt()
   {
      return (RichEnumRecordImpl) 1;
   }

   [Benchmark]
   public SmartEnumImpl SmartEnumFromInt()
   {
      return (SmartEnumImpl) 1;
   }
}