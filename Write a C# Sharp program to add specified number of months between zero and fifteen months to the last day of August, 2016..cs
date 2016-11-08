using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime9
{
    class Program
    {
        static void Main(string[] args)
        {
            var Date = new DateTime(2016, 8, 31);
            for (int ctr = 0; ctr <= 15; ctr++)
            {
                Console.WriteLine(Date.AddMonths(ctr).ToString("d"));
            }
            Console.ReadLine();
        }
    }
}
