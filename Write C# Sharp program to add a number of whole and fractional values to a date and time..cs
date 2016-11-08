using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] hours = { .98766, .997888, .56544, .5, .90, .8676, .120, .76, .65, .465665, .32344 };
            DateTime DateValue = new DateTime(2016, 8, 23, 15, 34, 00);
            foreach (double hour in hours)
            {
                Console.WriteLine("{0}+{1}hours={2}", DateValue, hour, DateValue.AddHours(hour));
            }
            Console.ReadLine();
        }
    }
}
