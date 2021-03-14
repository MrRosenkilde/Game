using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Resources
{
    [Flags]
    public enum RAttr
    {
        None        =  0,
        Crafting   =  1,
        Editable    =  2,
        Burnable    =  4,
        Shroom      =  8,
        Plant       = 16,
        Meat        = 32,
        Dangerous   = 64
    }
}
