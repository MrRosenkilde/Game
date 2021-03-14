using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Zepto : IPrefix
    {
        public int Power => -21;

        public string LongSymbol => "zepto";

        public char ShortSymbol => 'z';
    }
}
