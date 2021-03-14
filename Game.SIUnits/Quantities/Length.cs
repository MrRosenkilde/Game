using Game.SIUnits.BaseUnits;
using Game.SIUnits.Prefixes;
using Game.SIUnits.Units.BaseUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SIUnits.Quantities
{
    public readonly struct Length : IQuantity
    {
        public IBaseUnit Unit => new Metre();

        public IPrefix Prefix { get; init; }

        public double Value { get; init; }

        public Length(IPrefix prefix, double value)
        {
            Prefix = prefix;
            Value = value;
        }

        public static Length operator + (Length left, double value)
            => new Length();


        public static implicit operator Length(double val)
            => new Length(new None(), val);


    }
}
