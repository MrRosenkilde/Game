using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Femto : IPrefix
    {
        public int Power => -15;

        public string LongSymbol => "femto";

        public char ShortSymbol => 'f';
    }
}
