using Game.SIUnits.BaseUnits;
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
    public readonly struct Length : IQuantity, IQuantityConstructor<Length>
    {
        public IUnit Unit => new Metre();

        public IPrefix Prefix { get; init; }

        public double Value { get; init; }

        public Length(IPrefix prefix, double value)
        {
            Prefix = prefix;
            Value = value;
        }

        public Length Reciprocal()
            => new Length(
                Prefix,
                1 / Value
            );

        public Length Construct(IPrefix prefix, double value)
            => new Length(prefix, value);

        public static Length operator -(Length q)
            => new Length(q.Prefix, -q.Value);

        public static Length operator +(Length q, double val)
            => new Length(q.Prefix, q.Value + val);

        public static Length operator -(Length q, double val)
            => new Length(q.Prefix, q.Value - val);

        public static Length operator *(Length q, double val)
            => new Length(q.Prefix, q.Value * val);

        public static Length operator /(Length q, double val)
            => new Length(q.Prefix, q.Value / val);

        public static Length operator +(Length left, Length right)
            => left.DefaultAdd(right);

        public static Length operator -(Length left, Length right)
            => left.DefaultAdd(-right);

        public static Area operator *(Length left, Length right)
            => new Area(
                prefix: left.Prefix.Shift(right.Prefix),
                value: left.Value * right.Value    
            );

        public static double operator /(Length left, Length right)
            => left.DefaultDivide(right);

        public static implicit operator Length(double val)
            => new Length(new None(), val);


    }
}
