using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Kilo : IPrefix
    {
        public int Power => 3;

        public string LongSymbol => "kilo";

        public char ShortSymbol => 'K';
    }
}
