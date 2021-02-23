using Game.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Game.Tests
{
    [TestClass]
    public class ResourceTesting
    {
        [TestMethod]
        public void EarnGivesResourceAmount()
        {
            Resource sticks = RType.Sticks;
            sticks.Earn(3u);
            AreEqual(3u, sticks.Amount);
        }

        [TestMethod]
        public void SpendingWithoutHavingEnoughReturnsFalseAndDoesnotChangeAmount()
        {
            var sticks = RType.Sticks.ToResource(amount: 5);
            IsFalse(sticks.Spend(10u));
            AreEqual(5u, sticks.Amount);
        }

        [TestMethod]
        public void HasReturnsFalseIfNotEnoughResource() 
        {
            Resource sticks = (5u, RType.Sticks);
            IsFalse(sticks.Has(10u));
            IsTrue(sticks.Has(3u));
        }

        [TestMethod]
        public void SpendingReducesAmountOfResourcesIfTheyAreAvailable() {
            Resource stones = (10u, RType.SmallStones);
            IsTrue(stones.Spend(5u));
            AreEqual(5u, stones.Amount);
        }
    }
}
