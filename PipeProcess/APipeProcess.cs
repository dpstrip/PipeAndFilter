using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeFilterLib;
using PipeFilterLib.Interfaces;

namespace PipeProcess
{
    public class APipeProcess : PipeFilterLib.Interfaces.aPipe<MyMsg>
    {
        MyMsg msg { get; set; } 

        public APipeProcess(MyMsg msg)
        {
            this.msg = msg;
        }

        public APipeProcess()
        {
        }




    }
}
