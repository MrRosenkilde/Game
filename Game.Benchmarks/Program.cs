using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Running;

namespace Game.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var runner = BenchmarkRunner.Run<Log10Benchmarking>();
        }
    }
}
