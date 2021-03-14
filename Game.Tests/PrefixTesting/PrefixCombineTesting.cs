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
    public class PrefixCombineTesting
    {
        [TestMethod]
        public void KiloCombineKilIsMega() 
        {
            var pf = new Kilo().Combine(new Kilo(), out var diff);
            AreEqual(6, pf.Power);
            AreEqual(diff, 3, "expected diff to be 3");
        }

        [TestMethod]
        public void CombiningDoesNotGoBeyondYotta() 
        {
            var pf = new Yotta().Combine(new Yotta(), out var diff);
            AreEqual(24, pf.Power);
        }
    }
}
