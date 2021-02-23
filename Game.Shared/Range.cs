using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Shared
{
    public readonly struct Range
    {
        /// <summary>
        /// Inclusive From
        /// </summary>
        public readonly int From;
        /// <summary>
        /// Exclusive To
        /// </summary>
        public readonly int To;

        public Range(int from, int to)
        {
            From = from;
            To = to;
        }

        public static implicit operator Range((int from, int to) range)
            => new Range(range.from, range.to);
    }
}
