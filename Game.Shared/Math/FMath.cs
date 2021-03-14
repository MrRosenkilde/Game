using Game.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Shared.Math
{
    public static class FMath
    {
        public static int Clamp(int val, int min, int max)
            => val +
                (max - val) * (val > max).Int() +
                (min - val) * (val < min).Int();

        public static double Floor3(double n) =>
            ((int)n / 3) * 
            3 - (Convert.ToInt32(n < 0 && n % 3 != 0) * 3);
        //private static int Log10GreaterThanOne(double val)
        //{
        //    int i = 0;
        //    while (val > 10)
        //    {
        //        val *= .1;
        //        i++;
        //    }
        //    return i;
        //}

        //private static int Log10GreaterThanOne(double val)
        //{
        //    int i = 0;
        //    uint ival = (uint)val;
        //    while (ival > 1)
        //    {
        //        ival >>= 1;
        //        i++;
        //    }
        //    return (int) (i * 0.3010299956639812d);
        //}

        //private static int Log10BetweenZeroAndOne(double val) 
        //{
        //    int i = 0;
        //    while (val < 1)
        //    {
        //        val *= 10;
        //        i++;
        //    }
        //    return -i;
        //}
        //public static int Log10(double val)
        //{
        //    if (val <= 0) throw new ArgumentException($"{val} must be greathre then zero");
        //    return val < 1 ?
        //        Log10BetweenZeroAndOne(val) :
        //        -Log10BetweenZeroAndOne(1 / val) - 1;
        //}
        //public static double Log10(double val)
        //{
        //    int i = 0;
        //    while (val > 0) {
        //        val >>= 1;
        //        i++;
        //    }
        //    return System.Math.Log2(val) * 0.3010299956639812d;
        //}
    }
}
