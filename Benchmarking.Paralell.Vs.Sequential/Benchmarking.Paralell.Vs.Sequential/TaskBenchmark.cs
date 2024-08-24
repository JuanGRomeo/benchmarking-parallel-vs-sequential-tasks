using BenchmarkDotNet.Attributes;

namespace Benchmarking.Paralell.Vs.Sequential;

public class TaskBenchmark
{
    private List<int> data;

    [GlobalSetup]
    public void Setup()
    {
        data = Enumerable.Range(1, 100).ToList();
    }

    private async Task SimulateIOOperation(int delay)
    {
        await Task.Delay(delay);
    }

    [Benchmark]
    public async Task ExecuteSequentially()
    {
        foreach (var item in data)
        {
            await SimulateIOOperation(10);
        }
    }

    [Benchmark]
    public async Task ExecuteInParallel()
    {
        var tasks = data.Select(item => SimulateIOOperation(10));
        await Task.WhenAll(tasks);
    }
}