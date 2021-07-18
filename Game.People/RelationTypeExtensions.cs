using System;
using System.Collections.Generic;
using System.Text;

namespace Game.People
{
    public static class RelationTypeExtensions
    {
        /// <summary>
        /// Finds the others persons relations to the person that holds the relation
        /// </summary>
        /// <param name="relation">this relation</param>
        /// <param name="other">the person that this relationtype is in regards to</param>
        /// <returns></returns>
        public static RelationType RelationTo(this RelationType relation, Person other)
            => relation switch
            {
                //e.g If i'm a sister and the other person is Female, then it's my sister otherwise it's my brother.
                RelationType.Sister => other.Gender == Gender.Female ? RelationType.Sister : RelationType.Brother,
                RelationType.Brother => other.Gender == Gender.Female ? RelationType.Sister : RelationType.Brother,
                RelationType.Mother => other.Gender == Gender.Female ? RelationType.Daughter : RelationType.Son,
                RelationType.Father => other.Gender == Gender.Female ? RelationType.Daughter : RelationType.Son,
                RelationType.Son => other.Gender == Gender.Female ? RelationType.Mother : RelationType.Father,
                RelationType.Daughter => other.Gender == Gender.Female ? RelationType.Mother : RelationType.Father,
                _ => RelationType.Default //unknown

            };
    }
}
