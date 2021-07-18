using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Tests
{
    public static class TestingUtill
    {
        internal delegate void ActionDoubleDouble(double roll1, double roll2);
        internal delegate void ActionDouble(double roll1);

        private static Random r = new Random();

        private static double Roll()
            => r.Next(int.MinValue, int.MaxValue) * r.NextDouble();

        private static void LoopAndInvoke(Action a, int iterations = 10_000) 
        {
            for (int i = 0; i < iterations; i++)
                a();
        }


        internal static void BiRandomTest(ActionDoubleDouble action, int iterations = 10_000)
            => LoopAndInvoke(
                () => action(Roll(), Roll()),
                iterations
            );
        

        internal static void UnaryRandomTest(ActionDouble action, int iterations = 10_000)
            => LoopAndInvoke(
                () => action(Roll()),
                iterations
            );
        


    }
}
