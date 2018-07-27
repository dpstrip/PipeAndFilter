using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeFilterLib.Interfaces;

namespace PipeProcess
{
    class Filter1 : IFilter<MyMsg>
    {
        public bool Execute(MyMsg msg)
        {
            msg.AMessage = "This is a new message";
            viewMessage(msg);
            return true;
        }

        private void viewMessage(MyMsg msg)
        {
            Console.WriteLine(msg.AMessage);
        }
    }
}
