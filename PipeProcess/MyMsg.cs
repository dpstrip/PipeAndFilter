using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeFilterLib.Interfaces;

namespace PipeProcess
{
    public class MyMsg : IMsg    {
        public string AMessage { get; set; } 
    }
}
