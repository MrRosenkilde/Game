//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Game.Shared.Math;

//namespace Game.Tests.MathTesting
//{
//    [TestClass]
//    public class Log10Testing
//    {
//        [TestMethod]
//        public void RandomizedTesting() {
//            var r = new Random();
//            for (int i = 0; i < 100_000; i++) {
//                var val = r.Next() * r.NextDouble();
//                AreEqual(Math.Floor(Math.Log10(val)), FMath.Log10(val), $"{val} passed: {i}");
//                //AreEqual(Math.Log10(val), FMath.Log10(val), 3, $"{val}");
//            }
//        }

//        [TestMethod]
//        public void BetweenZeroAndOne()
//        {
//            var r = new Random();
//            for (int i = 0; i < 100_000; i++)
//            {
//                var val = r.NextDouble();
//                AreEqual(Math.Floor(Math.Log10(val)), FMath.Log10(val), $"{val}");
//                //AreEqual(Math.Log10(val), FMath.Log10(val), 3, $"{val}");
//            }
//        }

//        [TestMethod]
//        public void ZeroAndLessThrowError() 
//        {
//            var r = new Random();
//            Console.WriteLine(Math.Log2(10));
//            for (int i = 0; i < 10_000; i++)
//                Assert.ThrowsException<ArgumentException>(() =>
//                    FMath.Log10( r.Next() * (r.NextDouble() - 1))
//                );
//        }
//    }
//}
