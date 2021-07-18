using BenchmarkDotNet.Attributes;
using Game.Shared.Math;
using System;
using System.Collections.Generic;

namespace Game.Benchmarks
{
    [ShortRunJob]
    public class Log10Benchmarking
    {
        [Params(100)]
        public double Param { get; set; }

        private double[] Table = new double[49];
        private readonly int n = 24;

        [GlobalSetup]
        public void Setup() 
        {
            for (int i = 0; i < Table.Length; i++)
                Table[i] = Math.Pow(10, -n + i);
        }

        [Benchmark(Baseline = true)]
        public double MathImpl()
            => FMath.Clamp(
                (int)FMath.Floor3(
                    Math.Log10(
                        Math.Abs(Param)
                    )
                ) + 8, 0, 16);

        [Benchmark]
        public int Switch()
            => (Param > 1E+24 ?
                8 :
                Param > 1E+21 ?
                7 :
                Param > 1E+18 ?
                6 :
                Param > 1E+15 ?
                5 :
                Param > 1E+12 ?
                4 :
                Param > 1E+9 ?
                3 :
                Param > 1E+6 ?
                2 :
                Param > 1E+3 ?
                1 :
                Param > 1E+0 ?
                0 :
                Param > 1E-3 ?
                -1 :
                Param > 1E-6 ?
                -2 :
                Param > 1E-9 ?
                -3 :
                Param > 1E-12 ?
                -4 :
                Param > 1E-15 ?
                -5 :
                Param > 1E-18 ?
                -6 :
                Param > 1E-21 ?
                -7 :
                -8) + 8;


        public int BinarySearchForMatch(
            double[] arr,
            IComparable<double> comparer)
        {
            int min = 0;
            int max = arr.Length- 1;

            while (min <= max)
            {
                int mid = (int) ((min + max) * .5f);
                int comparison = comparer.CompareTo(arr[mid]);
                if (comparison == -1 && comparer.CompareTo(arr[mid + 1]) == 1)
                    return mid;
                if (comparison < 0)
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            return ~min;
        }
    }
}