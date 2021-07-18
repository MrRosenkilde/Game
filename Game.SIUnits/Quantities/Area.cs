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
    public readonly struct Area : IQuantity, IQuantityConstructor<Area>
    {
        public IUnit Unit => new SquareMetre();

        public IPrefix Prefix { get; init; }
        public double Value { get; init; }

        public Area(IPrefix prefix, double value)
        {
            Prefix = prefix;
            Value = value;
        }

        public Area Construct(IPrefix prefix, double value)
            => new Area(prefix, value);

        public static Area operator -(Area q)
            => new Area(q.Prefix, q.Value);

        public static Area operator +(Area q, double val)
            => new Area(q.Prefix, q.Value + val);

        public static Area operator -(Area q, double val)
            => new Area(q.Prefix, q.Value - val);

        public static Area operator * (Area q, double val)
            => new Area(q.Prefix, q.Value * val);

        public static Area operator / (Area q, double val)
            => new Area(q.Prefix, q.Value / val);

        public static Area operator +(Area left, Area right)
            => left.DefaultAdd(right);

        public static Area operator -(Area left, Area right)
            => left.DefaultAdd(-right);

        public static Volume operator *(Area left, Area right)
            => new Volume(
                prefix: left.Prefix.Shift(right.Prefix),
                value: left.Value * right.Value
            );

        public static implicit operator Area(double val)
            => new Area(new None(), val);

        
    }
}
