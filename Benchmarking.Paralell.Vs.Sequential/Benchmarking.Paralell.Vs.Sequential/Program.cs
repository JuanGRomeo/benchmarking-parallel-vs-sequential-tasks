using BenchmarkDotNet.Running;
using Benchmarking.Paralell.Vs.Sequential;

var summary = BenchmarkRunner.Run<TaskBenchmark>(new Config());