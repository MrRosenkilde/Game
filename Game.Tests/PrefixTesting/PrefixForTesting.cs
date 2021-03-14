using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.SIUnits;

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
                var nabs = Math.Abs(n);
                while (nabs > 10) {
                    nabs *= .1;
                    expected++;
                }
                expected -= (expected % 3);
                AreEqual(expected, pf.Power, $"n: {n}, pow: {pf.Power} passed: {i}");
            }
        }
    }
}
