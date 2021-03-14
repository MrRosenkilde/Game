using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Game.Resources
{
    public readonly struct Amount
    {
        public BigInteger Value { get; init; }
        public MassUnits Unit { get; init; }

        public Amount(BigInteger amount, MassUnits unit)
        {
            Value = amount;
            Unit = unit;
        }

        public static implicit operator Amount((BigInteger value, MassUnits unit) amount)
            => new Amount(amount.value, amount.unit);
    }
}
