using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime t1 = new DateTime(2016, 1, 9);
            Console.WriteLine("The day of the week for {0:d} is {1}", t1, t1.DayOfWeek);
            Console.ReadLine();
        }
    }
}
