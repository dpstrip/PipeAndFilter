using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeFilterLib.Interfaces
{
    public interface IFilter<T>
    {
        /*This is a filter.  All process operations should be in a class
         * that inherits this interface. The class must define the execute 
         * method with items that thi process must go ahead and implement
         */

        bool Execute(T obj);
    }
}
