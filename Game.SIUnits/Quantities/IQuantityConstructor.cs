using Game.SIUnits.Prefixes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SIUnits.Quantities
{
    public interface IQuantityConstructor<T>
    {
        T Construct(IPrefix prefix, double value);
    }
}
