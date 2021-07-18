using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.SIUnits.Prefixes;

namespace Game.Tests.PrefixTesting
{
    [TestClass]
    public class PrefixMoveToTesting
    {
        [TestMethod]
        public void OneThousandKileIsOneMega() 
        {
            var value = new Kilo().MoveTo(new Mega(), 1000);
            AreEqual(1, value, "expected a 1000 kilos to be 1 mega");
        }

        [TestMethod]
        public void OneMegaIsOneThousandKile()
        {
            var value = new Mega().MoveTo(new Kilo(), 1);
            AreEqual(1000, value, "expected 1 mega to be 1000 kilo");
        }

        [TestMethod]
        public void CombiningDoesNotGoBeyondYotta() 
        {
            var value = new Yotta().MoveTo(new Yotta(), 1000);
            AreEqual(1000, value, "expected 1000 yotta to be moved to 1000");
        }
    }
}
