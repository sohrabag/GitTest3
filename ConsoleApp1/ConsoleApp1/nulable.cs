using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class nulable1
    {
        public  void nullableExamp()
        {
            //nullable type is a value type variable which can be assigned to value null.
            int? num = null;

            if (num.HasValue)
            {
                Console.WriteLine("num value is: {0}", num.Value);
            }
            else { Console.WriteLine("num value is: null"); }

            //set the value of the y to zero
            int y = num.GetValueOrDefault();

            try
            {
                y = num.Value;
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
