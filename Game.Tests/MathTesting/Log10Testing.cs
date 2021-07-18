using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Shared.Math;

namespace Game.Tests.MathTesting
{

    [TestClass]
    public class Log10Testing
    {
        private double[] Table = new double[49];
        private readonly int n = 24;

        public Log10Testing() 
        {
            for (int i = 0; i < Table.Length; i++)
                Table[i] = Math.Pow(10, -n + i);
        }

        [TestMethod]
        public void TestLookup() 
        {
            AreEqual(
                expected: 2,
                Lookup(123.456)
            );
        }

        public void Setup()
        {
            for (int i = 0; i < Table.Length; i++)
                Table[i] = Math.Pow(10, -n + i);
        }

        public int Lookup(double param)
        {
            var index = BinarySearchForMatch(
                Table,
                (n) => Convert.ToInt32(n > param) -
                    Convert.ToInt32(n < param)
            );
            return index - n;
        }

        public static int BinarySearchForMatch<T>(
            IList<T> list,
            Func<T, int> comparer)
        {
            int min = 0;
            int max = list.Count - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                int comparison = comparer(list[mid]);

                if (comparison == -1 && comparer(list[mid + 1]) == 1)
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
