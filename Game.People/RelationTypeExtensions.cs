using System;
using System.Collections.Generic;
using System.Text;

namespace Game.People
{
    public static class RelationTypeExtensions
    {
        /// <summary>
        /// Finds the inverse of the relationship with the other person
        /// </summary>
        /// <param name="relation">this relation</param>
        /// <param name="other">the person that this relationtype is in regards to</param>
        /// <returns></returns>
        public static RelationType RelationTo(this RelationType relation, Person other)
            => relation switch
            {
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
