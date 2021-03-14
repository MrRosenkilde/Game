using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Exa : IPrefix
    {
        public int Power => 18;

        public string LongSymbol => "exa";

        public char ShortSymbol => 'E';
    }
}
