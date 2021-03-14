using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Resources.Interfaces
{
    public interface ICraftable
    {
        public sealed RAttr Attr => RAttr.Crafting;
        public Resource[] Recipe { get; }
    }
}
