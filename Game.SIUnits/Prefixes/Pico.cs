using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Pico : IPrefix
    {
        public int Power => -12;
        public string LongSymbol => "pico";

        public char ShortSymbol => 'p';
    }
}
