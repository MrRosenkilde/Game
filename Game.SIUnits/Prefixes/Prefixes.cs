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

        public static IPrefix ShiftedIndex(int index)
            => Prefixes[
                FMath.Clamp(index + 8, 0, 16)
            ];

        public static IPrefix FromPower(int power)
            => ShiftedIndex(power / 3);

        public static IPrefix For(double val)
            => FromPower(
                (int)FMath.Floor3(
                    Math.Log10(
                        Math.Abs(val)
                    )
                )
            );
    }
}
