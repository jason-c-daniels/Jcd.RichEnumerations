#region

using BenchmarkDotNet.Attributes;

using Jcd.RichEnumerations.Records;

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
   public FlagEnumClassImpl FlagEnumClassImplFromInt_Defined()
   {
      return (FlagEnumClassImpl) 1;
   }

   [Benchmark]
   public FlagEnumClassImpl FlagEnumClassImplFromInt_Synthesized()
   {
      return (FlagEnumClassImpl) 3;
   }

   [Benchmark]
   public RichEnumRecordImpl RichEnumRecordImplFromInt()
   {
      return (RichEnumRecordImpl) 1;
   }

   [Benchmark]
   public FlagEnumRecordImpl FlagEnumRecordImplFromInt_Defined()
   {
      return (FlagEnumRecordImpl) 1;
   }

   [Benchmark]
   public FlagEnumRecordImpl FlagEnumRecordImplFromInt_Synthesized()
   {
      return (FlagEnumRecordImpl) 3;
   }

   [Benchmark]
   public SmartEnumImpl SmartEnumFromInt()
   {
      return (SmartEnumImpl) 1;
   }

   [Benchmark]
   public SmartFlagEnumImpl SmartFlagEnumFromInt_Defined()
   {
      return (SmartFlagEnumImpl) 1;
   }

   [Benchmark]
   public SmartFlagEnumImpl SmartFlagEnumFromInt_Synthesized()
   {
      return (SmartFlagEnumImpl) 3;
   }
}