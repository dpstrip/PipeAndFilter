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
            msg.AMessage = Reverse(msg.AMessage);
            viewMessage(msg);
            return true;
        }

        private void viewMessage(MyMsg msg)
        {
            Console.WriteLine("F2: {0}", msg.AMessage);
        }

        private string Reverse(string msg)
        {
            StringBuilder temp = new StringBuilder(msg.Length);
            for (int i = msg.Length - 1; i >= 0; i--)
            {
                temp.Append(msg[i]);
            }
            msg = temp.ToString();
            return msg;
        }
    }
}
