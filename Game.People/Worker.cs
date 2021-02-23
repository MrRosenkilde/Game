using Game.Jobs;
using Game.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.People
{
    public class Worker : Person
    {
        public Job AssignedJob { get; set; }
        public Worker(string name, int age, Gender gender, Job assignedJob, List<Relation> relations = null) 
            : base(name, age, gender, relations)
        {
            AssignedJob = assignedJob;
        }

                
    }
}
