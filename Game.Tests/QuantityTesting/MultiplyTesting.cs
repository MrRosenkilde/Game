using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
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
    public class MultiplyTesting
    {
        [TestMethod]
        public void LengthTimesLengthIsArea() 
        {
            Length l1 = 3;
            Length l2 = 5;
            var actual = l1 * l2;
            Area expected = 15;
            AreEqual(expected.Value, actual.Value);
            IsTrue(actual is Area);
        }

        [TestMethod]
        public void OnePointTwoKilometersTimes1MeterIsOnePointTwoSquareKilometers()
        {
            Length l1 = new Length(new Kilo(), 1.2d);
            Length l2 = 1;
            var actual = l1 * l2;
            Area expected = new Area(new Kilo(), 1.2d);
            AreEqual(expected.Value, actual.Value);
            AreEqual(expected.Prefix.Power, actual.Prefix.Power);
            
        }
    }
}
