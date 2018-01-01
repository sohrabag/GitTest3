using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class nulable2
    {
        public void nulable2Ex()
        {
            int? x = 10; //one can assing value to a nullable type
            double? d = 4.9956;
            Console.WriteLine("x value is: {0} and d value is: {1}", x, d);
            //in case of nullable variable types one can use != and == to check
            //against the null value.
            if (x != null)
                Console.WriteLine("x value is not null.");
            if (x == null)
                Console.WriteLine("value of x is: null");
            // check if value of x is null then assign a default value to y 
            //otherwise assign value of x to variabl y.
            int y = x ?? -1;
        }
    }
}
