using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Tests.MathTesting
{
    [TestClass]
    public class PowImplTesting
    {

        public float Pow(float f, uint pow) 
        {
            while (--pow != 0)
                f *= 10;
            return f;
        }

        [TestMethod]
        public void TestPowImpl() 
        {
            AreEqual(1000, Pow(10, 3));
        }
    }
}
