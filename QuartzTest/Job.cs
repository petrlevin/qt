using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;

namespace QuartzTest
{
    [PersistJobDataAfterExecution]
    [DisallowConcurrentExecution]
    public class Job : IJob
    {
        private int i;
        public string Color { get; set; }
    
        public void Execute(IJobExecutionContext context)
        {
            //Console.Write("Color {0}",Color);
            Color = Color + ++i;
            Console.WriteLine("{0} Key {1}",Color, context.JobDetail.Key);
            context.JobDetail.JobDataMap.Put("Color", Color);
        }
    }
}
