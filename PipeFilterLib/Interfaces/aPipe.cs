using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeFilterLib.Interfaces
{
    public abstract class aPipe
    {
        public List<IFilter<IMsg>> pipeLine = new List<IFilter<IMsg>>();
        public IMsg msg;

        public void Register(IFilter<IMsg> filter)
        {
            pipeLine.Add(filter);
        }

        public bool ExecutePipeLine()
        {
            try
            {
                foreach (IFilter<IMsg> filter in pipeLine)
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
