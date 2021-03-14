using Game.SIUnits.BaseUnits;
using Game.SIUnits.Prefixes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SIUnits.Quantities
{
    public interface IQuantity
    {
        IBaseUnit Unit { get; }
        IPrefix Prefix { get; init; }
        double Value   { get; init; }
    }
}
