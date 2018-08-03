using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeFilterLib.Interfaces;

namespace PipeProcess
{
    public class Filter3 : IFilter<MyMsg>
    {
        public bool Execute(MyMsg msg)
        {
            msg.AMessage = msg.AMessage.Insert(3, "I did someting else");
            viewMessage(msg);
            return true;
        }

        private void viewMessage(MyMsg msg)
        {
            Console.WriteLine(msg.AMessage);
        }
    }
}
