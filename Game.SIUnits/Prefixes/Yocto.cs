using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Yocto : IPrefix
    {
        public int Power => -24;
        public string LongSymbol => "yocto";

        public char ShortSymbol => 'y';
    }
}
