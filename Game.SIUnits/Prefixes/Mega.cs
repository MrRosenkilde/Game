using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Mega : IPrefix
    {
        public int Power => 6;

        public string LongSymbol => "mega";

        public char ShortSymbol => 'M';
    }
}
