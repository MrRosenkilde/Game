using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Zetta : IPrefix
    {
        public int Power => 21;

        public string LongSymbol => "zetta";

        public char ShortSymbol => 'Z';
    }
}
