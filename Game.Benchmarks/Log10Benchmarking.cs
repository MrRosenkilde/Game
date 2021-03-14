using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Game.Shared.Math;
using System;

namespace Game.Benchmarks
{
    [ShortRunJob(RuntimeMoniker.CoreRt50)]
    public class Log10Benchmarking
    {
        public const int N = 10_000;
        private double[] numbers = new double[N];
        private double[] numbersZeroToOne = new double[N];
        [GlobalSetup]
        public void setup() 
        {
            var r = new Random();
            for (int i = 0; i < N; i++) {
                numbers[i] = r.Next() * r.NextDouble();
            }
            for (int i = 0; i < N; i++)
            {
                numbersZeroToOne[i] = r.NextDouble();
            }
        }

        [Benchmark(Baseline = true, Description = "Math.Log10")]
        public void MathLog10()
        {
            for (int i = 0; i < N; i++)
            {
                var n = Math.Log10(numbers[i]);
            }
        }

        [Benchmark(Description = "Math.Log10 0-1")]
        public void MathLog10ZeroToOne()
        {
            for (int i = 0; i < N; i++)
            {
                var n = Math.Log10(numbersZeroToOne[i]);
            }
        }

        [Benchmark(Description = "My Method")]
        public void MyImpl()
        {
            for (int i = 0; i < numbers.Length; i++) 
            {
                var n = FMath.Log10(numbers[i]);
            }

        }

        [Benchmark(Description = "My Method 0-1")]
        public void MyImplZeroToOne()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var n = FMath.Log10(numbersZeroToOne[i]);
            }

        }

    }
}