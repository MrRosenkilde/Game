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
        
    }
}
