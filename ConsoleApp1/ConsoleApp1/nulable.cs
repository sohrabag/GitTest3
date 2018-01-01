using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class nulable
    {
        public  void nullableExamp()
        {
            int? num = null;

            if (num.HasValue)
            {
                Console.WriteLine("num value is: {0}", num.Value);
            }
            else { Console.WriteLine("num value is: null"); }
        }
    }
}
