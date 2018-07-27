using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeFilterLib.Interfaces;

namespace PipeProcess
{
    public class Filter2 : IFilter<MyMsg>
    {
        public bool Execute(MyMsg msg)
        {
            string m = msg.AMessage;
            m.Reverse();
            msg.AMessage = m;
            viewMessage(msg);
            return true;
        }

        private void viewMessage(MyMsg msg)
        {
            Console.WriteLine(msg.AMessage);
        }
    }
}
