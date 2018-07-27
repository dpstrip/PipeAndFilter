using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeFilterLib.Interfaces;

namespace PipeProcess
{
    class Filter3 : IFilter<MyMsg>
    {
        public bool Execute(MyMsg msg)
        {
            string m = msg.AMessage;
            m.Reverse();
            m.Insert(3, " I did something else ");
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
