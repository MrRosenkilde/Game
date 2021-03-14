using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Milli : IPrefix
    {
        public int Power => -3;

        public string LongSymbol => "milli";

        public char ShortSymbol => 'm';
    }
}
