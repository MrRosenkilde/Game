using Game.SIUnits.Prefixes;
using System;
using System.Numerics;

namespace Game.SIUnits
{
    public readonly struct Mass
    {
        public readonly decimal Value;
        public readonly IPrefix Prefix;
        public Mass(decimal value, IPrefix prefix = null)
        {
            Prefix = prefix ?? new Kilo();
            Value = value * 1000;
        }

        public static Mass operator * (Mass left, decimal right)
            => new Mass(left.Value * right, left.Prefix);

        public static Mass operator / (Mass left, decimal right)
            => new Mass(left.Value * right, left.Prefix);

        public static Mass operator * (Mass left, double right)
            => new Mass(left.Value * new decimal(right), left.Prefix);

        public static Mass operator / (Mass left, double right)
            => new Mass(left.Value * new decimal(right), left.Prefix);

        public static Mass operator + (Mass l, Mass r)
            => new Mass(l.Value + r.Value);

        public static Mass operator - (Mass l, Mass r)
            => new Mass(l.Value - r.Value);

        public override string ToString()
            => $"{Value:e3} {Prefix.LongSymbol}g";

    }
}
