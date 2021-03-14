using Game.SIUnits.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SIUnits.BaseUnits
{
    public interface IBaseUnit : IUnit
    {
        char DimensionSymbol { get; }

    }
}
