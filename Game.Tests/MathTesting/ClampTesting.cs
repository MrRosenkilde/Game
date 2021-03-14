using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Shared.Math;

namespace Game.Tests.MathTesting
{
    [TestClass]
    public class ClampTesting
    {
        [TestMethod]
        public void RandomizedTests() 
        {
            var r = new Random();
            for (int i = 0; i < 100_000; i++) {
                var val = r.Next();
                var min = r.Next();
                var max = r.Next(min, int.MaxValue);
                var result = FMath.Clamp(val, min, max);
                var expected = val <= min ?
                    min :
                    val >= max ?
                    max :
                    val;
                AreEqual(expected, result, $"min: {min} max: {max} val: {val} passes: {i}");
            }
        }
    }
}
