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
    public class PrefixShiftTesting
    {
        [TestMethod]
        public void ShiftingWithNoneReturnsTheSamePrefix() 
        {
            var prefixes = Prefix.Prefixes;
            for (int i = 0; i < prefixes.Count; i++) { 
                var actual = prefixes[i].Shift(new None());
                AreEqual(prefixes[i].Power, actual.Power);
            }
        }
    }
}
