using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static Game.Tests.TestingUtill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.SIUnits.Quantities;

namespace Game.Tests.QuantityTesting
{
    [TestClass]
    public class BasicArithmeticTesting
    {
       
        [TestMethod]
        public void TestAdding()
        {
            BiRandomTest(
                (roll1, roll2) =>
                {
                    Length l = (Length) roll1;
                    var actual = l + roll2;
                    Length expected = (Length) roll1 + (Length) roll2;
                    AreEqual(expected.Value, actual.Value);
                }
            );
        }

        [TestMethod]
        public void TestSubtraction()
        {
            BiRandomTest((roll1, roll2) =>
            {
                Length l = (Length) roll1;
                var actual = l - roll2;
                double expected = roll1 - roll2;
                AreEqual(expected, actual.Value, $"{roll1} - {roll2}");
            });
        }

        [TestMethod]
        public void TestMultiply()
        {
            BiRandomTest((roll1, roll2) =>
            {
                Length l = (Length) roll1;
                var actual = l * roll2;
                double expected = roll1 * roll2;
                AreEqual(expected, actual.Value, $"{roll1} * {roll2}");
            });
        }

        [TestMethod]
        public void TestDivide()
        {
            BiRandomTest((roll1, roll2) =>
            {
                Length l = (Length)roll1;
                var actual = l / roll2;
                double expected = roll1 / roll2;
                AreEqual(expected, actual.Value, $"{roll1} * {roll2}");
            });
        }

        [TestMethod]
        public void TestNegate()
        {
            UnaryRandomTest((roll1) =>
            {
                Length l = (Length)roll1;
                var actual = -l;
                double expected = -roll1;
                AreEqual(expected, actual.Value, $"{-roll1}");
            });
        }
    }
}
