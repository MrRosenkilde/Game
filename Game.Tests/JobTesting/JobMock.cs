using Game.Jobs;
using System;

namespace Game.Tests.JobTesting
{
    internal class JobMock : Job
    {
        public JobMock(in TimeSpan completionTime) 
            : base(completionTime)
        {
        }
    }
}
