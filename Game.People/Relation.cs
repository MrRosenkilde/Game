using System;
using System.Collections.Generic;
using System.Text;

namespace Game.People
{
    public struct Relation
    {
        public Person Person { get; set; }
        public Person RelatesTo { get; set; }
        public RelationType RelationType { get; set; }

        public Relation(Person person, Person relatesTo, RelationType relationType)
        {
            Person = person;
            RelatesTo = relatesTo;
            RelationType = relationType;
        }

        public Relation Inverse()
            => new Relation(
                RelatesTo, 
                Person, 
                RelationType.RelationTo(RelatesTo)
        );
    }
}
