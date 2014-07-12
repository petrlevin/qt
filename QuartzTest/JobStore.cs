using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz.Simpl;

namespace QuartzTest
{
    class XmlJobStore : RAMJobStore 
    {
        public override void StoreJob(Quartz.IJobDetail newJob, bool replaceExisting)
        {
            base.StoreJob(newJob, replaceExisting);
        }
    }
}
