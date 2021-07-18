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
        public static T Simplify<T>(this T quantity) where T : IQuantity, IQuantityConstructor<T>
        {
            var prefix = Prefix.For(quantity.Value);
            var new_prefix = quantity.Prefix.Shift(prefix);
            var new_value = quantity.Prefix.MoveTo(new_prefix, quantity.Value);
            return quantity.Construct(
                prefix: new_prefix,
                value: new_value
            );
        }

        internal static T DefaultAdd<T>(this T quantity, T other) where T : IQuantity, IQuantityConstructor<T>
        {
            var new_value = quantity.Value + 
                other.Prefix.MoveTo(quantity.Prefix, other.Value);

            return quantity.Construct
            (
                prefix : quantity.Prefix,
                value  : new_value
            );
        }

        internal static double DefaultDivide<T>(this T quantity, T other) where T : IQuantity, IQuantityConstructor<T>
            => quantity.Prefix.Apply(quantity.Value) /
                other.Prefix.Apply(other.Value);

    }
}
