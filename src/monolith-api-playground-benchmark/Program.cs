using BenchmarkDotNet.Running;

namespace monolith_api_playground_benchmark
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StoreRepositoryBenchmarks>();
        }
    }
}
