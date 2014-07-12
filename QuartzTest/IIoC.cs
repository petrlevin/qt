using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuartzTest
{
    public interface IIoC
    {
        Object Resolve(Type type);
        Object Resolve(Type type,String name);
    }
}
