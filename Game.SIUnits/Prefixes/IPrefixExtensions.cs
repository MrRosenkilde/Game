using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SIUnits.Prefixes
{
    public static class IPrefixExtensions
    {
        public static object PrefixesLib { get; private set; }
        private static Pow10LookupTable PowLookup { get; } = new Pow10LookupTable(range: 24);
        /// <summary>
        /// Expands the value to its previous state where the prefix hasn't been applied
        /// </summary>

        public static double Apply(this IPrefix prefix, double val)
            => val * PowLookup[prefix.Power];

        /// <summary>
        /// Gets the value in the base of the prefix
        /// </summary>
        public static double ReverseApplication(this IPrefix prefix, double val)
            => val * PowLookup[-prefix.Power];


        /// <summary>
        /// shifts the base of the value from one prefix to another
        /// </summary>
        public static double MoveTo (this IPrefix from, in IPrefix to, double value)
        {
            var diff = to.Power - from.Power;
            var diff_prefix = Prefix.FromPower(diff);
            return diff_prefix.ReverseApplication(value);
        }

        public static IPrefix Shift(this IPrefix from, IPrefix with)
            => Prefix.FromPower(from.Power + with.Power);

        private class Pow10LookupTable 
        {
            private readonly double[] Table;
            private readonly int Range;
            public Pow10LookupTable(int range) 
            {
                Range = range;
                Table = new double[2 * range + 1];
                float power = MathF.Pow(10, -range);
                for (int i = -range; i <= range; i++)
                {
                    Table[i + range] = power;
                    power *= 10;
                }
            }
            public double this[int power] => Table[power + Range];
        }
    }
}
