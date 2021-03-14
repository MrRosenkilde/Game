using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Resources
{
    public static class RAttrExtensions
    {
        //private readonly static RAttr AllAttributes

        public static IEnumerable<RAttr> GetFlags(this RAttr attr) 
        {
            long max = (long)Math.Pow(2, 32);
            for (long i = 0x1; i < max; i = i<<1)
                if (attr.HasFlag((RAttr)i))
                    yield return (RAttr)i;
        }
    }
}
