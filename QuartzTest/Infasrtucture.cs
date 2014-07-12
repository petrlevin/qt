using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Practices.Unity;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;

namespace QuartzTest
{
    internal class Infasrtucture : IDisposable
    {
        //private readonly Container _container;
        private readonly IScheduler _scheduler;

        public IScheduler Scheduler
        {
            get { return _scheduler; }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Infasrtucture Register(Action<IUnityContainer> registration)
        {
            return this;
        }

        public Infasrtucture()
        {
            //    _container = new Container();
            //    var schedulerFactory = new StdSchedulerFactory();
            //    _scheduler = schedulerFactory.GetScheduler();
            //    Scheduler.JobFactory = _container;
            //}

            //private class Container : UnityContainer, IJobFactory
            //{
            //    public object Resolve(Type type)
            //    {
            //        return UnityContainerExtensions.Resolve(this, type);
            //    }


            //    public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
            //    {
            //        var data = bundle.JobDetail.JobDataMap.Get(bundle.JobDetail.Key.Name);
            //        if (data!=null)

            //        var result = (IJob) Resolve(bundle.JobDetail.JobType,bundle.JobDetail.Key.Name);
            //        return result;

            //    }

            //    public void ReturnJob(IJob job)
            //    {
            //        throw new NotImplementedException();
            //    }
            //}


        }
    }
}
