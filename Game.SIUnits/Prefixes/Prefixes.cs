using Game.Shared.Extensions;
using Game.Shared.Math;
using Game.SIUnits.Prefixes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits
{
    public static class Prefix
    {
        public static readonly IReadOnlyList<IPrefix> Prefixes = new List<IPrefix>
        {
            new Yocto(),
            new Zepto(),
            new Atto(),
            new Femto(),
            new Pico(),
            new Nano(),
            new Micro(),
            new Milli(),
            new None(),
            new Kilo(),
            new Mega(),
            new Giga(),
            new Tera(),
            new Peta(),
            new Exa(),
            new Zetta(),
            new Yotta(),
        };

        private static IPrefix ShiftedIndex(int index)
            => Prefixes[
                FMath.Clamp(index + 8, 0, 16)
            ];

        public static IPrefix FromPower(int power)
            => ShiftedIndex(power / 3);

        public static IPrefix For(double val)
            => Prefixes[ //looks kinda crazy but it's hella fast
               (val > 1E+24 ?
                8 :
                val > 1E+21 ?
                7 :
                val > 1E+18 ?
                6 :
                val > 1E+15 ?
                5 :
                val > 1E+12 ?
                4 :
                val > 1E+9 ?
                3 :
                val > 1E+6 ?
                2 :
                val > 1E+3 ?
                1 :
                val > 1E+0 ?
                0 :
                val > 1E-3 ?
                -1 :
                val > 1E-6 ?
                -2 :
                val > 1E-9 ?
                -3 :
                val > 1E-12 ?
                -4 :
                val > 1E-15 ?
                -5 :
                val > 1E-18 ?
                -6 :
                val > 1E-21 ?
                -7 :
                -8) + 8
            ];
    }
}
