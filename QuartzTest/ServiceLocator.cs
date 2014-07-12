using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuartzTest
{
    public static class ServiceLocator
    {
        private static IIoC _container;

        public static void Init(IIoC container)
        {
            _container = container;
        }

        //public Object Resolve(Type type)
        //{
            
        //}
        //public Object Resolve(Type type, String name)
        //{
            
        //}


    }
}
