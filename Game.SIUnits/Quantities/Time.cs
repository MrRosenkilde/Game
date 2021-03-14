using Game.SIUnits.BaseUnits;
using Game.SIUnits.Prefixes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SIUnits.Quantities
{
    public readonly struct Time : IQuantity
    {
        public IBaseUnit Unit => new Second();

        public IPrefix Prefix { get; init; }

        public double Value { get; init; }

        public Time(IPrefix prefix, double value)
        {
            Prefix = prefix;
            Value = value;
        }
    }
}
