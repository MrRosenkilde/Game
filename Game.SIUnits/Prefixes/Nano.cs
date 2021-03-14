using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Nano : IPrefix
    {
        public int Power => -9;

        public string LongSymbol => "nano";

        public char ShortSymbol => 'n';
    }
}
