using Game.SIUnits.BaseUnits;
using Game.SIUnits.Prefixes;
using Game.SIUnits.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SIUnits.Quantities
{
    public interface IQuantity
    {
        IUnit Unit { get; }
        IPrefix Prefix { get; init; }
        double Value   { get; init; }


        public string ShortString()
            => $"{Value} {Prefix.ShortSymbol}{Unit.Symbol}";

        public string LongString()
            => $"{Value} {Prefix.LongSymbol}{Unit.Name}";
    }
}
