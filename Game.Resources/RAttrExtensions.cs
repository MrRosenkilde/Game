using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Resources
{
    public static class RAttrExtensions
    {
        private readonly static RAttr[] AllAttributes =
            Enum.GetValues(typeof(RAttr))
            .Cast<RAttr>()
            .ToArray();

        public static IEnumerable<RAttr> GetFlags(this RAttr attr) 
        {
            foreach (var flag in AllAttributes)
                if (attr.HasFlag(flag))
                    yield return flag;
        }
    }
}
