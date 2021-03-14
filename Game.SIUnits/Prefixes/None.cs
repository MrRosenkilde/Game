using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct None : IPrefix
    {
        public int Power => 0;

        public string LongSymbol => "";

        public char ShortSymbol => ' ';
    }
}
