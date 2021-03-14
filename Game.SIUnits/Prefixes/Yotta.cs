using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Yotta : IPrefix
    {
        public int Power => 24;

        public string LongSymbol => "yotta";

        public char ShortSymbol => 'Y';
    }
}
