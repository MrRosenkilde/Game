using Game.Resources;
using System;

namespace Game.Jobs
{
    public abstract class Job
    {

        public double FinishedRatio => Worked.TotalMilliseconds / CompletionTime.TotalMilliseconds;
        public readonly TimeSpan CompletionTime;
        private TimeSpan Worked = TimeSpan.Zero;
        public double SpeedMultiplier { get; set; } = 1;
        public event Action<Job> OnJobFinished;

        protected Job(in TimeSpan completionTime)
        {
            CompletionTime = completionTime;
        }

        public virtual void Tick(in TimeSpan deltaTime) {
            Worked += deltaTime * SpeedMultiplier;
            while (Worked >= CompletionTime) {
                OnJobFinished?.Invoke(this);
                Worked -= CompletionTime;
            }
        }
    }
}
