using Game.SIUnits.Prefixes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SIUnits.Quantities
{
    public static class IQuantityExtensions
    {
        public static T Simplify<T>(this T quantity) where T : IQuantity, new()
        {
            //throw new NotImplementedException();
            var prefix = Prefix.For(quantity.Value);
            var newPrefix = prefix.Combine(quantity.Prefix, out var difference);
            var newValue = quantity.Value * Math.Pow(10, -difference);

            //var newValue = difference.ApplyTo(quantity.Value);
            //var newPrefix = difference.Combine(quantity.Value, out int remainder);
            return new T
            {
                Prefix = newPrefix,
                Value = newValue
            };
        }

    }
}
