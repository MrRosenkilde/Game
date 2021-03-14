using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.SIUnits.Prefixes;
using Game.SIUnits;

namespace Game.Tests.PrefixTesting
{
    [TestClass]
    public class PrefixApplyTesting
    {
        [TestMethod]
        public void ApplyToReturnsOrginalValue() 
        {
            var r = new Random();
            for (int i = 0; i < 10_000; i++) { 
                var n = r.NextDouble() + r.Next(-1000, 1000);
                var pf = Prefix.Prefixes[r.Next(0, Prefix.Prefixes.Count - 1)];
                AreEqual(n * Math.Pow(10, pf.Power), pf.ApplyTo(n));
            }
        }

        [TestMethod]
        public void ApplyInverseReversesAnApplicationOfAPrefix()
        {
            var r = new Random();
            for (int i = 0; i < 10_000; i++)
            {
                var n = r.NextDouble() * r.Next(int.MinValue, int.MaxValue);
                var pf = Prefix.Prefixes[r.Next(0, Prefix.Prefixes.Count - 1)];
                AreEqual(n, pf.ApplyInverseTo(pf.ApplyTo(n)), 5);
            }
        }

        

    }
}
