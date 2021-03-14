using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Atto : IPrefix
    {
        public int Power => -18;
        public string LongSymbol => "atto";

        public char ShortSymbol => 'a';
    }
}
