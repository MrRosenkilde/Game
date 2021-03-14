using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct CustomPrefix : IPrefix
    {
        public string LongSymbol { get; }
        public int Power { get; }

        public char ShortSymbol { get; }

        public CustomPrefix(string symbol, int power, char short_symbol)
        {
            LongSymbol = symbol;
            Power = power;
            ShortSymbol = short_symbol;
        }
    }
}
