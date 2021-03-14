using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Micro : IPrefix
    {
        public int Power => -6;

        public string LongSymbol => "micro";

        public char ShortSymbol => 'μ';
    }
}
