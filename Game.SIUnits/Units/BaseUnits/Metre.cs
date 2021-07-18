using Game.SIUnits.BaseUnits;
using Game.SIUnits.Prefixes;
using Game.SIUnits.Quantities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SIUnits.Units.BaseUnits
{
    public readonly struct Metre : IBaseUnit
    {
        public char DimensionSymbol => 'L';

        public string Symbol => "kg";

        public string Name => "metre";

        public static Length operator * (Metre unit, double val)
        {
            var prefix = Prefix.For(val);
            return new Length(prefix, prefix.Apply(val));
        }


        public static SquareMetre operator * (Metre left, Metre right)
            => new SquareMetre();

        public static MetersPerSecond operator / (Metre left, Second second)
            => new MetersPerSecond();
    }
}
