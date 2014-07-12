using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Quartz.Impl;

namespace QuartzTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var inf = new Infasrtucture().Register(c=>c.RegisterType())


            ISchedulerFactory schedFact = new StdSchedulerFactory();
            IScheduler sched = schedFact.GetScheduler();
            //sched.Start();
            //sched.



            //sched.GetJobKeys()
            IJobDetail job = sched.GetJobDetail(new JobKey("myJob"));
            
            if (job == null)
                // define the job and tie it to our HelloJob class
                job = JobBuilder.Create<Job>()
                   .WithIdentity("myJob")
                   .UsingJobData("Color", "a")
                   .Build();
            var trigger = sched.GetTrigger(new TriggerKey("myTrigger"));
            if (trigger == null)
            {
                //// Trigger the job to run now, and then every 40 seconds
                trigger = TriggerBuilder.Create()
                    .WithIdentity("myTrigger")
                    .StartNow()
                    .WithCronSchedule("0 0/1 * * * ?")
                    .Build();
                sched.ScheduleJob(job, trigger);
            }
            else
            {
                var cron = trigger as ICronTrigger;
                if (cron==null || cron.CronExpressionString!= "0 0/1 * * * ?")
                    trigger = TriggerBuilder.Create()
                        .WithIdentity("myTrigger")
                        .StartNow()
                        .WithCronSchedule("0 0/1 * * * ?")
                        .Build();
                sched.RescheduleJob(new TriggerKey("myTrigger"), trigger);

            }
            

            ////IJobDetail job1 = JobBuilder.Create<Job>()
            ////    .WithIdentity("myJob1")
            ////    .UsingJobData("Color", "b")
            ////    .Build();

            ////// Trigger the job to run now, and then every 40 seconds
            ////ITrigger trigger1 = TriggerBuilder.Create()
            ////  .WithIdentity("myTrigger1")
            ////  .StartNow()
            ////  .WithSimpleSchedule(x => x
            ////      .WithIntervalInSeconds(4)
            ////      .RepeatForever())
            ////  .Build();

            ////sched.ScheduleJob(job1, trigger1);
            sched.Start();

        }
    }
}
