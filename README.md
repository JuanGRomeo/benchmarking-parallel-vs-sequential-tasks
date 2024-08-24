# BenchMarking Parallel VS Sequential Tasks

This repository is an exercise to demonstrate the usage of the NuGet package BenchmarkDotNet for benchmarking performance tests.

## Example Description

In this example, we compare the execution time of parallel tasks versus sequential tasks for a specific task or operation. The goal is to measure the performance impact of running tasks in parallel versus running them sequentially.

To simulate external asynchronous calls, we make use of `Task.Delay` method. This allows us to introduce artificial delays in the execution of tasks, mimicking the behavior of real asynchronous operations.

To run the benchmark, follow these steps:

1. Install the BenchmarkDotNet NuGet package.
2. Build the solution.
3. Run the program on Release mode Without Debugging.

After running the benchmark, the results will be displayed, showing the execution time for both the parallel and sequential tasks. These results can be used to analyze the performance difference and make informed decisions about task execution strategies.

Please note that the benchmark results may vary depending on the hardware and software environment in which the benchmark is executed.

## Benchmark Results


BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
12th Gen Intel Core i5-1240P, 1 CPU, 16 logical and 12 physical cores
.NET SDK 8.0.304
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2


 Method              | Mean        | Error    | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s    | Completed Work Items | Lock Contentions | Exceptions | Allocated |
-------------------- |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|--------:|---------------------:|-----------------:|-----------:|----------:|
 ExecuteSequentially | 1,576.09 ms | 6.295 ms | 5.580 ms | 1.491 ms | 1,560.96 ms | 1,575.80 ms | 1,578.09 ms | 1,578.92 ms | 1,581.68 ms |  0.6345 |             100.0000 |                - |          - |  26.64 KB |
 ExecuteInParallel   |    15.80 ms | 0.056 ms | 0.052 ms | 0.014 ms |    15.71 ms |    15.76 ms |    15.81 ms |    15.84 ms |    15.86 ms | 63.2937 |             100.0000 |           0.0625 |          - |  28.32 KB |

 **Legends**

  - Mean                 : Arithmetic mean of all measurements
  - Error                : Half of 99.9% confidence interval
  - StdDev               : Standard deviation of all measurements
  - StdErr               : Standard error of all measurements
  - Min                  : Minimum
  - Q1                   : Quartile 1 (25th percentile)
  - Median               : Value separating the higher half of all measurements (50th percentile)
  - Q3                   : Quartile 3 (75th percentile)
  - Max                  : Maximum
  - Op/s                 : Operation per second
  - Completed Work Items : The number of work items that have been processed in ThreadPool (per single operation)
  - Lock Contentions     : The number of times there was contention upon trying to take a Monitor's lock (per single operation)
  - Exceptions           : Exceptions thrown per single operation
  - Allocated            : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  - 1 ms                 : 1 Millisecond (0.001 sec)