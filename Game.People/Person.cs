using Game.People;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Game.People
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IReadOnlyList<Relation> Relations => relations;
        private List<Relation> relations { get; }
        public Gender Gender { get; set; }

        protected Person(string name, int age, Gender gender, List<Relation> relations = null)
        {
            Name = name;
            Age = age;
            this.relations = relations ?? new List<Relation>();
            Gender = gender;
        }
        
        /// <summary>
        /// Assigns the relation to this character and the inverse relation to the other Person
        /// </summary>
        /// <param name="relatesTo">The other person</param>
        /// <param name="relationType">How this person relates to the other person</param>
        public void AssignNewRelation(Person relatesTo, RelationType relationType)
        {
            var relation = new Relation(this, relatesTo, relationType);
            relations.Add(relation);
            relatesTo.relations.Add(relation.Inverse());
        }
    }
}
