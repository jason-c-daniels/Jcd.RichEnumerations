using BenchmarkDotNet.Running;

using Jcd.RichEnumerations.Benchmark;

BenchmarkSwitcher
  .FromAssembly(typeof(Program).Assembly)
  .Run(args);