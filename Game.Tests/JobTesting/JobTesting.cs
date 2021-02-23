using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Tests.JobTesting
{
    [TestClass]
    public class JobTesting
    {
        [TestMethod]
        public void OnProgramFinishedIsInvokedWhenDeltaTimeIsBiggerThenCompletionTime() {
            var job = new JobMock(TimeSpan.FromSeconds(2));
            bool passed = false;
            job.OnJobFinished += (job) => passed = true;
            job.Tick(TimeSpan.FromSeconds(3));
            AreEqual(true, passed, "OnJobFinished wasn't invoked");
        }

        [TestMethod]
        public void SpeedMultiplierOf2Makes2SecondJobFinishInOneSecond()
        {
            var job = new JobMock(TimeSpan.FromSeconds(2));
            bool passed = false;
            job.SpeedMultiplier = 2;
            job.OnJobFinished += (job) => passed = true;
            job.Tick(TimeSpan.FromSeconds(1));
            AreEqual(true, passed, "OnJobFinished wasn't invoked");
        }

        [TestMethod]
        public void RandomizedTestFinishedRatio() {
            var r = new Random();
            for (int i = 0; i < 100; i++)
            {
                var cycle_time = r.Next(0, 7200);
                var job = new JobMock(TimeSpan.FromSeconds(cycle_time));
                var acc = 0d;
                for (int j = 0; j < 100_000; j++) 
                {
                    var roll = r.NextDouble();
                    acc += roll / cycle_time;
                    job.Tick(TimeSpan.FromSeconds(roll));
                    AreEqual(acc % 1, job.FinishedRatio, 4);
                }
            }
        }

        [TestMethod]
        public void RandomizedTestFinishedRatioWithSpeedMultiplier()
        {
            var r = new Random();
            for (int i = 0; i < 100; i++)
            {
                var cycle_time = r.Next(0, 7200);
                var job = new JobMock(TimeSpan.FromSeconds(cycle_time));
                var speed_multiplier = r.NextDouble() * 2;
                job.SpeedMultiplier = speed_multiplier;
                var acc = 0d;
                for (int j = 0; j < 100_000; j++)
                {
                    var roll = r.NextDouble();
                    acc += roll / cycle_time * speed_multiplier;
                    job.Tick(TimeSpan.FromSeconds(roll));
                    AreEqual(acc % 1, job.FinishedRatio, 4);
                }
            }
        }
    }
}
