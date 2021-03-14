using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public readonly struct Tera : IPrefix
    {
        public int Power => 12;

        public string LongSymbol => "tera";

        public char ShortSymbol => 'T';
    }
}
