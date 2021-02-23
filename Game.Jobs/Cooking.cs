using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Jobs
{
    public class Cooking : Job
    {
        public Cooking(TimeSpan completionTime) : base(completionTime)
        {
        }
    }
}
