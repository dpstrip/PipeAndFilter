using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeFilterLib.Interfaces
{
    public abstract class aPipe<T>
    {
        public List<IFilter<T>> pipeLine = new List<IFilter<T>>();
        public T msg;

        public void Register(IFilter<T> filter)
        {
            pipeLine.Add(filter);
        }

        public bool ExecutePipeLine()
        {
            try
            {
                foreach (IFilter<T> filter in pipeLine)
                {
                    filter.Execute(msg);
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }

    }
}
