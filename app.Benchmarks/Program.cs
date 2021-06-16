using System;
using BenchmarkDotNet.Running;

namespace app.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DateParserBenchmarks>();
        }
    }
}
