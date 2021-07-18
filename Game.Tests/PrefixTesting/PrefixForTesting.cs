using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.SIUnits;
using Game.Shared.Math;
using Game.SIUnits.Prefixes;

namespace Game.Tests.PrefixTesting
{
    [TestClass]
    public class PrefixForTesting
    {
        [TestMethod]
        public void PrefixForReturnAPrefixWithAPowerEqualToTheDigitsInTheNumberRoundedToNearestThird()
        {
            var r = new Random();
            for (int i = 0; i < 10_000; i++)
            {
                var n = r.NextDouble() * r.Next((int) -1E6, (int)1.2E+6);
                var pf = Prefix.For(n);
                int expected = 0;

                //count digits
                var nabs = Math.Abs(n);
                while (nabs > 10) {
                    nabs *= .1;
                    expected++;
                }
                while (nabs < 1) {
                    nabs /= .1;
                    expected--;
                }
                expected = (int)FMath.Floor3(expected);

                AreEqual(expected, pf.Power, $"n: {n}, pow: {pf.Power} passed: {i}");
            }
        }

        [TestMethod]
        public void TestPrefixFor() 
        {
            var r = new Random();
            for (int i = 0; i < 500; i++) {
                var prefix = Prefix.FromPower(r.Next(-24, 25));
                var number = r.NextDouble() + r.Next(1, 10);
                var result = Prefix.For(
                    prefix.Apply(number)
                );
                AreEqual(
                    result.Power, 
                    prefix.Power,
                    message: $"prefix: {prefix} n: {number} result: {result}"
                );
            }

        }
    }
}
