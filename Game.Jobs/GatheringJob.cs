using Game.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using Range = Game.Shared.Range;

namespace Game.Jobs
{
    public class GatheringJob : Job
    {
        private readonly Dictionary<RType, Range> GatherableResources;
        //new Dictionary<RType, Range>() {
        //    { RType.Sticks, (0, 10) },
        //    { RType.SmallStones, (0, 10) },
        //    { RType.Grass,  (0, 5)  },

        //};
        public event Action<GatheringJob, Resource[]> OnGatheringJobFinished;
        public GatheringJob(Dictionary<RType, Range> gatherableResources, float secondsCompletionTime) 
            : base(
                TimeSpan.FromSeconds(secondsCompletionTime)
            )
        {
            GatherableResources = gatherableResources;
            base.OnJobFinished += GatheringOnJobFinished;
            
        }

        private void GatheringOnJobFinished(Job _)
        {
            throw new NotImplementedException();
        }
    }
}
