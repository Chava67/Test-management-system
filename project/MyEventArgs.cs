using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class MyEventArgs:EventArgs
    {
        public int Message { get; set; }
        public MyEventArgs(int message)
        {
            this.Message = message;
        }
    }
}
