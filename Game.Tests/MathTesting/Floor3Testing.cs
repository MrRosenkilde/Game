using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Shared.Math;
using Game.Shared.Extensions;

namespace Game.Tests.MathTesting
{
    [TestClass]
    public class Floor3Testing
    {
        [TestMethod]
        public void TestFirst100ThousandIntegers() 
        {
            var expected = 0;
            for (int i = 0; i < 100_000; i += 3, expected += 3) 
            {
                AreEqual(expected, FMath.Floor3(i));
                AreEqual(expected, FMath.Floor3(i + 1));
                AreEqual(expected, FMath.Floor3(i + 2));
            }
        }
        [TestMethod]
        public void TestFirst100ThousandNegativeIntegers() 
        {
            var expected = -3;
            for (int i = -1; i > -100_000; i -= 3, expected -= 3) 
            {
                AreEqual(expected, FMath.Floor3(i));
                AreEqual(expected, FMath.Floor3(i - 1));
                AreEqual(expected, FMath.Floor3(i - 2));
            }
        }

        [TestMethod]
        public void Minus11IsFlooredToMinus12() 
        {
            AreEqual(-12, FMath.Floor3(-11));
        }

    }
}
