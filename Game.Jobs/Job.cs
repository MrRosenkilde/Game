using Game.Resources;
using System;

namespace Game.Jobs
{
    public abstract class Job
    {
        public readonly TimeSpan CompletionTime;
        private TimeSpan Worked = TimeSpan.Zero;
        public double FinishedRatio => Worked.TotalMilliseconds / CompletionTime.TotalMilliseconds;
        public double SpeedMultiplier { get; set; } = 1;
        public event Action<Job> OnJobFinished;

        protected Job(in TimeSpan completionTime)
        {
            CompletionTime = completionTime;
        }

        //public void ApplyNewSpeedMultiplier(float multiplier)
        //    => SpeedMultiplier *= multiplier;

        public virtual void Tick(in TimeSpan deltaTime) {
            Worked += deltaTime * SpeedMultiplier;
            if (Worked >= CompletionTime) {
                OnJobFinished?.Invoke(this);
                Worked -= CompletionTime;
            }
        }
    }
}
