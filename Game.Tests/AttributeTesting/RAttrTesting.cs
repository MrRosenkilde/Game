using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Text;
using Game.Resources;
using System.Linq;

namespace Game.Tests.AttributeTesting
{
    [TestClass]
    public class RAttrTesting
    {
        [TestMethod]
        public void CraftingOrEditableReturnsTwoFlags() 
        {
            var flags = (RAttr.Crafting | RAttr.Editable).GetFlags();
            AreEqual(2, flags.Count());
            IsTrue(flags.Contains(RAttr.Crafting));
            IsTrue(flags.Contains(RAttr.Editable));
        }

        [TestMethod]
        public void GetFlagsReturnsTheFlagsOfTheEnum()
        {
            var flags = (RAttr.Dangerous | RAttr.Plant).GetFlags();
            AreEqual(2, flags.Count());
            IsTrue(flags.Contains(RAttr.Dangerous));
            IsTrue(flags.Contains(RAttr.Plant));
        }

        [TestMethod]
        public void Test3()
        {
            var flags = (RAttr.Dangerous | RAttr.Meat | RAttr.Crafting).GetFlags();
            AreEqual(3, flags.Count());
            IsTrue(flags.Contains(RAttr.Dangerous));
            IsTrue(flags.Contains(RAttr.Meat));
            IsTrue(flags.Contains(RAttr.Crafting));
        }
    }
}
