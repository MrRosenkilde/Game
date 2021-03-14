using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SIUnits.Prefixes
{
    public static class IPrefixExtensions
    {

        /// <summary>
        /// Assumes that the value doesn't have any prefix and applies this prefix to it
        /// </summary>
        /// <param name="prefix">this prefix</param>
        /// <param name="val">the value the prefix should be applied to</param>
        /// <returns>the value as if it had the prefix applied</returns>
        public static double ApplyTo(this IPrefix prefix, double val)
            => val * Math.Pow(10, prefix.Power);

        public static double ApplyInverseTo(this IPrefix prefix, double val)
            => val * Math.Pow(10, -prefix.Power);

        public static IPrefix Combine(this IPrefix prefix, IPrefix other, out int difference)
        {
            var sum = prefix.Power + other.Power;
            var _new = Prefix.FromPower(sum);
            difference = _new.Power - other.Power;
            return _new;
        }

    }
}
