using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Benchmarks
{
    [ShortRunJob]
    public class PowBenchmarking
    {
        [Params(-4, 3, 24, 100)]
        public int N { get; set; }

        public float Float = MathF.PI;

        private double[] Table = new double[200];
        [GlobalSetup]
        public void Setup() 
        {
            for (int i = -N; i <= N; i++)
                Table[i + N] = Math.Pow(10, i);
        }

        [Benchmark (Baseline = true)]
        public double MathPow() 
            => Math.Pow(10, N);

        [Benchmark]
        public double Lookup()
            => Table[N + 24];

    }
}
