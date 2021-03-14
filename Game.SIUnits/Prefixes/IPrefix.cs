using System;
using System.Collections.Generic;
using System.Text;

namespace Game.SIUnits.Prefixes
{
    public interface IPrefix
    {
        int Power { get; }
        string LongSymbol { get; }
        char ShortSymbol { get; }
        
    }
}
