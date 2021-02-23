using Game.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Jobs
{
    public class Hunting : Job
    {
        public Hunting(in TimeSpan completionTime)
            : base(
                completionTime
            )
        {
        }
    }
}
