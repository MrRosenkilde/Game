using Game.SIUnits.Prefixes;
using Game.SIUnits.Units;
using Game.SIUnits.Units.BaseUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SIUnits.Quantities
{
    public readonly struct Volume : IQuantity, IQuantityConstructor<Volume>
    {
        public IUnit Unit => new CubicMetre();

        public IPrefix Prefix { get; init; }

        public double Value { get; init; }

        public Volume(IPrefix prefix, double value)
            => (Prefix, Value) = (prefix, value);

        public Volume Construct(IPrefix prefix, double value)
            => new Volume(prefix, value);

        public static Volume operator -(Volume q)
            => new Volume(q.Prefix, -q.Value);

        public static Volume operator +(Volume q, double val)
            => new Volume(q.Prefix, q.Value + val);

        public static Volume operator -(Volume q, double val)
            => new Volume(q.Prefix, q.Value - val);

        public static Volume operator *(Volume q, double val)
            => new Volume(q.Prefix, q.Value * val);

        public static Volume operator /(Volume q, double val)
            => new Volume(q.Prefix, q.Value / val);

        public static Volume operator +(Volume left, Volume right)
            => left.DefaultAdd(right);

        public static Volume operator -(Volume left, Volume right)
            => left.DefaultAdd(-right);

        public static implicit operator Volume(double val)
            => new Volume(new None(), val);


    }
}
