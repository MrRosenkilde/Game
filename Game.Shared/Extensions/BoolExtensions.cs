using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Shared.Extensions
{
    public static class BoolExtensions
    {
        public static int Int(this bool _bool)
            => Convert.ToInt32(_bool);
    }
}
