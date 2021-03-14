using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Giga : IPrefix
    {
        public int Power => 9;

        public string LongSymbol => "giga";

        public char ShortSymbol => 'G';
    }
}
