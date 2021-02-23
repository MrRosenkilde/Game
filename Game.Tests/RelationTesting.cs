using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Text;
using Game.People;
using System.Linq;

namespace Game.Tests
{
    [TestClass]
    public class RelationTesting
    {
        [TestMethod]
        public void AssigningCreatesOnesRelationOnBothPeople() 
        {
            var a = new TestPerson(Gender.Female);
            var b = new TestPerson(Gender.Female);
            a.AssignNewRelation(b, RelationType.Mother);
            var relation = a.Relations.First();
            AreEqual(1, a.Relations.Count);
            AreEqual(1, b.Relations.Count);
            AreEqual(b, a.Relations.First().RelatesTo);
            AreEqual(a, b.Relations.First().RelatesTo);
            AreEqual(RelationType.Mother,   a.Relations.First().RelationType);
            AreEqual(RelationType.Daughter, b.Relations.First().RelationType);
            
        }
        [TestMethod]
        public void TestFemaleInverses() 
        {
            var a = new TestPerson(Gender.Female);
            AreEqual(RelationType.Daughter, RelationType.Mother.RelationTo(a));
            AreEqual(RelationType.Mother, RelationType.Daughter.RelationTo(a));
            AreEqual(RelationType.Sister, RelationType.Sister.RelationTo(a));
            AreEqual(RelationType.Sister, RelationType.Brother.RelationTo(a));
        }
        [TestMethod]
        public void TestMaleInverses()
        {
            var a = new TestPerson(Gender.Male);
            AreEqual(RelationType.Son, RelationType.Father.RelationTo(a));
            AreEqual(RelationType.Father, RelationType.Son.RelationTo(a));
            AreEqual(RelationType.Brother, RelationType.Brother.RelationTo(a));
            AreEqual(RelationType.Brother, RelationType.Sister.RelationTo(a));
        }
    }
    internal class TestPerson : Person
    {
        public TestPerson(Gender gender, List<Relation> relations = null) 
            : base("Tester", 18, gender, relations)
        {
        }
    }
}
