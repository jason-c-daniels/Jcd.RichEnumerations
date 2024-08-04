#region

using BenchmarkDotNet.Attributes;

#endregion

namespace Jcd.RichEnumerations.Benchmark;

public class RichEnumVsSmartEnum
{
   [Benchmark]
   public bool RichEnumClassImpl_IsValidOnValidInt()
   {
      return RichEnumClassImpl.IsValid(1);
   }

   [Benchmark]
   public bool RichEnumClassImpl_IsValidOnInvalidInt()
   {
      return RichEnumClassImpl.IsValid(10);
   }

   [Benchmark(Baseline = true)]
   public RichEnumClassImpl RichEnumClassImplFromInt()
   {
      return (RichEnumClassImpl) 1;
   }

   [Benchmark]
   public bool FlagEnumClassImpl_IsValidOnValidInt()
   {
      return FlagEnumClassImpl.IsValid(1);
   }

   [Benchmark]
   public bool FlagEnumClassImpl_IsValidOnInvalidInt()
   {
      return FlagEnumClassImpl.IsValid(FlagEnumClassImpl.AllFlags.Value << 2);
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
   public bool RichEnumRecordImpl_IsValidOnValidInt()
   {
      return RichEnumRecordImpl.IsValid(1);
   }

   [Benchmark]
   public bool RichEnumRecordImpl_IsValidOnInvalidInt()
   {
      return RichEnumRecordImpl.IsValid(10);
   }

   [Benchmark]
   public RichEnumRecordImpl RichEnumRecordImplFromInt()
   {
      return (RichEnumRecordImpl) 1;
   }

   [Benchmark]
   public bool FlagEnumRecordImpl_IsValidOnValidInt()
   {
      return FlagEnumRecordImpl.IsValid(1);
   }

   [Benchmark]
   public bool FlagEnumRecordImpl_IsValidOnInvalidInt()
   {
      return FlagEnumRecordImpl.IsValid(FlagEnumClassImpl.AllFlags.Value << 2);
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