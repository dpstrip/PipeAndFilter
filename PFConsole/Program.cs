using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeProcess;

namespace PFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IN console.  Will make the pipe class");
            APipeProcess pp = new APipeProcess();
            MyMsg msg = new MyMsg();
            //msg.AMessage = "I wrote a message";
            pp.msg = msg;

            Filter1 f1 = new Filter1();
            pp.Register(f1);
            Filter2 f2 = new Filter2();
            pp.Register(f2);
            Filter3 f3 = new Filter3();
            pp.Register(f3);
            pp.ExecutePipeLine();

            Console.ReadKey();
        }
    }
}
