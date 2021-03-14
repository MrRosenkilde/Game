using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Peta : IPrefix
    {
        public int Power => 15;

        public string LongSymbol => "peta";

        public char ShortSymbol => 'P';
    }
}
