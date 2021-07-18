using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.SIUnits.Quantities;

namespace Game.Tests.QuantityTesting
{
    [TestClass]
    public class SimplifyTesting
    {
        [TestMethod]
        public void Simplifying1200MetreIs1Dot2Kilometre() 
        {
            Length l = (Length)1200d;
            var ls = l.Simplify().Simplify();
            
            AreEqual(1.2d, ls.Value);
        }

        [TestMethod]
        public void Simplifying1200YottaMetreIsStill1200YottaMetre() 
        {
            Length l = (Length) 1200E+24;
            var ls = l.Simplify().Simplify(); //simplify twice for testing reasons
            AreEqual(1200, ls.Value);
            AreEqual(24, ls.Prefix.Power);
        }

        [TestMethod]
        public void SimplifyingANegativeValueIsOk() 
        {
            Length l = (Length) (-1200d);
            var ls = l.Simplify();
            AreEqual(-1.2, ls.Value);
            AreEqual(3, ls.Prefix.Power);
        }

        [TestMethod]
        public void ZeroPoint001Is1Milimetre()
        {
            Length l = (Length) 0.001;
            var ls = l.Simplify().Simplify(); //simplify twice for testing reasons
            AreEqual(1, ls.Value);
            AreEqual(-3, ls.Prefix.Power);
        }
        [TestMethod]
        public void ZeroPoint0001Is100MicroMetre()
        {
            Length l = (Length) (0.0001);
            var ls = l.Simplify().Simplify(); //simplify twice for testing reasons
            AreEqual(100, ls.Value);
            AreEqual(-6, ls.Prefix.Power);
        }

        [TestMethod]
        public void ZeroPoint01Is100Milimetre()
        {
            Length l = (Length) (0.1);
            var ls = l.Simplify().Simplify(); //simplify twice for testing reasons
            AreEqual(100, ls.Value);
            AreEqual(-3, ls.Prefix.Power);
        }

        [TestMethod]
        public void SimplifyingASimplifiedValueDoesNotChangeAnything() 
        {
            var r = new Random();
            for (int i = 0; i < 100_000; i++) 
            {
                Length l = (Length) ((r.Next(-999, 999) + r.NextDouble()) * Math.Pow(10, r.Next(-24, 24)));
                var ls = l.Simplify();
                var lss = ls.Simplify();
                AreEqual(ls.Value, lss.Value);
                AreEqual(ls.Prefix.Power, lss.Prefix.Power);
            }
        }

        [TestMethod]
        public void RandomizedTesting() 
        {
            var r = new Random();
            for (int i = 0; i < 10_000; i++) 
            {
                var power_roll = r.Next(-24, 24);
                var n_roll = (r.Next(1, 999) + r.NextDouble());
                Console.WriteLine($"power: {power_roll}");
                Console.WriteLine($"n: {n_roll}");
                var val = n_roll * Math.Pow(10, power_roll);
                Length l = (Length) val;
                l = l.Simplify();
                var expected_power = (int)Math.Floor(Math.Log10(val) / 3) * 3;
                var expected_n = val * Math.Pow(10, -(expected_power));
                AreEqual(expected_n, l.Value, 4);
                AreEqual(expected_power, l.Prefix.Power);
            }
        }

    }
}
