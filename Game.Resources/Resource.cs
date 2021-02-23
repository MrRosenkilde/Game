using System;
using System.Collections.Generic;

namespace Game.Resources
{
    public struct Resource
    {
        public uint Amount { get; private set; }
        public RType Type { get; }
        public RAttr Attributes { get; }


        public Resource(RType type)
            : this(0u, type) { }

        public Resource(uint start_amount, RType type)
        {
            Amount = start_amount;
            Type = type;
            Attributes = type.Attributes();
        }

        /// <summary>
        /// adds the amount to this resource
        /// </summary>
        /// <param name="amount">ned amount to increase the resource with</param>
        public void Earn(uint amount) 
            => Amount += amount;
        
        public bool Spend(uint amount) {
            if (Has(amount)) { 
                Amount -= amount;
                return true;
            }
            return false;
        } 
        public bool Has(uint amount) => Amount >= amount;
        
        public static implicit operator Resource(RType type)
            => new Resource(type);

        public static implicit operator Resource((uint amount, RType type) tuple)
            => new Resource(tuple.amount, tuple.type);

        public override string ToString()
        {
            return $"[{Type}:\t {(Amount > 1000 ? (Amount.ToString("e3")) : Amount.ToString())}]";
        }
    }
}
