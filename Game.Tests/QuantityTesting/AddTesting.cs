using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static Game.Tests.TestingUtill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.SIUnits.Quantities;
using Game.SIUnits.Prefixes;

namespace Game.Tests.QuantityTesting
{
    [TestClass]
    public class AddTesting
    {

        [TestMethod]
        public void TwoMetersPlusFiveMetersAreSeventMeters() 
        {
            Length l = 2d;
            Length r = 3d;
            Length expected = 5d;
            AreEqual(expected, l + r);
        }

        [TestMethod]
        public void SimpleRandomizedTesting() 
        {
            BiRandomTest((roll1, roll2) =>
            {
                Length left = roll1;
                Length right = roll2;
                AreEqual(roll1 + roll2, (left + right).Value);
            });
        }

        [TestMethod]
        public void TwoKilometersPlusOneMeterIsTwoPoint001Kilometers() 
        {
            Length left = new Length(new Kilo(), 2);
            Length right = 1;
            var result = left + right;
            var expected = new Length(new Kilo(), 2.001);
            AreEqual(expected.Value, result.Value);
            AreEqual(new Kilo().Power, result.Prefix.Power);
        }
    }
}
